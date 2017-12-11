using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CameraComponent : Component
	{
		public CameraComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CameraComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CameraComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CameraComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CameraComponent(SimObject pObj) : base(pObj)
		{
		}

		public CameraComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CameraComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMode(IntPtr thisPtr, int argc, string[] argv);
         private static _getMode _getModeFunc;
         internal static IntPtr getMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraComponent_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr, argc, argv);
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
         				"fn_CameraComponent_getForwardVector"), typeof(_getForwardVector));
         	}
         
         	return  _getForwardVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getRightVector(IntPtr thisPtr);
         private static _getRightVector _getRightVectorFunc;
         internal static InternalPoint3FStruct getRightVector(IntPtr thisPtr)
         {
         	if (_getRightVectorFunc == null)
         	{
         		_getRightVectorFunc =
         			(_getRightVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraComponent_getRightVector"), typeof(_getRightVector));
         	}
         
         	return  _getRightVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getUpVector(IntPtr thisPtr);
         private static _getUpVector _getUpVectorFunc;
         internal static InternalPoint3FStruct getUpVector(IntPtr thisPtr)
         {
         	if (_getUpVectorFunc == null)
         	{
         		_getUpVectorFunc =
         			(_getUpVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraComponent_getUpVector"), typeof(_getUpVector));
         	}
         
         	return  _getUpVectorFunc(thisPtr);
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
         				"fn_CameraComponent_setForwardVector"), typeof(_setForwardVector));
         	}
         
         	 _setForwardVectorFunc(thisPtr, newForward);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getWorldPosition(IntPtr thisPtr);
         private static _getWorldPosition _getWorldPositionFunc;
         internal static InternalPoint3FStruct getWorldPosition(IntPtr thisPtr)
         {
         	if (_getWorldPositionFunc == null)
         	{
         		_getWorldPositionFunc =
         			(_getWorldPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraComponent_getWorldPosition"), typeof(_getWorldPosition));
         	}
         
         	return  _getWorldPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CameraComponent_create();
         private static _CameraComponent_create _CameraComponent_createFunc;
         internal static IntPtr CameraComponent_create()
         {
         	if (_CameraComponent_createFunc == null)
         	{
         		_CameraComponent_createFunc =
         			(_CameraComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraComponent_create"), typeof(_CameraComponent_create));
         	}
         
         	return  _CameraComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getMode()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual VectorF getForwardVector()
         {
            return new VectorF(InternalUnsafeMethods.getForwardVector(ObjectPtr));
         }
      
         public virtual VectorF getRightVector()
         {
            return new VectorF(InternalUnsafeMethods.getRightVector(ObjectPtr));
         }
      
         public virtual VectorF getUpVector()
         {
            return new VectorF(InternalUnsafeMethods.getUpVector(ObjectPtr));
         }
      
         public virtual void setForwardVector(VectorF newForward = null)
         {
            if (newForward == null) newForward = new VectorF(0, 0, 0);
                  InternalUnsafeMethods.setForwardVector(ObjectPtr, newForward.ToStruct());
         }
      
         public virtual Point3F getWorldPosition()
         {
            return new Point3F(InternalUnsafeMethods.getWorldPosition(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public float FOV
         {
         	get { return float.Parse(getFieldValue("FOV")); }
         	set { setFieldValue("FOV", value.ToString()); }
         }
      
         public float MinFOV
         {
         	get { return float.Parse(getFieldValue("MinFOV")); }
         	set { setFieldValue("MinFOV", value.ToString()); }
         }
      
         public float MaxFOV
         {
         	get { return float.Parse(getFieldValue("MaxFOV")); }
         	set { setFieldValue("MaxFOV", value.ToString()); }
         }
      
         public Point2I ScreenAspect
         {
         	get { return new Point2I(getFieldValue("ScreenAspect")); }
         	set { setFieldValue("ScreenAspect", value.ToString()); }
         }
      
         public string TargetNode
         {
         	get { return getFieldValue("TargetNode"); }
         	set { setFieldValue("TargetNode", value); }
         }
      
         public Point3F PositionOffset
         {
         	get { return new Point3F(getFieldValue("PositionOffset")); }
         	set { setFieldValue("PositionOffset", value.ToString()); }
         }
      
         public RotationF RotationOffset
         {
         	get { return new RotationF(getFieldValue("RotationOffset")); }
         	set { setFieldValue("RotationOffset", value.ToString()); }
         }
      
         public bool UseParentTransform
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseParentTransform")); }
         	set { setFieldValue("UseParentTransform", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}