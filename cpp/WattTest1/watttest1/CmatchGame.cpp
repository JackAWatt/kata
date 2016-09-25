// CmatchGame.cpp : implementation file
//

#include "stdafx.h"
#include "WattTest1.h"
#include "CmatchGame.h"
#include "afxdialogex.h"


// CmatchGame dialog

IMPLEMENT_DYNAMIC(CmatchGame, CDialogEx)

CmatchGame::CmatchGame(CWnd* pParent /*=NULL*/)
	: CDialogEx(CmatchGame::IDD, pParent)
	, m_MatchOutput1(0)
	, m_MatchOutput2(0)
	, m_MatchOutput3(0)
	, m_MatchInput1(0)
	, //m_MatchInput(0)
	, m_MatchInput3(0)
	, m_MatchInput(0)
	, m_chkFreePlay(FALSE)
	, m_radDollarSelected(0)
{

}

CmatchGame::~CmatchGame()
{
}

void CmatchGame::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_txtMatchOutput1, m_MatchOutput1);
	DDX_Text(pDX, IDC_txtMatchOutput2, m_MatchOutput2);
	DDX_Text(pDX, IDC_txtMatchOutput3, m_MatchOutput3);
	DDX_Text(pDX, IDC_txtMatchInput1, m_MatchInput1);
	//DDX_Text(pDX, IDC_txtMatchInput2, m_MatchInput);
	DDX_Text(pDX, IDC_txtMatchInput3, m_MatchInput3);
	DDX_Text(pDX, IDC_txtMatchInput2, m_MatchInput);
	DDX_Check(pDX, IDC_chkFreePlay, m_chkFreePlay);
	DDX_Radio(pDX, IDC_radOneDollar, m_radDollarSelected);
}


BEGIN_MESSAGE_MAP(CmatchGame, CDialogEx)
END_MESSAGE_MAP()


// CmatchGame message handlers
