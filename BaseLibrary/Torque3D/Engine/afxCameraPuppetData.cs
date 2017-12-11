using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxCameraPuppetData : GameBaseData
	{
		public afxCameraPuppetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxCameraPuppetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxCameraPuppetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxCameraPuppetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxCameraPuppetData(SimObject pObj) : base(pObj)
		{
		}

		public afxCameraPuppetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxCameraPuppetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxCameraPuppetData_create();
         private static _afxCameraPuppetData_create _afxCameraPuppetData_createFunc;
         internal static IntPtr afxCameraPuppetData_create()
         {
         	if (_afxCameraPuppetData_createFunc == null)
         	{
         		_afxCameraPuppetData_createFunc =
         			(_afxCameraPuppetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCameraPuppetData_create"), typeof(_afxCameraPuppetData_create));
         	}
         
         	return  _afxCameraPuppetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string CameraSpec
         {
         	get { return getFieldValue("CameraSpec"); }
         	set { setFieldValue("CameraSpec", value); }
         }
      
         public byte Networking
         {
         	get { return byte.Parse(getFieldValue("Networking")); }
         	set { setFieldValue("Networking", value.ToString()); }
         }
      
      
      #endregion

	}
}