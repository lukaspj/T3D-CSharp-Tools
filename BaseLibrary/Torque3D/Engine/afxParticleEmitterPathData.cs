using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxParticleEmitterPathData : afxParticleEmitterData
	{
		public afxParticleEmitterPathData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxParticleEmitterPathData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxParticleEmitterPathData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxParticleEmitterPathData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxParticleEmitterPathData(SimObject pObj) : base(pObj)
		{
		}

		public afxParticleEmitterPathData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxParticleEmitterPathData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxParticleEmitterPathData_create();
         private static _afxParticleEmitterPathData_create _afxParticleEmitterPathData_createFunc;
         internal static IntPtr afxParticleEmitterPathData_create()
         {
         	if (_afxParticleEmitterPathData_createFunc == null)
         	{
         		_afxParticleEmitterPathData_createFunc =
         			(_afxParticleEmitterPathData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxParticleEmitterPathData_create"), typeof(_afxParticleEmitterPathData_create));
         	}
         
         	return  _afxParticleEmitterPathData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Paths
         {
         	get { return getFieldValue("Paths"); }
         	set { setFieldValue("Paths", value); }
         }
      
         public afxParticleEmitterPath_OriginType PathOrigin
         {
         	get { return (afxParticleEmitterPath_OriginType)Enum.Parse(typeof(afxParticleEmitterPath_OriginType), getFieldValue("PathOrigin"), true); }
         	set { setFieldValue("PathOrigin", value.ToString()); }
         }
      
         public bool GroundConform
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GroundConform")); }
         	set { setFieldValue("GroundConform", value ? "1" : "0"); }
         }
      
         public bool GroundConformTerrain
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GroundConformTerrain")); }
         	set { setFieldValue("GroundConformTerrain", value ? "1" : "0"); }
         }
      
         public bool GroundConformInteriors
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GroundConformInteriors")); }
         	set { setFieldValue("GroundConformInteriors", value ? "1" : "0"); }
         }
      
         public float GroundConformHeight
         {
         	get { return float.Parse(getFieldValue("GroundConformHeight")); }
         	set { setFieldValue("GroundConformHeight", value.ToString()); }
         }
      
      
      #endregion

	}
}