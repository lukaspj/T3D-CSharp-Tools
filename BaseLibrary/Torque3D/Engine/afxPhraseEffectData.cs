using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxPhraseEffectData : GameBaseData
	{
		public afxPhraseEffectData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxPhraseEffectData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxPhraseEffectData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxPhraseEffectData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxPhraseEffectData(SimObject pObj) : base(pObj)
		{
		}

		public afxPhraseEffectData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxPhraseEffectData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addEffect(IntPtr thisPtr, IntPtr effectData);
         private static _addEffect _addEffectFunc;
         internal static void addEffect(IntPtr thisPtr, IntPtr effectData)
         {
         	if (_addEffectFunc == null)
         	{
         		_addEffectFunc =
         			(_addEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxPhraseEffectData_addEffect"), typeof(_addEffect));
         	}
         
         	 _addEffectFunc(thisPtr, effectData);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxPhraseEffectData_create();
         private static _afxPhraseEffectData_create _afxPhraseEffectData_createFunc;
         internal static IntPtr afxPhraseEffectData_create()
         {
         	if (_afxPhraseEffectData_createFunc == null)
         	{
         		_afxPhraseEffectData_createFunc =
         			(_afxPhraseEffectData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxPhraseEffectData_create"), typeof(_afxPhraseEffectData_create));
         	}
         
         	return  _afxPhraseEffectData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addEffect(afxEffectBaseData effectData)
         {
            InternalUnsafeMethods.addEffect(ObjectPtr, effectData.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float Duration
         {
         	get { return float.Parse(getFieldValue("Duration")); }
         	set { setFieldValue("Duration", value.ToString()); }
         }
      
         public int NumLoops
         {
         	get { return int.Parse(getFieldValue("NumLoops")); }
         	set { setFieldValue("NumLoops", value.ToString()); }
         }
      
         public int TriggerMask
         {
         	get { return int.Parse(getFieldValue("TriggerMask")); }
         	set { setFieldValue("TriggerMask", value.ToString()); }
         }
      
         public afxPhraseEffect_MatchType MatchType
         {
         	get { return (afxPhraseEffect_MatchType)Enum.Parse(typeof(afxPhraseEffect_MatchType), getFieldValue("MatchType"), true); }
         	set { setFieldValue("MatchType", value.ToString()); }
         }
      
         public afxPhraseEffect_StateType MatchState
         {
         	get { return (afxPhraseEffect_StateType)Enum.Parse(typeof(afxPhraseEffect_StateType), getFieldValue("MatchState"), true); }
         	set { setFieldValue("MatchState", value.ToString()); }
         }
      
         public afxPhraseEffect_PhraseType PhraseType
         {
         	get { return (afxPhraseEffect_PhraseType)Enum.Parse(typeof(afxPhraseEffect_PhraseType), getFieldValue("PhraseType"), true); }
         	set { setFieldValue("PhraseType", value.ToString()); }
         }
      
         public bool IgnoreChoreographerTriggers
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreChoreographerTriggers")); }
         	set { setFieldValue("IgnoreChoreographerTriggers", value ? "1" : "0"); }
         }
      
         public bool IgnoreConstraintTriggers
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreConstraintTriggers")); }
         	set { setFieldValue("IgnoreConstraintTriggers", value ? "1" : "0"); }
         }
      
         public bool IgnorePlayerTriggers
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnorePlayerTriggers")); }
         	set { setFieldValue("IgnorePlayerTriggers", value ? "1" : "0"); }
         }
      
         public string OnTriggerCommand
         {
         	get { return getFieldValue("OnTriggerCommand"); }
         	set { setFieldValue("OnTriggerCommand", value); }
         }
      
         public afxEffectBaseData AddEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddEffect")); }
         	set { setFieldValue("AddEffect", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}