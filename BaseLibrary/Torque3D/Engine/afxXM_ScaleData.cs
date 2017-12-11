using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_ScaleData : afxXM_WeightedBaseData
	{
		public afxXM_ScaleData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_ScaleData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_ScaleData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_ScaleData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_ScaleData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_ScaleData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_ScaleData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_ScaleData_create();
         private static _afxXM_ScaleData_create _afxXM_ScaleData_createFunc;
         internal static IntPtr afxXM_ScaleData_create()
         {
         	if (_afxXM_ScaleData_createFunc == null)
         	{
         		_afxXM_ScaleData_createFunc =
         			(_afxXM_ScaleData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_ScaleData_create"), typeof(_afxXM_ScaleData_create));
         	}
         
         	return  _afxXM_ScaleData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F Scale
         {
         	get { return new Point3F(getFieldValue("Scale")); }
         	set { setFieldValue("Scale", value.ToString()); }
         }
      
      
      #endregion

	}
}