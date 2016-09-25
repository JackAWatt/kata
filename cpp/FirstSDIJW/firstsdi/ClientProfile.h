#pragma once


// CClientProfile dialog

class CClientProfile : public CDialogEx
{
	DECLARE_DYNAMIC(CClientProfile)

public:
	CClientProfile(CWnd* pParent = NULL);   // standard constructor
	virtual ~CClientProfile();

// Dialog Data
	enum { IDD = IDD_DIALOG1 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	CString m_txtFirstName;
	CString m_txtLastName;
	//int IDC_radSelected;
	int m_radSelected;
	//BOOL m_radSelected;
	BOOL m_chkCPlusPlus;
	BOOL m_chkVisualBasic;
	BOOL m_chkCOBOL;
	BOOL m_chkJava;
	BOOL m_chkHex;
	int m_cboFavouriteCourse;
	afx_msg void OnCbnSelchangecbofavouritecourse();
};
