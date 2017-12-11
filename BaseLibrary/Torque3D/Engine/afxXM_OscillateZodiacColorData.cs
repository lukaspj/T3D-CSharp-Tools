using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxXM_OscillateZodiacColorData : afxXM_WeightedBaseData
	{
		public afxXM_OscillateZodiacColorData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxXM_OscillateZodiacColorData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxXM_OscillateZodiacColorData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxXM_OscillateZodiacColorData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxXM_OscillateZodiacColorData(SimObject pObj) : base(pObj)
		{
		}

		public afxXM_OscillateZodiacColorData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxXM_OscillateZodiacColorData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxXM_OscillateZodiacColorData_create();
         private static _afxXM_OscillateZodiacColorData_create _afxXM_OscillateZodiacColorData_createFunc;
         internal static IntPtr afxXM_OscillateZodiacColorData_create()
         {
         	if (_afxXM_OscillateZodiacColorData_createFunc == null)
         	{
         		_afxXM_OscillateZodiacColorData_createFunc =
         			(_afxXM_OscillateZodiacColorData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxXM_OscillateZodiacColorData_create"), typeof(_afxXM_OscillateZodiacColorData_create));
         	}
         
         	return  _afxXM_OscillateZodiacColorData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public LinearColorF ColorA
         {
         	get { return new LinearColorF(getFieldValue("ColorA")); }
         	set { setFieldValue("ColorA", value.ToString()); }
         }
      
         public LinearColorF ColorB
         {
         	get { return new LinearColorF(getFieldValue("ColorB")); }
         	set { setFieldValue("ColorB", value.ToString()); }
         }
      
         public float Speed
         {
         	get { return float.Parse(getFieldValue("Speed")); }
         	set { setFieldValue("Speed", value.ToString()); }
         }
      
      
      #endregion

	}
}