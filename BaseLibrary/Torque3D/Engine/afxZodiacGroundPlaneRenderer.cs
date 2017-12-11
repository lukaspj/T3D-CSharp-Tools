using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacGroundPlaneRenderer : RenderBinManager
	{
		public afxZodiacGroundPlaneRenderer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacGroundPlaneRenderer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacGroundPlaneRenderer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacGroundPlaneRenderer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacGroundPlaneRenderer(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacGroundPlaneRenderer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacGroundPlaneRenderer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacGroundPlaneRenderer_create();
         private static _afxZodiacGroundPlaneRenderer_create _afxZodiacGroundPlaneRenderer_createFunc;
         internal static IntPtr afxZodiacGroundPlaneRenderer_create()
         {
         	if (_afxZodiacGroundPlaneRenderer_createFunc == null)
         	{
         		_afxZodiacGroundPlaneRenderer_createFunc =
         			(_afxZodiacGroundPlaneRenderer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacGroundPlaneRenderer_create"), typeof(_afxZodiacGroundPlaneRenderer_create));
         	}
         
         	return  _afxZodiacGroundPlaneRenderer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}