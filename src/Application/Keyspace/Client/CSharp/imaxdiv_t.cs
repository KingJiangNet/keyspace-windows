/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class imaxdiv_t : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal imaxdiv_t(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(imaxdiv_t obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~imaxdiv_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          keyspace_clientPINVOKE.delete_imaxdiv_t(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public long quot {
    set {
      keyspace_clientPINVOKE.imaxdiv_t_quot_set(swigCPtr, value);
    } 
    get {
      long ret = keyspace_clientPINVOKE.imaxdiv_t_quot_get(swigCPtr);
      return ret;
    } 
  }

  public long rem {
    set {
      keyspace_clientPINVOKE.imaxdiv_t_rem_set(swigCPtr, value);
    } 
    get {
      long ret = keyspace_clientPINVOKE.imaxdiv_t_rem_get(swigCPtr);
      return ret;
    } 
  }

  public imaxdiv_t() : this(keyspace_clientPINVOKE.new_imaxdiv_t(), true) {
  }

}
