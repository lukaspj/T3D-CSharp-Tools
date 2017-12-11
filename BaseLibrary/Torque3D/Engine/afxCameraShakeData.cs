using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxCameraShakeData : GameBaseData
	{
		public afxCameraShakeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxCameraShakeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxCameraShakeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxCameraShakeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxCameraShakeData(SimObject pObj) : base(pObj)
		{
		}

		public afxCameraShakeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxCameraShakeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxCameraShakeData_create();
         private static _afxCameraShakeData_create _afxCameraShakeData_createFunc;
         internal static IntPtr afxCameraShakeData_create()
         {
         	if (_afxCameraShakeData_createFunc == null)
         	{
         		_afxCameraShakeData_createFunc =
         			(_afxCameraShakeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCameraShakeData_create"), typeof(_afxCameraShakeData_create));
         	}
         
         	return  _afxCameraShakeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F Frequency
         {
         	get { return new Point3F(getFieldValue("Frequency")); }
         	set { setFieldValue("Frequency", value.ToString()); }
         }
      
         public Point3F Amplitude
         {
         	get { return new Point3F(getFieldValue("Amplitude")); }
         	set { setFieldValue("Amplitude", value.ToString()); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float Falloff
         {
         	get { return float.Parse(getFieldValue("Falloff")); }
         	set { setFieldValue("Falloff", value.ToString()); }
         }
      
      
      #endregion

	}
}