using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_GroundConformData : afxXM_WeightedBaseData
	{
		public afxXM_GroundConformData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_GroundConformData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_GroundConformData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_GroundConformData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_GroundConformData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_GroundConformData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_GroundConformData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_GroundConformData_create();
         private static _afxXM_GroundConformData_create _afxXM_GroundConformData_createFunc;
         internal static IntPtr afxXM_GroundConformData_create()
         {
         	if (_afxXM_GroundConformData_createFunc == null)
         	{
         		_afxXM_GroundConformData_createFunc =
         			(_afxXM_GroundConformData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_GroundConformData_create"), typeof(_afxXM_GroundConformData_create));
         	}
         
         	return  _afxXM_GroundConformData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Height
         {
         	get { return float.Parse(getFieldValue("Height")); }
         	set { setFieldValue("Height", value.ToString()); }
         }
      
         public bool ConformToTerrain
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ConformToTerrain")); }
         	set { setFieldValue("ConformToTerrain", value ? "1" : "0"); }
         }
      
         public bool ConformToInteriors
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ConformToInteriors")); }
         	set { setFieldValue("ConformToInteriors", value ? "1" : "0"); }
         }
      
         public bool ConformOrientation
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ConformOrientation")); }
         	set { setFieldValue("ConformOrientation", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}