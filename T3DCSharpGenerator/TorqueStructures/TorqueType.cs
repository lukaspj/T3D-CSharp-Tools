using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace T3DCSharpGenerator.TorqueStructures
{
   class TorqueType
   {
      public static List<string> ClassNames = new List<string>();

      public TorqueType(string type)
      {
         // Convert from a console type to a C# type
         switch (type)
         {
            case "vector":
               ManagedType = "VectorF";
               NativeReturnType = "VectorF";
               NativeArgType = "VectorF";
               break;
            case "WorldEditor::AlignmentType":
               ManagedType = "AlignmentType";
               NativeReturnType = "AlignmentType";
               NativeArgType = "AlignmentType";
               break;
            case "Camera::CameraMotionMode":
               ManagedType = "CameraMotionMode";
               NativeReturnType = "CameraMotionMode";
               NativeArgType = "CameraMotionMode";
               break;
            case "SFXDistanceModel":
            case "SFXStatus":
            case "GuiGraphType":
            case "GFXFormat":
            case "MBButtons":
            case "MBIcons":
            case "void":
            case "bool":
            case "int":
            case "uint":
            case "float":
               ManagedType = type;
               NativeReturnType = type;
               NativeArgType = type;
               break;
            case "const char*":
            case "const char *":
            case "string":
            case "String":
               ManagedType = "string";
               NativeReturnType = "IntPtr";
               NativeArgType = "string";
               break;
            case "U8":
               ManagedType = "byte";
               NativeReturnType = "byte";
               NativeArgType = "byte";
               break;
            case "S8":
               ManagedType = "sbyte";
               NativeReturnType = "sbyte";
               NativeArgType = "sbyte";
               break;
            case "S32":
               ManagedType = "int";
               NativeReturnType = "int";
               NativeArgType = "int";
               break;
            case "SimObjectId":
               ManagedType = "uint";
               NativeReturnType = "uint";
               NativeArgType = "uint";
               break;
            case "F32":
               ManagedType = "float";
               NativeReturnType = "float";
               NativeArgType = "float";
               break;
            case "ColorI":
               ManagedType = type;
               NativeReturnType = "InternalColorIStruct";
               NativeArgType = "InternalColorIStruct";
               break;
            case "RectSpacingI":
               ManagedType = type;
               NativeReturnType = "InternalRectSpacingIStruct";
               NativeArgType = "InternalRectSpacingIStruct";
               break;
            case "RectI":
               ManagedType = type;
               NativeReturnType = "InternalRectIStruct";
               NativeArgType = "InternalRectIStruct";
               break;
            case "Point3I":
            case "Point2I":
               ManagedType = type;
               NativeReturnType = "int[]";
               NativeArgType = "int[]";
               break;
            case "VectorF":
            case "AngAxisF":
            case "Box3F":
            case "Point3F":
            case "Point2F":
            case "MatrixF":
               ManagedType = type;
               NativeReturnType = "float[]";
               NativeArgType = "float[]";
               break;
            case "ColorF":
               ManagedType = type;
               NativeReturnType = "InternalColorFStruct";
               NativeArgType = "InternalColorFStruct";
               break;
            case "TransformF":
               ManagedType = type;
               NativeReturnType = "InternalTransformStruct";
               NativeArgType = "InternalTransformStruct";
               break;
            case "Torque::UUID":
               ManagedType = "UUID";
               NativeReturnType = "InternalUUIDStruct";
               NativeArgType = "InternalUUIDStruct";
               break;
            default:
               if (!ClassNames.Contains(type) && !ClassNames.Contains(type.Replace("*", "")))
                  throw new NotImplementedException("Not handling type: " + type);
               ManagedType = type.Replace("*", "");
               NativeReturnType = "IntPtr";
               NativeArgType = "IntPtr";
               break;
         }
      }

      public bool IsVoid => ManagedType == "void";

      public string NativeArgType { get; set; }

      public string NativeReturnType { get; set; }

      public string ManagedType { get; set; }

      public string GetReturnString(string stmt)
      {
         // Marshal specific types before returning
         if (NativeReturnType == "IntPtr" && ManagedType == "string")
         {
            return $"Marshal.PtrToStringUni({stmt})";
         }
         if (NativeReturnType == "IntPtr" && ManagedType != "IntPtr")
         {
            if (ManagedType == "SimObjectPtr*")
            {
               return $"(SimObjectPtr*){stmt}";
            }
            return $"new {ManagedType}({stmt})";
         }
         if (NativeReturnType == "IntPtr[]" && ManagedType == "SimObject[]")
         {
            return $"{stmt}.Select(x => new SimObject(x)).ToArray()";
         }
         if ((ManagedType != "float[]" && NativeReturnType == "float[]")
             || NativeReturnType == "InternalColorFStruct"
             || NativeReturnType == "InternalColorIStruct"
             || NativeReturnType == "InternalRectIStruct"
             || NativeReturnType == "InternalRectSpacingIStruct"
             || (ManagedType != "int[]" && NativeReturnType == "int[]")
             || (ManagedType != "char[]" && NativeReturnType == "char[]"))
         {
            // Assume it's a class like Point3F
            return $"new {ManagedType}({stmt})";
         }
         if (NativeReturnType == "InternalTransformStruct")
         {
            return $"new TransformF({stmt})";
         }
         if (NativeReturnType == "InternalUUIDStruct")
         {
            return $"new UUID({stmt})";
         }
         return stmt;
      }

      public string GetArg(string name)
      {
         // Marshal specific types for sending to C++
         if (NativeArgType == "IntPtr" && ManagedType != "IntPtr")
         {
            return $"{name}.ObjectPtr->RefPtr->ObjPtr";
         }
         if (ManagedType == "SimObject[]")
         {
            return $"{name}.Select(x => x.ObjectPtr->RefPtr->ObjPtr).ToArray()";
         }
         if ((ManagedType != "float[]" && NativeReturnType == "float[]")
             || (ManagedType != "int[]" && NativeReturnType == "int[]")
             || (ManagedType != "char[]" && NativeReturnType == "char[]"))
         {
            // Assume it's a class like Point3F
            return $"{name}.ToArray()";
         }
         if (NativeReturnType == "InternalTransformStruct"
             || NativeReturnType == "InternalColorFStruct"
             || NativeReturnType == "InternalColorIStruct"
             || NativeReturnType == "InternalRectIStruct"
             || NativeReturnType == "InternalRectSpacingIStruct"
             || NativeReturnType == "InternalUUIDStruct")
         {
            return $"{name}.ToStruct()";
         }

         return name;
      }

      public static void RegisterClasses(JArray classes)
      {
         classes.ToList().ForEach(x => ClassNames.Add(x["ClassName"].ToString()));
      }
   }
}