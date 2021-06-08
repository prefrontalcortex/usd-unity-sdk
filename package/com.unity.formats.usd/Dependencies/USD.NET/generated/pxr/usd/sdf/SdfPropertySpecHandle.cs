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
    public class SdfPropertySpecHandle : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfPropertySpecHandle(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfPropertySpecHandle obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfPropertySpecHandle()
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
                        UsdCsPINVOKE.delete_SdfPropertySpecHandle(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SdfPropertySpecHandle() : this(UsdCsPINVOKE.new_SdfPropertySpecHandle__SWIG_0(), true)
        {
        }

        public SdfPropertySpecHandle(SdfPropertySpec spec) : this(UsdCsPINVOKE.new_SdfPropertySpecHandle__SWIG_1(SdfPropertySpec.getCPtr(spec)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfPropertySpecHandle(SdfPropertySpecHandle handle) : this(UsdCsPINVOKE.new_SdfPropertySpecHandle__SWIG_2(SdfPropertySpecHandle.getCPtr(handle)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfPropertySpec __deref__()
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.SdfPropertySpecHandle___deref__(swigCPtr);
            SdfPropertySpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPropertySpec(cPtr, false);
            return ret;
        }

        public string GetName()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetName(swigCPtr);
            return ret;
        }

        public TfToken GetNameToken()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.SdfPropertySpecHandle_GetNameToken(swigCPtr), true);
            return ret;
        }

        public bool CanSetName(string newName, SWIGTYPE_p_std__string whyNot)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_CanSetName(swigCPtr, newName, SWIGTYPE_p_std__string.getCPtr(whyNot));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetName(string newName, bool validate)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_SetName__SWIG_0(swigCPtr, newName, validate);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetName(string newName)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_SetName__SWIG_1(swigCPtr, newName);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool IsValidName(string name)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_IsValidName(swigCPtr, name);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfSpecHandle GetOwner()
        {
            SdfSpecHandle ret = new SdfSpecHandle(UsdCsPINVOKE.SdfPropertySpecHandle_GetOwner(swigCPtr), true);
            return ret;
        }

        public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
        {
            SWIGTYPE_p_SdfDictionaryProxy ret = new SWIGTYPE_p_SdfDictionaryProxy(UsdCsPINVOKE.SdfPropertySpecHandle_GetCustomData(swigCPtr), true);
            return ret;
        }

        public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
        {
            SWIGTYPE_p_SdfDictionaryProxy ret = new SWIGTYPE_p_SdfDictionaryProxy(UsdCsPINVOKE.SdfPropertySpecHandle_GetAssetInfo(swigCPtr), true);
            return ret;
        }

        public void SetCustomData(string name, VtValue value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetAssetInfo(string name, VtValue value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public string GetDisplayGroup()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetDisplayGroup(swigCPtr);
            return ret;
        }

        public void SetDisplayGroup(string value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetDisplayGroup(swigCPtr, value);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public string GetDisplayName()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetDisplayName(swigCPtr);
            return ret;
        }

        public void SetDisplayName(string value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetDisplayName(swigCPtr, value);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public string GetDocumentation()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetDocumentation(swigCPtr);
            return ret;
        }

        public void SetDocumentation(string value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetDocumentation(swigCPtr, value);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool GetHidden()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetHidden(swigCPtr);
            return ret;
        }

        public void SetHidden(bool value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetHidden(swigCPtr, value);
        }

        public SdfPermission GetPermission()
        {
            SdfPermission ret = (SdfPermission)UsdCsPINVOKE.SdfPropertySpecHandle_GetPermission(swigCPtr);
            return ret;
        }

        public void SetPermission(SdfPermission value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetPermission(swigCPtr, (int)value);
        }

        public string GetPrefix()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetPrefix(swigCPtr);
            return ret;
        }

        public void SetPrefix(string value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetPrefix(swigCPtr, value);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public string GetSuffix()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetSuffix(swigCPtr);
            return ret;
        }

        public void SetSuffix(string value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetSuffix(swigCPtr, value);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public string GetSymmetricPeer()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetSymmetricPeer(swigCPtr);
            return ret;
        }

        public void SetSymmetricPeer(string peerName)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetSymmetricPeer(swigCPtr, peerName);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
        {
            SWIGTYPE_p_SdfDictionaryProxy ret = new SWIGTYPE_p_SdfDictionaryProxy(UsdCsPINVOKE.SdfPropertySpecHandle_GetSymmetryArguments(swigCPtr), true);
            return ret;
        }

        public void SetSymmetryArgument(string name, VtValue value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public TfToken GetSymmetryFunction()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.SdfPropertySpecHandle_GetSymmetryFunction(swigCPtr), true);
            return ret;
        }

        public void SetSymmetryFunction(TfToken functionName)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
        {
            SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t ret = new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(UsdCsPINVOKE.SdfPropertySpecHandle_GetTimeSampleMap(swigCPtr), true);
            return ret;
        }

        public TfType GetValueType()
        {
            TfType ret = new TfType(UsdCsPINVOKE.SdfPropertySpecHandle_GetValueType(swigCPtr), true);
            return ret;
        }

        public SdfValueTypeName GetTypeName()
        {
            SdfValueTypeName ret = new SdfValueTypeName(UsdCsPINVOKE.SdfPropertySpecHandle_GetTypeName(swigCPtr), true);
            return ret;
        }

        public VtValue GetDefaultValue()
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfPropertySpecHandle_GetDefaultValue(swigCPtr), true);
            return ret;
        }

        public bool SetDefaultValue(VtValue defaultValue)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_SetDefaultValue(swigCPtr, VtValue.getCPtr(defaultValue));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool HasDefaultValue()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_HasDefaultValue(swigCPtr);
            return ret;
        }

        public void ClearDefaultValue()
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_ClearDefaultValue(swigCPtr);
        }

        public string GetComment()
        {
            string ret = UsdCsPINVOKE.SdfPropertySpecHandle_GetComment(swigCPtr);
            return ret;
        }

        public void SetComment(string value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetComment(swigCPtr, value);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool IsCustom()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_IsCustom(swigCPtr);
            return ret;
        }

        public void SetCustom(bool custom)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetCustom(swigCPtr, custom);
        }

        public SdfVariability GetVariability()
        {
            SdfVariability ret = (SdfVariability)UsdCsPINVOKE.SdfPropertySpecHandle_GetVariability(swigCPtr);
            return ret;
        }

        public bool HasOnlyRequiredFields()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_HasOnlyRequiredFields(swigCPtr);
            return ret;
        }

        public SWIGTYPE_p_SdfSchemaBase GetSchema()
        {
            SWIGTYPE_p_SdfSchemaBase ret = new SWIGTYPE_p_SdfSchemaBase(UsdCsPINVOKE.SdfPropertySpecHandle_GetSchema(swigCPtr), false);
            return ret;
        }

        public SdfSpecType GetSpecType()
        {
            SdfSpecType ret = (SdfSpecType)UsdCsPINVOKE.SdfPropertySpecHandle_GetSpecType(swigCPtr);
            return ret;
        }

        public bool IsDormant()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_IsDormant(swigCPtr);
            return ret;
        }

        public SdfLayerHandle GetLayer()
        {
            SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.SdfPropertySpecHandle_GetLayer(swigCPtr), true);
            return ret;
        }

        public SdfPath GetPath()
        {
            SdfPath ret = new SdfPath(UsdCsPINVOKE.SdfPropertySpecHandle_GetPath(swigCPtr), true);
            return ret;
        }

        public bool PermissionToEdit()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_PermissionToEdit(swigCPtr);
            return ret;
        }

        public TfTokenVector ListInfoKeys()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfPropertySpecHandle_ListInfoKeys(swigCPtr), true);
            return ret;
        }

        public TfTokenVector GetMetaDataInfoKeys()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfPropertySpecHandle_GetMetaDataInfoKeys(swigCPtr), true);
            return ret;
        }

        public TfToken GetMetaDataDisplayGroup(TfToken key)
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.SdfPropertySpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VtValue GetInfo(TfToken key)
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfPropertySpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetInfo(TfToken key, VtValue value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool HasInfo(TfToken key)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void ClearInfo(TfToken key)
        {
            UsdCsPINVOKE.SdfPropertySpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public TfType GetTypeForInfo(TfToken key)
        {
            TfType ret = new TfType(UsdCsPINVOKE.SdfPropertySpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VtValue GetFallbackForInfo(TfToken key)
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfPropertySpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), false);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool WriteToStream(SWIGTYPE_p_std__ostream arg0, uint indent)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_WriteToStream__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(arg0), indent);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool WriteToStream(SWIGTYPE_p_std__ostream arg0)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_WriteToStream__SWIG_1(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(arg0));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool IsInert(bool ignoreChildren)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
            return ret;
        }

        public bool IsInert()
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_IsInert__SWIG_1(swigCPtr);
            return ret;
        }

        public TfTokenVector ListFields()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfPropertySpecHandle_ListFields(swigCPtr), true);
            return ret;
        }

        public bool HasField(TfToken name)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VtValue GetField(TfToken name)
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfPropertySpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetField(TfToken name, VtValue value)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearField(TfToken name)
        {
            bool ret = UsdCsPINVOKE.SdfPropertySpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }
}
