Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FRM_PreviewReport
    Public con_pallet As SqlConnection = New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
    Private Sub FRM_PreviewReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim reportPath As String = System.IO.Path.Combine(Application.StartupPath, "\\utility-svr\SyteLine\Report\Reports\PalletTaggingReports\PalletTaggingReports\PalletTaggingReports\", report_rdl)
        Dim reportPath As String = System.IO.Path.Combine(Application.StartupPath, "\\utility-svr\SyteLine\Report\Reports\PalletTaggingReports\PalletTaggingReports\PalletTaggingReports\" + report_rdl)
        Dim datasource1 As New ReportDataSource

        ReportViewer1.ProcessingMode = ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = reportPath

        If FRM_Monitoring_Checklist_Report.CMB_Section.Text = "CUTTING" Then
            datasource1 = New ReportDataSource("DataSource", MC_Cutting())
        ElseIf FRM_Monitoring_Checklist_Report.CMB_Section.Text = "OFFSET" Then
            datasource1 = New ReportDataSource("MC_Offset_DataSource", MC_Offset())
        End If



        '' Clear existing data sources (optional, depending on your needs)
        ReportViewer1.LocalReport.DataSources.Clear()



        '' Add the new data source
        ReportViewer1.LocalReport.DataSources.Add(dataSource1)

        Dim reportParameters As New List(Of ReportParameter)()

        '' Add parameters to the list. Replace "ParameterName" with the actual name of the parameter
        '' defined in your report, and provide the value you want to pass.
        reportParameters.Add(New ReportParameter("paramSite", user_site))
        reportParameters.Add(New ReportParameter("paramSDate", FRM_Monitoring_Checklist_Report.DTP_StartDate.Value.ToString("yyyy-MM-dd")))
        reportParameters.Add(New ReportParameter("paramEDate", FRM_Monitoring_Checklist_Report.DTP_EndDate.Value.ToString("yyyy-MM-dd")))
        'reportParameters.Add(New ReportParameter("Section", FRM_Monitoring_Checklist_Report.CMB_Section.Text))
        'reportParameters.Add(New ReportParameter("Machine", FRM_Monitoring_Checklist_Report.CMB_Machine.Text))
        reportParameters.Add(New ReportParameter("paramSection", FRM_Monitoring_Checklist_Report.CMB_Section.Text))
        reportParameters.Add(New ReportParameter("paramMachine", FRM_Monitoring_Checklist_Report.CMB_Machine.Text))
        ''reportParameters.Add(New ReportParameter("empnum", EmpValue))

        '' Set the parameters to the report.
        ReportViewer1.LocalReport.SetParameters(reportParameters)

        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Function MC_Offset()
        Dim datatable1 As New DataTable()
        Try
            con_pallet.Open()
            Dim CMD_IT_RPT_SP As New SqlCommand("IT_RPT_MC_Offset", con_pallet)
            'Dim cmd_timeeval_rpt As New SqlCommand("IT_RPT_MC_Cutting", con)
            CMD_IT_RPT_SP.CommandType = CommandType.StoredProcedure

            'CMD_IT_RPT_SP.Parameters.AddWithValue("paramSite", user_site)
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramSite", "PI-SP")
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramSDate", FRM_Monitoring_Checklist_Report.DTP_StartDate.Value.ToString("yyyy-MM-dd"))
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramEDate", FRM_Monitoring_Checklist_Report.DTP_EndDate.Value.ToString("yyyy-MM-dd"))
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramSection", FRM_Monitoring_Checklist_Report.CMB_Section.Text)
            'CMD_IT_RPT_SP.Parameters.AddWithValue("Section", "CUTTING")
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramMachine", FRM_Monitoring_Checklist_Report.CMB_Machine.Text)
            'CMD_IT_RPT_SP.Parameters.AddWithValue("section", SqlDbType.NVarChar).Value = Frm_Transaction_Summary_Report.cmb_section.Text
            'CMD_IT_RPT_SP.Parameters.AddWithValue("startdate", SqlDbType.Date).Value = Frm_Transaction_Summary_Report.dtp_startdate.Value.ToString
            'CMD_IT_RPT_SP.Parameters.AddWithValue("enddate", SqlDbType.Date).Value = Frm_Transaction_Summary_Report.dtp_enddate.Value.ToString

            Dim adapter As New SqlDataAdapter(CMD_IT_RPT_SP)

            adapter.Fill(datatable1)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_pallet.Close()
        End Try
        Return datatable1
        MsgBox(datatable1)
    End Function

    Private Function MC_Cutting() As DataTable
        Dim datatable1 As New DataTable()
        Try
            con_pallet.Open()
            Dim CMD_IT_RPT_SP As New SqlCommand("IT_RPT_MC_Cutting", con_pallet)
            'Dim cmd_timeeval_rpt As New SqlCommand("IT_RPT_MC_Cutting", con)
            CMD_IT_RPT_SP.CommandType = CommandType.StoredProcedure

            'CMD_IT_RPT_SP.Parameters.AddWithValue("paramSite", user_site)
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramSite", "PI-SP")
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramSDate", FRM_Monitoring_Checklist_Report.DTP_StartDate.Value.ToString("yyyy-MM-dd"))
            CMD_IT_RPT_SP.Parameters.AddWithValue("paramEDate", FRM_Monitoring_Checklist_Report.DTP_EndDate.Value.ToString("yyyy-MM-dd"))
            CMD_IT_RPT_SP.Parameters.AddWithValue("Section", FRM_Monitoring_Checklist_Report.CMB_Section.Text)
            'CMD_IT_RPT_SP.Parameters.AddWithValue("Section", "CUTTING")
            CMD_IT_RPT_SP.Parameters.AddWithValue("Machine", FRM_Monitoring_Checklist_Report.CMB_Machine.Text)
            'CMD_IT_RPT_SP.Parameters.AddWithValue("section", SqlDbType.NVarChar).Value = Frm_Transaction_Summary_Report.cmb_section.Text
            'CMD_IT_RPT_SP.Parameters.AddWithValue("startdate", SqlDbType.Date).Value = Frm_Transaction_Summary_Report.dtp_startdate.Value.ToString
            'CMD_IT_RPT_SP.Parameters.AddWithValue("enddate", SqlDbType.Date).Value = Frm_Transaction_Summary_Report.dtp_enddate.Value.ToString

            Dim adapter As New SqlDataAdapter(CMD_IT_RPT_SP)

            adapter.Fill(datatable1)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_pallet.Close()
        End Try
        Return datatable1
        MsgBox(datatable1)
    End Function

End Class