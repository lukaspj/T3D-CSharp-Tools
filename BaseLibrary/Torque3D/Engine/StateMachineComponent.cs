using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class StateMachineComponent : Component
	{
		public StateMachineComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public StateMachineComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public StateMachineComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public StateMachineComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public StateMachineComponent(SimObject pObj) : base(pObj)
		{
		}

		public StateMachineComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.StateMachineComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StateMachineComponent_create();
         private static _StateMachineComponent_create _StateMachineComponent_createFunc;
         internal static IntPtr StateMachineComponent_create()
         {
         	if (_StateMachineComponent_createFunc == null)
         	{
         		_StateMachineComponent_createFunc =
         			(_StateMachineComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StateMachineComponent_create"), typeof(_StateMachineComponent_create));
         	}
         
         	return  _StateMachineComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string StateMachineFile
         {
         	get { return getFieldValue("StateMachineFile"); }
         	set { setFieldValue("StateMachineFile", value); }
         }
      
      
      #endregion

	}
}