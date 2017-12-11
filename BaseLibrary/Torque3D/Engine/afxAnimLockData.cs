using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxAnimLockData : GameBaseData
	{
		public afxAnimLockData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxAnimLockData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxAnimLockData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxAnimLockData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxAnimLockData(SimObject pObj) : base(pObj)
		{
		}

		public afxAnimLockData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxAnimLockData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxAnimLockData_create();
         private static _afxAnimLockData_create _afxAnimLockData_createFunc;
         internal static IntPtr afxAnimLockData_create()
         {
         	if (_afxAnimLockData_createFunc == null)
         	{
         		_afxAnimLockData_createFunc =
         			(_afxAnimLockData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxAnimLockData_create"), typeof(_afxAnimLockData_create));
         	}
         
         	return  _afxAnimLockData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}