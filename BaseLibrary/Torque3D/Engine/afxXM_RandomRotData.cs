using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_RandomRotData : afxXM_BaseData
	{
		public afxXM_RandomRotData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_RandomRotData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_RandomRotData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_RandomRotData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_RandomRotData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_RandomRotData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_RandomRotData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_RandomRotData_create();
         private static _afxXM_RandomRotData_create _afxXM_RandomRotData_createFunc;
         internal static IntPtr afxXM_RandomRotData_create()
         {
         	if (_afxXM_RandomRotData_createFunc == null)
         	{
         		_afxXM_RandomRotData_createFunc =
         			(_afxXM_RandomRotData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_RandomRotData_create"), typeof(_afxXM_RandomRotData_create));
         	}
         
         	return  _afxXM_RandomRotData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F Axis
         {
         	get { return new Point3F(getFieldValue("Axis")); }
         	set { setFieldValue("Axis", value.ToString()); }
         }
      
         public float ThetaMin
         {
         	get { return float.Parse(getFieldValue("ThetaMin")); }
         	set { setFieldValue("ThetaMin", value.ToString()); }
         }
      
         public float ThetaMax
         {
         	get { return float.Parse(getFieldValue("ThetaMax")); }
         	set { setFieldValue("ThetaMax", value.ToString()); }
         }
      
         public float PhiMin
         {
         	get { return float.Parse(getFieldValue("PhiMin")); }
         	set { setFieldValue("PhiMin", value.ToString()); }
         }
      
         public float PhiMax
         {
         	get { return float.Parse(getFieldValue("PhiMax")); }
         	set { setFieldValue("PhiMax", value.ToString()); }
         }
      
      
      #endregion

	}
}