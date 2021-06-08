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
    public class UsdShadeShaderDefUtils : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdShadeShaderDefUtils(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdShadeShaderDefUtils obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdShadeShaderDefUtils()
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
                        UsdCsPINVOKE.delete_UsdShadeShaderDefUtils(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public static bool SplitShaderIdentifier(TfToken identifier, TfToken familyName, TfToken implementationName, NdrVersion version)
        {
            bool ret = UsdCsPINVOKE.UsdShadeShaderDefUtils_SplitShaderIdentifier(TfToken.getCPtr(identifier), TfToken.getCPtr(familyName), TfToken.getCPtr(implementationName), NdrVersion.getCPtr(version));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static NdrNodeDiscoveryResultVector GetNodeDiscoveryResults(UsdShadeShader shaderDef, string sourceUri)
        {
            NdrNodeDiscoveryResultVector ret = new NdrNodeDiscoveryResultVector(UsdCsPINVOKE.UsdShadeShaderDefUtils_GetNodeDiscoveryResults(UsdShadeShader.getCPtr(shaderDef), sourceUri), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdShadeShaderDefUtils() : this(UsdCsPINVOKE.new_UsdShadeShaderDefUtils(), true)
        {
        }
    }
}
