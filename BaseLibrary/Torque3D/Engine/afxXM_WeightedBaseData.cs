using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WeightedBaseData : afxXM_BaseData
	{
		public afxXM_WeightedBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WeightedBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WeightedBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WeightedBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WeightedBaseData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WeightedBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WeightedBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WeightedBaseData_create();
         private static _afxXM_WeightedBaseData_create _afxXM_WeightedBaseData_createFunc;
         internal static IntPtr afxXM_WeightedBaseData_create()
         {
         	if (_afxXM_WeightedBaseData_createFunc == null)
         	{
         		_afxXM_WeightedBaseData_createFunc =
         			(_afxXM_WeightedBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WeightedBaseData_create"), typeof(_afxXM_WeightedBaseData_create));
         	}
         
         	return  _afxXM_WeightedBaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Delay
         {
         	get { return float.Parse(getFieldValue("Delay")); }
         	set { setFieldValue("Delay", value.ToString()); }
         }
      
         public float Lifetime
         {
         	get { return float.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public float FadeInTime
         {
         	get { return float.Parse(getFieldValue("FadeInTime")); }
         	set { setFieldValue("FadeInTime", value.ToString()); }
         }
      
         public float FadeOutTime
         {
         	get { return float.Parse(getFieldValue("FadeOutTime")); }
         	set { setFieldValue("FadeOutTime", value.ToString()); }
         }
      
         public Point2F FadeInEase
         {
         	get { return new Point2F(getFieldValue("FadeInEase")); }
         	set { setFieldValue("FadeInEase", value.ToString()); }
         }
      
         public Point2F FadeOutEase
         {
         	get { return new Point2F(getFieldValue("FadeOutEase")); }
         	set { setFieldValue("FadeOutEase", value.ToString()); }
         }
      
         public float LifetimeBias
         {
         	get { return float.Parse(getFieldValue("LifetimeBias")); }
         	set { setFieldValue("LifetimeBias", value.ToString()); }
         }
      
      
      #endregion

	}
}