using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxProjectileData : ProjectileData
	{
		public afxProjectileData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxProjectileData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxProjectileData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxProjectileData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxProjectileData(SimObject pObj) : base(pObj)
		{
		}

		public afxProjectileData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxProjectileData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxProjectileData_create();
         private static _afxProjectileData_create _afxProjectileData_createFunc;
         internal static IntPtr afxProjectileData_create()
         {
         	if (_afxProjectileData_createFunc == null)
         	{
         		_afxProjectileData_createFunc =
         			(_afxProjectileData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxProjectileData_create"), typeof(_afxProjectileData_create));
         	}
         
         	return  _afxProjectileData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public byte Networking
         {
         	get { return byte.Parse(getFieldValue("Networking")); }
         	set { setFieldValue("Networking", value.ToString()); }
         }
      
         public string LaunchPosSpec
         {
         	get { return getFieldValue("LaunchPosSpec"); }
         	set { setFieldValue("LaunchPosSpec", value); }
         }
      
         public Point3F LaunchDirBias
         {
         	get { return new Point3F(getFieldValue("LaunchDirBias")); }
         	set { setFieldValue("LaunchDirBias", value.ToString()); }
         }
      
         public bool IgnoreSourceTimeout
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreSourceTimeout")); }
         	set { setFieldValue("IgnoreSourceTimeout", value ? "1" : "0"); }
         }
      
         public int DynamicCollisionMask
         {
         	get { return int.Parse(getFieldValue("DynamicCollisionMask")); }
         	set { setFieldValue("DynamicCollisionMask", value.ToString()); }
         }
      
         public int StaticCollisionMask
         {
         	get { return int.Parse(getFieldValue("StaticCollisionMask")); }
         	set { setFieldValue("StaticCollisionMask", value.ToString()); }
         }
      
         public bool OverrideCollisionMasks
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideCollisionMasks")); }
         	set { setFieldValue("OverrideCollisionMasks", value ? "1" : "0"); }
         }
      
         public afxProjectile_LaunchDirType LaunchDirMethod
         {
         	get { return (afxProjectile_LaunchDirType)Enum.Parse(typeof(afxProjectile_LaunchDirType), getFieldValue("LaunchDirMethod"), true); }
         	set { setFieldValue("LaunchDirMethod", value.ToString()); }
         }
      
      
      #endregion

	}
}