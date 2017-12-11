using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxGuiTextData : GameBaseData
	{
		public afxGuiTextData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxGuiTextData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxGuiTextData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxGuiTextData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxGuiTextData(SimObject pObj) : base(pObj)
		{
		}

		public afxGuiTextData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxGuiTextData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxGuiTextData_create();
         private static _afxGuiTextData_create _afxGuiTextData_createFunc;
         internal static IntPtr afxGuiTextData_create()
         {
         	if (_afxGuiTextData_createFunc == null)
         	{
         		_afxGuiTextData_createFunc =
         			(_afxGuiTextData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxGuiTextData_create"), typeof(_afxGuiTextData_create));
         	}
         
         	return  _afxGuiTextData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Text
         {
         	get { return getFieldValue("Text"); }
         	set { setFieldValue("Text", value); }
         }
      
         public LinearColorF Color
         {
         	get { return new LinearColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
      
      #endregion

	}
}