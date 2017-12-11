using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class EditorTool : SimObject
	{
		public EditorTool(bool pRegister = false)
			: base(pRegister)
		{
		}

		public EditorTool(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public EditorTool(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public EditorTool(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public EditorTool(SimObject pObj) : base(pObj)
		{
		}

		public EditorTool(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.EditorTool_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EditorTool_create();
         private static _EditorTool_create _EditorTool_createFunc;
         internal static IntPtr EditorTool_create()
         {
         	if (_EditorTool_createFunc == null)
         	{
         		_EditorTool_createFunc =
         			(_EditorTool_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_EditorTool_create"), typeof(_EditorTool_create));
         	}
         
         	return  _EditorTool_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}