using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorField : GuiControl
	{
		public GuiInspectorField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorField(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getInspector(IntPtr thisPtr);
         private static _getInspector _getInspectorFunc;
         internal static int getInspector(IntPtr thisPtr)
         {
         	if (_getInspectorFunc == null)
         	{
         		_getInspectorFunc =
         			(_getInspector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_getInspector"), typeof(_getInspector));
         	}
         
         	return  _getInspectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getInspectedFieldName(IntPtr thisPtr);
         private static _getInspectedFieldName _getInspectedFieldNameFunc;
         internal static IntPtr getInspectedFieldName(IntPtr thisPtr)
         {
         	if (_getInspectedFieldNameFunc == null)
         	{
         		_getInspectedFieldNameFunc =
         			(_getInspectedFieldName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_getInspectedFieldName"), typeof(_getInspectedFieldName));
         	}
         
         	return  _getInspectedFieldNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getInspectedFieldType(IntPtr thisPtr);
         private static _getInspectedFieldType _getInspectedFieldTypeFunc;
         internal static IntPtr getInspectedFieldType(IntPtr thisPtr)
         {
         	if (_getInspectedFieldTypeFunc == null)
         	{
         		_getInspectedFieldTypeFunc =
         			(_getInspectedFieldType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_getInspectedFieldType"), typeof(_getInspectedFieldType));
         	}
         
         	return  _getInspectedFieldTypeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _apply(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newValue, bool callbacks);
         private static _apply _applyFunc;
         internal static void apply(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newValue, bool callbacks)
         {
         	if (_applyFunc == null)
         	{
         		_applyFunc =
         			(_apply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_apply"), typeof(_apply));
         	}
         
         	 _applyFunc(thisPtr, newValue, callbacks);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyWithoutUndo(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _applyWithoutUndo _applyWithoutUndoFunc;
         internal static void applyWithoutUndo(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_applyWithoutUndoFunc == null)
         	{
         		_applyWithoutUndoFunc =
         			(_applyWithoutUndo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_applyWithoutUndo"), typeof(_applyWithoutUndo));
         	}
         
         	 _applyWithoutUndoFunc(thisPtr, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getData(IntPtr thisPtr);
         private static _getData _getDataFunc;
         internal static IntPtr getData(IntPtr thisPtr)
         {
         	if (_getDataFunc == null)
         	{
         		_getDataFunc =
         			(_getData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_getData"), typeof(_getData));
         	}
         
         	return  _getDataFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCaption(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newCaption);
         private static _setCaption _setCaptionFunc;
         internal static void setCaption(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newCaption)
         {
         	if (_setCaptionFunc == null)
         	{
         		_setCaptionFunc =
         			(_setCaption)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_setCaption"), typeof(_setCaption));
         	}
         
         	 _setCaptionFunc(thisPtr, newCaption);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEditControl(IntPtr thisPtr, IntPtr editCtrl);
         private static _setEditControl _setEditControlFunc;
         internal static void setEditControl(IntPtr thisPtr, IntPtr editCtrl)
         {
         	if (_setEditControlFunc == null)
         	{
         		_setEditControlFunc =
         			(_setEditControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_setEditControl"), typeof(_setEditControl));
         	}
         
         	 _setEditControlFunc(thisPtr, editCtrl);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorField_create();
         private static _GuiInspectorField_create _GuiInspectorField_createFunc;
         internal static IntPtr GuiInspectorField_create()
         {
         	if (_GuiInspectorField_createFunc == null)
         	{
         		_GuiInspectorField_createFunc =
         			(_GuiInspectorField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorField_create"), typeof(_GuiInspectorField_create));
         	}
         
         	return  _GuiInspectorField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getInspector()
         {
            return InternalUnsafeMethods.getInspector(ObjectPtr);
         }
      
         public virtual string getInspectedFieldName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getInspectedFieldName(ObjectPtr));
         }
      
         public virtual string getInspectedFieldType()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getInspectedFieldType(ObjectPtr));
         }
      
         public virtual void apply(string newValue, bool callbacks = true)
         {
            InternalUnsafeMethods.apply(ObjectPtr, newValue, callbacks);
         }
      
         public virtual void applyWithoutUndo(string data)
         {
            InternalUnsafeMethods.applyWithoutUndo(ObjectPtr, data);
         }
      
         public virtual string getData()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getData(ObjectPtr));
         }
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void setCaption(string newCaption)
         {
            InternalUnsafeMethods.setCaption(ObjectPtr, newCaption);
         }
      
         public virtual void setEditControl(GuiControl editCtrl = null)
         {
            if (editCtrl == null) editCtrl = null;
                  InternalUnsafeMethods.setEditControl(ObjectPtr, editCtrl.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}