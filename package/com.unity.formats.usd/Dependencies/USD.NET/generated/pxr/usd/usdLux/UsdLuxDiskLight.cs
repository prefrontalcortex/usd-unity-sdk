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
    public class UsdLuxDiskLight : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdLuxDiskLight(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdLuxDiskLight obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdLuxDiskLight()
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
                        UsdCsPINVOKE.delete_UsdLuxDiskLight(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdLuxDiskLight(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdLuxDiskLight__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdLuxDiskLight() : this(UsdCsPINVOKE.new_UsdLuxDiskLight__SWIG_1(), true)
        {
        }

        public UsdLuxDiskLight(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdLuxDiskLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxDiskLight_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxDiskLight_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public static UsdLuxDiskLight Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdLuxDiskLight ret = new UsdLuxDiskLight(UsdCsPINVOKE.UsdLuxDiskLight_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static UsdLuxDiskLight Define(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdLuxDiskLight ret = new UsdLuxDiskLight(UsdCsPINVOKE.UsdLuxDiskLight_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetRadiusAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDiskLight_GetRadiusAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDiskLight_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRadiusAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDiskLight_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRadiusAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDiskLight_CreateRadiusAttr__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}
