Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports CrystalDecisions.Shared
Imports ZXing
Imports System.Windows.Forms
Public Class FRM_ProcessJob

    '4.5 Added Clean Code for Exiting Form
    Private LogoutBTNInitiated As Boolean = False
    Private Sub FRM_ProcessJob_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not LogoutBTNInitiated AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True ' Cancel the close so we can call logout logic
        End If
    End Sub

    Private Sub UpdateButtonState()
        ' Check if all textboxes have text
        If Not String.IsNullOrWhiteSpace(txt_machine.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txt_jobname.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txt_jobqty.Text) Then
            ' Enable the button if all textboxes have values

            If section = "FINISHING" Then

                BTN_AddFinishingDailyOut.Enabled = True
                BTN_AddMonitoringChecklist.Enabled = True
                btn_generateqr.Enabled = True
                btn_printpallet.Enabled = True
            ElseIf section = "GLUING" AndAlso txt_machine.Text = "P-AMBITION-50" Or section = "GLUING" AndAlso txt_machine.Text = "P-BM-68" Or section = "GLUING" AndAlso txt_machine.Text = "P-EXPERTFOLD-110" Or section = "GLUING" AndAlso txt_machine.Text = "P-EXPERTFOLD-80" Or section = "GLUING" AndAlso txt_machine.Text = "P-LAMINA-2212-A" Or section = "GLUING" AndAlso txt_machine.Text = "P-LAMINA-2212-B" Or section = "GLUING" AndAlso txt_machine.Text = "P-SUN-1300" Or section = "GLUING" AndAlso txt_machine.Text = "P-SUN-650" Or section = "GLUING" AndAlso txt_machine.Text = "P-SUN-850"

                BTN_AddFinishingDailyOut.Enabled = True
                BTN_AddMonitoringChecklist.Enabled = True
                btn_generateqr.Enabled = True
                btn_printpallet.Enabled = True

            ElseIf section = "STRIPPING" AndAlso txt_machine.Text = "P-BOXMATE-A" Or section = "STRIPPING" AndAlso txt_machine.Text = "P-BOXMATE-B" Or section = "STRIPPING" AndAlso txt_machine.Text = "P-BOXMATE-C" Or section = "STRIPPING" AndAlso txt_machine.Text = "P-BOXMATE-D" Or section = "STRIPPING" AndAlso txt_machine.Text = "P-BOXMATE-E"

                BTN_AddFinishingDailyOut.Enabled = True
                BTN_AddMonitoringChecklist.Enabled = True
                btn_generateqr.Enabled = True
                btn_printpallet.Enabled = True
            ElseIf section = "CUTTING"
                BTN_AddFinishingDailyOut.Enabled = True
                BTN_AddMonitoringChecklist.Enabled = True
                btn_generateqr.Enabled = True
                btn_printpallet.Enabled = True
            Else
                BTN_AddFinishingDailyOut.Enabled = False
                BTN_AddMonitoringChecklist.Enabled = True
                btn_generateqr.Enabled = True
                btn_printpallet.Enabled = True
            End If


        Else
            ' Disable the button if any textbox is empty
            FRM_MonitoringChecklistMain.Close()
            BTN_AddFinishingDailyOut.Enabled = False
            BTN_AddMonitoringChecklist.Enabled = False
            btn_generateqr.Enabled = False
            btn_printpallet.Enabled = False
        End If
    End Sub

    Public con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
    Dim mcdate As Date = Today
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Try
            opendb1()

            Dim cmd_select_hdr As SqlCommand = New SqlCommand(
                "BEGIN TRAN

                    declare 
		                    @jonumber nvarchar(10) = 'P2402-0610',
		                    @josuffix int = 6,
		                    @operationnum int = 10
                    select
			                    job.job,
			                    job.suffix,
			                    item.item,
			                    job.description,
			                    item.description as description2
                    INTO #JOB2
                    from
	                    job
		                    inner join item on job.item = item.item
                    where 
			                    job.suffix = 0
			
                    select 
			                    jroute.job,
			                    jroute.suffix,
			                    jroute.oper_num,
			                    jroute.wc,
			                    rgrp.RESID,
			                    REPLACE(CONVERT(VARCHAR, CONVERT(MONEY, job.qty_released), 1), '.00', '') as qty_released,
			                    item.u_m,
			                    job.item,
			                    job2.item,
			                    job2.description
			                    --job2.description2
                    from
	                    jobroute jroute
		                    inner join jrtresourcegroup jrscgrp on 
			                    jroute.job = jrscgrp.job AND
			                    jroute.suffix = jrscgrp.suffix AND
			                    jroute.oper_num = jrscgrp.oper_num
		                    inner join RGRPMBR000 rgrp on   
			                    jrscgrp.rgid = rgrp.RGID
		                    inner join RESRC000  resr on 
			                    rgrp.RESID = resr.RESID
		                    inner join job on
			                    jroute.job = job.job AND
			                    jroute.suffix = job.suffix
		                    inner join item on job.item = item.item
		                    inner join #JOB2 job2 on job.job = job2.job
                    WHERE
		                    jroute.job = @jonumber AND
		                    jroute.suffix = @josuffix AND
		                    jroute.oper_num = @operationnum
		
                    drop table #JOB2
                    ROLLBACK TRAN", opendb1)
            cmd_select_hdr.Parameters.AddWithValue("@jonumber", txt_joborder.Text)
            cmd_select_hdr.Parameters.AddWithValue("@josuffix", txt_suffix.Text)
            cmd_select_hdr.Parameters.AddWithValue("@operationnum", txt_opernum.Text)

            Dim read_cmd_select_hdr As SqlDataReader = cmd_select_hdr.ExecuteReader

            While read_cmd_select_hdr.Read
                txt_machine.Text = read_cmd_select_hdr("RESID").ToString
            End While

        Catch ex As Exception
        Finally
            closedb1()
        End Try
    End Sub



    Private Sub BTN_AddMonitoringChecklist_Click(sender As Object, e As EventArgs) Handles BTN_AddMonitoringChecklist.Click

        check_app_version()
        If app_version <> check_app_version() Then


            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If


        If position <> "Supervisor" And position <> "Operator" And position <> "Superintendent" Then

            MessageBox.Show("Invalid Position: Only  Operators, Supervisors and Superintendents are allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Exit Sub
        End If







        populatefields()

        If globalvariable.sppmchdr_existing_mcnum = True Then
            'MsgBox("Mc number already Exist")
            'FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = False

            ' MsgBox("mcexist")

            joborder = txt_joborder.Text
            suffix = txt_suffix.Text
            oper_num = txt_opernum.Text

            'MsgBox(section)
            FRM_MonitoringChecklistMain.lbl_empnum.Text = lbl_empnum.Text
            FRM_MonitoringChecklistMain.lbl_empname.Text = lbl_empname.Text


        Else
            ' MsgBox("mcnotexist")
            FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = True
            joborder = txt_joborder.Text
            suffix = txt_suffix.Text
            oper_num = txt_opernum.Text

            'MsgBox(section)
            'FRM_MonitoringChecklistMain.lbl_empnum.Text = lbl_empnum.Text
            'FRM_MonitoringChecklistMain.lbl_empname.Text = lbl_empname.Text

        End If





        'If section = "CUTTING" Or section = "DIE CUTTING" Or section = "OFFSET" Or section = "LAMINATION" Then
        If position = "Supervisor" Then
            'FRM_MonitoringChecklistMain.txt_operator.Text = ""








            FRM_MonitoringChecklistMain.BTN_Supervisor.ForeColor = Color.DodgerBlue
            FRM_MonitoringChecklistMain.BTN_Supervisor.BackColor = Color.White

            'changed color to black

            FRM_MonitoringChecklistMain.BTN_Operator.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Operator.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_SuperIntendent.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_SuperIntendent.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_NxtProcess.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_NxtProcess.BackColor = Color.WhiteSmoke
        Else
            Try
                Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
                    con.Open()
                    Using cmd As New SqlCommand("SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num", con)
                        cmd.CommandType = CommandType.Text
                        With cmd.Parameters
                            .Clear()
                            .AddWithValue("@Site", Form1.cmb_site.Text)
                            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                            .AddWithValue("@emp_num", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                        End With
                        Using dr As SqlDataReader = cmd.ExecuteReader()
                            If dr.HasRows Then
                                dr.Close()
                                'FRM_MonitoringChecklistMain.txt_operator.Text = lbl_empname.Text
                                FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = False
                            End If
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            'Try
            '    Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
            '        con.Open()
            '        Using cmd As New SqlCommand("SELECT Name FROM Employee WHERE Site = @Site AND Emp_num = @Emp_num", con)
            '            cmd.CommandType = CommandType.Text
            '            With cmd.Parameters
            '                .Clear()
            '                .AddWithValue("@Site", Form1.cmb_site.Text)
            '                .AddWithValue("@@Emp_num", FRM_MonitoringChecklistMain.lbl_empnum.Text)
            '            End With
            '            Using dr As SqlDataReader = cmd.ExecuteReader()
            '                If dr.HasRows Then
            '                    If dr.Read() Then
            '                        FRM_MonitoringChecklistMain.TXT_CreatedBy.Text = dr("Name")
            '                    End If

            '                    dr.Close()
            '                End If
            '            End Using
            '        End Using
            '    End Using
            '    FRM_MonitoringChecklistMain.Show()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
        End If









        If section <> "" And position <> "Line Leader" Then
            Me.Hide()
            FRM_MonitoringChecklistMain.Show()

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




            'Select Case Uf_Resrc_Section  from [PI-SP_App].dbo.RESRC000 where RESID='P-BOXMATE-A'






            'Try
            '    Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
            '        con.Open()
            '        Using cmd As New SqlCommand("SELECT Uf_Resrc_Section FROM [PI-SP_App].dbo.RESRC000 WHERE RESID = @RESID", con)
            '            cmd.CommandType = CommandType.Text
            '            With cmd.Parameters
            '                .Clear()
            '                .AddWithValue("@RESID", txt_machine.Text)
            '            End With
            '            Using dr As SqlDataReader = cmd.ExecuteReader()
            '                If dr.HasRows Then
            '                    If dr.Read() Then
            '                        section = dr("Uf_Resrc_Section").ToString()
            '                    End If
            '                End If
            '            End Using
            '        End Using
            '    End Using
            '    FRM_MonitoringChecklistMain.Show()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            'FRM_MonitoringChecklistMain.LBL_SectionName.Text = section






            'Try
            '    OpenConnection()
            '    cmd.CommandText = "Select Uf_Resrc_Section  from [PI-SP_App].dbo.RESRC000 where RESID = @RESID "
            '    cmd.CommandType = CommandType.Text
            '    cmd.Parameters.Clear()

            '    cmd.Parameters.AddWithValue("@RESID", txt_machine.Text)
            '    dr = cmd.ExecuteReader()
            '    If dr.HasRows() Then
            '        If dr.Read() Then
            '            section = dr("Uf_Resrc_Section").ToString()
            '            dr.Close()
            '            con.Close()
            '        End If
            '        dr.Close()
            '        con.Close()
            '    End If
            '    dr.Close()
            '    con.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'Finally
            '    con.Close()
            'End Try
            'con.Close()

            If position = "Operator" Then

                If section = "CUTTING" Then
                    MonitoringChecklistOperator.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    MonitoringChecklistOperator.Show()
                    MonitoringChecklistOperator.Dock = DockStyle.Fill
                ElseIf section = "DIE CUTTING"
                    UC_OperatorDieCutting.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorDieCutting.Show()
                    UC_OperatorDieCutting.Dock = DockStyle.Fill
                ElseIf section = "OFFSET"
                    UC_OperatorOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorOff.Show()
                    UC_OperatorOff.Dock = DockStyle.Fill
                ElseIf section = "LAMINATION"
                    UC_OperatorLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorLam.Show()
                    UC_OperatorLam.Dock = DockStyle.Fill
                ElseIf section = "STRIPPING"
                    Dim UC_OperatorStrip As New UC_OperatorStripping
                    UC_OperatorStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorStrip.Show()
                    UC_OperatorStrip.Dock = DockStyle.Fill
                ElseIf section = "INSPECTION MACHINE"
                    Dim UC_OperatorQC As New UC_OperatorQCMachine
                    UC_OperatorQC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorQC.Show()
                    UC_OperatorQC.Dock = DockStyle.Fill
                ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA")
                    Dim UC_OperatorGluingLamina As New UC_OperatorGluingLamina
                    UC_OperatorGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorGluingLamina.Show()
                    UC_OperatorGluingLamina.Dock = DockStyle.Fill
                ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA")
                    Dim UC_OperatorGluing As New UC_OperatorGluing
                    UC_OperatorGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

                    UC_OperatorGluing.Show()
                    UC_OperatorGluing.Dock = DockStyle.Fill
                ElseIf section = "DIGITAL PRESS"
                    Dim UC_OperatorDigiPress As New UC_OperatorDigiPress
                    UC_OperatorDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain

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

                ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA")
                    Dim UC_SupervisorGluingLamina As New UC_SupervisorGluingLamina
                    UC_SupervisorGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                    UC_SupervisorGluingLamina.Show()
                    UC_SupervisorGluingLamina.Dock = DockStyle.Fill

                ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA")
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

                ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA")
                    Dim UC_SuperIntendentGluingLamina As New UC_SuperIntendentGluingLamina
                    UC_SuperIntendentGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
                    UC_SuperIntendentGluingLamina.Show()
                    UC_SuperIntendentGluingLamina.Dock = DockStyle.Fill

                ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA")
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
            End If
        Else
            If position = "Line Leader" Then
                MsgBox("Line leader is not allowed to add production run")
            Else
                MsgBox("this machine is no section")
            End If

        End If





        If section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            FRM_MonitoringChecklistMain.LBL_SectionName.Text = "GLUING LAMINA"

        End If





    End Sub

    Private Sub BTN_MonitoringChecklistSummary_Click(sender As Object, e As EventArgs) Handles BTN_MonitoringChecklistSummary.Click
        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            FRM_MonitoringChecklistSummary.Show()
            Me.Hide()
        End If


    End Sub
    Private Sub populatefields()


        Try
            Dim check_machine As String = ""
            con.Open()
            ' MsgBox(mcdate)
            Dim cmd_select_pispapp_sppmcHdr As New SqlCommand("Select_pispapp_sppmcHdr", con)
            cmd_select_pispapp_sppmcHdr.CommandType = CommandType.StoredProcedure
            cmd_select_pispapp_sppmcHdr.Parameters.AddWithValue("@jonumber", txt_joborder.Text)
            cmd_select_pispapp_sppmcHdr.Parameters.AddWithValue("@josuffix", txt_suffix.Text)
            cmd_select_pispapp_sppmcHdr.Parameters.AddWithValue("@operationnum", txt_opernum.Text)


            Dim cmd_select_sppmcHdr As New SqlCommand("Select_sppmcHdr_operator", con) 'Change SP from Select_sppmcHdr to Select_sppmcHdr_operator
            cmd_select_sppmcHdr.CommandType = CommandType.StoredProcedure
            cmd_select_sppmcHdr.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd_select_sppmcHdr.Parameters.AddWithValue("@mcdate", mcdate)
            cmd_select_sppmcHdr.Parameters.AddWithValue("@job", txt_joborder.Text)
            cmd_select_sppmcHdr.Parameters.AddWithValue("@suffix", txt_suffix.Text)
            cmd_select_sppmcHdr.Parameters.AddWithValue("@opernum", txt_opernum.Text)
            cmd_select_sppmcHdr.Parameters.AddWithValue("@Shift", Form1.cmbshift.Text)
            'cmd_select_sppmcHdr.Parameters.AddWithValue("@empnum", globalvariable.empnum)
            'cmd_select_sppmcHdr.Parameters.AddWithValue("@section", section_code) -- change to section
            cmd_select_sppmcHdr.Parameters.AddWithValue("@section", section)
            If txt_opernum.Text.Length = 2 AndAlso txt_joborder.Text.Length > 9 AndAlso txt_suffix.Text <> "" Then
                Dim read_cmd_select_sppmcHdr As SqlDataReader = cmd_select_sppmcHdr.ExecuteReader
                If read_cmd_select_sppmcHdr.HasRows Then
                    globalvariable.sppmchdr_existing_mcnum = True
                    While read_cmd_select_sppmcHdr.Read

                        check_machine = read_cmd_select_sppmcHdr("machine").ToString
                        txt_jobname.Text = read_cmd_select_sppmcHdr("jobname").ToString


                        txt_jobqty.Text = read_cmd_select_sppmcHdr("jobqty").ToString
                        txt_machine.Text = read_cmd_select_sppmcHdr("machine").ToString
                        FRM_MonitoringChecklistMain.txt_machine.Text = read_cmd_select_sppmcHdr("machine").ToString
                        FRM_MonitoringChecklistMain.txt_job.Text = read_cmd_select_sppmcHdr("job").ToString
                        FRM_MonitoringChecklistMain.txt_jobname.Text = read_cmd_select_sppmcHdr("jobname").ToString
                        FRM_MonitoringChecklistMain.txt_jobname_ext.Text = read_cmd_select_sppmcHdr("jobname_ext").ToString
                        job_name = read_cmd_select_sppmcHdr("jobname_ext").ToString
                        'FRM_MonitoringChecklistMain.txt_date.Text = read_cmd_select_sppmcHdr("mcdate").ToString
                        mcdate = read_cmd_select_sppmcHdr("mcdate").ToString
                        'MsgBox(mcdate.ToString("MM/dd/yyyy"))
                        FRM_MonitoringChecklistMain.txt_date.Text = mcdate.ToString("MM/dd/yyyy")
                        FRM_MonitoringChecklistMain.txt_jobqty.Text = Convert.ToDecimal(read_cmd_select_sppmcHdr("jobqty")).ToString("N0")
                        FRM_MonitoringChecklistMain.txt_um.Text = read_cmd_select_sppmcHdr("um").ToString
                        FRM_MonitoringChecklistMain.txt_shift.Text = Form1.cmbshift.Text
                        'FRM_MonitoringChecklistMain.txt_operator.Text = Me.lbl_empname.Text
                        FRM_MonitoringChecklistMain.TXT_MCNO.Text = read_cmd_select_sppmcHdr("mcnum").ToString

                        FRM_MonitoringChecklistMain.txt_operator.Text = read_cmd_select_sppmcHdr("operator_name").ToString  'added 08 oct 2024
                        FRM_MonitoringChecklistMain.TXT_CreatedBy.Text = read_cmd_select_sppmcHdr("created_supervisor").ToString  'added 08 oct 2024
                        'FRM_MonitoringChecklistMain.txt_operator.Text = read_cmd_select_sppmcHdr("Name").ToString  comment 11:53 am oct 2 2024
                        'I added TXT for site
                    End While

                Else
                    read_cmd_select_sppmcHdr.Close()
                    globalvariable.sppmchdr_existing_mcnum = False
                    Dim read_cmd_select_pispapp_sppmcHdr As SqlDataReader = cmd_select_pispapp_sppmcHdr.ExecuteReader
                    If read_cmd_select_pispapp_sppmcHdr.HasRows Then
                        While read_cmd_select_pispapp_sppmcHdr.Read


                            check_machine = read_cmd_select_pispapp_sppmcHdr("MACHINE").ToString

                            txt_jobname.Text = read_cmd_select_pispapp_sppmcHdr("description").ToString
                            txt_jobqty.Text = read_cmd_select_pispapp_sppmcHdr("jobqty").ToString + " " + read_cmd_select_pispapp_sppmcHdr("um").ToString
                            txt_machine.Text = read_cmd_select_pispapp_sppmcHdr("MACHINE").ToString
                            FRM_MonitoringChecklistMain.txt_machine.Text = read_cmd_select_pispapp_sppmcHdr("MACHINE").ToString
                            FRM_MonitoringChecklistMain.txt_job.Text = read_cmd_select_pispapp_sppmcHdr("job").ToString
                            FRM_MonitoringChecklistMain.txt_jobname.Text = read_cmd_select_pispapp_sppmcHdr("item").ToString
                            FRM_MonitoringChecklistMain.txt_jobname_ext.Text = read_cmd_select_pispapp_sppmcHdr("description").ToString + read_cmd_select_pispapp_sppmcHdr("Uf_itemdesc_ext").ToString
                            job_name = read_cmd_select_pispapp_sppmcHdr("description").ToString
                            FRM_MonitoringChecklistMain.txt_date.Text = mcdate
                            FRM_MonitoringChecklistMain.txt_jobqty.Text = Convert.ToDecimal(read_cmd_select_pispapp_sppmcHdr("jobqty")).ToString("N0")
                            FRM_MonitoringChecklistMain.txt_um.Text = read_cmd_select_pispapp_sppmcHdr("um").ToString
                            FRM_MonitoringChecklistMain.txt_shift.Text = Form1.cmbshift.Text
                            'FRM_MonitoringChecklistMain.txt_operator.Text = Me.lbl_empname.Text
                            FRM_MonitoringChecklistMain.txt_shift.Text = Form1.cmbshift.Text


                        End While
                        read_cmd_select_pispapp_sppmcHdr.Close()
                    End If
                    ' MsgBox("No rows")
                End If
            Else
                txt_jobname.Clear()
                txt_jobqty.Clear()
                txt_machine.Clear()
                FRM_MonitoringChecklistMain.txt_machine.Clear()
                FRM_MonitoringChecklistMain.txt_job.Clear()
                FRM_MonitoringChecklistMain.txt_jobname.Clear()
                FRM_MonitoringChecklistMain.txt_jobname_ext.Clear()
                FRM_MonitoringChecklistMain.txt_jobqty.Clear()
                FRM_MonitoringChecklistMain.txt_um.Clear()
                FRM_MonitoringChecklistMain.txt_shift.Clear()
                FRM_MonitoringChecklistMain.txt_operator.Clear()
                FRM_MonitoringChecklistMain.txt_shift.Clear()

                'joborder = cleartext()
                'suffix = cleartext()
                'oper_num = cleartext()
            End If


            If check_machine <> "" Then

                Try
                    Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
                        con.Open()
                        Using cmd As New SqlCommand("SELECT Uf_Resrc_Section FROM [PI-SP_App].dbo.RESRC000 WHERE RESID = @RESID", con)
                            cmd.CommandType = CommandType.Text
                            With cmd.Parameters
                                .Clear()
                                .AddWithValue("@RESID", check_machine)
                            End With
                            Using dr As SqlDataReader = cmd.ExecuteReader()
                                If dr.HasRows Then
                                    If dr.Read() Then
                                        section = dr("Uf_Resrc_Section").ToString()


                                    End If
                                End If
                            End Using
                        End Using
                    End Using



                    'If section = "" Then
                    '    section_code = ""
                    'ElseIf section = "DIE CUTTING" Then
                    '    section_code = "DT"
                    'Else
                    '    Using cmd As New SqlCommand("SELECT * FROM SectionMasterfile WHERE SECTION = @SECTION", con)
                    '        cmd.CommandType = CommandType.Text
                    '        cmd.Parameters.Clear()
                    '        cmd.Parameters.AddWithValue("@SECTION", section)

                    '        Using dr As SqlDataReader = cmd.ExecuteReader()
                    '            If dr.HasRows Then
                    '                If dr.Read() Then
                    '                    If section = "DIE CUTTING" Then
                    '                        section_code = "DT"
                    '                    Else
                    '                        section_code = dr("ZZCODE").ToString()
                    '                    End If
                    '                End If
                    '            End If
                    '        End Using
                    '    End Using



                    'End If



                    If section = "CUTTING" Then
                        section_code = "CU"
                    ElseIf section = "DIE CUTTING" Then
                        section_code = "DT"
                    ElseIf section = "OFFSET" Then
                        section_code = "OF"
                    ElseIf section = "LAMINATION" Then
                        section_code = "LA"
                    ElseIf section = "STRIPPING" Then
                        section_code = "ST"
                    ElseIf section = "INSPECTION MACHINE" Then
                        section_code = "QC"
                    ElseIf section = "GLUING" Then
                        section_code = "GL"
                    ElseIf section = "DIGITAL PRESS" Then
                        section_code = "DP"
                    ElseIf section = "FINISHING" Then
                        section_code = "FI"
                    Else
                        section = ""
                    End If


                    'Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
                    '    con.Open()
                    '    Using cmd As New SqlCommand("SELECT * FROM SectionMasterfile WHERE SECTION = @SECTION")
                    '        cmd.CommandType = CommandType.Text
                    '        With cmd.Parameters
                    '            .Clear()
                    '            .AddWithValue("@SECTION",section)
                    '        End With
                    '        Using dr As SqlDataReader = cmd.ExecuteReader()
                    '            If dr.HasRows Then
                    '                If dr.Read() Then

                    '                    If section = "DIE CUTTING" Then
                    '                        section_code = "DT"
                    '                    Else
                    '                        section_code = dr("ZZCODE").ToString()
                    '                    End If




                    '                End If
                    '            End If
                    '        End Using
                    '    End Using
                    'End Using

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try



            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


        UpdateButtonState()
    End Sub

    Private Sub txt_opernum_TextChanged(sender As Object, e As EventArgs) Handles txt_opernum.TextChanged
        populatefields()
    End Sub

    Private Sub FRM_ProcessJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MsgBox(globalvariable.empnum)
        lbl_empnum.Text = globalvariable.empnum
        lbl_empname.Text = globalvariable.empname
        If position = "Superintendent" Then
            txt_joborder.Enabled = False
            txt_suffix.Enabled = False
            txt_opernum.Enabled = False
        Else
            txt_joborder.Enabled = True
            txt_suffix.Enabled = True
            txt_opernum.Enabled = True
        End If
    End Sub

    Private Sub txt_joborder_TextChanged(sender As Object, e As EventArgs) Handles txt_joborder.TextChanged
        UpdateButtonState()
        populatefields()
    End Sub

    Private Sub txt_suffix_TextChanged(sender As Object, e As EventArgs) Handles txt_suffix.TextChanged
        UpdateButtonState()
        populatefields()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_printpallet.Click


        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else


            joborder = txt_joborder.Text
            suffix = txt_suffix.Text
            oper_num = txt_opernum.Text

            Form2.txtjoborder.Text = joborder
            Form2.txtjobsuffix.Text = suffix
            Form2.txtjobordert3.Text = joborder
            Form2.txtjobsuffixt3.Text = suffix
            Form2.txtjob_subcon.Text = joborder
            Form2.txtsuffix_subcon.Text = suffix

            Form2.Show()
            Form2.TabControl1.SelectedTab = Form2.TabPage1
            Form2.txtopernum_subcon.Text = oper_num
            Form2.txtjoboperation.Text = oper_num
            Form2.txtjoboperationt3.Text = oper_num
            Me.Hide()

        End If

        'MsgBox(Form1.cmb_site.Text)
        'MsgBox(Form1.cmbuserid.Text)
        'MsgBox(Form1.cmbshift.Text)
    End Sub

    Private Sub BTN_Logout_Click(sender As Object, e As EventArgs) Handles BTN_Logout.Click
        LogoutBTNInitiated = True
        Form1.Show()
        FRM_MonitoringChecklistMain.Close()
        empnum = cleartext()
        empname = cleartext()

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_generateqr.Click

        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else



            joborder = txt_joborder.Text
            suffix = txt_suffix.Text
            oper_num = txt_opernum.Text

            Dim writer As New BarcodeWriter
            Dim writer1 As New BarcodeWriter

            writer1.Format = BarcodeFormat.QR_CODE
            writer.Format = BarcodeFormat.CODE_93

            ' Dim data1 As String = DataGridView2.SelectedCells(0).Value.ToString
            Form6.PictureBox1.Image = writer1.Write(joborder)
            Form6.PictureBox2.Image = writer1.Write(suffix)
            Form6.PictureBox3.Image = writer1.Write(oper_num)
            Form6.txtjob.Text = joborder
            Form6.txtsuffix.Text = suffix
            Form6.txtoperation.Text = oper_num
            Form6.rtbjobname.Text = job_name
            Form6.txtjobqty.Text = txt_jobqty.Text
            Form6.PictureBox4.Image = writer1.Write(empnum)
            Form6.txtemployee.Text = empname
            Form6.PictureBox5.Image = writer1.Write(user_shift)
            Form6.txtshift.Text = user_shift
            Form6.txtempnum.Text = empnum

            Form6.Refresh()
            Form6.Show()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub clear_frm_checklist_main()
        FRM_MonitoringChecklistMain.TXT_MCNO.Clear()
        FRM_MonitoringChecklistMain.PBox_QRCode.Image = Nothing

    End Sub
    Private Sub BTN_AddFinishingDailyOut_Click(sender As Object, e As EventArgs) Handles BTN_AddFinishingDailyOut.Click

        check_app_version()
        If app_version <> check_app_version() Then


            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If




        If position <> "Supervisor" And position <> "Operator" And position <> "Line Leader" Then

            MessageBox.Show("Invalid Position: Only  Operators, Line Leader and Supervisors are allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Exit Sub
        End If





        clear_frm_checklist_main()


        FRM_MonitoringChecklistMain.TXT_OrigSection.Text = section
        FRM_MonitoringChecklistMain.TXT_OrigSectionCode.Text = section_code


        section = "FINISHING"
        section_code = "FI"

        Try
            Dim connectionString As String = "Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011"

            Using con As New SqlConnection(connectionString)
                con.Open()
                Using cmd_select_sppmcHdr As New SqlCommand("Select_sppmcHdr_operator", con)
                    cmd_select_sppmcHdr.CommandType = CommandType.StoredProcedure
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@Site", Form1.cmb_site.Text.Trim())
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@mcdate", mcdate)
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@job", txt_joborder.Text.Trim())
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@suffix", txt_suffix.Text.Trim())
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@opernum", txt_opernum.Text.Trim())
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@Shift", Form1.cmbshift.Text.Trim())
                    cmd_select_sppmcHdr.Parameters.AddWithValue("@section", "FINISHING")

                    ' Validate input before executing the command
                    If txt_opernum.Text.Trim().Length = 2 AndAlso txt_joborder.Text.Trim().Length > 9 AndAlso txt_suffix.Text.Trim() <> "" Then
                        Using read_cmd_select_sppmcHdr As SqlDataReader = cmd_select_sppmcHdr.ExecuteReader()
                            If read_cmd_select_sppmcHdr.HasRows Then
                                globalvariable.sppmchdr_existing_mcnum = True
                                While read_cmd_select_sppmcHdr.Read()
                                    txt_jobname.Text = read_cmd_select_sppmcHdr("jobname").ToString()
                                    txt_jobqty.Text = read_cmd_select_sppmcHdr("jobqty").ToString()
                                    txt_machine.Text = read_cmd_select_sppmcHdr("machine").ToString()

                                    ' Assign values to Monitoring Checklist Form
                                    With FRM_MonitoringChecklistMain
                                        .txt_machine.Text = read_cmd_select_sppmcHdr("machine").ToString()
                                        .txt_job.Text = read_cmd_select_sppmcHdr("job").ToString()
                                        .txt_jobname.Text = read_cmd_select_sppmcHdr("jobname").ToString()
                                        .txt_jobname_ext.Text = read_cmd_select_sppmcHdr("jobname_ext").ToString()
                                        .txt_date.Text = Convert.ToDateTime(read_cmd_select_sppmcHdr("mcdate")).ToString("MM/dd/yyyy")
                                        .txt_jobqty.Text = Convert.ToDecimal(read_cmd_select_sppmcHdr("jobqty")).ToString("N0")
                                        .txt_um.Text = read_cmd_select_sppmcHdr("um").ToString()
                                        .txt_shift.Text = Form1.cmbshift.Text.Trim()
                                        .TXT_MCNO.Text = read_cmd_select_sppmcHdr("mcnum").ToString()
                                        .txt_operator.Text = read_cmd_select_sppmcHdr("operator_name").ToString()
                                        .TXT_CreatedBy.Text = read_cmd_select_sppmcHdr("created_supervisor").ToString()
                                    End With
                                End While
                            Else

                                ' Reset form fields if no data is found
                                With FRM_MonitoringChecklistMain
                                    .TXT_MCNO.Text = ""
                                    .txt_operator.Text = ""
                                    .TXT_CreatedBy.Text = ""
                                    .BTN_AddMCNo.Enabled = True
                                    .BTN_AddMCNo.BackColor = Color.DodgerBlue
                                    .BTN_AddMCNo.ForeColor = Color.White
                                End With
                            End If
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        joborder = txt_joborder.Text
        suffix = txt_suffix.Text
        oper_num = txt_opernum.Text

        'Try
        '    OpenConnection()
        '    cmd.CommandText = "Select_sppmcHdr_operator"
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Clear()
        '    With cmd.Parameters
        '        .AddWithValue("@Site", Form1.cmb_site.Text)
        '        .AddWithValue("@mcdate", mcdate)
        '        .AddWithValue("@job", txt_joborder.Text)
        '        .AddWithValue("@suffix", txt_suffix.Text)
        '        .AddWithValue("@opernum", txt_opernum.Text)
        '        .AddWithValue("@Shift", Form1.cmbshift.Text)
        '        .AddWithValue("@section", "FINISHING")
        '    End With
        '    If txt_opernum.Text.Length = 2 AndAlso txt_joborder.Text.Length > 9 AndAlso txt_suffix.Text <> "" Then
        '        dr = cmd.ExecuteReader
        '        If dr.HasRows Then
        '            If dr.Read Then
        '                FRM_MonitoringChecklistMain.TXT_MCNO.Text = dr("mcnum").ToString
        '                FRM_MonitoringChecklistMain.txt_operator.Text = dr("operator_name").ToString  'added 08 oct 2024
        '                FRM_MonitoringChecklistMain.TXT_CreatedBy.Text = dr("created_supervisor").ToString  'added 08 oct 2024
        '                dr.Close()
        '                con.Close()

        '            Else
        '                dr.Close()
        '                con.Close()
        '                FRM_MonitoringChecklistMain.TXT_MCNO.Text = ""
        '            End If

        '        End If
        '        dr.Close()
        '        con.Close()
        '    End If

        '    dr.Close()
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    con.Close()
        'End Try




        'Try
        '    con.Open()
        '    Dim cmd As New SqlCommand("Select * FROM sppmcHdr Where Site = '" & Form1.cmb_site.Text & "' And mcnum = '" & Form1.cmb_site.Text & "' And ", con)
        '    Dim dr As SqlDataReader = cmd.ExecuteReader
        '    If dr.HasRows Then
        '        While dr.Read
        '            maintenance_version = dr("Version").ToString
        '        End While
        '        dr.Close()
        '    End If


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    con.Close()
        'End Try




        'MsgBox(section)

        'MsgBox(section_code)


        'FRM_MonitoringChecklistMain.LBL_SectionName.Text = section
        FRM_MonitoringChecklistMain.LBL_Title.Text = "FINISHING DAILY OUTPUT"

        FRM_MonitoringChecklistMain.LBL_SectionName.Visible = False

        'FRM_MonitoringChecklistMain.BTN_AddMCNo.BackColor = Color.Blue
        'FRM_MonitoringChecklistMain.BTN_AddMCNo.ForeColor = Color.White
        'FRM_MonitoringChecklistMain.LBL_Section.Text = section

        'If globalvariable.sppmchdr_existing_mcnum = True Then
        '    'MsgBox("Mc number already Exist")
        '    'FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = False

        '    ' MsgBox("mcexist")

        '    joborder = txt_joborder.Text
        '    suffix = txt_suffix.Text
        '    oper_num = txt_opernum.Text

        '    'MsgBox(section)
        '    FRM_MonitoringChecklistMain.lbl_empnum.Text = lbl_empnum.Text
        '    FRM_MonitoringChecklistMain.lbl_empname.Text = lbl_empname.Text

        '    Hide()
        'Else
        '    ' MsgBox("mcnotexist")
        '    FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = True
        '    joborder = txt_joborder.Text
        '    suffix = txt_suffix.Text
        '    oper_num = txt_opernum.Text

        '    'MsgBox(section)
        '    'FRM_MonitoringChecklistMain.lbl_empnum.Text = lbl_empnum.Text
        '    'FRM_MonitoringChecklistMain.lbl_empname.Text = lbl_empname.Text
        '    Hide()
        'End If





        'If section = "CUTTING" Or section = "DIE CUTTING" Or section = "OFFSET" Or section = "LAMINATION" Then
        If position = "Supervisor" Then
            'FRM_MonitoringChecklistMain.txt_operator.Text = ""



            Me.Hide()
            FRM_MonitoringChecklistMain.Show()


            For i = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            'FOR CUTTING
            Dim UC_SupervisorFinishing As New UC_SupervisorFinishing
            UC_SupervisorFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SupervisorFinishing.Show()
            UC_SupervisorFinishing.Dock = DockStyle.Fill



            FRM_MonitoringChecklistMain.BTN_Supervisor.ForeColor = Color.DodgerBlue
            FRM_MonitoringChecklistMain.BTN_Supervisor.BackColor = Color.White

            'changed color to black

            FRM_MonitoringChecklistMain.BTN_Operator.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_Operator.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_SuperIntendent.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_SuperIntendent.BackColor = Color.WhiteSmoke

            FRM_MonitoringChecklistMain.BTN_NxtProcess.ForeColor = Color.Black
            FRM_MonitoringChecklistMain.BTN_NxtProcess.BackColor = Color.WhiteSmoke
        Else
            Try
                Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
                    con.Open()
                    Using cmd As New SqlCommand("SELECT * FROM sppmcHdr WHERE Site = @Site And mcnum = @mcnum And emp_num = @emp_num", con)
                        cmd.CommandType = CommandType.Text
                        With cmd.Parameters
                            .Clear()
                            .AddWithValue("@Site", Form1.cmb_site.Text)
                            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                            .AddWithValue("@emp_num", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                        End With
                        Using dr As SqlDataReader = cmd.ExecuteReader()
                            If dr.HasRows Then
                                dr.Close()
                                'FRM_MonitoringChecklistMain.txt_operator.Text = lbl_empname.Text
                                FRM_MonitoringChecklistMain.BTN_AddMCNo.Enabled = False
                            End If
                        End Using
                    End Using
                End Using
                Me.Hide()
                FRM_MonitoringChecklistMain.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            'Try
            '    Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
            '        con.Open()
            '        Using cmd As New SqlCommand("SELECT Name FROM Employee WHERE Site = @Site And Emp_num = @Emp_num", con)
            '            cmd.CommandType = CommandType.Text
            '            With cmd.Parameters
            '                .Clear()
            '                .AddWithValue("@Site", Form1.cmb_site.Text)
            '                .AddWithValue("@@Emp_num", FRM_MonitoringChecklistMain.lbl_empnum.Text)
            '            End With
            '            Using dr As SqlDataReader = cmd.ExecuteReader()
            '                If dr.HasRows Then
            '                    If dr.Read() Then
            '                        FRM_MonitoringChecklistMain.TXT_CreatedBy.Text = dr("Name")
            '                    End If
            '
            '                    dr.Close()
            '                End If
            '            End Using
            '        End Using
            '    End Using
            '    FRM_MonitoringChecklistMain.Show()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End If

        'End If









    End Sub

    Private Sub BTN_UserMaintenance_Click(sender As Object, e As EventArgs) Handles BTN_UserMaintenance.Click
        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            Me.Hide()
            FRM_UserMaintenance.Show()
        End If
    End Sub
End Class
