Imports System.Data.SqlClient
Public Class FRM_MonitoringChecklistSummary

    Dim CreatedBySupervisor As String







    Private Sub BTN_Process_Click(sender As Object, e As EventArgs) Handles BTN_Process.Click

        LoadRecord()
        DataGridView1.ClearSelection()

        BTN_Update.Enabled = False
    End Sub

    Sub LoadRecord()
        Dim section As String = String.Empty

        If CBO_SectionSummary.Text = "CUTTING" Then
            section = "CU"
        ElseIf CBO_SectionSummary.Text = "QA" Then
            section = "QA"
        ElseIf CBO_SectionSummary.Text = "FINISHING" Then
            section = "FI"
        ElseIf CBO_SectionSummary.Text = "GLUING" Then
            section = "GL"
        ElseIf CBO_SectionSummary.Text = "LAMINATION" Then
            section = "LA"
        ElseIf CBO_SectionSummary.Text = "OFFSET" Then
            section = "OF"
        ElseIf CBO_SectionSummary.Text = "INSPECTION MACHINE" Then
            section = "QC"
        ElseIf CBO_SectionSummary.Text = "STRIPPING" Then
            section = "ST"

        Else
            section = "XX"
        End If

        Try

            OpenConnection()

            'Clear the DataGridView before loading new records
            DataGridView1.Rows.Clear()
            cmd.CommandText = "Select_MCSummary"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@MCDateStart", dtp_startdate.Text)
            cmd.Parameters.AddWithValue("@MCDateEnd", dtp_enddate.Text)
            cmd.Parameters.AddWithValue("@SecS", CBO_SectionSummary.Text)
            cmd.Parameters.AddWithValue("@Sece", CBO_SectionSummary.Text)




            If position <> "Operator" Then
                cmd.Parameters.AddWithValue("@Empnum", "sa")
            Else
                cmd.Parameters.AddWithValue("@Empnum", empnum)

            End If


            cmd.Parameters.AddWithValue("@MachS", cmb_machine.Text)
            cmd.Parameters.AddWithValue("@Mache", cmb_machine.Text)
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)



            dr = cmd.ExecuteReader()

            While dr.Read()
                'Dim empName As String = GetEmployeeNumber(dr.Item("emp_num"))
                DataGridView1.Rows.Add(dr.Item("rescmch"), dr.Item("mcnum"), Convert.ToDateTime(dr.Item("mcdate")).ToString("d"), dr.Item("shift"), dr.Item("job"), dr.Item("jobname_ext"), dr.Item("Name"), dr.Item("cbsupervisor"), dr.Item("cbsuperintendent"), dr.Item("cbnxtsuper"))
            End While
            dr.Close()
            con.Close()


            'cmd.CommandText = "SELECT sppmcHdr.rescmch, sppmcHdr.mcnum, sppmcHdr.mcdate, sppmcHdr.shift, sppmcHdr.job, sppmcHdr.jobname, Employee.Name " &
            '      "FROM sppmcHdr INNER JOIN Employee On sppmcHdr.emp_num = Employee.Emp_num " &
            '      "WHERE sppmcHdr.SECTION = @Section"
            'cmd.CommandType = CommandType.Text
            'cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("@Section", section)
            'dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            con.Close()
        End Try





    End Sub

    'Private Function GetEmployeeNumber(emp_num As String) As String



    '    Dim empName As String = ""
    '    Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
    '        con.Open()
    '        Using cmd As New SqlCommand("Select Name FROM Employee WHERE Emp_num = @emp_num", con)
    '            cmd.Parameters.AddWithValue("@emp_num", emp_num)
    '            Dim result = cmd.ExecuteScalar()
    '            If result IsNot Nothing Then
    '                empName = result.ToString()
    '            End If
    '        End Using
    '    End Using
    '    Return empName
    'End Function





    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click


        FRM_ProcessJob.Show()
        Me.Close()




    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            TXT_CheckMcNo.Text = row.Cells(1).Value

            TXT_MachineName.Text = row.Cells(0).Value




            If row.Cells(6).Value IsNot Nothing Then
                TXT_OperName.Text = row.Cells(6).Value.ToString
            Else
                TXT_OperName.Text = ""
            End If





            If row.Cells(7).Value IsNot Nothing Then
                'It's a Global bariable
                CreatedBySupervisor = row.Cells(7).Value.ToString
                'FRM_MonitoringChecklistMain.TXT_CreatedBy.Text = CreatedBySupervisor
            Else
                CreatedBySupervisor = ""
            End If





        End If

        If TXT_CheckMcNo.Text = "" Then
            BTN_Update.Enabled = False
        Else
            BTN_Update.Enabled = True
        End If



    End Sub

    Private Sub BTN_Update_Click(sender As Object, e As EventArgs) Handles BTN_Update.Click
        check_app_version()
        If app_version <> check_app_version() Then


            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If


        If position = "Line Leader" And CBO_SectionSummary.Text <> "FINISHING" Then

            MessageBox.Show("Invalid section: Only  Finishing section are allowed for the position of Line Leader", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If


        If position = "Inspector" And CBO_SectionSummary.Text = "FINISHING" Then

            MessageBox.Show("Invalid Positon: Inspector are not allowed in Finishing section", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If




        If position <> "Supervisor" And position <> "Operator" And position <> "Line Leader" And position <> "Superintendent" And position <> "Inspector" Then

            MessageBox.Show("Invalid Position: Only  Operators, Line Leaders, Inspectors, Supervisors and Superintendents are allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Exit Sub
        End If










        section = CBO_SectionSummary.Text
        FRM_MonitoringChecklistMain.LBL_SectionName.Text = CBO_SectionSummary.Text


        Me.Hide()
        FRM_MonitoringChecklistMain.Show()



        'passing Data to form of main operator name
        FRM_MonitoringChecklistMain.txt_operator.Text = TXT_OperName.Text

        FRM_MonitoringChecklistMain.CHK_CkeckedUSer.Checked = True




        'passing Data to form of main 
        Try
            OpenConnection()
            cmd.CommandText = "Select * FROM sppmcHdr WHERE Site = @Site And mcnum = @mcnum "
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", TXT_CheckMcNo.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then
                    FRM_MonitoringChecklistMain.TXT_MCNO.Text = dr("mcnum").ToString()
                    FRM_MonitoringChecklistMain.txt_machine.Text = dr("rescmch").ToString()
                    FRM_MonitoringChecklistMain.txt_job.Text = dr("job").ToString()
                    FRM_MonitoringChecklistMain.txt_jobname.Text = dr("jobname").ToString()
                    FRM_MonitoringChecklistMain.txt_jobname_ext.Text = dr("jobname_ext").ToString()
                    FRM_MonitoringChecklistMain.txt_date.Text = Convert.ToDateTime(dr("mcdate")).ToString("d")
                    FRM_MonitoringChecklistMain.txt_jobqty.Text = Convert.ToDecimal(dr("job_qty")).ToString("N0")
                    FRM_MonitoringChecklistMain.txt_um.Text = dr("U_m").ToString()
                    FRM_MonitoringChecklistMain.TXT_MCNO.Text = dr("mcnum").ToString()
                    FRM_MonitoringChecklistMain.LBL_oper_numOperator.Text = dr("emp_num").ToString()
                    FRM_MonitoringChecklistMain.txt_shift.Text = dr("shift").ToString()
                    FRM_MonitoringChecklistMain.TXT_CreatedBy.Text = CreatedBySupervisor
                    joborder = dr("job").ToString()
                    suffix = dr("suffix").ToString()
                    oper_num = dr("oper_num").ToString()

                    dr.Close()
                    con.Close()



                End If
                dr.Close()
                con.Close()

                If position <> "Supervisor" Then
                    FRM_MonitoringChecklistMain.BTN_SaveHeader.Enabled = False
                Else
                    FRM_MonitoringChecklistMain.BTN_SaveHeader.Enabled = True
                End If


            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try


        'SECTION and section name change



        'FRM_MonitoringChecklistMain.TXT_OrigSection.Text = section
        'FRM_MonitoringChecklistMain.TXT_OrigSectionCode.Text = section_code



        'refresh table of production run
        Dim i As Integer
        For i = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        'FOR CUTTING
        Dim MonitoringChecklistOperator As New UC_MonitoringChecklistOperators
        Dim MonitoringChecklistSupervisor As New UC_MonitoringChecklistSupervisor
        Dim MonitoringChecklistSupervisorIntendent As New UC_MonitoringChecklistSuperIntendent




        'FOR DIE CUTTING
        Dim UC_OperatorDieCutting As New UC_OperatorDIeCutting
        Dim UC_SupervisorDieCuting As New UC_SupervisorDIeCutting
        Dim UC_SuperIntendent As New UC_SuperIntendentDieCutting



        'FOR OFFSET
        Dim UC_OperatorOff As New UC_OperatorOffset
        Dim UC_SupervisorOff As New UC_SupervisorOffset
        Dim UC_SuperIntendentOff As New UC_SuperIntendentOffset




        'FOR LAMINATION
        Dim UC_OperatorLam As New UC_OperatorLamination
        Dim UC_SupervisorLam As New UC_SupervisorLamination
        Dim UC_SuperIntendentLam As New UC_SuperIntendentLamination




        If position = "Operator" Or position = "Line Leader" Then


            If section = "CUTTING" Then
                MonitoringChecklistOperator.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistOperator.BTN_AddProductionRun.Enabled = True
                MonitoringChecklistOperator.Show()
                MonitoringChecklistOperator.Dock = DockStyle.Fill
            ElseIf section = "DIE CUTTING"
                UC_OperatorDieCutting.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorDieCutting.BTN_AddProductionRun.Enabled = True
                UC_OperatorDieCutting.Show()
                UC_OperatorDieCutting.Dock = DockStyle.Fill
            ElseIf section = "OFFSET"
                UC_OperatorOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorOff.BTN_AddProductionRun.Enabled = True
                UC_OperatorOff.Show()
                UC_OperatorOff.Dock = DockStyle.Fill
            ElseIf section = "LAMINATION"
                UC_OperatorLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorLam.BTN_AddProductionRun.Enabled = True
                UC_OperatorLam.Show()
                UC_OperatorLam.Dock = DockStyle.Fill
            ElseIf section = "STRIPPING"
                Dim UC_OperatorStrip As New UC_OperatorStripping
                UC_OperatorStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorStrip.BTN_AddProductionRun.Enabled = True
                UC_OperatorStrip.Show()
                UC_OperatorStrip.Dock = DockStyle.Fill
            ElseIf section = "INSPECTION MACHINE"
                Dim UC_OperatorQC As New UC_OperatorQCMachine
                UC_OperatorQC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorQC.BTN_AddProductionRun.Enabled = True
                UC_OperatorQC.Show()
                UC_OperatorQC.Dock = DockStyle.Fill
            ElseIf section = "GLUING" AndAlso TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_OperatorGluingLamina As New UC_OperatorGluingLamina
                UC_OperatorGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorGluingLamina.BTN_AddProductionRun.Enabled = True
                UC_OperatorGluingLamina.Show()
                UC_OperatorGluingLamina.Dock = DockStyle.Fill
            ElseIf section = "GLUING" AndAlso Not TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_OperatorGluing As New UC_OperatorGluing
                UC_OperatorGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorGluing.BTN_AddProductionRun.Enabled = True
                UC_OperatorGluing.Show()
                UC_OperatorGluing.Dock = DockStyle.Fill
            ElseIf section = "DIGITAL PRESS"
                Dim UC_OperatorDigiPress As New UC_OperatorDigiPress
                UC_OperatorDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorDigiPress.BTN_AddProductionRun.Enabled = True
                UC_OperatorDigiPress.Show()
                UC_OperatorDigiPress.Dock = DockStyle.Fill
            ElseIf section = "FINISHING"
                Dim UC_OperatorFinishing As New UC_OperatorFinishing
                UC_OperatorFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_OperatorFinishing.Show()
                UC_OperatorFinishing.Dock = DockStyle.Fill


            End If


            FRM_MonitoringChecklistMain.BTN_Operator.ForeColor = Color.DodgerBlue
            FRM_MonitoringChecklistMain.BTN_Operator.BackColor = Color.White


            'changed color to black
            FRM_MonitoringChecklistMain.BTN_Supervisor.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Supervisor.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_SuperIntendent.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_SuperIntendent.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_NxtProcess.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_NxtProcess.BackColor = Color.WhiteSmoke


        ElseIf position = "Supervisor"
            If section = "CUTTING" Then
                MonitoringChecklistSupervisor.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistSupervisor.Show()
                MonitoringChecklistSupervisor.Dock = DockStyle.Fill

            ElseIf section = "DIE CUTTING"
                UC_SupervisorDieCuting.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorDieCuting.Show()
                UC_SupervisorDieCuting.Dock = DockStyle.Fill

            ElseIf section = "OFFSET"
                UC_SupervisorOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorOff.Show()
                UC_SupervisorOff.Dock = DockStyle.Fill

            ElseIf section = "LAMINATION"
                UC_SupervisorLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorLam.Show()
                UC_SupervisorLam.Dock = DockStyle.Fill

            ElseIf section = "STRIPPING"
                Dim UC_SupervisorStrip As New UC_SupervisorStripping
                UC_SupervisorStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorStrip.Show()
                UC_SupervisorStrip.Dock = DockStyle.Fill

            ElseIf section = "INSPECTION MACHINE"
                Dim UC_SupervisorQC As New UC_SupervisorQCMachine
                UC_SupervisorQC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorQC.Show()
                UC_SupervisorQC.Dock = DockStyle.Fill

            ElseIf section = "GLUING" AndAlso TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_SupervisorGluingLamina As New UC_SupervisorGluingLamina
                UC_SupervisorGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorGluingLamina.Show()
                UC_SupervisorGluingLamina.Dock = DockStyle.Fill

            ElseIf section = "GLUING" AndAlso Not TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_SupervisorGluing As New UC_SupervisorGluing
                UC_SupervisorGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorGluing.Show()
                UC_SupervisorGluing.Dock = DockStyle.Fill

            ElseIf section = "DIGITAL PRESS"
                Dim UC_SupervisorDigiPress As New UC_SupervisorDigiPress
                UC_SupervisorDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorDigiPress.Show()
                UC_SupervisorDigiPress.Dock = DockStyle.Fill

            ElseIf section = "FINISHING"
                Dim UC_SupervisorFinishing As New UC_SupervisorFinishing
                UC_SupervisorFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SupervisorFinishing.Show()
                UC_SupervisorFinishing.Dock = DockStyle.Fill
            End If


            FRM_MonitoringChecklistMain.BTN_Supervisor.ForeColor = Color.DodgerBlue
            FRM_MonitoringChecklistMain.BTN_Supervisor.BackColor = Color.White

            'changed color to black

            FRM_MonitoringChecklistMain.BTN_Operator.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Operator.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_SuperIntendent.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_SuperIntendent.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_NxtProcess.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_NxtProcess.BackColor = Color.WhiteSmoke

            'FRM_MonitoringChecklistMain.BTN_Save.Enabled = True
        ElseIf position = "Superintendent"

            If section = "CUTTING" Then
                MonitoringChecklistSupervisorIntendent.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistSupervisorIntendent.Show()
                MonitoringChecklistSupervisorIntendent.Dock = DockStyle.Fill

            ElseIf section = "DIE CUTTING"
                UC_SuperIntendent.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendent.Show()
                UC_SuperIntendent.Dock = DockStyle.Fill

            ElseIf section = "OFFSET"
                UC_SuperIntendentOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentOff.Show()
                UC_SuperIntendentOff.Dock = DockStyle.Fill

            ElseIf section = "LAMINATION"
                UC_SuperIntendentLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentLam.Show()
                UC_SuperIntendentLam.Dock = DockStyle.Fill

            ElseIf section = "STRIPPING"
                Dim UC_SuperIntendentStrip As New UC_SuperIntendentStripping
                UC_SuperIntendentStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentStrip.Show()
                UC_SuperIntendentStrip.Dock = DockStyle.Fill

            ElseIf section = "INSPECTION MACHINE"
                Dim UC_SuperIntendentQC As New UC_SuperIntendentQCMachine
                UC_SuperIntendentQC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentQC.Show()
                UC_SuperIntendentQC.Dock = DockStyle.Fill

            ElseIf section = "GLUING" AndAlso TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_SuperIntendentGluingLamina As New UC_SuperIntendentGluingLamina
                UC_SuperIntendentGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentGluingLamina.Show()
                UC_SuperIntendentGluingLamina.Dock = DockStyle.Fill

            ElseIf section = "GLUING" AndAlso Not TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_SuperIntendentGluing As New UC_SuperIntendentGluing
                UC_SuperIntendentGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentGluing.Show()
                UC_SuperIntendentGluing.Dock = DockStyle.Fill

            ElseIf section = "DIGITAL PRESS"
                Dim UC_SuperIntendentDigiPress As New UC_SuperIntendentDigiPress
                UC_SuperIntendentDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentDigiPress.Show()
                UC_SuperIntendentDigiPress.Dock = DockStyle.Fill

            ElseIf section = "FINISHING"
                Dim UC_SuperIntendentFinishing As New UC_SuperIntendentFinishing
                UC_SuperIntendentFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentFinishing.Show()
                UC_SuperIntendentFinishing.Dock = DockStyle.Fill

            End If


            FRM_MonitoringChecklistMain.BTN_SuperIntendent.ForeColor = Color.DodgerBlue
            FRM_MonitoringChecklistMain.BTN_SuperIntendent.BackColor = Color.White

            'changed color to black
            FRM_MonitoringChecklistMain.BTN_Operator.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Operator.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_Supervisor.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Supervisor.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_NxtProcess.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_NxtProcess.BackColor = Color.WhiteSmoke

        ElseIf position = "Inspector"


            If section = "CUTTING" Then
                Dim UC_MonitoringChecklistNxtProcessCutting As New UC_MonitoringChecklistNxtProcess
                UC_MonitoringChecklistNxtProcessCutting.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_MonitoringChecklistNxtProcessCutting.Show()
                UC_MonitoringChecklistNxtProcessCutting.Dock = DockStyle.Fill

            ElseIf section = "DIE CUTTING"
                Dim UC_NxtProcessDieCutting As New UC_NxtProcessDieCutting
                UC_NxtProcessDieCutting.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessDieCutting.Show()
                UC_NxtProcessDieCutting.Dock = DockStyle.Fill

            ElseIf section = "OFFSET"
                Dim UC_NxtProcessOffset As New UC_NxtProcessOffset
                UC_NxtProcessOffset.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessOffset.Show()
                UC_NxtProcessOffset.Dock = DockStyle.Fill

            ElseIf section = "LAMINATION"
                Dim UC_NxtProcessLamination As New UC_NxtProcessLamination
                UC_NxtProcessLamination.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessLamination.Show()
                UC_NxtProcessLamination.Dock = DockStyle.Fill

            ElseIf section = "STRIPPING"
                Dim UC_NxtProcessStripping As New UC_NxtProcessStripping
                UC_NxtProcessStripping.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessStripping.Show()
                UC_NxtProcessStripping.Dock = DockStyle.Fill

            ElseIf section = "INSPECTION MACHINE"
                Dim UC_NxtProcessQC As New UC_NxtProcessQC
                UC_NxtProcessQC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessQC.Show()
                UC_NxtProcessQC.Dock = DockStyle.Fill

            ElseIf section = "GLUING" AndAlso TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_NxtProcessGluingLamina As New UC_NxtProcessGluingLamina
                UC_NxtProcessGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessGluingLamina.Show()
                UC_NxtProcessGluingLamina.Dock = DockStyle.Fill

            ElseIf section = "GLUING" AndAlso Not TXT_MachineName.Text.StartsWith("P-LAMINA")
                Dim UC_NxtProcessGluing As New UC_NxtProcessGluing
                UC_NxtProcessGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessGluing.Show()
                UC_NxtProcessGluing.Dock = DockStyle.Fill

            ElseIf section = "DIGITAL PRESS"
                Dim UC_NxtProcessDigiPress As New UC_NxtProcessDigiPress
                UC_NxtProcessDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessDigiPress.Show()
                UC_NxtProcessDigiPress.Dock = DockStyle.Fill

            ElseIf section = "FINISHING"
                Dim UC_NxtProcessFinishing As New UC_NxtProcessFinishing
                UC_NxtProcessFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessFinishing.Show()
                UC_NxtProcessFinishing.Dock = DockStyle.Fill
            End If


            FRM_MonitoringChecklistMain.BTN_SuperIntendent.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_SuperIntendent.BackColor = Color.WhiteSmoke

            'changed color to black
            FRM_MonitoringChecklistMain.BTN_Operator.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Operator.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_Supervisor.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Supervisor.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_NxtProcess.ForeColor = Color.DodgerBlue
            FRM_MonitoringChecklistMain.BTN_NxtProcess.BackColor = Color.White

        End If


        FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = False


        If section = "GLUING" AndAlso TXT_MachineName.Text.StartsWith("P-LAMINA") Then
            FRM_MonitoringChecklistMain.LBL_SectionName.Text = "GLUING LAMINA"

        End If
    End Sub

    Private Sub FRM_MonitoringChecklistSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_Empname.Text = empname
        LBL_EmpNum.Text = empnum


        CBO_SectionSummary.Text = section



    End Sub




    Private Sub populaterscmach()
        Dim con1 As SqlConnection = New SqlConnection("Data Source=ERP-SVR;Initial Catalog=PI-SP_App;User ID=sa;Password=pi_dc_2011")
        'Dim cmd1 As SqlCommand = New SqlCommand("SELECT RS.RESID,RS.DESCR FROM wc INNER JOIN wcresourcegroup WCR ON WC.wc=WCR.wc INNER JOIN RGRPMBR000 RG ON RG.RGID=WCR.rgid INNER JOIN RESRC000 RS ON RS.RESID=RG.RESID where wc.wc=@wc", con1)
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT DISTINCT RS.RESID,RS.DESCR, RS.Uf_Resrc_Section FROM wc INNER JOIN wcresourcegroup WCR ON WC.wc=WCR.wc INNER JOIN RGRPMBR000 RG ON RG.RGID=WCR.rgid RIGHT JOIN RESRC000 RS ON RS.RESID=RG.RESID WHERE RS.Uf_Resrc_Section = @section", con1)
        cmd1.Parameters.AddWithValue("@section", CBO_SectionSummary.Text)

        Try
            con1.Open()
            Dim reader As SqlDataReader = cmd1.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    cmb_machine.Items.Add(reader("RESID").ToString())
                End While
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'Dim con1 As SqlConnection = New SqlConnection("Data Source=ERP-SVR;Initial Catalog=PI-SP_App;User ID=sa;Password=pi_dc_2011")
        'Dim cmd1 As SqlCommand = New SqlCommand("Select RS.RESID,RS.DESCR FROM wc INNER JOIN wcresourcegroup WCR On WC.wc=WCR.wc INNER JOIN RGRPMBR000 RG On RG.RGID=WCR.rgid INNER JOIN RESRC000 RS On RS.RESID=RG.RESID where wc.wc=@wc", con1)
        ''Dim cmd1 As SqlCommand = New SqlCommand("Select DISTINCT RS.RESID,RS.DESCR, RS.Uf_Resrc_Section FROM wc INNER JOIN wcresourcegroup WCR On WC.wc=WCR.wc INNER JOIN RGRPMBR000 RG On RG.RGID=WCR.rgid RIGHT JOIN RESRC000 RS On RS.RESID=RG.RESID WHERE RS.Uf_Resrc_Section = @section", con1)
        'cmd1.Parameters.AddWithValue("@section", CBO_SectionSummary.Text) 
        'Try
        '    con1.Open()
        '    Dim reader As SqlDataReader = cmd1.ExecuteReader
        '    If reader.HasRows Then
        '        While reader.Read()
        '            cmb_machine.Items.Add(reader("RESID").ToString())
        '        End While
        '        reader.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub



    Private Sub cmb_machine_DropDown(sender As Object, e As EventArgs) Handles cmb_machine.DropDown
        cmb_machine.Items.Clear()
        'populatemachine()
        populaterscmach()
    End Sub

    Private Sub CBO_SectionSummary_DropDown(sender As Object, e As EventArgs) Handles CBO_SectionSummary.DropDown
        cmb_machine.SelectedIndex = -1
        'CBO_SectionSummary.Items.Clear()
        ' populatesection()
    End Sub

    Private Sub CBO_SectionSummary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_SectionSummary.SelectedIndexChanged
        'populatesectioncode()
    End Sub


    Private Sub populatesection()
        Try
            con.Open()
            Dim cmd_viewsection As New SqlCommand("Select ZZCODE, SECTION, ZZCODE + ' - ' + SECTION as codeandsection from SectionMasterfile", con)
            Dim read_cmd As SqlDataReader = cmd_viewsection.ExecuteReader
            If read_cmd.HasRows Then
                While read_cmd.Read
                    CBO_SectionSummary.Items.Add(read_cmd("codeandsection"))
                End While
                read_cmd.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub populatesectioncode()
        Dim cmd As New SqlCommand("Select_SectionMasterfile", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codedesc", CBO_SectionSummary.Text)
        Try
            con.Open()
            Dim readcmd As SqlDataReader = cmd.ExecuteReader
            While readcmd.Read
                Dim codeanddesc As String = readcmd("zzcode")
                CBO_SectionSummary.Items.Add(codeanddesc)
                CBO_SectionSummary.Text = readcmd("zzcode").ToString
                'MsgBox(readcmd("zzcode").ToString)
            End While
            readcmd.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub populatemachine()
        Try
            con.Open()
            Dim cmd_view_machine As New SqlCommand("Select_Machine_PISP", con)
            cmd_view_machine.CommandType = CommandType.StoredProcedure
            cmd_view_machine.Parameters.AddWithValue("@section", CBO_SectionSummary.Text)

            Dim read_cmd_view_machine As SqlDataReader = cmd_view_machine.ExecuteReader
            If read_cmd_view_machine.HasRows Then
                While read_cmd_view_machine.Read
                    cmb_machine.Items.Add(read_cmd_view_machine("RESID").ToString)
                End While
                read_cmd_view_machine.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TXT_OperName_TextChanged(sender As Object, e As EventArgs) Handles TXT_OperName.TextChanged

    End Sub


End Class