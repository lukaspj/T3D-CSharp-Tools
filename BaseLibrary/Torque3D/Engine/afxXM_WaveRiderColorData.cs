using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WaveRiderColorData : afxXM_WaveRiderBaseData
	{
		public afxXM_WaveRiderColorData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WaveRiderColorData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WaveRiderColorData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WaveRiderColorData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WaveRiderColorData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WaveRiderColorData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WaveRiderColorData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WaveRiderColorData_create();
         private static _afxXM_WaveRiderColorData_create _afxXM_WaveRiderColorData_createFunc;
         internal static IntPtr afxXM_WaveRiderColorData_create()
         {
         	if (_afxXM_WaveRiderColorData_createFunc == null)
         	{
         		_afxXM_WaveRiderColorData_createFunc =
         			(_afxXM_WaveRiderColorData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WaveRiderColorData_create"), typeof(_afxXM_WaveRiderColorData_create));
         	}
         
         	return  _afxXM_WaveRiderColorData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public LinearColorF A
         {
         	get { return new LinearColorF(getFieldValue("A")); }
         	set { setFieldValue("A", value.ToString()); }
         }
      
         public LinearColorF B
         {
         	get { return new LinearColorF(getFieldValue("B")); }
         	set { setFieldValue("B", value.ToString()); }
         }
      
         public LinearColorF AVariance
         {
         	get { return new LinearColorF(getFieldValue("AVariance")); }
         	set { setFieldValue("AVariance", value.ToString()); }
         }
      
         public LinearColorF BVariance
         {
         	get { return new LinearColorF(getFieldValue("BVariance")); }
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