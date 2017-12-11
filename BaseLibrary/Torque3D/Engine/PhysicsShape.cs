using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicsShape : GameBase
	{
		public PhysicsShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicsShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicsShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicsShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicsShape(SimObject pObj) : base(pObj)
		{
		}

		public PhysicsShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicsShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDestroyed(IntPtr thisPtr);
         private static _isDestroyed _isDestroyedFunc;
         internal static bool isDestroyed(IntPtr thisPtr)
         {
         	if (_isDestroyedFunc == null)
         	{
         		_isDestroyedFunc =
         			(_isDestroyed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShape_isDestroyed"), typeof(_isDestroyed));
         	}
         
         	return  _isDestroyedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _destroy(IntPtr thisPtr);
         private static _destroy _destroyFunc;
         internal static void destroy(IntPtr thisPtr)
         {
         	if (_destroyFunc == null)
         	{
         		_destroyFunc =
         			(_destroy)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShape_destroy"), typeof(_destroy));
         	}
         
         	 _destroyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _restore(IntPtr thisPtr);
         private static _restore _restoreFunc;
         internal static void restore(IntPtr thisPtr)
         {
         	if (_restoreFunc == null)
         	{
         		_restoreFunc =
         			(_restore)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShape_restore"), typeof(_restore));
         	}
         
         	 _restoreFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyTorque(IntPtr thisPtr, InternalPoint3FStruct torque);
         private static _applyTorque _applyTorqueFunc;
         internal static void applyTorque(IntPtr thisPtr, InternalPoint3FStruct torque)
         {
         	if (_applyTorqueFunc == null)
         	{
         		_applyTorqueFunc =
         			(_applyTorque)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShape_applyTorque"), typeof(_applyTorque));
         	}
         
         	 _applyTorqueFunc(thisPtr, torque);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyForce(IntPtr thisPtr, InternalPoint3FStruct force);
         private static _applyForce _applyForceFunc;
         internal static void applyForce(IntPtr thisPtr, InternalPoint3FStruct force)
         {
         	if (_applyForceFunc == null)
         	{
         		_applyForceFunc =
         			(_applyForce)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShape_applyForce"), typeof(_applyForce));
         	}
         
         	 _applyForceFunc(thisPtr, force);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsShape_create();
         private static _PhysicsShape_create _PhysicsShape_createFunc;
         internal static IntPtr PhysicsShape_create()
         {
         	if (_PhysicsShape_createFunc == null)
         	{
         		_PhysicsShape_createFunc =
         			(_PhysicsShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShape_create"), typeof(_PhysicsShape_create));
         	}
         
         	return  _PhysicsShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isDestroyed()
         {
            return InternalUnsafeMethods.isDestroyed(ObjectPtr);
         }
      
         public virtual void destroy()
         {
            InternalUnsafeMethods.destroy(ObjectPtr);
         }
      
         public virtual void restore()
         {
            InternalUnsafeMethods.restore(ObjectPtr);
         }
      
         public virtual void applyTorque(Point3F torque)
         {
            InternalUnsafeMethods.applyTorque(ObjectPtr, torque.ToStruct());
         }
      
         public virtual void applyForce(Point3F force)
         {
            InternalUnsafeMethods.applyForce(ObjectPtr, force.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
         public bool PlayAmbient
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PlayAmbient")); }
         	set { setFieldValue("PlayAmbient", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}