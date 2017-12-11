using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacTerrainRenderer : RenderBinManager
	{
		public afxZodiacTerrainRenderer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacTerrainRenderer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacTerrainRenderer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacTerrainRenderer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacTerrainRenderer(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacTerrainRenderer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacTerrainRenderer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacTerrainRenderer_create();
         private static _afxZodiacTerrainRenderer_create _afxZodiacTerrainRenderer_createFunc;
         internal static IntPtr afxZodiacTerrainRenderer_create()
         {
         	if (_afxZodiacTerrainRenderer_createFunc == null)
         	{
         		_afxZodiacTerrainRenderer_createFunc =
         			(_afxZodiacTerrainRenderer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacTerrainRenderer_create"), typeof(_afxZodiacTerrainRenderer_create));
         	}
         
         	return  _afxZodiacTerrainRenderer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}