using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxStatusBar : GuiControl
	{
		public afxStatusBar(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxStatusBar(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxStatusBar(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxStatusBar(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxStatusBar(SimObject pObj) : base(pObj)
		{
		}

		public afxStatusBar(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxStatusBar_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setProgress(IntPtr thisPtr, float percentDone);
         private static _setProgress _setProgressFunc;
         internal static void setProgress(IntPtr thisPtr, float percentDone)
         {
         	if (_setProgressFunc == null)
         	{
         		_setProgressFunc =
         			(_setProgress)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStatusBar_setProgress"), typeof(_setProgress));
         	}
         
         	 _setProgressFunc(thisPtr, percentDone);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setShape(IntPtr thisPtr, IntPtr shape);
         private static _setShape _setShapeFunc;
         internal static void setShape(IntPtr thisPtr, IntPtr shape)
         {
         	if (_setShapeFunc == null)
         	{
         		_setShapeFunc =
         			(_setShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStatusBar_setShape"), typeof(_setShape));
         	}
         
         	 _setShapeFunc(thisPtr, shape);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearShape(IntPtr thisPtr);
         private static _clearShape _clearShapeFunc;
         internal static void clearShape(IntPtr thisPtr)
         {
         	if (_clearShapeFunc == null)
         	{
         		_clearShapeFunc =
         			(_clearShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStatusBar_clearShape"), typeof(_clearShape));
         	}
         
         	 _clearShapeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxStatusBar_create();
         private static _afxStatusBar_create _afxStatusBar_createFunc;
         internal static IntPtr afxStatusBar_create()
         {
         	if (_afxStatusBar_createFunc == null)
         	{
         		_afxStatusBar_createFunc =
         			(_afxStatusBar_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxStatusBar_create"), typeof(_afxStatusBar_create));
         	}
         
         	return  _afxStatusBar_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setProgress(float percentDone)
         {
            InternalUnsafeMethods.setProgress(ObjectPtr, percentDone);
         }
      
         public virtual void setShape(ShapeBase shape)
         {
            InternalUnsafeMethods.setShape(ObjectPtr, shape.ObjectPtr);
         }
      
         public virtual void clearShape()
         {
            InternalUnsafeMethods.clearShape(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public LinearColorF FillColor
         {
         	get { return new LinearColorF(getFieldValue("FillColor")); }
         	set { setFieldValue("FillColor", value.ToString()); }
         }
      
         public bool DisplayEnergy
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DisplayEnergy")); }
         	set { setFieldValue("DisplayEnergy", value ? "1" : "0"); }
         }
      
         public bool MonitorPlayer
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MonitorPlayer")); }
         	set { setFieldValue("MonitorPlayer", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}