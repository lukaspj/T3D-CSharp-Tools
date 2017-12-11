using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxSpellButton : GuiButtonCtrl
	{
		public afxSpellButton(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxSpellButton(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxSpellButton(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxSpellButton(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxSpellButton(SimObject pObj) : base(pObj)
		{
		}

		public afxSpellButton(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxSpellButton_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _onSpellbookChange(IntPtr thisPtr, IntPtr spellbook, uint page);
         private static _onSpellbookChange _onSpellbookChangeFunc;
         internal static void onSpellbookChange(IntPtr thisPtr, IntPtr spellbook, uint page)
         {
         	if (_onSpellbookChangeFunc == null)
         	{
         		_onSpellbookChangeFunc =
         			(_onSpellbookChange)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_onSpellbookChange"), typeof(_onSpellbookChange));
         	}
         
         	 _onSpellbookChangeFunc(thisPtr, spellbook, page);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _onTurnPage(IntPtr thisPtr, uint page);
         private static _onTurnPage _onTurnPageFunc;
         internal static void onTurnPage(IntPtr thisPtr, uint page)
         {
         	if (_onTurnPageFunc == null)
         	{
         		_onTurnPageFunc =
         			(_onTurnPage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_onTurnPage"), typeof(_onTurnPage));
         	}
         
         	 _onTurnPageFunc(thisPtr, page);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSpellDescription(IntPtr thisPtr);
         private static _getSpellDescription _getSpellDescriptionFunc;
         internal static IntPtr getSpellDescription(IntPtr thisPtr)
         {
         	if (_getSpellDescriptionFunc == null)
         	{
         		_getSpellDescriptionFunc =
         			(_getSpellDescription)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_getSpellDescription"), typeof(_getSpellDescription));
         	}
         
         	return  _getSpellDescriptionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSpellDataBlock(IntPtr thisPtr);
         private static _getSpellDataBlock _getSpellDataBlockFunc;
         internal static int getSpellDataBlock(IntPtr thisPtr)
         {
         	if (_getSpellDataBlockFunc == null)
         	{
         		_getSpellDataBlockFunc =
         			(_getSpellDataBlock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_getSpellDataBlock"), typeof(_getSpellDataBlock));
         	}
         
         	return  _getSpellDataBlockFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSpellRPGDataBlock(IntPtr thisPtr);
         private static _getSpellRPGDataBlock _getSpellRPGDataBlockFunc;
         internal static int getSpellRPGDataBlock(IntPtr thisPtr)
         {
         	if (_getSpellRPGDataBlockFunc == null)
         	{
         		_getSpellRPGDataBlockFunc =
         			(_getSpellRPGDataBlock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_getSpellRPGDataBlock"), typeof(_getSpellRPGDataBlock));
         	}
         
         	return  _getSpellRPGDataBlockFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _useFreeTargeting(IntPtr thisPtr);
         private static _useFreeTargeting _useFreeTargetingFunc;
         internal static bool useFreeTargeting(IntPtr thisPtr)
         {
         	if (_useFreeTargetingFunc == null)
         	{
         		_useFreeTargetingFunc =
         			(_useFreeTargeting)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_useFreeTargeting"), typeof(_useFreeTargeting));
         	}
         
         	return  _useFreeTargetingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFreeTargetStyle(IntPtr thisPtr);
         private static _getFreeTargetStyle _getFreeTargetStyleFunc;
         internal static int getFreeTargetStyle(IntPtr thisPtr)
         {
         	if (_getFreeTargetStyleFunc == null)
         	{
         		_getFreeTargetStyleFunc =
         			(_getFreeTargetStyle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_getFreeTargetStyle"), typeof(_getFreeTargetStyle));
         	}
         
         	return  _getFreeTargetStyleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxSpellButton_create();
         private static _afxSpellButton_create _afxSpellButton_createFunc;
         internal static IntPtr afxSpellButton_create()
         {
         	if (_afxSpellButton_createFunc == null)
         	{
         		_afxSpellButton_createFunc =
         			(_afxSpellButton_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellButton_create"), typeof(_afxSpellButton_create));
         	}
         
         	return  _afxSpellButton_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void onSpellbookChange(afxSpellBook spellbook, uint page)
         {
            InternalUnsafeMethods.onSpellbookChange(ObjectPtr, spellbook.ObjectPtr, page);
         }
      
         public virtual void onTurnPage(uint page)
         {
            InternalUnsafeMethods.onTurnPage(ObjectPtr, page);
         }
      
         public virtual string getSpellDescription()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSpellDescription(ObjectPtr));
         }
      
         public virtual int getSpellDataBlock()
         {
            return InternalUnsafeMethods.getSpellDataBlock(ObjectPtr);
         }
      
         public virtual int getSpellRPGDataBlock()
         {
            return InternalUnsafeMethods.getSpellRPGDataBlock(ObjectPtr);
         }
      
         public virtual bool useFreeTargeting()
         {
            return InternalUnsafeMethods.useFreeTargeting(ObjectPtr);
         }
      
         public virtual int getFreeTargetStyle()
         {
            return InternalUnsafeMethods.getFreeTargetStyle(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
         public Point2I Book_slot
         {
         	get { return new Point2I(getFieldValue("Book_slot")); }
         	set { setFieldValue("Book_slot", value.ToString()); }
         }
      
      
      #endregion

	}
}