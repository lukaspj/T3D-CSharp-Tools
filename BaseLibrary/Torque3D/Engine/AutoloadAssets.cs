using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AutoloadAssets : SimObject
	{
		public AutoloadAssets(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AutoloadAssets(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AutoloadAssets(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AutoloadAssets(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AutoloadAssets(SimObject pObj) : base(pObj)
		{
		}

		public AutoloadAssets(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AutoloadAssets_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AutoloadAssets_create();
         private static _AutoloadAssets_create _AutoloadAssets_createFunc;
         internal static IntPtr AutoloadAssets_create()
         {
         	if (_AutoloadAssets_createFunc == null)
         	{
         		_AutoloadAssets_createFunc =
         			(_AutoloadAssets_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AutoloadAssets_create"), typeof(_AutoloadAssets_create));
         	}
         
         	return  _AutoloadAssets_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Path
         {
         	get { return getFieldValue("Path"); }
         	set { setFieldValue("Path", value); }
         }
      
         public string AssetType
         {
         	get { return getFieldValue("AssetType"); }
         	set { setFieldValue("AssetType", value); }
         }
      
         public bool Recurse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Recurse")); }
         	set { setFieldValue("Recurse", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}