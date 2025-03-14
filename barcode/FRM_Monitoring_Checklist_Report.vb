Imports System.Data.SqlClient
Imports ZXing
Public Class FRM_Monitoring_Checklist_Report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CMB_Section.Text = "" Then
            MsgBox("Section is Required!", vbExclamation)
            Exit Sub
        End If

        If CMB_Section.Text = "CUTTING" Then
            report_rdl = "IT_RPT_MC_Cutting.rdl"
        ElseIf CMB_Section.Text = "OFFSET" Then
            report_rdl = "IT_RPT_MC_Offset.rdl"
        End If

        'MsgBox(DTP_StartDate.Value.ToString("yyyy-mm-dd"))

        FRM_PreviewReport.Show()
    End Sub

    Private Sub CMB_Machine_DropDown(sender As Object, e As EventArgs) Handles CMB_Machine.DropDown
        CMB_Machine.Items.Clear()
        populaterscmach()
    End Sub

    Private Sub populaterscmach()

        'Dim cmd1 As SqlCommand = New SqlCommand("SELECT RS.RESID,RS.DESCR FROM wc INNER JOIN wcresourcegroup WCR ON WC.wc=WCR.wc INNER JOIN RGRPMBR000 RG ON RG.RGID=WCR.rgid INNER JOIN RESRC000 RS ON RS.RESID=RG.RESID where wc.wc=@wc", con1)
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT DISTINCT RS.RESID,RS.DESCR, RS.Uf_Resrc_Section FROM wc INNER JOIN wcresourcegroup WCR ON WC.wc=WCR.wc INNER JOIN RGRPMBR000 RG ON RG.RGID=WCR.rgid RIGHT JOIN RESRC000 RS ON RS.RESID=RG.RESID WHERE RS.Uf_Resrc_Section = @section", con_Pisp)
        cmd1.Parameters.AddWithValue("@section", CMB_Section.Text)
        Try
            con_Pisp.Open()
            Dim reader As SqlDataReader = cmd1.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    CMB_Machine.Items.Add(reader("RESID").ToString())
                End While
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_Pisp.Close()
        End Try
    End Sub
End Class