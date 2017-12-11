using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PlayerControllerComponent : Component
	{
		public PlayerControllerComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PlayerControllerComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PlayerControllerComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PlayerControllerComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PlayerControllerComponent(SimObject pObj) : base(pObj)
		{
		}

		public PlayerControllerComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PlayerControllerComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _applyImpulse(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct vel);
         private static _applyImpulse _applyImpulseFunc;
         internal static bool applyImpulse(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct vel)
         {
         	if (_applyImpulseFunc == null)
         	{
         		_applyImpulseFunc =
         			(_applyImpulse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PlayerControllerComponent_applyImpulse"), typeof(_applyImpulse));
         	}
         
         	return  _applyImpulseFunc(thisPtr, pos, vel);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getContactNormal(IntPtr thisPtr);
         private static _getContactNormal _getContactNormalFunc;
         internal static InternalPoint3FStruct getContactNormal(IntPtr thisPtr)
         {
         	if (_getContactNormalFunc == null)
         	{
         		_getContactNormalFunc =
         			(_getContactNormal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PlayerControllerComponent_getContactNormal"), typeof(_getContactNormal));
         	}
         
         	return  _getContactNormalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getContactObject(IntPtr thisPtr);
         private static _getContactObject _getContactObjectFunc;
         internal static IntPtr getContactObject(IntPtr thisPtr)
         {
         	if (_getContactObjectFunc == null)
         	{
         		_getContactObjectFunc =
         			(_getContactObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PlayerControllerComponent_getContactObject"), typeof(_getContactObject));
         	}
         
         	return  _getContactObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isContacted(IntPtr thisPtr);
         private static _isContacted _isContactedFunc;
         internal static bool isContacted(IntPtr thisPtr)
         {
         	if (_isContactedFunc == null)
         	{
         		_isContactedFunc =
         			(_isContacted)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PlayerControllerComponent_isContacted"), typeof(_isContacted));
         	}
         
         	return  _isContactedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PlayerControllerComponent_create();
         private static _PlayerControllerComponent_create _PlayerControllerComponent_createFunc;
         internal static IntPtr PlayerControllerComponent_create()
         {
         	if (_PlayerControllerComponent_createFunc == null)
         	{
         		_PlayerControllerComponent_createFunc =
         			(_PlayerControllerComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PlayerControllerComponent_create"), typeof(_PlayerControllerComponent_create));
         	}
         
         	return  _PlayerControllerComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool applyImpulse(Point3F pos, VectorF vel)
         {
            return InternalUnsafeMethods.applyImpulse(ObjectPtr, pos.ToStruct(), vel.ToStruct());
         }
      
         public virtual Point3F getContactNormal()
         {
            return new Point3F(InternalUnsafeMethods.getContactNormal(ObjectPtr));
         }
      
         public virtual SceneObject getContactObject()
         {
            return new SceneObject(InternalUnsafeMethods.getContactObject(ObjectPtr));
         }
      
         public virtual bool isContacted()
         {
            return InternalUnsafeMethods.isContacted(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F InputVelocity
         {
         	get { return new Point3F(getFieldValue("InputVelocity")); }
         	set { setFieldValue("InputVelocity", value.ToString()); }
         }
      
         public Point3F UseDirectMoveInput
         {
         	get { return new Point3F(getFieldValue("UseDirectMoveInput")); }
         	set { setFieldValue("UseDirectMoveInput", value.ToString()); }
         }
      
      
      #endregion

	}
}