using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEventCatchAll : GuiControl
	{
		public afxEventCatchAll(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEventCatchAll(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEventCatchAll(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEventCatchAll(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEventCatchAll(SimObject pObj) : base(pObj)
		{
		}

		public afxEventCatchAll(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEventCatchAll_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEventCatchAll_create();
         private static _afxEventCatchAll_create _afxEventCatchAll_createFunc;
         internal static IntPtr afxEventCatchAll_create()
         {
         	if (_afxEventCatchAll_createFunc == null)
         	{
         		_afxEventCatchAll_createFunc =
         			(_afxEventCatchAll_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEventCatchAll_create"), typeof(_afxEventCatchAll_create));
         	}
         
         	return  _afxEventCatchAll_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}