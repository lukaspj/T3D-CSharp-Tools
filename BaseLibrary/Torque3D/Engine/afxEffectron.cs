using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEffectron : afxChoreographer
	{
		public afxEffectron(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEffectron(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEffectron(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEffectron(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEffectron(SimObject pObj) : base(pObj)
		{
		}

		public afxEffectron(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEffectron_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTimeFactor(IntPtr thisPtr, float factor);
         private static _setTimeFactor _setTimeFactorFunc;
         internal static void setTimeFactor(IntPtr thisPtr, float factor)
         {
         	if (_setTimeFactorFunc == null)
         	{
         		_setTimeFactorFunc =
         			(_setTimeFactor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectron_setTimeFactor"), typeof(_setTimeFactor));
         	}
         
         	 _setTimeFactorFunc(thisPtr, factor);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _interrupt(IntPtr thisPtr);
         private static _interrupt _interruptFunc;
         internal static void interrupt(IntPtr thisPtr)
         {
         	if (_interruptFunc == null)
         	{
         		_interruptFunc =
         			(_interrupt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectron_interrupt"), typeof(_interrupt));
         	}
         
         	 _interruptFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activate(IntPtr thisPtr);
         private static _activate _activateFunc;
         internal static void activate(IntPtr thisPtr)
         {
         	if (_activateFunc == null)
         	{
         		_activateFunc =
         			(_activate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectron_activate"), typeof(_activate));
         	}
         
         	 _activateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEffectron_create();
         private static _afxEffectron_create _afxEffectron_createFunc;
         internal static IntPtr afxEffectron_create()
         {
         	if (_afxEffectron_createFunc == null)
         	{
         		_afxEffectron_createFunc =
         			(_afxEffectron_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectron_create"), typeof(_afxEffectron_create));
         	}
         
         	return  _afxEffectron_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setTimeFactor(float factor)
         {
            InternalUnsafeMethods.setTimeFactor(ObjectPtr, factor);
         }
      
         public virtual void interrupt()
         {
            InternalUnsafeMethods.interrupt(ObjectPtr);
         }
      
         public virtual void activate()
         {
            InternalUnsafeMethods.activate(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}