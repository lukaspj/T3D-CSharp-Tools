using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxScriptEventData : GameBaseData
	{
		public afxScriptEventData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxScriptEventData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxScriptEventData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxScriptEventData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxScriptEventData(SimObject pObj) : base(pObj)
		{
		}

		public afxScriptEventData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxScriptEventData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxScriptEventData_create();
         private static _afxScriptEventData_create _afxScriptEventData_createFunc;
         internal static IntPtr afxScriptEventData_create()
         {
         	if (_afxScriptEventData_createFunc == null)
         	{
         		_afxScriptEventData_createFunc =
         			(_afxScriptEventData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxScriptEventData_create"), typeof(_afxScriptEventData_create));
         	}
         
         	return  _afxScriptEventData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string MethodName
         {
         	get { return getFieldValue("MethodName"); }
         	set { setFieldValue("MethodName", value); }
         }
      
         public string ScriptData
         {
         	get { return getFieldValue("ScriptData"); }
         	set { setFieldValue("ScriptData", value); }
         }
      
      
      #endregion

	}
}