using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeCubemapName : GuiInspectorTypeMenuBase
	{
		public GuiInspectorTypeCubemapName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeCubemapName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeCubemapName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeCubemapName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeCubemapName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeCubemapName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeCubemapName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeCubemapName_create();
         private static _GuiInspectorTypeCubemapName_create _GuiInspectorTypeCubemapName_createFunc;
         internal static IntPtr GuiInspectorTypeCubemapName_create()
         {
         	if (_GuiInspectorTypeCubemapName_createFunc == null)
         	{
         		_GuiInspectorTypeCubemapName_createFunc =
         			(_GuiInspectorTypeCubemapName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeCubemapName_create"), typeof(_GuiInspectorTypeCubemapName_create));
         	}
         
         	return  _GuiInspectorTypeCubemapName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}