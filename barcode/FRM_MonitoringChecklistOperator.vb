Public Class FRM_MonitoringChecklistOperator
    Private Sub MonitoringChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Rows.Add("07:00", "", "", "", "", "", "", "", "", "", "", "", "", "07:30")
        DataGridView1.Rows.Add("08:00", "", "", "", "", "", "", "", "", "", "", "", "", "08:30")
        DataGridView1.Rows.Add("09:00", "", "", "", "", "", "", "", "", "", "", "", "", "09:30")
        DataGridView1.Rows.Add("10:00", "", "", "", "", "", "", "", "", "", "", "", "", "10:30")
        DataGridView1.Rows.Add("11:00", "", "", "", "", "", "", "", "", "", "", "", "", "11:30")
        DataGridView1.Rows.Add("12:00", "", "", "", "", "", "", "", "", "", "", "", "", "12:30")
        DataGridView1.Rows.Add("01:00", "", "", "", "", "", "", "", "", "", "", "", "", "01:30")
        DataGridView1.Rows.Add("02:00", "", "", "", "", "", "", "", "", "", "", "", "", "02:30")
        DataGridView1.Rows.Add("03:00", "", "", "", "", "", "", "", "", "", "", "", "", "03:30")
        DataGridView1.Rows.Add("04:00", "", "", "", "", "", "", "", "", "", "", "", "", "04:30")
        DataGridView1.Rows.Add("05:00", "", "", "", "", "", "", "", "", "", "", "", "", "05:30")
        DataGridView1.Rows.Add("06:00", "", "", "", "", "", "", "", "", "", "", "", "", "06:30")

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 40
        Next

    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.Rows.Add("07:00", "X", "", "", "", "", "", "", "", "", "", "", "", "07:30")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class