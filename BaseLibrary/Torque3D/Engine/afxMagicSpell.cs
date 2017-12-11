using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMagicSpell : afxChoreographer
	{
		public afxMagicSpell(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMagicSpell(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMagicSpell(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMagicSpell(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMagicSpell(SimObject pObj) : base(pObj)
		{
		}

		public afxMagicSpell(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMagicSpell_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCaster(IntPtr thisPtr);
         private static _getCaster _getCasterFunc;
         internal static int getCaster(IntPtr thisPtr)
         {
         	if (_getCasterFunc == null)
         	{
         		_getCasterFunc =
         			(_getCaster)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_getCaster"), typeof(_getCaster));
         	}
         
         	return  _getCasterFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTarget(IntPtr thisPtr);
         private static _getTarget _getTargetFunc;
         internal static int getTarget(IntPtr thisPtr)
         {
         	if (_getTargetFunc == null)
         	{
         		_getTargetFunc =
         			(_getTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_getTarget"), typeof(_getTarget));
         	}
         
         	return  _getTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMissile(IntPtr thisPtr);
         private static _getMissile _getMissileFunc;
         internal static int getMissile(IntPtr thisPtr)
         {
         	if (_getMissileFunc == null)
         	{
         		_getMissileFunc =
         			(_getMissile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_getMissile"), typeof(_getMissile));
         	}
         
         	return  _getMissileFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getImpactedObject(IntPtr thisPtr);
         private static _getImpactedObject _getImpactedObjectFunc;
         internal static int getImpactedObject(IntPtr thisPtr)
         {
         	if (_getImpactedObjectFunc == null)
         	{
         		_getImpactedObjectFunc =
         			(_getImpactedObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_getImpactedObject"), typeof(_getImpactedObject));
         	}
         
         	return  _getImpactedObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTimeFactor(IntPtr thisPtr, int argc, string[] argv);
         private static _setTimeFactor _setTimeFactorFunc;
         internal static void setTimeFactor(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setTimeFactorFunc == null)
         	{
         		_setTimeFactorFunc =
         			(_setTimeFactor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_setTimeFactor"), typeof(_setTimeFactor));
         	}
         
         	 _setTimeFactorFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _interruptStage(IntPtr thisPtr);
         private static _interruptStage _interruptStageFunc;
         internal static void interruptStage(IntPtr thisPtr)
         {
         	if (_interruptStageFunc == null)
         	{
         		_interruptStageFunc =
         			(_interruptStage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_interruptStage"), typeof(_interruptStage));
         	}
         
         	 _interruptStageFunc(thisPtr);
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
         				"fn_afxMagicSpell_interrupt"), typeof(_interrupt));
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
         				"fn_afxMagicSpell_activate"), typeof(_activate));
         	}
         
         	 _activateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMagicSpell_create();
         private static _afxMagicSpell_create _afxMagicSpell_createFunc;
         internal static IntPtr afxMagicSpell_create()
         {
         	if (_afxMagicSpell_createFunc == null)
         	{
         		_afxMagicSpell_createFunc =
         			(_afxMagicSpell_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicSpell_create"), typeof(_afxMagicSpell_create));
         	}
         
         	return  _afxMagicSpell_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getCaster()
         {
            return InternalUnsafeMethods.getCaster(ObjectPtr);
         }
      
         public virtual int getTarget()
         {
            return InternalUnsafeMethods.getTarget(ObjectPtr);
         }
      
         public virtual int getMissile()
         {
            return InternalUnsafeMethods.getMissile(ObjectPtr);
         }
      
         public virtual int getImpactedObject()
         {
            return InternalUnsafeMethods.getImpactedObject(ObjectPtr);
         }
      
         public virtual void setTimeFactor(float factor)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(factor.ToString());
                  InternalUnsafeMethods.setTimeFactor(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void interruptStage()
         {
            InternalUnsafeMethods.interruptStage(ObjectPtr);
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
      
      
         public SimObject Caster
         {
         	get { return Sim.FindObject<SimObject>(getFieldValue("Caster")); }
         	set { setFieldValue("Caster", value.getId().ToString()); }
         }
      
         public SimObject Target
         {
         	get { return Sim.FindObject<SimObject>(getFieldValue("Target")); }
         	set { setFieldValue("Target", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}