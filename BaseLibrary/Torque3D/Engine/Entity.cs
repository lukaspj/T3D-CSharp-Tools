using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Entity : GameBase
	{
		public Entity(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Entity(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Entity(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Entity(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Entity(SimObject pObj) : base(pObj)
		{
		}

		public Entity(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Entity_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mountObject(IntPtr thisPtr, IntPtr objB, InternalTransformFStruct txfm);
         private static _mountObject _mountObjectFunc;
         internal static bool mountObject(IntPtr thisPtr, IntPtr objB, InternalTransformFStruct txfm)
         {
         	if (_mountObjectFunc == null)
         	{
         		_mountObjectFunc =
         			(_mountObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_mountObject"), typeof(_mountObject));
         	}
         
         	return  _mountObjectFunc(thisPtr, objB, txfm);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountOffset(IntPtr thisPtr, InternalPoint3FStruct posOffset);
         private static _setMountOffset _setMountOffsetFunc;
         internal static void setMountOffset(IntPtr thisPtr, InternalPoint3FStruct posOffset)
         {
         	if (_setMountOffsetFunc == null)
         	{
         		_setMountOffsetFunc =
         			(_setMountOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_setMountOffset"), typeof(_setMountOffset));
         	}
         
         	 _setMountOffsetFunc(thisPtr, posOffset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountRotation(IntPtr thisPtr, InternalPoint3FStruct rotOffset);
         private static _setMountRotation _setMountRotationFunc;
         internal static void setMountRotation(IntPtr thisPtr, InternalPoint3FStruct rotOffset)
         {
         	if (_setMountRotationFunc == null)
         	{
         		_setMountRotationFunc =
         			(_setMountRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_setMountRotation"), typeof(_setMountRotation));
         	}
         
         	 _setMountRotationFunc(thisPtr, rotOffset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getMountTransform(IntPtr thisPtr);
         private static _getMountTransform _getMountTransformFunc;
         internal static InternalTransformFStruct getMountTransform(IntPtr thisPtr)
         {
         	if (_getMountTransformFunc == null)
         	{
         		_getMountTransformFunc =
         			(_getMountTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getMountTransform"), typeof(_getMountTransform));
         	}
         
         	return  _getMountTransformFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBox(IntPtr thisPtr, InternalPoint3FStruct box);
         private static _setBox _setBoxFunc;
         internal static void setBox(IntPtr thisPtr, InternalPoint3FStruct box)
         {
         	if (_setBoxFunc == null)
         	{
         		_setBoxFunc =
         			(_setBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_setBox"), typeof(_setBox));
         	}
         
         	 _setBoxFunc(thisPtr, box);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addComponent(IntPtr thisPtr, int argc, string[] argv);
         private static _addComponent _addComponentFunc;
         internal static bool addComponent(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_addComponentFunc == null)
         	{
         		_addComponentFunc =
         			(_addComponent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_addComponent"), typeof(_addComponent));
         	}
         
         	return  _addComponentFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeComponent(IntPtr thisPtr, int argc, string[] argv);
         private static _removeComponent _removeComponentFunc;
         internal static bool removeComponent(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_removeComponentFunc == null)
         	{
         		_removeComponentFunc =
         			(_removeComponent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_removeComponent"), typeof(_removeComponent));
         	}
         
         	return  _removeComponentFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearComponents(IntPtr thisPtr, int argc, string[] argv);
         private static _clearComponents _clearComponentsFunc;
         internal static void clearComponents(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_clearComponentsFunc == null)
         	{
         		_clearComponentsFunc =
         			(_clearComponents)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_clearComponents"), typeof(_clearComponents));
         	}
         
         	 _clearComponentsFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getComponentByIndex(IntPtr thisPtr, int argc, string[] argv);
         private static _getComponentByIndex _getComponentByIndexFunc;
         internal static int getComponentByIndex(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getComponentByIndexFunc == null)
         	{
         		_getComponentByIndexFunc =
         			(_getComponentByIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getComponentByIndex"), typeof(_getComponentByIndex));
         	}
         
         	return  _getComponentByIndexFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getComponent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string componentName);
         private static _getComponent _getComponentFunc;
         internal static int getComponent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string componentName)
         {
         	if (_getComponentFunc == null)
         	{
         		_getComponentFunc =
         			(_getComponent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getComponent"), typeof(_getComponent));
         	}
         
         	return  _getComponentFunc(thisPtr, componentName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getComponentCount(IntPtr thisPtr, int argc, string[] argv);
         private static _getComponentCount _getComponentCountFunc;
         internal static int getComponentCount(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getComponentCountFunc == null)
         	{
         		_getComponentCountFunc =
         			(_getComponentCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getComponentCount"), typeof(_getComponentCount));
         	}
         
         	return  _getComponentCountFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setComponentDirty(IntPtr thisPtr, int componentID, bool forceUpdate);
         private static _setComponentDirty _setComponentDirtyFunc;
         internal static void setComponentDirty(IntPtr thisPtr, int componentID, bool forceUpdate)
         {
         	if (_setComponentDirtyFunc == null)
         	{
         		_setComponentDirtyFunc =
         			(_setComponentDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_setComponentDirty"), typeof(_setComponentDirty));
         	}
         
         	 _setComponentDirtyFunc(thisPtr, componentID, forceUpdate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMoveVector(IntPtr thisPtr);
         private static _getMoveVector _getMoveVectorFunc;
         internal static InternalPoint3FStruct getMoveVector(IntPtr thisPtr)
         {
         	if (_getMoveVectorFunc == null)
         	{
         		_getMoveVectorFunc =
         			(_getMoveVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getMoveVector"), typeof(_getMoveVector));
         	}
         
         	return  _getMoveVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMoveRotation(IntPtr thisPtr);
         private static _getMoveRotation _getMoveRotationFunc;
         internal static InternalPoint3FStruct getMoveRotation(IntPtr thisPtr)
         {
         	if (_getMoveRotationFunc == null)
         	{
         		_getMoveRotationFunc =
         			(_getMoveRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getMoveRotation"), typeof(_getMoveRotation));
         	}
         
         	return  _getMoveRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getMoveTrigger(IntPtr thisPtr, int triggerNum);
         private static _getMoveTrigger _getMoveTriggerFunc;
         internal static bool getMoveTrigger(IntPtr thisPtr, int triggerNum)
         {
         	if (_getMoveTriggerFunc == null)
         	{
         		_getMoveTriggerFunc =
         			(_getMoveTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getMoveTrigger"), typeof(_getMoveTrigger));
         	}
         
         	return  _getMoveTriggerFunc(thisPtr, triggerNum);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getForwardVector(IntPtr thisPtr);
         private static _getForwardVector _getForwardVectorFunc;
         internal static InternalPoint3FStruct getForwardVector(IntPtr thisPtr)
         {
         	if (_getForwardVectorFunc == null)
         	{
         		_getForwardVectorFunc =
         			(_getForwardVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_getForwardVector"), typeof(_getForwardVector));
         	}
         
         	return  _getForwardVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setForwardVector(IntPtr thisPtr, InternalPoint3FStruct newForward);
         private static _setForwardVector _setForwardVectorFunc;
         internal static void setForwardVector(IntPtr thisPtr, InternalPoint3FStruct newForward)
         {
         	if (_setForwardVectorFunc == null)
         	{
         		_setForwardVectorFunc =
         			(_setForwardVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_setForwardVector"), typeof(_setForwardVector));
         	}
         
         	 _setForwardVectorFunc(thisPtr, newForward);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _lookAt(IntPtr thisPtr, InternalPoint3FStruct lookPosition);
         private static _lookAt _lookAtFunc;
         internal static void lookAt(IntPtr thisPtr, InternalPoint3FStruct lookPosition)
         {
         	if (_lookAtFunc == null)
         	{
         		_lookAtFunc =
         			(_lookAt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_lookAt"), typeof(_lookAt));
         	}
         
         	 _lookAtFunc(thisPtr, lookPosition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _rotateTo(IntPtr thisPtr, InternalPoint3FStruct lookPosition, float degreePerSecond);
         private static _rotateTo _rotateToFunc;
         internal static void rotateTo(IntPtr thisPtr, InternalPoint3FStruct lookPosition, float degreePerSecond)
         {
         	if (_rotateToFunc == null)
         	{
         		_rotateToFunc =
         			(_rotateTo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_rotateTo"), typeof(_rotateTo));
         	}
         
         	 _rotateToFunc(thisPtr, lookPosition, degreePerSecond);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _notify(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string signalFunction, [MarshalAs(UnmanagedType.LPWStr)]string argA, [MarshalAs(UnmanagedType.LPWStr)]string argB, [MarshalAs(UnmanagedType.LPWStr)]string argC, [MarshalAs(UnmanagedType.LPWStr)]string argD, [MarshalAs(UnmanagedType.LPWStr)]string argE);
         private static _notify _notifyFunc;
         internal static void notify(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string signalFunction, [MarshalAs(UnmanagedType.LPWStr)]string argA, [MarshalAs(UnmanagedType.LPWStr)]string argB, [MarshalAs(UnmanagedType.LPWStr)]string argC, [MarshalAs(UnmanagedType.LPWStr)]string argD, [MarshalAs(UnmanagedType.LPWStr)]string argE)
         {
         	if (_notifyFunc == null)
         	{
         		_notifyFunc =
         			(_notify)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_notify"), typeof(_notify));
         	}
         
         	 _notifyFunc(thisPtr, signalFunction, argA, argB, argC, argD, argE);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Entity_create();
         private static _Entity_create _Entity_createFunc;
         internal static IntPtr Entity_create()
         {
         	if (_Entity_createFunc == null)
         	{
         		_Entity_createFunc =
         			(_Entity_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Entity_create"), typeof(_Entity_create));
         	}
         
         	return  _Entity_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool mountObject(SceneObject objB, TransformF txfm = null)
         {
            if (txfm == null) txfm = TransformF.Identity;
                  return InternalUnsafeMethods.mountObject(ObjectPtr, objB.ObjectPtr, txfm.ToStruct());
         }
      
         public virtual void setMountOffset(Point3F posOffset = null)
         {
            if (posOffset == null) posOffset = new Point3F(0, 0, 0);
                  InternalUnsafeMethods.setMountOffset(ObjectPtr, posOffset.ToStruct());
         }
      
         public virtual void setMountRotation(EulerF rotOffset = null)
         {
            if (rotOffset == null) rotOffset = new EulerF(0, 0, 0);
                  InternalUnsafeMethods.setMountRotation(ObjectPtr, rotOffset.ToStruct());
         }
      
         public virtual TransformF getMountTransform()
         {
            return new TransformF(InternalUnsafeMethods.getMountTransform(ObjectPtr));
         }
      
         public virtual void setBox(Point3F box = null)
         {
            if (box == null) box = new Point3F(1, 1, 1);
                  InternalUnsafeMethods.setBox(ObjectPtr, box.ToStruct());
         }
      
         public virtual bool addComponent(Component bi)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(bi.getId().ToString());
                  return InternalUnsafeMethods.addComponent(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool removeComponent(Component bi, bool deleteBehavior = true)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(bi.getId().ToString());
                  tmp_arg_list.Add(deleteBehavior.ToString());
                  return InternalUnsafeMethods.removeComponent(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void clearComponents()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.clearComponents(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual int getComponentByIndex(int index)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(index.ToString());
                  return InternalUnsafeMethods.getComponentByIndex(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual int getComponent(string componentName = "")
         {
            if (componentName == null) componentName = "";
                  return InternalUnsafeMethods.getComponent(ObjectPtr, componentName);
         }
      
         public virtual int getComponentCount()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.getComponentCount(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setComponentDirty(int componentID = 0, bool forceUpdate = false)
         {
            InternalUnsafeMethods.setComponentDirty(ObjectPtr, componentID, forceUpdate);
         }
      
         public virtual VectorF getMoveVector()
         {
            return new VectorF(InternalUnsafeMethods.getMoveVector(ObjectPtr));
         }
      
         public virtual VectorF getMoveRotation()
         {
            return new VectorF(InternalUnsafeMethods.getMoveRotation(ObjectPtr));
         }
      
         public virtual bool getMoveTrigger(int triggerNum = 0)
         {
            return InternalUnsafeMethods.getMoveTrigger(ObjectPtr, triggerNum);
         }
      
         public virtual VectorF getForwardVector()
         {
            return new VectorF(InternalUnsafeMethods.getForwardVector(ObjectPtr));
         }
      
         public virtual void setForwardVector(VectorF newForward = null)
         {
            if (newForward == null) newForward = new VectorF(0,0,0);
                  InternalUnsafeMethods.setForwardVector(ObjectPtr, newForward.ToStruct());
         }
      
         public virtual void lookAt(Point3F lookPosition)
         {
            InternalUnsafeMethods.lookAt(ObjectPtr, lookPosition.ToStruct());
         }
      
         public virtual void rotateTo(Point3F lookPosition, float degreePerSecond = 1.0f)
         {
            InternalUnsafeMethods.rotateTo(ObjectPtr, lookPosition.ToStruct(), degreePerSecond);
         }
      
         public virtual void notify(string signalFunction = "", string argA = "", string argB = "", string argC = "", string argD = "", string argE = "")
         {
            if (signalFunction == null) signalFunction = "";
                  if (argA == null) argA = "";
                  if (argB == null) argB = "";
                  if (argC == null) argC = "";
                  if (argD == null) argD = "";
                  if (argE == null) argE = "";
                  InternalUnsafeMethods.notify(ObjectPtr, signalFunction, argA, argB, argC, argD, argE);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F LocalPosition
         {
         	get { return new Point3F(getFieldValue("LocalPosition")); }
         	set { setFieldValue("LocalPosition", value.ToString()); }
         }
      
         public AngAxisF LocalRotation
         {
         	get { return new AngAxisF(getFieldValue("LocalRotation")); }
         	set { setFieldValue("LocalRotation", value.ToString()); }
         }
      
         public string GameObjectName
         {
         	get { return getFieldValue("GameObjectName"); }
         	set { setFieldValue("GameObjectName", value); }
         }
      
      
      #endregion

	}
}