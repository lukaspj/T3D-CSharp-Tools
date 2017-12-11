using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxF_DragData : GameBaseData
	{
		public afxF_DragData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxF_DragData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxF_DragData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxF_DragData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxF_DragData(SimObject pObj) : base(pObj)
		{
		}

		public afxF_DragData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxF_DragData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxF_DragData_create();
         private static _afxF_DragData_create _afxF_DragData_createFunc;
         internal static IntPtr afxF_DragData_create()
         {
         	if (_afxF_DragData_createFunc == null)
         	{
         		_afxF_DragData_createFunc =
         			(_afxF_DragData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxF_DragData_create"), typeof(_afxF_DragData_create));
         	}
         
         	return  _afxF_DragData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Drag
         {
         	get { return float.Parse(getFieldValue("Drag")); }
         	set { setFieldValue("Drag", value.ToString()); }
         }
      
         public float AirDensity
         {
         	get { return float.Parse(getFieldValue("AirDensity")); }
         	set { setFieldValue("AirDensity", value.ToString()); }
         }
      
         public float CrossSectionalArea
         {
         	get { return float.Parse(getFieldValue("CrossSectionalArea")); }
         	set { setFieldValue("CrossSectionalArea", value.ToString()); }
         }
      
         public string ForceSetName
         {
         	get { return getFieldValue("ForceSetName"); }
         	set { setFieldValue("ForceSetName", value); }
         }
      
      
      #endregion

	}
}