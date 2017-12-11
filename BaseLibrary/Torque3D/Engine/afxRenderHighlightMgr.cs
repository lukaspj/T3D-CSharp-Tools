using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxRenderHighlightMgr : RenderTexTargetBinManager
	{
		public afxRenderHighlightMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxRenderHighlightMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxRenderHighlightMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxRenderHighlightMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxRenderHighlightMgr(SimObject pObj) : base(pObj)
		{
		}

		public afxRenderHighlightMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxRenderHighlightMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxRenderHighlightMgr_create();
         private static _afxRenderHighlightMgr_create _afxRenderHighlightMgr_createFunc;
         internal static IntPtr afxRenderHighlightMgr_create()
         {
         	if (_afxRenderHighlightMgr_createFunc == null)
         	{
         		_afxRenderHighlightMgr_createFunc =
         			(_afxRenderHighlightMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxRenderHighlightMgr_create"), typeof(_afxRenderHighlightMgr_create));
         	}
         
         	return  _afxRenderHighlightMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}