using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxPhysicalZoneData : GameBaseData
	{
		public afxPhysicalZoneData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxPhysicalZoneData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxPhysicalZoneData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxPhysicalZoneData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxPhysicalZoneData(SimObject pObj) : base(pObj)
		{
		}

		public afxPhysicalZoneData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxPhysicalZoneData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxPhysicalZoneData_create();
         private static _afxPhysicalZoneData_create _afxPhysicalZoneData_createFunc;
         internal static IntPtr afxPhysicalZoneData_create()
         {
         	if (_afxPhysicalZoneData_createFunc == null)
         	{
         		_afxPhysicalZoneData_createFunc =
         			(_afxPhysicalZoneData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxPhysicalZoneData_create"), typeof(_afxPhysicalZoneData_create));
         	}
         
         	return  _afxPhysicalZoneData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float VelocityMod
         {
         	get { return float.Parse(getFieldValue("VelocityMod")); }
         	set { setFieldValue("VelocityMod", value.ToString()); }
         }
      
         public float GravityMod
         {
         	get { return float.Parse(getFieldValue("GravityMod")); }
         	set { setFieldValue("GravityMod", value.ToString()); }
         }
      
         public Point3F AppliedForce
         {
         	get { return new Point3F(getFieldValue("AppliedForce")); }
         	set { setFieldValue("AppliedForce", value.ToString()); }
         }
      
         public string Polyhedron
         {
         	get { return getFieldValue("Polyhedron"); }
         	set { setFieldValue("Polyhedron", value); }
         }
      
         public PhysicalZone_ForceType ForceType
         {
         	get { return (PhysicalZone_ForceType)Enum.Parse(typeof(PhysicalZone_ForceType), getFieldValue("ForceType"), true); }
         	set { setFieldValue("ForceType", value.ToString()); }
         }
      
         public bool OrientForce
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OrientForce")); }
         	set { setFieldValue("OrientForce", value ? "1" : "0"); }
         }
      
         public bool ExcludeConstraintObject
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ExcludeConstraintObject")); }
         	set { setFieldValue("ExcludeConstraintObject", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}