/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class keyspace_client {
  public static long imaxabs(long n) {
    long ret = keyspace_clientPINVOKE.imaxabs(n);
    return ret;
  }

  public static imaxdiv_t imaxdiv(long numer, long denom) {
    imaxdiv_t ret = new imaxdiv_t(keyspace_clientPINVOKE.imaxdiv(numer, denom), true);
    return ret;
  }

  public static long strtoimax(string nptr, SWIGTYPE_p_p_char endptr, int arg2) {
    long ret = keyspace_clientPINVOKE.strtoimax(nptr, SWIGTYPE_p_p_char.getCPtr(endptr), arg2);
    return ret;
  }

  public static ulong strtoumax(string nptr, SWIGTYPE_p_p_char endptr, int arg2) {
    ulong ret = keyspace_clientPINVOKE.strtoumax(nptr, SWIGTYPE_p_p_char.getCPtr(endptr), arg2);
    return ret;
  }

  public static void Keyspace_ResultBegin(SWIGTYPE_p_void result) {
    keyspace_clientPINVOKE.Keyspace_ResultBegin(SWIGTYPE_p_void.getCPtr(result));
  }

  public static void Keyspace_ResultNext(SWIGTYPE_p_void result) {
    keyspace_clientPINVOKE.Keyspace_ResultNext(SWIGTYPE_p_void.getCPtr(result));
  }

  public static bool Keyspace_ResultIsEnd(SWIGTYPE_p_void result) {
    bool ret = keyspace_clientPINVOKE.Keyspace_ResultIsEnd(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static void Keyspace_ResultClose(SWIGTYPE_p_void result) {
    keyspace_clientPINVOKE.Keyspace_ResultClose(SWIGTYPE_p_void.getCPtr(result));
  }

  public static string Keyspace_ResultKey(SWIGTYPE_p_void result) {
    string ret = keyspace_clientPINVOKE.Keyspace_ResultKey(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static string Keyspace_ResultValue(SWIGTYPE_p_void result) {
    string ret = keyspace_clientPINVOKE.Keyspace_ResultValue(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static int Keyspace_ResultTransportStatus(SWIGTYPE_p_void result) {
    int ret = keyspace_clientPINVOKE.Keyspace_ResultTransportStatus(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static int Keyspace_ResultConnectivityStatus(SWIGTYPE_p_void result) {
    int ret = keyspace_clientPINVOKE.Keyspace_ResultConnectivityStatus(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static int Keyspace_ResultTimeoutStatus(SWIGTYPE_p_void result) {
    int ret = keyspace_clientPINVOKE.Keyspace_ResultTimeoutStatus(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static int Keyspace_ResultCommandStatus(SWIGTYPE_p_void result) {
    int ret = keyspace_clientPINVOKE.Keyspace_ResultCommandStatus(SWIGTYPE_p_void.getCPtr(result));
    return ret;
  }

  public static SWIGTYPE_p_void Keyspace_Create() {
    IntPtr cPtr = keyspace_clientPINVOKE.Keyspace_Create();
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public static int Keyspace_Init(SWIGTYPE_p_void client, Keyspace_NodeParams arg1) {
    int ret = keyspace_clientPINVOKE.Keyspace_Init(SWIGTYPE_p_void.getCPtr(client), Keyspace_NodeParams.getCPtr(arg1));
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void Keyspace_Destroy(SWIGTYPE_p_void client) {
    keyspace_clientPINVOKE.Keyspace_Destroy(SWIGTYPE_p_void.getCPtr(client));
  }

  public static SWIGTYPE_p_void Keyspace_GetResult(SWIGTYPE_p_void arg0) {
    IntPtr cPtr = keyspace_clientPINVOKE.Keyspace_GetResult(SWIGTYPE_p_void.getCPtr(arg0));
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public static void Keyspace_SetGlobalTimeout(SWIGTYPE_p_void client, ulong timeout) {
    keyspace_clientPINVOKE.Keyspace_SetGlobalTimeout(SWIGTYPE_p_void.getCPtr(client), timeout);
  }

  public static void Keyspace_SetMasterTimeout(SWIGTYPE_p_void client, ulong timeout) {
    keyspace_clientPINVOKE.Keyspace_SetMasterTimeout(SWIGTYPE_p_void.getCPtr(client), timeout);
  }

  public static ulong Keyspace_GetGlobalTimeout(SWIGTYPE_p_void client) {
    ulong ret = keyspace_clientPINVOKE.Keyspace_GetGlobalTimeout(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static ulong Keyspace_GetMasterTimeout(SWIGTYPE_p_void client) {
    ulong ret = keyspace_clientPINVOKE.Keyspace_GetMasterTimeout(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static int Keyspace_GetMaster(SWIGTYPE_p_void client) {
    int ret = keyspace_clientPINVOKE.Keyspace_GetMaster(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static void Keyspace_DistributeDirty(SWIGTYPE_p_void client, bool dd) {
    keyspace_clientPINVOKE.Keyspace_DistributeDirty(SWIGTYPE_p_void.getCPtr(client), dd);
  }

  public static int Keyspace_Get(SWIGTYPE_p_void client, string key) {
    int ret = keyspace_clientPINVOKE.Keyspace_Get(SWIGTYPE_p_void.getCPtr(client), key);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyGet(SWIGTYPE_p_void client, string key) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyGet(SWIGTYPE_p_void.getCPtr(client), key);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Count(SWIGTYPE_p_void client, string prefix, string startKey, ulong count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_Count(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_CountStr(SWIGTYPE_p_void client, string prefix, string startKey, string count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_CountStr(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyCount(SWIGTYPE_p_void client, string prefix, string startKey, ulong count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyCount(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyCountStr(SWIGTYPE_p_void client, string prefix, string startKey, string count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyCountStr(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_ListKeys(SWIGTYPE_p_void client, string prefix, string startKey, ulong count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_ListKeys(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_ListKeysStr(SWIGTYPE_p_void client, string prefix, string startKey, string count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_ListKeysStr(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyListKeys(SWIGTYPE_p_void client, string prefix, string startKey, ulong count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyListKeys(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyListKeysStr(SWIGTYPE_p_void client, string prefix, string startKey, string count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyListKeysStr(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_ListKeyValues(SWIGTYPE_p_void client, string prefix, string startKey, ulong count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_ListKeyValues(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_ListKeyValuesStr(SWIGTYPE_p_void client, string prefix, string startKey, string count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_ListKeyValuesStr(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyListKeyValues(SWIGTYPE_p_void client, string prefix, string startKey, ulong count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyListKeyValues(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_DirtyListKeyValuesStr(SWIGTYPE_p_void client, string prefix, string startKey, string count, bool next, bool forward) {
    int ret = keyspace_clientPINVOKE.Keyspace_DirtyListKeyValuesStr(SWIGTYPE_p_void.getCPtr(client), prefix, startKey, count, next, forward);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Set(SWIGTYPE_p_void client, string key, string value) {
    int ret = keyspace_clientPINVOKE.Keyspace_Set(SWIGTYPE_p_void.getCPtr(client), key, value);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_TestAndSet(SWIGTYPE_p_void client, string key, string test, string value) {
    int ret = keyspace_clientPINVOKE.Keyspace_TestAndSet(SWIGTYPE_p_void.getCPtr(client), key, test, value);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Add(SWIGTYPE_p_void client, string key, long num) {
    int ret = keyspace_clientPINVOKE.Keyspace_Add(SWIGTYPE_p_void.getCPtr(client), key, num);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_AddStr(SWIGTYPE_p_void client, string key, string num) {
    int ret = keyspace_clientPINVOKE.Keyspace_AddStr(SWIGTYPE_p_void.getCPtr(client), key, num);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Delete(SWIGTYPE_p_void client, string key) {
    int ret = keyspace_clientPINVOKE.Keyspace_Delete(SWIGTYPE_p_void.getCPtr(client), key);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Remove(SWIGTYPE_p_void client, string key) {
    int ret = keyspace_clientPINVOKE.Keyspace_Remove(SWIGTYPE_p_void.getCPtr(client), key);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Rename(SWIGTYPE_p_void client, string from, string to) {
    int ret = keyspace_clientPINVOKE.Keyspace_Rename(SWIGTYPE_p_void.getCPtr(client), from, to);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_Prune(SWIGTYPE_p_void client, string prefix) {
    int ret = keyspace_clientPINVOKE.Keyspace_Prune(SWIGTYPE_p_void.getCPtr(client), prefix);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_SetExpiry(SWIGTYPE_p_void client, string key, int exptime) {
    int ret = keyspace_clientPINVOKE.Keyspace_SetExpiry(SWIGTYPE_p_void.getCPtr(client), key, exptime);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_RemoveExpiry(SWIGTYPE_p_void client, string key) {
    int ret = keyspace_clientPINVOKE.Keyspace_RemoveExpiry(SWIGTYPE_p_void.getCPtr(client), key);
    if (keyspace_clientPINVOKE.SWIGPendingException.Pending) throw keyspace_clientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Keyspace_ClearExpiries(SWIGTYPE_p_void client) {
    int ret = keyspace_clientPINVOKE.Keyspace_ClearExpiries(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static int Keyspace_Begin(SWIGTYPE_p_void client) {
    int ret = keyspace_clientPINVOKE.Keyspace_Begin(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static int Keyspace_Submit(SWIGTYPE_p_void client) {
    int ret = keyspace_clientPINVOKE.Keyspace_Submit(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static int Keyspace_Cancel(SWIGTYPE_p_void client) {
    int ret = keyspace_clientPINVOKE.Keyspace_Cancel(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static bool Keyspace_IsBatched(SWIGTYPE_p_void client) {
    bool ret = keyspace_clientPINVOKE.Keyspace_IsBatched(SWIGTYPE_p_void.getCPtr(client));
    return ret;
  }

  public static void Keyspace_SetTrace(bool trace) {
    keyspace_clientPINVOKE.Keyspace_SetTrace(trace);
  }

}
