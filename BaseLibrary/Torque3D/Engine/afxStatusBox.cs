using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxStatusBox : GuiBitmapCtrl
	{
		public afxStatusBox(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxStatusBox(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxStatusBox(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxStatusBox(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxStatusBox(SimObject pObj) : base(pObj)
		{
		}

		public afxStatusBox(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxStatusBox_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxStatusBox_create();
         private static _afxStatusBox_create _afxStatusBox_createFunc;
         internal static IntPtr afxStatusBox_create()
         {
         	if (_afxStatusBox_createFunc == null)
         	{
         		_afxStatusBox_createFunc =
         			(_afxStatusBox_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStatusBox_create"), typeof(_afxStatusBox_create));
         	}
         
         	return  _afxStatusBox_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}