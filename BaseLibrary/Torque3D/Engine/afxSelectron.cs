using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxSelectron : afxChoreographer
	{
		public afxSelectron(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxSelectron(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxSelectron(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxSelectron(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxSelectron(SimObject pObj) : base(pObj)
		{
		}

		public afxSelectron(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxSelectron_create();
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
         				"fn_afxSelectron_setTimeFactor"), typeof(_setTimeFactor));
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
         				"fn_afxSelectron_interrupt"), typeof(_interrupt));
         	}
         
         	 _interruptFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopSelectron(IntPtr thisPtr);
         private static _stopSelectron _stopSelectronFunc;
         internal static void stopSelectron(IntPtr thisPtr)
         {
         	if (_stopSelectronFunc == null)
         	{
         		_stopSelectronFunc =
         			(_stopSelectron)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSelectron_stopSelectron"), typeof(_stopSelectron));
         	}
         
         	 _stopSelectronFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxSelectron_create();
         private static _afxSelectron_create _afxSelectron_createFunc;
         internal static IntPtr afxSelectron_create()
         {
         	if (_afxSelectron_createFunc == null)
         	{
         		_afxSelectron_createFunc =
         			(_afxSelectron_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSelectron_create"), typeof(_afxSelectron_create));
         	}
         
         	return  _afxSelectron_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setTimeFactor(float factor = 1.0f)
         {
            InternalUnsafeMethods.setTimeFactor(ObjectPtr, factor);
         }
      
         public virtual void interrupt()
         {
            InternalUnsafeMethods.interrupt(ObjectPtr);
         }
      
         public virtual void stopSelectron()
         {
            InternalUnsafeMethods.stopSelectron(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}