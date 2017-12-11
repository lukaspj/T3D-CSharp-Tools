using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxStaticShapeData : StaticShapeData
	{
		public afxStaticShapeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxStaticShapeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxStaticShapeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxStaticShapeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxStaticShapeData(SimObject pObj) : base(pObj)
		{
		}

		public afxStaticShapeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxStaticShapeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxStaticShapeData_create();
         private static _afxStaticShapeData_create _afxStaticShapeData_createFunc;
         internal static IntPtr afxStaticShapeData_create()
         {
         	if (_afxStaticShapeData_createFunc == null)
         	{
         		_afxStaticShapeData_createFunc =
         			(_afxStaticShapeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStaticShapeData_create"), typeof(_afxStaticShapeData_create));
         	}
         
         	return  _afxStaticShapeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Sequence
         {
         	get { return getFieldValue("Sequence"); }
         	set { setFieldValue("Sequence", value); }
         }
      
         public bool IgnoreSceneAmbient
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreSceneAmbient")); }
         	set { setFieldValue("IgnoreSceneAmbient", value ? "1" : "0"); }
         }
      
         public bool UseCustomSceneAmbient
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseCustomSceneAmbient")); }
         	set { setFieldValue("UseCustomSceneAmbient", value ? "1" : "0"); }
         }
      
         public LinearColorF CustomSceneAmbient
         {
         	get { return new LinearColorF(getFieldValue("CustomSceneAmbient")); }
         	set { setFieldValue("CustomSceneAmbient", value.ToString()); }
         }
      
         public bool DoSpawn
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DoSpawn")); }
         	set { setFieldValue("DoSpawn", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}