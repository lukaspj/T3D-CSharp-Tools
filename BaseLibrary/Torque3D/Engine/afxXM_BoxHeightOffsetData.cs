using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_BoxHeightOffsetData : afxXM_BaseData
	{
		public afxXM_BoxHeightOffsetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_BoxHeightOffsetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_BoxHeightOffsetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_BoxHeightOffsetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_BoxHeightOffsetData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_BoxHeightOffsetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_BoxHeightOffsetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_BoxHeightOffsetData_create();
         private static _afxXM_BoxHeightOffsetData_create _afxXM_BoxHeightOffsetData_createFunc;
         internal static IntPtr afxXM_BoxHeightOffsetData_create()
         {
         	if (_afxXM_BoxHeightOffsetData_createFunc == null)
         	{
         		_afxXM_BoxHeightOffsetData_createFunc =
         			(_afxXM_BoxHeightOffsetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_BoxHeightOffsetData_create"), typeof(_afxXM_BoxHeightOffsetData_create));
         	}
         
         	return  _afxXM_BoxHeightOffsetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F Offset
         {
         	get { return new Point3F(getFieldValue("Offset")); }
         	set { setFieldValue("Offset", value.ToString()); }
         }
      
      
      #endregion

	}
}