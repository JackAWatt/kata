

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0555 */
/* at Thu Oct 04 16:16:58 2012
 */
/* Compiler settings for FirstSDI.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 7.00.0555 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__


#ifndef __FirstSDIidl_h__
#define __FirstSDIidl_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef ___DFirstSDI_FWD_DEFINED__
#define ___DFirstSDI_FWD_DEFINED__
typedef interface _DFirstSDI _DFirstSDI;
#endif 	/* ___DFirstSDI_FWD_DEFINED__ */


#ifndef ___DFirstSDIEvents_FWD_DEFINED__
#define ___DFirstSDIEvents_FWD_DEFINED__
typedef interface _DFirstSDIEvents _DFirstSDIEvents;
#endif 	/* ___DFirstSDIEvents_FWD_DEFINED__ */


#ifndef __FirstSDI_FWD_DEFINED__
#define __FirstSDI_FWD_DEFINED__

#ifdef __cplusplus
typedef class FirstSDI FirstSDI;
#else
typedef struct FirstSDI FirstSDI;
#endif /* __cplusplus */

#endif 	/* __FirstSDI_FWD_DEFINED__ */


#ifdef __cplusplus
extern "C"{
#endif 



#ifndef __FirstSDILib_LIBRARY_DEFINED__
#define __FirstSDILib_LIBRARY_DEFINED__

/* library FirstSDILib */
/* [control][version][uuid] */ 


EXTERN_C const IID LIBID_FirstSDILib;

#ifndef ___DFirstSDI_DISPINTERFACE_DEFINED__
#define ___DFirstSDI_DISPINTERFACE_DEFINED__

/* dispinterface _DFirstSDI */
/* [uuid] */ 


EXTERN_C const IID DIID__DFirstSDI;

#if defined(__cplusplus) && !defined(CINTERFACE)

    MIDL_INTERFACE("183635FF-37E7-40B6-A851-666EFF4BAD27")
    _DFirstSDI : public IDispatch
    {
    };
    
#else 	/* C style interface */

    typedef struct _DFirstSDIVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            _DFirstSDI * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            _DFirstSDI * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            _DFirstSDI * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            _DFirstSDI * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            _DFirstSDI * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            _DFirstSDI * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            _DFirstSDI * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        END_INTERFACE
    } _DFirstSDIVtbl;

    interface _DFirstSDI
    {
        CONST_VTBL struct _DFirstSDIVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define _DFirstSDI_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define _DFirstSDI_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define _DFirstSDI_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define _DFirstSDI_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define _DFirstSDI_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define _DFirstSDI_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define _DFirstSDI_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */


#endif 	/* ___DFirstSDI_DISPINTERFACE_DEFINED__ */


#ifndef ___DFirstSDIEvents_DISPINTERFACE_DEFINED__
#define ___DFirstSDIEvents_DISPINTERFACE_DEFINED__

/* dispinterface _DFirstSDIEvents */
/* [uuid] */ 


EXTERN_C const IID DIID__DFirstSDIEvents;

#if defined(__cplusplus) && !defined(CINTERFACE)

    MIDL_INTERFACE("45D68F88-449B-412E-99C9-21A26AB3A08F")
    _DFirstSDIEvents : public IDispatch
    {
    };
    
#else 	/* C style interface */

    typedef struct _DFirstSDIEventsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            _DFirstSDIEvents * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            _DFirstSDIEvents * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            _DFirstSDIEvents * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            _DFirstSDIEvents * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            _DFirstSDIEvents * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            _DFirstSDIEvents * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            _DFirstSDIEvents * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        END_INTERFACE
    } _DFirstSDIEventsVtbl;

    interface _DFirstSDIEvents
    {
        CONST_VTBL struct _DFirstSDIEventsVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define _DFirstSDIEvents_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define _DFirstSDIEvents_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define _DFirstSDIEvents_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define _DFirstSDIEvents_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define _DFirstSDIEvents_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define _DFirstSDIEvents_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define _DFirstSDIEvents_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */


#endif 	/* ___DFirstSDIEvents_DISPINTERFACE_DEFINED__ */


EXTERN_C const CLSID CLSID_FirstSDI;

#ifdef __cplusplus

class DECLSPEC_UUID("EB718317-D19A-4143-A21D-C9837BB37E1D")
FirstSDI;
#endif
#endif /* __FirstSDILib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


