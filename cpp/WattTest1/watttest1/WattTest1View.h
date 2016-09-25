
// WattTest1View.h : interface of the CWattTest1View class
//

#pragma once


class CWattTest1View : public CView
{
protected: // create from serialization only
	CWattTest1View();
	DECLARE_DYNCREATE(CWattTest1View)

// Attributes
public:
	CWattTest1Doc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// Implementation
public:
	virtual ~CWattTest1View();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in WattTest1View.cpp
inline CWattTest1Doc* CWattTest1View::GetDocument() const
   { return reinterpret_cast<CWattTest1Doc*>(m_pDocument); }
#endif

