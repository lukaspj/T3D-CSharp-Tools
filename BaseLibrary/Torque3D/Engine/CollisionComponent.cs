using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CollisionComponent : Component
	{
		public CollisionComponent(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CollisionComponent(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CollisionComponent(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CollisionComponent(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CollisionComponent(SimObject pObj) : base(pObj)
		{
		}

		public CollisionComponent(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CollisionComponent_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumberOfContacts(IntPtr thisPtr);
         private static _getNumberOfContacts _getNumberOfContactsFunc;
         internal static int getNumberOfContacts(IntPtr thisPtr)
         {
         	if (_getNumberOfContactsFunc == null)
         	{
         		_getNumberOfContactsFunc =
         			(_getNumberOfContacts)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getNumberOfContacts"), typeof(_getNumberOfContacts));
         	}
         
         	return  _getNumberOfContactsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getBestContact(IntPtr thisPtr);
         private static _getBestContact _getBestContactFunc;
         internal static int getBestContact(IntPtr thisPtr)
         {
         	if (_getBestContactFunc == null)
         	{
         		_getBestContactFunc =
         			(_getBestContact)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getBestContact"), typeof(_getBestContact));
         	}
         
         	return  _getBestContactFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getContactNormal(IntPtr thisPtr);
         private static _getContactNormal _getContactNormalFunc;
         internal static InternalPoint3FStruct getContactNormal(IntPtr thisPtr)
         {
         	if (_getContactNormalFunc == null)
         	{
         		_getContactNormalFunc =
         			(_getContactNormal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getContactNormal"), typeof(_getContactNormal));
         	}
         
         	return  _getContactNormalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getContactMaterial(IntPtr thisPtr);
         private static _getContactMaterial _getContactMaterialFunc;
         internal static int getContactMaterial(IntPtr thisPtr)
         {
         	if (_getContactMaterialFunc == null)
         	{
         		_getContactMaterialFunc =
         			(_getContactMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getContactMaterial"), typeof(_getContactMaterial));
         	}
         
         	return  _getContactMaterialFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getContactObject(IntPtr thisPtr);
         private static _getContactObject _getContactObjectFunc;
         internal static int getContactObject(IntPtr thisPtr)
         {
         	if (_getContactObjectFunc == null)
         	{
         		_getContactObjectFunc =
         			(_getContactObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getContactObject"), typeof(_getContactObject));
         	}
         
         	return  _getContactObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getContactPoint(IntPtr thisPtr);
         private static _getContactPoint _getContactPointFunc;
         internal static InternalPoint3FStruct getContactPoint(IntPtr thisPtr)
         {
         	if (_getContactPointFunc == null)
         	{
         		_getContactPointFunc =
         			(_getContactPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getContactPoint"), typeof(_getContactPoint));
         	}
         
         	return  _getContactPointFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getContactTime(IntPtr thisPtr);
         private static _getContactTime _getContactTimeFunc;
         internal static int getContactTime(IntPtr thisPtr)
         {
         	if (_getContactTimeFunc == null)
         	{
         		_getContactTimeFunc =
         			(_getContactTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getContactTime"), typeof(_getContactTime));
         	}
         
         	return  _getContactTimeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _hasContact(IntPtr thisPtr);
         private static _hasContact _hasContactFunc;
         internal static bool hasContact(IntPtr thisPtr)
         {
         	if (_hasContactFunc == null)
         	{
         		_hasContactFunc =
         			(_hasContact)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_hasContact"), typeof(_hasContact));
         	}
         
         	return  _hasContactFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCollisionCount(IntPtr thisPtr);
         private static _getCollisionCount _getCollisionCountFunc;
         internal static int getCollisionCount(IntPtr thisPtr)
         {
         	if (_getCollisionCountFunc == null)
         	{
         		_getCollisionCountFunc =
         			(_getCollisionCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getCollisionCount"), typeof(_getCollisionCount));
         	}
         
         	return  _getCollisionCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getCollisionNormal(IntPtr thisPtr, int collisionIndex);
         private static _getCollisionNormal _getCollisionNormalFunc;
         internal static InternalPoint3FStruct getCollisionNormal(IntPtr thisPtr, int collisionIndex)
         {
         	if (_getCollisionNormalFunc == null)
         	{
         		_getCollisionNormalFunc =
         			(_getCollisionNormal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getCollisionNormal"), typeof(_getCollisionNormal));
         	}
         
         	return  _getCollisionNormalFunc(thisPtr, collisionIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getCollisionAngle(IntPtr thisPtr, int collisionIndex, InternalPoint3FStruct upVector);
         private static _getCollisionAngle _getCollisionAngleFunc;
         internal static float getCollisionAngle(IntPtr thisPtr, int collisionIndex, InternalPoint3FStruct upVector)
         {
         	if (_getCollisionAngleFunc == null)
         	{
         		_getCollisionAngleFunc =
         			(_getCollisionAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getCollisionAngle"), typeof(_getCollisionAngle));
         	}
         
         	return  _getCollisionAngleFunc(thisPtr, collisionIndex, upVector);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getBestCollisionAngle(IntPtr thisPtr, InternalPoint3FStruct upVector);
         private static _getBestCollisionAngle _getBestCollisionAngleFunc;
         internal static float getBestCollisionAngle(IntPtr thisPtr, InternalPoint3FStruct upVector)
         {
         	if (_getBestCollisionAngleFunc == null)
         	{
         		_getBestCollisionAngleFunc =
         			(_getBestCollisionAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_getBestCollisionAngle"), typeof(_getBestCollisionAngle));
         	}
         
         	return  _getBestCollisionAngleFunc(thisPtr, upVector);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CollisionComponent_create();
         private static _CollisionComponent_create _CollisionComponent_createFunc;
         internal static IntPtr CollisionComponent_create()
         {
         	if (_CollisionComponent_createFunc == null)
         	{
         		_CollisionComponent_createFunc =
         			(_CollisionComponent_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CollisionComponent_create"), typeof(_CollisionComponent_create));
         	}
         
         	return  _CollisionComponent_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getNumberOfContacts()
         {
            return InternalUnsafeMethods.getNumberOfContacts(ObjectPtr);
         }
      
         public virtual int getBestContact()
         {
            return InternalUnsafeMethods.getBestContact(ObjectPtr);
         }
      
         public virtual Point3F getContactNormal()
         {
            return new Point3F(InternalUnsafeMethods.getContactNormal(ObjectPtr));
         }
      
         public virtual int getContactMaterial()
         {
            return InternalUnsafeMethods.getContactMaterial(ObjectPtr);
         }
      
         public virtual int getContactObject()
         {
            return InternalUnsafeMethods.getContactObject(ObjectPtr);
         }
      
         public virtual Point3F getContactPoint()
         {
            return new Point3F(InternalUnsafeMethods.getContactPoint(ObjectPtr));
         }
      
         public virtual int getContactTime()
         {
            return InternalUnsafeMethods.getContactTime(ObjectPtr);
         }
      
         public virtual bool hasContact()
         {
            return InternalUnsafeMethods.hasContact(ObjectPtr);
         }
      
         public virtual int getCollisionCount()
         {
            return InternalUnsafeMethods.getCollisionCount(ObjectPtr);
         }
      
         public virtual Point3F getCollisionNormal(int collisionIndex)
         {
            return new Point3F(InternalUnsafeMethods.getCollisionNormal(ObjectPtr, collisionIndex));
         }
      
         public virtual float getCollisionAngle(int collisionIndex, VectorF upVector)
         {
            return InternalUnsafeMethods.getCollisionAngle(ObjectPtr, collisionIndex, upVector.ToStruct());
         }
      
         public virtual float getBestCollisionAngle(VectorF upVector)
         {
            return InternalUnsafeMethods.getBestCollisionAngle(ObjectPtr, upVector.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
         public CollisionMeshMeshType CollisionType
         {
         	get { return (CollisionMeshMeshType)Enum.Parse(typeof(CollisionMeshMeshType), getFieldValue("CollisionType"), true); }
         	set { setFieldValue("CollisionType", value.ToString()); }
         }
      
         public CollisionMeshMeshType LineOfSightType
         {
         	get { return (CollisionMeshMeshType)Enum.Parse(typeof(CollisionMeshMeshType), getFieldValue("LineOfSightType"), true); }
         	set { setFieldValue("LineOfSightType", value.ToString()); }
         }
      
         public CollisionMeshMeshType DecalType
         {
         	get { return (CollisionMeshMeshType)Enum.Parse(typeof(CollisionMeshMeshType), getFieldValue("DecalType"), true); }
         	set { setFieldValue("DecalType", value.ToString()); }
         }
      
         public string CollisionMeshPrefix
         {
         	get { return getFieldValue("CollisionMeshPrefix"); }
         	set { setFieldValue("CollisionMeshPrefix", value); }
         }
      
         public bool BlockCollisions
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BlockCollisions")); }
         	set { setFieldValue("BlockCollisions", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}