using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiPlatformGenericMenuBar : GuiMenuBar
	{
		public GuiPlatformGenericMenuBar(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiPlatformGenericMenuBar(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiPlatformGenericMenuBar(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiPlatformGenericMenuBar(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiPlatformGenericMenuBar(SimObject pObj) : base(pObj)
		{
		}

		public GuiPlatformGenericMenuBar(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiPlatformGenericMenuBar_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPlatformGenericMenuBar_create();
         private static _GuiPlatformGenericMenuBar_create _GuiPlatformGenericMenuBar_createFunc;
         internal static IntPtr GuiPlatformGenericMenuBar_create()
         {
         	if (_GuiPlatformGenericMenuBar_createFunc == null)
         	{
         		_GuiPlatformGenericMenuBar_createFunc =
         			(_GuiPlatformGenericMenuBar_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiPlatformGenericMenuBar_create"), typeof(_GuiPlatformGenericMenuBar_create));
         	}
         
         	return  _GuiPlatformGenericMenuBar_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}