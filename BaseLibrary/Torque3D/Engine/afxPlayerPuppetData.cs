using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxPlayerPuppetData : GameBaseData
	{
		public afxPlayerPuppetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxPlayerPuppetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxPlayerPuppetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxPlayerPuppetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxPlayerPuppetData(SimObject pObj) : base(pObj)
		{
		}

		public afxPlayerPuppetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxPlayerPuppetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxPlayerPuppetData_create();
         private static _afxPlayerPuppetData_create _afxPlayerPuppetData_createFunc;
         internal static IntPtr afxPlayerPuppetData_create()
         {
         	if (_afxPlayerPuppetData_createFunc == null)
         	{
         		_afxPlayerPuppetData_createFunc =
         			(_afxPlayerPuppetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxPlayerPuppetData_create"), typeof(_afxPlayerPuppetData_create));
         	}
         
         	return  _afxPlayerPuppetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ObjectSpec
         {
         	get { return getFieldValue("ObjectSpec"); }
         	set { setFieldValue("ObjectSpec", value); }
         }
      
         public byte Networking
         {
         	get { return byte.Parse(getFieldValue("Networking")); }
         	set { setFieldValue("Networking", value.ToString()); }
         }
      
      
      #endregion

	}
}