using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxAnimClipData : GameBaseData
	{
		public afxAnimClipData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxAnimClipData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxAnimClipData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxAnimClipData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxAnimClipData(SimObject pObj) : base(pObj)
		{
		}

		public afxAnimClipData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxAnimClipData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxAnimClipData_create();
         private static _afxAnimClipData_create _afxAnimClipData_createFunc;
         internal static IntPtr afxAnimClipData_create()
         {
         	if (_afxAnimClipData_createFunc == null)
         	{
         		_afxAnimClipData_createFunc =
         			(_afxAnimClipData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxAnimClipData_create"), typeof(_afxAnimClipData_create));
         	}
         
         	return  _afxAnimClipData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ClipName
         {
         	get { return getFieldValue("ClipName"); }
         	set { setFieldValue("ClipName", value); }
         }
      
         public float Rate
         {
         	get { return float.Parse(getFieldValue("Rate")); }
         	set { setFieldValue("Rate", value.ToString()); }
         }
      
         public float PosOffset
         {
         	get { return float.Parse(getFieldValue("PosOffset")); }
         	set { setFieldValue("PosOffset", value.ToString()); }
         }
      
         public float TransitionTime
         {
         	get { return float.Parse(getFieldValue("TransitionTime")); }
         	set { setFieldValue("TransitionTime", value.ToString()); }
         }
      
         public bool IgnoreCorpse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreCorpse")); }
         	set { setFieldValue("IgnoreCorpse", value ? "1" : "0"); }
         }
      
         public bool IgnoreLiving
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreLiving")); }
         	set { setFieldValue("IgnoreLiving", value ? "1" : "0"); }
         }
      
         public bool TreatAsDeathAnim
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TreatAsDeathAnim")); }
         	set { setFieldValue("TreatAsDeathAnim", value ? "1" : "0"); }
         }
      
         public bool LockAnimation
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LockAnimation")); }
         	set { setFieldValue("LockAnimation", value ? "1" : "0"); }
         }
      
         public bool IgnoreFirstPerson
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreFirstPerson")); }
         	set { setFieldValue("IgnoreFirstPerson", value ? "1" : "0"); }
         }
      
         public bool IgnoreThirdPerson
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreThirdPerson")); }
         	set { setFieldValue("IgnoreThirdPerson", value ? "1" : "0"); }
         }
      
         public bool IgnoreDisabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreDisabled")); }
         	set { setFieldValue("IgnoreDisabled", value ? "1" : "0"); }
         }
      
         public bool IgnoreEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreEnabled")); }
         	set { setFieldValue("IgnoreEnabled", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}