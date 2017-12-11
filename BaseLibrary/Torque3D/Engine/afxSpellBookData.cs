using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxSpellBookData : GameBaseData
	{
		public afxSpellBookData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxSpellBookData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxSpellBookData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxSpellBookData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxSpellBookData(SimObject pObj) : base(pObj)
		{
		}

		public afxSpellBookData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxSpellBookData_create();
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
         				"fn_afxSpellBookData_getPageSlotIndex"), typeof(_getPageSlotIndex));
         	}
         
         	return  _getPageSlotIndexFunc(thisPtr, bookSlot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCapacity(IntPtr thisPtr);
         private static _getCapacity _getCapacityFunc;
         internal static int getCapacity(IntPtr thisPtr)
         {
         	if (_getCapacityFunc == null)
         	{
         		_getCapacityFunc =
         			(_getCapacity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBookData_getCapacity"), typeof(_getCapacity));
         	}
         
         	return  _getCapacityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxSpellBookData_create();
         private static _afxSpellBookData_create _afxSpellBookData_createFunc;
         internal static IntPtr afxSpellBookData_create()
         {
         	if (_afxSpellBookData_createFunc == null)
         	{
         		_afxSpellBookData_createFunc =
         			(_afxSpellBookData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellBookData_create"), typeof(_afxSpellBookData_create));
         	}
         
         	return  _afxSpellBookData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getPageSlotIndex(Point2I bookSlot)
         {
            return InternalUnsafeMethods.getPageSlotIndex(ObjectPtr, bookSlot.ToArray());
         }
      
         public virtual int getCapacity()
         {
            return InternalUnsafeMethods.getCapacity(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public byte SpellsPerPage
         {
         	get { return byte.Parse(getFieldValue("SpellsPerPage")); }
         	set { setFieldValue("SpellsPerPage", value.ToString()); }
         }
      
         public byte PagesPerBook
         {
         	get { return byte.Parse(getFieldValue("PagesPerBook")); }
         	set { setFieldValue("PagesPerBook", value.ToString()); }
         }
      
         public DynamicFieldVector<GameBaseData> Spells
         {
         	get { return new DynamicFieldVector<GameBaseData>(this, "Spells", 144, val => Sim.FindObject<GameBaseData>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<GameBaseData> RpgSpells
         {
         	get { return new DynamicFieldVector<GameBaseData>(this, "RpgSpells", 144, val => Sim.FindObject<GameBaseData>(val), obj => obj.getId().ToString()); }
         }
      
      
      #endregion

	}
}