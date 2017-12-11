using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxStatusLabel : GuiMLTextCtrl
	{
		public afxStatusLabel(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxStatusLabel(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxStatusLabel(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxStatusLabel(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxStatusLabel(SimObject pObj) : base(pObj)
		{
		}

		public afxStatusLabel(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxStatusLabel_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxStatusLabel_create();
         private static _afxStatusLabel_create _afxStatusLabel_createFunc;
         internal static IntPtr afxStatusLabel_create()
         {
         	if (_afxStatusLabel_createFunc == null)
         	{
         		_afxStatusLabel_createFunc =
         			(_afxStatusLabel_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStatusLabel_create"), typeof(_afxStatusLabel_create));
         	}
         
         	return  _afxStatusLabel_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}