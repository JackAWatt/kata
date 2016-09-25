#pragma once


// CmatchGame dialog

class CmatchGame : public CDialogEx
{
	DECLARE_DYNAMIC(CmatchGame)

public:
	CmatchGame(CWnd* pParent = NULL);   // standard constructor
	virtual ~CmatchGame();

// Dialog Data
	enum { IDD = IDD_MatchGame };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	UINT m_MatchOutput1;
	UINT m_MatchOutput2;
	UINT m_MatchOutput3;
	UINT m_MatchInput1;
	//UINT m_MatchInput;
	UINT m_MatchInput3;
	UINT m_MatchInput;
	BOOL m_chkFreePlay;
	int m_radDollarSelected;
};
