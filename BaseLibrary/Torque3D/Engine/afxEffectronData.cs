using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEffectronData : afxChoreographerData
	{
		public afxEffectronData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEffectronData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEffectronData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEffectronData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEffectronData(SimObject pObj) : base(pObj)
		{
		}

		public afxEffectronData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEffectronData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectronData_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addEffect(IntPtr thisPtr, IntPtr effect);
         private static _addEffect _addEffectFunc;
         internal static void addEffect(IntPtr thisPtr, IntPtr effect)
         {
         	if (_addEffectFunc == null)
         	{
         		_addEffectFunc =
         			(_addEffect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectronData_addEffect"), typeof(_addEffect));
         	}
         
         	 _addEffectFunc(thisPtr, effect);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEffectronData_create();
         private static _afxEffectronData_create _afxEffectronData_createFunc;
         internal static IntPtr afxEffectronData_create()
         {
         	if (_afxEffectronData_createFunc == null)
         	{
         		_afxEffectronData_createFunc =
         			(_afxEffectronData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectronData_create"), typeof(_afxEffectronData_create));
         	}
         
         	return  _afxEffectronData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void addEffect(afxEffectBaseData effect)
         {
            InternalUnsafeMethods.addEffect(ObjectPtr, effect.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float Duration
         {
         	get { return float.Parse(getFieldValue("Duration")); }
         	set { setFieldValue("Duration", value.ToString()); }
         }
      
         public int NumLoops
         {
         	get { return int.Parse(getFieldValue("NumLoops")); }
         	set { setFieldValue("NumLoops", value.ToString()); }
         }
      
         public afxEffectBaseData AddEffect
         {
         	get { return Sim.FindObject<afxEffectBaseData>(getFieldValue("AddEffect")); }
         	set { setFieldValue("AddEffect", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}