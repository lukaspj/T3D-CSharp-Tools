using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxStaticShape : StaticShape
	{
		public afxStaticShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxStaticShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxStaticShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxStaticShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxStaticShape(SimObject pObj) : base(pObj)
		{
		}

		public afxStaticShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxStaticShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxStaticShape_create();
         private static _afxStaticShape_create _afxStaticShape_createFunc;
         internal static IntPtr afxStaticShape_create()
         {
         	if (_afxStaticShape_createFunc == null)
         	{
         		_afxStaticShape_createFunc =
         			(_afxStaticShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStaticShape_create"), typeof(_afxStaticShape_create));
         	}
         
         	return  _afxStaticShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}