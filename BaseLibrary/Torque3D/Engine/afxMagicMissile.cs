using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxMagicMissile : GameBase
	{
		public afxMagicMissile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxMagicMissile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxMagicMissile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxMagicMissile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxMagicMissile(SimObject pObj) : base(pObj)
		{
		}

		public afxMagicMissile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxMagicMissile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setStartingVelocityVector(IntPtr thisPtr, InternalPoint3FStruct velocityVec);
         private static _setStartingVelocityVector _setStartingVelocityVectorFunc;
         internal static void setStartingVelocityVector(IntPtr thisPtr, InternalPoint3FStruct velocityVec)
         {
         	if (_setStartingVelocityVectorFunc == null)
         	{
         		_setStartingVelocityVectorFunc =
         			(_setStartingVelocityVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicMissile_setStartingVelocityVector"), typeof(_setStartingVelocityVector));
         	}
         
         	 _setStartingVelocityVectorFunc(thisPtr, velocityVec);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setStartingVelocity(IntPtr thisPtr, float velocity);
         private static _setStartingVelocity _setStartingVelocityFunc;
         internal static void setStartingVelocity(IntPtr thisPtr, float velocity)
         {
         	if (_setStartingVelocityFunc == null)
         	{
         		_setStartingVelocityFunc =
         			(_setStartingVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicMissile_setStartingVelocity"), typeof(_setStartingVelocity));
         	}
         
         	 _setStartingVelocityFunc(thisPtr, velocity);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxMagicMissile_create();
         private static _afxMagicMissile_create _afxMagicMissile_createFunc;
         internal static IntPtr afxMagicMissile_create()
         {
         	if (_afxMagicMissile_createFunc == null)
         	{
         		_afxMagicMissile_createFunc =
         			(_afxMagicMissile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxMagicMissile_create"), typeof(_afxMagicMissile_create));
         	}
         
         	return  _afxMagicMissile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setStartingVelocityVector(Point3F velocityVec)
         {
            InternalUnsafeMethods.setStartingVelocityVector(ObjectPtr, velocityVec.ToStruct());
         }
      
         public virtual void setStartingVelocity(float velocity)
         {
            InternalUnsafeMethods.setStartingVelocity(ObjectPtr, velocity);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F InitialPosition
         {
         	get { return new Point3F(getFieldValue("InitialPosition")); }
         	set { setFieldValue("InitialPosition", value.ToString()); }
         }
      
         public Point3F InitialVelocity
         {
         	get { return new Point3F(getFieldValue("InitialVelocity")); }
         	set { setFieldValue("InitialVelocity", value.ToString()); }
         }
      
      
      #endregion

	}
}