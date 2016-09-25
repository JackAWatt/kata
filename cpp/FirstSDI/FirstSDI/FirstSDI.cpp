// FirstSDI.cpp : Implementation of CFirstSDIApp and DLL registration.

#include "stdafx.h"
#include "FirstSDI.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


CFirstSDIApp theApp;

const GUID CDECL _tlid = { 0x67C9AC5, 0xFA39, 0x4320, { 0xA7, 0x7, 0xF0, 0xB7, 0x1C, 0xB2, 0x54, 0x92 } };
const WORD _wVerMajor = 1;
const WORD _wVerMinor = 0;



// CFirstSDIApp::InitInstance - DLL initialization

BOOL CFirstSDIApp::InitInstance()
{
	BOOL bInit = COleControlModule::InitInstance();

	if (bInit)
	{
		// TODO: Add your own module initialization code here.
	}

	return bInit;
}



// CFirstSDIApp::ExitInstance - DLL termination

int CFirstSDIApp::ExitInstance()
{
	// TODO: Add your own module termination code here.

	return COleControlModule::ExitInstance();
}



// DllRegisterServer - Adds entries to the system registry

STDAPI DllRegisterServer(void)
{
	AFX_MANAGE_STATE(_afxModuleAddrThis);

	if (!AfxOleRegisterTypeLib(AfxGetInstanceHandle(), _tlid))
		return ResultFromScode(SELFREG_E_TYPELIB);

	if (!COleObjectFactoryEx::UpdateRegistryAll(TRUE))
		return ResultFromScode(SELFREG_E_CLASS);

	return NOERROR;
}



// DllUnregisterServer - Removes entries from the system registry

STDAPI DllUnregisterServer(void)
{
	AFX_MANAGE_STATE(_afxModuleAddrThis);

	if (!AfxOleUnregisterTypeLib(_tlid, _wVerMajor, _wVerMinor))
		return ResultFromScode(SELFREG_E_TYPELIB);

	if (!COleObjectFactoryEx::UpdateRegistryAll(FALSE))
		return ResultFromScode(SELFREG_E_CLASS);

	return NOERROR;
}
