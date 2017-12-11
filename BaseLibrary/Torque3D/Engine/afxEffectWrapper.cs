using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxEffectWrapper : SimObject
	{
		public afxEffectWrapper(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxEffectWrapper(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxEffectWrapper(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxEffectWrapper(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxEffectWrapper(SimObject pObj) : base(pObj)
		{
		}

		public afxEffectWrapper(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxEffectWrapper_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxEffectWrapper_create();
         private static _afxEffectWrapper_create _afxEffectWrapper_createFunc;
         internal static IntPtr afxEffectWrapper_create()
         {
         	if (_afxEffectWrapper_createFunc == null)
         	{
         		_afxEffectWrapper_createFunc =
         			(_afxEffectWrapper_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxEffectWrapper_create"), typeof(_afxEffectWrapper_create));
         	}
         
         	return  _afxEffectWrapper_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float LiveScaleFactor
         {
         	get { return float.Parse(getFieldValue("LiveScaleFactor")); }
         	set { setFieldValue("LiveScaleFactor", value.ToString()); }
         }
      
         public float LiveFadeFactor
         {
         	get { return float.Parse(getFieldValue("LiveFadeFactor")); }
         	set { setFieldValue("LiveFadeFactor", value.ToString()); }
         }
      
      
      #endregion

	}
}