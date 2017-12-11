using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxF_GravityData : GameBaseData
	{
		public afxF_GravityData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxF_GravityData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxF_GravityData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxF_GravityData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxF_GravityData(SimObject pObj) : base(pObj)
		{
		}

		public afxF_GravityData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxF_GravityData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxF_GravityData_create();
         private static _afxF_GravityData_create _afxF_GravityData_createFunc;
         internal static IntPtr afxF_GravityData_create()
         {
         	if (_afxF_GravityData_createFunc == null)
         	{
         		_afxF_GravityData_createFunc =
         			(_afxF_GravityData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxF_GravityData_create"), typeof(_afxF_GravityData_create));
         	}
         
         	return  _afxF_GravityData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Gravity
         {
         	get { return float.Parse(getFieldValue("Gravity")); }
         	set { setFieldValue("Gravity", value.ToString()); }
         }
      
         public string ForceSetName
         {
         	get { return getFieldValue("ForceSetName"); }
         	set { setFieldValue("ForceSetName", value); }
         }
      
      
      #endregion

	}
}