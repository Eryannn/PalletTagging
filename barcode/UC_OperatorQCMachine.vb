﻿Imports System.Data.SqlClient

Public Class UC_OperatorQCMachine
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


            If BTN_Recalculate.Enabled = True Then
                If position = "Operator" Then
                    BTN_Recalculate.Enabled = False
                Else
                    BTN_Recalculate.Enabled = True
                End If


                If position = "Operator" Then
                    BTN_Save.Enabled = True
                End If





            Else
                If position = "Operator" Then
                    BTN_Save.Enabled = True
                End If

                If position = "Operator" Then
                    BTN_Recalculate.Enabled = False
                End If

                BTN_Recalculate.Enabled = True
            End If












            Dim int As Integer
            For int = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
            Next

            Dim UC_OperatorQC As New UC_OperatorQCMachine
            UC_OperatorQC.BTN_AddProductionRun.Enabled = True
            UC_OperatorQC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorQC.Show()
            UC_OperatorQC.Dock = DockStyle.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UC_OperatorQCMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        con.Close()


        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_QCM  WHERE Site = @site And mcnum = @mcnum"
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





        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_QCM WHERE Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "'"
            cmd.CommandType = CommandType.Text
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

            'If RBT_Acknowledge.Text = "" Then
            '    BTN_Acknowledge.Enabled = True
            'Else
            '    BTN_Acknowledge.Enabled = False
            'End If
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
            cmd.CommandText = "Select_MCTimecomputetotalQCM"
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

        cmd.CommandText = "SELECT * FROM sppmcPRR_QCM WHERE Site = @site And  mcnum = @mcnum "
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add("07:00", dr.Item("prr_QCAlign070809"), dr.Item("prr_QCFdrGa070809"), dr.Item("prr_QCTagpts0700"), dr.Item("prr_QCTagpts0700val"), dr.Item("prr_QCScratch0700"), dr.Item("prr_QCScratch0700val"), dr.Item("prr_QCCrump0700"), dr.Item("prr_QCCrump0700val"), total_0700)
            DataGridView1.Rows.Add("08:00", dr.Item("prr_QCAlign070809"), dr.Item("prr_QCFdrGa070809"), dr.Item("prr_QCTagpts0800"), dr.Item("prr_QCTagpts0800val"), dr.Item("prr_QCScratch0800"), dr.Item("prr_QCScratch0800val"), dr.Item("prr_QCCrump0800"), dr.Item("prr_QCCrump0800val"), total_0800)
            DataGridView1.Rows.Add("09:00", dr.Item("prr_QCAlign070809"), dr.Item("prr_QCFdrGa070809"), dr.Item("prr_QCTagpts0900"), dr.Item("prr_QCTagpts0900val"), dr.Item("prr_QCScratch0900"), dr.Item("prr_QCScratch0900val"), dr.Item("prr_QCCrump0900"), dr.Item("prr_QCCrump0900val"), total_0900)
            DataGridView1.Rows.Add("1000", dr.Item("prr_QCAlign101112"), dr.Item("prr_QCFdrGa101112"), dr.Item("prr_QCTagpts1000"), dr.Item("prr_QCTagpts1000val"), dr.Item("prr_QCScratch1000"), dr.Item("prr_QCScratch1000val"), dr.Item("prr_QCCrump1000"), dr.Item("prr_QCCrump1000val"), total_1000)
            DataGridView1.Rows.Add("11:00", dr.Item("prr_QCAlign101112"), dr.Item("prr_QCFdrGa101112"), dr.Item("prr_QCTagpts1100"), dr.Item("prr_QCTagpts1100val"), dr.Item("prr_QCScratch1100"), dr.Item("prr_QCScratch1100val"), dr.Item("prr_QCCrump1100"), dr.Item("prr_QCCrump1100val"), total_1100)
            DataGridView1.Rows.Add("12:00", dr.Item("prr_QCAlign101112"), dr.Item("prr_QCFdrGa101112"), dr.Item("prr_QCTagpts1200"), dr.Item("prr_QCTagpts1200val"), dr.Item("prr_QCScratch1200"), dr.Item("prr_QCScratch1200val"), dr.Item("prr_QCCrump1200"), dr.Item("prr_QCCrump1200val"), total_1200)
            DataGridView1.Rows.Add("01:00", dr.Item("prr_QCAlign010203"), dr.Item("prr_QCFdrGa010203"), dr.Item("prr_QCTagpts0100"), dr.Item("prr_QCTagpts0100val"), dr.Item("prr_QCScratch0100"), dr.Item("prr_QCScratch0100val"), dr.Item("prr_QCCrump0100"), dr.Item("prr_QCCrump0100val"), total_0100)
            DataGridView1.Rows.Add("02:00", dr.Item("prr_QCAlign010203"), dr.Item("prr_QCFdrGa010203"), dr.Item("prr_QCTagpts0200"), dr.Item("prr_QCTagpts0200val"), dr.Item("prr_QCScratch0200"), dr.Item("prr_QCScratch0200val"), dr.Item("prr_QCCrump0200"), dr.Item("prr_QCCrump0200val"), total_0200)
            DataGridView1.Rows.Add("03:00", dr.Item("prr_QCAlign010203"), dr.Item("prr_QCFdrGa010203"), dr.Item("prr_QCTagpts0300"), dr.Item("prr_QCTagpts0300val"), dr.Item("prr_QCScratch0300"), dr.Item("prr_QCScratch0300val"), dr.Item("prr_QCCrump0300"), dr.Item("prr_QCCrump0300val"), total_0300)
            DataGridView1.Rows.Add("04:00", dr.Item("prr_QCAlign040506"), dr.Item("prr_QCFdrGa040506"), dr.Item("prr_QCTagpts0400"), dr.Item("prr_QCTagpts0400val"), dr.Item("prr_QCScratch0400"), dr.Item("prr_QCScratch0400val"), dr.Item("prr_QCCrump0400"), dr.Item("prr_QCCrump0400val"), total_0400)
            DataGridView1.Rows.Add("05:00", dr.Item("prr_QCAlign040506"), dr.Item("prr_QCFdrGa040506"), dr.Item("prr_QCTagpts0500"), dr.Item("prr_QCTagpts0500val"), dr.Item("prr_QCScratch0500"), dr.Item("prr_QCScratch0500val"), dr.Item("prr_QCCrump0500"), dr.Item("prr_QCCrump0500val"), total_0500)
            DataGridView1.Rows.Add("06:00", dr.Item("prr_QCAlign040506"), dr.Item("prr_QCFdrGa040506"), dr.Item("prr_QCTagpts0600"), dr.Item("prr_QCTagpts0600val"), dr.Item("prr_QCScratch0600"), dr.Item("prr_QCScratch0600val"), dr.Item("prr_QCCrump0600"), dr.Item("prr_QCCrump0600val"), total_0600)
        End While
        dr.Close()
        con.Close()

        AddHandler DataGridView1.CellFormatting, AddressOf DataGridView1_CellFormatting


        'sum



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

    Private Sub BTN_AddProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_AddProductionRun.Click
        FRM_AddProductionRunQCMachine.Show()
        FRM_MonitoringChecklistMain.Hide()
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
