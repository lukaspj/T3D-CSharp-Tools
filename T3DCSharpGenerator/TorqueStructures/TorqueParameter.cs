using Newtonsoft.Json.Linq;

namespace T3DCSharpGenerator.TorqueStructures
{
   internal class TorqueParameter
   {
      public TorqueParameter(JObject jObject)
      {
         Type = new TorqueType(jObject["Type"].ToString());
         Name = jObject["Name"].ToString();
         DefaultValue = jObject["DefaultValue"].ToString();
         VarArgs = jObject["VarArgs"].ToObject<bool>();

         RenameIfReserved();
         ValidateDefaultValue();
      }

      public TorqueParameter(TorqueType type, string name, string defaultValue, bool varargs)
      {
         Type = type;
         Name = name;
         DefaultValue = defaultValue;
         VarArgs = varargs;

         RenameIfReserved();
         ValidateDefaultValue();
      }

      public bool VarArgs { get; set; }

      public string DefaultValue { get; set; }

      public string Name { get; set; }

      public TorqueType Type { get; set; }

      private void ValidateDefaultValue()
      {
         DefaultValue = DefaultValue.Trim();
         switch (DefaultValue)
         {
            case "NULL":
               DefaultValue = "null";
               break;
         }
         if (DefaultValue.StartsWith("MB"))
         {
            DefaultValue = "MBButtons." + DefaultValue.Substring(2);
         }
         if (DefaultValue.StartsWith("MI"))
         {
            DefaultValue = "MBIcons." + DefaultValue.Substring(2);
         }
         if (DefaultValue.Equals("S32_MAX"))
         {
            DefaultValue = int.MaxValue.ToString();
         }
      }

      private void RenameIfReserved()
      {
         switch (Name)
         {
            case "string":
               Name = "_string";
               break;
            case "object":
               Name = "_object";
               break;
            case "checked":
               Name = "_checked";
               break;
            case "lock":
               Name = "_lock";
               break;
            case "params":
               Name = "_params";
               break;
         }
      }
   }
}