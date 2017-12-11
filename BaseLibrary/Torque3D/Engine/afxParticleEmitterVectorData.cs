using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxParticleEmitterVectorData : afxParticleEmitterData
	{
		public afxParticleEmitterVectorData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxParticleEmitterVectorData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxParticleEmitterVectorData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxParticleEmitterVectorData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxParticleEmitterVectorData(SimObject pObj) : base(pObj)
		{
		}

		public afxParticleEmitterVectorData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxParticleEmitterVectorData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxParticleEmitterVectorData_create();
         private static _afxParticleEmitterVectorData_create _afxParticleEmitterVectorData_createFunc;
         internal static IntPtr afxParticleEmitterVectorData_create()
         {
         	if (_afxParticleEmitterVectorData_createFunc == null)
         	{
         		_afxParticleEmitterVectorData_createFunc =
         			(_afxParticleEmitterVectorData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxParticleEmitterVectorData_create"), typeof(_afxParticleEmitterVectorData_create));
         	}
         
         	return  _afxParticleEmitterVectorData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}