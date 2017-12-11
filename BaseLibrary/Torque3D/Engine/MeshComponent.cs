using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MeshComponent : Component
	{
		public MeshComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MeshComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MeshComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MeshComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MeshComponent(SimObject pObj) : base(pObj)
		{
		}

		public MeshComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MeshComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalBox3FStruct _getShapeBounds(IntPtr thisPtr);
         private static _getShapeBounds _getShapeBoundsFunc;
         internal static InternalBox3FStruct getShapeBounds(IntPtr thisPtr)
         {
         	if (_getShapeBoundsFunc == null)
         	{
         		_getShapeBoundsFunc =
         			(_getShapeBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_getShapeBounds"), typeof(_getShapeBounds));
         	}
         
         	return  _getShapeBoundsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mountObject(IntPtr thisPtr, IntPtr objB, [MarshalAs(UnmanagedType.LPWStr)]string node, InternalTransformFStruct txfm);
         private static _mountObject _mountObjectFunc;
         internal static bool mountObject(IntPtr thisPtr, IntPtr objB, [MarshalAs(UnmanagedType.LPWStr)]string node, InternalTransformFStruct txfm)
         {
         	if (_mountObjectFunc == null)
         	{
         		_mountObjectFunc =
         			(_mountObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_mountObject"), typeof(_mountObject));
         	}
         
         	return  _mountObjectFunc(thisPtr, objB, node, txfm);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getNodeTransform(IntPtr thisPtr, int node);
         private static _getNodeTransform _getNodeTransformFunc;
         internal static InternalTransformFStruct getNodeTransform(IntPtr thisPtr, int node)
         {
         	if (_getNodeTransformFunc == null)
         	{
         		_getNodeTransformFunc =
         			(_getNodeTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_getNodeTransform"), typeof(_getNodeTransform));
         	}
         
         	return  _getNodeTransformFunc(thisPtr, node);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getNodeEulerRot(IntPtr thisPtr, int node, bool radToDeg);
         private static _getNodeEulerRot _getNodeEulerRotFunc;
         internal static InternalPoint3FStruct getNodeEulerRot(IntPtr thisPtr, int node, bool radToDeg)
         {
         	if (_getNodeEulerRotFunc == null)
         	{
         		_getNodeEulerRotFunc =
         			(_getNodeEulerRot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_getNodeEulerRot"), typeof(_getNodeEulerRot));
         	}
         
         	return  _getNodeEulerRotFunc(thisPtr, node, radToDeg);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getNodePosition(IntPtr thisPtr, int node);
         private static _getNodePosition _getNodePositionFunc;
         internal static InternalPoint3FStruct getNodePosition(IntPtr thisPtr, int node)
         {
         	if (_getNodePositionFunc == null)
         	{
         		_getNodePositionFunc =
         			(_getNodePosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_getNodePosition"), typeof(_getNodePosition));
         	}
         
         	return  _getNodePositionFunc(thisPtr, node);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNodeByName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string nodeName);
         private static _getNodeByName _getNodeByNameFunc;
         internal static int getNodeByName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string nodeName)
         {
         	if (_getNodeByNameFunc == null)
         	{
         		_getNodeByNameFunc =
         			(_getNodeByName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_getNodeByName"), typeof(_getNodeByName));
         	}
         
         	return  _getNodeByNameFunc(thisPtr, nodeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _changeMaterial(IntPtr thisPtr, uint slot, [MarshalAs(UnmanagedType.LPWStr)]string newMat);
         private static _changeMaterial _changeMaterialFunc;
         internal static void changeMaterial(IntPtr thisPtr, uint slot, [MarshalAs(UnmanagedType.LPWStr)]string newMat)
         {
         	if (_changeMaterialFunc == null)
         	{
         		_changeMaterialFunc =
         			(_changeMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_changeMaterial"), typeof(_changeMaterial));
         	}
         
         	 _changeMaterialFunc(thisPtr, slot, newMat);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MeshComponent_create();
         private static _MeshComponent_create _MeshComponent_createFunc;
         internal static IntPtr MeshComponent_create()
         {
         	if (_MeshComponent_createFunc == null)
         	{
         		_MeshComponent_createFunc =
         			(_MeshComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshComponent_create"), typeof(_MeshComponent_create));
         	}
         
         	return  _MeshComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual Box3F getShapeBounds()
         {
            return new Box3F(InternalUnsafeMethods.getShapeBounds(ObjectPtr));
         }
      
         public virtual bool mountObject(SceneObject objB, string node, TransformF txfm = null)
         {
            if (txfm == null) txfm = TransformF.Identity;
                  return InternalUnsafeMethods.mountObject(ObjectPtr, objB.ObjectPtr, node, txfm.ToStruct());
         }
      
         public virtual TransformF getNodeTransform(int node = -1)
         {
            return new TransformF(InternalUnsafeMethods.getNodeTransform(ObjectPtr, node));
         }
      
         public virtual EulerF getNodeEulerRot(int node = -1, bool radToDeg = true)
         {
            return new EulerF(InternalUnsafeMethods.getNodeEulerRot(ObjectPtr, node, radToDeg));
         }
      
         public virtual Point3F getNodePosition(int node = -1)
         {
            return new Point3F(InternalUnsafeMethods.getNodePosition(ObjectPtr, node));
         }
      
         public virtual int getNodeByName(string nodeName)
         {
            return InternalUnsafeMethods.getNodeByName(ObjectPtr, nodeName);
         }
      
         public virtual void changeMaterial(uint slot = 0, string newMat = "")
         {
            if (newMat == null) newMat = "";
                  InternalUnsafeMethods.changeMaterial(ObjectPtr, slot, newMat);
         }
      
      
      #endregion


      #region Properties
      
      
         public string MeshAsset
         {
         	get { return getFieldValue("MeshAsset"); }
         	set { setFieldValue("MeshAsset", value); }
         }
      
      
      #endregion

	}
}