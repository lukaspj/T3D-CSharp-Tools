using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TriggerComponent : Component
	{
		public TriggerComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TriggerComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TriggerComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TriggerComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TriggerComponent(SimObject pObj) : base(pObj)
		{
		}

		public TriggerComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TriggerComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addClient(IntPtr thisPtr, int clientID);
         private static _addClient _addClientFunc;
         internal static void addClient(IntPtr thisPtr, int clientID)
         {
         	if (_addClientFunc == null)
         	{
         		_addClientFunc =
         			(_addClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TriggerComponent_addClient"), typeof(_addClient));
         	}
         
         	 _addClientFunc(thisPtr, clientID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeClient(IntPtr thisPtr, int clientID);
         private static _removeClient _removeClientFunc;
         internal static void removeClient(IntPtr thisPtr, int clientID)
         {
         	if (_removeClientFunc == null)
         	{
         		_removeClientFunc =
         			(_removeClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TriggerComponent_removeClient"), typeof(_removeClient));
         	}
         
         	 _removeClientFunc(thisPtr, clientID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _visualizeFrustums(IntPtr thisPtr, float renderTime);
         private static _visualizeFrustums _visualizeFrustumsFunc;
         internal static void visualizeFrustums(IntPtr thisPtr, float renderTime)
         {
         	if (_visualizeFrustumsFunc == null)
         	{
         		_visualizeFrustumsFunc =
         			(_visualizeFrustums)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TriggerComponent_visualizeFrustums"), typeof(_visualizeFrustums));
         	}
         
         	 _visualizeFrustumsFunc(thisPtr, renderTime);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TriggerComponent_create();
         private static _TriggerComponent_create _TriggerComponent_createFunc;
         internal static IntPtr TriggerComponent_create()
         {
         	if (_TriggerComponent_createFunc == null)
         	{
         		_TriggerComponent_createFunc =
         			(_TriggerComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TriggerComponent_create"), typeof(_TriggerComponent_create));
         	}
         
         	return  _TriggerComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addClient(int clientID = -1)
         {
            InternalUnsafeMethods.addClient(ObjectPtr, clientID);
         }
      
         public virtual void removeClient(int clientID = -1)
         {
            InternalUnsafeMethods.removeClient(ObjectPtr, clientID);
         }
      
         public virtual void visualizeFrustums(float renderTime = 1000f)
         {
            InternalUnsafeMethods.visualizeFrustums(ObjectPtr, renderTime);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Visibile
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Visibile")); }
         	set { setFieldValue("Visibile", value ? "1" : "0"); }
         }
      
         public string OnEnterViewCmd
         {
         	get { return getFieldValue("OnEnterViewCmd"); }
         	set { setFieldValue("OnEnterViewCmd", value); }
         }
      
         public string OnExitViewCmd
         {
         	get { return getFieldValue("OnExitViewCmd"); }
         	set { setFieldValue("OnExitViewCmd", value); }
         }
      
         public string OnUpdateInViewCmd
         {
         	get { return getFieldValue("OnUpdateInViewCmd"); }
         	set { setFieldValue("OnUpdateInViewCmd", value); }
         }
      
      
      #endregion

	}
}