using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxGuiTextHud : GuiControl
	{
		public afxGuiTextHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxGuiTextHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxGuiTextHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxGuiTextHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxGuiTextHud(SimObject pObj) : base(pObj)
		{
		}

		public afxGuiTextHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxGuiTextHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxGuiTextHud_create();
         private static _afxGuiTextHud_create _afxGuiTextHud_createFunc;
         internal static IntPtr afxGuiTextHud_create()
         {
         	if (_afxGuiTextHud_createFunc == null)
         	{
         		_afxGuiTextHud_createFunc =
         			(_afxGuiTextHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxGuiTextHud_create"), typeof(_afxGuiTextHud_create));
         	}
         
         	return  _afxGuiTextHud_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public LinearColorF FillColor
         {
         	get { return new LinearColorF(getFieldValue("FillColor")); }
         	set { setFieldValue("FillColor", value.ToString()); }
         }
      
         public LinearColorF FrameColor
         {
         	get { return new LinearColorF(getFieldValue("FrameColor")); }
         	set { setFieldValue("FrameColor", value.ToString()); }
         }
      
         public LinearColorF TextColor
         {
         	get { return new LinearColorF(getFieldValue("TextColor")); }
         	set { setFieldValue("TextColor", value.ToString()); }
         }
      
         public bool ShowFill
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowFill")); }
         	set { setFieldValue("ShowFill", value ? "1" : "0"); }
         }
      
         public bool ShowFrame
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowFrame")); }
         	set { setFieldValue("ShowFrame", value ? "1" : "0"); }
         }
      
         public float VerticalOffset
         {
         	get { return float.Parse(getFieldValue("VerticalOffset")); }
         	set { setFieldValue("VerticalOffset", value.ToString()); }
         }
      
         public float DistanceFade
         {
         	get { return float.Parse(getFieldValue("DistanceFade")); }
         	set { setFieldValue("DistanceFade", value.ToString()); }
         }
      
         public bool LabelAllShapes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LabelAllShapes")); }
         	set { setFieldValue("LabelAllShapes", value ? "1" : "0"); }
         }
      
         public bool EnableControlObjectOcclusion
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EnableControlObjectOcclusion")); }
         	set { setFieldValue("EnableControlObjectOcclusion", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}