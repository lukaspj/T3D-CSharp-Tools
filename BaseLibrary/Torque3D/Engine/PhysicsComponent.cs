using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicsComponent : Component
	{
		public PhysicsComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicsComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicsComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicsComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicsComponent(SimObject pObj) : base(pObj)
		{
		}

		public PhysicsComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicsComponent_create();
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
         				"fn_PhysicsComponent_applyImpulse"), typeof(_applyImpulse));
         	}
         
         	return  _applyImpulseFunc(thisPtr, pos, vel);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsComponent_create();
         private static _PhysicsComponent_create _PhysicsComponent_createFunc;
         internal static IntPtr PhysicsComponent_create()
         {
         	if (_PhysicsComponent_createFunc == null)
         	{
         		_PhysicsComponent_createFunc =
         			(_PhysicsComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsComponent_create"), typeof(_PhysicsComponent_create));
         	}
         
         	return  _PhysicsComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool applyImpulse(Point3F pos, VectorF vel)
         {
            return InternalUnsafeMethods.applyImpulse(ObjectPtr, pos.ToStruct(), vel.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F Gravity
         {
         	get { return new Point3F(getFieldValue("Gravity")); }
         	set { setFieldValue("Gravity", value.ToString()); }
         }
      
         public Point3F Velocity
         {
         	get { return new Point3F(getFieldValue("Velocity")); }
         	set { setFieldValue("Velocity", value.ToString()); }
         }
      
         public bool IsStatic
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsStatic")); }
         	set { setFieldValue("IsStatic", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}