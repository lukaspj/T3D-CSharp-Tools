using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_BoxAdaptData : afxXM_WeightedBaseData
	{
		public afxXM_BoxAdaptData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_BoxAdaptData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_BoxAdaptData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_BoxAdaptData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_BoxAdaptData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_BoxAdaptData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_BoxAdaptData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_BoxAdaptData_create();
         private static _afxXM_BoxAdaptData_create _afxXM_BoxAdaptData_createFunc;
         internal static IntPtr afxXM_BoxAdaptData_create()
         {
         	if (_afxXM_BoxAdaptData_createFunc == null)
         	{
         		_afxXM_BoxAdaptData_createFunc =
         			(_afxXM_BoxAdaptData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_BoxAdaptData_create"), typeof(_afxXM_BoxAdaptData_create));
         	}
         
         	return  _afxXM_BoxAdaptData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float ScaleFactor
         {
         	get { return float.Parse(getFieldValue("ScaleFactor")); }
         	set { setFieldValue("ScaleFactor", value.ToString()); }
         }
      
         public Point2F DimensionRange
         {
         	get { return new Point2F(getFieldValue("DimensionRange")); }
         	set { setFieldValue("DimensionRange", value.ToString()); }
         }
      
      
      #endregion

	}
}