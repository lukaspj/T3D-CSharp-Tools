using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMagicSpellData : afxChoreographerData
	{
		public afxMagicSpellData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMagicSpellData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMagicSpellData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMagicSpellData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMagicSpellData(SimObject pObj) : base(pObj)
		{
		}

		public afxMagicSpellData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMagicSpellData_create();
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
         				"fn_afxMagicSpellData_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addCastingEffect(IntPtr thisPtr, IntPtr effect);
         private static _addCastingEffect _addCastingEffectFunc;
         internal static void addCastingEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addCastingEffectFunc == null)
         	{
         		_addCastingEffectFunc =
         			(_addCastingEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpellData_addCastingEffect"), typeof(_addCastingEffect));
         	}
         
         	 _addCastingEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addLaunchEffect(IntPtr thisPtr, IntPtr effect);
         private static _addLaunchEffect _addLaunchEffectFunc;
         internal static void addLaunchEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addLaunchEffectFunc == null)
         	{
         		_addLaunchEffectFunc =
         			(_addLaunchEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpellData_addLaunchEffect"), typeof(_addLaunchEffect));
         	}
         
         	 _addLaunchEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addDeliveryEffect(IntPtr thisPtr, IntPtr effect);
         private static _addDeliveryEffect _addDeliveryEffectFunc;
         internal static void addDeliveryEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addDeliveryEffectFunc == null)
         	{
         		_addDeliveryEffectFunc =
         			(_addDeliveryEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpellData_addDeliveryEffect"), typeof(_addDeliveryEffect));
         	}
         
         	 _addDeliveryEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addImpactEffect(IntPtr thisPtr, IntPtr effect);
         private static _addImpactEffect _addImpactEffectFunc;
         internal static void addImpactEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addImpactEffectFunc == null)
         	{
         		_addImpactEffectFunc =
         			(_addImpactEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpellData_addImpactEffect"), typeof(_addImpactEffect));
         	}
         
         	 _addImpactEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addLingerEffect(IntPtr thisPtr, IntPtr effect);
         private static _addLingerEffect _addLingerEffectFunc;
         internal static void addLingerEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addLingerEffectFunc == null)
         	{
         		_addLingerEffectFunc =
         			(_addLingerEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpellData_addLingerEffect"), typeof(_addLingerEffect));
         	}
         
         	 _addLingerEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMagicSpellData_create();
         private static _afxMagicSpellData_create _afxMagicSpellData_createFunc;
         internal static IntPtr afxMagicSpellData_create()
         {
         	if (_afxMagicSpellData_createFunc == null)
         	{
         		_afxMagicSpellData_createFunc =
         			(_afxMagicSpellData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpellData_create"), typeof(_afxMagicSpellData_create));
         	}
         
         	return  _afxMagicSpellData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void addCastingEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addCastingEffect(ObjectPtr, effect.ObjectPtr);
         }
      
         public virtual void addLaunchEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addLaunchEffect(ObjectPtr, effect.ObjectPtr);
         }
      
         public virtual void addDeliveryEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addDeliveryEffect(ObjectPtr, effect.ObjectPtr);
         }
      
         public virtual void addImpactEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addImpactEffect(ObjectPtr, effect.ObjectPtr);
         }
      
         public virtual void addLingerEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addLingerEffect(ObjectPtr, effect.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float CastingDur
         {
         	get { return float.Parse(getFieldValue("CastingDur")); }
         	set { setFieldValue("CastingDur", value.ToString()); }
         }
      
         public int NumCastingLoops
         {
         	get { return int.Parse(getFieldValue("NumCastingLoops")); }
         	set { setFieldValue("NumCastingLoops", value.ToString()); }
         }
      
         public float ExtraCastingTime
         {
         	get { return float.Parse(getFieldValue("ExtraCastingTime")); }
         	set { setFieldValue("ExtraCastingTime", value.ToString()); }
         }
      
         public afxEffectBaseData AddCastingEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddCastingEffect")); }
         	set { setFieldValue("AddCastingEffect", value.getId().ToString()); }
         }
      
         public float DeliveryDur
         {
         	get { return float.Parse(getFieldValue("DeliveryDur")); }
         	set { setFieldValue("DeliveryDur", value.ToString()); }
         }
      
         public int NumDeliveryLoops
         {
         	get { return int.Parse(getFieldValue("NumDeliveryLoops")); }
         	set { setFieldValue("NumDeliveryLoops", value.ToString()); }
         }
      
         public float ExtraDeliveryTime
         {
         	get { return float.Parse(getFieldValue("ExtraDeliveryTime")); }
         	set { setFieldValue("ExtraDeliveryTime", value.ToString()); }
         }
      
         public afxEffectBaseData AddLaunchEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddLaunchEffect")); }
         	set { setFieldValue("AddLaunchEffect", value.getId().ToString()); }
         }
      
         public afxEffectBaseData AddDeliveryEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddDeliveryEffect")); }
         	set { setFieldValue("AddDeliveryEffect", value.getId().ToString()); }
         }
      
         public float LingerDur
         {
         	get { return float.Parse(getFieldValue("LingerDur")); }
         	set { setFieldValue("LingerDur", value.ToString()); }
         }
      
         public int NumLingerLoops
         {
         	get { return int.Parse(getFieldValue("NumLingerLoops")); }
         	set { setFieldValue("NumLingerLoops", value.ToString()); }
         }
      
         public float ExtraLingerTime
         {
         	get { return float.Parse(getFieldValue("ExtraLingerTime")); }
         	set { setFieldValue("ExtraLingerTime", value.ToString()); }
         }
      
         public afxEffectBaseData AddImpactEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddImpactEffect")); }
         	set { setFieldValue("AddImpactEffect", value.getId().ToString()); }
         }
      
         public afxEffectBaseData AddLingerEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddLingerEffect")); }
         	set { setFieldValue("AddLingerEffect", value.getId().ToString()); }
         }
      
         public bool AllowMovementInterrupts
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowMovementInterrupts")); }
         	set { setFieldValue("AllowMovementInterrupts", value ? "1" : "0"); }
         }
      
         public float MovementInterruptSpeed
         {
         	get { return float.Parse(getFieldValue("MovementInterruptSpeed")); }
         	set { setFieldValue("MovementInterruptSpeed", value.ToString()); }
         }
      
         public afxMagicMissileData Missile
         {
         	get { return Sim.FindObject<afxMagicMissileData>(getFieldValue("Missile")); }
         	set { setFieldValue("Missile", value.getId().ToString()); }
         }
      
         public bool LaunchOnServerSignal
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LaunchOnServerSignal")); }
         	set { setFieldValue("LaunchOnServerSignal", value ? "1" : "0"); }
         }
      
         public int PrimaryTargetTypes
         {
         	get { return int.Parse(getFieldValue("PrimaryTargetTypes")); }
         	set { setFieldValue("PrimaryTargetTypes", value.ToString()); }
         }
      
      
      #endregion

	}
}