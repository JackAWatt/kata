// FirstSDICtrl.cpp : Implementation of the CFirstSDICtrl ActiveX Control class.

#include "stdafx.h"
#include "FirstSDI.h"
#include "FirstSDICtrl.h"
#include "FirstSDIPropPage.h"
#include "afxdialogex.h"


#ifdef _DEBUG
#define new DEBUG_NEW
#endif


IMPLEMENT_DYNCREATE(CFirstSDICtrl, COleControl)



// Message map

BEGIN_MESSAGE_MAP(CFirstSDICtrl, COleControl)
	ON_OLEVERB(AFX_IDS_VERB_PROPERTIES, OnProperties)
END_MESSAGE_MAP()



// Dispatch map

BEGIN_DISPATCH_MAP(CFirstSDICtrl, COleControl)
	DISP_FUNCTION_ID(CFirstSDICtrl, "AboutBox", DISPID_ABOUTBOX, AboutBox, VT_EMPTY, VTS_NONE)
END_DISPATCH_MAP()



// Event map

BEGIN_EVENT_MAP(CFirstSDICtrl, COleControl)
END_EVENT_MAP()



// Property pages

// TODO: Add more property pages as needed.  Remember to increase the count!
BEGIN_PROPPAGEIDS(CFirstSDICtrl, 1)
	PROPPAGEID(CFirstSDIPropPage::guid)
END_PROPPAGEIDS(CFirstSDICtrl)



// Initialize class factory and guid

IMPLEMENT_OLECREATE_EX(CFirstSDICtrl, "FIRSTSDI.FirstSDICtrl.1",
	0xeb718317, 0xd19a, 0x4143, 0xa2, 0x1d, 0xc9, 0x83, 0x7b, 0xb3, 0x7e, 0x1d)



// Type library ID and version

IMPLEMENT_OLETYPELIB(CFirstSDICtrl, _tlid, _wVerMajor, _wVerMinor)



// Interface IDs

const IID IID_DFirstSDI = { 0x183635FF, 0x37E7, 0x40B6, { 0xA8, 0x51, 0x66, 0x6E, 0xFF, 0x4B, 0xAD, 0x27 } };
const IID IID_DFirstSDIEvents = { 0x45D68F88, 0x449B, 0x412E, { 0x99, 0xC9, 0x21, 0xA2, 0x6A, 0xB3, 0xA0, 0x8F } };


// Control type information

static const DWORD _dwFirstSDIOleMisc =
	OLEMISC_ACTIVATEWHENVISIBLE |
	OLEMISC_SETCLIENTSITEFIRST |
	OLEMISC_INSIDEOUT |
	OLEMISC_CANTLINKINSIDE |
	OLEMISC_RECOMPOSEONRESIZE;

IMPLEMENT_OLECTLTYPE(CFirstSDICtrl, IDS_FIRSTSDI, _dwFirstSDIOleMisc)



// CFirstSDICtrl::CFirstSDICtrlFactory::UpdateRegistry -
// Adds or removes system registry entries for CFirstSDICtrl

BOOL CFirstSDICtrl::CFirstSDICtrlFactory::UpdateRegistry(BOOL bRegister)
{
	// TODO: Verify that your control follows apartment-model threading rules.
	// Refer to MFC TechNote 64 for more information.
	// If your control does not conform to the apartment-model rules, then
	// you must modify the code below, changing the 6th parameter from
	// afxRegApartmentThreading to 0.

	if (bRegister)
		return AfxOleRegisterControlClass(
			AfxGetInstanceHandle(),
			m_clsid,
			m_lpszProgID,
			IDS_FIRSTSDI,
			IDB_FIRSTSDI,
			afxRegApartmentThreading,
			_dwFirstSDIOleMisc,
			_tlid,
			_wVerMajor,
			_wVerMinor);
	else
		return AfxOleUnregisterClass(m_clsid, m_lpszProgID);
}



// CFirstSDICtrl::CFirstSDICtrl - Constructor

CFirstSDICtrl::CFirstSDICtrl()
{
	InitializeIIDs(&IID_DFirstSDI, &IID_DFirstSDIEvents);
	// TODO: Initialize your control's instance data here.
}



// CFirstSDICtrl::~CFirstSDICtrl - Destructor

CFirstSDICtrl::~CFirstSDICtrl()
{
	// TODO: Cleanup your control's instance data here.
}



// CFirstSDICtrl::OnDraw - Drawing function

void CFirstSDICtrl::OnDraw(
			CDC* pdc, const CRect& rcBounds, const CRect& rcInvalid)
{
	if (!pdc)
		return;

	// TODO: Replace the following code with your own drawing code.
	pdc->FillRect(rcBounds, CBrush::FromHandle((HBRUSH)GetStockObject(WHITE_BRUSH)));
	pdc->Ellipse(rcBounds);
}



// CFirstSDICtrl::DoPropExchange - Persistence support

void CFirstSDICtrl::DoPropExchange(CPropExchange* pPX)
{
	ExchangeVersion(pPX, MAKELONG(_wVerMinor, _wVerMajor));
	COleControl::DoPropExchange(pPX);

	// TODO: Call PX_ functions for each persistent custom property.
}



// CFirstSDICtrl::OnResetState - Reset control to default state

void CFirstSDICtrl::OnResetState()
{
	COleControl::OnResetState();  // Resets defaults found in DoPropExchange

	// TODO: Reset any other control state here.
}



// CFirstSDICtrl::AboutBox - Display an "About" box to the user

void CFirstSDICtrl::AboutBox()
{
	CDialogEx dlgAbout(IDD_ABOUTBOX_FIRSTSDI);
	dlgAbout.DoModal();
}



// CFirstSDICtrl message handlers
