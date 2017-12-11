using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMachineGunData : GameBaseData
	{
		public afxMachineGunData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMachineGunData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMachineGunData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMachineGunData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMachineGunData(SimObject pObj) : base(pObj)
		{
		}

		public afxMachineGunData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMachineGunData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMachineGunData_create();
         private static _afxMachineGunData_create _afxMachineGunData_createFunc;
         internal static IntPtr afxMachineGunData_create()
         {
         	if (_afxMachineGunData_createFunc == null)
         	{
         		_afxMachineGunData_createFunc =
         			(_afxMachineGunData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMachineGunData_create"), typeof(_afxMachineGunData_create));
         	}
         
         	return  _afxMachineGunData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ProjectileData Projectile
         {
         	get { return Sim.FindObject<ProjectileData>(getFieldValue("Projectile")); }
         	set { setFieldValue("Projectile", value.getId().ToString()); }
         }
      
         public int RoundsPerMinute
         {
         	get { return int.Parse(getFieldValue("RoundsPerMinute")); }
         	set { setFieldValue("RoundsPerMinute", value.ToString()); }
         }
      
      
      #endregion

	}
}