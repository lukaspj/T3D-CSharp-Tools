using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMultiLightData : GameBaseData
	{
		public afxMultiLightData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMultiLightData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMultiLightData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMultiLightData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMultiLightData(SimObject pObj) : base(pObj)
		{
		}

		public afxMultiLightData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMultiLightData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMultiLightData_create();
         private static _afxMultiLightData_create _afxMultiLightData_createFunc;
         internal static IntPtr afxMultiLightData_create()
         {
         	if (_afxMultiLightData_createFunc == null)
         	{
         		_afxMultiLightData_createFunc =
         			(_afxMultiLightData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMultiLightData_create"), typeof(_afxMultiLightData_create));
         	}
         
         	return  _afxMultiLightData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}