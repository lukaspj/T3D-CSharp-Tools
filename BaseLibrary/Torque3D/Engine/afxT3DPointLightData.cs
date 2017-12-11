using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxT3DPointLightData : afxT3DLightBaseData
	{
		public afxT3DPointLightData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxT3DPointLightData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxT3DPointLightData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxT3DPointLightData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxT3DPointLightData(SimObject pObj) : base(pObj)
		{
		}

		public afxT3DPointLightData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxT3DPointLightData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxT3DPointLightData_create();
         private static _afxT3DPointLightData_create _afxT3DPointLightData_createFunc;
         internal static IntPtr afxT3DPointLightData_create()
         {
         	if (_afxT3DPointLightData_createFunc == null)
         	{
         		_afxT3DPointLightData_createFunc =
         			(_afxT3DPointLightData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxT3DPointLightData_create"), typeof(_afxT3DPointLightData_create));
         	}
         
         	return  _afxT3DPointLightData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
      
      #endregion

	}
}