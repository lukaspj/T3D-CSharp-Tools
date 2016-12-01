using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace T3DCSharpGenerator.TorqueStructures
{
   internal class TorqueFunction
   {
      public TorqueFunction(JObject jObject)
      {
         Namespace = jObject["Namespace"]?.ToString();
         Type = new TorqueType(jObject["Type"].ToString());
         Name = jObject["Name"].ToString();
         Comment = jObject["Comment"].ToString();
         Parameters = ((JArray) jObject["Parameters"]).Select(x => new TorqueParameter((JObject) x)).ToList();
         IsStringlyTyped = jObject["IsStringlyTyped"]?.ToObject<bool>();
         RenameIfReserved();
      }

      public bool? IsStringlyTyped { get; set; }

      public string RealName { get; set; }

      public List<TorqueParameter> Parameters { get; set; }

      public string Comment { get; set; }

      public string Name { get; set; }

      public TorqueType Type { get; set; }

      public string Namespace { get; set; }

      private void RenameIfReserved()
      {
         RealName = Name;
         switch (Name)
         {
            case "sizeof":
               Name = "sizeOf";
               break;
         }
      }

      public string GetArgsString()
      {
         string argsString = Parameters.Aggregate("", (x, y) =>
         {
            if (y.VarArgs) return $"{x}, {y.Name}.Length, {y.Name}";
            return $"{x}, {y.Type.GetArg(y.Name)}";
         });
         if (argsString.Length > 0)
         {
            argsString = argsString.Substring(2);
         }
         return argsString;
      }

      public string GetParametersString()
      {
         string paramString = Parameters.Aggregate("", (x, y) =>
         {
            if (y.VarArgs) x += $", params {y.Type.ManagedType}[] {y.Name}";
            else x += $", {y.Type.ManagedType} {y.Name}";
            if (string.IsNullOrEmpty(y.DefaultValue)) return x;
            if (y.DefaultValue.Contains("::")) x += " = null";
            else x += " = " + y.DefaultValue;
            return x;
         });
         if (paramString.Length > 0)
         {
            paramString = paramString.Substring(2);
         }
         return paramString;
      }

      public string GetNativeParametersString(bool unicode = false)
      {
         if (IsStringlyTyped != null && IsStringlyTyped.Value)
         {
            return "int argc, string[] argv";
         }
         string paramString = Parameters.Aggregate("", (x, y) =>
         {
            string marshalling = "";

            // Some parts of Torque use Unicode.
            if (unicode && y.Type.NativeArgType == "string")
            {
               marshalling = "[MarshalAs(UnmanagedType.LPWStr)]";
            }
            if (y.VarArgs) return $"{x}, int {y.Name}_c, {y.Type.NativeArgType}[] {y.Name}_v";
            return $"{x}, {marshalling}{y.Type.NativeArgType} {y.Name}";
         });
         if (paramString.Length > 0)
         {
            paramString = paramString.Substring(2);
         }
         return paramString;
      }

      public string GetNativeArgsString()
      {
         if (IsStringlyTyped != null && IsStringlyTyped.Value)
         {
            return "argc, argv";
         }
         string argString = Parameters.Aggregate("", (x, y) =>
         {
            if (y.VarArgs) return $"{x}, {y.Name}_c, {y.Name}_v";
            return $"{x}, {y.Name}";
         });
         if (argString.Length > 0)
         {
            argString = argString.Substring(2);
         }
         return argString;
      }
   }
}