using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEffectGroupData : afxEffectBaseData
	{
		public afxEffectGroupData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEffectGroupData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEffectGroupData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEffectGroupData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEffectGroupData(SimObject pObj) : base(pObj)
		{
		}

		public afxEffectGroupData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEffectGroupData_create();
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
         				"fn_afxEffectGroupData_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addEffect(IntPtr thisPtr, IntPtr effect);
         private static _addEffect _addEffectFunc;
         internal static void addEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addEffectFunc == null)
         	{
         		_addEffectFunc =
         			(_addEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectGroupData_addEffect"), typeof(_addEffect));
         	}
         
         	 _addEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEffectGroupData_create();
         private static _afxEffectGroupData_create _afxEffectGroupData_createFunc;
         internal static IntPtr afxEffectGroupData_create()
         {
         	if (_afxEffectGroupData_createFunc == null)
         	{
         		_afxEffectGroupData_createFunc =
         			(_afxEffectGroupData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectGroupData_create"), typeof(_afxEffectGroupData_create));
         	}
         
         	return  _afxEffectGroupData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void addEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addEffect(ObjectPtr, effect.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool GroupEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GroupEnabled")); }
         	set { setFieldValue("GroupEnabled", value ? "1" : "0"); }
         }
      
         public int Count
         {
         	get { return int.Parse(getFieldValue("Count")); }
         	set { setFieldValue("Count", value.ToString()); }
         }
      
         public byte IndexOffset
         {
         	get { return byte.Parse(getFieldValue("IndexOffset")); }
         	set { setFieldValue("IndexOffset", value.ToString()); }
         }
      
         public bool AssignIndices
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AssignIndices")); }
         	set { setFieldValue("AssignIndices", value ? "1" : "0"); }
         }
      
         public float Delay
         {
         	get { return float.Parse(getFieldValue("Delay")); }
         	set { setFieldValue("Delay", value.ToString()); }
         }
      
         public float Lifetime
         {
         	get { return float.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public float FadeInTime
         {
         	get { return float.Parse(getFieldValue("FadeInTime")); }
         	set { setFieldValue("FadeInTime", value.ToString()); }
         }
      
         public float FadeOutTime
         {
         	get { return float.Parse(getFieldValue("FadeOutTime")); }
         	set { setFieldValue("FadeOutTime", value.ToString()); }
         }
      
         public afxEffectBaseData AddEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddEffect")); }
         	set { setFieldValue("AddEffect", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}