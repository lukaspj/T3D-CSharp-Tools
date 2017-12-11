using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxCameraData : ShapeBaseData
	{
		public afxCameraData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxCameraData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxCameraData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxCameraData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxCameraData(SimObject pObj) : base(pObj)
		{
		}

		public afxCameraData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxCameraData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxCameraData_create();
         private static _afxCameraData_create _afxCameraData_createFunc;
         internal static IntPtr afxCameraData_create()
         {
         	if (_afxCameraData_createFunc == null)
         	{
         		_afxCameraData_createFunc =
         			(_afxCameraData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCameraData_create"), typeof(_afxCameraData_create));
         	}
         
         	return  _afxCameraData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}