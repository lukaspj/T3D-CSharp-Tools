using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxSpellBook : GameBase
	{
		public afxSpellBook(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxSpellBook(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxSpellBook(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxSpellBook(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxSpellBook(SimObject pObj) : base(pObj)
		{
		}

		public afxSpellBook(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxSpellBook_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPageSlotIndex(IntPtr thisPtr, int[] bookSlot);
         private static _getPageSlotIndex _getPageSlotIndexFunc;
         internal static int getPageSlotIndex(IntPtr thisPtr, int[] bookSlot)
         {
         	if (_getPageSlotIndexFunc == null)
         	{
         		_getPageSlotIndexFunc =
         			(_getPageSlotIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBook_getPageSlotIndex"), typeof(_getPageSlotIndex));
         	}
         
         	return  _getPageSlotIndexFunc(thisPtr, bookSlot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSpellData(IntPtr thisPtr, int[] bookSlot);
         private static _getSpellData _getSpellDataFunc;
         internal static int getSpellData(IntPtr thisPtr, int[] bookSlot)
         {
         	if (_getSpellDataFunc == null)
         	{
         		_getSpellDataFunc =
         			(_getSpellData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBook_getSpellData"), typeof(_getSpellData));
         	}
         
         	return  _getSpellDataFunc(thisPtr, bookSlot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSpellRPGData(IntPtr thisPtr, int[] bookSlot);
         private static _getSpellRPGData _getSpellRPGDataFunc;
         internal static int getSpellRPGData(IntPtr thisPtr, int[] bookSlot)
         {
         	if (_getSpellRPGDataFunc == null)
         	{
         		_getSpellRPGDataFunc =
         			(_getSpellRPGData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBook_getSpellRPGData"), typeof(_getSpellRPGData));
         	}
         
         	return  _getSpellRPGDataFunc(thisPtr, bookSlot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startAllSpellCooldown(IntPtr thisPtr);
         private static _startAllSpellCooldown _startAllSpellCooldownFunc;
         internal static void startAllSpellCooldown(IntPtr thisPtr)
         {
         	if (_startAllSpellCooldownFunc == null)
         	{
         		_startAllSpellCooldownFunc =
         			(_startAllSpellCooldown)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBook_startAllSpellCooldown"), typeof(_startAllSpellCooldown));
         	}
         
         	 _startAllSpellCooldownFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxSpellBook_create();
         private static _afxSpellBook_create _afxSpellBook_createFunc;
         internal static IntPtr afxSpellBook_create()
         {
         	if (_afxSpellBook_createFunc == null)
         	{
         		_afxSpellBook_createFunc =
         			(_afxSpellBook_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBook_create"), typeof(_afxSpellBook_create));
         	}
         
         	return  _afxSpellBook_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getPageSlotIndex(Point2I bookSlot)
         {
            return InternalUnsafeMethods.getPageSlotIndex(ObjectPtr, bookSlot.ToArray());
         }
      
         public virtual int getSpellData(Point2I bookSlot)
         {
            return InternalUnsafeMethods.getSpellData(ObjectPtr, bookSlot.ToArray());
         }
      
         public virtual int getSpellRPGData(Point2I bookSlot)
         {
            return InternalUnsafeMethods.getSpellRPGData(ObjectPtr, bookSlot.ToArray());
         }
      
         public virtual void startAllSpellCooldown()
         {
            InternalUnsafeMethods.startAllSpellCooldown(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}