using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxParticleEmitterDiscData : afxParticleEmitterData
	{
		public afxParticleEmitterDiscData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxParticleEmitterDiscData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxParticleEmitterDiscData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxParticleEmitterDiscData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxParticleEmitterDiscData(SimObject pObj) : base(pObj)
		{
		}

		public afxParticleEmitterDiscData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxParticleEmitterDiscData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxParticleEmitterDiscData_create();
         private static _afxParticleEmitterDiscData_create _afxParticleEmitterDiscData_createFunc;
         internal static IntPtr afxParticleEmitterDiscData_create()
         {
         	if (_afxParticleEmitterDiscData_createFunc == null)
         	{
         		_afxParticleEmitterDiscData_createFunc =
         			(_afxParticleEmitterDiscData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxParticleEmitterDiscData_create"), typeof(_afxParticleEmitterDiscData_create));
         	}
         
         	return  _afxParticleEmitterDiscData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float RadiusMin
         {
         	get { return float.Parse(getFieldValue("RadiusMin")); }
         	set { setFieldValue("RadiusMin", value.ToString()); }
         }
      
         public float RadiusMax
         {
         	get { return float.Parse(getFieldValue("RadiusMax")); }
         	set { setFieldValue("RadiusMax", value.ToString()); }
         }
      
      
      #endregion

	}
}