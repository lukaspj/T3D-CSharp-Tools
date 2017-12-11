using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacPlane : GameBase
	{
		public afxZodiacPlane(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacPlane(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacPlane(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacPlane(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacPlane(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacPlane(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacPlane_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacPlane_create();
         private static _afxZodiacPlane_create _afxZodiacPlane_createFunc;
         internal static IntPtr afxZodiacPlane_create()
         {
         	if (_afxZodiacPlane_createFunc == null)
         	{
         		_afxZodiacPlane_createFunc =
         			(_afxZodiacPlane_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacPlane_create"), typeof(_afxZodiacPlane_create));
         	}
         
         	return  _afxZodiacPlane_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}