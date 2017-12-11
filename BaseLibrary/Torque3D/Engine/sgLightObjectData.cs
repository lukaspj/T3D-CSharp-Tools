using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class sgLightObjectData : GameBaseData
	{
		public sgLightObjectData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public sgLightObjectData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public sgLightObjectData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public sgLightObjectData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public sgLightObjectData(SimObject pObj) : base(pObj)
		{
		}

		public sgLightObjectData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.sgLightObjectData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _sgLightObjectData_create();
         private static _sgLightObjectData_create _sgLightObjectData_createFunc;
         internal static IntPtr sgLightObjectData_create()
         {
         	if (_sgLightObjectData_createFunc == null)
         	{
         		_sgLightObjectData_createFunc =
         			(_sgLightObjectData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sgLightObjectData_create"), typeof(_sgLightObjectData_create));
         	}
         
         	return  _sgLightObjectData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}