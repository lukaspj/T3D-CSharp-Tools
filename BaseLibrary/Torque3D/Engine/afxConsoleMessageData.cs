using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxConsoleMessageData : GameBaseData
	{
		public afxConsoleMessageData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxConsoleMessageData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxConsoleMessageData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxConsoleMessageData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxConsoleMessageData(SimObject pObj) : base(pObj)
		{
		}

		public afxConsoleMessageData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxConsoleMessageData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxConsoleMessageData_create();
         private static _afxConsoleMessageData_create _afxConsoleMessageData_createFunc;
         internal static IntPtr afxConsoleMessageData_create()
         {
         	if (_afxConsoleMessageData_createFunc == null)
         	{
         		_afxConsoleMessageData_createFunc =
         			(_afxConsoleMessageData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxConsoleMessageData_create"), typeof(_afxConsoleMessageData_create));
         	}
         
         	return  _afxConsoleMessageData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Message
         {
         	get { return getFieldValue("Message"); }
         	set { setFieldValue("Message", value); }
         }
      
      
      #endregion

	}
}