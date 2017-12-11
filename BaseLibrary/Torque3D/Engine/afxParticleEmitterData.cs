using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxParticleEmitterData : ParticleEmitterData
	{
		public afxParticleEmitterData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxParticleEmitterData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxParticleEmitterData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxParticleEmitterData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxParticleEmitterData(SimObject pObj) : base(pObj)
		{
		}

		public afxParticleEmitterData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxParticleEmitterData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxParticleEmitterData_create();
         private static _afxParticleEmitterData_create _afxParticleEmitterData_createFunc;
         internal static IntPtr afxParticleEmitterData_create()
         {
         	if (_afxParticleEmitterData_createFunc == null)
         	{
         		_afxParticleEmitterData_createFunc =
         			(_afxParticleEmitterData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxParticleEmitterData_create"), typeof(_afxParticleEmitterData_create));
         	}
         
         	return  _afxParticleEmitterData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool FadeVelocity
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FadeVelocity")); }
         	set { setFieldValue("FadeVelocity", value ? "1" : "0"); }
         }
      
         public bool FadeOffset
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FadeOffset")); }
         	set { setFieldValue("FadeOffset", value ? "1" : "0"); }
         }
      
         public Point3F Vector
         {
         	get { return new Point3F(getFieldValue("Vector")); }
         	set { setFieldValue("Vector", value.ToString()); }
         }
      
         public bool VectorIsWorld
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("VectorIsWorld")); }
         	set { setFieldValue("VectorIsWorld", value ? "1" : "0"); }
         }
      
         public string PathsTransform
         {
         	get { return getFieldValue("PathsTransform"); }
         	set { setFieldValue("PathsTransform", value); }
         }
      
      
      #endregion

	}
}