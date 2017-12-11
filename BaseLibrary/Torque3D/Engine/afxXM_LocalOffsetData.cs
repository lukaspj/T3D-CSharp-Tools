using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_LocalOffsetData : afxXM_WeightedBaseData
	{
		public afxXM_LocalOffsetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_LocalOffsetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_LocalOffsetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_LocalOffsetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_LocalOffsetData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_LocalOffsetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_LocalOffsetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_LocalOffsetData_create();
         private static _afxXM_LocalOffsetData_create _afxXM_LocalOffsetData_createFunc;
         internal static IntPtr afxXM_LocalOffsetData_create()
         {
         	if (_afxXM_LocalOffsetData_createFunc == null)
         	{
         		_afxXM_LocalOffsetData_createFunc =
         			(_afxXM_LocalOffsetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_LocalOffsetData_create"), typeof(_afxXM_LocalOffsetData_create));
         	}
         
         	return  _afxXM_LocalOffsetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F LocalOffset
         {
         	get { return new Point3F(getFieldValue("LocalOffset")); }
         	set { setFieldValue("LocalOffset", value.ToString()); }
         }
      
         public bool OffsetPos2
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OffsetPos2")); }
         	set { setFieldValue("OffsetPos2", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}