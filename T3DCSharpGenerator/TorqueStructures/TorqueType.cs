using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace T3DCSharpGenerator.TorqueStructures
{
    class TorqueType
    {
        public static List<string> ClassNames = new List<string>();

        public TorqueType(string type)
        {
            DataType = DataType.Object;
            // Convert from a console type to a C# type
            switch (type)
            {
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
                case "GuiIconButtonTextLocation":
                case "GuiIconButtonIconLocation":
                case "WorldEditorAlignmentType":
                case "GuiAutoScrollDirection":
                case "MarkerSmoothingType":
                case "MarkerKnotType":
                case "GuiHorizontalStackingType":
                case "GuiVerticalStackingType":
                case "GuiStackingType":
                case "WorldEditorDropType":
                case "GuiHorizontalSizing":
                case "GuiScrollBarBehavior":
                case "GuiTheoraTranscoder":
                case "GuiGradientPickMode":
                case "GuiSplitOrientation":
                case "GuiSplitFixedPanel":
                case "GuiVerticalSizing":
                case "GuiTSRenderStyles":
                case "GuiSeparatorType":
                case "SFXDistanceModel":
                case "GuiColorPickMode":
                case "GuiFontCharset":
                case "CameraMotionMode":
                case "GuiTabPosition":
                case "GuiBitmapMode":
                case "GuiFrameState":
                case "GuiDockingType":
                case "GuiButtonType":
                case "GuiAlignmentType":
                case "TSMeshType":
                case "ShadowType":
                case "SFXStatus":
                case "GuiGraphType":
                case "GFXFormat":
                case "GFXAdapterType":
                case "GFXBlend":
                case "GFXCmpFunc":
                case "GFXTextureAddressMode":
                case "GFXTextureFilterType":
                case "GFXTextureOp":
                case "GFXTextureArgument":
                case "GFXTextureTransformFlags":
                case "GFXCullMode":
                case "GFXStencilOp":
                case "GFXBlendOp":
                case "MBButtons":
                case "baseTexFormat":
                case "CoverPointSize":
                case "NavMeshWaterMethod":
                case "PFXRenderTime":
                case "PFXTargetClear":
                case "PFXTargetViewport":
                case "SFXPlayListLoopMode":
                case "SFXPlayListRandomMode":
                case "SFXPlayListTransitionMode":
                case "SFXPlayListReplayMode":
                case "SFXPlayListStateMode":
                case "TurretShapeFireLinkType":
                case "ItemLightType":
                case "PhysicsSimType":
                case "ShapeBaseImageLoadedState":
                case "ShapeBaseImageSpinState":
                case "ShapeBaseImageRecoilState":
                case "ShapeBaseImageLightType":
                case "ParticleBlendStyle":
                case "MaterialAnimType":
                case "MaterialBlendOp":
                case "MaterialWaveType":
                case "GizmoAlignment":
                case "GizmoMode":
                case "SFXChannel":
                case "ForestBrushMode":
                case "LogLevel":
                case "TSShapeConstructorUpAxis":
                case "TSShapeConstructorLodType":
                case "_TamlFormatMode":
                case "MBIcons":
                case "PhysicalZone_ForceType":
                case "CollisionMeshMeshType":
                case "afxBillboard_BlendStyle":
                case "afxBillboard_TexFuncType":
                case "afxParticleEmitterPath_OriginType":
                case "afxPlayerMovement_OpType":
                case "afxProjectile_LaunchDirType":
                case "afxZodiac_BlendType":
                case "afxZodiacPlane_BlendType":
                case "afxZodiacPlane_FacingType":
                case "afxXM_WaveFormType":
                case "afxXM_WaveParamType":
                case "afxXM_WaveOpType":
                case "afxXM_BoxConformType":
                case "afxRPGMagicSpell_TargetType":
                case "afxParticlePool_PoolType":
                case "afxPhraseEffect_MatchType":
                case "afxPhraseEffect_StateType":
                case "afxPhraseEffect_PhraseType":
                    ManagedType = type;
                    NativeReturnType = type;
                    NativeArgType = type;
                    DataType = DataType.Enum;
                    break;
                case "void":
                case "bool":
                case "int":
                case "uint":
                case "float":
                    ManagedType = type;
                    NativeReturnType = type;
                    NativeArgType = type;
                    DataType = DataType.Primitive;
                    break;
                case "char":
                case "U8":
                    ManagedType = "byte";
                    NativeReturnType = "byte";
                    NativeArgType = "byte";
                    DataType = DataType.Primitive;
                    break;
                case "S8":
                    ManagedType = "sbyte";
                    NativeReturnType = "sbyte";
                    NativeArgType = "sbyte";
                    DataType = DataType.Primitive;
                    break;
                case "S32":
                    ManagedType = "int";
                    NativeReturnType = "int";
                    NativeArgType = "int";
                    DataType = DataType.Primitive;
                    break;
                case "F32":
                    ManagedType = "float";
                    NativeReturnType = "float";
                    NativeArgType = "float";
                    DataType = DataType.Primitive;
                    break;
                case "filename":
                case "caseString":
                case "const char*":
                case "const char *":
                case "string":
                case "String":
                    ManagedType = "string";
                    NativeReturnType = "IntPtr";
                    NativeArgType = "string";
                    break;
                case "SimObjectId":
                    ManagedType = "uint";
                    NativeReturnType = "uint";
                    NativeArgType = "uint";
                    break;
                case "Point3I":
                case "Point2I":
                    ManagedType = type;
                    NativeReturnType = "int[]";
                    NativeArgType = "int[]";
                    break;
                case "vector":
                    ManagedType = "VectorF";
                    NativeReturnType = "VectorF";
                    NativeArgType = "VectorF";
                    break;
                case "MatrixRotation":
                    ManagedType = "AngAxisF";
                    NativeReturnType = $"Internal{ManagedType}Struct";
                    NativeArgType = $"Internal{ManagedType}Struct";
                    break;
                    ;
                case "MatrixPosition":
                    ManagedType = "Point3F";
                    NativeReturnType = $"Internal{ManagedType}Struct";
                    NativeArgType = $"Internal{ManagedType}Struct";
                    break;
                case "ColorI":
                case "RectSpacingI":
                case "RectI":
                case "RectF":
                case "ColorF":
                case "LinearColorF":
                case "TransformF":
                case "EaseF":
                case "Point4F":
                case "AngAxisF":
                case "RotationF":
                case "Box3F":
                case "Point3F":
                case "Point2F":
                case "MatrixF":
                case "ByteRange":
                    ManagedType = type;
                    NativeReturnType = $"Internal{ManagedType}Struct";
                    NativeArgType = $"Internal{ManagedType}Struct";
                    DataType = DataType.Struct;
                    break;
                case "VectorF":
                case "EulerF":
                    ManagedType = type;
                    NativeReturnType = $"InternalPoint3FStruct";
                    NativeArgType = $"InternalPoint3FStruct";
                    DataType = DataType.Struct;
                    break;
                case "Torque::UUID":
                    ManagedType = "UUID";
                    NativeReturnType = $"Internal{ManagedType}Struct";
                    NativeArgType = $"Internal{ManagedType}Struct";
                    DataType = DataType.Struct;
                    break;
                case "intList":
                case "floatList":
                case "pid":
                case "assetIdString":
                    ManagedType = "string";
                    NativeReturnType = "string";
                    NativeArgType = "string";
                    break;
                case "GameObjectAssetPtr":
                case "ComponentAssetPtr":
                    ManagedType = "string";
                    NativeReturnType = "string";
                    NativeArgType = "string";
                    break;
                case "deprecated":
                    throw new FieldDeprecatedException(type);
                default:
                    if (!ClassNames.Contains(type) && !ClassNames.Contains(type.Replace("*", "")))
                        throw new NotImplementedException("Not handling type: " + type);
                    DataType = DataType.SimObject;
                    ManagedType = type.Replace("*", "");
                    NativeReturnType = "IntPtr";
                    NativeArgType = "IntPtr";
                    break;
            }
        }

        internal string GetReturnMarshalling()
        {
            if (NativeReturnType == "bool")
            {
                return "[return: MarshalAs(UnmanagedType.I1)]";
            }
            return "";
        }

        public DataType DataType { get; set; }

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
                || DataType == DataType.Struct
                || (ManagedType != "int[]" && NativeReturnType == "int[]")
                || (ManagedType != "char[]" && NativeReturnType == "char[]"))
            {
                // Assume it's a class like Point3F
                return $"new {ManagedType}({stmt})";
            }
            return stmt;
        }

        public string GetArg(string name)
        {
            // Marshal specific types for sending to C++
            if (NativeArgType == "IntPtr" && ManagedType != "IntPtr")
            {
                return $"{name}.ObjectPtr";
            }
            if (ManagedType == "SimObject[]")
            {
                return $"{name}.Select(x => x.ObjectPtr).ToArray()";
            }
            if ((ManagedType != "float[]" && NativeReturnType == "float[]")
                || (ManagedType != "int[]" && NativeReturnType == "int[]")
                || (ManagedType != "char[]" && NativeReturnType == "char[]"))
            {
                // Assume it's a class like Point3F
                return $"{name}.ToArray()";
            }
            if (DataType == DataType.Struct)
            {
                return $"{name}.ToStruct()";
            }

            return name;
        }

        public string ToString(string name)
        {
            if (DataType == DataType.SimObject)
            {
                return $"{name}.getId().ToString()";
            }

            switch (ManagedType)
            {
                case "string":
                    return name;
                case "bool":
                    return $"{name} ? \"1\" : \"0\"";
                default:
                    return $"{name}.ToString()";
            }
        }

        public string FromString(string name)
        {
            if (ClassNames.Contains(ManagedType))
            {
                return $"Sim.FindObject<{ManagedType}>({name})";
            }

            if (DataType == DataType.Enum)
            {
                return $"({ManagedType})Enum.Parse(typeof({ManagedType}), {name}, true)";
            }

            switch (ManagedType)
            {
                case "bool":
                    return $"GenericMarshal.StringToBool({name})";
                case "string":
                    return name;
                case "int":
                case "float":
                case "double":
                case "byte":
                    return $"{ManagedType}.Parse({name})";
                default:
                    return $"new {ManagedType}({name})";
            }
        }

        public static void RegisterClasses(JArray classes)
        {
            classes.ToList().ForEach(x => ClassNames.Add(x["ClassName"].ToString()));
        }
    }

    internal enum DataType
    {
        Enum,
        Object,
        Struct,
        SimObject,
        Primitive
    }
}