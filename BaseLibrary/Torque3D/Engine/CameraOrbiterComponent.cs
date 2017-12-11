using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CameraOrbiterComponent : Component
	{
		public CameraOrbiterComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CameraOrbiterComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CameraOrbiterComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CameraOrbiterComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CameraOrbiterComponent(SimObject pObj) : base(pObj)
		{
		}

		public CameraOrbiterComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CameraOrbiterComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CameraOrbiterComponent_create();
         private static _CameraOrbiterComponent_create _CameraOrbiterComponent_createFunc;
         internal static IntPtr CameraOrbiterComponent_create()
         {
         	if (_CameraOrbiterComponent_createFunc == null)
         	{
         		_CameraOrbiterComponent_createFunc =
         			(_CameraOrbiterComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraOrbiterComponent_create"), typeof(_CameraOrbiterComponent_create));
         	}
         
         	return  _CameraOrbiterComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float OrbitDistance
         {
         	get { return float.Parse(getFieldValue("OrbitDistance")); }
         	set { setFieldValue("OrbitDistance", value.ToString()); }
         }
      
         public RotationF Rotation
         {
         	get { return new RotationF(getFieldValue("Rotation")); }
         	set { setFieldValue("Rotation", value.ToString()); }
         }
      
         public float MaxPitchAngle
         {
         	get { return float.Parse(getFieldValue("MaxPitchAngle")); }
         	set { setFieldValue("MaxPitchAngle", value.ToString()); }
         }
      
         public float MinPitchAngle
         {
         	get { return float.Parse(getFieldValue("MinPitchAngle")); }
         	set { setFieldValue("MinPitchAngle", value.ToString()); }
         }
      
      
      #endregion

	}
}