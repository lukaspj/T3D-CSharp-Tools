using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_ShockwaveData : afxXM_BaseData
	{
		public afxXM_ShockwaveData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_ShockwaveData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_ShockwaveData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_ShockwaveData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_ShockwaveData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_ShockwaveData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_ShockwaveData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_ShockwaveData_create();
         private static _afxXM_ShockwaveData_create _afxXM_ShockwaveData_createFunc;
         internal static IntPtr afxXM_ShockwaveData_create()
         {
         	if (_afxXM_ShockwaveData_createFunc == null)
         	{
         		_afxXM_ShockwaveData_createFunc =
         			(_afxXM_ShockwaveData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_ShockwaveData_create"), typeof(_afxXM_ShockwaveData_create));
         	}
         
         	return  _afxXM_ShockwaveData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Rate
         {
         	get { return float.Parse(getFieldValue("Rate")); }
         	set { setFieldValue("Rate", value.ToString()); }
         }
      
         public bool AimZOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AimZOnly")); }
         	set { setFieldValue("AimZOnly", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}