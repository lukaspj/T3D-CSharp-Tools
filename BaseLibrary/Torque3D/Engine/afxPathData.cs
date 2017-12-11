using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxPathData : GameBaseData
	{
		public afxPathData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxPathData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxPathData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxPathData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxPathData(SimObject pObj) : base(pObj)
		{
		}

		public afxPathData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxPathData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxPathData_create();
         private static _afxPathData_create _afxPathData_createFunc;
         internal static IntPtr afxPathData_create()
         {
         	if (_afxPathData_createFunc == null)
         	{
         		_afxPathData_createFunc =
         			(_afxPathData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxPathData_create"), typeof(_afxPathData_create));
         	}
         
         	return  _afxPathData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Points
         {
         	get { return getFieldValue("Points"); }
         	set { setFieldValue("Points", value); }
         }
      
         public string Roll
         {
         	get { return getFieldValue("Roll"); }
         	set { setFieldValue("Roll", value); }
         }
      
         public string Times
         {
         	get { return getFieldValue("Times"); }
         	set { setFieldValue("Times", value); }
         }
      
         public string Loop
         {
         	get { return getFieldValue("Loop"); }
         	set { setFieldValue("Loop", value); }
         }
      
         public float Mult
         {
         	get { return float.Parse(getFieldValue("Mult")); }
         	set { setFieldValue("Mult", value.ToString()); }
         }
      
         public float Delay
         {
         	get { return float.Parse(getFieldValue("Delay")); }
         	set { setFieldValue("Delay", value.ToString()); }
         }
      
         public float Lifetime
         {
         	get { return float.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public float TimeOffset
         {
         	get { return float.Parse(getFieldValue("TimeOffset")); }
         	set { setFieldValue("TimeOffset", value.ToString()); }
         }
      
         public bool Reverse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Reverse")); }
         	set { setFieldValue("Reverse", value ? "1" : "0"); }
         }
      
         public Point3F Offset
         {
         	get { return new Point3F(getFieldValue("Offset")); }
         	set { setFieldValue("Offset", value.ToString()); }
         }
      
         public bool Echo
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Echo")); }
         	set { setFieldValue("Echo", value ? "1" : "0"); }
         }
      
         public bool Concentric
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Concentric")); }
         	set { setFieldValue("Concentric", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}