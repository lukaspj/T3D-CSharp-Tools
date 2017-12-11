using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacData : GameBaseData
	{
		public afxZodiacData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacData(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacData_create();
         private static _afxZodiacData_create _afxZodiacData_createFunc;
         internal static IntPtr afxZodiacData_create()
         {
         	if (_afxZodiacData_createFunc == null)
         	{
         		_afxZodiacData_createFunc =
         			(_afxZodiacData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacData_create"), typeof(_afxZodiacData_create));
         	}
         
         	return  _afxZodiacData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Texture
         {
         	get { return getFieldValue("Texture"); }
         	set { setFieldValue("Texture", value); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public Point2F VerticalRange
         {
         	get { return new Point2F(getFieldValue("VerticalRange")); }
         	set { setFieldValue("VerticalRange", value.ToString()); }
         }
      
         public bool ScaleVerticalRange
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ScaleVerticalRange")); }
         	set { setFieldValue("ScaleVerticalRange", value ? "1" : "0"); }
         }
      
         public float StartAngle
         {
         	get { return float.Parse(getFieldValue("StartAngle")); }
         	set { setFieldValue("StartAngle", value.ToString()); }
         }
      
         public float RotationRate
         {
         	get { return float.Parse(getFieldValue("RotationRate")); }
         	set { setFieldValue("RotationRate", value.ToString()); }
         }
      
         public float GrowInTime
         {
         	get { return float.Parse(getFieldValue("GrowInTime")); }
         	set { setFieldValue("GrowInTime", value.ToString()); }
         }
      
         public float ShrinkOutTime
         {
         	get { return float.Parse(getFieldValue("ShrinkOutTime")); }
         	set { setFieldValue("ShrinkOutTime", value.ToString()); }
         }
      
         public float GrowthRate
         {
         	get { return float.Parse(getFieldValue("GrowthRate")); }
         	set { setFieldValue("GrowthRate", value.ToString()); }
         }
      
         public LinearColorF Color
         {
         	get { return new LinearColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public afxZodiac_BlendType Blend
         {
         	get { return (afxZodiac_BlendType)Enum.Parse(typeof(afxZodiac_BlendType), getFieldValue("Blend"), true); }
         	set { setFieldValue("Blend", value.ToString()); }
         }
      
         public bool ShowOnTerrain
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowOnTerrain")); }
         	set { setFieldValue("ShowOnTerrain", value ? "1" : "0"); }
         }
      
         public bool ShowOnInteriors
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowOnInteriors")); }
         	set { setFieldValue("ShowOnInteriors", value ? "1" : "0"); }
         }
      
         public bool ShowInReflections
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowInReflections")); }
         	set { setFieldValue("ShowInReflections", value ? "1" : "0"); }
         }
      
         public bool ShowInNonReflections
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowInNonReflections")); }
         	set { setFieldValue("ShowInNonReflections", value ? "1" : "0"); }
         }
      
         public bool TrackOrientConstraint
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TrackOrientConstraint")); }
         	set { setFieldValue("TrackOrientConstraint", value ? "1" : "0"); }
         }
      
         public bool InteriorHorizontalOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InteriorHorizontalOnly")); }
         	set { setFieldValue("InteriorHorizontalOnly", value ? "1" : "0"); }
         }
      
         public bool InteriorIgnoreVertical
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InteriorIgnoreVertical")); }
         	set { setFieldValue("InteriorIgnoreVertical", value ? "1" : "0"); }
         }
      
         public bool InteriorIgnoreBackfaces
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InteriorIgnoreBackfaces")); }
         	set { setFieldValue("InteriorIgnoreBackfaces", value ? "1" : "0"); }
         }
      
         public bool InteriorIgnoreOpaque
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InteriorIgnoreOpaque")); }
         	set { setFieldValue("InteriorIgnoreOpaque", value ? "1" : "0"); }
         }
      
         public bool InteriorIgnoreTransparent
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InteriorIgnoreTransparent")); }
         	set { setFieldValue("InteriorIgnoreTransparent", value ? "1" : "0"); }
         }
      
         public float AltitudeMax
         {
         	get { return float.Parse(getFieldValue("AltitudeMax")); }
         	set { setFieldValue("AltitudeMax", value.ToString()); }
         }
      
         public float AltitudeFalloff
         {
         	get { return float.Parse(getFieldValue("AltitudeFalloff")); }
         	set { setFieldValue("AltitudeFalloff", value.ToString()); }
         }
      
         public bool AltitudeShrinks
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AltitudeShrinks")); }
         	set { setFieldValue("AltitudeShrinks", value ? "1" : "0"); }
         }
      
         public bool AltitudeFades
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AltitudeFades")); }
         	set { setFieldValue("AltitudeFades", value ? "1" : "0"); }
         }
      
         public float DistanceMax
         {
         	get { return float.Parse(getFieldValue("DistanceMax")); }
         	set { setFieldValue("DistanceMax", value.ToString()); }
         }
      
         public float DistanceFalloff
         {
         	get { return float.Parse(getFieldValue("DistanceFalloff")); }
         	set { setFieldValue("DistanceFalloff", value.ToString()); }
         }
      
         public bool UseGradientRange
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseGradientRange")); }
         	set { setFieldValue("UseGradientRange", value ? "1" : "0"); }
         }
      
         public bool PreferDestinationGradients
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PreferDestinationGradients")); }
         	set { setFieldValue("PreferDestinationGradients", value ? "1" : "0"); }
         }
      
         public Point2F GradientRange
         {
         	get { return new Point2F(getFieldValue("GradientRange")); }
         	set { setFieldValue("GradientRange", value.ToString()); }
         }
      
         public bool InvertGradientRange
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InvertGradientRange")); }
         	set { setFieldValue("InvertGradientRange", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}