#pragma once


// CsecondDialog dialog

class CsecondDialog : public CDialogEx
{
	DECLARE_DYNAMIC(CsecondDialog)

public:
	CsecondDialog(CWnd* pParent = NULL);   // standard constructor
	virtual ~CsecondDialog();

// Dialog Data
	enum { IDD = IDD_DIALOG2 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
};
