using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxGuiControllerData : GameBaseData
	{
		public afxGuiControllerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxGuiControllerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxGuiControllerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxGuiControllerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxGuiControllerData(SimObject pObj) : base(pObj)
		{
		}

		public afxGuiControllerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxGuiControllerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxGuiControllerData_create();
         private static _afxGuiControllerData_create _afxGuiControllerData_createFunc;
         internal static IntPtr afxGuiControllerData_create()
         {
         	if (_afxGuiControllerData_createFunc == null)
         	{
         		_afxGuiControllerData_createFunc =
         			(_afxGuiControllerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxGuiControllerData_create"), typeof(_afxGuiControllerData_create));
         	}
         
         	return  _afxGuiControllerData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ControlName
         {
         	get { return getFieldValue("ControlName"); }
         	set { setFieldValue("ControlName", value); }
         }
      
         public bool PreservePosition
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PreservePosition")); }
         	set { setFieldValue("PreservePosition", value ? "1" : "0"); }
         }
      
         public bool ControllingClientOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ControllingClientOnly")); }
         	set { setFieldValue("ControllingClientOnly", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}