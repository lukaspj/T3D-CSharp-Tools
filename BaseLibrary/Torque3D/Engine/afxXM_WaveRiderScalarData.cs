using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WaveRiderScalarData : afxXM_WaveRiderBaseData
	{
		public afxXM_WaveRiderScalarData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WaveRiderScalarData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WaveRiderScalarData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WaveRiderScalarData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WaveRiderScalarData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WaveRiderScalarData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WaveRiderScalarData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WaveRiderScalarData_create();
         private static _afxXM_WaveRiderScalarData_create _afxXM_WaveRiderScalarData_createFunc;
         internal static IntPtr afxXM_WaveRiderScalarData_create()
         {
         	if (_afxXM_WaveRiderScalarData_createFunc == null)
         	{
         		_afxXM_WaveRiderScalarData_createFunc =
         			(_afxXM_WaveRiderScalarData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WaveRiderScalarData_create"), typeof(_afxXM_WaveRiderScalarData_create));
         	}
         
         	return  _afxXM_WaveRiderScalarData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float A
         {
         	get { return float.Parse(getFieldValue("A")); }
         	set { setFieldValue("A", value.ToString()); }
         }
      
         public float B
         {
         	get { return float.Parse(getFieldValue("B")); }
         	set { setFieldValue("B", value.ToString()); }
         }
      
         public float AVariance
         {
         	get { return float.Parse(getFieldValue("AVariance")); }
         	set { setFieldValue("AVariance", value.ToString()); }
         }
      
         public float BVariance
         {
         	get { return float.Parse(getFieldValue("BVariance")); }
         	set { setFieldValue("BVariance", value.ToString()); }
         }
      
         public bool SyncVariances
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SyncVariances")); }
         	set { setFieldValue("SyncVariances", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}