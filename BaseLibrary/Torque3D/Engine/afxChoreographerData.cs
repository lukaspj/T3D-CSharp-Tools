using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxChoreographerData : GameBaseData
	{
		public afxChoreographerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxChoreographerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxChoreographerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxChoreographerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxChoreographerData(SimObject pObj) : base(pObj)
		{
		}

		public afxChoreographerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxChoreographerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxChoreographerData_create();
         private static _afxChoreographerData_create _afxChoreographerData_createFunc;
         internal static IntPtr afxChoreographerData_create()
         {
         	if (_afxChoreographerData_createFunc == null)
         	{
         		_afxChoreographerData_createFunc =
         			(_afxChoreographerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographerData_create"), typeof(_afxChoreographerData_create));
         	}
         
         	return  _afxChoreographerData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool ExecOnNewClients
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ExecOnNewClients")); }
         	set { setFieldValue("ExecOnNewClients", value ? "1" : "0"); }
         }
      
         public byte EchoPacketUsage
         {
         	get { return byte.Parse(getFieldValue("EchoPacketUsage")); }
         	set { setFieldValue("EchoPacketUsage", value.ToString()); }
         }
      
         public string ClientScriptFile
         {
         	get { return getFieldValue("ClientScriptFile"); }
         	set { setFieldValue("ClientScriptFile", value); }
         }
      
         public string ClientInitFunction
         {
         	get { return getFieldValue("ClientInitFunction"); }
         	set { setFieldValue("ClientInitFunction", value); }
         }
      
      
      #endregion

	}
}