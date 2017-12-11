using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEffectBaseData : GameBaseData
	{
		public afxEffectBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEffectBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEffectBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEffectBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEffectBaseData(SimObject pObj) : base(pObj)
		{
		}

		public afxEffectBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEffectBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEffectBaseData_create();
         private static _afxEffectBaseData_create _afxEffectBaseData_createFunc;
         internal static IntPtr afxEffectBaseData_create()
         {
         	if (_afxEffectBaseData_createFunc == null)
         	{
         		_afxEffectBaseData_createFunc =
         			(_afxEffectBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectBaseData_create"), typeof(_afxEffectBaseData_create));
         	}
         
         	return  _afxEffectBaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}