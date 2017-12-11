using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AnimationComponent : Component
	{
		public AnimationComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AnimationComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AnimationComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AnimationComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AnimationComponent(SimObject pObj) : base(pObj)
		{
		}

		public AnimationComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AnimationComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _playThread(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name, bool transition, float transitionTime);
         private static _playThread _playThreadFunc;
         internal static bool playThread(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name, bool transition, float transitionTime)
         {
         	if (_playThreadFunc == null)
         	{
         		_playThreadFunc =
         			(_playThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_playThread"), typeof(_playThread));
         	}
         
         	return  _playThreadFunc(thisPtr, slot, name, transition, transitionTime);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadDir(IntPtr thisPtr, int slot, bool fwd);
         private static _setThreadDir _setThreadDirFunc;
         internal static bool setThreadDir(IntPtr thisPtr, int slot, bool fwd)
         {
         	if (_setThreadDirFunc == null)
         	{
         		_setThreadDirFunc =
         			(_setThreadDir)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_setThreadDir"), typeof(_setThreadDir));
         	}
         
         	return  _setThreadDirFunc(thisPtr, slot, fwd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadTimeScale(IntPtr thisPtr, int slot, float scale);
         private static _setThreadTimeScale _setThreadTimeScaleFunc;
         internal static bool setThreadTimeScale(IntPtr thisPtr, int slot, float scale)
         {
         	if (_setThreadTimeScaleFunc == null)
         	{
         		_setThreadTimeScaleFunc =
         			(_setThreadTimeScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_setThreadTimeScale"), typeof(_setThreadTimeScale));
         	}
         
         	return  _setThreadTimeScaleFunc(thisPtr, slot, scale);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadPosition(IntPtr thisPtr, int slot, float pos);
         private static _setThreadPosition _setThreadPositionFunc;
         internal static bool setThreadPosition(IntPtr thisPtr, int slot, float pos)
         {
         	if (_setThreadPositionFunc == null)
         	{
         		_setThreadPositionFunc =
         			(_setThreadPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_setThreadPosition"), typeof(_setThreadPosition));
         	}
         
         	return  _setThreadPositionFunc(thisPtr, slot, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadAnimation(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setThreadAnimation _setThreadAnimationFunc;
         internal static bool setThreadAnimation(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setThreadAnimationFunc == null)
         	{
         		_setThreadAnimationFunc =
         			(_setThreadAnimation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_setThreadAnimation"), typeof(_setThreadAnimation));
         	}
         
         	return  _setThreadAnimationFunc(thisPtr, slot, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getThreadAnimation(IntPtr thisPtr, int slot);
         private static _getThreadAnimation _getThreadAnimationFunc;
         internal static IntPtr getThreadAnimation(IntPtr thisPtr, int slot)
         {
         	if (_getThreadAnimationFunc == null)
         	{
         		_getThreadAnimationFunc =
         			(_getThreadAnimation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_getThreadAnimation"), typeof(_getThreadAnimation));
         	}
         
         	return  _getThreadAnimationFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _stopThread(IntPtr thisPtr, int slot);
         private static _stopThread _stopThreadFunc;
         internal static bool stopThread(IntPtr thisPtr, int slot)
         {
         	if (_stopThreadFunc == null)
         	{
         		_stopThreadFunc =
         			(_stopThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_stopThread"), typeof(_stopThread));
         	}
         
         	return  _stopThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _destroyThread(IntPtr thisPtr, int slot);
         private static _destroyThread _destroyThreadFunc;
         internal static bool destroyThread(IntPtr thisPtr, int slot)
         {
         	if (_destroyThreadFunc == null)
         	{
         		_destroyThreadFunc =
         			(_destroyThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_destroyThread"), typeof(_destroyThread));
         	}
         
         	return  _destroyThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _pauseThread(IntPtr thisPtr, int slot);
         private static _pauseThread _pauseThreadFunc;
         internal static bool pauseThread(IntPtr thisPtr, int slot)
         {
         	if (_pauseThreadFunc == null)
         	{
         		_pauseThreadFunc =
         			(_pauseThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_pauseThread"), typeof(_pauseThread));
         	}
         
         	return  _pauseThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAnimationCount(IntPtr thisPtr);
         private static _getAnimationCount _getAnimationCountFunc;
         internal static int getAnimationCount(IntPtr thisPtr)
         {
         	if (_getAnimationCountFunc == null)
         	{
         		_getAnimationCountFunc =
         			(_getAnimationCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_getAnimationCount"), typeof(_getAnimationCount));
         	}
         
         	return  _getAnimationCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAnimationIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getAnimationIndex _getAnimationIndexFunc;
         internal static int getAnimationIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getAnimationIndexFunc == null)
         	{
         		_getAnimationIndexFunc =
         			(_getAnimationIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_getAnimationIndex"), typeof(_getAnimationIndex));
         	}
         
         	return  _getAnimationIndexFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAnimationName(IntPtr thisPtr, int index);
         private static _getAnimationName _getAnimationNameFunc;
         internal static IntPtr getAnimationName(IntPtr thisPtr, int index)
         {
         	if (_getAnimationNameFunc == null)
         	{
         		_getAnimationNameFunc =
         			(_getAnimationName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_getAnimationName"), typeof(_getAnimationName));
         	}
         
         	return  _getAnimationNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AnimationComponent_create();
         private static _AnimationComponent_create _AnimationComponent_createFunc;
         internal static IntPtr AnimationComponent_create()
         {
         	if (_AnimationComponent_createFunc == null)
         	{
         		_AnimationComponent_createFunc =
         			(_AnimationComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AnimationComponent_create"), typeof(_AnimationComponent_create));
         	}
         
         	return  _AnimationComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool playThread(int slot = -1, string name = "", bool transition = true, float transitionTime = 0.5f)
         {
            if (name == null) name = "";
                  return InternalUnsafeMethods.playThread(ObjectPtr, slot, name, transition, transitionTime);
         }
      
         public virtual bool setThreadDir(int slot, bool fwd)
         {
            return InternalUnsafeMethods.setThreadDir(ObjectPtr, slot, fwd);
         }
      
         public virtual bool setThreadTimeScale(int slot, float scale)
         {
            return InternalUnsafeMethods.setThreadTimeScale(ObjectPtr, slot, scale);
         }
      
         public virtual bool setThreadPosition(int slot, float pos)
         {
            return InternalUnsafeMethods.setThreadPosition(ObjectPtr, slot, pos);
         }
      
         public virtual bool setThreadAnimation(int slot, string name = "")
         {
            if (name == null) name = "";
                  return InternalUnsafeMethods.setThreadAnimation(ObjectPtr, slot, name);
         }
      
         public virtual string getThreadAnimation(int slot)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getThreadAnimation(ObjectPtr, slot));
         }
      
         public virtual bool stopThread(int slot)
         {
            return InternalUnsafeMethods.stopThread(ObjectPtr, slot);
         }
      
         public virtual bool destroyThread(int slot)
         {
            return InternalUnsafeMethods.destroyThread(ObjectPtr, slot);
         }
      
         public virtual bool pauseThread(int slot)
         {
            return InternalUnsafeMethods.pauseThread(ObjectPtr, slot);
         }
      
         public virtual int getAnimationCount()
         {
            return InternalUnsafeMethods.getAnimationCount(ObjectPtr);
         }
      
         public virtual int getAnimationIndex(string name)
         {
            return InternalUnsafeMethods.getAnimationIndex(ObjectPtr, name);
         }
      
         public virtual string getAnimationName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAnimationName(ObjectPtr, index));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}