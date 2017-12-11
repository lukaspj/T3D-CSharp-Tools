using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxCollisionEventData : GameBaseData
	{
		public afxCollisionEventData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxCollisionEventData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxCollisionEventData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxCollisionEventData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxCollisionEventData(SimObject pObj) : base(pObj)
		{
		}

		public afxCollisionEventData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxCollisionEventData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxCollisionEventData_create();
         private static _afxCollisionEventData_create _afxCollisionEventData_createFunc;
         internal static IntPtr afxCollisionEventData_create()
         {
         	if (_afxCollisionEventData_createFunc == null)
         	{
         		_afxCollisionEventData_createFunc =
         			(_afxCollisionEventData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCollisionEventData_create"), typeof(_afxCollisionEventData_create));
         	}
         
         	return  _afxCollisionEventData_createFunc();
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
      
         public bool GenerateTrigger
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GenerateTrigger")); }
         	set { setFieldValue("GenerateTrigger", value ? "1" : "0"); }
         }
      
         public byte TriggerBit
         {
         	get { return byte.Parse(getFieldValue("TriggerBit")); }
         	set { setFieldValue("TriggerBit", value.ToString()); }
         }
      
      
      #endregion

	}
}