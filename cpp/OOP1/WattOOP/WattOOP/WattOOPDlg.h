
// WattOOPDlg.h : header file
//

#pragma once


// CWattOOPDlg dialog
class CWattOOPDlg : public CDialogEx
{
// Construction
public:
	CWattOOPDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_WATTOOP_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	//CString m_txtCoinStack100;
	afx_msg void OnEnChangetxtcoinstack100();
	UINT m_txtCoinStack10;
	UINT m_txtCoinStack25;
	UINT m_txtCoinStack5;
	double m_txtCoinStackTotal;
	UINT m_txtCoinsEntered100;
	UINT m_txtCoinsEntered25;
	UINT m_txtCoinsEntered10;
	UINT m_txtCoinsEntered5;
	double x_txtCoinsEnteredTotal;
	UINT m_txtDispenserCola;
	UINT m_txtDispenserDiet;
	UINT m_txtDispenserOrange;
	UINT m_txtDispenserRootBeer;
	double m_txtCoinsEnteredTotal;
	CString m_txtDispenserSlot;
	//CString m_txtDispenserCoinReturn;
	UINT m_txtDispenser100;
	//CString m_txtDispenser25;
	UINT m_txtDispenser5;
	// Representing Pop radio group
	int m_DispenserSelected;
	afx_msg void OnBnClickedcmdcoinsentered100();
	afx_msg void OnBnClickedcmdcoinsentered25();
	afx_msg void OnBnClickedcmdcoinsentered10();
	afx_msg void OnBnClickedcmdcoinsentered5();
	afx_msg void OnBnClickedcmdservicecola();
	afx_msg void OnBnClickedcmdservicediet();
	afx_msg void OnBnClickedcmdserviceorange();
	afx_msg void OnBnClickedcmdserviceroot();
	afx_msg void OnBnClickedcmdservice100();
	UINT m_txtCoinStack100;
	afx_msg void OnBnClickedcmdservice25();
	afx_msg void OnBnClickedcmdservice10();
	afx_msg void OnBnClickedcmdservice5();
	afx_msg void OnBnClickedcmdservicereturn100();
	afx_msg void OnBnClickedcmdservicereturn25();
	afx_msg void OnBnClickedcmdservicereturn10();
	afx_msg void OnBnClickedcmdservicereturn5();
	// Calculate $ amount of contents of CoinStack
	void UpdateCoinStackTotal(void);
	// Calculate Total coins entered by end user
	void UpdateCoinsEnteredTotal(void);
	// Dispense function , used for radio buttons
	int Dispense(void);
	afx_msg void OnBnClickedoptdispensercoinreturn();
	BOOL m_optDispenserSelected;
	//UINT m_txtDispenserCoinReturn;
	double m_txtDispenserCoinReturn;
	afx_msg void OnBnClickedoptdispensercola();
	unsigned int calculateCoinsEntered(void);
	afx_msg void OnBnClickedoptdispenserdietcola();
	afx_msg void OnBnClickedoptdispenserorange();
	afx_msg void OnBnClickedoptdispenserrootbeer();
	void DisableEnable(void);
	BOOL m_chkService;
	afx_msg void OnBnClickedchkservicemachine();
	afx_msg void OnClose();
	UINT m_txtDispenser25;
	UINT m_txtDispenser10;
};
