using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxRPGMagicSpellData : GameBaseData
	{
		public afxRPGMagicSpellData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxRPGMagicSpellData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxRPGMagicSpellData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxRPGMagicSpellData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxRPGMagicSpellData(SimObject pObj) : base(pObj)
		{
		}

		public afxRPGMagicSpellData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxRPGMagicSpellData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxRPGMagicSpellData_create();
         private static _afxRPGMagicSpellData_create _afxRPGMagicSpellData_createFunc;
         internal static IntPtr afxRPGMagicSpellData_create()
         {
         	if (_afxRPGMagicSpellData_createFunc == null)
         	{
         		_afxRPGMagicSpellData_createFunc =
         			(_afxRPGMagicSpellData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxRPGMagicSpellData_create"), typeof(_afxRPGMagicSpellData_create));
         	}
         
         	return  _afxRPGMagicSpellData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string SpellName
         {
         	get { return getFieldValue("SpellName"); }
         	set { setFieldValue("SpellName", value); }
         }
      
         public string Desc
         {
         	get { return getFieldValue("Desc"); }
         	set { setFieldValue("Desc", value); }
         }
      
         public afxRPGMagicSpell_TargetType Target
         {
         	get { return (afxRPGMagicSpell_TargetType)Enum.Parse(typeof(afxRPGMagicSpell_TargetType), getFieldValue("Target"), true); }
         	set { setFieldValue("Target", value.ToString()); }
         }
      
         public float Range
         {
         	get { return float.Parse(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
         }
      
         public int ManaCost
         {
         	get { return int.Parse(getFieldValue("ManaCost")); }
         	set { setFieldValue("ManaCost", value.ToString()); }
         }
      
         public DynamicFieldVector<byte> ReagentCost
         {
         	get { return new DynamicFieldVector<byte>(this, "ReagentCost", 8, val => byte.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> ReagentName
         {
         	get { return new DynamicFieldVector<string>(this, "ReagentName", 8, val => val, obj => obj); }
         }
      
         public float CastingDur
         {
         	get { return float.Parse(getFieldValue("CastingDur")); }
         	set { setFieldValue("CastingDur", value.ToString()); }
         }
      
         public string IconBitmap
         {
         	get { return getFieldValue("IconBitmap"); }
         	set { setFieldValue("IconBitmap", value); }
         }
      
         public string SourcePack
         {
         	get { return getFieldValue("SourcePack"); }
         	set { setFieldValue("SourcePack", value); }
         }
      
         public bool IsPlaceholder
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsPlaceholder")); }
         	set { setFieldValue("IsPlaceholder", value ? "1" : "0"); }
         }
      
         public byte FreeTargetStyle
         {
         	get { return byte.Parse(getFieldValue("FreeTargetStyle")); }
         	set { setFieldValue("FreeTargetStyle", value.ToString()); }
         }
      
         public bool TargetOptional
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TargetOptional")); }
         	set { setFieldValue("TargetOptional", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}