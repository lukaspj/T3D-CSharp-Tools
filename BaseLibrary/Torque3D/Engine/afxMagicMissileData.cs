using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMagicMissileData : GameBaseData
	{
		public afxMagicMissileData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMagicMissileData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMagicMissileData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMagicMissileData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMagicMissileData(SimObject pObj) : base(pObj)
		{
		}

		public afxMagicMissileData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMagicMissileData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMagicMissileData_create();
         private static _afxMagicMissileData_create _afxMagicMissileData_createFunc;
         internal static IntPtr afxMagicMissileData_create()
         {
         	if (_afxMagicMissileData_createFunc == null)
         	{
         		_afxMagicMissileData_createFunc =
         			(_afxMagicMissileData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicMissileData_create"), typeof(_afxMagicMissileData_create));
         	}
         
         	return  _afxMagicMissileData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ParticleEmitterData ParticleEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ParticleEmitter")); }
         	set { setFieldValue("ParticleEmitter", value.getId().ToString()); }
         }
      
         public ParticleEmitterData ParticleWaterEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ParticleWaterEmitter")); }
         	set { setFieldValue("ParticleWaterEmitter", value.getId().ToString()); }
         }
      
         public string ProjectileShapeName
         {
         	get { return getFieldValue("ProjectileShapeName"); }
         	set { setFieldValue("ProjectileShapeName", value); }
         }
      
         public Point3F Scale
         {
         	get { return new Point3F(getFieldValue("Scale")); }
         	set { setFieldValue("Scale", value.ToString()); }
         }
      
         public SFXTrack Sound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("Sound")); }
         	set { setFieldValue("Sound", value.getId().ToString()); }
         }
      
         public SplashData Splash
         {
         	get { return Sim.FindObject<SplashData>(getFieldValue("Splash")); }
         	set { setFieldValue("Splash", value.getId().ToString()); }
         }
      
         public LightDescription LightDesc
         {
         	get { return Sim.FindObject<LightDescription>(getFieldValue("LightDesc")); }
         	set { setFieldValue("LightDesc", value.getId().ToString()); }
         }
      
         public bool IsBallistic
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsBallistic")); }
         	set { setFieldValue("IsBallistic", value ? "1" : "0"); }
         }
      
         public float MuzzleVelocity
         {
         	get { return float.Parse(getFieldValue("MuzzleVelocity")); }
         	set { setFieldValue("MuzzleVelocity", value.ToString()); }
         }
      
         public int Lifetime
         {
         	get { return int.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public float GravityMod
         {
         	get { return float.Parse(getFieldValue("GravityMod")); }
         	set { setFieldValue("GravityMod", value.ToString()); }
         }
      
         public string MissileShapeName
         {
         	get { return getFieldValue("MissileShapeName"); }
         	set { setFieldValue("MissileShapeName", value); }
         }
      
         public Point3F MissileShapeScale
         {
         	get { return new Point3F(getFieldValue("MissileShapeScale")); }
         	set { setFieldValue("MissileShapeScale", value.ToString()); }
         }
      
         public Point3F StartingVelocityVector
         {
         	get { return new Point3F(getFieldValue("StartingVelocityVector")); }
         	set { setFieldValue("StartingVelocityVector", value.ToString()); }
         }
      
         public bool IsGuided
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsGuided")); }
         	set { setFieldValue("IsGuided", value ? "1" : "0"); }
         }
      
         public float Precision
         {
         	get { return float.Parse(getFieldValue("Precision")); }
         	set { setFieldValue("Precision", value.ToString()); }
         }
      
         public int TrackDelay
         {
         	get { return int.Parse(getFieldValue("TrackDelay")); }
         	set { setFieldValue("TrackDelay", value.ToString()); }
         }
      
         public float BallisticCoefficient
         {
         	get { return float.Parse(getFieldValue("BallisticCoefficient")); }
         	set { setFieldValue("BallisticCoefficient", value.ToString()); }
         }
      
         public int CollisionMask
         {
         	get { return int.Parse(getFieldValue("CollisionMask")); }
         	set { setFieldValue("CollisionMask", value.ToString()); }
         }
      
         public bool FollowTerrain
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FollowTerrain")); }
         	set { setFieldValue("FollowTerrain", value ? "1" : "0"); }
         }
      
         public float FollowTerrainHeight
         {
         	get { return float.Parse(getFieldValue("FollowTerrainHeight")); }
         	set { setFieldValue("FollowTerrainHeight", value.ToString()); }
         }
      
         public float FollowTerrainAdjustRate
         {
         	get { return float.Parse(getFieldValue("FollowTerrainAdjustRate")); }
         	set { setFieldValue("FollowTerrainAdjustRate", value.ToString()); }
         }
      
         public int FollowTerrainAdjustDelay
         {
         	get { return int.Parse(getFieldValue("FollowTerrainAdjustDelay")); }
         	set { setFieldValue("FollowTerrainAdjustDelay", value.ToString()); }
         }
      
         public float Acceleration
         {
         	get { return float.Parse(getFieldValue("Acceleration")); }
         	set { setFieldValue("Acceleration", value.ToString()); }
         }
      
         public int AccelDelay
         {
         	get { return int.Parse(getFieldValue("AccelDelay")); }
         	set { setFieldValue("AccelDelay", value.ToString()); }
         }
      
         public int AccelLifetime
         {
         	get { return int.Parse(getFieldValue("AccelLifetime")); }
         	set { setFieldValue("AccelLifetime", value.ToString()); }
         }
      
         public string LaunchNode
         {
         	get { return getFieldValue("LaunchNode"); }
         	set { setFieldValue("LaunchNode", value); }
         }
      
         public Point3F LaunchOffset
         {
         	get { return new Point3F(getFieldValue("LaunchOffset")); }
         	set { setFieldValue("LaunchOffset", value.ToString()); }
         }
      
         public Point3F LaunchOffsetServer
         {
         	get { return new Point3F(getFieldValue("LaunchOffsetServer")); }
         	set { setFieldValue("LaunchOffsetServer", value.ToString()); }
         }
      
         public Point3F LaunchOffsetClient
         {
         	get { return new Point3F(getFieldValue("LaunchOffsetClient")); }
         	set { setFieldValue("LaunchOffsetClient", value.ToString()); }
         }
      
         public Point3F LaunchNodeOffset
         {
         	get { return new Point3F(getFieldValue("LaunchNodeOffset")); }
         	set { setFieldValue("LaunchNodeOffset", value.ToString()); }
         }
      
         public float LaunchAimPitch
         {
         	get { return float.Parse(getFieldValue("LaunchAimPitch")); }
         	set { setFieldValue("LaunchAimPitch", value.ToString()); }
         }
      
         public float LaunchAimPan
         {
         	get { return float.Parse(getFieldValue("LaunchAimPan")); }
         	set { setFieldValue("LaunchAimPan", value.ToString()); }
         }
      
         public string LaunchConstraintServer
         {
         	get { return getFieldValue("LaunchConstraintServer"); }
         	set { setFieldValue("LaunchConstraintServer", value); }
         }
      
         public string LaunchConstraintClient
         {
         	get { return getFieldValue("LaunchConstraintClient"); }
         	set { setFieldValue("LaunchConstraintClient", value); }
         }
      
         public bool EchoLaunchOffset
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EchoLaunchOffset")); }
         	set { setFieldValue("EchoLaunchOffset", value ? "1" : "0"); }
         }
      
         public string WiggleMagnitudes
         {
         	get { return getFieldValue("WiggleMagnitudes"); }
         	set { setFieldValue("WiggleMagnitudes", value); }
         }
      
         public string WiggleSpeeds
         {
         	get { return getFieldValue("WiggleSpeeds"); }
         	set { setFieldValue("WiggleSpeeds", value); }
         }
      
         public string WiggleAxis
         {
         	get { return getFieldValue("WiggleAxis"); }
         	set { setFieldValue("WiggleAxis", value); }
         }
      
         public float HoverAltitude
         {
         	get { return float.Parse(getFieldValue("HoverAltitude")); }
         	set { setFieldValue("HoverAltitude", value.ToString()); }
         }
      
         public float HoverAttackDistance
         {
         	get { return float.Parse(getFieldValue("HoverAttackDistance")); }
         	set { setFieldValue("HoverAttackDistance", value.ToString()); }
         }
      
         public float HoverAttackGradient
         {
         	get { return float.Parse(getFieldValue("HoverAttackGradient")); }
         	set { setFieldValue("HoverAttackGradient", value.ToString()); }
         }
      
         public int Hovertime
         {
         	get { return int.Parse(getFieldValue("Hovertime")); }
         	set { setFieldValue("Hovertime", value.ToString()); }
         }
      
         public bool ReverseTargeting
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReverseTargeting")); }
         	set { setFieldValue("ReverseTargeting", value ? "1" : "0"); }
         }
      
         public int CasterSafetyTime
         {
         	get { return int.Parse(getFieldValue("CasterSafetyTime")); }
         	set { setFieldValue("CasterSafetyTime", value.ToString()); }
         }
      
      
      #endregion

	}
}