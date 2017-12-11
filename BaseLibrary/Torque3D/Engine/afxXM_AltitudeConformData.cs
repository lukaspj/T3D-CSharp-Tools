using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_AltitudeConformData : afxXM_WeightedBaseData
	{
		public afxXM_AltitudeConformData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_AltitudeConformData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_AltitudeConformData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_AltitudeConformData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_AltitudeConformData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_AltitudeConformData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_AltitudeConformData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_AltitudeConformData_create();
         private static _afxXM_AltitudeConformData_create _afxXM_AltitudeConformData_createFunc;
         internal static IntPtr afxXM_AltitudeConformData_create()
         {
         	if (_afxXM_AltitudeConformData_createFunc == null)
         	{
         		_afxXM_AltitudeConformData_createFunc =
         			(_afxXM_AltitudeConformData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_AltitudeConformData_create"), typeof(_afxXM_AltitudeConformData_create));
         	}
         
         	return  _afxXM_AltitudeConformData_createFunc();
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
      
         public bool Freeze
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Freeze")); }
         	set { setFieldValue("Freeze", value ? "1" : "0"); }
         }
      
         public int InteriorTypes
         {
         	get { return int.Parse(getFieldValue("InteriorTypes")); }
         	set { setFieldValue("InteriorTypes", value.ToString()); }
         }
      
         public int TerrainTypes
         {
         	get { return int.Parse(getFieldValue("TerrainTypes")); }
         	set { setFieldValue("TerrainTypes", value.ToString()); }
         }
      
      
      #endregion

	}
}