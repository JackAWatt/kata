// ClientProfile.cpp : implementation file
//

#include "stdafx.h"
#include "FirstSDI.h"
#include "ClientProfile.h"
#include "afxdialogex.h"


// CClientProfile dialog

IMPLEMENT_DYNAMIC(CClientProfile, CDialogEx)

CClientProfile::CClientProfile(CWnd* pParent /*=NULL*/)
	: CDialogEx(CClientProfile::IDD, pParent)
	, m_txtFirstName(_T(""))
	, m_txtLastName(_T(""))
//	, IDC_radSelected(0)
, m_radSelected(0)
//, m_radSelected(FALSE)
, m_chkCPlusPlus(FALSE)
, m_chkVisualBasic(FALSE)
, m_chkCOBOL(FALSE)
, m_chkJava(FALSE)
, m_chkHex(FALSE)
, m_cboFavouriteCourse(CB_ERR)
{

}

CClientProfile::~CClientProfile()
{
}

void CClientProfile::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_txtFirstName, m_txtFirstName);
	DDX_Text(pDX, IDC_txtLastName, m_txtLastName);
	//DDX_Radio(pDX, IDC_radEnglish, IDC_radSelected);
	DDX_Radio(pDX, IDC_radEnglish, m_radSelected);
	//DDX_Radio(pDX, IDC_radEnglish, m_radSelected);
	DDX_Check(pDX, IDC_chkCPlusPlus, m_chkCPlusPlus);
	DDX_Check(pDX, IDC_chkVisualBasic, m_chkVisualBasic);
	DDX_Check(pDX, IDC_chkCOBOL, m_chkCOBOL);
	DDX_Check(pDX, IDC_chkJava, m_chkJava);
	DDX_Check(pDX, IDC_chkHex, m_chkHex);
	DDX_CBIndex(pDX, IDC_cboFavouriteCourse, m_cboFavouriteCourse);
}


BEGIN_MESSAGE_MAP(CClientProfile, CDialogEx)
	ON_CBN_SELCHANGE(IDC_cboFavouriteCourse, &CClientProfile::OnCbnSelchangecbofavouritecourse)
END_MESSAGE_MAP()


// CClientProfile message handlers


void CClientProfile::OnCbnSelchangecbofavouritecourse()
{

	m_cboFavouriteCourse = (int)SendDlgItemMessage(IDC_cboFavouriteCourse, CB_GETCURSEL, 0, 0);
	// TODO: Add your control notification handler code here
}
