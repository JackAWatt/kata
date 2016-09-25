// FirstSDIPropPage.cpp : Implementation of the CFirstSDIPropPage property page class.

#include "stdafx.h"
#include "FirstSDI.h"
#include "FirstSDIPropPage.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


IMPLEMENT_DYNCREATE(CFirstSDIPropPage, COlePropertyPage)



// Message map

BEGIN_MESSAGE_MAP(CFirstSDIPropPage, COlePropertyPage)
END_MESSAGE_MAP()



// Initialize class factory and guid

IMPLEMENT_OLECREATE_EX(CFirstSDIPropPage, "FIRSTSDI.FirstSDIPropPage.1",
	0x8341ad3c, 0xead9, 0x49bf, 0x83, 0x93, 0x27, 0x93, 0x4a, 0x9f, 0x63, 0x57)



// CFirstSDIPropPage::CFirstSDIPropPageFactory::UpdateRegistry -
// Adds or removes system registry entries for CFirstSDIPropPage

BOOL CFirstSDIPropPage::CFirstSDIPropPageFactory::UpdateRegistry(BOOL bRegister)
{
	if (bRegister)
		return AfxOleRegisterPropertyPageClass(AfxGetInstanceHandle(),
			m_clsid, IDS_FIRSTSDI_PPG);
	else
		return AfxOleUnregisterClass(m_clsid, NULL);
}



// CFirstSDIPropPage::CFirstSDIPropPage - Constructor

CFirstSDIPropPage::CFirstSDIPropPage() :
	COlePropertyPage(IDD, IDS_FIRSTSDI_PPG_CAPTION)
{
}



// CFirstSDIPropPage::DoDataExchange - Moves data between page and properties

void CFirstSDIPropPage::DoDataExchange(CDataExchange* pDX)
{
	DDP_PostProcessing(pDX);
}



// CFirstSDIPropPage message handlers
