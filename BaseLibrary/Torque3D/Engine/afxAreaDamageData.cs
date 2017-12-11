using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxAreaDamageData : GameBaseData
	{
		public afxAreaDamageData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxAreaDamageData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxAreaDamageData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxAreaDamageData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxAreaDamageData(SimObject pObj) : base(pObj)
		{
		}

		public afxAreaDamageData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxAreaDamageData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxAreaDamageData_create();
         private static _afxAreaDamageData_create _afxAreaDamageData_createFunc;
         internal static IntPtr afxAreaDamageData_create()
         {
         	if (_afxAreaDamageData_createFunc == null)
         	{
         		_afxAreaDamageData_createFunc =
         			(_afxAreaDamageData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxAreaDamageData_create"), typeof(_afxAreaDamageData_create));
         	}
         
         	return  _afxAreaDamageData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Flavor
         {
         	get { return getFieldValue("Flavor"); }
         	set { setFieldValue("Flavor", value); }
         }
      
         public float Damage
         {
         	get { return float.Parse(getFieldValue("Damage")); }
         	set { setFieldValue("Damage", value.ToString()); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float Impulse
         {
         	get { return float.Parse(getFieldValue("Impulse")); }
         	set { setFieldValue("Impulse", value.ToString()); }
         }
      
         public bool NotifyDamageSource
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NotifyDamageSource")); }
         	set { setFieldValue("NotifyDamageSource", value ? "1" : "0"); }
         }
      
         public bool ExcludeConstraintObject
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ExcludeConstraintObject")); }
         	set { setFieldValue("ExcludeConstraintObject", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}