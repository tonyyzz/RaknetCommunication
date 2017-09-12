/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class FileProgressStruct : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileProgressStruct(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FileProgressStruct obj) {

    if (obj != null)
    {
	if (obj.firstDataChunkIsCached)
        {
  	     	obj.SetFirstDataChunk(obj.firstDataChunk, obj.firstDataChunk.Length);
 	}
  	if (obj.iriDataChunkIsCached)
        {
		obj.SetIriDataChunk(obj.iriDataChunk, obj.iriDataChunk.Length);
	}
	obj.firstDataChunkIsCached=false;
	obj.iriDataChunkIsCached=false;
    }

    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileProgressStruct() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FileProgressStruct(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    private bool firstDataChunkIsCached = false;
    private byte[] firstDataChunkCache;
    private bool iriDataChunkIsCached = false;
    private byte[] iriDataChunkCache;

  public OnFileStruct onFileStruct {
    set {
      RakNetPINVOKE.FileProgressStruct_onFileStruct_set(swigCPtr, OnFileStruct.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_onFileStruct_get(swigCPtr);
      OnFileStruct ret = (cPtr == IntPtr.Zero) ? null : new OnFileStruct(cPtr, false);
      return ret;
    } 
  }

  public uint partCount {
    set {
      RakNetPINVOKE.FileProgressStruct_partCount_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.FileProgressStruct_partCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint partTotal {
    set {
      RakNetPINVOKE.FileProgressStruct_partTotal_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.FileProgressStruct_partTotal_get(swigCPtr);
      return ret;
    } 
  }

  public uint dataChunkLength {
    set {
      RakNetPINVOKE.FileProgressStruct_dataChunkLength_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.FileProgressStruct_dataChunkLength_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] firstDataChunk {
	set 
	{
	    	firstDataChunkCache=value;
		firstDataChunkIsCached = true;
		SetFirstDataChunk (value, value.Length);    
	}

        get
        {
            byte[] returnArray;
            if (!firstDataChunkIsCached)
            {
                IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_firstDataChunk_get (swigCPtr);
                int len = (int) dataChunkLength;
		if (len<=0)
		{
			return null;
		}
                returnArray = new byte[len];
                byte[] marshalArray = new byte[len];
                Marshal.Copy(cPtr, marshalArray, 0, len);
                marshalArray.CopyTo(returnArray, 0);
                firstDataChunkCache = returnArray;
                firstDataChunkIsCached = true;
            }
            else
            {
                returnArray = firstDataChunkCache;
            }
            return returnArray;
        }
 
  }

  public byte[] iriDataChunk {
	set 
	{
	    	iriDataChunkCache=value;
		iriDataChunkIsCached = true;
		SetIriDataChunk (value, value.Length);    
	}

        get
        {
            byte[] returnArray;
            if (!iriDataChunkIsCached)
            {
                IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_iriDataChunk_get (swigCPtr);
                int len = (int) dataChunkLength;
		if (len<=0)
		{
			return null;
		}
                returnArray = new byte[len];
                byte[] marshalArray = new byte[len];
                Marshal.Copy(cPtr, marshalArray, 0, len);
                marshalArray.CopyTo(returnArray, 0);
                iriDataChunkCache = returnArray;
                iriDataChunkIsCached = true;
            }
            else
            {
                returnArray = iriDataChunkCache;
            }
            return returnArray;
        }
 
  }

  public uint iriWriteOffset {
    set {
      RakNetPINVOKE.FileProgressStruct_iriWriteOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.FileProgressStruct_iriWriteOffset_get(swigCPtr);
      return ret;
    } 
  }

  public SystemAddress senderSystemAddress {
    set {
      RakNetPINVOKE.FileProgressStruct_senderSystemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_senderSystemAddress_get(swigCPtr);
      SystemAddress ret = (cPtr == IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
      return ret;
    } 
  }

  public RakNetGUID senderGuid {
    set {
      RakNetPINVOKE.FileProgressStruct_senderGuid_set(swigCPtr, RakNetGUID.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_senderGuid_get(swigCPtr);
      RakNetGUID ret = (cPtr == IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
      return ret;
    } 
  }

  public bool allocateIrIDataChunkAutomatically {
    set {
      RakNetPINVOKE.FileProgressStruct_allocateIrIDataChunkAutomatically_set(swigCPtr, value);
    } 
    get {
      bool ret = RakNetPINVOKE.FileProgressStruct_allocateIrIDataChunkAutomatically_get(swigCPtr);
      return ret;
    } 
  }

  public FileProgressStruct() : this(RakNetPINVOKE.new_FileProgressStruct(), true) {
  }

  private void SetFirstDataChunk(byte[] inByteArray, int numBytes) {
    RakNetPINVOKE.FileProgressStruct_SetFirstDataChunk(swigCPtr, inByteArray, numBytes);
  }

  private void SetIriDataChunk(byte[] inByteArray, int numBytes) {
    RakNetPINVOKE.FileProgressStruct_SetIriDataChunk(swigCPtr, inByteArray, numBytes);
  }

}

}
