using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacPlaneData : GameBaseData
	{
		public afxZodiacPlaneData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacPlaneData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacPlaneData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacPlaneData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacPlaneData(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacPlaneData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacPlaneData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacPlaneData_create();
         private static _afxZodiacPlaneData_create _afxZodiacPlaneData_createFunc;
         internal static IntPtr afxZodiacPlaneData_create()
         {
         	if (_afxZodiacPlaneData_createFunc == null)
         	{
         		_afxZodiacPlaneData_createFunc =
         			(_afxZodiacPlaneData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacPlaneData_create"), typeof(_afxZodiacPlaneData_create));
         	}
         
         	return  _afxZodiacPlaneData_createFunc();
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
      
         public afxZodiacPlane_BlendType Blend
         {
         	get { return (afxZodiacPlane_BlendType)Enum.Parse(typeof(afxZodiacPlane_BlendType), getFieldValue("Blend"), true); }
         	set { setFieldValue("Blend", value.ToString()); }
         }
      
         public bool TrackOrientConstraint
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TrackOrientConstraint")); }
         	set { setFieldValue("TrackOrientConstraint", value ? "1" : "0"); }
         }
      
         public bool DoubleSided
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DoubleSided")); }
         	set { setFieldValue("DoubleSided", value ? "1" : "0"); }
         }
      
         public afxZodiacPlane_FacingType FaceDir
         {
         	get { return (afxZodiacPlane_FacingType)Enum.Parse(typeof(afxZodiacPlane_FacingType), getFieldValue("FaceDir"), true); }
         	set { setFieldValue("FaceDir", value.ToString()); }
         }
      
         public bool UseFullTransform
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseFullTransform")); }
         	set { setFieldValue("UseFullTransform", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}