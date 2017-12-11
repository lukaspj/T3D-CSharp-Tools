using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_AimData : afxXM_WeightedBaseData
	{
		public afxXM_AimData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_AimData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_AimData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_AimData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_AimData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_AimData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_AimData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_AimData_create();
         private static _afxXM_AimData_create _afxXM_AimData_createFunc;
         internal static IntPtr afxXM_AimData_create()
         {
         	if (_afxXM_AimData_createFunc == null)
         	{
         		_afxXM_AimData_createFunc =
         			(_afxXM_AimData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_AimData_create"), typeof(_afxXM_AimData_create));
         	}
         
         	return  _afxXM_AimData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool AimZOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AimZOnly")); }
         	set { setFieldValue("AimZOnly", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}