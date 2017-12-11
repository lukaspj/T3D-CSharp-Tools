using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_PathConformData : afxXM_WeightedBaseData
	{
		public afxXM_PathConformData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_PathConformData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_PathConformData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_PathConformData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_PathConformData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_PathConformData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_PathConformData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_PathConformData_create();
         private static _afxXM_PathConformData_create _afxXM_PathConformData_createFunc;
         internal static IntPtr afxXM_PathConformData_create()
         {
         	if (_afxXM_PathConformData_createFunc == null)
         	{
         		_afxXM_PathConformData_createFunc =
         			(_afxXM_PathConformData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_PathConformData_create"), typeof(_afxXM_PathConformData_create));
         	}
         
         	return  _afxXM_PathConformData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Paths
         {
         	get { return getFieldValue("Paths"); }
         	set { setFieldValue("Paths", value); }
         }
      
         public float PathMult
         {
         	get { return float.Parse(getFieldValue("PathMult")); }
         	set { setFieldValue("PathMult", value.ToString()); }
         }
      
         public float PathTimeOffset
         {
         	get { return float.Parse(getFieldValue("PathTimeOffset")); }
         	set { setFieldValue("PathTimeOffset", value.ToString()); }
         }
      
         public bool OrientToPath
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OrientToPath")); }
         	set { setFieldValue("OrientToPath", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}