#pragma once

// FirstSDICtrl.h : Declaration of the CFirstSDICtrl ActiveX Control class.


// CFirstSDICtrl : See FirstSDICtrl.cpp for implementation.

class CFirstSDICtrl : public COleControl
{
	DECLARE_DYNCREATE(CFirstSDICtrl)

// Constructor
public:
	CFirstSDICtrl();

// Overrides
public:
	virtual void OnDraw(CDC* pdc, const CRect& rcBounds, const CRect& rcInvalid);
	virtual void DoPropExchange(CPropExchange* pPX);
	virtual void OnResetState();

// Implementation
protected:
	~CFirstSDICtrl();

	DECLARE_OLECREATE_EX(CFirstSDICtrl)    // Class factory and guid
	DECLARE_OLETYPELIB(CFirstSDICtrl)      // GetTypeInfo
	DECLARE_PROPPAGEIDS(CFirstSDICtrl)     // Property page IDs
	DECLARE_OLECTLTYPE(CFirstSDICtrl)		// Type name and misc status

// Message maps
	DECLARE_MESSAGE_MAP()

// Dispatch maps
	DECLARE_DISPATCH_MAP()

	afx_msg void AboutBox();

// Event maps
	DECLARE_EVENT_MAP()

// Dispatch and event IDs
public:
	enum {
	};
};

