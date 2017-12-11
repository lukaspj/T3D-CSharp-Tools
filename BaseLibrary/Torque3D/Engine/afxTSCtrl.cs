using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxTSCtrl : GuiTSCtrl
	{
		public afxTSCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxTSCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxTSCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxTSCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxTSCtrl(SimObject pObj) : base(pObj)
		{
		}

		public afxTSCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxTSCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSpellBook(IntPtr thisPtr, IntPtr spellbook);
         private static _setSpellBook _setSpellBookFunc;
         internal static void setSpellBook(IntPtr thisPtr, IntPtr spellbook)
         {
         	if (_setSpellBookFunc == null)
         	{
         		_setSpellBookFunc =
         			(_setSpellBook)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_setSpellBook"), typeof(_setSpellBook));
         	}
         
         	 _setSpellBookFunc(thisPtr, spellbook);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushTargetingMode(IntPtr thisPtr, uint mode, uint checkMethod);
         private static _pushTargetingMode _pushTargetingModeFunc;
         internal static void pushTargetingMode(IntPtr thisPtr, uint mode, uint checkMethod)
         {
         	if (_pushTargetingModeFunc == null)
         	{
         		_pushTargetingModeFunc =
         			(_pushTargetingMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_pushTargetingMode"), typeof(_pushTargetingMode));
         	}
         
         	 _pushTargetingModeFunc(thisPtr, mode, checkMethod);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popTargetingMode(IntPtr thisPtr);
         private static _popTargetingMode _popTargetingModeFunc;
         internal static void popTargetingMode(IntPtr thisPtr)
         {
         	if (_popTargetingModeFunc == null)
         	{
         		_popTargetingModeFunc =
         			(_popTargetingMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_popTargetingMode"), typeof(_popTargetingMode));
         	}
         
         	 _popTargetingModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTargetingMode(IntPtr thisPtr);
         private static _getTargetingMode _getTargetingModeFunc;
         internal static int getTargetingMode(IntPtr thisPtr)
         {
         	if (_getTargetingModeFunc == null)
         	{
         		_getTargetingModeFunc =
         			(_getTargetingMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_getTargetingMode"), typeof(_getTargetingMode));
         	}
         
         	return  _getTargetingModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMouse3DVec(IntPtr thisPtr);
         private static _getMouse3DVec _getMouse3DVecFunc;
         internal static InternalPoint3FStruct getMouse3DVec(IntPtr thisPtr)
         {
         	if (_getMouse3DVecFunc == null)
         	{
         		_getMouse3DVecFunc =
         			(_getMouse3DVec)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_getMouse3DVec"), typeof(_getMouse3DVec));
         	}
         
         	return  _getMouse3DVecFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMouse3DPos(IntPtr thisPtr);
         private static _getMouse3DPos _getMouse3DPosFunc;
         internal static InternalPoint3FStruct getMouse3DPos(IntPtr thisPtr)
         {
         	if (_getMouse3DPosFunc == null)
         	{
         		_getMouse3DPosFunc =
         			(_getMouse3DPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_getMouse3DPos"), typeof(_getMouse3DPos));
         	}
         
         	return  _getMouse3DPosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxTSCtrl_create();
         private static _afxTSCtrl_create _afxTSCtrl_createFunc;
         internal static IntPtr afxTSCtrl_create()
         {
         	if (_afxTSCtrl_createFunc == null)
         	{
         		_afxTSCtrl_createFunc =
         			(_afxTSCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxTSCtrl_create"), typeof(_afxTSCtrl_create));
         	}
         
         	return  _afxTSCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setSpellBook(afxSpellBook spellbook)
         {
            InternalUnsafeMethods.setSpellBook(ObjectPtr, spellbook.ObjectPtr);
         }
      
         public virtual void pushTargetingMode(afxTargeting mode = afxTargeting.Off, afxTargetCheck checkMethod = afxTargetCheck.Poll)
         {
            InternalUnsafeMethods.pushTargetingMode(ObjectPtr, (uint)mode, (uint)checkMethod);
         }
      
         public virtual void popTargetingMode()
         {
            InternalUnsafeMethods.popTargetingMode(ObjectPtr);
         }
      
         public virtual int getTargetingMode()
         {
            return InternalUnsafeMethods.getTargetingMode(ObjectPtr);
         }
      
         public virtual Point3F getMouse3DVec()
         {
            return new Point3F(InternalUnsafeMethods.getMouse3DVec(ObjectPtr));
         }
      
         public virtual Point3F getMouse3DPos()
         {
            return new Point3F(InternalUnsafeMethods.getMouse3DPos(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}