Imports System.Data.SqlClient

Public Class UC_OperatorOffset
    Private Sub BTN_AddProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_AddProductionRun.Click
        FRM_AddProductionRunOffset.Show()
        FRM_MonitoringChecklistMain.Hide()
    End Sub

    Private Sub UC_OperatorOffset_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        con.Close()


        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_OFF  WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text

            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                BTN_AddProductionRun.Text = "Update"
            Else
                BTN_AddProductionRun.Text = "Add"
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try


        'Change height to 40px
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 40
        Next


        'enabled and disable button
        If position = "Operator" Then
            BTN_Recalculate.Enabled = True
            TXT_Remarks.Enabled = True
            BTN_Save.Enabled = True
            BTN_AddProductionRun.Enabled = True



            If FRM_MonitoringChecklistMain.BTN_AddMCNo.Visible = False Then
                BTN_AddProductionRun.Enabled = True
            Else
                BTN_AddProductionRun.Enabled = True
            End If


            If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then
                BTN_AddProductionRun.Enabled = False
                BTN_Save.Enabled = False

            End If



        Else
            BTN_AddProductionRun.Enabled = False

            TXT_Remarks.Enabled = False
            BTN_Save.Enabled = False


        End If



        If FRM_MonitoringChecklistMain.txt_operator.Text <> "" Then

            If FRM_MonitoringChecklistMain.lbl_empname.Text <> FRM_MonitoringChecklistMain.txt_operator.Text Then
                BTN_Save.Enabled = False
                BTN_AddProductionRun.Enabled = False
            End If
        End If




        If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then
            'MsgBox("No mc number!")
            BTN_Recalculate.Enabled = False

        Else

            calculate_output_sfms_jobtran()
            'If position <> "Operator" Then
            '    BTN_Recalculate.Enabled = False

            'Else
            '    BTN_Recalculate.Enabled = True
            'End If

        End If

        'SHOWING THE VALUE FOR RES No SAS No
        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_OFF WHERE Site =@Site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then
                    TXT_ResNo.Text = dr("prr_RESNum").ToString()
                    TXT_SasNo.Text = dr("prr_SASNum").ToString()
                    dr.Close()
                    con.Close()
                End If
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try



        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcOutput"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@Site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then


                    TXT_Acknowledge.Text = dr("NxtNameSup").ToString()



                    dr.Close()
                    con.Close()

                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try


    End Sub
    Sub LoadRecord()


        Dim total_0700 As Integer
        Dim total_0800 As Integer
        Dim total_0900 As Integer
        Dim total_1000 As Integer
        Dim total_1100 As Integer
        Dim total_1200 As Integer
        Dim total_0100 As Integer
        Dim total_0200 As Integer
        Dim total_0300 As Integer
        Dim total_0400 As Integer
        Dim total_0500 As Integer
        Dim total_0600 As Integer


        Dim sum_total As Integer



        Try
            OpenConnection()
            cmd.CommandText = "Select_MCTimecomputetotalOffset"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                If dr.Read() Then


                    If dr.GetOrdinal("total_0700") >= 0 AndAlso Not IsDBNull(dr("total_0700")) Then
                        total_0700 = Convert.ToInt32(dr("total_0700"))
                    Else
                        total_0700 = 0
                    End If


                    If dr.GetOrdinal("total_0800") >= 0 AndAlso Not IsDBNull(dr("total_0800")) Then
                        total_0800 = Convert.ToInt32(dr("total_0800"))
                    Else
                        total_0800 = 0
                    End If


                    If dr.GetOrdinal("total_0900") >= 0 AndAlso Not IsDBNull(dr("total_0900")) Then
                        total_0900 = Convert.ToInt32(dr("total_0900"))
                    Else
                        total_0900 = 0
                    End If


                    If dr.GetOrdinal("total_1000") >= 0 AndAlso Not IsDBNull(dr("total_1000")) Then
                        total_1000 = Convert.ToInt32(dr("total_1000"))
                    Else
                        total_1000 = 0
                    End If


                    If dr.GetOrdinal("total_1100") >= 0 AndAlso Not IsDBNull(dr("total_1100")) Then
                        total_1100 = Convert.ToInt32(dr("total_1100"))
                    Else
                        total_1100 = 0
                    End If



                    If dr.GetOrdinal("total_1200") >= 0 AndAlso Not IsDBNull(dr("total_1200")) Then
                        total_1200 = Convert.ToInt32(dr("total_1200"))
                    Else
                        total_1200 = 0
                    End If


                    If dr.GetOrdinal("total_0100") >= 0 AndAlso Not IsDBNull(dr("total_0100")) Then
                        total_0100 = Convert.ToInt32(dr("total_0100"))
                    Else
                        total_0100 = 0
                    End If



                    If dr.GetOrdinal("total_0200") >= 0 AndAlso Not IsDBNull(dr("total_0200")) Then
                        total_0200 = Convert.ToInt32(dr("total_0200"))
                    Else
                        total_0200 = 0
                    End If


                    If dr.GetOrdinal("total_0300") >= 0 AndAlso Not IsDBNull(dr("total_0300")) Then
                        total_0300 = Convert.ToInt32(dr("total_0300"))
                    Else
                        total_0300 = 0
                    End If


                    If dr.GetOrdinal("total_0400") >= 0 AndAlso Not IsDBNull(dr("total_0400")) Then
                        total_0400 = Convert.ToInt32(dr("total_0400"))
                    Else
                        total_0400 = 0
                    End If

                    If dr.GetOrdinal("total_0500") >= 0 AndAlso Not IsDBNull(dr("total_0500")) Then
                        total_0500 = Convert.ToInt32(dr("total_0500"))
                    Else
                        total_0500 = 0
                    End If


                    If dr.GetOrdinal("total_0600") >= 0 AndAlso Not IsDBNull(dr("total_0600")) Then
                        total_0600 = Convert.ToInt32(dr("total_0600"))
                    Else
                        total_0600 = 0
                    End If


                    sum_total = total_0700 + total_0800 + total_0900 + total_1000 + total_1100 + total_1200 + total_0100 + total_0200 + total_0300 + total_0400 + total_0500 + total_0600

                    TXT_Total.Text = Convert.ToDecimal(sum_total).ToString("N0")
                End If
            End If




            'Dim result As Object = cmd.ExecuteScalar()
            'TXT_Total.Text = If(result IsNot DBNull.Value, Convert.ToDecimal(result).ToString("N0"), "0")

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



        DataGridView1.Rows.Clear()
        OpenConnection()

        cmd.CommandText = "SELECT * FROM sppmcPRR_OFF WHERE Site = @site And  mcnum = @mcnum "
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add("07:00", dr.Item("prr_OFInkVrnLd0700"), dr.Item("prr_OFVrnVisc07to09val"), dr.Item("prr_OFFSTemp07to09val"), dr.Item("prr_OFFSCndtvty07to09val"), dr.Item("prr_OFFSpH07to09val"), dr.Item("prr_OFOffColor0700"), dr.Item("prr_OFOffColor0700val"), dr.Item("prr_OFEread0700"), dr.Item("prr_OFEread0700val"), dr.Item("prr_OFBarbak0700"), dr.Item("prr_OFBarbak0700val"), dr.Item("prr_OFHawa0700"), dr.Item("prr_OFHawa0700val"), dr.Item("prr_OFSlurring0700"), dr.Item("prr_OFSlurring0700val"), dr.Item("prr_OFGhostng0700"), dr.Item("prr_OFGhostng0700val"), dr.Item("prr_OFGalaw0700"), dr.Item("prr_OFGalaw0700val"), dr.Item("prr_OFLubog0700"), dr.Item("prr_OFLubog0700val"), dr.Item("prr_OFSpot0700"), dr.Item("prr_OFSpot0700val"), dr.Item("prr_OFTapetst0700"), dr.Item("prr_OFTapetst0700val"), total_0700)
            DataGridView1.Rows.Add("08:00", dr.Item("prr_OFInkVrnLd0800"), dr.Item("prr_OFVrnVisc07to09val"), dr.Item("prr_OFFSTemp07to09val"), dr.Item("prr_OFFSCndtvty07to09val"), dr.Item("prr_OFFSpH07to09val"), dr.Item("prr_OFOffColor0800"), dr.Item("prr_OFOffColor0800val"), dr.Item("prr_OFEread0800"), dr.Item("prr_OFEread0800val"), dr.Item("prr_OFBarbak0800"), dr.Item("prr_OFBarbak0800val"), dr.Item("prr_OFHawa0800"), dr.Item("prr_OFHawa0800val"), dr.Item("prr_OFSlurring0800"), dr.Item("prr_OFSlurring0800val"), dr.Item("prr_OFGhostng0800"), dr.Item("prr_OFGhostng0800val"), dr.Item("prr_OFGalaw0800"), dr.Item("prr_OFGalaw0800val"), dr.Item("prr_OFLubog0800"), dr.Item("prr_OFLubog0800val"), dr.Item("prr_OFSpot0800"), dr.Item("prr_OFSpot0800val"), dr.Item("prr_OFTapetst0800"), dr.Item("prr_OFTapetst0800val"), total_0800)
            DataGridView1.Rows.Add("09:00", dr.Item("prr_OFInkVrnLd0900"), dr.Item("prr_OFVrnVisc07to09val"), dr.Item("prr_OFFSTemp07to09val"), dr.Item("prr_OFFSCndtvty07to09val"), dr.Item("prr_OFFSpH07to09val"), dr.Item("prr_OFOffColor0900"), dr.Item("prr_OFOffColor0900val"), dr.Item("prr_OFEread0900"), dr.Item("prr_OFEread0900val"), dr.Item("prr_OFBarbak0900"), dr.Item("prr_OFBarbak0900val"), dr.Item("prr_OFHawa0900"), dr.Item("prr_OFHawa0900val"), dr.Item("prr_OFSlurring0900"), dr.Item("prr_OFSlurring0900val"), dr.Item("prr_OFGhostng0900"), dr.Item("prr_OFGhostng0900val"), dr.Item("prr_OFGalaw0900"), dr.Item("prr_OFGalaw0900val"), dr.Item("prr_OFLubog0900"), dr.Item("prr_OFLubog0900val"), dr.Item("prr_OFSpot0900"), dr.Item("prr_OFSpot0900val"), dr.Item("prr_OFTapetst0900"), dr.Item("prr_OFTapetst0900val"), total_0900)
            DataGridView1.Rows.Add("10:00", dr.Item("prr_OFInkVrnLd1000"), dr.Item("prr_OFVrnVisc10to12val"), dr.Item("prr_OFFSTemp10to12val"), dr.Item("prr_OFFSCndtvty10to12val"), dr.Item("prr_OFFSpH10to12val"), dr.Item("prr_OFOffColor1000"), dr.Item("prr_OFOffColor1000val"), dr.Item("prr_OFEread1000"), dr.Item("prr_OFEread1000val"), dr.Item("prr_OFBarbak1000"), dr.Item("prr_OFBarbak1000val"), dr.Item("prr_OFHawa1000"), dr.Item("prr_OFHawa1000val"), dr.Item("prr_OFSlurring1000"), dr.Item("prr_OFSlurring1000val"), dr.Item("prr_OFGhostng1000"), dr.Item("prr_OFGhostng1000val"), dr.Item("prr_OFGalaw1000"), dr.Item("prr_OFGalaw1000val"), dr.Item("prr_OFLubog1000"), dr.Item("prr_OFLubog1000val"), dr.Item("prr_OFSpot1000"), dr.Item("prr_OFSpot1000val"), dr.Item("prr_OFTapetst1000"), dr.Item("prr_OFTapetst1000val"), total_1000)
            DataGridView1.Rows.Add("11:00", dr.Item("prr_OFInkVrnLd1100"), dr.Item("prr_OFVrnVisc10to12val"), dr.Item("prr_OFFSTemp10to12val"), dr.Item("prr_OFFSCndtvty10to12val"), dr.Item("prr_OFFSpH10to12val"), dr.Item("prr_OFOffColor1100"), dr.Item("prr_OFOffColor1100val"), dr.Item("prr_OFEread1100"), dr.Item("prr_OFEread1100val"), dr.Item("prr_OFBarbak1100"), dr.Item("prr_OFBarbak1100val"), dr.Item("prr_OFHawa1100"), dr.Item("prr_OFHawa1100val"), dr.Item("prr_OFSlurring1100"), dr.Item("prr_OFSlurring1100val"), dr.Item("prr_OFGhostng1100"), dr.Item("prr_OFGhostng1100val"), dr.Item("prr_OFGalaw1100"), dr.Item("prr_OFGalaw1100val"), dr.Item("prr_OFLubog1100"), dr.Item("prr_OFLubog1100val"), dr.Item("prr_OFSpot1100"), dr.Item("prr_OFSpot1100val"), dr.Item("prr_OFTapetst1100"), dr.Item("prr_OFTapetst1100val"), total_1100)
            DataGridView1.Rows.Add("12:00", dr.Item("prr_OFInkVrnLd1200"), dr.Item("prr_OFVrnVisc10to12val"), dr.Item("prr_OFFSTemp10to12val"), dr.Item("prr_OFFSCndtvty10to12val"), dr.Item("prr_OFFSpH10to12val"), dr.Item("prr_OFOffColor1200"), dr.Item("prr_OFOffColor1200val"), dr.Item("prr_OFEread1200"), dr.Item("prr_OFEread1200val"), dr.Item("prr_OFBarbak1200"), dr.Item("prr_OFBarbak1200val"), dr.Item("prr_OFHawa1200"), dr.Item("prr_OFHawa1200val"), dr.Item("prr_OFSlurring1200"), dr.Item("prr_OFSlurring1200val"), dr.Item("prr_OFGhostng1200"), dr.Item("prr_OFGhostng1200val"), dr.Item("prr_OFGalaw1200"), dr.Item("prr_OFGalaw1200val"), dr.Item("prr_OFLubog1200"), dr.Item("prr_OFLubog1200val"), dr.Item("prr_OFSpot1200"), dr.Item("prr_OFSpot1200val"), dr.Item("prr_OFTapetst1200"), dr.Item("prr_OFTapetst1200val"), total_1200)
            DataGridView1.Rows.Add("01:00", dr.Item("prr_OFInkVrnLd0100"), dr.Item("prr_OFVrnVisc01to03val"), dr.Item("prr_OFFSTemp01to03val"), dr.Item("prr_OFFSCndtvty01to03val"), dr.Item("prr_OFFSpH01to03val"), dr.Item("prr_OFOffColor0100"), dr.Item("prr_OFOffColor0100val"), dr.Item("prr_OFEread0100"), dr.Item("prr_OFEread0100val"), dr.Item("prr_OFBarbak0100"), dr.Item("prr_OFBarbak0100val"), dr.Item("prr_OFHawa0100"), dr.Item("prr_OFHawa0100val"), dr.Item("prr_OFSlurring0100"), dr.Item("prr_OFSlurring0100val"), dr.Item("prr_OFGhostng0100"), dr.Item("prr_OFGhostng0100val"), dr.Item("prr_OFGalaw0100"), dr.Item("prr_OFGalaw0100val"), dr.Item("prr_OFLubog0100"), dr.Item("prr_OFLubog0100val"), dr.Item("prr_OFSpot0100"), dr.Item("prr_OFSpot0100val"), dr.Item("prr_OFTapetst0100"), dr.Item("prr_OFTapetst0100val"), total_0100)
            DataGridView1.Rows.Add("02:00", dr.Item("prr_OFInkVrnLd0200"), dr.Item("prr_OFVrnVisc01to03val"), dr.Item("prr_OFFSTemp01to03val"), dr.Item("prr_OFFSCndtvty01to03val"), dr.Item("prr_OFFSpH01to03val"), dr.Item("prr_OFOffColor0200"), dr.Item("prr_OFOffColor0200val"), dr.Item("prr_OFEread0200"), dr.Item("prr_OFEread0200val"), dr.Item("prr_OFBarbak0200"), dr.Item("prr_OFBarbak0200val"), dr.Item("prr_OFHawa0200"), dr.Item("prr_OFHawa0200val"), dr.Item("prr_OFSlurring0200"), dr.Item("prr_OFSlurring0200val"), dr.Item("prr_OFGhostng0200"), dr.Item("prr_OFGhostng0200val"), dr.Item("prr_OFGalaw0200"), dr.Item("prr_OFGalaw0200val"), dr.Item("prr_OFLubog0200"), dr.Item("prr_OFLubog0200val"), dr.Item("prr_OFSpot0200"), dr.Item("prr_OFSpot0200val"), dr.Item("prr_OFTapetst0200"), dr.Item("prr_OFTapetst0200val"), total_0200)
            DataGridView1.Rows.Add("03:00", dr.Item("prr_OFInkVrnLd0300"), dr.Item("prr_OFVrnVisc01to03val"), dr.Item("prr_OFFSTemp01to03val"), dr.Item("prr_OFFSCndtvty01to03val"), dr.Item("prr_OFFSpH01to03val"), dr.Item("prr_OFOffColor0300"), dr.Item("prr_OFOffColor0300val"), dr.Item("prr_OFEread0300"), dr.Item("prr_OFEread0300val"), dr.Item("prr_OFBarbak0300"), dr.Item("prr_OFBarbak0300val"), dr.Item("prr_OFHawa0300"), dr.Item("prr_OFHawa0300val"), dr.Item("prr_OFSlurring0300"), dr.Item("prr_OFSlurring0300val"), dr.Item("prr_OFGhostng0300"), dr.Item("prr_OFGhostng0300val"), dr.Item("prr_OFGalaw0300"), dr.Item("prr_OFGalaw0300val"), dr.Item("prr_OFLubog0300"), dr.Item("prr_OFLubog0300val"), dr.Item("prr_OFSpot0300"), dr.Item("prr_OFSpot0300val"), dr.Item("prr_OFTapetst0300"), dr.Item("prr_OFTapetst0300val"), total_0300)
            DataGridView1.Rows.Add("04:00", dr.Item("prr_OFInkVrnLd0400"), dr.Item("prr_OFVrnVisc04to06val"), dr.Item("prr_OFFSTemp04to06val"), dr.Item("prr_OFFSCndtvty04to06val"), dr.Item("prr_OFFSpH04to06val"), dr.Item("prr_OFOffColor0400"), dr.Item("prr_OFOffColor0400val"), dr.Item("prr_OFEread0400"), dr.Item("prr_OFEread0400val"), dr.Item("prr_OFBarbak0400"), dr.Item("prr_OFBarbak0400val"), dr.Item("prr_OFHawa0400"), dr.Item("prr_OFHawa0400val"), dr.Item("prr_OFSlurring0400"), dr.Item("prr_OFSlurring0400val"), dr.Item("prr_OFGhostng0400"), dr.Item("prr_OFGhostng0400val"), dr.Item("prr_OFGalaw0400"), dr.Item("prr_OFGalaw0400val"), dr.Item("prr_OFLubog0400"), dr.Item("prr_OFLubog0400val"), dr.Item("prr_OFSpot0400"), dr.Item("prr_OFSpot0400val"), dr.Item("prr_OFTapetst0400"), dr.Item("prr_OFTapetst0400val"), total_0400)
            DataGridView1.Rows.Add("05:00", dr.Item("prr_OFInkVrnLd0500"), dr.Item("prr_OFVrnVisc04to06val"), dr.Item("prr_OFFSTemp04to06val"), dr.Item("prr_OFFSCndtvty04to06val"), dr.Item("prr_OFFSpH04to06val"), dr.Item("prr_OFOffColor0500"), dr.Item("prr_OFOffColor0500val"), dr.Item("prr_OFEread0500"), dr.Item("prr_OFEread0500val"), dr.Item("prr_OFBarbak0500"), dr.Item("prr_OFBarbak0500val"), dr.Item("prr_OFHawa0500"), dr.Item("prr_OFHawa0500val"), dr.Item("prr_OFSlurring0500"), dr.Item("prr_OFSlurring0500val"), dr.Item("prr_OFGhostng0500"), dr.Item("prr_OFGhostng0500val"), dr.Item("prr_OFGalaw0500"), dr.Item("prr_OFGalaw0500val"), dr.Item("prr_OFLubog0500"), dr.Item("prr_OFLubog0500val"), dr.Item("prr_OFSpot0500"), dr.Item("prr_OFSpot0500val"), dr.Item("prr_OFTapetst0500"), dr.Item("prr_OFTapetst0500val"), total_0500)
            DataGridView1.Rows.Add("06:00", dr.Item("prr_OFInkVrnLd0600"), dr.Item("prr_OFVrnVisc04to06val"), dr.Item("prr_OFFSTemp04to06val"), dr.Item("prr_OFFSCndtvty04to06val"), dr.Item("prr_OFFSpH04to06val"), dr.Item("prr_OFOffColor0600"), dr.Item("prr_OFOffColor0600val"), dr.Item("prr_OFEread0600"), dr.Item("prr_OFEread0600val"), dr.Item("prr_OFBarbak0600"), dr.Item("prr_OFBarbak0600val"), dr.Item("prr_OFHawa0600"), dr.Item("prr_OFHawa0600val"), dr.Item("prr_OFSlurring0600"), dr.Item("prr_OFSlurring0600val"), dr.Item("prr_OFGhostng0600"), dr.Item("prr_OFGhostng0600val"), dr.Item("prr_OFGalaw0600"), dr.Item("prr_OFGalaw0600val"), dr.Item("prr_OFLubog0600"), dr.Item("prr_OFLubog0600val"), dr.Item("prr_OFSpot0600"), dr.Item("prr_OFSpot0600val"), dr.Item("prr_OFTapetst0600"), dr.Item("prr_OFTapetst0600val"), total_0600)
        End While
        dr.Close()
        con.Close()

        AddHandler DataGridView1.CellFormatting, AddressOf DataGridView1_CellFormatting

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Check if the cell is in the desired column and has the value "O"
        If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "O" Then
                e.Value = "✓"
            End If
        End If

        If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
                e.Value = "N/A"
            End If
        End If


        If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "0.00" Then
                e.Value = ""
            End If
        End If


        If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "0" Then
                e.Value = ""
            End If
        End If

        'If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
        '    If e.Value IsNot Nothing AndAlso e.Value.ToString() = "" Then
        '        e.Value = "N/A"
        '    End If
        'End If
    End Sub


    Private Sub calculate_output_sfms_jobtran()





        Dim cmd_calculate_sppmcoutput As New SqlCommand("Select * from sppmcOutput where  Site = @Site And mcnum = @mcnum", con)
        cmd_calculate_sppmcoutput.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
        cmd_calculate_sppmcoutput.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)


        'Dim read_cmd_sppmcoutput As SqlDataReader = cmd_calculate_sppmcoutput.ExecuteReader

        Dim cmd_calculate As New SqlCommand("Select_sfms_jobtran_output", con)
        cmd_calculate.CommandType = CommandType.StoredProcedure
        cmd_calculate.Parameters.AddWithValue("@job", joborder)
        cmd_calculate.Parameters.AddWithValue("@suffix", suffix)
        cmd_calculate.Parameters.AddWithValue("@opernum", oper_num)
        cmd_calculate.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

        'Dim read_cmd_calculate As SqlDataReader = cmd_calculate.ExecuteReader


        Try
            con.Open()
            Dim read_cmd_sppmcoutput As SqlDataReader = cmd_calculate_sppmcoutput.ExecuteReader
            If read_cmd_sppmcoutput.HasRows Then

                While read_cmd_sppmcoutput.Read

                    'TXT_GoodQtyTotal.Text = Convert.ToDecimal(read_cmd_sppmcoutput("mchout_GoodCurrPalltQty")).ToString("N0")



                    If read_cmd_sppmcoutput("mchout_GoodCurrPalltQty").ToString() = "" Then
                        TXT_CurGoodQty.Text = 0
                    Else
                        TXT_CurGoodQty.Text = Convert.ToDecimal(read_cmd_sppmcoutput("mchout_GoodCurrPalltQty")).ToString("N0")
                    End If


                    If read_cmd_sppmcoutput("mchout_RedCurrPalltQty").ToString() = "" Then
                        TXT_CurRedPalletQty.Text = 0
                    Else
                        TXT_CurRedPalletQty.Text = Convert.ToDecimal(read_cmd_sppmcoutput("mchout_RedCurrPalltQty")).ToString("N0")
                    End If



                    If read_cmd_sppmcoutput("mchout_SpoilCurrPalltQty").ToString() = "" Then
                        TXT_CurSpoilageQty.Text = 0
                    Else
                        TXT_CurSpoilageQty.Text = Convert.ToDecimal(read_cmd_sppmcoutput("mchout_SpoilCurrPalltQty")).ToString("N0")
                    End If





                    'TXT_SpoilageQtyTotal.Text = Convert.ToDecimal(read_cmd_sppmcoutput("mchout_SpoilCurrPalltQty")).ToString("N0")



                    If read_cmd_sppmcoutput("output_Remrks").ToString() = "" Then
                        TXT_Remarks.Text = ""
                    Else
                        TXT_Remarks.Text = read_cmd_sppmcoutput("output_Remrks").ToString()
                    End If




                End While
                read_cmd_sppmcoutput.Close()
            Else

                read_cmd_sppmcoutput.Close()
                Dim read_cmd_calculate As SqlDataReader = cmd_calculate.ExecuteReader

                If read_cmd_calculate.HasRows Then
                    While read_cmd_calculate.Read
                        TXT_CurGoodQty.Text = Convert.ToDecimal(read_cmd_calculate("completeqty")).ToString("N0")
                        TXT_CurRedPalletQty.Text = Convert.ToDecimal(read_cmd_calculate("redtagsqty")).ToString("N0")
                        TXT_CurSpoilageQty.Text = Convert.ToDecimal(read_cmd_calculate("scrappedqty")).ToString("N0")

                        TXT_CurQty.Text = read_cmd_calculate("completeqty").ToString
                        TXT_RedQty.Text = read_cmd_calculate("redtagsqty").ToString
                        TXT_SpoilQty.Text = read_cmd_calculate("scrappedqty").ToString

                    End While
                    read_cmd_calculate.Close()


                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try




        Try
            OpenConnection()
            cmd.CommandText = "Select_sfms_jobtran_output"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@job", joborder)
                .AddWithValue("@suffix", suffix)
                .AddWithValue("@opernum", oper_num)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With


            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read Then

                    TXT_CurGoodQty.Text = Convert.ToDecimal(dr("completeqty")).ToString("N0")
                    TXT_CurRedPalletQty.Text = Convert.ToDecimal(dr("redtagsqty")).ToString("N0")
                    TXT_CurSpoilageQty.Text = Convert.ToDecimal(dr("scrappedqty")).ToString("N0")


                    'TXT_GoodQtyTotal.Text = dr("completeqty").ToString()
                    'TXT_RedPalletQtyTotal.Text = dr("redtagsqty").ToString()
                    'TXT_SpoilageQtyTotal.Text = dr("scrappedqty").ToString()




                    dr.Close()
                    con.Close()


                End If

                dr.Close()
                con.Close()



            End If
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



    End Sub

    Private Sub BTN_Recalculate_Click(sender As Object, e As EventArgs) Handles BTN_Recalculate.Click
        Try
            OpenConnection()
            cmd.CommandText = "Select_sfms_jobtran_output"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@job", joborder)
                .AddWithValue("@suffix", suffix)
                .AddWithValue("@opernum", oper_num)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With


            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read Then

                    TXT_CurGoodQty.Text = Convert.ToDecimal(dr("completeqty")).ToString("N0")
                    TXT_CurRedPalletQty.Text = Convert.ToDecimal(dr("redtagsqty")).ToString("N0")
                    TXT_CurSpoilageQty.Text = Convert.ToDecimal(dr("scrappedqty")).ToString("N0")


                    'TXT_GoodQtyTotal.Text = dr("completeqty").ToString()
                    'TXT_RedPalletQtyTotal.Text = dr("redtagsqty").ToString()
                    'TXT_SpoilageQtyTotal.Text = dr("scrappedqty").ToString()




                    dr.Close()
                    con.Close()


                End If

                dr.Close()
                con.Close()



            End If
            con.Close()



            MsgBox("successfully re-calculate!")

            'If BTN_Recalculate.Enabled = True Then
            '    If position = "Operator" Then
            '        BTN_Recalculate.Enabled = False
            '    Else
            '        BTN_Recalculate.Enabled = True
            '    End If


            '    If position = "Operator" Then
            '        BTN_Save.Enabled = True
            '    End If


            'Else
            '    If position = "Operator" Then
            '        BTN_Save.Enabled = True
            '    End If

            '    If position = "Operator" Then
            '        BTN_Recalculate.Enabled = False
            '    End If

            '    BTN_Recalculate.Enabled = True
            'End If






        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Try


            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcOutput WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With


            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Close()
                con.Close()


                OpenConnection()
                cmd.CommandText = "UPDATE sppmcOutput SET output_Remrks = @output_Remrks WHERE  Site = @site And mcnum = @mcnum"
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@output_Remrks", TXT_Remarks.Text)
                End With
                cmd.ExecuteNonQuery()
                con.Close()





            Else
                con.Close()



                OpenConnection()
                cmd.CommandText = "INSERT INTO sppmcOutput (Site, mcnum, output_Remrks) VALUES (@site, @mcnum,  @output_Remrks) "
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@output_Remrks", TXT_Remarks.Text)
                End With
                cmd.ExecuteNonQuery()
                con.Close()



            End If
            con.Close()







            Dim currGoodQty As Integer
            Dim currRedQty As Integer
            Dim currSpoilQty As Integer






            OpenConnection()
            cmd.CommandText = "Select_sfms_jobtran_output"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@job", joborder)
                .AddWithValue("@suffix", suffix)
                .AddWithValue("@opernum", oper_num)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With


            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read Then

                    currGoodQty = dr("completeqty").ToString()
                    currRedQty = dr("redtagsqty").ToString()
                    currSpoilQty = dr("scrappedqty").ToString()


                    'TXT_GoodQtyTotal.Text = dr("completeqty").ToString()
                    'TXT_RedPalletQtyTotal.Text = dr("redtagsqty").ToString()
                    'TXT_SpoilageQtyTotal.Text = dr("scrappedqty").ToString()




                    dr.Close()
                    con.Close()


                End If

                dr.Close()
                con.Close()



            End If
            con.Close()






            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcOutput WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With


            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Close()
                con.Close()



                OpenConnection()
                cmd.CommandText = "UPDATE sppmcOutput SET mchout_GoodCurrPalltQty  = @mchout_GoodCurrPalltQty, mchout_RedCurrPalltQty = @mchout_RedCurrPalltQty, mchout_SpoilCurrPalltQty = @mchout_SpoilCurrPalltQty WHERE  Site = @site And mcnum = @mcnum"
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@mchout_GoodCurrPalltQty", currGoodQty)
                    .AddWithValue("@mchout_RedCurrPalltQty", currRedQty)
                    .AddWithValue("@mchout_SpoilCurrPalltQty", currSpoilQty)

                End With
                cmd.ExecuteNonQuery()
                con.Close()




            Else
                con.Close()




                OpenConnection()
                cmd.CommandText = "INSERT INTO sppmcOutput (Site, mcnum , mchout_GoodCurrPalltQty, mchout_RedCurrPalltQty, mchout_SpoilCurrPalltQty) VALUES (@site, @mcnum,  @mchout_GoodCurrPalltQty, @mchout_RedCurrPalltQty, @mchout_SpoilCurrPalltQty) "
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@mchout_GoodCurrPalltQty", TXT_CurQty.Text)
                    .AddWithValue("@mchout_RedCurrPalltQty", TXT_RedQty.Text)
                    .AddWithValue("@mchout_SpoilCurrPalltQty", TXT_SpoilQty.Text)

                End With
                cmd.ExecuteNonQuery()
                con.Close()



            End If
            con.Close()

            MsgBox("Successfully saved!")


























            Dim int As Integer
            For int = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
            Next


            Dim UC_OperatorOff As New UC_OperatorOffset
            UC_OperatorOff.BTN_AddProductionRun.Enabled = True

            UC_OperatorOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorOff.Show()
            UC_OperatorOff.Dock = DockStyle.Fill


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Dim timer As New Timer()
        AddHandler timer.Tick, Sub(s, args)
                                   timer.Stop()
                                   If FRM_MonitoringChecklistMain.CHK_CkeckedUSer.Checked Then
                                       FRM_MonitoringChecklistSummary.Show()
                                       FRM_MonitoringChecklistMain.CHK_CkeckedUSer.Checked = False
                                       FRM_MonitoringChecklistMain.Hide()
                                   Else
                                       FRM_ProcessJob.txt_joborder.Text = joborder
                                       FRM_ProcessJob.txt_suffix.Text = suffix
                                       FRM_ProcessJob.txt_opernum.Text = oper_num

                                       FRM_ProcessJob.Show()
                                       FRM_MonitoringChecklistMain.Hide()
                                   End If
                               End Sub
        timer.Interval = 100 ' Adjust the interval as needed
        timer.Start()

    End Sub
End Class
