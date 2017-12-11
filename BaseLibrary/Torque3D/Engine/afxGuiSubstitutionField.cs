using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxGuiSubstitutionField : GuiInspectorField
	{
		public afxGuiSubstitutionField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxGuiSubstitutionField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxGuiSubstitutionField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxGuiSubstitutionField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxGuiSubstitutionField(SimObject pObj) : base(pObj)
		{
		}

		public afxGuiSubstitutionField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxGuiSubstitutionField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxGuiSubstitutionField_create();
         private static _afxGuiSubstitutionField_create _afxGuiSubstitutionField_createFunc;
         internal static IntPtr afxGuiSubstitutionField_create()
         {
         	if (_afxGuiSubstitutionField_createFunc == null)
         	{
         		_afxGuiSubstitutionField_createFunc =
         			(_afxGuiSubstitutionField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxGuiSubstitutionField_create"), typeof(_afxGuiSubstitutionField_create));
         	}
         
         	return  _afxGuiSubstitutionField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}