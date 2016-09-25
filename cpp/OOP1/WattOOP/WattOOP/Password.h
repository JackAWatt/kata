#pragma once


// CPassword dialog

class CPassword : public CDialog
{
	DECLARE_DYNAMIC(CPassword)

public:
	CPassword(CWnd* pParent = NULL);   // standard constructor
	virtual ~CPassword();

// Dialog Data
	enum { IDD = IDD_Password };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	CString m_txtPassword;
};
