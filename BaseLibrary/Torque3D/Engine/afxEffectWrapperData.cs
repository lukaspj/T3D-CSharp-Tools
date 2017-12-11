using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEffectWrapperData : afxEffectBaseData
	{
		public afxEffectWrapperData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEffectWrapperData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEffectWrapperData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEffectWrapperData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEffectWrapperData(SimObject pObj) : base(pObj)
		{
		}

		public afxEffectWrapperData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEffectWrapperData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEffectWrapperData_create();
         private static _afxEffectWrapperData_create _afxEffectWrapperData_createFunc;
         internal static IntPtr afxEffectWrapperData_create()
         {
         	if (_afxEffectWrapperData_createFunc == null)
         	{
         		_afxEffectWrapperData_createFunc =
         			(_afxEffectWrapperData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectWrapperData_create"), typeof(_afxEffectWrapperData_create));
         	}
         
         	return  _afxEffectWrapperData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SimDataBlock Effect
         {
         	get { return Sim.FindObject<SimDataBlock>(getFieldValue("Effect")); }
         	set { setFieldValue("Effect", value.getId().ToString()); }
         }
      
         public string EffectName
         {
         	get { return getFieldValue("EffectName"); }
         	set { setFieldValue("EffectName", value); }
         }
      
         public string Constraint
         {
         	get { return getFieldValue("Constraint"); }
         	set { setFieldValue("Constraint", value); }
         }
      
         public string PosConstraint
         {
         	get { return getFieldValue("PosConstraint"); }
         	set { setFieldValue("PosConstraint", value); }
         }
      
         public string PosConstraint2
         {
         	get { return getFieldValue("PosConstraint2"); }
         	set { setFieldValue("PosConstraint2", value); }
         }
      
         public string OrientConstraint
         {
         	get { return getFieldValue("OrientConstraint"); }
         	set { setFieldValue("OrientConstraint", value); }
         }
      
         public string LifeConstraint
         {
         	get { return getFieldValue("LifeConstraint"); }
         	set { setFieldValue("LifeConstraint", value); }
         }
      
         public bool IsConstraintSrc
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsConstraintSrc")); }
         	set { setFieldValue("IsConstraintSrc", value ? "1" : "0"); }
         }
      
         public bool GhostIsConstraintSrc
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GhostIsConstraintSrc")); }
         	set { setFieldValue("GhostIsConstraintSrc", value ? "1" : "0"); }
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
      
         public float ResidueLifetime
         {
         	get { return float.Parse(getFieldValue("ResidueLifetime")); }
         	set { setFieldValue("ResidueLifetime", value.ToString()); }
         }
      
         public Point2F FadeInEase
         {
         	get { return new Point2F(getFieldValue("FadeInEase")); }
         	set { setFieldValue("FadeInEase", value.ToString()); }
         }
      
         public Point2F FadeOutEase
         {
         	get { return new Point2F(getFieldValue("FadeOutEase")); }
         	set { setFieldValue("FadeOutEase", value.ToString()); }
         }
      
         public float LifetimeBias
         {
         	get { return float.Parse(getFieldValue("LifetimeBias")); }
         	set { setFieldValue("LifetimeBias", value.ToString()); }
         }
      
         public float FadeOutTime
         {
         	get { return float.Parse(getFieldValue("FadeOutTime")); }
         	set { setFieldValue("FadeOutTime", value.ToString()); }
         }
      
         public float RateFactor
         {
         	get { return float.Parse(getFieldValue("RateFactor")); }
         	set { setFieldValue("RateFactor", value.ToString()); }
         }
      
         public float ScaleFactor
         {
         	get { return float.Parse(getFieldValue("ScaleFactor")); }
         	set { setFieldValue("ScaleFactor", value.ToString()); }
         }
      
         public bool IsLooping
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsLooping")); }
         	set { setFieldValue("IsLooping", value ? "1" : "0"); }
         }
      
         public int LoopCount
         {
         	get { return int.Parse(getFieldValue("LoopCount")); }
         	set { setFieldValue("LoopCount", value.ToString()); }
         }
      
         public float LoopGapTime
         {
         	get { return float.Parse(getFieldValue("LoopGapTime")); }
         	set { setFieldValue("LoopGapTime", value.ToString()); }
         }
      
         public bool IgnoreTimeFactor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreTimeFactor")); }
         	set { setFieldValue("IgnoreTimeFactor", value ? "1" : "0"); }
         }
      
         public bool PropagateTimeFactor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PropagateTimeFactor")); }
         	set { setFieldValue("PropagateTimeFactor", value ? "1" : "0"); }
         }
      
         public bool EffectEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EffectEnabled")); }
         	set { setFieldValue("EffectEnabled", value ? "1" : "0"); }
         }
      
         public ByteRange RankingRange
         {
         	get { return new ByteRange(getFieldValue("RankingRange")); }
         	set { setFieldValue("RankingRange", value.ToString()); }
         }
      
         public ByteRange LevelOfDetailRange
         {
         	get { return new ByteRange(getFieldValue("LevelOfDetailRange")); }
         	set { setFieldValue("LevelOfDetailRange", value.ToString()); }
         }
      
         public int LifeConditions
         {
         	get { return int.Parse(getFieldValue("LifeConditions")); }
         	set { setFieldValue("LifeConditions", value.ToString()); }
         }
      
         public DynamicFieldVector<int> ExecConditions
         {
         	get { return new DynamicFieldVector<int>(this, "ExecConditions", 4, val => int.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<int> ExecOffConditions
         {
         	get { return new DynamicFieldVector<int>(this, "ExecOffConditions", 4, val => int.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<afxXM_BaseData> XfmModifiers
         {
         	get { return new DynamicFieldVector<afxXM_BaseData>(this, "XfmModifiers", 32, val => Sim.FindObject<afxXM_BaseData>(val), obj => obj.getId().ToString()); }
         }
      
         public Box3F ForcedBBox
         {
         	get { return new Box3F(getFieldValue("ForcedBBox")); }
         	set { setFieldValue("ForcedBBox", value.ToString()); }
         }
      
         public bool UpdateForcedBBox
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UpdateForcedBBox")); }
         	set { setFieldValue("UpdateForcedBBox", value ? "1" : "0"); }
         }
      
         public byte SortPriority
         {
         	get { return byte.Parse(getFieldValue("SortPriority")); }
         	set { setFieldValue("SortPriority", value.ToString()); }
         }
      
         public Point3F Direction
         {
         	get { return new Point3F(getFieldValue("Direction")); }
         	set { setFieldValue("Direction", value.ToString()); }
         }
      
         public float Speed
         {
         	get { return float.Parse(getFieldValue("Speed")); }
         	set { setFieldValue("Speed", value.ToString()); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public bool BorrowAltitudes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BorrowAltitudes")); }
         	set { setFieldValue("BorrowAltitudes", value ? "1" : "0"); }
         }
      
         public string VisibilityKeys
         {
         	get { return getFieldValue("VisibilityKeys"); }
         	set { setFieldValue("VisibilityKeys", value); }
         }
      
         public int GroupIndex
         {
         	get { return int.Parse(getFieldValue("GroupIndex")); }
         	set { setFieldValue("GroupIndex", value.ToString()); }
         }
      
         public int InheritGroupTiming
         {
         	get { return int.Parse(getFieldValue("InheritGroupTiming")); }
         	set { setFieldValue("InheritGroupTiming", value.ToString()); }
         }
      
      
      #endregion

	}
}