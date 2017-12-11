using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxModelData : GameBaseData
	{
		public afxModelData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxModelData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxModelData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxModelData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxModelData(SimObject pObj) : base(pObj)
		{
		}

		public afxModelData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxModelData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxModelData_create();
         private static _afxModelData_create _afxModelData_createFunc;
         internal static IntPtr afxModelData_create()
         {
         	if (_afxModelData_createFunc == null)
         	{
         		_afxModelData_createFunc =
         			(_afxModelData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxModelData_create"), typeof(_afxModelData_create));
         	}
         
         	return  _afxModelData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public string Sequence
         {
         	get { return getFieldValue("Sequence"); }
         	set { setFieldValue("Sequence", value); }
         }
      
         public float SequenceRate
         {
         	get { return float.Parse(getFieldValue("SequenceRate")); }
         	set { setFieldValue("SequenceRate", value.ToString()); }
         }
      
         public float SequenceOffset
         {
         	get { return float.Parse(getFieldValue("SequenceOffset")); }
         	set { setFieldValue("SequenceOffset", value.ToString()); }
         }
      
         public float AlphaMult
         {
         	get { return float.Parse(getFieldValue("AlphaMult")); }
         	set { setFieldValue("AlphaMult", value.ToString()); }
         }
      
         public float FogMult
         {
         	get { return float.Parse(getFieldValue("FogMult")); }
         	set { setFieldValue("FogMult", value.ToString()); }
         }
      
         public string RemapTextureTags
         {
         	get { return getFieldValue("RemapTextureTags"); }
         	set { setFieldValue("RemapTextureTags", value); }
         }
      
         public bool ShadowEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShadowEnable")); }
         	set { setFieldValue("ShadowEnable", value ? "1" : "0"); }
         }
      
         public bool UseVertexAlpha
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseVertexAlpha")); }
         	set { setFieldValue("UseVertexAlpha", value ? "1" : "0"); }
         }
      
         public int ForceOnMaterialFlags
         {
         	get { return int.Parse(getFieldValue("ForceOnMaterialFlags")); }
         	set { setFieldValue("ForceOnMaterialFlags", value.ToString()); }
         }
      
         public int ForceOffMaterialFlags
         {
         	get { return int.Parse(getFieldValue("ForceOffMaterialFlags")); }
         	set { setFieldValue("ForceOffMaterialFlags", value.ToString()); }
         }
      
         public bool TextureFiltering
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TextureFiltering")); }
         	set { setFieldValue("TextureFiltering", value ? "1" : "0"); }
         }
      
         public bool OverrideLightingOptions
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideLightingOptions")); }
         	set { setFieldValue("OverrideLightingOptions", value ? "1" : "0"); }
         }
      
         public bool ReceiveSunLight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReceiveSunLight")); }
         	set { setFieldValue("ReceiveSunLight", value ? "1" : "0"); }
         }
      
         public bool ReceiveLMLighting
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReceiveLMLighting")); }
         	set { setFieldValue("ReceiveLMLighting", value ? "1" : "0"); }
         }
      
         public bool UseAdaptiveSelfIllumination
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseAdaptiveSelfIllumination")); }
         	set { setFieldValue("UseAdaptiveSelfIllumination", value ? "1" : "0"); }
         }
      
         public bool UseCustomAmbientLighting
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseCustomAmbientLighting")); }
         	set { setFieldValue("UseCustomAmbientLighting", value ? "1" : "0"); }
         }
      
         public bool CustomAmbientSelfIllumination
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CustomAmbientSelfIllumination")); }
         	set { setFieldValue("CustomAmbientSelfIllumination", value ? "1" : "0"); }
         }
      
         public LinearColorF CustomAmbientLighting
         {
         	get { return new LinearColorF(getFieldValue("CustomAmbientLighting")); }
         	set { setFieldValue("CustomAmbientLighting", value.ToString()); }
         }
      
         public int ShadowSize
         {
         	get { return int.Parse(getFieldValue("ShadowSize")); }
         	set { setFieldValue("ShadowSize", value.ToString()); }
         }
      
         public float ShadowMaxVisibleDistance
         {
         	get { return float.Parse(getFieldValue("ShadowMaxVisibleDistance")); }
         	set { setFieldValue("ShadowMaxVisibleDistance", value.ToString()); }
         }
      
         public float ShadowProjectionDistance
         {
         	get { return float.Parse(getFieldValue("ShadowProjectionDistance")); }
         	set { setFieldValue("ShadowProjectionDistance", value.ToString()); }
         }
      
         public float ShadowSphereAdjust
         {
         	get { return float.Parse(getFieldValue("ShadowSphereAdjust")); }
         	set { setFieldValue("ShadowSphereAdjust", value.ToString()); }
         }
      
      
      #endregion

	}
}