using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderDeferredMgr : RenderTexTargetBinManager
	{
		public RenderDeferredMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderDeferredMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderDeferredMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderDeferredMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderDeferredMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderDeferredMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderDeferredMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderDeferredMgr_create();
         private static _RenderDeferredMgr_create _RenderDeferredMgr_createFunc;
         internal static IntPtr RenderDeferredMgr_create()
         {
         	if (_RenderDeferredMgr_createFunc == null)
         	{
         		_RenderDeferredMgr_createFunc =
         			(_RenderDeferredMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderDeferredMgr_create"), typeof(_RenderDeferredMgr_create));
         	}
         
         	return  _RenderDeferredMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}