using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxBillboardData : GameBaseData
	{
		public afxBillboardData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxBillboardData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxBillboardData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxBillboardData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxBillboardData(SimObject pObj) : base(pObj)
		{
		}

		public afxBillboardData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxBillboardData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxBillboardData_create();
         private static _afxBillboardData_create _afxBillboardData_createFunc;
         internal static IntPtr afxBillboardData_create()
         {
         	if (_afxBillboardData_createFunc == null)
         	{
         		_afxBillboardData_createFunc =
         			(_afxBillboardData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxBillboardData_create"), typeof(_afxBillboardData_create));
         	}
         
         	return  _afxBillboardData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public LinearColorF Color
         {
         	get { return new LinearColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public string Texture
         {
         	get { return getFieldValue("Texture"); }
         	set { setFieldValue("Texture", value); }
         }
      
         public Point2F Dimensions
         {
         	get { return new Point2F(getFieldValue("Dimensions")); }
         	set { setFieldValue("Dimensions", value.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> TextureCoords
         {
         	get { return new DynamicFieldVector<Point2F>(this, "TextureCoords", 4, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public afxBillboard_BlendStyle BlendStyle
         {
         	get { return (afxBillboard_BlendStyle)Enum.Parse(typeof(afxBillboard_BlendStyle), getFieldValue("BlendStyle"), true); }
         	set { setFieldValue("BlendStyle", value.ToString()); }
         }
      
         public GFXBlend SrcBlendFactor
         {
         	get { return (GFXBlend)Enum.Parse(typeof(GFXBlend), getFieldValue("SrcBlendFactor"), true); }
         	set { setFieldValue("SrcBlendFactor", value.ToString()); }
         }
      
         public GFXBlend DstBlendFactor
         {
         	get { return (GFXBlend)Enum.Parse(typeof(GFXBlend), getFieldValue("DstBlendFactor"), true); }
         	set { setFieldValue("DstBlendFactor", value.ToString()); }
         }
      
         public afxBillboard_TexFuncType TextureFunction
         {
         	get { return (afxBillboard_TexFuncType)Enum.Parse(typeof(afxBillboard_TexFuncType), getFieldValue("TextureFunction"), true); }
         	set { setFieldValue("TextureFunction", value.ToString()); }
         }
      
      
      #endregion

	}
}