using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_WaveBaseData : afxXM_WeightedBaseData
	{
		public afxXM_WaveBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_WaveBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_WaveBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_WaveBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_WaveBaseData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_WaveBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_WaveBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_WaveBaseData_create();
         private static _afxXM_WaveBaseData_create _afxXM_WaveBaseData_createFunc;
         internal static IntPtr afxXM_WaveBaseData_create()
         {
         	if (_afxXM_WaveBaseData_createFunc == null)
         	{
         		_afxXM_WaveBaseData_createFunc =
         			(_afxXM_WaveBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_WaveBaseData_create"), typeof(_afxXM_WaveBaseData_create));
         	}
         
         	return  _afxXM_WaveBaseData_createFunc();
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
         	set { setFieldValue("Parameter", value.ToString()); }
         }
      
         public afxXM_WaveOpType Op
         {
         	get { return (afxXM_WaveOpType)Enum.Parse(typeof(afxXM_WaveOpType), getFieldValue("Op"), true); }
         	set { setFieldValue("Op", value.ToString()); }
         }
      
         public float Speed
         {
         	get { return float.Parse(getFieldValue("Speed")); }
         	set { setFieldValue("Speed", value.ToString()); }
         }
      
         public float SpeedVariance
         {
         	get { return float.Parse(getFieldValue("SpeedVariance")); }
         	set { setFieldValue("SpeedVariance", value.ToString()); }
         }
      
         public float Acceleration
         {
         	get { return float.Parse(getFieldValue("Acceleration")); }
         	set { setFieldValue("Acceleration", value.ToString()); }
         }
      
         public float PhaseShift
         {
         	get { return float.Parse(getFieldValue("PhaseShift")); }
         	set { setFieldValue("PhaseShift", value.ToString()); }
         }
      
         public float DutyCycle
         {
         	get { return float.Parse(getFieldValue("DutyCycle")); }
         	set { setFieldValue("DutyCycle", value.ToString()); }
         }
      
         public float DutyShift
         {
         	get { return float.Parse(getFieldValue("DutyShift")); }
         	set { setFieldValue("DutyShift", value.ToString()); }
         }
      
         public float OffDutyT
         {
         	get { return float.Parse(getFieldValue("OffDutyT")); }
         	set { setFieldValue("OffDutyT", value.ToString()); }
         }
      
         public ByteRange WavesPerPulse
         {
         	get { return new ByteRange(getFieldValue("WavesPerPulse")); }
         	set { setFieldValue("WavesPerPulse", value.ToString()); }
         }
      
         public ByteRange WavesPerRest
         {
         	get { return new ByteRange(getFieldValue("WavesPerRest")); }
         	set { setFieldValue("WavesPerRest", value.ToString()); }
         }
      
         public float RestDuration
         {
         	get { return float.Parse(getFieldValue("RestDuration")); }
         	set { setFieldValue("RestDuration", value.ToString()); }
         }
      
         public float RestDurationVariance
         {
         	get { return float.Parse(getFieldValue("RestDurationVariance")); }
         	set { setFieldValue("RestDurationVariance", value.ToString()); }
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