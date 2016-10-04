'	Description.	further labs into database, and manipulating them using VB.net
'	Programmed by.	JackWatt /04/9/2012 




Public Class form1

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CompanyDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

        'All staff defaults to checked
        radAllStaff.Checked = 1

    End Sub

    Private Sub radAllStaff_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radAllStaff.CheckedChanged

        'Will show all staff (no filter)
        SalesStaffTableAdapter.Fill(CompanyDataSet.SalesStaff)
        'used to compute average and display back to end user
        ComputeAverage()
    End Sub

    'used to compute average for group selected
    Private Sub ComputeAverage()
        Dim average, sum As Double


        'loop through dataset to get total
        For i = 0 To CompanyDataSet.SalesStaff.Count - 1
            'uses current i position along with column name
            sum += CompanyDataSet.SalesStaff.Rows(i)("Salary")
        Next
        'computes average
        average = sum / CompanyDataSet.SalesStaff.Count
        'display onscreen for end user
        lblAverageSalary.Text = FormatCurrency(average)
    End Sub

    Private Sub radFullTime_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFullTime.CheckedChanged
        'Will show fulltime staff 
        SalesStaffTableAdapter.FillByFullTime(CompanyDataSet.SalesStaff)
        'used to compute average and display back to end user
        ComputeAverage()
    End Sub

    Private Sub radPartTime_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radPartTime.CheckedChanged
        'Will show parttime staff 
        SalesStaffTableAdapter.FillByPartTime(CompanyDataSet.SalesStaff)
        'used to compute average and display back to end user
        ComputeAverage()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        'flips the visibility
        SalesStaffDataGridView.Visible = Not SalesStaffDataGridView.Visible
    End Sub
End Class
