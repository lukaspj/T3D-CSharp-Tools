using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxZodiacMeshRoadRenderer : RenderBinManager
	{
		public afxZodiacMeshRoadRenderer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxZodiacMeshRoadRenderer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxZodiacMeshRoadRenderer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxZodiacMeshRoadRenderer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxZodiacMeshRoadRenderer(SimObject pObj) : base(pObj)
		{
		}

		public afxZodiacMeshRoadRenderer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxZodiacMeshRoadRenderer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxZodiacMeshRoadRenderer_create();
         private static _afxZodiacMeshRoadRenderer_create _afxZodiacMeshRoadRenderer_createFunc;
         internal static IntPtr afxZodiacMeshRoadRenderer_create()
         {
         	if (_afxZodiacMeshRoadRenderer_createFunc == null)
         	{
         		_afxZodiacMeshRoadRenderer_createFunc =
         			(_afxZodiacMeshRoadRenderer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxZodiacMeshRoadRenderer_create"), typeof(_afxZodiacMeshRoadRenderer_create));
         	}
         
         	return  _afxZodiacMeshRoadRenderer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}