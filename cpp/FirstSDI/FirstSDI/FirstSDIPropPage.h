#pragma once

// FirstSDIPropPage.h : Declaration of the CFirstSDIPropPage property page class.


// CFirstSDIPropPage : See FirstSDIPropPage.cpp for implementation.

class CFirstSDIPropPage : public COlePropertyPage
{
	DECLARE_DYNCREATE(CFirstSDIPropPage)
	DECLARE_OLECREATE_EX(CFirstSDIPropPage)

// Constructor
public:
	CFirstSDIPropPage();

// Dialog Data
	enum { IDD = IDD_PROPPAGE_FIRSTSDI };

// Implementation
protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Message maps
protected:
	DECLARE_MESSAGE_MAP()
};

