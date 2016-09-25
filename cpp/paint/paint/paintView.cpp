
// paintView.cpp : implementation of the CpaintView class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "paint.h"
#endif

#include "paintDoc.h"
#include "paintView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CpaintView
enum { Fonts, Pens, Brushes } m_ToolToUse;
IMPLEMENT_DYNCREATE(CpaintView, CView)

BEGIN_MESSAGE_MAP(CpaintView, CView)
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CpaintView::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
	ON_WM_LBUTTONDOWN()
	ON_WM_RBUTTONDOWN()
	ON_WM_KEYDOWN()
END_MESSAGE_MAP()

// CpaintView construction/destruction

CpaintView::CpaintView()
{
	// TODO: add construction code here
	m_ToolToUse = Fonts;  // Same as m_ToolToUse = 0;

}

CpaintView::~CpaintView()
{
}

BOOL CpaintView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// CpaintView drawing

void CpaintView::OnDraw(CDC* pDC)
{
	CpaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	  // TODO: add draw code for native data here 
  // Instead of putting all the code in OnDraw, we will compartmentalize it 
  // into three new methods.  Note the passing of the Device Context. 
   switch (m_ToolToUse) { 
    case Fonts:  ShowFonts(pDC);   break; 
    case Pens:  ShowPens(pDC);   break; 
    case Brushes: ShowBrushes(pDC);   break; 
  } 

	// TODO: add draw code for native data here
}


// CpaintView printing


void CpaintView::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CpaintView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CpaintView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CpaintView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

void CpaintView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	//ClientToScreen(&point);
	//OnContextMenu(this, point);
}

void CpaintView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CpaintView diagnostics

#ifdef _DEBUG
void CpaintView::AssertValid() const
{
	CView::AssertValid();
}

void CpaintView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CpaintDoc* CpaintView::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CpaintDoc)));
	return (CpaintDoc*)m_pDocument;
}
#endif //_DEBUG


// CpaintView message handlers


			void CpaintView::ShowFonts(CDC* pDC) 
			{  // Output some text using the "default font" 
			 pDC->TextOut(20,0, "I'm in ShowFonts with default font"); 
			// Save the "default font" 
			 CFont* pMyOldFont = pDC->GetCurrentFont(); 
			// Save the "default text color" 
			 COLORREF MyOldColor = pDC->GetTextColor(); 
			// LOGFONT is a structure that contains all the attributes for your new font 
			// For detailed info on all the attributes, see on-line help 
			 LOGFONT MyNewLogFont; 
  
			 MyNewLogFont.lfCharSet=ANSI_CHARSET; 
			strcpy( MyNewLogFont.lfFaceName, "Times New Roman" ); // Try another font 
  
			 MyNewLogFont.lfHeight=30;      // Try 60 
			 MyNewLogFont.lfWidth=0;       // Try 200 
			 MyNewLogFont.lfEscapement=0;      // Try -200 
  
			 MyNewLogFont.lfWeight=FW_NORMAL;     // Try FW_BOLD, FW_ULTRALIGHT 
			 MyNewLogFont.lfItalic=0;      // Try 1 
			 MyNewLogFont.lfUnderline=0;      // Try 1 
			 MyNewLogFont.lfStrikeOut=0;      // Try 1    
   
			// Allocate a variable for my new font
			CFont MyNewFont; 
			// CREATE THE NEW FONT using the attributes set up in the LOGFONT structure
			 MyNewFont.CreateFontIndirect(&MyNewLogFont); 
			// These will be used to change the font color inside the loop
			//int Red=100, Green=100, Blue=100; 
			 COLORREF MyNewColor; 
  
			// Display text using our old and new fonts...  
			 UINT i, position=0; 
			for (i=0; i<8; i++) {   
				// Allocate a variable for my new font
				CFont MyNewFont; 
				// CREATE THE NEW FONT using the attributes set up in the LOGFONT structure
				MyNewLogFont.lfHeight=30 - (i*3);
				MyNewFont.CreateFontIndirect(&MyNewLogFont); 

	
				//MyNewFont.CreateObject(MyNewLogFont);
			   // Switching between fonts 
			   if (i%2) pDC->SelectObject(&MyNewFont);   // Why & used here…   
			   else  pDC->SelectObject(pMyOldFont);  // …but not here??
			// You *can’t* change the attributes, such as size, of an existing font,  
			// *but* you can change the color
			   
			   //cycles through 3 colors
			   //first is red
			   if (i%3 == 0) { MyNewColor = RGB(255,0,0);}
			   //second is green
			   if (i%3 == 1) { MyNewColor = RGB(0,255,0);}
			   //third is blue
			   if (i%3 == 2) { MyNewColor = RGB(0,0,255);}
				//MyNewColor = RGB(Red+=10,Green+=20,Blue+=30); 
			  pDC->SetTextColor(MyNewColor); 
   
			  pDC->TextOutA(20,position+=40, "My Name is Jack Watt"); 
			 } 
			// Make sure you're back to the default font now that you're done 
			 pDC->SelectObject(pMyOldFont); 
			 pDC->SetTextColor(MyOldColor); 
			 pDC->TextOutA(20,position+=60, "I'm leaving ShowFonts with default font"); 
			}


void CpaintView::ShowPens(CDC* pDC) 
{  
	// Draw a line using the "default pen" 
 //pDC->MoveTo(20,10); 
 //pDC->LineTo(400,10); 
// Save the "default pen" 
 CPen* pMyOldPen = pDC->GetCurrentPen(); 
  
// 1) Create a "new pen" inside the scope of the "for loop", 
// 2) Use the "new pen" 
// 3) Destroy the "new pen" at the end of each loop iteration 
 UINT i, position = 20; 
for (i=0; i<10; i++) { 
   int red = 0 , green = 0, blue = 0;
// 1) Create a pen, varying the size (param 1) and the color (param 2) 
	if (i%3 == 0) { red = 255;}
	else if (i%3 == 1) { green = 255; }
	else { blue = 255;  }
  CPen MyNewPen(PS_SOLID, 7, RGB(red,green,blue));
// Instead of the above, try... 
  // LOGBRUSH logBrush; 
//logBrush.lbStyle = BS_SOLID; 
//logBrush.lbColor = RGB(0+(i*30),0+(i*15),0+(i*5)); 
//CPen MyNewPen (PS_DASHDOT|PS_GEOMETRIC|PS_ENDCAP_ROUND, i*2+1, &logBrush);
// 2) Use   

//{
//pDC->SelectObject(&MyNewPen); 
//pDC->MoveTo(i*14,i*14);
//	pDC->LineTo(470-i*14, i*14);
//	pDC->LineTo(470-i*14, 470-i*14);
//	pDC->LineTo(i*14,470-i*14);
//		
//	pDC->LineTo(i*14,i*14);
//}

    {
pDC->SelectObject(&MyNewPen); 
	pDC->MoveTo(i*9,i*9);
	
	//pDC->LineTo(470+i*7,470-i*7);
	pDC->LineTo(470-i*9, i*9);
	//pDC->LineTo(470+i*7,470-i*7);
	pDC->LineTo(470-i*9, 470-i*9);
	//pDC->LineTo(470+i*7,470-i*7);
	pDC->LineTo(i*9,470-i*9);
	//pDC->LineTo(470+i*7,470-i*7);	
	pDC->LineTo(i*9,i*9);
	//pDC->LineTo(470+i*7,470-i*7);
	//pDC->MoveTo((i*9)+9, (i*9)+9);
	//pDC->LineTo(470-(i*9)+9,(i*9)+9);
	//pDC->MoveTo(10+i*9,10+i*9);
	//pDC->LineTo((96-470)-i^3,96);
  }
	pDC->MoveTo((i*9)+9, (i*9)+9);
	
//	pDC->Rectangle( i+10+i, i+10+i, i+80+i, i+20+i ); 
//	pDC->Draw3dRect(10,20,30,40,255,37);
//  pDC->MoveTo(20,position); 
 // pDC->LineTo(400,position); 

 /* pDC->MoveTo(100 + ( i * 7),100 + ( i * 7));
  pDC->LineTo(100 - ( i * 7),400 + ( i * 7));
  pDC->LineTo(400 - ( i * 7),400 - ( i * 7));
  pDC->LineTo(400 + ( i * 7),100 - ( i * 7));
  pDC->LineTo(100 + ( i * 7),100 + ( i * 7));*/
//  position += i*2+10; 
//   
 } // 3) Destroy the pen created inside the loop 

CPen MyNewPen(PS_SOLID, 8, RGB(128,0,32));
	pDC->SelectObject(&MyNewPen); 
	pDC->MoveTo(9*9,9*9);
	for (int i = 0; i <= 5; i++){
	pDC->LineTo(300 + (i*6-55) + rand() % 50,300 + (i*6)+ rand() % 50);
	pDC->LineTo(370 + (i*6) + rand() % 50,380 + (i*6 - 16)+ rand() % 50);
	pDC->LineTo(170 + (i*6)+ rand() % 50,180 + (i*6)+ rand() % 50);
	pDC->LineTo(100 + (i*6)+ rand() % 50,280 + (i*6)+ rand() % 50);
	}
//  
//// Make sure you're back to the default pen now that you're done 
// pDC->SelectObject(pMyOldPen); 
// pDC->MoveTo(20,position); 
// pDC->LineTo(400,position); 
}


void CpaintView::ShowBrushes(CDC* pDC) 
{  
// Draw a shape using the "default brush" 
 pDC->Ellipse(20,0,400,40); 
// Save the "default brush" 
 CBrush* pMyOldBrush = pDC->GetCurrentBrush(); 
// 1) Create a "new brush" inside the scope of the "for loop", 
// 2) Use the "new brush" 
// 3) Destroy the "new brush" at the end of each loop iteration 
 UINT i, position=50; 
for (i=0; i<7; i++) { 
   
   // 1) Create a new brush, changing patterns (param1) and colors (param2) 
  CBrush MyNewBrush(i, RGB(0+(i*10),0+(i*20),0+(i*30))); 
   
   // 2) Use 
  pDC->SelectObject(&MyNewBrush); 
  pDC->RoundRect(20,position,400,position+40,40,40); 
   // Other available shapes are Chord, DrawFocusRect, Pie,  
// Polygon, PolyPolygon, Polyline, Rectangle, Ellipse, RoundRect 
// Consult online help for further information 
   
  position+=50; 
 } // 3) Destroy the brush created inside the loop 
// Make sure you're back to the default brush now that you're done 
 pDC->SelectObject(pMyOldBrush); 
 pDC->Ellipse(20,position,400,position+40); 
}


void CpaintView::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: Add your message handler code here and/or call default
	m_ToolToUse = Pens;  // Same as m_ToolToUse = 1;
	

	CpaintDoc* pDoc = GetDocument(); 
	
	//*m_ClickedHere
	// Storing the “point” passed through the parameter list into our array. 
	; 
	Invalidate(); 
	CView::OnLButtonDown(nFlags, point);
}


void CpaintView::OnRButtonDown(UINT nFlags, CPoint point)
{
	// TODO: Add your message handler code here and/or call default
	m_ToolToUse = Brushes;

	Invalidate();
	CView::OnRButtonDown(nFlags, point);
}


void CpaintView::OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags)
{
	// TODO: Add your message handler code here and/or call default
	m_ToolToUse = Fonts;

	Invalidate();
	CView::OnKeyDown(nChar, nRepCnt, nFlags);
}
