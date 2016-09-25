
// WattOOPDlg.cpp : implementation file
//

#include "stdafx.h"
#include "WattOOP.h"
#include "WattOOPDlg.h"
#include "afxdialogex.h"
#include "Password.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
public:
	void UpdateTotal(void);
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CWattOOPDlg dialog




CWattOOPDlg::CWattOOPDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CWattOOPDlg::IDD, pParent)
	//, m_txtCoinStack100(_T(""))
	, m_txtCoinStack10(0)
	, m_txtCoinStack25(0)
	, m_txtCoinStack5(0)
	, m_txtCoinStackTotal(0)
	, m_txtCoinsEntered100(0)
	, m_txtCoinsEntered25(0)
	, m_txtCoinsEntered10(0)
	, m_txtCoinsEntered5(0)
	//, x_txtCoinsEnteredTotal(_T(""))
	//, m_txtDispenserCola(_T(""))
	, m_txtDispenserCola(0)
	, m_txtDispenserDiet(0)
	, m_txtDispenserOrange(0)
	, m_txtDispenserRootBeer(0)
	, m_txtCoinsEnteredTotal(0)
	, m_txtDispenserSlot(_T(""))
	//, m_txtDispenserCoinReturn(_T(""))
	, m_txtDispenser100(0)
	//, m_txtDispenser25(_T(""))
	, m_txtDispenser5(0)
	, m_DispenserSelected(0)
	, m_txtCoinStack100(0)
	, m_optDispenserSelected(FALSE)
	//, m_txtDispenserCoinReturn(0)
	, m_txtDispenserCoinReturn(0)
	, m_chkService(FALSE)
	, m_txtDispenser25(0)
	, m_txtDispenser10(0)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CWattOOPDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DisableEnable();
	//DDX_Text(pDX, IDC_txtCoinStack100, m_txtCoinStack100);
	DDX_Text(pDX, IDC_txtCoinStack10, m_txtCoinStack10);
	DDX_Text(pDX, IDC_txtCoinStack25, m_txtCoinStack25);
	DDX_Text(pDX, IDC_txtCoinStack5, m_txtCoinStack5);
	DDX_Text(pDX, IDC_txtCoinStackTotal, m_txtCoinStackTotal);
	DDX_Text(pDX, IDC_txtCoinsEntered100, m_txtCoinsEntered100);
	DDX_Text(pDX, IDC_txtCoinsEntered25, m_txtCoinsEntered25);
	DDX_Text(pDX, IDC_txtCoinsEntered10, m_txtCoinsEntered10);
	DDX_Text(pDX, IDC_txtCoinsEntered5, m_txtCoinsEntered5);
	//DDX_Text(pDX, IDC_txtCoinsEnteredTotal, x_txtCoinsEnteredTotal);
	DDX_Text(pDX, IDC_txtDispenserCola, m_txtDispenserCola);
	DDX_Text(pDX, IDC_DispenserDiet, m_txtDispenserDiet);
	DDX_Text(pDX, IDC_DispenserOrange, m_txtDispenserOrange);
	DDX_Text(pDX, IDC_DispenserRootBeer, m_txtDispenserRootBeer);
	DDX_Text(pDX, IDC_txtCoinsEnteredTotal, m_txtCoinsEnteredTotal);
	DDX_Text(pDX, IDC_txtDispenserDispenseSlot, m_txtDispenserSlot);
	//DDX_Text(pDX, IDC_txtDispenserCoinReturn, m_txtDispenserCoinReturn);
	DDX_Text(pDX, IDC_txtDispenser100, m_txtDispenser100);
	//DDX_Text(pDX, IDC_txtDispenser25, m_txtDispenser25);
	DDX_Text(pDX, IDC_txtDispenser5, m_txtDispenser5);
	DDX_Text(pDX, IDC_txtCoinStack100, m_txtCoinStack100);
	DDX_Radio(pDX, IDC_optDispenserCola, m_optDispenserSelected);
	//DDX_Text(pDX, IDC_txtDispenserCoinReturn, m_txtDispenserCoinReturn);
	DDX_Text(pDX, IDC_txtDispenserCoinReturn, m_txtDispenserCoinReturn);
	DDX_Check(pDX, IDC_chkServiceMachine, m_chkService);
	DDX_Text(pDX, IDC_txtDispenser25, m_txtDispenser25);
	DDX_Text(pDX, IDC_txtDispenser10, m_txtDispenser10);
}

BEGIN_MESSAGE_MAP(CWattOOPDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_EN_CHANGE(IDC_txtCoinStack100, &CWattOOPDlg::OnEnChangetxtcoinstack100)
	ON_BN_CLICKED(IDC_cmdCoinsEntered100, &CWattOOPDlg::OnBnClickedcmdcoinsentered100)
	ON_BN_CLICKED(IDC_cmdCoinsEntered25, &CWattOOPDlg::OnBnClickedcmdcoinsentered25)
	ON_BN_CLICKED(IDC_cmdCoinsEntered10, &CWattOOPDlg::OnBnClickedcmdcoinsentered10)
	ON_BN_CLICKED(IDC_cmdCoinsEntered5, &CWattOOPDlg::OnBnClickedcmdcoinsentered5)
	ON_BN_CLICKED(IDC_cmdServiceCola, &CWattOOPDlg::OnBnClickedcmdservicecola)
	ON_BN_CLICKED(IDC_cmdServiceDiet, &CWattOOPDlg::OnBnClickedcmdservicediet)
	ON_BN_CLICKED(IDC_cmdServiceOrange, &CWattOOPDlg::OnBnClickedcmdserviceorange)
	ON_BN_CLICKED(IDC_cmdServiceRoot, &CWattOOPDlg::OnBnClickedcmdserviceroot)
	ON_BN_CLICKED(IDC_cmdService100, &CWattOOPDlg::OnBnClickedcmdservice100)
	ON_BN_CLICKED(IDC_cmdService25, &CWattOOPDlg::OnBnClickedcmdservice25)
	ON_BN_CLICKED(IDC_cmdService10, &CWattOOPDlg::OnBnClickedcmdservice10)
	ON_BN_CLICKED(IDC_cmdService5, &CWattOOPDlg::OnBnClickedcmdservice5)
	ON_BN_CLICKED(IDC_cmdServiceReturn100, &CWattOOPDlg::OnBnClickedcmdservicereturn100)
	ON_BN_CLICKED(IDC_cmdServiceReturn25, &CWattOOPDlg::OnBnClickedcmdservicereturn25)
	ON_BN_CLICKED(IDC_cmdServiceReturn10, &CWattOOPDlg::OnBnClickedcmdservicereturn10)
	ON_BN_CLICKED(IDC_cmdServiceReturn5, &CWattOOPDlg::OnBnClickedcmdservicereturn5)
	ON_BN_CLICKED(IDC_optDispenserCoinReturn, &CWattOOPDlg::OnBnClickedoptdispensercoinreturn)
	ON_BN_CLICKED(IDC_optDispenserCola, &CWattOOPDlg::OnBnClickedoptdispensercola)
	ON_BN_CLICKED(IDC_optDispenserDietCola, &CWattOOPDlg::OnBnClickedoptdispenserdietcola)
	ON_BN_CLICKED(IDC_optDispenserOrange, &CWattOOPDlg::OnBnClickedoptdispenserorange)
	ON_BN_CLICKED(IDC_optDispenserRootBeer, &CWattOOPDlg::OnBnClickedoptdispenserrootbeer)
	ON_BN_CLICKED(IDC_chkServiceMachine, &CWattOOPDlg::OnBnClickedchkservicemachine)
	ON_WM_CLOSE()
END_MESSAGE_MAP()


// CWattOOPDlg message handlers

BOOL CWattOOPDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CWattOOPDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CWattOOPDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CWattOOPDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CWattOOPDlg::OnEnChangetxtcoinstack100()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CWattOOPDlg::OnBnClickedcmdcoinsentered100()
{
	// TODO: Add your control notification handler code here
	m_txtCoinsEntered100++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdcoinsentered25()
{
	// TODO: Add your control notification handler code here
	m_txtCoinsEntered25++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdcoinsentered10()
{
	// TODO: Add your control notification handler code here
	m_txtCoinsEntered10++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdcoinsentered5()
{
	// TODO: Add your control notification handler code here
	m_txtCoinsEntered5++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservicecola()
{
	// TODO: Add your control notification handler code here
	m_txtDispenserCola++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservicediet()
{
	// TODO: Add your control notification handler code here
	m_txtDispenserDiet++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdserviceorange()
{
	// TODO: Add your control notification handler code here
	m_txtDispenserOrange++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdserviceroot()
{
	// TODO: Add your control notification handler code here
	m_txtDispenserRootBeer++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservice100()
{
	// TODO: Add your control notification handler code here
	m_txtCoinStack100++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservice25()
{
	// TODO: Add your control notification handler code here
	m_txtCoinStack25++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservice10()
{
	// TODO: Add your control notification handler code here
	m_txtCoinStack10++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservice5()
{
	// TODO: Add your control notification handler code here
	m_txtCoinStack5++;
	UpdateData(FALSE);
}


void CWattOOPDlg::OnBnClickedcmdservicereturn100()
{
	// TODO: Add your control notification handler code here
	if (m_txtCoinStack100 > 0) {
		m_txtCoinStack100--;
		UpdateData(FALSE);
	}
}


void CWattOOPDlg::OnBnClickedcmdservicereturn25()
{
	// TODO: Add your control notification handler code here
	if (m_txtCoinStack25 > 0) {
		m_txtCoinStack25--;
		UpdateData(FALSE);
	}
}


void CWattOOPDlg::OnBnClickedcmdservicereturn10()
{
	// TODO: Add your control notification handler code here
	if (m_txtCoinStack10 > 0) {
		m_txtCoinStack10--;
		UpdateData(FALSE);
	}
}


void CWattOOPDlg::OnBnClickedcmdservicereturn5()
{
	// TODO: Add your control notification handler code here
	
	if (m_txtCoinStack5 > 0) {
		m_txtCoinStack5--;
		UpdateData(FALSE);

	}
}


// Calculate $ amount of contents of CoinStack
void CWattOOPDlg::UpdateCoinStackTotal(void)
{
}


// Calculate Total coins entered by end user
void CWattOOPDlg::UpdateCoinsEnteredTotal(void)
{
}


// Dispense function , used for radio buttons
//IN: none
//OUT: none
//DOES: Dispense pop, caluclate returns
int CWattOOPDlg::Dispense(void)
{

	enum ACTION { COLA, DIET, ORANGE, ROOT, COINRETURN } ButtonPressed;
	ButtonPressed = (ACTION) m_optDispenserSelected;
	
			

	if ( calculateCoinsEntered() > 105 && ButtonPressed != 4) {

		MessageBox("Exact change only, please." , "Sorry!", MB_ICONSTOP);
		ButtonPressed= COINRETURN;



	}



		if ( ButtonPressed == COINRETURN ) {
			//move all CoinEntered fields to CoinReturn fields
			m_txtDispenserCoinReturn = 0;
			m_txtDispenserCoinReturn += m_txtCoinsEntered10 * 10;
			m_txtDispenserCoinReturn += m_txtCoinsEntered100 * 100;
			m_txtDispenserCoinReturn += m_txtCoinsEntered25 * 25;
			m_txtDispenserCoinReturn += m_txtCoinsEntered5 * 5;

			m_txtDispenser10 = m_txtCoinsEntered5;
			m_txtDispenser100 = m_txtCoinsEntered100;
			m_txtDispenser25 = m_txtCoinsEntered25;
			m_txtDispenser5 = m_txtCoinsEntered5;
			//Calculate the $$$ value of the CoinReturn fields
			m_txtDispenserCoinReturn /= 100;
			//set all CoinEntered fields to zeros
			m_txtCoinsEntered100 = 0;
			m_txtCoinsEntered25 = 0;
			m_txtCoinsEntered10 = 0;
			m_txtCoinsEntered5 = 0;

			UpdateData(FALSE);
			return 0;
		}

		
		if (calculateCoinsEntered() < 105) {

			MessageBox(	"Insufficient funds entered." , "Sorry!" , MB_ICONSTOP );
			UpdateData(FALSE);

		}
		if ( ButtonPressed == COLA && m_txtDispenserCola == 0) {
			MessageBox( "None available. Try another selection." , "Sorry!", MB_ICONSTOP);
			UpdateData(FALSE);

		} 	

		if ( ButtonPressed == DIET && m_txtDispenserDiet == 0) {
			MessageBox( "None available. Try another selection." , "Sorry!", MB_ICONSTOP);
			UpdateData(FALSE);

		}

		if ( ButtonPressed == ORANGE && m_txtDispenserOrange == 0) {
			MessageBox( "None available. Try another selection." , "Sorry!", MB_ICONSTOP);
			UpdateData(FALSE);

		}

		if ( ButtonPressed == ROOT && m_txtDispenserRootBeer == 0) {
			MessageBox( "None available. Try another selection." , "Sorry!", MB_ICONSTOP);
			UpdateData(FALSE);

		}

		if ( ButtonPressed == COLA && m_txtDispenserCola > 0 && calculateCoinsEntered() == 105) {
			m_txtCoinStack10 += m_txtCoinsEntered10;
			m_txtCoinStack100 += m_txtCoinsEntered100;
			m_txtCoinStack25 += m_txtCoinsEntered25;
			m_txtCoinStack5 += m_txtCoinsEntered5;
			m_txtCoinsEntered10 = 0;
			m_txtCoinsEntered100 = 0;
			m_txtCoinsEntered25 = 0;
			m_txtCoinsEntered5 = 0;
			m_txtDispenserCola--;
			if (m_txtDispenserCoinReturn != 0){
			m_txtDispenserSlot = "Klunk";
			}
			UpdateData(FALSE);

		}

		if ( ButtonPressed == DIET && m_txtDispenserDiet > 0 && calculateCoinsEntered() == 105) {
			m_txtCoinStack10 += m_txtCoinsEntered10;
			m_txtCoinStack100 += m_txtCoinsEntered100;
			m_txtCoinStack25 += m_txtCoinsEntered25;
			m_txtCoinStack5 += m_txtCoinsEntered5;
			m_txtCoinsEntered10 = 0;
			m_txtCoinsEntered100 = 0;
			m_txtCoinsEntered25 = 0;
			m_txtCoinsEntered5 = 0;
			m_txtDispenserDiet--;
			if (m_txtDispenserCoinReturn != 0){
			m_txtDispenserSlot = "Klunk";
			}
			UpdateData(FALSE);

		}

		if ( ButtonPressed == ORANGE && m_txtDispenserOrange > 0 && calculateCoinsEntered() == 105) {
			m_txtCoinStack10 += m_txtCoinsEntered10;
			m_txtCoinStack100 += m_txtCoinsEntered100;
			m_txtCoinStack25 += m_txtCoinsEntered25;
			m_txtCoinStack5 += m_txtCoinsEntered5;
			m_txtCoinsEntered10 = 0;
			m_txtCoinsEntered100 = 0;
			m_txtCoinsEntered25 = 0;
			m_txtCoinsEntered5 = 0;
			m_txtDispenserOrange--;
			if (m_txtDispenserCoinReturn != 0){
			m_txtDispenserSlot = "Klunk";
			}
			UpdateData(FALSE);

		}

		if ( ButtonPressed == ROOT && m_txtDispenserRootBeer > 0 && calculateCoinsEntered() == 105) {
			m_txtCoinStack10 += m_txtCoinsEntered10;
			m_txtCoinStack100 += m_txtCoinsEntered100;
			m_txtCoinStack25 += m_txtCoinsEntered25;
			m_txtCoinStack5 += m_txtCoinsEntered5;
			m_txtCoinsEntered10 = 0;
			m_txtCoinsEntered100 = 0;
			m_txtCoinsEntered25 = 0;
			m_txtCoinsEntered5 = 0;
			m_txtDispenserRootBeer--;
			if (m_txtDispenserCoinReturn != 0){
			m_txtDispenserSlot = "Klunk";
			}
			UpdateData(FALSE);

		}


}


void CWattOOPDlg::OnBnClickedoptdispensercoinreturn()
{
	
	m_optDispenserSelected=4;
	Dispense();
	

	// TODO: Add your control notification handler code here
}


void CWattOOPDlg::OnBnClickedoptdispensercola()
{
	m_optDispenserSelected=0;
	Dispense();
	// TODO: Add your control notification handler code here
}


unsigned int CWattOOPDlg::calculateCoinsEntered(void)
{
	UINT total = 0;
	total += m_txtCoinsEntered10 * 10;
	total += m_txtCoinsEntered100 * 100;
	total += m_txtCoinsEntered25 * 25;
	total += m_txtCoinsEntered5 * 5;
	return total;
}


void CWattOOPDlg::OnBnClickedoptdispenserdietcola()
{
	m_optDispenserSelected=1;
	Dispense();
	// TODO: Add your control notification handler code here
}


void CWattOOPDlg::OnBnClickedoptdispenserorange()
{
	m_optDispenserSelected=2;
	Dispense();
	// TODO: Add your control notification handler code here
}


void CWattOOPDlg::OnBnClickedoptdispenserrootbeer()
{
	m_optDispenserSelected=3;
	Dispense();
	// TODO: Add your control notification handler code here
}

//DisableEnable
//used to enable and disable controls on form
//IN: none
//OUT: none
void CWattOOPDlg::DisableEnable(void)
{
	


	if (m_txtDispenserCola > 0) {
		GetDlgItem(IDC_optDispenserCola)->EnableWindow(TRUE);
	}
	else if (m_txtDispenserCola == 0) {
		GetDlgItem(IDC_optDispenserCola)->EnableWindow(FALSE);
	}
	
	if (m_txtDispenserDiet > 0) {
		GetDlgItem(IDC_optDispenserDietCola)->EnableWindow(TRUE);

	}
	else if(m_txtDispenserDiet == 0) {
		GetDlgItem(IDC_optDispenserDietCola)->EnableWindow(FALSE);

	}

	if (m_txtDispenserOrange > 0 ) {
		GetDlgItem(IDC_optDispenserOrange)->EnableWindow(TRUE);


	}
	else if (m_txtDispenserOrange == 0 ) {
		GetDlgItem(IDC_optDispenserOrange)->EnableWindow(FALSE);


	}

	if (m_txtDispenserRootBeer > 0 ) {
		GetDlgItem(IDC_optDispenserRootBeer)->EnableWindow(TRUE);


	}
	else if (m_txtDispenserRootBeer == 0) {
		GetDlgItem(IDC_optDispenserRootBeer)->EnableWindow(FALSE);

	}

	if (m_txtCoinStack100 > 0) {
		GetDlgItem(IDC_cmdServiceReturn100)->EnableWindow(TRUE);


	}
	else if (m_txtCoinStack100 == 0) {
		GetDlgItem(IDC_cmdServiceReturn100)->EnableWindow(FALSE);


	}

		if (m_txtCoinStack10 > 0) {
		GetDlgItem(IDC_cmdServiceReturn10)->EnableWindow(TRUE);


	}
	else if (m_txtCoinStack10 == 0) {
		GetDlgItem(IDC_cmdServiceReturn10)->EnableWindow(FALSE);


	}

		if (m_txtCoinStack25 > 0) {
		GetDlgItem(IDC_cmdServiceReturn25)->EnableWindow(TRUE);


	}
	else if (m_txtCoinStack25 == 0) {
		GetDlgItem(IDC_cmdServiceReturn25)->EnableWindow(FALSE);


	}

		if (m_txtCoinStack5 > 0) {
		GetDlgItem(IDC_cmdServiceReturn5)->EnableWindow(TRUE);


	}
	else if (m_txtCoinStack5 == 0) {
		GetDlgItem(IDC_cmdServiceReturn5)->EnableWindow(FALSE);


	}


	
	GetDlgItem(IDC_txtCoinsEntered10)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinsEntered100)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinsEntered25)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinsEntered5)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinsEnteredTotal)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinStack10)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinStack100)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinStack25)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinStack5)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtCoinStackTotal)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenser100)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenser10)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenser25)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenser5)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenserCoinReturn)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenserDispenseSlot)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenserCola)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenserDiet)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenserOrange)->EnableWindow(FALSE);
	GetDlgItem(IDC_txtDispenserRootBeer)->EnableWindow(FALSE);

		if (m_chkService == FALSE) {


		GetDlgItem(IDC_txtCoinStack10)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_txtCoinStack100)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_txtCoinStack25)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_txtCoinStack5)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_txtCoinStackTotal)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_lblCoinStack)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_grpCoinStacks)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cboServicePopPrice)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdService10)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdService100)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdService5)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdService25)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceCola)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceDiet)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceOrange)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceRoot)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceReturn10)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceReturn100)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceReturn25)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_cmdServiceReturn5)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_lstServicePopSold)->ShowWindow(SW_HIDE);
		GetDlgItem(IDC_grpService)->ShowWindow(SW_HIDE);
		
	} else {


		GetDlgItem(IDC_txtCoinStack10)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_txtCoinStack100)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_txtCoinStack25)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_txtCoinStack5)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_txtCoinStackTotal)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_lblCoinStack)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_grpCoinStacks)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cboServicePopPrice)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdService10)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdService100)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdService25)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdService5)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceCola)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceDiet)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceOrange)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceRoot)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceReturn10)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceReturn100)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceReturn25)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_cmdServiceReturn5)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_lstServicePopSold)->ShowWindow(SW_SHOW);
		GetDlgItem(IDC_grpService)->ShowWindow(SW_SHOW);

	}


	m_txtCoinsEnteredTotal = ((m_txtCoinsEntered10 * 10) + (m_txtCoinsEntered100 * 100)  
		+ (m_txtCoinsEntered25 * 25) + (m_txtCoinsEntered5 * 5) ) / 100.0;

	m_txtCoinStackTotal = ((m_txtCoinStack10 * 10) + (m_txtCoinStack100 * 100) 
		+ (m_txtCoinStack25 * 25) + (m_txtCoinStack5 * 5)) / 100.0;

		
		
}


void CWattOOPDlg::OnBnClickedchkservicemachine()
{
	
	int Result;
	CPassword PW;

	if (m_chkService == FALSE) {
		Result = PW.DoModal();

		if (PW.m_txtPassword != "Password" && PW.m_txtPassword != "") {
			MessageBox(	"Incorrect Password!", "Security Violation" , MB_ICONSTOP );
			m_chkService=FALSE;
			UpdateData(FALSE);

		}
		else if (PW.m_txtPassword == "") {
			m_chkService=FALSE;
			UpdateData(FALSE);
			
		}
		else {m_chkService = !m_chkService;}
	}
		else if (m_chkService == TRUE) {


		m_chkService = !m_chkService;

	}
	
	UpdateData(TRUE);

	// TODO: Add your control notification handler code here
}


void CWattOOPDlg::OnClose()
{
	// TODO: Add your message handler code here and/or call default
	int Result;

	Result = MessageBox("Thanks for your patronage!\nAre you sure you want to exit?" 
		, "Orville Says...", MB_ICONQUESTION | MB_YESNO |MB_DEFBUTTON2);

	if (Result == IDYES) { CDialog::OnClose();}
	
	
}


void CAboutDlg::UpdateTotal(void)
{

}
