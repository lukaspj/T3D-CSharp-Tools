using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxChoreographer : GameBase
	{
		public afxChoreographer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxChoreographer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxChoreographer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxChoreographer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxChoreographer(SimObject pObj) : base(pObj)
		{
		}

		public afxChoreographer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxChoreographer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRanking(IntPtr thisPtr, uint ranking);
         private static _setRanking _setRankingFunc;
         internal static void setRanking(IntPtr thisPtr, uint ranking)
         {
         	if (_setRankingFunc == null)
         	{
         		_setRankingFunc =
         			(_setRanking)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_setRanking"), typeof(_setRanking));
         	}
         
         	 _setRankingFunc(thisPtr, ranking);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLevelOfDetail(IntPtr thisPtr, uint lod);
         private static _setLevelOfDetail _setLevelOfDetailFunc;
         internal static void setLevelOfDetail(IntPtr thisPtr, uint lod)
         {
         	if (_setLevelOfDetailFunc == null)
         	{
         		_setLevelOfDetailFunc =
         			(_setLevelOfDetail)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_setLevelOfDetail"), typeof(_setLevelOfDetail));
         	}
         
         	 _setLevelOfDetailFunc(thisPtr, lod);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setExecConditions(IntPtr thisPtr, uint mask);
         private static _setExecConditions _setExecConditionsFunc;
         internal static void setExecConditions(IntPtr thisPtr, uint mask)
         {
         	if (_setExecConditionsFunc == null)
         	{
         		_setExecConditionsFunc =
         			(_setExecConditions)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_setExecConditions"), typeof(_setExecConditions));
         	}
         
         	 _setExecConditionsFunc(thisPtr, mask);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addConstraint(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _addConstraint _addConstraintFunc;
         internal static void addConstraint(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_addConstraintFunc == null)
         	{
         		_addConstraintFunc =
         			(_addConstraint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_addConstraint"), typeof(_addConstraint));
         	}
         
         	 _addConstraintFunc(thisPtr, source, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addExplicitClient(IntPtr thisPtr, IntPtr client);
         private static _addExplicitClient _addExplicitClientFunc;
         internal static void addExplicitClient(IntPtr thisPtr, IntPtr client)
         {
         	if (_addExplicitClientFunc == null)
         	{
         		_addExplicitClientFunc =
         			(_addExplicitClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_addExplicitClient"), typeof(_addExplicitClient));
         	}
         
         	 _addExplicitClientFunc(thisPtr, client);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTriggerBit(IntPtr thisPtr, uint bit_num);
         private static _setTriggerBit _setTriggerBitFunc;
         internal static void setTriggerBit(IntPtr thisPtr, uint bit_num)
         {
         	if (_setTriggerBitFunc == null)
         	{
         		_setTriggerBitFunc =
         			(_setTriggerBit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_setTriggerBit"), typeof(_setTriggerBit));
         	}
         
         	 _setTriggerBitFunc(thisPtr, bit_num);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearTriggerBit(IntPtr thisPtr, uint bit_num);
         private static _clearTriggerBit _clearTriggerBitFunc;
         internal static void clearTriggerBit(IntPtr thisPtr, uint bit_num)
         {
         	if (_clearTriggerBitFunc == null)
         	{
         		_clearTriggerBitFunc =
         			(_clearTriggerBit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_clearTriggerBit"), typeof(_clearTriggerBit));
         	}
         
         	 _clearTriggerBitFunc(thisPtr, bit_num);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _testTriggerBit(IntPtr thisPtr, uint bit_num);
         private static _testTriggerBit _testTriggerBitFunc;
         internal static bool testTriggerBit(IntPtr thisPtr, uint bit_num)
         {
         	if (_testTriggerBitFunc == null)
         	{
         		_testTriggerBitFunc =
         			(_testTriggerBit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_testTriggerBit"), typeof(_testTriggerBit));
         	}
         
         	return  _testTriggerBitFunc(thisPtr, bit_num);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _remapConstraint(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _remapConstraint _remapConstraintFunc;
         internal static void remapConstraint(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_remapConstraintFunc == null)
         	{
         		_remapConstraintFunc =
         			(_remapConstraint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_remapConstraint"), typeof(_remapConstraint));
         	}
         
         	 _remapConstraintFunc(thisPtr, source, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxChoreographer_create();
         private static _afxChoreographer_create _afxChoreographer_createFunc;
         internal static IntPtr afxChoreographer_create()
         {
         	if (_afxChoreographer_createFunc == null)
         	{
         		_afxChoreographer_createFunc =
         			(_afxChoreographer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxChoreographer_create"), typeof(_afxChoreographer_create));
         	}
         
         	return  _afxChoreographer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setRanking(uint ranking)
         {
            InternalUnsafeMethods.setRanking(ObjectPtr, ranking);
         }
      
         public virtual void setLevelOfDetail(uint lod)
         {
            InternalUnsafeMethods.setLevelOfDetail(ObjectPtr, lod);
         }
      
         public virtual void setExecConditions(uint mask)
         {
            InternalUnsafeMethods.setExecConditions(ObjectPtr, mask);
         }
      
         public virtual void addConstraint(string source, string name)
         {
            InternalUnsafeMethods.addConstraint(ObjectPtr, source, name);
         }
      
         public virtual void addExplicitClient(NetConnection client)
         {
            InternalUnsafeMethods.addExplicitClient(ObjectPtr, client.ObjectPtr);
         }
      
         public virtual void setTriggerBit(uint bit_num)
         {
            InternalUnsafeMethods.setTriggerBit(ObjectPtr, bit_num);
         }
      
         public virtual void clearTriggerBit(uint bit_num)
         {
            InternalUnsafeMethods.clearTriggerBit(ObjectPtr, bit_num);
         }
      
         public virtual bool testTriggerBit(uint bit_num)
         {
            return InternalUnsafeMethods.testTriggerBit(ObjectPtr, bit_num);
         }
      
         public virtual void remapConstraint(string source, string name)
         {
            InternalUnsafeMethods.remapConstraint(ObjectPtr, source, name);
         }
      
      
      #endregion


      #region Properties
      
      
         public SimObject Extra
         {
         	get { return Sim.FindObject<SimObject>(getFieldValue("Extra")); }
         	set { setFieldValue("Extra", value.getId().ToString()); }
         }
      
         public bool PostponeActivation
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PostponeActivation")); }
         	set { setFieldValue("PostponeActivation", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}