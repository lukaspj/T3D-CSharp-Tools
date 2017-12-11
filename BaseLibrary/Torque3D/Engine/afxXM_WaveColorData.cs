using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WaveColorData : afxXM_WaveBaseData
	{
		public afxXM_WaveColorData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WaveColorData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WaveColorData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WaveColorData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WaveColorData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WaveColorData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WaveColorData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WaveColorData_create();
         private static _afxXM_WaveColorData_create _afxXM_WaveColorData_createFunc;
         internal static IntPtr afxXM_WaveColorData_create()
         {
         	if (_afxXM_WaveColorData_createFunc == null)
         	{
         		_afxXM_WaveColorData_createFunc =
         			(_afxXM_WaveColorData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WaveColorData_create"), typeof(_afxXM_WaveColorData_create));
         	}
         
         	return  _afxXM_WaveColorData_createFunc();
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