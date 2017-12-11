using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WaveRiderBaseData : afxXM_WeightedBaseData
	{
		public afxXM_WaveRiderBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WaveRiderBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WaveRiderBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WaveRiderBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WaveRiderBaseData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WaveRiderBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WaveRiderBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WaveRiderBaseData_create();
         private static _afxXM_WaveRiderBaseData_create _afxXM_WaveRiderBaseData_createFunc;
         internal static IntPtr afxXM_WaveRiderBaseData_create()
         {
         	if (_afxXM_WaveRiderBaseData_createFunc == null)
         	{
         		_afxXM_WaveRiderBaseData_createFunc =
         			(_afxXM_WaveRiderBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WaveRiderBaseData_create"), typeof(_afxXM_WaveRiderBaseData_create));
         	}
         
         	return  _afxXM_WaveRiderBaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public afxXM_WaveFormType Waveform
         {
         	get { return (afxXM_WaveFormType)Enum.Parse(typeof(afxXM_WaveFormType), getFieldValue("Waveform"), true); }
         	set { setFieldValue("Waveform", value.ToString()); }
         }
      
         public string Parameter
         {
         	get { return getFieldValue("Parameter"); }
         	set { setFieldValue("Parameter", value); }
         }
      
         public afxXM_WaveOpType Op
         {
         	get { return (afxXM_WaveOpType)Enum.Parse(typeof(afxXM_WaveOpType), getFieldValue("Op"), true); }
         	set { setFieldValue("Op", value.ToString()); }
         }
      
         public float OffDutyT
         {
         	get { return float.Parse(getFieldValue("OffDutyT")); }
         	set { setFieldValue("OffDutyT", value.ToString()); }
         }
      
         public Point3F Axis
         {
         	get { return new Point3F(getFieldValue("Axis")); }
         	set { setFieldValue("Axis", value.ToString()); }
         }
      
         public bool AxisIsLocal
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AxisIsLocal")); }
         	set { setFieldValue("AxisIsLocal", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}