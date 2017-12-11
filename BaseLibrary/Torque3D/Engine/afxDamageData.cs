using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxDamageData : GameBaseData
	{
		public afxDamageData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxDamageData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxDamageData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxDamageData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxDamageData(SimObject pObj) : base(pObj)
		{
		}

		public afxDamageData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxDamageData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxDamageData_create();
         private static _afxDamageData_create _afxDamageData_createFunc;
         internal static IntPtr afxDamageData_create()
         {
         	if (_afxDamageData_createFunc == null)
         	{
         		_afxDamageData_createFunc =
         			(_afxDamageData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxDamageData_create"), typeof(_afxDamageData_create));
         	}
         
         	return  _afxDamageData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Label
         {
         	get { return getFieldValue("Label"); }
         	set { setFieldValue("Label", value); }
         }
      
         public string Flavor
         {
         	get { return getFieldValue("Flavor"); }
         	set { setFieldValue("Flavor", value); }
         }
      
         public float DirectDamage
         {
         	get { return float.Parse(getFieldValue("DirectDamage")); }
         	set { setFieldValue("DirectDamage", value.ToString()); }
         }
      
         public byte DirectDamageRepeats
         {
         	get { return byte.Parse(getFieldValue("DirectDamageRepeats")); }
         	set { setFieldValue("DirectDamageRepeats", value.ToString()); }
         }
      
         public float AreaDamage
         {
         	get { return float.Parse(getFieldValue("AreaDamage")); }
         	set { setFieldValue("AreaDamage", value.ToString()); }
         }
      
         public float AreaDamageRadius
         {
         	get { return float.Parse(getFieldValue("AreaDamageRadius")); }
         	set { setFieldValue("AreaDamageRadius", value.ToString()); }
         }
      
         public float AreaDamageImpulse
         {
         	get { return float.Parse(getFieldValue("AreaDamageImpulse")); }
         	set { setFieldValue("AreaDamageImpulse", value.ToString()); }
         }
      
      
      #endregion

	}
}