using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxProjectile : Projectile
	{
		public afxProjectile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxProjectile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxProjectile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxProjectile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxProjectile(SimObject pObj) : base(pObj)
		{
		}

		public afxProjectile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxProjectile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxProjectile_create();
         private static _afxProjectile_create _afxProjectile_createFunc;
         internal static IntPtr afxProjectile_create()
         {
         	if (_afxProjectile_createFunc == null)
         	{
         		_afxProjectile_createFunc =
         			(_afxProjectile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxProjectile_create"), typeof(_afxProjectile_create));
         	}
         
         	return  _afxProjectile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}