//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdGeomCollectionAPI : UsdSchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomCollectionAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomCollectionAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomCollectionAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomCollectionAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomCollectionAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomCollectionAPI(UsdPrim prim, TfToken name) : this(UsdCsPINVOKE.new_UsdGeomCollectionAPI__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomCollectionAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomCollectionAPI__SWIG_1(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomCollectionAPI() : this(UsdCsPINVOKE.new_UsdGeomCollectionAPI__SWIG_2(), true) {
  }

  public UsdGeomCollectionAPI(UsdSchemaBase schemaObj, TfToken name) : this(UsdCsPINVOKE.new_UsdGeomCollectionAPI__SWIG_3(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfToken GetCollectionName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomCollectionAPI_GetCollectionName(swigCPtr), true);
    return ret;
  }

  public bool IsEmpty() {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_IsEmpty(swigCPtr);
    return ret;
  }

  public bool SetTargets(SdfPathVector targets) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_SetTargets(swigCPtr, SdfPathVector.getCPtr(targets));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTargetFaceCounts(VtIntArray targetFaceCounts, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_SetTargetFaceCounts__SWIG_0(swigCPtr, VtIntArray.getCPtr(targetFaceCounts), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTargetFaceCounts(VtIntArray targetFaceCounts) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_SetTargetFaceCounts__SWIG_1(swigCPtr, VtIntArray.getCPtr(targetFaceCounts));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTargetFaceCounts(VtIntArray targetFaceCounts, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetFaceCounts__SWIG_0(swigCPtr, VtIntArray.getCPtr(targetFaceCounts), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTargetFaceCounts(VtIntArray targetFaceCounts) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetFaceCounts__SWIG_1(swigCPtr, VtIntArray.getCPtr(targetFaceCounts));
    return ret;
  }

  public bool SetTargetFaceIndices(VtIntArray targetFaceIndices, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_SetTargetFaceIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(targetFaceIndices), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTargetFaceIndices(VtIntArray targetFaceIndices) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_SetTargetFaceIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(targetFaceIndices));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTargetFaceIndices(VtIntArray targetFaceIndices, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetFaceIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(targetFaceIndices), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTargetFaceIndices(VtIntArray targetFaceIndices) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetFaceIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(targetFaceIndices));
    return ret;
  }

  public bool AddTarget(SdfPath target, VtIntArray faceIndices, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_AddTarget__SWIG_0(swigCPtr, SdfPath.getCPtr(target), VtIntArray.getCPtr(faceIndices), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddTarget(SdfPath target, VtIntArray faceIndices) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_AddTarget__SWIG_1(swigCPtr, SdfPath.getCPtr(target), VtIntArray.getCPtr(faceIndices));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddTarget(SdfPath target) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_AddTarget__SWIG_2(swigCPtr, SdfPath.getCPtr(target));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetTargetFaceCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetFaceCountsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTargetFaceCountsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetFaceCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTargetFaceCountsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetFaceCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTargetFaceCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetFaceCountsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTargetFaceIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetFaceIndicesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTargetFaceIndicesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetFaceIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTargetFaceIndicesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetFaceIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTargetFaceIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetFaceIndicesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetTargetsRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdGeomCollectionAPI_GetTargetsRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateTargetsRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdGeomCollectionAPI_CreateTargetsRel(swigCPtr), true);
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdPrim prim, TfToken name, SdfPathVector targets, VtIntArray targetFaceCounts, VtIntArray targetFaceIndices) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(name), SdfPathVector.getCPtr(targets), VtIntArray.getCPtr(targetFaceCounts), VtIntArray.getCPtr(targetFaceIndices)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdPrim prim, TfToken name, SdfPathVector targets, VtIntArray targetFaceCounts) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name), SdfPathVector.getCPtr(targets), VtIntArray.getCPtr(targetFaceCounts)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdPrim prim, TfToken name, SdfPathVector targets) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_2(UsdPrim.getCPtr(prim), TfToken.getCPtr(name), SdfPathVector.getCPtr(targets)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdPrim prim, TfToken name) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_3(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdSchemaBase schemaObj, TfToken name, SdfPathVector targets, VtIntArray targetFaceCounts, VtIntArray targetFaceIndices) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_4(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name), SdfPathVector.getCPtr(targets), VtIntArray.getCPtr(targetFaceCounts), VtIntArray.getCPtr(targetFaceIndices)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdSchemaBase schemaObj, TfToken name, SdfPathVector targets, VtIntArray targetFaceCounts) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_5(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name), SdfPathVector.getCPtr(targets), VtIntArray.getCPtr(targetFaceCounts)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdSchemaBase schemaObj, TfToken name, SdfPathVector targets) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_6(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name), SdfPathVector.getCPtr(targets)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPI Create(UsdSchemaBase schemaObj, TfToken name) {
    UsdGeomCollectionAPI ret = new UsdGeomCollectionAPI(UsdCsPINVOKE.UsdGeomCollectionAPI_Create__SWIG_7(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPIVector GetCollections(UsdPrim prim) {
    UsdGeomCollectionAPIVector ret = new UsdGeomCollectionAPIVector(UsdCsPINVOKE.UsdGeomCollectionAPI_GetCollections__SWIG_0(UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCollectionAPIVector GetCollections(UsdSchemaBase schemaObj) {
    UsdGeomCollectionAPIVector ret = new UsdGeomCollectionAPIVector(UsdCsPINVOKE.UsdGeomCollectionAPI_GetCollections__SWIG_1(UsdSchemaBase.getCPtr(schemaObj)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Validate(/*cstype*/ out string reason) {
    bool ret = UsdCsPINVOKE.UsdGeomCollectionAPI_Validate(swigCPtr, out reason);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
