

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


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


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, LIBID_FirstSDILib,0x067C9AC5,0xFA39,0x4320,0xA7,0x07,0xF0,0xB7,0x1C,0xB2,0x54,0x92);


MIDL_DEFINE_GUID(IID, DIID__DFirstSDI,0x183635FF,0x37E7,0x40B6,0xA8,0x51,0x66,0x6E,0xFF,0x4B,0xAD,0x27);


MIDL_DEFINE_GUID(IID, DIID__DFirstSDIEvents,0x45D68F88,0x449B,0x412E,0x99,0xC9,0x21,0xA2,0x6A,0xB3,0xA0,0x8F);


MIDL_DEFINE_GUID(CLSID, CLSID_FirstSDI,0xEB718317,0xD19A,0x4143,0xA2,0x1D,0xC9,0x83,0x7B,0xB3,0x7E,0x1D);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



