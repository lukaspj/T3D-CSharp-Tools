using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AudioProfile : SFXProfile
	{
		public AudioProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AudioProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AudioProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AudioProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AudioProfile(SimObject pObj) : base(pObj)
		{
		}

		public AudioProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AudioProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AudioProfile_create();
         private static _AudioProfile_create _AudioProfile_createFunc;
         internal static IntPtr AudioProfile_create()
         {
         	if (_AudioProfile_createFunc == null)
         	{
         		_AudioProfile_createFunc =
         			(_AudioProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AudioProfile_create"), typeof(_AudioProfile_create));
         	}
         
         	return  _AudioProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}