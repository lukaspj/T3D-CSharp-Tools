using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_SpinData : afxXM_WeightedBaseData
	{
		public afxXM_SpinData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_SpinData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_SpinData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_SpinData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_SpinData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_SpinData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_SpinData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_SpinData_create();
         private static _afxXM_SpinData_create _afxXM_SpinData_createFunc;
         internal static IntPtr afxXM_SpinData_create()
         {
         	if (_afxXM_SpinData_createFunc == null)
         	{
         		_afxXM_SpinData_createFunc =
         			(_afxXM_SpinData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_SpinData_create"), typeof(_afxXM_SpinData_create));
         	}
         
         	return  _afxXM_SpinData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F SpinAxis
         {
         	get { return new Point3F(getFieldValue("SpinAxis")); }
         	set { setFieldValue("SpinAxis", value.ToString()); }
         }
      
         public float SpinAngle
         {
         	get { return float.Parse(getFieldValue("SpinAngle")); }
         	set { setFieldValue("SpinAngle", value.ToString()); }
         }
      
         public float SpinAngleVariance
         {
         	get { return float.Parse(getFieldValue("SpinAngleVariance")); }
         	set { setFieldValue("SpinAngleVariance", value.ToString()); }
         }
      
         public float SpinRate
         {
         	get { return float.Parse(getFieldValue("SpinRate")); }
         	set { setFieldValue("SpinRate", value.ToString()); }
         }
      
         public float SpinRateVariance
         {
         	get { return float.Parse(getFieldValue("SpinRateVariance")); }
         	set { setFieldValue("SpinRateVariance", value.ToString()); }
         }
      
      
      #endregion

	}
}