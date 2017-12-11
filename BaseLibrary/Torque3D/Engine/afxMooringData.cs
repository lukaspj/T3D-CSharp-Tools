using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMooringData : GameBaseData
	{
		public afxMooringData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMooringData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMooringData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMooringData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMooringData(SimObject pObj) : base(pObj)
		{
		}

		public afxMooringData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMooringData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMooringData_create();
         private static _afxMooringData_create _afxMooringData_createFunc;
         internal static IntPtr afxMooringData_create()
         {
         	if (_afxMooringData_createFunc == null)
         	{
         		_afxMooringData_createFunc =
         			(_afxMooringData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMooringData_create"), typeof(_afxMooringData_create));
         	}
         
         	return  _afxMooringData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool DisplayAxisMarker
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DisplayAxisMarker")); }
         	set { setFieldValue("DisplayAxisMarker", value ? "1" : "0"); }
         }
      
         public bool TrackPosOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TrackPosOnly")); }
         	set { setFieldValue("TrackPosOnly", value ? "1" : "0"); }
         }
      
         public byte Networking
         {
         	get { return byte.Parse(getFieldValue("Networking")); }
         	set { setFieldValue("Networking", value.ToString()); }
         }
      
      
      #endregion

	}
}