using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxParticleEmitterConeData : afxParticleEmitterData
	{
		public afxParticleEmitterConeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxParticleEmitterConeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxParticleEmitterConeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxParticleEmitterConeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxParticleEmitterConeData(SimObject pObj) : base(pObj)
		{
		}

		public afxParticleEmitterConeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxParticleEmitterConeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxParticleEmitterConeData_create();
         private static _afxParticleEmitterConeData_create _afxParticleEmitterConeData_createFunc;
         internal static IntPtr afxParticleEmitterConeData_create()
         {
         	if (_afxParticleEmitterConeData_createFunc == null)
         	{
         		_afxParticleEmitterConeData_createFunc =
         			(_afxParticleEmitterConeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxParticleEmitterConeData_create"), typeof(_afxParticleEmitterConeData_create));
         	}
         
         	return  _afxParticleEmitterConeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float SpreadMin
         {
         	get { return float.Parse(getFieldValue("SpreadMin")); }
         	set { setFieldValue("SpreadMin", value.ToString()); }
         }
      
         public float SpreadMax
         {
         	get { return float.Parse(getFieldValue("SpreadMax")); }
         	set { setFieldValue("SpreadMax", value.ToString()); }
         }
      
      
      #endregion

	}
}