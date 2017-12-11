using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxVolumeLightData : GameBaseData
	{
		public afxVolumeLightData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxVolumeLightData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxVolumeLightData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxVolumeLightData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxVolumeLightData(SimObject pObj) : base(pObj)
		{
		}

		public afxVolumeLightData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxVolumeLightData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxVolumeLightData_create();
         private static _afxVolumeLightData_create _afxVolumeLightData_createFunc;
         internal static IntPtr afxVolumeLightData_create()
         {
         	if (_afxVolumeLightData_createFunc == null)
         	{
         		_afxVolumeLightData_createFunc =
         			(_afxVolumeLightData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxVolumeLightData_create"), typeof(_afxVolumeLightData_create));
         	}
         
         	return  _afxVolumeLightData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}