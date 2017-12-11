using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxT3DLightBaseData : GameBaseData
	{
		public afxT3DLightBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxT3DLightBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxT3DLightBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxT3DLightBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxT3DLightBaseData(SimObject pObj) : base(pObj)
		{
		}

		public afxT3DLightBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxT3DLightBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxT3DLightBaseData_create();
         private static _afxT3DLightBaseData_create _afxT3DLightBaseData_createFunc;
         internal static IntPtr afxT3DLightBaseData_create()
         {
         	if (_afxT3DLightBaseData_createFunc == null)
         	{
         		_afxT3DLightBaseData_createFunc =
         			(_afxT3DLightBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxT3DLightBaseData_create"), typeof(_afxT3DLightBaseData_create));
         	}
         
         	return  _afxT3DLightBaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool IsEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsEnabled")); }
         	set { setFieldValue("IsEnabled", value ? "1" : "0"); }
         }
      
         public LinearColorF Color
         {
         	get { return new LinearColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public float Brightness
         {
         	get { return float.Parse(getFieldValue("Brightness")); }
         	set { setFieldValue("Brightness", value.ToString()); }
         }
      
         public bool CastShadows
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CastShadows")); }
         	set { setFieldValue("CastShadows", value ? "1" : "0"); }
         }
      
         public float Priority
         {
         	get { return float.Parse(getFieldValue("Priority")); }
         	set { setFieldValue("Priority", value.ToString()); }
         }
      
         public bool LocalRenderViz
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LocalRenderViz")); }
         	set { setFieldValue("LocalRenderViz", value ? "1" : "0"); }
         }
      
         public bool Animate
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Animate")); }
         	set { setFieldValue("Animate", value ? "1" : "0"); }
         }
      
         public LightAnimData AnimationType
         {
         	get { return Sim.FindObject<LightAnimData>(getFieldValue("AnimationType")); }
         	set { setFieldValue("AnimationType", value.getId().ToString()); }
         }
      
         public float AnimationPeriod
         {
         	get { return float.Parse(getFieldValue("AnimationPeriod")); }
         	set { setFieldValue("AnimationPeriod", value.ToString()); }
         }
      
         public float AnimationPhase
         {
         	get { return float.Parse(getFieldValue("AnimationPhase")); }
         	set { setFieldValue("AnimationPhase", value.ToString()); }
         }
      
         public LightFlareData FlareType
         {
         	get { return Sim.FindObject<LightFlareData>(getFieldValue("FlareType")); }
         	set { setFieldValue("FlareType", value.getId().ToString()); }
         }
      
         public float FlareScale
         {
         	get { return float.Parse(getFieldValue("FlareScale")); }
         	set { setFieldValue("FlareScale", value.ToString()); }
         }
      
      
      #endregion

	}
}