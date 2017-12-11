using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GameConnection : NetConnection
	{
		public GameConnection(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GameConnection(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GameConnection(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GameConnection(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GameConnection(SimObject pObj) : base(pObj)
		{
		}

		public GameConnection(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GameConnection_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setJoinPassword(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string password);
         private static _setJoinPassword _setJoinPasswordFunc;
         internal static void setJoinPassword(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string password)
         {
         	if (_setJoinPasswordFunc == null)
         	{
         		_setJoinPasswordFunc =
         			(_setJoinPassword)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setJoinPassword"), typeof(_setJoinPassword));
         	}
         
         	 _setJoinPasswordFunc(thisPtr, password);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setConnectArgs(IntPtr thisPtr, int argc, string[] argv);
         private static _setConnectArgs _setConnectArgsFunc;
         internal static void setConnectArgs(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setConnectArgsFunc == null)
         	{
         		_setConnectArgsFunc =
         			(_setConnectArgs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setConnectArgs"), typeof(_setConnectArgs));
         	}
         
         	 _setConnectArgsFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _transmitDataBlocks(IntPtr thisPtr, int sequence);
         private static _transmitDataBlocks _transmitDataBlocksFunc;
         internal static void transmitDataBlocks(IntPtr thisPtr, int sequence)
         {
         	if (_transmitDataBlocksFunc == null)
         	{
         		_transmitDataBlocksFunc =
         			(_transmitDataBlocks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_transmitDataBlocks"), typeof(_transmitDataBlocks));
         	}
         
         	 _transmitDataBlocksFunc(thisPtr, sequence);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activateGhosting(IntPtr thisPtr);
         private static _activateGhosting _activateGhostingFunc;
         internal static void activateGhosting(IntPtr thisPtr)
         {
         	if (_activateGhostingFunc == null)
         	{
         		_activateGhostingFunc =
         			(_activateGhosting)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_activateGhosting"), typeof(_activateGhosting));
         	}
         
         	 _activateGhostingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetGhosting(IntPtr thisPtr);
         private static _resetGhosting _resetGhostingFunc;
         internal static void resetGhosting(IntPtr thisPtr)
         {
         	if (_resetGhostingFunc == null)
         	{
         		_resetGhostingFunc =
         			(_resetGhosting)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_resetGhosting"), typeof(_resetGhosting));
         	}
         
         	 _resetGhostingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setControlObject(IntPtr thisPtr, IntPtr ctrlObj);
         private static _setControlObject _setControlObjectFunc;
         internal static bool setControlObject(IntPtr thisPtr, IntPtr ctrlObj)
         {
         	if (_setControlObjectFunc == null)
         	{
         		_setControlObjectFunc =
         			(_setControlObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setControlObject"), typeof(_setControlObject));
         	}
         
         	return  _setControlObjectFunc(thisPtr, ctrlObj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearDisplayDevice(IntPtr thisPtr);
         private static _clearDisplayDevice _clearDisplayDeviceFunc;
         internal static void clearDisplayDevice(IntPtr thisPtr)
         {
         	if (_clearDisplayDeviceFunc == null)
         	{
         		_clearDisplayDeviceFunc =
         			(_clearDisplayDevice)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_clearDisplayDevice"), typeof(_clearDisplayDevice));
         	}
         
         	 _clearDisplayDeviceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getControlObject(IntPtr thisPtr);
         private static _getControlObject _getControlObjectFunc;
         internal static IntPtr getControlObject(IntPtr thisPtr)
         {
         	if (_getControlObjectFunc == null)
         	{
         		_getControlObjectFunc =
         			(_getControlObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getControlObject"), typeof(_getControlObject));
         	}
         
         	return  _getControlObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAIControlled(IntPtr thisPtr);
         private static _isAIControlled _isAIControlledFunc;
         internal static bool isAIControlled(IntPtr thisPtr)
         {
         	if (_isAIControlledFunc == null)
         	{
         		_isAIControlledFunc =
         			(_isAIControlled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_isAIControlled"), typeof(_isAIControlled));
         	}
         
         	return  _isAIControlledFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isControlObjectRotDampedCamera(IntPtr thisPtr);
         private static _isControlObjectRotDampedCamera _isControlObjectRotDampedCameraFunc;
         internal static bool isControlObjectRotDampedCamera(IntPtr thisPtr)
         {
         	if (_isControlObjectRotDampedCameraFunc == null)
         	{
         		_isControlObjectRotDampedCameraFunc =
         			(_isControlObjectRotDampedCamera)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_isControlObjectRotDampedCamera"), typeof(_isControlObjectRotDampedCamera));
         	}
         
         	return  _isControlObjectRotDampedCameraFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _play2D(IntPtr thisPtr, IntPtr profile);
         private static _play2D _play2DFunc;
         internal static bool play2D(IntPtr thisPtr, IntPtr profile)
         {
         	if (_play2DFunc == null)
         	{
         		_play2DFunc =
         			(_play2D)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_play2D"), typeof(_play2D));
         	}
         
         	return  _play2DFunc(thisPtr, profile);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _play3D(IntPtr thisPtr, IntPtr profile, InternalTransformFStruct location);
         private static _play3D _play3DFunc;
         internal static bool play3D(IntPtr thisPtr, IntPtr profile, InternalTransformFStruct location)
         {
         	if (_play3DFunc == null)
         	{
         		_play3DFunc =
         			(_play3D)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_play3D"), typeof(_play3D));
         	}
         
         	return  _play3DFunc(thisPtr, profile, location);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _chaseCam(IntPtr thisPtr, int size);
         private static _chaseCam _chaseCamFunc;
         internal static bool chaseCam(IntPtr thisPtr, int size)
         {
         	if (_chaseCamFunc == null)
         	{
         		_chaseCamFunc =
         			(_chaseCam)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_chaseCam"), typeof(_chaseCam));
         	}
         
         	return  _chaseCamFunc(thisPtr, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getControlCameraDefaultFov(IntPtr thisPtr);
         private static _getControlCameraDefaultFov _getControlCameraDefaultFovFunc;
         internal static float getControlCameraDefaultFov(IntPtr thisPtr)
         {
         	if (_getControlCameraDefaultFovFunc == null)
         	{
         		_getControlCameraDefaultFovFunc =
         			(_getControlCameraDefaultFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getControlCameraDefaultFov"), typeof(_getControlCameraDefaultFov));
         	}
         
         	return  _getControlCameraDefaultFovFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setControlCameraFov(IntPtr thisPtr, float newFOV);
         private static _setControlCameraFov _setControlCameraFovFunc;
         internal static void setControlCameraFov(IntPtr thisPtr, float newFOV)
         {
         	if (_setControlCameraFovFunc == null)
         	{
         		_setControlCameraFovFunc =
         			(_setControlCameraFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setControlCameraFov"), typeof(_setControlCameraFov));
         	}
         
         	 _setControlCameraFovFunc(thisPtr, newFOV);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getControlCameraFov(IntPtr thisPtr);
         private static _getControlCameraFov _getControlCameraFovFunc;
         internal static float getControlCameraFov(IntPtr thisPtr)
         {
         	if (_getControlCameraFovFunc == null)
         	{
         		_getControlCameraFovFunc =
         			(_getControlCameraFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getControlCameraFov"), typeof(_getControlCameraFov));
         	}
         
         	return  _getControlCameraFovFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDamageFlash(IntPtr thisPtr);
         private static _getDamageFlash _getDamageFlashFunc;
         internal static float getDamageFlash(IntPtr thisPtr)
         {
         	if (_getDamageFlashFunc == null)
         	{
         		_getDamageFlashFunc =
         			(_getDamageFlash)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getDamageFlash"), typeof(_getDamageFlash));
         	}
         
         	return  _getDamageFlashFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getWhiteOut(IntPtr thisPtr);
         private static _getWhiteOut _getWhiteOutFunc;
         internal static float getWhiteOut(IntPtr thisPtr)
         {
         	if (_getWhiteOutFunc == null)
         	{
         		_getWhiteOutFunc =
         			(_getWhiteOut)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getWhiteOut"), typeof(_getWhiteOut));
         	}
         
         	return  _getWhiteOutFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBlackOut(IntPtr thisPtr, bool doFade, int timeMS);
         private static _setBlackOut _setBlackOutFunc;
         internal static void setBlackOut(IntPtr thisPtr, bool doFade, int timeMS)
         {
         	if (_setBlackOutFunc == null)
         	{
         		_setBlackOutFunc =
         			(_setBlackOut)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setBlackOut"), typeof(_setBlackOut));
         	}
         
         	 _setBlackOutFunc(thisPtr, doFade, timeMS);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMissionCRC(IntPtr thisPtr, int CRC);
         private static _setMissionCRC _setMissionCRCFunc;
         internal static void setMissionCRC(IntPtr thisPtr, int CRC)
         {
         	if (_setMissionCRCFunc == null)
         	{
         		_setMissionCRCFunc =
         			(_setMissionCRC)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setMissionCRC"), typeof(_setMissionCRC));
         	}
         
         	 _setMissionCRCFunc(thisPtr, CRC);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _delete(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string reason);
         private static _delete _deleteFunc;
         internal static void delete(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string reason)
         {
         	if (_deleteFunc == null)
         	{
         		_deleteFunc =
         			(_delete)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_delete"), typeof(_delete));
         	}
         
         	 _deleteFunc(thisPtr, reason);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startRecording(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _startRecording _startRecordingFunc;
         internal static void startRecording(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_startRecordingFunc == null)
         	{
         		_startRecordingFunc =
         			(_startRecording)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_startRecording"), typeof(_startRecording));
         	}
         
         	 _startRecordingFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopRecording(IntPtr thisPtr);
         private static _stopRecording _stopRecordingFunc;
         internal static void stopRecording(IntPtr thisPtr)
         {
         	if (_stopRecordingFunc == null)
         	{
         		_stopRecordingFunc =
         			(_stopRecording)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_stopRecording"), typeof(_stopRecording));
         	}
         
         	 _stopRecordingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _playDemo(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string demoFileName);
         private static _playDemo _playDemoFunc;
         internal static bool playDemo(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string demoFileName)
         {
         	if (_playDemoFunc == null)
         	{
         		_playDemoFunc =
         			(_playDemo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_playDemo"), typeof(_playDemo));
         	}
         
         	return  _playDemoFunc(thisPtr, demoFileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDemoPlaying(IntPtr thisPtr);
         private static _isDemoPlaying _isDemoPlayingFunc;
         internal static bool isDemoPlaying(IntPtr thisPtr)
         {
         	if (_isDemoPlayingFunc == null)
         	{
         		_isDemoPlayingFunc =
         			(_isDemoPlaying)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_isDemoPlaying"), typeof(_isDemoPlaying));
         	}
         
         	return  _isDemoPlayingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDemoRecording(IntPtr thisPtr);
         private static _isDemoRecording _isDemoRecordingFunc;
         internal static bool isDemoRecording(IntPtr thisPtr)
         {
         	if (_isDemoRecordingFunc == null)
         	{
         		_isDemoRecordingFunc =
         			(_isDemoRecording)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_isDemoRecording"), typeof(_isDemoRecording));
         	}
         
         	return  _isDemoRecordingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _listClassIDs(IntPtr thisPtr);
         private static _listClassIDs _listClassIDsFunc;
         internal static void listClassIDs(IntPtr thisPtr)
         {
         	if (_listClassIDsFunc == null)
         	{
         		_listClassIDsFunc =
         			(_listClassIDs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_listClassIDs"), typeof(_listClassIDs));
         	}
         
         	 _listClassIDsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getServerConnection(IntPtr thisPtr);
         private static _getServerConnection _getServerConnectionFunc;
         internal static int getServerConnection(IntPtr thisPtr)
         {
         	if (_getServerConnectionFunc == null)
         	{
         		_getServerConnectionFunc =
         			(_getServerConnection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getServerConnection"), typeof(_getServerConnection));
         	}
         
         	return  _getServerConnectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setCameraObject(IntPtr thisPtr, IntPtr camera);
         private static _setCameraObject _setCameraObjectFunc;
         internal static bool setCameraObject(IntPtr thisPtr, IntPtr camera)
         {
         	if (_setCameraObjectFunc == null)
         	{
         		_setCameraObjectFunc =
         			(_setCameraObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setCameraObject"), typeof(_setCameraObject));
         	}
         
         	return  _setCameraObjectFunc(thisPtr, camera);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCameraObject(IntPtr thisPtr);
         private static _getCameraObject _getCameraObjectFunc;
         internal static IntPtr getCameraObject(IntPtr thisPtr)
         {
         	if (_getCameraObjectFunc == null)
         	{
         		_getCameraObjectFunc =
         			(_getCameraObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getCameraObject"), typeof(_getCameraObject));
         	}
         
         	return  _getCameraObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearCameraObject(IntPtr thisPtr);
         private static _clearCameraObject _clearCameraObjectFunc;
         internal static void clearCameraObject(IntPtr thisPtr)
         {
         	if (_clearCameraObjectFunc == null)
         	{
         		_clearCameraObjectFunc =
         			(_clearCameraObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_clearCameraObject"), typeof(_clearCameraObject));
         	}
         
         	 _clearCameraObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFirstPerson(IntPtr thisPtr);
         private static _isFirstPerson _isFirstPersonFunc;
         internal static bool isFirstPerson(IntPtr thisPtr)
         {
         	if (_isFirstPersonFunc == null)
         	{
         		_isFirstPersonFunc =
         			(_isFirstPerson)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_isFirstPerson"), typeof(_isFirstPerson));
         	}
         
         	return  _isFirstPersonFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFirstPerson(IntPtr thisPtr, bool firstPerson);
         private static _setFirstPerson _setFirstPersonFunc;
         internal static void setFirstPerson(IntPtr thisPtr, bool firstPerson)
         {
         	if (_setFirstPersonFunc == null)
         	{
         		_setFirstPersonFunc =
         			(_setFirstPerson)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setFirstPerson"), typeof(_setFirstPerson));
         	}
         
         	 _setFirstPersonFunc(thisPtr, firstPerson);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setControlSchemeParameters(IntPtr thisPtr, bool absoluteRotation, bool addYawToAbsRot, bool addPitchToAbsRot);
         private static _setControlSchemeParameters _setControlSchemeParametersFunc;
         internal static void setControlSchemeParameters(IntPtr thisPtr, bool absoluteRotation, bool addYawToAbsRot, bool addPitchToAbsRot)
         {
         	if (_setControlSchemeParametersFunc == null)
         	{
         		_setControlSchemeParametersFunc =
         			(_setControlSchemeParameters)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setControlSchemeParameters"), typeof(_setControlSchemeParameters));
         	}
         
         	 _setControlSchemeParametersFunc(thisPtr, absoluteRotation, addYawToAbsRot, addPitchToAbsRot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getControlSchemeAbsoluteRotation(IntPtr thisPtr);
         private static _getControlSchemeAbsoluteRotation _getControlSchemeAbsoluteRotationFunc;
         internal static bool getControlSchemeAbsoluteRotation(IntPtr thisPtr)
         {
         	if (_getControlSchemeAbsoluteRotationFunc == null)
         	{
         		_getControlSchemeAbsoluteRotationFunc =
         			(_getControlSchemeAbsoluteRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getControlSchemeAbsoluteRotation"), typeof(_getControlSchemeAbsoluteRotation));
         	}
         
         	return  _getControlSchemeAbsoluteRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setVisibleGhostDistance(IntPtr thisPtr, float dist);
         private static _setVisibleGhostDistance _setVisibleGhostDistanceFunc;
         internal static void setVisibleGhostDistance(IntPtr thisPtr, float dist)
         {
         	if (_setVisibleGhostDistanceFunc == null)
         	{
         		_setVisibleGhostDistanceFunc =
         			(_setVisibleGhostDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setVisibleGhostDistance"), typeof(_setVisibleGhostDistance));
         	}
         
         	 _setVisibleGhostDistanceFunc(thisPtr, dist);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getVisibleGhostDistance(IntPtr thisPtr);
         private static _getVisibleGhostDistance _getVisibleGhostDistanceFunc;
         internal static float getVisibleGhostDistance(IntPtr thisPtr)
         {
         	if (_getVisibleGhostDistanceFunc == null)
         	{
         		_getVisibleGhostDistanceFunc =
         			(_getVisibleGhostDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getVisibleGhostDistance"), typeof(_getVisibleGhostDistance));
         	}
         
         	return  _getVisibleGhostDistanceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setSelectedObj(IntPtr thisPtr, int argc, string[] argv);
         private static _setSelectedObj _setSelectedObjFunc;
         internal static bool setSelectedObj(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setSelectedObjFunc == null)
         	{
         		_setSelectedObjFunc =
         			(_setSelectedObj)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setSelectedObj"), typeof(_setSelectedObj));
         	}
         
         	return  _setSelectedObjFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedObj(IntPtr thisPtr, int argc, string[] argv);
         private static _getSelectedObj _getSelectedObjFunc;
         internal static int getSelectedObj(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getSelectedObjFunc == null)
         	{
         		_getSelectedObjFunc =
         			(_getSelectedObj)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_getSelectedObj"), typeof(_getSelectedObj));
         	}
         
         	return  _getSelectedObjFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearSelectedObj(IntPtr thisPtr, int argc, string[] argv);
         private static _clearSelectedObj _clearSelectedObjFunc;
         internal static void clearSelectedObj(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_clearSelectedObjFunc == null)
         	{
         		_clearSelectedObjFunc =
         			(_clearSelectedObj)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_clearSelectedObj"), typeof(_clearSelectedObj));
         	}
         
         	 _clearSelectedObjFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPreSelectedObjFromRollover(IntPtr thisPtr, int argc, string[] argv);
         private static _setPreSelectedObjFromRollover _setPreSelectedObjFromRolloverFunc;
         internal static void setPreSelectedObjFromRollover(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setPreSelectedObjFromRolloverFunc == null)
         	{
         		_setPreSelectedObjFromRolloverFunc =
         			(_setPreSelectedObjFromRollover)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setPreSelectedObjFromRollover"), typeof(_setPreSelectedObjFromRollover));
         	}
         
         	 _setPreSelectedObjFromRolloverFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearPreSelectedObj(IntPtr thisPtr, int argc, string[] argv);
         private static _clearPreSelectedObj _clearPreSelectedObjFunc;
         internal static void clearPreSelectedObj(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_clearPreSelectedObjFunc == null)
         	{
         		_clearPreSelectedObjFunc =
         			(_clearPreSelectedObj)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_clearPreSelectedObj"), typeof(_clearPreSelectedObj));
         	}
         
         	 _clearPreSelectedObjFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedObjFromPreSelected(IntPtr thisPtr, int argc, string[] argv);
         private static _setSelectedObjFromPreSelected _setSelectedObjFromPreSelectedFunc;
         internal static void setSelectedObjFromPreSelected(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setSelectedObjFromPreSelectedFunc == null)
         	{
         		_setSelectedObjFromPreSelectedFunc =
         			(_setSelectedObjFromPreSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_setSelectedObjFromPreSelected"), typeof(_setSelectedObjFromPreSelected));
         	}
         
         	 _setSelectedObjFromPreSelectedFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _saveDatablockCache(IntPtr thisPtr, int argc, string[] argv);
         private static _saveDatablockCache _saveDatablockCacheFunc;
         internal static void saveDatablockCache(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_saveDatablockCacheFunc == null)
         	{
         		_saveDatablockCacheFunc =
         			(_saveDatablockCache)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_saveDatablockCache"), typeof(_saveDatablockCache));
         	}
         
         	 _saveDatablockCacheFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _loadDatablockCache(IntPtr thisPtr, int argc, string[] argv);
         private static _loadDatablockCache _loadDatablockCacheFunc;
         internal static void loadDatablockCache(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_loadDatablockCacheFunc == null)
         	{
         		_loadDatablockCacheFunc =
         			(_loadDatablockCache)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_loadDatablockCache"), typeof(_loadDatablockCache));
         	}
         
         	 _loadDatablockCacheFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _loadDatablockCache_Begin(IntPtr thisPtr, int argc, string[] argv);
         private static _loadDatablockCache_Begin _loadDatablockCache_BeginFunc;
         internal static bool loadDatablockCache_Begin(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_loadDatablockCache_BeginFunc == null)
         	{
         		_loadDatablockCache_BeginFunc =
         			(_loadDatablockCache_Begin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_loadDatablockCache_Begin"), typeof(_loadDatablockCache_Begin));
         	}
         
         	return  _loadDatablockCache_BeginFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _loadDatablockCache_Continue(IntPtr thisPtr, int argc, string[] argv);
         private static _loadDatablockCache_Continue _loadDatablockCache_ContinueFunc;
         internal static bool loadDatablockCache_Continue(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_loadDatablockCache_ContinueFunc == null)
         	{
         		_loadDatablockCache_ContinueFunc =
         			(_loadDatablockCache_Continue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_loadDatablockCache_Continue"), typeof(_loadDatablockCache_Continue));
         	}
         
         	return  _loadDatablockCache_ContinueFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameConnection_create();
         private static _GameConnection_create _GameConnection_createFunc;
         internal static IntPtr GameConnection_create()
         {
         	if (_GameConnection_createFunc == null)
         	{
         		_GameConnection_createFunc =
         			(_GameConnection_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameConnection_create"), typeof(_GameConnection_create));
         	}
         
         	return  _GameConnection_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setJoinPassword(string password)
         {
            InternalUnsafeMethods.setJoinPassword(ObjectPtr, password);
         }
      
         public virtual void setConnectArgs(string args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(args.ToString());
                  InternalUnsafeMethods.setConnectArgs(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void transmitDataBlocks(int sequence)
         {
            InternalUnsafeMethods.transmitDataBlocks(ObjectPtr, sequence);
         }
      
         public virtual void activateGhosting()
         {
            InternalUnsafeMethods.activateGhosting(ObjectPtr);
         }
      
         public virtual void resetGhosting()
         {
            InternalUnsafeMethods.resetGhosting(ObjectPtr);
         }
      
         public virtual bool setControlObject(GameBase ctrlObj)
         {
            return InternalUnsafeMethods.setControlObject(ObjectPtr, ctrlObj.ObjectPtr);
         }
      
         public virtual void clearDisplayDevice()
         {
            InternalUnsafeMethods.clearDisplayDevice(ObjectPtr);
         }
      
         public virtual GameBase getControlObject()
         {
            return new GameBase(InternalUnsafeMethods.getControlObject(ObjectPtr));
         }
      
         public virtual bool isAIControlled()
         {
            return InternalUnsafeMethods.isAIControlled(ObjectPtr);
         }
      
         public virtual bool isControlObjectRotDampedCamera()
         {
            return InternalUnsafeMethods.isControlObjectRotDampedCamera(ObjectPtr);
         }
      
         public virtual bool play2D(SFXProfile profile)
         {
            return InternalUnsafeMethods.play2D(ObjectPtr, profile.ObjectPtr);
         }
      
         public virtual bool play3D(SFXProfile profile, TransformF location)
         {
            return InternalUnsafeMethods.play3D(ObjectPtr, profile.ObjectPtr, location.ToStruct());
         }
      
         public virtual bool chaseCam(int size)
         {
            return InternalUnsafeMethods.chaseCam(ObjectPtr, size);
         }
      
         public virtual float getControlCameraDefaultFov()
         {
            return InternalUnsafeMethods.getControlCameraDefaultFov(ObjectPtr);
         }
      
         public virtual void setControlCameraFov(float newFOV)
         {
            InternalUnsafeMethods.setControlCameraFov(ObjectPtr, newFOV);
         }
      
         public virtual float getControlCameraFov()
         {
            return InternalUnsafeMethods.getControlCameraFov(ObjectPtr);
         }
      
         public virtual float getDamageFlash()
         {
            return InternalUnsafeMethods.getDamageFlash(ObjectPtr);
         }
      
         public virtual float getWhiteOut()
         {
            return InternalUnsafeMethods.getWhiteOut(ObjectPtr);
         }
      
         public virtual void setBlackOut(bool doFade, int timeMS)
         {
            InternalUnsafeMethods.setBlackOut(ObjectPtr, doFade, timeMS);
         }
      
         public virtual void setMissionCRC(int CRC)
         {
            InternalUnsafeMethods.setMissionCRC(ObjectPtr, CRC);
         }
      
         public virtual void delete(string reason = "")
         {
            if (reason == null) reason = "";
                  InternalUnsafeMethods.delete(ObjectPtr, reason);
         }
      
         public virtual void startRecording(string fileName)
         {
            InternalUnsafeMethods.startRecording(ObjectPtr, fileName);
         }
      
         public virtual void stopRecording()
         {
            InternalUnsafeMethods.stopRecording(ObjectPtr);
         }
      
         public virtual bool playDemo(string demoFileName)
         {
            return InternalUnsafeMethods.playDemo(ObjectPtr, demoFileName);
         }
      
         public virtual bool isDemoPlaying()
         {
            return InternalUnsafeMethods.isDemoPlaying(ObjectPtr);
         }
      
         public virtual bool isDemoRecording()
         {
            return InternalUnsafeMethods.isDemoRecording(ObjectPtr);
         }
      
         public virtual void listClassIDs()
         {
            InternalUnsafeMethods.listClassIDs(ObjectPtr);
         }
      
         public virtual int getServerConnection()
         {
            return InternalUnsafeMethods.getServerConnection(ObjectPtr);
         }
      
         public virtual bool setCameraObject(GameBase camera)
         {
            return InternalUnsafeMethods.setCameraObject(ObjectPtr, camera.ObjectPtr);
         }
      
         public virtual SimObject getCameraObject()
         {
            return new SimObject(InternalUnsafeMethods.getCameraObject(ObjectPtr));
         }
      
         public virtual void clearCameraObject()
         {
            InternalUnsafeMethods.clearCameraObject(ObjectPtr);
         }
      
         public virtual bool isFirstPerson()
         {
            return InternalUnsafeMethods.isFirstPerson(ObjectPtr);
         }
      
         public virtual void setFirstPerson(bool firstPerson)
         {
            InternalUnsafeMethods.setFirstPerson(ObjectPtr, firstPerson);
         }
      
         public virtual void setControlSchemeParameters(bool absoluteRotation, bool addYawToAbsRot, bool addPitchToAbsRot)
         {
            InternalUnsafeMethods.setControlSchemeParameters(ObjectPtr, absoluteRotation, addYawToAbsRot, addPitchToAbsRot);
         }
      
         public virtual bool getControlSchemeAbsoluteRotation()
         {
            return InternalUnsafeMethods.getControlSchemeAbsoluteRotation(ObjectPtr);
         }
      
         public virtual void setVisibleGhostDistance(float dist)
         {
            InternalUnsafeMethods.setVisibleGhostDistance(ObjectPtr, dist);
         }
      
         public virtual float getVisibleGhostDistance()
         {
            return InternalUnsafeMethods.getVisibleGhostDistance(ObjectPtr);
         }
      
         public virtual bool setSelectedObj()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.setSelectedObj(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual int getSelectedObj()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.getSelectedObj(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void clearSelectedObj()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.clearSelectedObj(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setPreSelectedObjFromRollover()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setPreSelectedObjFromRollover(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void clearPreSelectedObj()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.clearPreSelectedObj(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void setSelectedObjFromPreSelected()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setSelectedObjFromPreSelected(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void saveDatablockCache()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.saveDatablockCache(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void loadDatablockCache()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.loadDatablockCache(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool loadDatablockCache_Begin()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.loadDatablockCache_Begin(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool loadDatablockCache_Continue()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.loadDatablockCache_Continue(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}