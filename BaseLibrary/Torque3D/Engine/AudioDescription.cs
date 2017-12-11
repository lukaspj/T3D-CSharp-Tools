using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AudioDescription : SFXDescription
	{
		public AudioDescription(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AudioDescription(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AudioDescription(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AudioDescription(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AudioDescription(SimObject pObj) : base(pObj)
		{
		}

		public AudioDescription(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AudioDescription_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AudioDescription_create();
         private static _AudioDescription_create _AudioDescription_createFunc;
         internal static IntPtr AudioDescription_create()
         {
         	if (_AudioDescription_createFunc == null)
         	{
         		_AudioDescription_createFunc =
         			(_AudioDescription_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AudioDescription_create"), typeof(_AudioDescription_create));
         	}
         
         	return  _AudioDescription_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}