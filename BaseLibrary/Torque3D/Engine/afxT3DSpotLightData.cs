using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxT3DSpotLightData : afxT3DLightBaseData
	{
		public afxT3DSpotLightData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxT3DSpotLightData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxT3DSpotLightData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxT3DSpotLightData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxT3DSpotLightData(SimObject pObj) : base(pObj)
		{
		}

		public afxT3DSpotLightData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxT3DSpotLightData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxT3DSpotLightData_create();
         private static _afxT3DSpotLightData_create _afxT3DSpotLightData_createFunc;
         internal static IntPtr afxT3DSpotLightData_create()
         {
         	if (_afxT3DSpotLightData_createFunc == null)
         	{
         		_afxT3DSpotLightData_createFunc =
         			(_afxT3DSpotLightData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxT3DSpotLightData_create"), typeof(_afxT3DSpotLightData_create));
         	}
         
         	return  _afxT3DSpotLightData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Range
         {
         	get { return float.Parse(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
         }
      
         public float InnerAngle
         {
         	get { return float.Parse(getFieldValue("InnerAngle")); }
         	set { setFieldValue("InnerAngle", value.ToString()); }
         }
      
         public float OuterAngle
         {
         	get { return float.Parse(getFieldValue("OuterAngle")); }
         	set { setFieldValue("OuterAngle", value.ToString()); }
         }
      
      
      #endregion

	}
}