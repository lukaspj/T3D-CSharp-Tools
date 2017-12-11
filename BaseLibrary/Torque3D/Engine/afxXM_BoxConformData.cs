using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_BoxConformData : afxXM_BaseData
	{
		public afxXM_BoxConformData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_BoxConformData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_BoxConformData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_BoxConformData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_BoxConformData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_BoxConformData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_BoxConformData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_BoxConformData_create();
         private static _afxXM_BoxConformData_create _afxXM_BoxConformData_createFunc;
         internal static IntPtr afxXM_BoxConformData_create()
         {
         	if (_afxXM_BoxConformData_createFunc == null)
         	{
         		_afxXM_BoxConformData_createFunc =
         			(_afxXM_BoxConformData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_BoxConformData_create"), typeof(_afxXM_BoxConformData_create));
         	}
         
         	return  _afxXM_BoxConformData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public afxXM_BoxConformType BoxAlignment
         {
         	get { return (afxXM_BoxConformType)Enum.Parse(typeof(afxXM_BoxConformType), getFieldValue("BoxAlignment"), true); }
         	set { setFieldValue("BoxAlignment", value.ToString()); }
         }
      
      
      #endregion

	}
}