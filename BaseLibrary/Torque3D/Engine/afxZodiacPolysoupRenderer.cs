using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacPolysoupRenderer : RenderBinManager
	{
		public afxZodiacPolysoupRenderer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacPolysoupRenderer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacPolysoupRenderer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacPolysoupRenderer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacPolysoupRenderer(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacPolysoupRenderer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacPolysoupRenderer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacPolysoupRenderer_create();
         private static _afxZodiacPolysoupRenderer_create _afxZodiacPolysoupRenderer_createFunc;
         internal static IntPtr afxZodiacPolysoupRenderer_create()
         {
         	if (_afxZodiacPolysoupRenderer_createFunc == null)
         	{
         		_afxZodiacPolysoupRenderer_createFunc =
         			(_afxZodiacPolysoupRenderer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacPolysoupRenderer_create"), typeof(_afxZodiacPolysoupRenderer_create));
         	}
         
         	return  _afxZodiacPolysoupRenderer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}