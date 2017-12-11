using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Component : NetObject
	{
		public Component(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Component(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Component(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Component(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Component(SimObject pObj) : base(pObj)
		{
		}

		public Component(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Component_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _beginGroup(IntPtr thisPtr, int argc, string[] argv);
         private static _beginGroup _beginGroupFunc;
         internal static void beginGroup(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_beginGroupFunc == null)
         	{
         		_beginGroupFunc =
         			(_beginGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_beginGroup"), typeof(_beginGroup));
         	}
         
         	 _beginGroupFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _endGroup(IntPtr thisPtr, int argc, string[] argv);
         private static _endGroup _endGroupFunc;
         internal static void endGroup(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_endGroupFunc == null)
         	{
         		_endGroupFunc =
         			(_endGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_endGroup"), typeof(_endGroup));
         	}
         
         	 _endGroupFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addComponentField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, [MarshalAs(UnmanagedType.LPWStr)]string fieldDesc, [MarshalAs(UnmanagedType.LPWStr)]string fieldType, [MarshalAs(UnmanagedType.LPWStr)]string defValue, [MarshalAs(UnmanagedType.LPWStr)]string userData, bool hidden);
         private static _addComponentField _addComponentFieldFunc;
         internal static void addComponentField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, [MarshalAs(UnmanagedType.LPWStr)]string fieldDesc, [MarshalAs(UnmanagedType.LPWStr)]string fieldType, [MarshalAs(UnmanagedType.LPWStr)]string defValue, [MarshalAs(UnmanagedType.LPWStr)]string userData, bool hidden)
         {
         	if (_addComponentFieldFunc == null)
         	{
         		_addComponentFieldFunc =
         			(_addComponentField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_addComponentField"), typeof(_addComponentField));
         	}
         
         	 _addComponentFieldFunc(thisPtr, fieldName, fieldDesc, fieldType, defValue, userData, hidden);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getComponentFieldCount(IntPtr thisPtr, int argc, string[] argv);
         private static _getComponentFieldCount _getComponentFieldCountFunc;
         internal static int getComponentFieldCount(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getComponentFieldCountFunc == null)
         	{
         		_getComponentFieldCountFunc =
         			(_getComponentFieldCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_getComponentFieldCount"), typeof(_getComponentFieldCount));
         	}
         
         	return  _getComponentFieldCountFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getComponentField(IntPtr thisPtr, int argc, string[] argv);
         private static _getComponentField _getComponentFieldFunc;
         internal static IntPtr getComponentField(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getComponentFieldFunc == null)
         	{
         		_getComponentFieldFunc =
         			(_getComponentField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_getComponentField"), typeof(_getComponentField));
         	}
         
         	return  _getComponentFieldFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _setComponentield(IntPtr thisPtr, int argc, string[] argv);
         private static _setComponentield _setComponentieldFunc;
         internal static IntPtr setComponentield(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setComponentieldFunc == null)
         	{
         		_setComponentieldFunc =
         			(_setComponentield)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_setComponentield"), typeof(_setComponentield));
         	}
         
         	return  _setComponentieldFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getComponentFieldType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName);
         private static _getComponentFieldType _getComponentFieldTypeFunc;
         internal static IntPtr getComponentFieldType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName)
         {
         	if (_getComponentFieldTypeFunc == null)
         	{
         		_getComponentFieldTypeFunc =
         			(_getComponentFieldType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_getComponentFieldType"), typeof(_getComponentFieldType));
         	}
         
         	return  _getComponentFieldTypeFunc(thisPtr, fieldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBehaviorFieldUserData(IntPtr thisPtr, int argc, string[] argv);
         private static _getBehaviorFieldUserData _getBehaviorFieldUserDataFunc;
         internal static IntPtr getBehaviorFieldUserData(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getBehaviorFieldUserDataFunc == null)
         	{
         		_getBehaviorFieldUserDataFunc =
         			(_getBehaviorFieldUserData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_getBehaviorFieldUserData"), typeof(_getBehaviorFieldUserData));
         	}
         
         	return  _getBehaviorFieldUserDataFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getComponentFieldDescription(IntPtr thisPtr, int argc, string[] argv);
         private static _getComponentFieldDescription _getComponentFieldDescriptionFunc;
         internal static IntPtr getComponentFieldDescription(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getComponentFieldDescriptionFunc == null)
         	{
         		_getComponentFieldDescriptionFunc =
         			(_getComponentFieldDescription)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_getComponentFieldDescription"), typeof(_getComponentFieldDescription));
         	}
         
         	return  _getComponentFieldDescriptionFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addDependency(IntPtr thisPtr, int argc, string[] argv);
         private static _addDependency _addDependencyFunc;
         internal static void addDependency(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_addDependencyFunc == null)
         	{
         		_addDependencyFunc =
         			(_addDependency)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_addDependency"), typeof(_addDependency));
         	}
         
         	 _addDependencyFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDirty(IntPtr thisPtr, int argc, string[] argv);
         private static _setDirty _setDirtyFunc;
         internal static void setDirty(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setDirtyFunc == null)
         	{
         		_setDirtyFunc =
         			(_setDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_setDirty"), typeof(_setDirty));
         	}
         
         	 _setDirtyFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Component_create();
         private static _Component_create _Component_createFunc;
         internal static IntPtr Component_create()
         {
         	if (_Component_createFunc == null)
         	{
         		_Component_createFunc =
         			(_Component_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Component_create"), typeof(_Component_create));
         	}
         
         	return  _Component_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void beginGroup()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.beginGroup(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void endGroup()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.endGroup(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void addComponentField(string fieldName = "", string fieldDesc = "", string fieldType = "", string defValue = "", string userData = "", bool hidden = false)
         {
            if (fieldName == null) fieldName = "";
                  if (fieldDesc == null) fieldDesc = "";
                  if (fieldType == null) fieldType = "";
                  if (defValue == null) defValue = "";
                  if (userData == null) userData = "";
                  InternalUnsafeMethods.addComponentField(ObjectPtr, fieldName, fieldDesc, fieldType, defValue, userData, hidden);
         }
      
         public virtual int getComponentFieldCount()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.getComponentFieldCount(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual string getComponentField(int index)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(index.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getComponentField(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual string setComponentield(int index)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(index.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.setComponentield(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual string getComponentFieldType(string fieldName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getComponentFieldType(ObjectPtr, fieldName));
         }
      
         public virtual string getBehaviorFieldUserData(int index)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(index.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getBehaviorFieldUserData(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual string getComponentFieldDescription(int index)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(index.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getComponentFieldDescription(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual void addDependency(string behaviorName)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(behaviorName.ToString());
                  InternalUnsafeMethods.addDependency(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setDirty()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setDirty(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
         public string ComponentType
         {
         	get { return getFieldValue("ComponentType"); }
         	set { setFieldValue("ComponentType", value); }
         }
      
         public string NetworkType
         {
         	get { return getFieldValue("NetworkType"); }
         	set { setFieldValue("NetworkType", value); }
         }
      
         public string FriendlyName
         {
         	get { return getFieldValue("FriendlyName"); }
         	set { setFieldValue("FriendlyName", value); }
         }
      
         public string Description
         {
         	get { return getFieldValue("Description"); }
         	set { setFieldValue("Description", value); }
         }
      
         public bool Networked
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Networked")); }
         	set { setFieldValue("Networked", value ? "1" : "0"); }
         }
      
         public SimObject Owner
         {
         	get { return Sim.FindObject<SimObject>(getFieldValue("Owner")); }
         	set { setFieldValue("Owner", value.getId().ToString()); }
         }
      
         public bool Enabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Enabled")); }
         	set { setFieldValue("Enabled", value ? "1" : "0"); }
         }
      
         public string OriginatingAsset
         {
         	get { return getFieldValue("OriginatingAsset"); }
         	set { setFieldValue("OriginatingAsset", value); }
         }
      
      
      #endregion

	}
}