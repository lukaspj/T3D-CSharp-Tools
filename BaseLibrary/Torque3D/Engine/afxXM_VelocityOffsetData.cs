using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_VelocityOffsetData : afxXM_WeightedBaseData
	{
		public afxXM_VelocityOffsetData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_VelocityOffsetData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_VelocityOffsetData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_VelocityOffsetData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_VelocityOffsetData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_VelocityOffsetData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_VelocityOffsetData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_VelocityOffsetData_create();
         private static _afxXM_VelocityOffsetData_create _afxXM_VelocityOffsetData_createFunc;
         internal static IntPtr afxXM_VelocityOffsetData_create()
         {
         	if (_afxXM_VelocityOffsetData_createFunc == null)
         	{
         		_afxXM_VelocityOffsetData_createFunc =
         			(_afxXM_VelocityOffsetData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_VelocityOffsetData_create"), typeof(_afxXM_VelocityOffsetData_create));
         	}
         
         	return  _afxXM_VelocityOffsetData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float OffsetFactor
         {
         	get { return float.Parse(getFieldValue("OffsetFactor")); }
         	set { setFieldValue("OffsetFactor", value.ToString()); }
         }
      
         public bool OffsetPos2
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OffsetPos2")); }
         	set { setFieldValue("OffsetPos2", value ? "1" : "0"); }
         }
      
         public bool Normalize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Normalize")); }
         	set { setFieldValue("Normalize", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}