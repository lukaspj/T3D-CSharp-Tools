using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RigidBodyComponent : Component
	{
		public RigidBodyComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RigidBodyComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RigidBodyComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RigidBodyComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RigidBodyComponent(SimObject pObj) : base(pObj)
		{
		}

		public RigidBodyComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RigidBodyComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RigidBodyComponent_create();
         private static _RigidBodyComponent_create _RigidBodyComponent_createFunc;
         internal static IntPtr RigidBodyComponent_create()
         {
         	if (_RigidBodyComponent_createFunc == null)
         	{
         		_RigidBodyComponent_createFunc =
         			(_RigidBodyComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RigidBodyComponent_create"), typeof(_RigidBodyComponent_create));
         	}
         
         	return  _RigidBodyComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}