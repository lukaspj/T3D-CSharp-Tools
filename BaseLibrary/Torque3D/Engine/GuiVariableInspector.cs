using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiVariableInspector : GuiInspector
	{
		public GuiVariableInspector(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiVariableInspector(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiVariableInspector(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiVariableInspector(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiVariableInspector(SimObject pObj) : base(pObj)
		{
		}

		public GuiVariableInspector(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiVariableInspector_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _startGroup _startGroupFunc;
         internal static void startGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_startGroupFunc == null)
         	{
         		_startGroupFunc =
         			(_startGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_startGroup"), typeof(_startGroup));
         	}
         
         	 _startGroupFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _endGroup(IntPtr thisPtr);
         private static _endGroup _endGroupFunc;
         internal static void endGroup(IntPtr thisPtr)
         {
         	if (_endGroupFunc == null)
         	{
         		_endGroupFunc =
         			(_endGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_endGroup"), typeof(_endGroup));
         	}
         
         	 _endGroupFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string typeName, [MarshalAs(UnmanagedType.LPWStr)]string description, [MarshalAs(UnmanagedType.LPWStr)]string defaultValue, [MarshalAs(UnmanagedType.LPWStr)]string dataValues, IntPtr ownerObj);
         private static _addField _addFieldFunc;
         internal static void addField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string typeName, [MarshalAs(UnmanagedType.LPWStr)]string description, [MarshalAs(UnmanagedType.LPWStr)]string defaultValue, [MarshalAs(UnmanagedType.LPWStr)]string dataValues, IntPtr ownerObj)
         {
         	if (_addFieldFunc == null)
         	{
         		_addFieldFunc =
         			(_addField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_addField"), typeof(_addField));
         	}
         
         	 _addFieldFunc(thisPtr, name, label, typeName, description, defaultValue, dataValues, ownerObj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addCallbackField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string typeName, [MarshalAs(UnmanagedType.LPWStr)]string description, [MarshalAs(UnmanagedType.LPWStr)]string defaultValue, [MarshalAs(UnmanagedType.LPWStr)]string dataValues, [MarshalAs(UnmanagedType.LPWStr)]string callbackName, IntPtr ownerObj);
         private static _addCallbackField _addCallbackFieldFunc;
         internal static void addCallbackField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string typeName, [MarshalAs(UnmanagedType.LPWStr)]string description, [MarshalAs(UnmanagedType.LPWStr)]string defaultValue, [MarshalAs(UnmanagedType.LPWStr)]string dataValues, [MarshalAs(UnmanagedType.LPWStr)]string callbackName, IntPtr ownerObj)
         {
         	if (_addCallbackFieldFunc == null)
         	{
         		_addCallbackFieldFunc =
         			(_addCallbackField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_addCallbackField"), typeof(_addCallbackField));
         	}
         
         	 _addCallbackFieldFunc(thisPtr, name, label, typeName, description, defaultValue, dataValues, callbackName, ownerObj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _update(IntPtr thisPtr);
         private static _update _updateFunc;
         internal static void update(IntPtr thisPtr)
         {
         	if (_updateFunc == null)
         	{
         		_updateFunc =
         			(_update)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_update"), typeof(_update));
         	}
         
         	 _updateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearFields(IntPtr thisPtr);
         private static _clearFields _clearFieldsFunc;
         internal static void clearFields(IntPtr thisPtr)
         {
         	if (_clearFieldsFunc == null)
         	{
         		_clearFieldsFunc =
         			(_clearFields)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_clearFields"), typeof(_clearFields));
         	}
         
         	 _clearFieldsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFieldEnabled(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, bool isEnabled);
         private static _setFieldEnabled _setFieldEnabledFunc;
         internal static void setFieldEnabled(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, bool isEnabled)
         {
         	if (_setFieldEnabledFunc == null)
         	{
         		_setFieldEnabledFunc =
         			(_setFieldEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_setFieldEnabled"), typeof(_setFieldEnabled));
         	}
         
         	 _setFieldEnabledFunc(thisPtr, fieldName, isEnabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _loadVars(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string searchString);
         private static _loadVars _loadVarsFunc;
         internal static void loadVars(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string searchString)
         {
         	if (_loadVarsFunc == null)
         	{
         		_loadVarsFunc =
         			(_loadVars)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_loadVars"), typeof(_loadVars));
         	}
         
         	 _loadVarsFunc(thisPtr, searchString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiVariableInspector_create();
         private static _GuiVariableInspector_create _GuiVariableInspector_createFunc;
         internal static IntPtr GuiVariableInspector_create()
         {
         	if (_GuiVariableInspector_createFunc == null)
         	{
         		_GuiVariableInspector_createFunc =
         			(_GuiVariableInspector_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_create"), typeof(_GuiVariableInspector_create));
         	}
         
         	return  _GuiVariableInspector_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void startGroup(string name)
         {
            InternalUnsafeMethods.startGroup(ObjectPtr, name);
         }
      
         public virtual void endGroup()
         {
            InternalUnsafeMethods.endGroup(ObjectPtr);
         }
      
         public virtual void addField(string name = "", string label = "", string typeName = "", string description = "", string defaultValue = "", string dataValues = "", SimObject ownerObj = null)
         {
            if (name == null) name = "";
                  if (label == null) label = "";
                  if (typeName == null) typeName = "";
                  if (description == null) description = "";
                  if (defaultValue == null) defaultValue = "";
                  if (dataValues == null) dataValues = "";
                  if (ownerObj == null) ownerObj = null;
                  InternalUnsafeMethods.addField(ObjectPtr, name, label, typeName, description, defaultValue, dataValues, ownerObj.ObjectPtr);
         }
      
         public virtual void addCallbackField(string name, string label = "", string typeName = "", string description = "", string defaultValue = "", string dataValues = "", string callbackName = "", SimObject ownerObj = null)
         {
            if (label == null) label = "";
                  if (typeName == null) typeName = "";
                  if (description == null) description = "";
                  if (defaultValue == null) defaultValue = "";
                  if (dataValues == null) dataValues = "";
                  if (callbackName == null) callbackName = "";
                  if (ownerObj == null) ownerObj = null;
                  InternalUnsafeMethods.addCallbackField(ObjectPtr, name, label, typeName, description, defaultValue, dataValues, callbackName, ownerObj.ObjectPtr);
         }
      
         public virtual void update()
         {
            InternalUnsafeMethods.update(ObjectPtr);
         }
      
         public virtual void clearFields()
         {
            InternalUnsafeMethods.clearFields(ObjectPtr);
         }
      
         public virtual void setFieldEnabled(string fieldName, bool isEnabled = true)
         {
            InternalUnsafeMethods.setFieldEnabled(ObjectPtr, fieldName, isEnabled);
         }
      
         public virtual void loadVars(string searchString)
         {
            InternalUnsafeMethods.loadVars(ObjectPtr, searchString);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}