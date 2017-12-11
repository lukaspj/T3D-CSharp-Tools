using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_BaseData : GameBaseData
	{
		public afxXM_BaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_BaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_BaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_BaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_BaseData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_BaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_BaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_BaseData_create();
         private static _afxXM_BaseData_create _afxXM_BaseData_createFunc;
         internal static IntPtr afxXM_BaseData_create()
         {
         	if (_afxXM_BaseData_createFunc == null)
         	{
         		_afxXM_BaseData_createFunc =
         			(_afxXM_BaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_BaseData_create"), typeof(_afxXM_BaseData_create));
         	}
         
         	return  _afxXM_BaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool IgnoreTimeFactor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreTimeFactor")); }
         	set { setFieldValue("IgnoreTimeFactor", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}