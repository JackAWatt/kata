
// WattTest1View.cpp : implementation of the CWattTest1View class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "WattTest1.h"
#endif

#include "WattTest1Doc.h"
#include "WattTest1View.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CWattTest1View

IMPLEMENT_DYNCREATE(CWattTest1View, CView)

BEGIN_MESSAGE_MAP(CWattTest1View, CView)
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CWattTest1View::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CWattTest1View construction/destruction

CWattTest1View::CWattTest1View()
{
	// TODO: add construction code here

}

CWattTest1View::~CWattTest1View()
{
}

BOOL CWattTest1View::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// CWattTest1View drawing

void CWattTest1View::OnDraw(CDC* /*pDC*/)
{
	CWattTest1Doc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: add draw code for native data here
}


// CWattTest1View printing


void CWattTest1View::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CWattTest1View::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CWattTest1View::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CWattTest1View::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

void CWattTest1View::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CWattTest1View::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CWattTest1View diagnostics

#ifdef _DEBUG
void CWattTest1View::AssertValid() const
{
	CView::AssertValid();
}

void CWattTest1View::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CWattTest1Doc* CWattTest1View::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CWattTest1Doc)));
	return (CWattTest1Doc*)m_pDocument;
}
#endif //_DEBUG


// CWattTest1View message handlers
