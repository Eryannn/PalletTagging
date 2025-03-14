Imports System.Data.SqlClient

Public Class UC_OperatorStripping
    Private Sub BTN_AddProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_AddProductionRun.Click
        FRM_AddProductionRunStripping.Show()
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

            Dim UC_OperatorStripp As New UC_OperatorStripping
            UC_OperatorStripp.BTN_AddProductionRun.Enabled = True
            UC_OperatorStripp.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorStripp.Show()
            UC_OperatorStripp.Dock = DockStyle.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try





    End Sub

    Private Sub UC_OperatorStripping_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        con.Close()

        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_STR WHERE Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "' "
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


        'SHOWING THE VALUE FOR RES No SAS No
        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_STR WHERE Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "'"
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

        Dim Total_0700_0730 As Integer
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
            cmd.CommandText = "Select_MCTimecomputetotalStripping"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                If dr.Read() Then


                    If dr.GetOrdinal("total_0700_0730") >= 0 AndAlso Not IsDBNull(dr("total_0700_0730")) Then
                        Total_0700_0730 = Convert.ToInt32(dr("total_0700_0730"))
                    Else
                        Total_0700_0730 = 0
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


                    sum_total = Total_0700_0730 + total_0800_0830 + total_0900_0930 + total_1000_1030 + total_1100_1130 + total_1200_1230 + total_0100_0130 + total_0200_0230 + total_0300_0330 + total_0400_0430 + total_0500_0530 + total_0600_0630

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

        cmd.CommandText = "SELECT * FROM sppmcPRR_STR WHERE Site = @site And mcnum = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader
        While dr.Read()
            DataGridView1.Rows.Add("07:00", dr.Item("prr_STPinMrk0700"), dr.Item("prr_STPinMrk0700val"), dr.Item("prr_STPSA0700"), dr.Item("prr_STPSA0700val"), dr.Item("prr_STTorn0700"), dr.Item("prr_STTorn0700val"), "07:30", dr.Item("prr_STPinMrk0730"), dr.Item("prr_STPinMrk0730val"), dr.Item("prr_STPSA0730"), dr.Item("prr_STPSA0730val"), dr.Item("prr_STTorn0730"), dr.Item("prr_STTorn0730val"), Convert.ToDecimal(Total_0700_0730).ToString("N0"))
            DataGridView1.Rows.Add("08:00", dr.Item("prr_STPinMrk0800"), dr.Item("prr_STPinMrk0800val"), dr.Item("prr_STPSA0800"), dr.Item("prr_STPSA0800val"), dr.Item("prr_STTorn0800"), dr.Item("prr_STTorn0800val"), "08:30", dr.Item("prr_STPinMrk0830"), dr.Item("prr_STPinMrk0830val"), dr.Item("prr_STPSA0830"), dr.Item("prr_STPSA0830val"), dr.Item("prr_STTorn0830"), dr.Item("prr_STTorn0830val"), Convert.ToDecimal(total_0800_0830).ToString("N0"))
            DataGridView1.Rows.Add("09:00", dr.Item("prr_STPinMrk0900"), dr.Item("prr_STPinMrk0900val"), dr.Item("prr_STPSA0900"), dr.Item("prr_STPSA0900val"), dr.Item("prr_STTorn0900"), dr.Item("prr_STTorn0900val"), "09:30", dr.Item("prr_STPinMrk0930"), dr.Item("prr_STPinMrk0930val"), dr.Item("prr_STPSA0930"), dr.Item("prr_STPSA0930val"), dr.Item("prr_STTorn0930"), dr.Item("prr_STTorn0930val"), Convert.ToDecimal(total_0900_0930).ToString("N0"))
            DataGridView1.Rows.Add("10:00", dr.Item("prr_STPinMrk1000"), dr.Item("prr_STPinMrk1000val"), dr.Item("prr_STPSA1000"), dr.Item("prr_STPSA1000val"), dr.Item("prr_STTorn1000"), dr.Item("prr_STTorn1000val"), "10:30", dr.Item("prr_STPinMrk1030"), dr.Item("prr_STPinMrk1030val"), dr.Item("prr_STPSA1030"), dr.Item("prr_STPSA1030val"), dr.Item("prr_STTorn1030"), dr.Item("prr_STTorn1030val"), Convert.ToDecimal(total_1000_1030).ToString("N0"))
            DataGridView1.Rows.Add("11:00", dr.Item("prr_STPinMrk1100"), dr.Item("prr_STPinMrk1100val"), dr.Item("prr_STPSA1100"), dr.Item("prr_STPSA1100val"), dr.Item("prr_STTorn1100"), dr.Item("prr_STTorn1100val"), "11:30", dr.Item("prr_STPinMrk1130"), dr.Item("prr_STPinMrk1130val"), dr.Item("prr_STPSA1130"), dr.Item("prr_STPSA1130val"), dr.Item("prr_STTorn1130"), dr.Item("prr_STTorn1130val"), Convert.ToDecimal(total_1100_1130).ToString("N0"))
            DataGridView1.Rows.Add("12:00", dr.Item("prr_STPinMrk1200"), dr.Item("prr_STPinMrk1200val"), dr.Item("prr_STPSA1200"), dr.Item("prr_STPSA1200val"), dr.Item("prr_STTorn1200"), dr.Item("prr_STTorn1200val"), "12:30", dr.Item("prr_STPinMrk1230"), dr.Item("prr_STPinMrk1230val"), dr.Item("prr_STPSA1230"), dr.Item("prr_STPSA1230val"), dr.Item("prr_STTorn1230"), dr.Item("prr_STTorn1230val"), Convert.ToDecimal(total_1200_1230).ToString("N0"))
            DataGridView1.Rows.Add("01:00", dr.Item("prr_STPinMrk0100"), dr.Item("prr_STPinMrk0100val"), dr.Item("prr_STPSA0100"), dr.Item("prr_STPSA0100val"), dr.Item("prr_STTorn0100"), dr.Item("prr_STTorn0100val"), "01:30", dr.Item("prr_STPinMrk0130"), dr.Item("prr_STPinMrk0130val"), dr.Item("prr_STPSA0130"), dr.Item("prr_STPSA0130val"), dr.Item("prr_STTorn0130"), dr.Item("prr_STTorn0130val"), Convert.ToDecimal(total_0100_0130).ToString("N0"))
            DataGridView1.Rows.Add("02:00", dr.Item("prr_STPinMrk0200"), dr.Item("prr_STPinMrk0200val"), dr.Item("prr_STPSA0200"), dr.Item("prr_STPSA0200val"), dr.Item("prr_STTorn0200"), dr.Item("prr_STTorn0200val"), "02:30", dr.Item("prr_STPinMrk0230"), dr.Item("prr_STPinMrk0230val"), dr.Item("prr_STPSA0230"), dr.Item("prr_STPSA0230val"), dr.Item("prr_STTorn0230"), dr.Item("prr_STTorn0230val"), Convert.ToDecimal(total_0200_0230).ToString("N0"))
            DataGridView1.Rows.Add("03:00", dr.Item("prr_STPinMrk0300"), dr.Item("prr_STPinMrk0300val"), dr.Item("prr_STPSA0300"), dr.Item("prr_STPSA0300val"), dr.Item("prr_STTorn0300"), dr.Item("prr_STTorn0300val"), "03:30", dr.Item("prr_STPinMrk0330"), dr.Item("prr_STPinMrk0330val"), dr.Item("prr_STPSA0330"), dr.Item("prr_STPSA0330val"), dr.Item("prr_STTorn0330"), dr.Item("prr_STTorn0330val"), Convert.ToDecimal(total_0300_0330).ToString("N0"))
            DataGridView1.Rows.Add("04:00", dr.Item("prr_STPinMrk0400"), dr.Item("prr_STPinMrk0400val"), dr.Item("prr_STPSA0400"), dr.Item("prr_STPSA0400val"), dr.Item("prr_STTorn0400"), dr.Item("prr_STTorn0400val"), "04:30", dr.Item("prr_STPinMrk0430"), dr.Item("prr_STPinMrk0430val"), dr.Item("prr_STPSA0430"), dr.Item("prr_STPSA0430val"), dr.Item("prr_STTorn0430"), dr.Item("prr_STTorn0430val"), Convert.ToDecimal(total_0400_0430).ToString("N0"))
            DataGridView1.Rows.Add("05:00", dr.Item("prr_STPinMrk0500"), dr.Item("prr_STPinMrk0500val"), dr.Item("prr_STPSA0500"), dr.Item("prr_STPSA0500val"), dr.Item("prr_STTorn0500"), dr.Item("prr_STTorn0500val"), "05:30", dr.Item("prr_STPinMrk0530"), dr.Item("prr_STPinMrk0530val"), dr.Item("prr_STPSA0530"), dr.Item("prr_STPSA0530val"), dr.Item("prr_STTorn0530"), dr.Item("prr_STTorn0530val"), Convert.ToDecimal(total_0500_0530).ToString("N0"))
            DataGridView1.Rows.Add("06:00", dr.Item("prr_STPinMrk0600"), dr.Item("prr_STPinMrk0600val"), dr.Item("prr_STPSA0600"), dr.Item("prr_STPSA0600val"), dr.Item("prr_STTorn0600"), dr.Item("prr_STTorn0600val"), "06:30", dr.Item("prr_STPinMrk0630"), dr.Item("prr_STPinMrk0630val"), dr.Item("prr_STPSA0630"), dr.Item("prr_STPSA0630val"), dr.Item("prr_STTorn0630"), dr.Item("prr_STTorn0630val"), Convert.ToDecimal(total_0600_0630).ToString("N0"))

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
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "0" Then
                e.Value = ""
            End If
        End If


        'If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
        '    If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
        '        e.Value = ""
        '    End If
        'End If

        'If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
        '    If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
        '        e.Value = ""
        '    End If
        'End If

        'If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
        '    If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
        '        e.Value = "N"
        '    End If
        'End If

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
End Class
