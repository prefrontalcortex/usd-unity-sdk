//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class UsdStageWeakPtr : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdStageWeakPtr(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdStageWeakPtr obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdStageWeakPtr()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdStageWeakPtr(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdStageWeakPtr(UsdStage stage) : this(UsdCsPINVOKE.new_UsdStageWeakPtr(UsdStage.getCPtr(stage)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdStage __deref__()
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.UsdStageWeakPtr___deref__(swigCPtr);
            UsdStage ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdStage(cPtr, true);
            return ret;
        }

        public SWIGTYPE_p_UsdStageLoadRules GetLoadRules()
        {
            SWIGTYPE_p_UsdStageLoadRules ret = new SWIGTYPE_p_UsdStageLoadRules(UsdCsPINVOKE.UsdStageWeakPtr_GetLoadRules(swigCPtr), false);
            return ret;
        }

        public UsdStagePopulationMask GetPopulationMask()
        {
            UsdStagePopulationMask ret = new UsdStagePopulationMask(UsdCsPINVOKE.UsdStageWeakPtr_GetPopulationMask(swigCPtr), true);
            return ret;
        }

        public UsdPrim GetPseudoRoot()
        {
            UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdStageWeakPtr_GetPseudoRoot(swigCPtr), true);
            return ret;
        }

        public UsdPrim GetDefaultPrim()
        {
            UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdStageWeakPtr_GetDefaultPrim(swigCPtr), true);
            return ret;
        }

        public bool HasDefaultPrim()
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasDefaultPrim(swigCPtr);
            return ret;
        }

        public UsdPrim GetPrimAtPath(SdfPath path)
        {
            UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdStageWeakPtr_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdObject GetObjectAtPath(SdfPath path)
        {
            UsdObject ret = new UsdObject(UsdCsPINVOKE.UsdStageWeakPtr_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdProperty GetPropertyAtPath(SdfPath path)
        {
            UsdProperty ret = new UsdProperty(UsdCsPINVOKE.UsdStageWeakPtr_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetAttributeAtPath(SdfPath path)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdStageWeakPtr_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdRelationship GetRelationshipAtPath(SdfPath path)
        {
            UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdStageWeakPtr_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfLayerHandle GetSessionLayer()
        {
            SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.UsdStageWeakPtr_GetSessionLayer(swigCPtr), true);
            return ret;
        }

        public SdfLayerHandle GetRootLayer()
        {
            SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.UsdStageWeakPtr_GetRootLayer(swigCPtr), true);
            return ret;
        }

        public ArResolverContext GetPathResolverContext()
        {
            ArResolverContext ret = new ArResolverContext(UsdCsPINVOKE.UsdStageWeakPtr_GetPathResolverContext(swigCPtr), true);
            return ret;
        }

        public string ResolveIdentifierToEditTarget(string identifier)
        {
            string ret = UsdCsPINVOKE.UsdStageWeakPtr_ResolveIdentifierToEditTarget(swigCPtr, identifier);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfLayerHandleVector GetLayerStack(bool includeSessionLayers)
        {
            SdfLayerHandleVector ret = new SdfLayerHandleVector(UsdCsPINVOKE.UsdStageWeakPtr_GetLayerStack__SWIG_0(swigCPtr, includeSessionLayers), true);
            return ret;
        }

        public SdfLayerHandleVector GetLayerStack()
        {
            SdfLayerHandleVector ret = new SdfLayerHandleVector(UsdCsPINVOKE.UsdStageWeakPtr_GetLayerStack__SWIG_1(swigCPtr), true);
            return ret;
        }

        public SdfLayerHandleVector GetUsedLayers(bool includeClipLayers)
        {
            SdfLayerHandleVector ret = new SdfLayerHandleVector(UsdCsPINVOKE.UsdStageWeakPtr_GetUsedLayers__SWIG_0(swigCPtr, includeClipLayers), true);
            return ret;
        }

        public SdfLayerHandleVector GetUsedLayers()
        {
            SdfLayerHandleVector ret = new SdfLayerHandleVector(UsdCsPINVOKE.UsdStageWeakPtr_GetUsedLayers__SWIG_1(swigCPtr), true);
            return ret;
        }

        public bool HasLocalLayer(SdfLayerHandle layer)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasLocalLayer(swigCPtr, SdfLayerHandle.getCPtr(layer));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdEditTarget GetEditTarget()
        {
            UsdEditTarget ret = new UsdEditTarget(UsdCsPINVOKE.UsdStageWeakPtr_GetEditTarget(swigCPtr), false);
            return ret;
        }

        public StdStringVector GetMutedLayers()
        {
            StdStringVector ret = new StdStringVector(UsdCsPINVOKE.UsdStageWeakPtr_GetMutedLayers(swigCPtr), false);
            return ret;
        }

        public bool IsLayerMuted(string layerIdentifier)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_IsLayerMuted(swigCPtr, layerIdentifier);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Export(string filename, bool addSourceFileComment, SWIGTYPE_p_std__mapT_std__string_std__string_std__lessT_std__string_t_t args)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_Export__SWIG_0(swigCPtr, filename, addSourceFileComment, SWIGTYPE_p_std__mapT_std__string_std__string_std__lessT_std__string_t_t.getCPtr(args));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Export(string filename, bool addSourceFileComment)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_Export__SWIG_1(swigCPtr, filename, addSourceFileComment);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Export(string filename)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_Export__SWIG_2(swigCPtr, filename);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ExportToString(SWIGTYPE_p_std__string result, bool addSourceFileComment)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_ExportToString__SWIG_0(swigCPtr, SWIGTYPE_p_std__string.getCPtr(result), addSourceFileComment);
            return ret;
        }

        public bool ExportToString(SWIGTYPE_p_std__string result)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_ExportToString__SWIG_1(swigCPtr, SWIGTYPE_p_std__string.getCPtr(result));
            return ret;
        }

        public SdfLayer Flatten(bool addSourceFileComment)
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.UsdStageWeakPtr_Flatten__SWIG_0(swigCPtr, addSourceFileComment);
            SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
            return ret;
        }

        public SdfLayer Flatten()
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.UsdStageWeakPtr_Flatten__SWIG_1(swigCPtr);
            SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
            return ret;
        }

        public bool GetMetadata(TfToken key, VtValue value)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_GetMetadata(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool HasMetadata(TfToken key)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasMetadata(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool HasAuthoredMetadata(TfToken key)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasAuthoredMetadata(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetMetadata(TfToken key, VtValue value)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_SetMetadata(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearMetadata(TfToken key)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_ClearMetadata(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool GetMetadataByDictKey(TfToken key, TfToken keyPath, VtValue value)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_GetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool HasMetadataDictKey(TfToken key, TfToken keyPath)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool HasAuthoredMetadataDictKey(TfToken key, TfToken keyPath)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasAuthoredMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetMetadataByDictKey(TfToken key, TfToken keyPath, VtValue value)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_SetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearMetadataByDictKey(TfToken key, TfToken keyPath)
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_ClearMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public double GetStartTimeCode()
        {
            double ret = UsdCsPINVOKE.UsdStageWeakPtr_GetStartTimeCode(swigCPtr);
            return ret;
        }

        public double GetEndTimeCode()
        {
            double ret = UsdCsPINVOKE.UsdStageWeakPtr_GetEndTimeCode(swigCPtr);
            return ret;
        }

        public bool HasAuthoredTimeCodeRange()
        {
            bool ret = UsdCsPINVOKE.UsdStageWeakPtr_HasAuthoredTimeCodeRange(swigCPtr);
            return ret;
        }

        public double GetTimeCodesPerSecond()
        {
            double ret = UsdCsPINVOKE.UsdStageWeakPtr_GetTimeCodesPerSecond(swigCPtr);
            return ret;
        }

        public void SetTimeCodesPerSecond(double timeCodesPerSecond)
        {
            UsdCsPINVOKE.UsdStageWeakPtr_SetTimeCodesPerSecond(swigCPtr, timeCodesPerSecond);
        }

        public double GetFramesPerSecond()
        {
            double ret = UsdCsPINVOKE.UsdStageWeakPtr_GetFramesPerSecond(swigCPtr);
            return ret;
        }

        public void SetFramesPerSecond(double framesPerSecond)
        {
            UsdCsPINVOKE.UsdStageWeakPtr_SetFramesPerSecond(swigCPtr, framesPerSecond);
        }

        public void SetColorConfiguration(SdfAssetPath colorConfig)
        {
            UsdCsPINVOKE.UsdStageWeakPtr_SetColorConfiguration(swigCPtr, SdfAssetPath.getCPtr(colorConfig));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfAssetPath GetColorConfiguration()
        {
            SdfAssetPath ret = new SdfAssetPath(UsdCsPINVOKE.UsdStageWeakPtr_GetColorConfiguration(swigCPtr), true);
            return ret;
        }

        public void SetColorManagementSystem(TfToken cms)
        {
            UsdCsPINVOKE.UsdStageWeakPtr_SetColorManagementSystem(swigCPtr, TfToken.getCPtr(cms));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public TfToken GetColorManagementSystem()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdStageWeakPtr_GetColorManagementSystem(swigCPtr), true);
            return ret;
        }

        public UsdInterpolationType GetInterpolationType()
        {
            UsdInterpolationType ret = (UsdInterpolationType)UsdCsPINVOKE.UsdStageWeakPtr_GetInterpolationType(swigCPtr);
            return ret;
        }

        public UsdPrimVector GetMasters()
        {
            UsdPrimVector ret = new UsdPrimVector(UsdCsPINVOKE.UsdStageWeakPtr_GetMasters(swigCPtr), true);
            return ret;
        }
    }
}
