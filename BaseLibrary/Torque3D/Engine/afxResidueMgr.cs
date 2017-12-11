using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxResidueMgr : GameBase
	{
		public afxResidueMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxResidueMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxResidueMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxResidueMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxResidueMgr(SimObject pObj) : base(pObj)
		{
		}

		public afxResidueMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxResidueMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxResidueMgr_create();
         private static _afxResidueMgr_create _afxResidueMgr_createFunc;
         internal static IntPtr afxResidueMgr_create()
         {
         	if (_afxResidueMgr_createFunc == null)
         	{
         		_afxResidueMgr_createFunc =
         			(_afxResidueMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxResidueMgr_create"), typeof(_afxResidueMgr_create));
         	}
         
         	return  _afxResidueMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}