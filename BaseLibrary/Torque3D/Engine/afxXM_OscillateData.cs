using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_OscillateData : afxXM_WeightedBaseData
	{
		public afxXM_OscillateData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_OscillateData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_OscillateData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_OscillateData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_OscillateData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_OscillateData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_OscillateData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_OscillateData_create();
         private static _afxXM_OscillateData_create _afxXM_OscillateData_createFunc;
         internal static IntPtr afxXM_OscillateData_create()
         {
         	if (_afxXM_OscillateData_createFunc == null)
         	{
         		_afxXM_OscillateData_createFunc =
         			(_afxXM_OscillateData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_OscillateData_create"), typeof(_afxXM_OscillateData_create));
         	}
         
         	return  _afxXM_OscillateData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int Mask
         {
         	get { return int.Parse(getFieldValue("Mask")); }
         	set { setFieldValue("Mask", value.ToString()); }
         }
      
         public Point3F Min
         {
         	get { return new Point3F(getFieldValue("Min")); }
         	set { setFieldValue("Min", value.ToString()); }
         }
      
         public Point3F Max
         {
         	get { return new Point3F(getFieldValue("Max")); }
         	set { setFieldValue("Max", value.ToString()); }
         }
      
         public float Speed
         {
         	get { return float.Parse(getFieldValue("Speed")); }
         	set { setFieldValue("Speed", value.ToString()); }
         }
      
         public Point3F Axis
         {
         	get { return new Point3F(getFieldValue("Axis")); }
         	set { setFieldValue("Axis", value.ToString()); }
         }
      
         public bool AdditiveScale
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AdditiveScale")); }
         	set { setFieldValue("AdditiveScale", value ? "1" : "0"); }
         }
      
         public bool LocalOffset
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LocalOffset")); }
         	set { setFieldValue("LocalOffset", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}