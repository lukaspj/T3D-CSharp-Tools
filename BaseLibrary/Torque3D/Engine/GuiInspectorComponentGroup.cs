using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorComponentGroup : GuiInspectorGroup
	{
		public GuiInspectorComponentGroup(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorComponentGroup(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorComponentGroup(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorComponentGroup(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorComponentGroup(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorComponentGroup(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorComponentGroup_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _inspectGroup(IntPtr thisPtr, int argc, string[] argv);
         private static _inspectGroup _inspectGroupFunc;
         internal static bool inspectGroup(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_inspectGroupFunc == null)
         	{
         		_inspectGroupFunc =
         			(_inspectGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorComponentGroup_inspectGroup"), typeof(_inspectGroup));
         	}
         
         	return  _inspectGroupFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addDynamicField(IntPtr thisPtr, int argc, string[] argv);
         private static _addDynamicField _addDynamicFieldFunc;
         internal static void addDynamicField(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_addDynamicFieldFunc == null)
         	{
         		_addDynamicFieldFunc =
         			(_addDynamicField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorComponentGroup_addDynamicField"), typeof(_addDynamicField));
         	}
         
         	 _addDynamicFieldFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeDynamicField(IntPtr thisPtr, int argc, string[] argv);
         private static _removeDynamicField _removeDynamicFieldFunc;
         internal static void removeDynamicField(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_removeDynamicFieldFunc == null)
         	{
         		_removeDynamicFieldFunc =
         			(_removeDynamicField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorComponentGroup_removeDynamicField"), typeof(_removeDynamicField));
         	}
         
         	 _removeDynamicFieldFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorComponentGroup_create();
         private static _GuiInspectorComponentGroup_create _GuiInspectorComponentGroup_createFunc;
         internal static IntPtr GuiInspectorComponentGroup_create()
         {
         	if (_GuiInspectorComponentGroup_createFunc == null)
         	{
         		_GuiInspectorComponentGroup_createFunc =
         			(_GuiInspectorComponentGroup_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorComponentGroup_create"), typeof(_GuiInspectorComponentGroup_create));
         	}
         
         	return  _GuiInspectorComponentGroup_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool inspectGroup()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.inspectGroup(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void addDynamicField()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.addDynamicField(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void removeDynamicField()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.removeDynamicField(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}