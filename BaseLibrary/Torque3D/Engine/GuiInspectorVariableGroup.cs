using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorVariableGroup : GuiInspectorGroup
	{
		public GuiInspectorVariableGroup(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorVariableGroup(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorVariableGroup(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorVariableGroup(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorVariableGroup(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorVariableGroup(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorVariableGroup_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _createInspectorField(IntPtr thisPtr);
         private static _createInspectorField _createInspectorFieldFunc;
         internal static IntPtr createInspectorField(IntPtr thisPtr)
         {
         	if (_createInspectorFieldFunc == null)
         	{
         		_createInspectorFieldFunc =
         			(_createInspectorField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorVariableGroup_createInspectorField"), typeof(_createInspectorField));
         	}
         
         	return  _createInspectorFieldFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addInspectorField(IntPtr thisPtr, IntPtr field);
         private static _addInspectorField _addInspectorFieldFunc;
         internal static void addInspectorField(IntPtr thisPtr, IntPtr field)
         {
         	if (_addInspectorFieldFunc == null)
         	{
         		_addInspectorFieldFunc =
         			(_addInspectorField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorVariableGroup_addInspectorField"), typeof(_addInspectorField));
         	}
         
         	 _addInspectorFieldFunc(thisPtr, field);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorVariableGroup_create();
         private static _GuiInspectorVariableGroup_create _GuiInspectorVariableGroup_createFunc;
         internal static IntPtr GuiInspectorVariableGroup_create()
         {
         	if (_GuiInspectorVariableGroup_createFunc == null)
         	{
         		_GuiInspectorVariableGroup_createFunc =
         			(_GuiInspectorVariableGroup_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorVariableGroup_create"), typeof(_GuiInspectorVariableGroup_create));
         	}
         
         	return  _GuiInspectorVariableGroup_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual GuiInspectorField createInspectorField()
         {
            return new GuiInspectorField(InternalUnsafeMethods.createInspectorField(ObjectPtr));
         }
      
         public virtual void addInspectorField(GuiInspectorField field = null)
         {
            if (field == null) field = null;
                  InternalUnsafeMethods.addInspectorField(ObjectPtr, field.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}