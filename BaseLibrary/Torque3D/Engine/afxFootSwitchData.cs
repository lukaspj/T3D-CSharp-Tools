using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxFootSwitchData : GameBaseData
	{
		public afxFootSwitchData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxFootSwitchData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxFootSwitchData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxFootSwitchData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxFootSwitchData(SimObject pObj) : base(pObj)
		{
		}

		public afxFootSwitchData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxFootSwitchData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxFootSwitchData_create();
         private static _afxFootSwitchData_create _afxFootSwitchData_createFunc;
         internal static IntPtr afxFootSwitchData_create()
         {
         	if (_afxFootSwitchData_createFunc == null)
         	{
         		_afxFootSwitchData_createFunc =
         			(_afxFootSwitchData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxFootSwitchData_create"), typeof(_afxFootSwitchData_create));
         	}
         
         	return  _afxFootSwitchData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool OverrideAll
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideAll")); }
         	set { setFieldValue("OverrideAll", value ? "1" : "0"); }
         }
      
         public bool OverrideDecals
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideDecals")); }
         	set { setFieldValue("OverrideDecals", value ? "1" : "0"); }
         }
      
         public bool OverrideSounds
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideSounds")); }
         	set { setFieldValue("OverrideSounds", value ? "1" : "0"); }
         }
      
         public bool OverrideDust
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideDust")); }
         	set { setFieldValue("OverrideDust", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}