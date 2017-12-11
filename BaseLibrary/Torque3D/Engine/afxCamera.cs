using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class afxCamera : ShapeBase
	{
		public afxCamera(bool pRegister = false)
			: base(pRegister)
		{
		}

		public afxCamera(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public afxCamera(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public afxCamera(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public afxCamera(SimObject pObj) : base(pObj)
		{
		}

		public afxCamera(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.afxCamera_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrbitMode(IntPtr thisPtr, int argc, string[] argv);
         private static _setOrbitMode _setOrbitModeFunc;
         internal static void setOrbitMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setOrbitModeFunc == null)
         	{
         		_setOrbitModeFunc =
         			(_setOrbitMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setOrbitMode"), typeof(_setOrbitMode));
         	}
         
         	 _setOrbitModeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFlyMode(IntPtr thisPtr, int argc, string[] argv);
         private static _setFlyMode _setFlyModeFunc;
         internal static void setFlyMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setFlyModeFunc == null)
         	{
         		_setFlyModeFunc =
         			(_setFlyMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setFlyMode"), typeof(_setFlyMode));
         	}
         
         	 _setFlyModeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getPosition(IntPtr thisPtr, int argc, string[] argv);
         private static _getPosition _getPositionFunc;
         internal static IntPtr getPosition(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getPositionFunc == null)
         	{
         		_getPositionFunc =
         			(_getPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_getPosition"), typeof(_getPosition));
         	}
         
         	return  _getPositionFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setCameraSubject(IntPtr thisPtr, int argc, string[] argv);
         private static _setCameraSubject _setCameraSubjectFunc;
         internal static bool setCameraSubject(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setCameraSubjectFunc == null)
         	{
         		_setCameraSubjectFunc =
         			(_setCameraSubject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setCameraSubject"), typeof(_setCameraSubject));
         	}
         
         	return  _setCameraSubjectFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThirdPersonDistance(IntPtr thisPtr, int argc, string[] argv);
         private static _setThirdPersonDistance _setThirdPersonDistanceFunc;
         internal static bool setThirdPersonDistance(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setThirdPersonDistanceFunc == null)
         	{
         		_setThirdPersonDistanceFunc =
         			(_setThirdPersonDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setThirdPersonDistance"), typeof(_setThirdPersonDistance));
         	}
         
         	return  _setThirdPersonDistanceFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getThirdPersonDistance(IntPtr thisPtr, int argc, string[] argv);
         private static _getThirdPersonDistance _getThirdPersonDistanceFunc;
         internal static float getThirdPersonDistance(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getThirdPersonDistanceFunc == null)
         	{
         		_getThirdPersonDistanceFunc =
         			(_getThirdPersonDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_getThirdPersonDistance"), typeof(_getThirdPersonDistance));
         	}
         
         	return  _getThirdPersonDistanceFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThirdPersonAngle(IntPtr thisPtr, int argc, string[] argv);
         private static _setThirdPersonAngle _setThirdPersonAngleFunc;
         internal static bool setThirdPersonAngle(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setThirdPersonAngleFunc == null)
         	{
         		_setThirdPersonAngleFunc =
         			(_setThirdPersonAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setThirdPersonAngle"), typeof(_setThirdPersonAngle));
         	}
         
         	return  _setThirdPersonAngleFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getThirdPersonAngle(IntPtr thisPtr, int argc, string[] argv);
         private static _getThirdPersonAngle _getThirdPersonAngleFunc;
         internal static float getThirdPersonAngle(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getThirdPersonAngleFunc == null)
         	{
         		_getThirdPersonAngleFunc =
         			(_getThirdPersonAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_getThirdPersonAngle"), typeof(_getThirdPersonAngle));
         	}
         
         	return  _getThirdPersonAngleFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setThirdPersonOffset(IntPtr thisPtr, int argc, string[] argv);
         private static _setThirdPersonOffset _setThirdPersonOffsetFunc;
         internal static void setThirdPersonOffset(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setThirdPersonOffsetFunc == null)
         	{
         		_setThirdPersonOffsetFunc =
         			(_setThirdPersonOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setThirdPersonOffset"), typeof(_setThirdPersonOffset));
         	}
         
         	 _setThirdPersonOffsetFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getThirdPersonOffset(IntPtr thisPtr, int argc, string[] argv);
         private static _getThirdPersonOffset _getThirdPersonOffsetFunc;
         internal static IntPtr getThirdPersonOffset(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getThirdPersonOffsetFunc == null)
         	{
         		_getThirdPersonOffsetFunc =
         			(_getThirdPersonOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_getThirdPersonOffset"), typeof(_getThirdPersonOffset));
         	}
         
         	return  _getThirdPersonOffsetFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getThirdPersonCOIOffset(IntPtr thisPtr, int argc, string[] argv);
         private static _getThirdPersonCOIOffset _getThirdPersonCOIOffsetFunc;
         internal static IntPtr getThirdPersonCOIOffset(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getThirdPersonCOIOffsetFunc == null)
         	{
         		_getThirdPersonCOIOffsetFunc =
         			(_getThirdPersonCOIOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_getThirdPersonCOIOffset"), typeof(_getThirdPersonCOIOffset));
         	}
         
         	return  _getThirdPersonCOIOffsetFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setThirdPersonMode(IntPtr thisPtr, int argc, string[] argv);
         private static _setThirdPersonMode _setThirdPersonModeFunc;
         internal static void setThirdPersonMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setThirdPersonModeFunc == null)
         	{
         		_setThirdPersonModeFunc =
         			(_setThirdPersonMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setThirdPersonMode"), typeof(_setThirdPersonMode));
         	}
         
         	 _setThirdPersonModeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setThirdPersonSnap(IntPtr thisPtr, int argc, string[] argv);
         private static _setThirdPersonSnap _setThirdPersonSnapFunc;
         internal static void setThirdPersonSnap(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setThirdPersonSnapFunc == null)
         	{
         		_setThirdPersonSnapFunc =
         			(_setThirdPersonSnap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_setThirdPersonSnap"), typeof(_setThirdPersonSnap));
         	}
         
         	 _setThirdPersonSnapFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMode(IntPtr thisPtr, int argc, string[] argv);
         private static _getMode _getModeFunc;
         internal static IntPtr getMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _afxCamera_create();
         private static _afxCamera_create _afxCamera_createFunc;
         internal static IntPtr afxCamera_create()
         {
         	if (_afxCamera_createFunc == null)
         	{
         		_afxCamera_createFunc =
         			(_afxCamera_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_afxCamera_create"), typeof(_afxCamera_create));
         	}
         
         	return  _afxCamera_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setOrbitMode(GameBase orbitObject, TransformF mat, float minDistance, float maxDistance, float curDistance, bool ownClientObject)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(orbitObject.getId().ToString());
                  tmp_arg_list.Add(mat.ToString());
                  tmp_arg_list.Add(minDistance.ToString());
                  tmp_arg_list.Add(maxDistance.ToString());
                  tmp_arg_list.Add(curDistance.ToString());
                  tmp_arg_list.Add(ownClientObject.ToString());
                  InternalUnsafeMethods.setOrbitMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setFlyMode()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setFlyMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual string getPosition()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getPosition(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual bool setCameraSubject()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.setCameraSubject(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool setThirdPersonDistance()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.setThirdPersonDistance(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual float getThirdPersonDistance()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.getThirdPersonDistance(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool setThirdPersonAngle()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.setThirdPersonAngle(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual float getThirdPersonAngle()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.getThirdPersonAngle(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setThirdPersonOffset(Point3F offset, Point3F coi_offset)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(offset.ToString());
                  tmp_arg_list.Add(coi_offset.ToString());
                  InternalUnsafeMethods.setThirdPersonOffset(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual string getThirdPersonOffset()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getThirdPersonOffset(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual string getThirdPersonCOIOffset()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getThirdPersonCOIOffset(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual void setThirdPersonMode()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setThirdPersonMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setThirdPersonSnap()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setThirdPersonSnap(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual string getMode()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}