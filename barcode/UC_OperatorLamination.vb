Imports System.Data.SqlClient

Public Class UC_OperatorLamination
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


                    dr.Close()
                    con.Close()


                End If

                dr.Close()
                con.Close()



            End If
            con.Close()



            MsgBox("successfully re-calculate!")


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


            Dim UC_OperatorLam As New UC_OperatorLamination
            UC_OperatorLam.BTN_AddProductionRun.Enabled = True

            UC_OperatorLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorLam.Show()
            UC_OperatorLam.Dock = DockStyle.Fill


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

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

    Private Sub UC_OperatorLamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        con.Close()




        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_LAM WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "' "
            cmd.CommandType = CommandType.Text
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
            cmd.CommandText = "SELECT * FROM sppmcPRR_LAM WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "' "
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
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
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try


    End Sub
    Sub LoadRecord()


        Dim total_0700_0730 As Integer
        Dim total_0800_0830 As Integer
        Dim total_0900_0930 As Integer
        Dim total_1000_1030 As Integer
        Dim total_1100_1130 As Integer
        Dim total_1200_1230 As Integer
        Dim total_0100_0130 As Integer
        Dim total_0200_0230 As Integer
        Dim total_0300_0330 As Integer
        Dim total_0400_0430 As Integer
        Dim total_0500_0530 As Integer
        Dim total_0600_0630 As Integer


        Dim sum_total As Integer




        Try
            OpenConnection()
            cmd.CommandText = "Select_MCTimecomputetotalLamination"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                If dr.Read() Then


                    If dr.GetOrdinal("total_0700_0730") >= 0 AndAlso Not IsDBNull(dr("total_0700_0730")) Then
                        total_0700_0730 = Convert.ToInt32(dr("total_0700_0730"))
                    Else
                        total_0700_0730 = 0
                    End If


                    If dr.GetOrdinal("total_0800_0830") >= 0 AndAlso Not IsDBNull(dr("total_0800_0830")) Then
                        total_0800_0830 = Convert.ToInt32(dr("total_0800_0830"))
                    Else
                        total_0800_0830 = 0
                    End If


                    If dr.GetOrdinal("total_0900_0930") >= 0 AndAlso Not IsDBNull(dr("total_0900_0930")) Then
                        total_0900_0930 = Convert.ToInt32(dr("total_0900_0930"))
                    Else
                        total_0900_0930 = 0
                    End If


                    If dr.GetOrdinal("total_1000_1030") >= 0 AndAlso Not IsDBNull(dr("total_1000_1030")) Then
                        total_1000_1030 = Convert.ToInt32(dr("total_1000_1030"))
                    Else
                        total_1000_1030 = 0
                    End If


                    If dr.GetOrdinal("total_1100_1130") >= 0 AndAlso Not IsDBNull(dr("total_1100_1130")) Then
                        total_1100_1130 = Convert.ToInt32(dr("total_1100_1130"))
                    Else
                        total_1100_1130 = 0
                    End If



                    If dr.GetOrdinal("total_1200_1230") >= 0 AndAlso Not IsDBNull(dr("total_1200_1230")) Then
                        total_1200_1230 = Convert.ToInt32(dr("total_1200_1230"))
                    Else
                        total_1200_1230 = 0
                    End If


                    If dr.GetOrdinal("total_0100_0130") >= 0 AndAlso Not IsDBNull(dr("total_0100_0130")) Then
                        total_0100_0130 = Convert.ToInt32(dr("total_0100_0130"))
                    Else
                        total_0100_0130 = 0
                    End If



                    If dr.GetOrdinal("total_0200_0230") >= 0 AndAlso Not IsDBNull(dr("total_0200_0230")) Then
                        total_0200_0230 = Convert.ToInt32(dr("total_0200_0230"))
                    Else
                        total_0200_0230 = 0
                    End If


                    If dr.GetOrdinal("total_0300_0330") >= 0 AndAlso Not IsDBNull(dr("total_0300_0330")) Then
                        total_0300_0330 = Convert.ToInt32(dr("total_0300_0330"))
                    Else
                        total_0300_0330 = 0
                    End If


                    If dr.GetOrdinal("total_0400_0430") >= 0 AndAlso Not IsDBNull(dr("total_0400_0430")) Then
                        total_0400_0430 = Convert.ToInt32(dr("total_0400_0430"))
                    Else
                        total_0400_0430 = 0
                    End If

                    If dr.GetOrdinal("total_0500_0530") >= 0 AndAlso Not IsDBNull(dr("total_0500_0530")) Then
                        total_0500_0530 = Convert.ToInt32(dr("total_0500_0530"))
                    Else
                        total_0500_0530 = 0
                    End If


                    If dr.GetOrdinal("total_0600_0630") >= 0 AndAlso Not IsDBNull(dr("total_0600_0630")) Then
                        total_0600_0630 = Convert.ToInt32(dr("total_0600_0630"))
                    Else
                        total_0600_0630 = 0
                    End If


                    sum_total = total_0700_0730 + total_0800_0830 + total_0900_0930 + total_1000_1030 + total_1100_1130 + total_1200_1230 + total_0100_0130 + total_0200_0230 + total_0300_0330 + total_0400_0430 + total_0500_0530 + total_0600_0630

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

        cmd.CommandText = "SELECT * FROM sppmcPRR_LAM WHERE Site = @site And  mcnum = @mcnum "
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add("07:00", dr.Item("prr_LAGluld0700to0800"), dr.Item("prr_LAWtrld0700to0800"), dr.Item("prr_LAThickn0700to0800"), dr.Item("prr_LAMoist0700to0800"), dr.Item("prr_LAGluApp0700"), dr.Item("prr_LAGluApp0700val"), dr.Item("prr_LAWtrApp0700"), dr.Item("prr_LAWtrApp0700val"), dr.Item("prr_LAToCrScr0700"), dr.Item("prr_LAToCrScr0700val"), "7:30", dr.Item("prr_LAGluld0730to0830"), dr.Item("prr_LAWtrld0730to0830"), dr.Item("prr_LAThickn0730to0830"), dr.Item("prr_LAMoist0730to0830"), dr.Item("prr_LAGluApp0730"), dr.Item("prr_LAGluApp0730val"), dr.Item("prr_LAWtrApp0730"), dr.Item("prr_LAWtrApp0730val"), dr.Item("prr_LAToCrScr0730"), dr.Item("prr_LAToCrScr0730val"), total_0700_0730)
            DataGridView1.Rows.Add("08:00", dr.Item("prr_LAGluld0700to0800"), dr.Item("prr_LAWtrld0700to0800"), dr.Item("prr_LAThickn0700to0800"), dr.Item("prr_LAMoist0700to0800"), dr.Item("prr_LAGluApp0800"), dr.Item("prr_LAGluApp0800val"), dr.Item("prr_LAWtrApp0800"), dr.Item("prr_LAWtrApp0800val"), dr.Item("prr_LAToCrScr0800"), dr.Item("prr_LAToCrScr0800val"), "8:30", dr.Item("prr_LAGluld0730to0830"), dr.Item("prr_LAWtrld0730to0830"), dr.Item("prr_LAThickn0730to0830"), dr.Item("prr_LAMoist0730to0830"), dr.Item("prr_LAGluApp0830"), dr.Item("prr_LAGluApp0830val"), dr.Item("prr_LAWtrApp0830"), dr.Item("prr_LAWtrApp0830val"), dr.Item("prr_LAToCrScr0830"), dr.Item("prr_LAToCrScr0830val"), total_0800_0830)
            DataGridView1.Rows.Add("09:00", dr.Item("prr_LAGluld0900to1000"), dr.Item("prr_LAWtrld0900to1000"), dr.Item("prr_LAThickn0900to1000"), dr.Item("prr_LAMoist0900to1000"), dr.Item("prr_LAGluApp0900"), dr.Item("prr_LAGluApp0900val"), dr.Item("prr_LAWtrApp0900"), dr.Item("prr_LAWtrApp0900val"), dr.Item("prr_LAToCrScr0900"), dr.Item("prr_LAToCrScr0900val"), "9:30", dr.Item("prr_LAGluld0930to1030"), dr.Item("prr_LAWtrld0930to1030"), dr.Item("prr_LAThickn0930to1030"), dr.Item("prr_LAMoist0930to1030"), dr.Item("prr_LAGluApp0930"), dr.Item("prr_LAGluApp0930val"), dr.Item("prr_LAWtrApp0930"), dr.Item("prr_LAWtrApp0930val"), dr.Item("prr_LAToCrScr0930"), dr.Item("prr_LAToCrScr0930val"), total_0900_0930)
            DataGridView1.Rows.Add("10:00", dr.Item("prr_LAGluld0900to1000"), dr.Item("prr_LAWtrld0900to1000"), dr.Item("prr_LAThickn0900to1000"), dr.Item("prr_LAMoist0900to1000"), dr.Item("prr_LAGluApp1000"), dr.Item("prr_LAGluApp1000val"), dr.Item("prr_LAWtrApp1000"), dr.Item("prr_LAWtrApp1000val"), dr.Item("prr_LAToCrScr1000"), dr.Item("prr_LAToCrScr1000val"), "10:30", dr.Item("prr_LAGluld0930to1030"), dr.Item("prr_LAWtrld0930to1030"), dr.Item("prr_LAThickn0930to1030"), dr.Item("prr_LAMoist0930to1030"), dr.Item("prr_LAGluApp1030"), dr.Item("prr_LAGluApp1030val"), dr.Item("prr_LAWtrApp1030"), dr.Item("prr_LAWtrApp1030val"), dr.Item("prr_LAToCrScr1030"), dr.Item("prr_LAToCrScr1030val"), total_1000_1030)
            DataGridView1.Rows.Add("11:00", dr.Item("prr_LAGluld1100to1200"), dr.Item("prr_LAWtrld1100to1200"), dr.Item("prr_LAThickn1100to1200"), dr.Item("prr_LAMoist1100to1200"), dr.Item("prr_LAGluApp1100"), dr.Item("prr_LAGluApp1100val"), dr.Item("prr_LAWtrApp1100"), dr.Item("prr_LAWtrApp1100val"), dr.Item("prr_LAToCrScr1100"), dr.Item("prr_LAToCrScr1100val"), "11:30", dr.Item("prr_LAGluld1130to1230"), dr.Item("prr_LAWtrld1130to1230"), dr.Item("prr_LAThickn1130to1230"), dr.Item("prr_LAMoist1130to1230"), dr.Item("prr_LAGluApp1130"), dr.Item("prr_LAGluApp1130val"), dr.Item("prr_LAWtrApp1130"), dr.Item("prr_LAWtrApp1130val"), dr.Item("prr_LAToCrScr1130"), dr.Item("prr_LAToCrScr1130val"), total_1100_1130)
            DataGridView1.Rows.Add("12:00", dr.Item("prr_LAGluld1100to1200"), dr.Item("prr_LAWtrld1100to1200"), dr.Item("prr_LAThickn1100to1200"), dr.Item("prr_LAMoist1100to1200"), dr.Item("prr_LAGluApp1200"), dr.Item("prr_LAGluApp1200val"), dr.Item("prr_LAWtrApp1200"), dr.Item("prr_LAWtrApp1200val"), dr.Item("prr_LAToCrScr1200"), dr.Item("prr_LAToCrScr1200val"), "12:30", dr.Item("prr_LAGluld1130to1230"), dr.Item("prr_LAWtrld1130to1230"), dr.Item("prr_LAThickn1130to1230"), dr.Item("prr_LAMoist1130to1230"), dr.Item("prr_LAGluApp1230"), dr.Item("prr_LAGluApp1230val"), dr.Item("prr_LAWtrApp1230"), dr.Item("prr_LAWtrApp1230val"), dr.Item("prr_LAToCrScr1230"), dr.Item("prr_LAToCrScr1230val"), total_1200_1230)
            DataGridView1.Rows.Add("01:00", dr.Item("prr_LAGluld0100to0200"), dr.Item("prr_LAWtrld0100to0200"), dr.Item("prr_LAThickn0100to0200"), dr.Item("prr_LAMoist0100to0200"), dr.Item("prr_LAGluApp0100"), dr.Item("prr_LAGluApp0100val"), dr.Item("prr_LAWtrApp0100"), dr.Item("prr_LAWtrApp0100val"), dr.Item("prr_LAToCrScr0100"), dr.Item("prr_LAToCrScr0100val"), "1:30", dr.Item("prr_LAGluld0130to0230"), dr.Item("prr_LAWtrld0130to0230"), dr.Item("prr_LAThickn0130to0230"), dr.Item("prr_LAThickn0130to0230"), dr.Item("prr_LAGluApp0130"), dr.Item("prr_LAGluApp0130val"), dr.Item("prr_LAWtrApp0130"), dr.Item("prr_LAWtrApp0130val"), dr.Item("prr_LAToCrScr0130"), dr.Item("prr_LAToCrScr0130val"), total_0100_0130)
            DataGridView1.Rows.Add("02:00", dr.Item("prr_LAGluld0100to0200"), dr.Item("prr_LAWtrld0100to0200"), dr.Item("prr_LAThickn0100to0200"), dr.Item("prr_LAMoist0100to0200"), dr.Item("prr_LAGluApp0200"), dr.Item("prr_LAGluApp0200val"), dr.Item("prr_LAWtrApp0200"), dr.Item("prr_LAWtrApp0200val"), dr.Item("prr_LAToCrScr0200"), dr.Item("prr_LAToCrScr0200val"), "2:30", dr.Item("prr_LAGluld0130to0230"), dr.Item("prr_LAWtrld0130to0230"), dr.Item("prr_LAThickn0130to0230"), dr.Item("prr_LAThickn0130to0230"), dr.Item("prr_LAGluApp0230"), dr.Item("prr_LAGluApp0230val"), dr.Item("prr_LAWtrApp0230"), dr.Item("prr_LAWtrApp0230val"), dr.Item("prr_LAToCrScr0230"), dr.Item("prr_LAToCrScr0230val"), total_0200_0230)
            DataGridView1.Rows.Add("03:00", dr.Item("prr_LAGluld0300to0400"), dr.Item("prr_LAWtrld0300to0400"), dr.Item("prr_LAThickn0300to0400"), dr.Item("prr_LAMoist0300to0400"), dr.Item("prr_LAGluApp0300"), dr.Item("prr_LAGluApp0300val"), dr.Item("prr_LAWtrApp0300"), dr.Item("prr_LAWtrApp0300val"), dr.Item("prr_LAToCrScr0300"), dr.Item("prr_LAToCrScr0300val"), "3:30", dr.Item("prr_LAGluld0330to0430"), dr.Item("prr_LAWtrld0330to0430"), dr.Item("prr_LAThickn0330to0430"), dr.Item("prr_LAMoist0330to0430"), dr.Item("prr_LAGluApp0330"), dr.Item("prr_LAGluApp0330val"), dr.Item("prr_LAWtrApp0330"), dr.Item("prr_LAWtrApp0330val"), dr.Item("prr_LAToCrScr0330"), dr.Item("prr_LAToCrScr0330val"), total_0300_0330)
            DataGridView1.Rows.Add("04:00", dr.Item("prr_LAGluld0300to0400"), dr.Item("prr_LAWtrld0300to0400"), dr.Item("prr_LAThickn0300to0400"), dr.Item("prr_LAMoist0300to0400"), dr.Item("prr_LAGluApp0400"), dr.Item("prr_LAGluApp0400val"), dr.Item("prr_LAWtrApp0400"), dr.Item("prr_LAWtrApp0400val"), dr.Item("prr_LAToCrScr0400"), dr.Item("prr_LAToCrScr0400val"), "4:30", dr.Item("prr_LAGluld0330to0430"), dr.Item("prr_LAWtrld0330to0430"), dr.Item("prr_LAThickn0330to0430"), dr.Item("prr_LAMoist0330to0430"), dr.Item("prr_LAGluApp0430"), dr.Item("prr_LAGluApp0430val"), dr.Item("prr_LAWtrApp0430"), dr.Item("prr_LAWtrApp0430val"), dr.Item("prr_LAToCrScr0430"), dr.Item("prr_LAToCrScr0430val"), total_0400_0430)
            DataGridView1.Rows.Add("05:00", dr.Item("prr_LAGluld0500to0600"), dr.Item("prr_LAWtrld0500to0600"), dr.Item("prr_LAThickn0500to0600"), dr.Item("prr_LAMoist0500to0600"), dr.Item("prr_LAGluApp0500"), dr.Item("prr_LAGluApp0500val"), dr.Item("prr_LAWtrApp0500"), dr.Item("prr_LAWtrApp0500val"), dr.Item("prr_LAToCrScr0500"), dr.Item("prr_LAToCrScr0500val"), "5:30", dr.Item("prr_LAGluld0530to0630"), dr.Item("prr_LAWtrld0530to0630"), dr.Item("prr_LAThickn0530to0630"), dr.Item("prr_LAMoist0530to0630"), dr.Item("prr_LAGluApp0530"), dr.Item("prr_LAGluApp0530val"), dr.Item("prr_LAWtrApp0530"), dr.Item("prr_LAWtrApp0530val"), dr.Item("prr_LAToCrScr0530"), dr.Item("prr_LAToCrScr0530val"), total_0500_0530)
            DataGridView1.Rows.Add("06:00", dr.Item("prr_LAGluld0500to0600"), dr.Item("prr_LAWtrld0500to0600"), dr.Item("prr_LAThickn0500to0600"), dr.Item("prr_LAMoist0500to0600"), dr.Item("prr_LAGluApp0600"), dr.Item("prr_LAGluApp0600val"), dr.Item("prr_LAWtrApp0600"), dr.Item("prr_LAWtrApp0600val"), dr.Item("prr_LAToCrScr0600"), dr.Item("prr_LAToCrScr0600val"), "6:30", dr.Item("prr_LAGluld0530to0630"), dr.Item("prr_LAWtrld0530to0630"), dr.Item("prr_LAThickn0530to0630"), dr.Item("prr_LAMoist0530to0630"), dr.Item("prr_LAGluApp0630"), dr.Item("prr_LAGluApp0630val"), dr.Item("prr_LAWtrApp0630"), dr.Item("prr_LAWtrApp0630val"), dr.Item("prr_LAToCrScr0630"), dr.Item("prr_LAToCrScr0630val"), total_0600_0630)
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

    Private Sub BTN_AddProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_AddProductionRun.Click

        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            FRM_AddProductionRunLamination.Show()
            FRM_MonitoringChecklistMain.Hide()
        End If



    End Sub
End Class
