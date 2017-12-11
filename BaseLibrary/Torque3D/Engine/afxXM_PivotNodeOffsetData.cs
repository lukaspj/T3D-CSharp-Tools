using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_PivotNodeOffsetData : afxXM_BaseData
	{
		public afxXM_PivotNodeOffsetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_PivotNodeOffsetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_PivotNodeOffsetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_PivotNodeOffsetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_PivotNodeOffsetData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_PivotNodeOffsetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_PivotNodeOffsetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_PivotNodeOffsetData_create();
         private static _afxXM_PivotNodeOffsetData_create _afxXM_PivotNodeOffsetData_createFunc;
         internal static IntPtr afxXM_PivotNodeOffsetData_create()
         {
         	if (_afxXM_PivotNodeOffsetData_createFunc == null)
         	{
         		_afxXM_PivotNodeOffsetData_createFunc =
         			(_afxXM_PivotNodeOffsetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_PivotNodeOffsetData_create"), typeof(_afxXM_PivotNodeOffsetData_create));
         	}
         
         	return  _afxXM_PivotNodeOffsetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string NodeName
         {
         	get { return getFieldValue("NodeName"); }
         	set { setFieldValue("NodeName", value); }
         }
      
         public bool NodeIsStatic
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NodeIsStatic")); }
         	set { setFieldValue("NodeIsStatic", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}