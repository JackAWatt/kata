// Password.cpp : implementation file
//

#include "stdafx.h"
#include "WattOOP.h"
#include "Password.h"
#include "afxdialogex.h"


// CPassword dialog

IMPLEMENT_DYNAMIC(CPassword, CDialog)

CPassword::CPassword(CWnd* pParent /*=NULL*/)
	: CDialog(CPassword::IDD, pParent)
	, m_txtPassword(_T(""))
{

}

CPassword::~CPassword()
{
}

void CPassword::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_txtPassword, m_txtPassword);
}


BEGIN_MESSAGE_MAP(CPassword, CDialog)
END_MESSAGE_MAP()


// CPassword message handlers
