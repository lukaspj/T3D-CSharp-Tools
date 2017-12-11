using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_HeightSamplerData : afxXM_WeightedBaseData
	{
		public afxXM_HeightSamplerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_HeightSamplerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_HeightSamplerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_HeightSamplerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_HeightSamplerData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_HeightSamplerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_HeightSamplerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_HeightSamplerData_create();
         private static _afxXM_HeightSamplerData_create _afxXM_HeightSamplerData_createFunc;
         internal static IntPtr afxXM_HeightSamplerData_create()
         {
         	if (_afxXM_HeightSamplerData_createFunc == null)
         	{
         		_afxXM_HeightSamplerData_createFunc =
         			(_afxXM_HeightSamplerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_HeightSamplerData_create"), typeof(_afxXM_HeightSamplerData_create));
         	}
         
         	return  _afxXM_HeightSamplerData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}