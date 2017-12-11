using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CollisionTrigger : GameBase
	{
		public CollisionTrigger(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CollisionTrigger(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CollisionTrigger(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CollisionTrigger(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CollisionTrigger(SimObject pObj) : base(pObj)
		{
		}

		public CollisionTrigger(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CollisionTrigger_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumObjects(IntPtr thisPtr);
         private static _getNumObjects _getNumObjectsFunc;
         internal static int getNumObjects(IntPtr thisPtr)
         {
         	if (_getNumObjectsFunc == null)
         	{
         		_getNumObjectsFunc =
         			(_getNumObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionTrigger_getNumObjects"), typeof(_getNumObjects));
         	}
         
         	return  _getNumObjectsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getObject(IntPtr thisPtr, int index);
         private static _getObject _getObjectFunc;
         internal static int getObject(IntPtr thisPtr, int index)
         {
         	if (_getObjectFunc == null)
         	{
         		_getObjectFunc =
         			(_getObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionTrigger_getObject"), typeof(_getObject));
         	}
         
         	return  _getObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CollisionTrigger_create();
         private static _CollisionTrigger_create _CollisionTrigger_createFunc;
         internal static IntPtr CollisionTrigger_create()
         {
         	if (_CollisionTrigger_createFunc == null)
         	{
         		_CollisionTrigger_createFunc =
         			(_CollisionTrigger_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionTrigger_create"), typeof(_CollisionTrigger_create));
         	}
         
         	return  _CollisionTrigger_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getNumObjects()
         {
            return InternalUnsafeMethods.getNumObjects(ObjectPtr);
         }
      
         public virtual int getObject(int index)
         {
            return InternalUnsafeMethods.getObject(ObjectPtr, index);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Polyhedron
         {
         	get { return getFieldValue("Polyhedron"); }
         	set { setFieldValue("Polyhedron", value); }
         }
      
         public string EnterCommand
         {
         	get { return getFieldValue("EnterCommand"); }
         	set { setFieldValue("EnterCommand", value); }
         }
      
         public string LeaveCommand
         {
         	get { return getFieldValue("LeaveCommand"); }
         	set { setFieldValue("LeaveCommand", value); }
         }
      
         public string TickCommand
         {
         	get { return getFieldValue("TickCommand"); }
         	set { setFieldValue("TickCommand", value); }
         }
      
      
      #endregion

	}
}