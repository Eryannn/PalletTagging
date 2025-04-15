
Imports System.Data.SqlClient
Imports ZXing

Public Class FRM_MonitoringChecklistMain

    '4.5 Added Clean Code for Exiting Form
    Private Sub FRM_MonitoringChecklistMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FRM_ProcessJob.Show()
    End Sub

    Public mcnum_output As Boolean

    'declaration variable

    Private lastNumber As Integer = 0


    Private Sub FRM_MonitoringChecklistMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            LBL_SectionName.Text = "GLUING LAMINA"
        Else
            LBL_SectionName.Text = section
        End If

        If position <> "Supervisor" Then
            BTN_SaveHeader.Enabled = False
        Else
            BTN_SaveHeader.Enabled = True

        End If

        If TXT_MCNO.Text = "" Then
            BTN_SaveHeader.Enabled = False
        Else
            BTN_SaveHeader.Enabled = True

        End If



        'If lbl_empname.Text <> TXT_CreatedBy.Text Then
        '    BTN_SaveHeader.Enabled = False

        'End If




        'section = TXT_OrigSection.Text
        'section_code = TXT_OrigSectionCode.Text


        If section = "CUTTING" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True


                'If TXT_CreatedBy.Text = "" Then
                '    TXT_CreatedBy.Text = empname
                'End If

                TXT_CreatedBy.Text = empname



                Dim MonitoringChecklistSupervisorCutting As New UC_MonitoringChecklistSupervisor
                MonitoringChecklistSupervisorCutting.Parent = PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistSupervisorCutting.Show()
                MonitoringChecklistSupervisorCutting.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False
                    BTN_AddMCNo.BackColor = Color.Gray
                Else

                End If






            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text
                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True

                Dim MonitoringChecklistOperatorCutting As New UC_MonitoringChecklistOperators
                MonitoringChecklistOperatorCutting.Parent = PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistOperatorCutting.Show()
                MonitoringChecklistOperatorCutting.Dock = DockStyle.Fill


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()




            ElseIf position = "Superintendent"
                Dim MonitoringChecklistSuperintendentCutting As New UC_MonitoringChecklistSuperIntendent
                MonitoringChecklistSuperintendentCutting.Parent = PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistSuperintendentCutting.Show()
                MonitoringChecklistSuperintendentCutting.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_MonitoringChecklistNxtProcess As New UC_MonitoringChecklistNxtProcess
                UC_MonitoringChecklistNxtProcess.Parent = PNL_MonitoringChecklistOperatorMain
                UC_MonitoringChecklistNxtProcess.Show()
                UC_MonitoringChecklistNxtProcess.Dock = DockStyle.Fill

            End If



        End If



        If section = "DIE CUTTING" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorDC As New UC_SupervisorDIeCutting
                UC_SupervisorDC.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorDC.Show()
                UC_SupervisorDC.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorDC As New UC_OperatorDIeCutting
                UC_OperatorDC.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorDC.Show()
                UC_OperatorDC.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim MonitoringChecklistSuperintendentDC As New UC_SuperIntendentDieCutting
                MonitoringChecklistSuperintendentDC.Parent = PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistSuperintendentDC.Show()
                MonitoringChecklistSuperintendentDC.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessDieCutting As New UC_NxtProcessDieCutting
                UC_NxtProcessDieCutting.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessDieCutting.Show()
                UC_NxtProcessDieCutting.Dock = DockStyle.Fill

            End If




        End If


        If section = "OFFSET" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True


                TXT_CreatedBy.Text = empname




                Dim UC_SupervisorOFF As New UC_SupervisorOffset
                UC_SupervisorOFF.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorOFF.Show()
                UC_SupervisorOFF.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorOff As New UC_OperatorOffset
                UC_OperatorOff.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorOff.Show()
                UC_OperatorOff.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentOff As New UC_SuperIntendentOffset
                UC_SuperIntendentOff.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentOff.Show()
                UC_SuperIntendentOff.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessOffset As New UC_NxtProcessOffset
                UC_NxtProcessOffset.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessOffset.Show()
                UC_NxtProcessOffset.Dock = DockStyle.Fill

            End If

        End If



        If section = "LAMINATION" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorLam As New UC_SupervisorLamination
                UC_SupervisorLam.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorLam.Show()
                UC_SupervisorLam.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorLam As New UC_OperatorLamination
                UC_OperatorLam.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorLam.Show()
                UC_OperatorLam.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()
                    con.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    dr.Close()
                    con.Close()
                    txt_operator.Text = empname



                End If
                dr.Close()
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentLam As New UC_SuperIntendentLamination
                UC_SuperIntendentLam.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentLam.Show()
                UC_SuperIntendentLam.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessLamination As New UC_NxtProcessLamination
                UC_NxtProcessLamination.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessLamination.Show()
                UC_NxtProcessLamination.Dock = DockStyle.Fill

            End If

        End If



        If section = "STRIPPING" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorStrip As New UC_SupervisorStripping
                UC_SupervisorStrip.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorStrip.Show()
                UC_SupervisorStrip.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorStrip As New UC_OperatorStripping
                UC_OperatorStrip.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorStrip.Show()
                UC_OperatorStrip.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentStrip As New UC_SuperIntendentStripping
                UC_SuperIntendentStrip.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentStrip.Show()
                UC_SuperIntendentStrip.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessStripping As New UC_NxtProcessStripping
                UC_NxtProcessStripping.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessStripping.Show()
                UC_NxtProcessStripping.Dock = DockStyle.Fill

            End If

        End If




        If section = "INSPECTION MACHINE" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorQC As New UC_SupervisorQCMachine
                UC_SupervisorQC.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorQC.Show()
                UC_SupervisorQC.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorQC As New UC_OperatorQCMachine
                UC_OperatorQC.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorQC.Show()
                UC_OperatorQC.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentQC As New UC_SuperIntendentQCMachine
                UC_SuperIntendentQC.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentQC.Show()
                UC_SuperIntendentQC.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessQC As New UC_NxtProcessQC
                UC_NxtProcessQC.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessQC.Show()
                UC_NxtProcessQC.Dock = DockStyle.Fill

            End If

        End If



        If section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA") Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorGluing As New UC_SupervisorGluing
                UC_SupervisorGluing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorGluing.Show()
                UC_SupervisorGluing.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorGluing As New UC_OperatorGluing
                UC_OperatorGluing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorGluing.Show()
                UC_OperatorGluing.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentGluing As New UC_SuperIntendentGluing
                UC_SuperIntendentGluing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentGluing.Show()
                UC_SuperIntendentGluing.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessGluing As New UC_NxtProcessGluing
                UC_NxtProcessGluing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessGluing.Show()
                UC_NxtProcessGluing.Dock = DockStyle.Fill

            End If

        End If



        If section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorGluingLamina As New UC_SupervisorGluingLamina
                UC_SupervisorGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorGluingLamina.Show()
                UC_SupervisorGluingLamina.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorGluingLamina As New UC_OperatorGluingLamina
                UC_OperatorGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorGluingLamina.Show()
                UC_OperatorGluingLamina.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentGluingLamina As New UC_SuperIntendentGluingLamina
                UC_SuperIntendentGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentGluingLamina.Show()
                UC_SuperIntendentGluingLamina.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessGluingLamina As New UC_NxtProcessGluingLamina
                UC_NxtProcessGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessGluingLamina.Show()
                UC_NxtProcessGluingLamina.Dock = DockStyle.Fill

            End If

        End If





        If section = "DIGITAL PRESS" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorDigiPress As New UC_SupervisorDigiPress
                UC_SupervisorDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorDigiPress.Show()
                UC_SupervisorDigiPress.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorDigiPress As New UC_OperatorDigiPress
                UC_OperatorDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorDigiPress.Show()
                UC_OperatorDigiPress.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()
                    con.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    dr.Close()
                    con.Close()
                    txt_operator.Text = empname



                End If
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentDigiPress As New UC_SuperIntendentDigiPress
                UC_SuperIntendentDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentDigiPress.Show()
                UC_SuperIntendentDigiPress.Dock = DockStyle.Fill

            ElseIf position = "Inspector"
                Dim UC_NxtProcessDigiPress As New UC_NxtProcessDigiPress
                UC_NxtProcessDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
                UC_NxtProcessDigiPress.Show()
                UC_NxtProcessDigiPress.Dock = DockStyle.Fill

            End If


        End If



        If section = "FINISHING" Then


            If position = "Supervisor" Then
                BTN_AddMCNo.Visible = True

                TXT_CreatedBy.Text = empname


                Dim UC_SupervisorFinishing As New UC_SupervisorFinishing
                UC_SupervisorFinishing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorFinishing.Show()
                UC_SupervisorFinishing.Dock = DockStyle.Fill

                If TXT_MCNO.Text <> "" Then
                    BTN_AddMCNo.Enabled = False

                End If




            ElseIf position = "Operator" Or position = "Line Leader"
                txt_operator.Text = lbl_empname.Text


                Dim UC_OperatorFinishing As New UC_OperatorFinishing
                UC_OperatorFinishing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_OperatorFinishing.Show()
                UC_OperatorFinishing.Dock = DockStyle.Fill

                'LBL_CreatedBy.Text = "Created by sv"
                'TXT_CreatedBy.Visible = True


                OpenConnection()
                cmd.CommandText = "SELECT * FROM sppmcHdr WHERE Site = @Site AND mcnum = @mcnum And emp_num = @emp_num "
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", TXT_MCNO.Text)
                    .AddWithValue("@emp_num", lbl_empnum.Text)
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Close()
                    con.Close()

                    'txt_operator.Text = lbl_empname.Text
                    BTN_AddMCNo.Enabled = False
                Else
                    dr.Close()
                    con.Close()
                    txt_operator.Text = empname



                End If
                dr.Close()
                con.Close()



            ElseIf position = "Superintendent"
                Dim UC_SuperIntendentFinishing As New UC_SuperIntendentFinishing
                UC_SuperIntendentFinishing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SuperIntendentFinishing.Show()
                UC_SuperIntendentFinishing.Dock = DockStyle.Fill



            End If


        End If























        lbl_empnum.Text = empnum
        lbl_empname.Text = empname


        LBL_DummyCodeSection.Text = section_code
        '  LBL_DummyCodeSection.Text = section


        'disable button
        If position = "Operator" Then
            BTN_Operator.Enabled = True
            BTN_Supervisor.Enabled = False
            BTN_SuperIntendent.Enabled = False
            BTN_NxtProcess.Enabled = False
            BTN_AddMCNo.Text = "Update"
        ElseIf position = "Line Leader"
            BTN_Operator.Enabled = True
            BTN_Supervisor.Enabled = False
            BTN_SuperIntendent.Enabled = False
            BTN_NxtProcess.Enabled = False

        ElseIf position = "Supervisor"
            BTN_Operator.Enabled = True
            BTN_Supervisor.Enabled = True
            BTN_SuperIntendent.Enabled = False
            BTN_NxtProcess.Enabled = True
            If BTN_AddMCNo.Text = "Update" Then
                BTN_AddMCNo.Enabled = False
            End If

        ElseIf position = "Superintendent"
            BTN_Operator.Enabled = True
            BTN_Supervisor.Enabled = True
            BTN_SuperIntendent.Enabled = True
            BTN_NxtProcess.Enabled = True

        ElseIf position = "Inspector"
            BTN_Operator.Enabled = False
            BTN_Supervisor.Enabled = False
            BTN_SuperIntendent.Enabled = False
            BTN_NxtProcess.Enabled = True


        End If


        If BTN_AddMCNo.Enabled = False Then
            BTN_AddMCNo.BackColor = Color.White
            BTN_AddMCNo.ForeColor = Color.Black
        End If

        If txt_operator.Text <> "" Then
            BTN_AddMCNo.Enabled = False
        End If




        Dim writer As New BarcodeWriter
        Dim writer1 As New BarcodeWriter

        writer1.Format = BarcodeFormat.QR_CODE
        writer.Format = BarcodeFormat.CODE_93




        'If TXT_MCNO.Text = "" Then
        '    MsgBox("No mc number!")
        'End If


        If section = "FINISHING" Then
            BTN_NxtProcess.Enabled = False
        End If




    End Sub

    Private Function load_job_suffix_opernum()
        Try
            con.Open()
            Dim cmd As New SqlCommand("Select * from sppmcHdr where mcnum = @mcnum AND site=@site", con)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function


    Private Sub BTN_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Supervisor.Click
        Dim i As Integer
        For i = 0 To 0
            PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        If section = "CUTTING" Then
            Dim MonitoringChecklistSupervisor As New UC_MonitoringChecklistSupervisor
            MonitoringChecklistSupervisor.Parent = PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistSupervisor.Show()
            MonitoringChecklistSupervisor.Dock = DockStyle.Fill

        ElseIf section = "DIE CUTTING" Then
            Dim UC_SupervisorDieCut As New UC_SupervisorDIeCutting
            UC_SupervisorDieCut.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorDieCut.Show()
            UC_SupervisorDieCut.Dock = DockStyle.Fill

        ElseIf section = "OFFSET" Then
            Dim UC_SupervisorOFF As New UC_SupervisorOffset
            UC_SupervisorOFF.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorOFF.Show()
            UC_SupervisorOFF.Dock = DockStyle.Fill

        ElseIf section = "LAMINATION" Then
            Dim UC_SupervisorLam As New UC_SupervisorLamination
            UC_SupervisorLam.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorLam.Show()
            UC_SupervisorLam.Dock = DockStyle.Fill

        ElseIf section = "STRIPPING" Then
            Dim UC_SupervisorStrip As New UC_SupervisorStripping
            UC_SupervisorStrip.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorStrip.Show()
            UC_SupervisorStrip.Dock = DockStyle.Fill

        ElseIf section = "INSPECTION MACHINE" Then
            Dim UC_SupervisorQC As New UC_SupervisorQCMachine
            UC_SupervisorQC.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorQC.Show()
            UC_SupervisorQC.Dock = DockStyle.Fill

        ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_SupervisorGluing As New UC_SupervisorGluing
            UC_SupervisorGluing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorGluing.Show()
            UC_SupervisorGluing.Dock = DockStyle.Fill

        ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_SupervisorGluingLamina As New UC_SupervisorGluingLamina
            UC_SupervisorGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorGluingLamina.Show()
            UC_SupervisorGluingLamina.Dock = DockStyle.Fill

        ElseIf section = "DIGITAL PRESS" Then
            Dim UC_SupervisorDigiPress As New UC_SupervisorDigiPress
            UC_SupervisorDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorDigiPress.Show()
            UC_SupervisorDigiPress.Dock = DockStyle.Fill

        ElseIf section = "FINISHING" Then
            Dim UC_SupervisorFinishing As New UC_SupervisorFinishing
            UC_SupervisorFinishing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SupervisorFinishing.Show()
            UC_SupervisorFinishing.Dock = DockStyle.Fill

        End If


        BTN_Supervisor.ForeColor = Color.DodgerBlue
        BTN_Supervisor.BackColor = Color.White

        'changed color to black

        BTN_Operator.ForeColor = Color.Black
        BTN_Operator.BackColor = Color.WhiteSmoke

        BTN_SuperIntendent.ForeColor = Color.Black
        BTN_SuperIntendent.BackColor = Color.WhiteSmoke

        BTN_NxtProcess.ForeColor = Color.Black
        BTN_NxtProcess.BackColor = Color.WhiteSmoke





    End Sub

    Private Sub BTN_Operator_Click(sender As Object, e As EventArgs) Handles BTN_Operator.Click
        Dim i As Integer
        For i = 0 To 0
            PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next



        If section = "CUTTING" Then
            Dim MonitoringChecklistOperatorCutting As New UC_MonitoringChecklistOperators
            MonitoringChecklistOperatorCutting.Parent = PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistOperatorCutting.Show()
            MonitoringChecklistOperatorCutting.Dock = DockStyle.Fill

        ElseIf section = "DIE CUTTING" Then
            Dim MonitoringChecklistOperatorDieCutting As New UC_OperatorDIeCutting
            MonitoringChecklistOperatorDieCutting.Parent = PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistOperatorDieCutting.Show()
            MonitoringChecklistOperatorDieCutting.Dock = DockStyle.Fill

        ElseIf section = "OFFSET" Then
            Dim UC_OperatorOff As New UC_OperatorOffset
            UC_OperatorOff.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorOff.Show()
            UC_OperatorOff.Dock = DockStyle.Fill

        ElseIf section = "LAMINATION" Then
            Dim UC_OperatorLam As New UC_OperatorLamination
            UC_OperatorLam.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorLam.Show()
            UC_OperatorLam.Dock = DockStyle.Fill

        ElseIf section = "STRIPPING" Then
            Dim UC_OperatorStrip As New UC_OperatorStripping
            UC_OperatorStrip.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorStrip.Show()
            UC_OperatorStrip.Dock = DockStyle.Fill

        ElseIf section = "INSPECTION MACHINE" Then
            Dim UC_OperatorQC As New UC_OperatorQCMachine
            UC_OperatorQC.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorQC.Show()
            UC_OperatorQC.Dock = DockStyle.Fill

        ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_OperatorGluing As New UC_OperatorGluing
            UC_OperatorGluing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorGluing.Show()
            UC_OperatorGluing.Dock = DockStyle.Fill

        ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_OperatorGluingLamina As New UC_OperatorGluingLamina
            UC_OperatorGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorGluingLamina.Show()
            UC_OperatorGluingLamina.Dock = DockStyle.Fill
        ElseIf section = "DIGITAL PRESS" Then
            Dim UC_OperatorDigiPress As New UC_OperatorDigiPress
            UC_OperatorDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorDigiPress.Show()
            UC_OperatorDigiPress.Dock = DockStyle.Fill
        ElseIf section = "FINISHING" Then
            Dim UC_OperatorFinishing As New UC_OperatorFinishing
            UC_OperatorFinishing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_OperatorFinishing.Show()
            UC_OperatorFinishing.Dock = DockStyle.Fill

        End If

        BTN_Operator.ForeColor = Color.DodgerBlue
        BTN_Operator.BackColor = Color.White


        'changed color to black
        BTN_Supervisor.ForeColor = Color.Black
        BTN_Supervisor.BackColor = Color.WhiteSmoke


        BTN_SuperIntendent.ForeColor = Color.Black
        BTN_SuperIntendent.BackColor = Color.WhiteSmoke


        BTN_NxtProcess.ForeColor = Color.Black
        BTN_NxtProcess.BackColor = Color.WhiteSmoke






    End Sub

    Private Sub BTN_SuperIntendent_Click(sender As Object, e As EventArgs) Handles BTN_SuperIntendent.Click
        Dim i As Integer
        For i = 0 To 0
            PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next




        If section = "CUTTING" Then
            Dim MonitoringChecklistSuperIntendent As New UC_MonitoringChecklistSuperIntendent
            MonitoringChecklistSuperIntendent.Parent = PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistSuperIntendent.Show()
            MonitoringChecklistSuperIntendent.Dock = DockStyle.Fill
        ElseIf section = "DIE CUTTING" Then
            Dim UC_SuperIntendentDieCut As New UC_SuperIntendentDieCutting
            UC_SuperIntendentDieCut.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentDieCut.Show()
            UC_SuperIntendentDieCut.Dock = DockStyle.Fill

        ElseIf section = "OFFSET" Then
            Dim UC_SuperIntendentOff As New UC_SuperIntendentOffset
            UC_SuperIntendentOff.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentOff.Show()
            UC_SuperIntendentOff.Dock = DockStyle.Fill

        ElseIf section = "LAMINATION" Then
            Dim UC_SuperIntendentLam As New UC_SuperIntendentLamination
            UC_SuperIntendentLam.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentLam.Show()
            UC_SuperIntendentLam.Dock = DockStyle.Fill

        ElseIf section = "STRIPPING" Then
            Dim UC_SuperIntendentStrip As New UC_SuperIntendentStripping
            UC_SuperIntendentStrip.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentStrip.Show()
            UC_SuperIntendentStrip.Dock = DockStyle.Fill
        ElseIf section = "INSPECTION MACHINE" Then
            Dim UC_SuperIntendentQC As New UC_SuperIntendentQCMachine
            UC_SuperIntendentQC.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentQC.Show()
            UC_SuperIntendentQC.Dock = DockStyle.Fill
        ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_SuperIntendentGluing As New UC_SuperIntendentGluing
            UC_SuperIntendentGluing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentGluing.Show()
            UC_SuperIntendentGluing.Dock = DockStyle.Fill
        ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_SuperIntendentGluingLamina As New UC_SuperIntendentGluingLamina
            UC_SuperIntendentGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentGluingLamina.Show()
            UC_SuperIntendentGluingLamina.Dock = DockStyle.Fill
        ElseIf section = "DIGITAL PRESS" Then
            Dim UC_SuperIntendentDigiPress As New UC_SuperIntendentDigiPress
            UC_SuperIntendentDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentDigiPress.Show()
            UC_SuperIntendentDigiPress.Dock = DockStyle.Fill
        ElseIf section = "FINISHING" Then
            Dim UC_SuperIntendentFinishing As New UC_SuperIntendentFinishing
            UC_SuperIntendentFinishing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentFinishing.Show()
            UC_SuperIntendentFinishing.Dock = DockStyle.Fill

        End If


        BTN_SuperIntendent.ForeColor = Color.DodgerBlue
        BTN_SuperIntendent.BackColor = Color.White

        'changed color to black
        BTN_Operator.ForeColor = Color.Black
        BTN_Operator.BackColor = Color.WhiteSmoke

        BTN_Supervisor.ForeColor = Color.Black
        BTN_Supervisor.BackColor = Color.WhiteSmoke


        BTN_NxtProcess.ForeColor = Color.Black
        BTN_NxtProcess.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub BTN_NxtProcess_Click(sender As Object, e As EventArgs) Handles BTN_NxtProcess.Click

        Dim i As Integer
        For i = 0 To 0
            PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next



        Dim MonitoringChecklistNxtProcess As New UC_MonitoringChecklistNxtProcess

        Dim UC_NxtProcessDieCutting As New UC_NxtProcessDieCutting

        Dim UC_NxtProcessOff As New UC_NxtProcessOffset


        If section = "CUTTING" Then
            MonitoringChecklistNxtProcess.Parent = PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistNxtProcess.Show()
            MonitoringChecklistNxtProcess.Dock = DockStyle.Fill
        ElseIf section = "DIE CUTTING"
            UC_NxtProcessDieCutting.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessDieCutting.Show()
            UC_NxtProcessDieCutting.Dock = DockStyle.Fill

        ElseIf section = "OFFSET"
            UC_NxtProcessOff.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessOff.Show()
            UC_NxtProcessOff.Dock = DockStyle.Fill

        ElseIf section = "LAMINATION"
            Dim UC_NxtProcessLam As New UC_NxtProcessLamination
            UC_NxtProcessLam.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessLam.Show()
            UC_NxtProcessLam.Dock = DockStyle.Fill
        ElseIf section = "STRIPPING"
            Dim UC_NxtProcessStrip As New UC_NxtProcessStripping
            UC_NxtProcessStrip.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessStrip.Show()
            UC_NxtProcessStrip.Dock = DockStyle.Fill
        ElseIf section = "INSPECTION MACHINE"
            Dim UC_NxtProcessQCMachine As New UC_NxtProcessQC
            UC_NxtProcessQCMachine.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessQCMachine.Show()
            UC_NxtProcessQCMachine.Dock = DockStyle.Fill
        ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_NxtProcessGluing As New UC_NxtProcessGluing
            UC_NxtProcessGluing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessGluing.Show()
            UC_NxtProcessGluing.Dock = DockStyle.Fill
        ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim UC_NxtProcessGluingLamina As New UC_NxtProcessGluingLamina
            UC_NxtProcessGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessGluingLamina.Show()
            UC_NxtProcessGluingLamina.Dock = DockStyle.Fill
        ElseIf section = "DIGITAL PRESS" Then
            Dim UC_NxtProcessDigiPress As New UC_NxtProcessDigiPress
            UC_NxtProcessDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessDigiPress.Show()
            UC_NxtProcessDigiPress.Dock = DockStyle.Fill
        ElseIf section = "FINISHING" Then
            Dim UC_NxtProcessFinishing As New UC_NxtProcessFinishing
            UC_NxtProcessFinishing.Parent = PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessFinishing.Show()
            UC_NxtProcessFinishing.Dock = DockStyle.Fill
        End If


        'changed color to Active
        BTN_NxtProcess.ForeColor = Color.DodgerBlue
        BTN_NxtProcess.BackColor = Color.White

        'changed color to black
        BTN_Operator.ForeColor = Color.Black
        BTN_Operator.BackColor = Color.WhiteSmoke

        BTN_Supervisor.ForeColor = Color.Black
        BTN_Supervisor.BackColor = Color.WhiteSmoke

        BTN_SuperIntendent.ForeColor = Color.Black
        BTN_SuperIntendent.BackColor = Color.WhiteSmoke







    End Sub

    Private Sub BTN_AddMCNo_Click(sender As Object, e As EventArgs) Handles BTN_AddMCNo.Click

        If position = "Supervisor" Then

            Dim mcNumber As String = GenerateMCNumber()
            'Dim employee_num As String = lbl_empnum.Text

            TXT_MCNO.Text = mcNumber

            FRM_AddProductionRun.TXT_CheckMCNo.Text = mcNumber

            OpenConnection()
            cmd.CommandText = "INSERT INTO sppmcHdr (Site,  mcnum, mcdate, job, suffix, oper_num, job_date, shift, rescmch, SECTION, jobname, jobname_ext, emp_num,  job_qty, U_m, created_by) VALUES (@Site,  @mcnum, @mcdate, @job, @suffix, @oper_num, @job_date, @shift, @rescmch, @SECTION, @jobname,@jobname_ext, @emp_num,  @job_qty, @U_m, @created_by)"
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .Clear()
                .AddWithValue("@Site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", mcNumber)
                .AddWithValue("@mcdate", txt_date.Text)
                .AddWithValue("@job", txt_job.Text)
                .AddWithValue("@suffix", suffix)
                .AddWithValue("@oper_num", oper_num)
                .AddWithValue("@job_date", txt_date.Text)
                .AddWithValue("@shift", txt_shift.Text)
                .AddWithValue("@rescmch", txt_machine.Text)
                .AddWithValue("@SECTION", section)
                .AddWithValue("@jobname", txt_jobname.Text)
                .AddWithValue("@jobname_ext", txt_jobname_ext.Text)
                .AddWithValue("@emp_num", DBNull.Value)
                .AddWithValue("@job_qty", CInt(txt_jobqty.Text))
                .AddWithValue("@U_m", txt_um.Text)
                .AddWithValue("@created_by", lbl_empnum.Text)


            End With

            cmd.ExecuteNonQuery()
            con.Close()
            BTN_AddMCNo.Enabled = False


        End If







        If section = "CUTTING" Then

            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim MonitoringChecklistSupervisor As New UC_MonitoringChecklistSupervisor

            If position = "Supervisor" Then
                MonitoringChecklistSupervisor.Parent = PNL_MonitoringChecklistOperatorMain
                MonitoringChecklistSupervisor.Show()
                MonitoringChecklistSupervisor.Dock = DockStyle.Fill
            End If


        ElseIf section = "DIE CUTTING"

            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorDIeCuttingForm As New UC_SupervisorDIeCutting
            If position = "Supervisor" Then
                UC_SupervisorDIeCuttingForm.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorDIeCuttingForm.Show()
                UC_SupervisorDIeCuttingForm.Dock = DockStyle.Fill
            End If

        ElseIf section = "OFFSET"

            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorOffset As New UC_SupervisorOffset
            If position = "Supervisor" Then
                UC_SupervisorOffset.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorOffset.Show()
                UC_SupervisorOffset.Dock = DockStyle.Fill
            End If


        ElseIf section = "LAMINATION"

            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorLam As New UC_SupervisorLamination
            If position = "Supervisor" Then
                UC_SupervisorLam.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorLam.Show()
                UC_SupervisorLam.Dock = DockStyle.Fill
            End If

        ElseIf section = "STRIPPING"

            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorStrip As New UC_SupervisorStripping
            If position = "Supervisor" Then
                UC_SupervisorStrip.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorStrip.Show()
                UC_SupervisorStrip.Dock = DockStyle.Fill
            End If

        ElseIf section = "INSPECTION MACHINE"
            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorQCMach As New UC_SupervisorQCMachine
            If position = "Supervisor" Then
                UC_SupervisorQCMach.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorQCMach.Show()
                UC_SupervisorQCMach.Dock = DockStyle.Fill
            End If

        ElseIf section = "GLUING" AndAlso Not txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorGluing As New UC_SupervisorGluing
            If position = "Supervisor" Then
                UC_SupervisorGluing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorGluing.Show()
                UC_SupervisorGluing.Dock = DockStyle.Fill
            End If

        ElseIf section = "GLUING" AndAlso txt_machine.Text.StartsWith("P-LAMINA") Then
            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorGluingLamina As New UC_SupervisorGluingLamina
            If position = "Supervisor" Then
                UC_SupervisorGluingLamina.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorGluingLamina.Show()
                UC_SupervisorGluingLamina.Dock = DockStyle.Fill
            End If

        ElseIf section = "DIGITAL PRESS"
            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorDigiPress As New UC_SupervisorDigiPress
            If position = "Supervisor" Then
                UC_SupervisorDigiPress.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorDigiPress.Show()
                UC_SupervisorDigiPress.Dock = DockStyle.Fill
            End If

        ElseIf section = "FINISHING"
            Dim i As Integer
            For i = 0 To 0
                PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SupervisorFinishing As New UC_SupervisorFinishing
            If position = "Supervisor" Then
                UC_SupervisorFinishing.Parent = PNL_MonitoringChecklistOperatorMain
                UC_SupervisorFinishing.Show()
                UC_SupervisorFinishing.Dock = DockStyle.Fill
            End If

        End If








        If BTN_AddMCNo.Enabled = False Then
            BTN_AddMCNo.BackColor = Color.White
            BTN_AddMCNo.ForeColor = Color.Black
        End If


        BTN_Supervisor.ForeColor = Color.DodgerBlue
        BTN_Supervisor.BackColor = Color.White

        'changed color to black

        BTN_Operator.ForeColor = Color.Black
        BTN_Operator.BackColor = Color.WhiteSmoke

        BTN_SuperIntendent.ForeColor = Color.Black
        BTN_SuperIntendent.BackColor = Color.WhiteSmoke

        BTN_NxtProcess.ForeColor = Color.Black
        BTN_NxtProcess.BackColor = Color.WhiteSmoke





        'MessageBox.Show("Generated MC Number: " & mcNumber)
    End Sub


    'Private Function GenerateMCNumber() As String
    '    Dim site As String = "PI"
    '    Dim mcNumber As String = ""
    '    Dim yearPart As String = DateTime.Now.Year.ToString().Substring(2, 2) ' Last two digits of the year
    '    Dim monthPart As String = DateTime.Now.Month.ToString("00") ' Zero-padded month
    '    Dim Section As String = "CU"
    '    Dim maxMcNumberLength As Integer = 12 ' Column size is 12

    '    connection String
    '    Dim connectionString As String = "Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011"

    '    Using connection As New SqlConnection(connectionString)
    '        connection.Open()

    '         Get the latest counter value
    '        Dim command As String = "SELECT ISNULL(MAX(Counter), 0) FROM MCNO_LastTran WHERE Year = @Year AND Month = @Month AND Section = @Section"
    '        Dim lastCounter As Integer

    '        Using counterCmd As New SqlCommand(command, connection)
    '            counterCmd.Parameters.AddWithValue("@Year", yearPart)
    '            counterCmd.Parameters.AddWithValue("@Month", monthPart)
    '            counterCmd.Parameters.AddWithValue("@Section", Section)
    '            lastCounter = Convert.ToInt32(counterCmd.ExecuteScalar())
    '            lastCounter += 1
    '        End Using

    '        Dim numberPart As String = lastCounter.ToString("D6") ' Zero-padded number
    '        mcNumber = yearPart & monthPart & "-" & Section & numberPart

    '        Ensure the MC number fits within the maximum length
    '        If mcNumber.Length > maxMcNumberLength Then
    '            Trim the number part to fit if necessary
    '            numberPart = lastCounter.ToString("D" & (maxMcNumberLength - (yearPart.Length + monthPart.Length + Section.Length + 1))) ' Adjust for format
    '            mcNumber = yearPart & monthPart & "-" & Section & numberPart

    '            If trimming Then results In an invalid length, handle the Error
    '            If mcNumber.Length > maxMcNumberLength Then
    '                    Throw New Exception("Generated MC Number exceeds maximum allowed length.")
    '                End If
    '            End If

    '            Check If MC number already exists
    '        Dim checkQuery As String = "SELECT COUNT(*) FROM MCNO_LastTran WHERE GenMCnum = @GenMCnum"
    '            Dim count As Integer

    '            Using checkCmd As New SqlCommand(checkQuery, connection)
    '                checkCmd.Parameters.AddWithValue("@GenMCnum", mcNumber)
    '                count = Convert.ToInt32(checkCmd.ExecuteScalar())
    '            End Using

    '            If count > 0 Then
    '                If the Then number exists, generate a New one
    '            Return GenerateMCNumber() ' Recursively generate a new number
    '                End If

    '                Insert the New record
    '        Dim insertQuery As String = "INSERT INTO MCNO_LastTran (Site, GenMCnum, Year, Month, Section, Counter, CreateDate) VALUES (@Site, @GenMCnum, @Year, @Month, @Section, @Counter, @CreateDate)"

    '                Using insertCmd As New SqlCommand(insertQuery, connection)
    '                    insertCmd.Parameters.AddWithValue("@Site", site)
    '                    insertCmd.Parameters.AddWithValue("@GenMCnum", mcNumber)
    '                    insertCmd.Parameters.AddWithValue("@Year", yearPart)
    '                    insertCmd.Parameters.AddWithValue("@Month", monthPart)
    '                    insertCmd.Parameters.AddWithValue("@Section", Section)
    '                    insertCmd.Parameters.AddWithValue("@Counter", lastCounter)
    '                    insertCmd.Parameters.AddWithValue("@CreateDate", DateTime.Now.Date)
    '                    insertCmd.ExecuteNonQuery()
    '                End Using
    '    End Using

    '    Return mcNumber
    'End Function


    Private Function GenerateMCNumber() As String
        Dim Site As String = Form1.cmb_site.Text
        Dim mcNumber As String = ""
        Dim yearPart As String = DateTime.Now.Year.ToString().Substring(2, 2) ' Last two digits of the year
        Dim monthPart As String = DateTime.Now.Month.ToString("00") ' Zero-padded month

        Dim maxMcNumberLength As Integer = 12 ' Column size is 

        Dim sec_code As String = section_code

        If section = "DIE CUTTING" Then
            sec_code = "DT"
        ElseIf section = "DIGITAL PRESS"
            sec_code = "DP"
        End If


        Dim checkGenMCnum As String = ""

        ' Connection string
        Dim connectionString As String = "Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Check if a record already exists for the given Site, Year, Month, and Section
            Dim existingGenMCnum As String = ""
            Dim holderLastCounter As Integer = 0
            Dim lastCounter As Integer = 0







            Dim commandText As String = "SELECT Site, GenMCnum, Counter FROM MCNO_LastTran WHERE Site = @Site AND Year = @Year AND Month = @Month AND Section = @Section"

            Using checkCmd As New SqlCommand(commandText, connection)
                checkCmd.Parameters.AddWithValue("@Site", Site)
                checkCmd.Parameters.AddWithValue("@Year", yearPart)
                checkCmd.Parameters.AddWithValue("@Month", monthPart)
                checkCmd.Parameters.AddWithValue("@Section", sec_code)

                Using reader As SqlDataReader = checkCmd.ExecuteReader()
                    If reader.Read() Then
                        ' Record exists, so update it
                        existingGenMCnum = reader("GenMCnum").ToString()
                        holderLastCounter = reader("Counter")
                    Else
                        holderLastCounter = 1
                    End If
                End Using
            End Using




            Dim selectQuery As String = "SELECT Site, mcnum FROM sppmcHdr WHERE Site  = @site And mcnum = @mcnum "




            Using checkCmd As New SqlCommand(selectQuery, connection)
                checkCmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
                checkCmd.Parameters.AddWithValue("@mcnum", existingGenMCnum)


                Using reader As SqlDataReader = checkCmd.ExecuteReader()
                    If reader.Read() Then
                        ' Record exists, so update it



                        lastCounter = Convert.ToInt32(holderLastCounter) + 1

                    Else
                        lastCounter = holderLastCounter
                    End If
                End Using
            End Using










            ' Generate new MC number
            Dim numberPart As String = lastCounter.ToString("D6") ' Zero-padded number
            mcNumber = yearPart & monthPart & "-" & sec_code & numberPart

            ' Ensure the MC number fits within the maximum length
            If mcNumber.Length > maxMcNumberLength Then
                ' Trim the number part to fit if necessary
                numberPart = lastCounter.ToString("D" & (maxMcNumberLength - (yearPart.Length + monthPart.Length + sec_code.Length + 1))) ' Adjust for format
                mcNumber = yearPart & monthPart & "-" & sec_code & numberPart

                ' If trimming results in an invalid length, handle the error
                If mcNumber.Length > maxMcNumberLength Then
                    Throw New Exception("Generated MC Number exceeds maximum allowed length.")
                End If
            End If



            ' Update or insert the record
            Dim query As String
            If existingGenMCnum <> "" Then
                ' Update existing record
                query = "UPDATE MCNO_LastTran SET GenMCnum = @GenMCnum, Counter = @Counter, CreateDate = @CreateDate WHERE Year = @Year AND Month = @Month AND Section = @Section"
            Else
                ' Insert new record
                query = "INSERT INTO MCNO_LastTran (Site, GenMCnum, Year, Month, Section, Counter, CreateDate) VALUES (@Site, @GenMCnum, @Year, @Month, @Section, @Counter, @CreateDate)"
            End If

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Site", Site)
                cmd.Parameters.AddWithValue("@GenMCnum", mcNumber)
                cmd.Parameters.AddWithValue("@Counter", lastCounter)
                cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now.Date)
                cmd.Parameters.AddWithValue("@Year", yearPart)
                cmd.Parameters.AddWithValue("@Month", monthPart)
                cmd.Parameters.AddWithValue("@Section", sec_code)

                ' Execute update or insert command
                cmd.ExecuteNonQuery()
            End Using





        End Using

        Return mcNumber
    End Function



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox(Form1.cmbuserid.Text)
        MsgBox(Form1.cmb_site.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(globalvariable.section)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LBL_Logout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_MCNO_TextChanged(sender As Object, e As EventArgs) Handles TXT_MCNO.TextChanged

        Dim writer1 As New BarcodeWriter

        writer1.Format = BarcodeFormat.QR_CODE

        If TXT_MCNO.Text = "" Then
            PBox_QRCode.Image = Nothing
        Else
            PBox_QRCode.Image = writer1.Write(TXT_MCNO.Text)

            BTN_SaveHeader.Enabled = True

        End If




    End Sub

    Private Sub PNL_MonitoringChecklistOperatorMain_Paint(sender As Object, e As PaintEventArgs) Handles PNL_MonitoringChecklistOperatorMain.Paint

    End Sub

    Private Sub BTN_SaveHeader_Click(sender As Object, e As EventArgs) Handles BTN_SaveHeader.Click
        Try
            OpenConnection()
            cmd.CommandText = "UPDATE sppmcHdr SET  mcdate = @mcdate WHERE Site = @Site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .Clear()
                .AddWithValue("@Site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", TXT_MCNO.Text)
                .AddWithValue("@mcdate", txt_date.Text)



            End With



            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Save successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class