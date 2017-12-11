using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorEntityGroup : GuiInspectorGroup
	{
		public GuiInspectorEntityGroup(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorEntityGroup(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorEntityGroup(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorEntityGroup(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorEntityGroup(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorEntityGroup(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorEntityGroup_create();
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
         				"fn_GuiInspectorEntityGroup_inspectGroup"), typeof(_inspectGroup));
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
         				"fn_GuiInspectorEntityGroup_addDynamicField"), typeof(_addDynamicField));
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
         				"fn_GuiInspectorEntityGroup_removeDynamicField"), typeof(_removeDynamicField));
         	}
         
         	 _removeDynamicFieldFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorEntityGroup_create();
         private static _GuiInspectorEntityGroup_create _GuiInspectorEntityGroup_createFunc;
         internal static IntPtr GuiInspectorEntityGroup_create()
         {
         	if (_GuiInspectorEntityGroup_createFunc == null)
         	{
         		_GuiInspectorEntityGroup_createFunc =
         			(_GuiInspectorEntityGroup_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorEntityGroup_create"), typeof(_GuiInspectorEntityGroup_create));
         	}
         
         	return  _GuiInspectorEntityGroup_createFunc();
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