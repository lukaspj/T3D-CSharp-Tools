using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxSpellCastBar : GuiControl
	{
		public afxSpellCastBar(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxSpellCastBar(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxSpellCastBar(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxSpellCastBar(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxSpellCastBar(SimObject pObj) : base(pObj)
		{
		}

		public afxSpellCastBar(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxSpellCastBar_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setProgress(IntPtr thisPtr, float percentDone);
         private static _setProgress _setProgressFunc;
         internal static void setProgress(IntPtr thisPtr, float percentDone)
         {
         	if (_setProgressFunc == null)
         	{
         		_setProgressFunc =
         			(_setProgress)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellCastBar_setProgress"), typeof(_setProgress));
         	}
         
         	 _setProgressFunc(thisPtr, percentDone);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxSpellCastBar_create();
         private static _afxSpellCastBar_create _afxSpellCastBar_createFunc;
         internal static IntPtr afxSpellCastBar_create()
         {
         	if (_afxSpellCastBar_createFunc == null)
         	{
         		_afxSpellCastBar_createFunc =
         			(_afxSpellCastBar_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxSpellCastBar_create"), typeof(_afxSpellCastBar_create));
         	}
         
         	return  _afxSpellCastBar_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setProgress(float percentDone)
         {
            InternalUnsafeMethods.setProgress(ObjectPtr, percentDone);
         }
      
      
      #endregion


      #region Properties
      
      
         public LinearColorF BackgroundColor
         {
         	get { return new LinearColorF(getFieldValue("BackgroundColor")); }
         	set { setFieldValue("BackgroundColor", value.ToString()); }
         }
      
         public LinearColorF BorderColor
         {
         	get { return new LinearColorF(getFieldValue("BorderColor")); }
         	set { setFieldValue("BorderColor", value.ToString()); }
         }
      
         public LinearColorF FillColor
         {
         	get { return new LinearColorF(getFieldValue("FillColor")); }
         	set { setFieldValue("FillColor", value.ToString()); }
         }
      
         public LinearColorF FillColorFinal
         {
         	get { return new LinearColorF(getFieldValue("FillColorFinal")); }
         	set { setFieldValue("FillColorFinal", value.ToString()); }
         }
      
      
      #endregion

	}
}