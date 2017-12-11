using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WorldOffsetData : afxXM_WeightedBaseData
	{
		public afxXM_WorldOffsetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WorldOffsetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WorldOffsetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WorldOffsetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WorldOffsetData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WorldOffsetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WorldOffsetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WorldOffsetData_create();
         private static _afxXM_WorldOffsetData_create _afxXM_WorldOffsetData_createFunc;
         internal static IntPtr afxXM_WorldOffsetData_create()
         {
         	if (_afxXM_WorldOffsetData_createFunc == null)
         	{
         		_afxXM_WorldOffsetData_createFunc =
         			(_afxXM_WorldOffsetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WorldOffsetData_create"), typeof(_afxXM_WorldOffsetData_create));
         	}
         
         	return  _afxXM_WorldOffsetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F WorldOffset
         {
         	get { return new Point3F(getFieldValue("WorldOffset")); }
         	set { setFieldValue("WorldOffset", value.ToString()); }
         }
      
         public bool OffsetPos2
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OffsetPos2")); }
         	set { setFieldValue("OffsetPos2", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}