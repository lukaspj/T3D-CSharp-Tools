using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxParticlePoolData : GameBaseData
	{
		public afxParticlePoolData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxParticlePoolData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxParticlePoolData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxParticlePoolData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxParticlePoolData(SimObject pObj) : base(pObj)
		{
		}

		public afxParticlePoolData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxParticlePoolData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxParticlePoolData_create();
         private static _afxParticlePoolData_create _afxParticlePoolData_createFunc;
         internal static IntPtr afxParticlePoolData_create()
         {
         	if (_afxParticlePoolData_createFunc == null)
         	{
         		_afxParticlePoolData_createFunc =
         			(_afxParticlePoolData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxParticlePoolData_create"), typeof(_afxParticlePoolData_create));
         	}
         
         	return  _afxParticlePoolData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public afxParticlePool_PoolType PoolType
         {
         	get { return (afxParticlePool_PoolType)Enum.Parse(typeof(afxParticlePool_PoolType), getFieldValue("PoolType"), true); }
         	set { setFieldValue("PoolType", value.ToString()); }
         }
      
         public LinearColorF BaseColor
         {
         	get { return new LinearColorF(getFieldValue("BaseColor")); }
         	set { setFieldValue("BaseColor", value.ToString()); }
         }
      
         public float BlendWeight
         {
         	get { return float.Parse(getFieldValue("BlendWeight")); }
         	set { setFieldValue("BlendWeight", value.ToString()); }
         }
      
      
      #endregion

	}
}