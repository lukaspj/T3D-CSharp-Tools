using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_ForceData : afxXM_WeightedBaseData
	{
		public afxXM_ForceData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_ForceData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_ForceData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_ForceData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_ForceData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_ForceData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_ForceData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_ForceData_create();
         private static _afxXM_ForceData_create _afxXM_ForceData_createFunc;
         internal static IntPtr afxXM_ForceData_create()
         {
         	if (_afxXM_ForceData_createFunc == null)
         	{
         		_afxXM_ForceData_createFunc =
         			(_afxXM_ForceData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_ForceData_create"), typeof(_afxXM_ForceData_create));
         	}
         
         	return  _afxXM_ForceData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ForceSetName
         {
         	get { return getFieldValue("ForceSetName"); }
         	set { setFieldValue("ForceSetName", value); }
         }
      
         public float UpdateDT
         {
         	get { return float.Parse(getFieldValue("UpdateDT")); }
         	set { setFieldValue("UpdateDT", value.ToString()); }
         }
      
      
      #endregion

	}
}