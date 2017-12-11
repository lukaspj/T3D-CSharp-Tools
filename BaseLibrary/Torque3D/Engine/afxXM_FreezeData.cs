using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_FreezeData : afxXM_BaseData
	{
		public afxXM_FreezeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_FreezeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_FreezeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_FreezeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_FreezeData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_FreezeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_FreezeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_FreezeData_create();
         private static _afxXM_FreezeData_create _afxXM_FreezeData_createFunc;
         internal static IntPtr afxXM_FreezeData_create()
         {
         	if (_afxXM_FreezeData_createFunc == null)
         	{
         		_afxXM_FreezeData_createFunc =
         			(_afxXM_FreezeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_FreezeData_create"), typeof(_afxXM_FreezeData_create));
         	}
         
         	return  _afxXM_FreezeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int Mask
         {
         	get { return int.Parse(getFieldValue("Mask")); }
         	set { setFieldValue("Mask", value.ToString()); }
         }
      
         public float Delay
         {
         	get { return float.Parse(getFieldValue("Delay")); }
         	set { setFieldValue("Delay", value.ToString()); }
         }
      
      
      #endregion

	}
}