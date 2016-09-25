
// FirstSDI.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "afxwinappex.h"
#include "afxdialogex.h"
#include "FirstSDI.h"
#include "MainFrm.h"

#include "FirstSDIDoc.h"
#include "FirstSDIView.h"
#include "ClientProfile.h"
#include "CsecondDialog.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#endif




// CFirstSDIApp

BEGIN_MESSAGE_MAP(CFirstSDIApp, CWinAppEx)
	ON_COMMAND(ID_APP_ABOUT, &CFirstSDIApp::OnAppAbout)
	// Standard file based document commands
	ON_COMMAND(ID_FILE_NEW, &CWinAppEx::OnFileNew)
	ON_COMMAND(ID_FILE_OPEN, &CWinAppEx::OnFileOpen)
	// Standard print setup command
	ON_COMMAND(ID_FILE_PRINT_SETUP, &CWinAppEx::OnFilePrintSetup)
END_MESSAGE_MAP()


// CFirstSDIApp construction

CFirstSDIApp::CFirstSDIApp()
{
	m_bHiColorIcons = TRUE;

	// support Restart Manager
	m_dwRestartManagerSupportFlags = AFX_RESTART_MANAGER_SUPPORT_ALL_ASPECTS;
#ifdef _MANAGED
	// If the application is built using Common Language Runtime support (/clr):
	//     1) This additional setting is needed for Restart Manager support to work properly.
	//     2) In your project, you must add a reference to System.Windows.Forms in order to build.
	System::Windows::Forms::Application::SetUnhandledExceptionMode(System::Windows::Forms::UnhandledExceptionMode::ThrowException);
#endif

	// TODO: replace application ID string below with unique ID string; recommended
	// format for string is CompanyName.ProductName.SubProduct.VersionInformation
	SetAppID(_T("FirstSDI.AppID.NoVersion"));

	// TODO: add construction code here,
	// Place all significant initialization in InitInstance
}

// The one and only CFirstSDIApp object

CFirstSDIApp theApp;


// CFirstSDIApp initialization

BOOL CFirstSDIApp::InitInstance()
{
	// InitCommonControlsEx() is required on Windows XP if an application
	// manifest specifies use of ComCtl32.dll version 6 or later to enable
	// visual styles.  Otherwise, any window creation will fail.
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// Set this to include all the common control classes you want to use
	// in your application.
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinAppEx::InitInstance();


	// Initialize OLE libraries
	if (!AfxOleInit())
	{
		AfxMessageBox(IDP_OLE_INIT_FAILED);
		return FALSE;
	}

	AfxEnableControlContainer();

	EnableTaskbarInteraction(FALSE);

	// AfxInitRichEdit2() is required to use RichEdit control	
	// AfxInitRichEdit2();

	// Standard initialization
	// If you are not using these features and wish to reduce the size
	// of your final executable, you should remove from the following
	// the specific initialization routines you do not need
	// Change the registry key under which our settings are stored
	// TODO: You should modify this string to be something appropriate
	// such as the name of your company or organization
	SetRegistryKey(_T("Local AppWizard-Generated Applications"));
	LoadStdProfileSettings(4);  // Load standard INI file options (including MRU)


	InitContextMenuManager();

	InitKeyboardManager();

	InitTooltipManager();
	CMFCToolTipInfo ttParams;
	ttParams.m_bVislManagerTheme = TRUE;
	theApp.GetTooltipManager()->SetTooltipParams(AFX_TOOLTIP_TYPE_ALL,
		RUNTIME_CLASS(CMFCToolTipCtrl), &ttParams);

	// Register the application's document templates.  Document templates
	//  serve as the connection between documents, frame windows and views
	CSingleDocTemplate* pDocTemplate;
	pDocTemplate = new CSingleDocTemplate(
		IDR_MAINFRAME,
		RUNTIME_CLASS(CFirstSDIDoc),
		RUNTIME_CLASS(CMainFrame),       // main SDI frame window
		RUNTIME_CLASS(CFirstSDIView));
	if (!pDocTemplate)
		return FALSE;
	AddDocTemplate(pDocTemplate);


	// Parse command line for standard shell commands, DDE, file open
	CCommandLineInfo cmdInfo;
	ParseCommandLine(cmdInfo);



	// Dispatch commands specified on the command line.  Will return FALSE if
	// app was launched with /RegServer, /Register, /Unregserver or /Unregister.
	if (!ProcessShellCommand(cmdInfo))
		return FALSE;

	// The one and only window has been initialized, so show and update it
	m_pMainWnd->ShowWindow(SW_SHOW);
	m_pMainWnd->UpdateWindow();

	//enum ACTION { COLA, DIET, ORANGE, ROOT} ButtonPressed;
	//ButtonPressed = (ACTION) m_radSelected;

	CClientProfile dlg;
	//set initial information for form
	dlg.m_txtLastName = "Watt";
	dlg.m_txtFirstName = "Jack";
	dlg.m_radSelected = 2;
	dlg.m_chkCPlusPlus = 1;
	dlg.m_chkHex = 1;
	BOOL selectedTrue = 0;
	//when user selects OK it gives them the information entered in a message box
	if ( dlg.DoModal() == IDOK ) {
		CString Msg=" ";
		Msg += "\nYour First Name is ";
		Msg += dlg.m_txtFirstName;
		Msg += "\nYour Last Name is ";
		Msg += dlg.m_txtLastName;
		Msg += "\nYour favourite Computer Languages are ";
		if (dlg.m_chkCOBOL) {
			Msg += "COBOL";
			selectedTrue = 1;
		}
		//checks all check boxes. Adds any to the message that are checked
		if (dlg.m_chkCPlusPlus) {
			Msg += "\nC++";
			selectedTrue = 1;

		}
		if (dlg.m_chkHex) {
			Msg += "\nHex!";
			selectedTrue = 1;

		}
		if (dlg.m_chkJava) {
			Msg += "\nJava";
			selectedTrue = 1;

		}
		if (dlg.m_chkVisualBasic) {
			Msg += "\nVisual Basic";
			selectedTrue = 1;

		}
		//given no checkboxes are checked it adds a message to the user
		//was going to just not mention at all, but figured it would be 
		//better to notify the user they entered nothing for this part
		if (!selectedTrue) {
			Msg += "None selected";


		}
		
		Msg += "\nLanguage Preference";
		if (dlg.m_radSelected = 0) {
			Msg += "\nEnglish";

		}
		else if (dlg.m_radSelected = 1) {
			Msg += "\nFrancais";

		}
		else if (dlg.m_radSelected = 2) {
			Msg += "\nEspanol";

		}
		Msg += "\nFavourite Course is ";
		switch (dlg.m_cboFavouriteCourse) {
			case 0 :    Msg += "Android"; break;
			case 1 :    Msg += "C++"; break;
			case 2 :    Msg += "C++ ADT"; break;
			case 3 :    Msg += "DB Design"; break;
			case 4 :    Msg += "ISDP"; break;
			case 5 :    Msg += "Java"; break;
			case 6 :    Msg += "OOAD"; break;
			case 7 :    Msg += "PL SQL"; break;
			case 8 :    Msg += "SQL"; break;
			case 9 :    Msg += "Systems"; break;
			case 10 :    Msg += "Unix"; break;
			default:    Msg += "*none*"; break;


		}





		AfxMessageBox(Msg);
	}
	else {
		AfxMessageBox("You clicked CANCEL");
	}

	CsecondDialog dlgSecond;
	//prompts end user with dialog, gives them cool messages depending which control they click
	if (dlg.DoModal() == IDOK ) {
		AfxMessageBox("Hey Dude, having fun?");

	}
	else {
		AfxMessageBox("Later Instructor dude");


	}
	// call DragAcceptFiles only if there's a suffix
	//  In an SDI app, this should occur after ProcessShellCommand
	return TRUE;
}

int CFirstSDIApp::ExitInstance()
{
	//TODO: handle additional resources you may have added
	AfxOleTerm(FALSE);

	return CWinAppEx::ExitInstance();
}

// CFirstSDIApp message handlers


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

// App command to run the dialog
void CFirstSDIApp::OnAppAbout()
{
	CAboutDlg aboutDlg;
	aboutDlg.DoModal();
}

// CFirstSDIApp customization load/save methods

void CFirstSDIApp::PreLoadState()
{
	BOOL bNameValid;
	CString strName;
	bNameValid = strName.LoadString(IDS_EDIT_MENU);
	ASSERT(bNameValid);
	GetContextMenuManager()->AddMenu(strName, IDR_POPUP_EDIT);
	bNameValid = strName.LoadString(IDS_EXPLORER);
	ASSERT(bNameValid);
	GetContextMenuManager()->AddMenu(strName, IDR_POPUP_EXPLORER);
}

void CFirstSDIApp::LoadCustomState()
{
}

void CFirstSDIApp::SaveCustomState()
{
}

// CFirstSDIApp message handlers



