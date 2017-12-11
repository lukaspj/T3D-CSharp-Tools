using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxBillboard : GameBase
	{
		public afxBillboard(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxBillboard(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxBillboard(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxBillboard(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxBillboard(SimObject pObj) : base(pObj)
		{
		}

		public afxBillboard(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxBillboard_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxBillboard_create();
         private static _afxBillboard_create _afxBillboard_createFunc;
         internal static IntPtr afxBillboard_create()
         {
         	if (_afxBillboard_createFunc == null)
         	{
         		_afxBillboard_createFunc =
         			(_afxBillboard_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxBillboard_create"), typeof(_afxBillboard_create));
         	}
         
         	return  _afxBillboard_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}