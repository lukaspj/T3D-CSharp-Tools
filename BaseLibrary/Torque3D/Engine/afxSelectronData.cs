using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxSelectronData : afxChoreographerData
	{
		public afxSelectronData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxSelectronData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxSelectronData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxSelectronData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxSelectronData(SimObject pObj) : base(pObj)
		{
		}

		public afxSelectronData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxSelectronData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSelectronData_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxSelectronData_create();
         private static _afxSelectronData_create _afxSelectronData_createFunc;
         internal static IntPtr afxSelectronData_create()
         {
         	if (_afxSelectronData_createFunc == null)
         	{
         		_afxSelectronData_createFunc =
         			(_afxSelectronData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSelectronData_create"), typeof(_afxSelectronData_create));
         	}
         
         	return  _afxSelectronData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float MainDur
         {
         	get { return float.Parse(getFieldValue("MainDur")); }
         	set { setFieldValue("MainDur", value.ToString()); }
         }
      
         public float SelectDur
         {
         	get { return float.Parse(getFieldValue("SelectDur")); }
         	set { setFieldValue("SelectDur", value.ToString()); }
         }
      
         public float DeselectDur
         {
         	get { return float.Parse(getFieldValue("DeselectDur")); }
         	set { setFieldValue("DeselectDur", value.ToString()); }
         }
      
         public int MainRepeats
         {
         	get { return int.Parse(getFieldValue("MainRepeats")); }
         	set { setFieldValue("MainRepeats", value.ToString()); }
         }
      
         public int SelectRepeats
         {
         	get { return int.Parse(getFieldValue("SelectRepeats")); }
         	set { setFieldValue("SelectRepeats", value.ToString()); }
         }
      
         public int DeselectRepeats
         {
         	get { return int.Parse(getFieldValue("DeselectRepeats")); }
         	set { setFieldValue("DeselectRepeats", value.ToString()); }
         }
      
         public int SelectionTypeMask
         {
         	get { return int.Parse(getFieldValue("SelectionTypeMask")); }
         	set { setFieldValue("SelectionTypeMask", value.ToString()); }
         }
      
         public byte SelectionTypeStyle
         {
         	get { return byte.Parse(getFieldValue("SelectionTypeStyle")); }
         	set { setFieldValue("SelectionTypeStyle", value.ToString()); }
         }
      
         public afxEffectBaseData AddMainEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddMainEffect")); }
         	set { setFieldValue("AddMainEffect", value.getId().ToString()); }
         }
      
         public afxEffectBaseData AddSelectEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddSelectEffect")); }
         	set { setFieldValue("AddSelectEffect", value.getId().ToString()); }
         }
      
         public afxEffectBaseData AddDeselectEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddDeselectEffect")); }
         	set { setFieldValue("AddDeselectEffect", value.getId().ToString()); }
         }
      
         public int NumMainLoops
         {
         	get { return int.Parse(getFieldValue("NumMainLoops")); }
         	set { setFieldValue("NumMainLoops", value.ToString()); }
         }
      
         public int NumSelectLoops
         {
         	get { return int.Parse(getFieldValue("NumSelectLoops")); }
         	set { setFieldValue("NumSelectLoops", value.ToString()); }
         }
      
         public int NumDeselectLoops
         {
         	get { return int.Parse(getFieldValue("NumDeselectLoops")); }
         	set { setFieldValue("NumDeselectLoops", value.ToString()); }
         }
      
      
      #endregion

	}
}