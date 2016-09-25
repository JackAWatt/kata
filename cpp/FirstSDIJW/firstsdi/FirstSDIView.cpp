
// FirstSDIView.cpp : implementation of the CFirstSDIView class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "FirstSDI.h"
#endif

#include "FirstSDIDoc.h"
#include "FirstSDIView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CFirstSDIView

IMPLEMENT_DYNCREATE(CFirstSDIView, CView)

BEGIN_MESSAGE_MAP(CFirstSDIView, CView)
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CFirstSDIView::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CFirstSDIView construction/destruction

CFirstSDIView::CFirstSDIView()
{
	// TODO: add construction code here

}

CFirstSDIView::~CFirstSDIView()
{
}

BOOL CFirstSDIView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// CFirstSDIView drawing

void CFirstSDIView::OnDraw(CDC* /*pDC*/)
{
	CFirstSDIDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: add draw code for native data here
}


// CFirstSDIView printing


void CFirstSDIView::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CFirstSDIView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CFirstSDIView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CFirstSDIView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

void CFirstSDIView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CFirstSDIView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CFirstSDIView diagnostics

#ifdef _DEBUG
void CFirstSDIView::AssertValid() const
{
	CView::AssertValid();
}

void CFirstSDIView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CFirstSDIDoc* CFirstSDIView::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CFirstSDIDoc)));
	return (CFirstSDIDoc*)m_pDocument;
}
#endif //_DEBUG


// CFirstSDIView message handlers
