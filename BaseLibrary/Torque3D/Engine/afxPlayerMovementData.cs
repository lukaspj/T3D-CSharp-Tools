using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxPlayerMovementData : GameBaseData
	{
		public afxPlayerMovementData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxPlayerMovementData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxPlayerMovementData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxPlayerMovementData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxPlayerMovementData(SimObject pObj) : base(pObj)
		{
		}

		public afxPlayerMovementData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxPlayerMovementData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxPlayerMovementData_create();
         private static _afxPlayerMovementData_create _afxPlayerMovementData_createFunc;
         internal static IntPtr afxPlayerMovementData_create()
         {
         	if (_afxPlayerMovementData_createFunc == null)
         	{
         		_afxPlayerMovementData_createFunc =
         			(_afxPlayerMovementData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxPlayerMovementData_create"), typeof(_afxPlayerMovementData_create));
         	}
         
         	return  _afxPlayerMovementData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float SpeedBias
         {
         	get { return float.Parse(getFieldValue("SpeedBias")); }
         	set { setFieldValue("SpeedBias", value.ToString()); }
         }
      
         public Point3F Movement
         {
         	get { return new Point3F(getFieldValue("Movement")); }
         	set { setFieldValue("Movement", value.ToString()); }
         }
      
         public afxPlayerMovement_OpType MovementOp
         {
         	get { return (afxPlayerMovement_OpType)Enum.Parse(typeof(afxPlayerMovement_OpType), getFieldValue("MovementOp"), true); }
         	set { setFieldValue("MovementOp", value.ToString()); }
         }
      
      
      #endregion

	}
}