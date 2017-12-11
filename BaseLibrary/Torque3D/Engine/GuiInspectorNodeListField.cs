using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorNodeListField : GuiInspectorField
	{
		public GuiInspectorNodeListField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorNodeListField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorNodeListField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorNodeListField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorNodeListField(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorNodeListField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorNodeListField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorNodeListField_create();
         private static _GuiInspectorNodeListField_create _GuiInspectorNodeListField_createFunc;
         internal static IntPtr GuiInspectorNodeListField_create()
         {
         	if (_GuiInspectorNodeListField_createFunc == null)
         	{
         		_GuiInspectorNodeListField_createFunc =
         			(_GuiInspectorNodeListField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorNodeListField_create"), typeof(_GuiInspectorNodeListField_create));
         	}
         
         	return  _GuiInspectorNodeListField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}