using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WaveScalarData : afxXM_WaveBaseData
	{
		public afxXM_WaveScalarData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WaveScalarData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WaveScalarData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WaveScalarData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WaveScalarData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WaveScalarData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WaveScalarData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WaveScalarData_create();
         private static _afxXM_WaveScalarData_create _afxXM_WaveScalarData_createFunc;
         internal static IntPtr afxXM_WaveScalarData_create()
         {
         	if (_afxXM_WaveScalarData_createFunc == null)
         	{
         		_afxXM_WaveScalarData_createFunc =
         			(_afxXM_WaveScalarData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WaveScalarData_create"), typeof(_afxXM_WaveScalarData_create));
         	}
         
         	return  _afxXM_WaveScalarData_createFunc();
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