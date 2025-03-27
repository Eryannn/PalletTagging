Imports System.Data.SqlClient

Public Class UC_OperatorDigiPress
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

            'test
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read Then

                    TXT_CurGoodQty.Text = Convert.ToDecimal(dr("completeqty")).ToString("N0")
                    TXT_CurRedPalletQty.Text = Convert.ToDecimal(dr("redtagsqty")).ToString("N0")
                    TXT_CurSpoilageQty.Text = Convert.ToDecimal(dr("scrappedqty")).ToString("N0")
                    TXT_CurCleanShtsQty.Text = Convert.ToDecimal(dr("cleansheetsqty")).ToString("N0")


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
            Dim currCleanShtsQty As Integer






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
                    currCleanShtsQty = dr("cleansheetsqty").ToString()



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
                cmd.CommandText = "UPDATE sppmcOutput 
                                    SET mchout_GoodCurrPalltQty  = @mchout_GoodCurrPalltQty, 
                                    mchout_RedCurrPalltQty = @mchout_RedCurrPalltQty, 
                                    mchout_SpoilCurrPalltQty = @mchout_SpoilCurrPalltQty,
                                    mchout_CleanShtCurrPallQty = @mchout_CleanShtCurrPallQty 
                                    WHERE  Site = @site And mcnum = @mcnum"
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@mchout_GoodCurrPalltQty", currGoodQty)
                    .AddWithValue("@mchout_RedCurrPalltQty", currRedQty)
                    .AddWithValue("@mchout_SpoilCurrPalltQty", currSpoilQty)
                    .AddWithValue("@mchout_CleanShtCurrPallQty", TXT_CurCleanShtsQty.Text)

                End With
                cmd.ExecuteNonQuery()
                con.Close()




            Else
                con.Close()

                OpenConnection()
                cmd.CommandText = "INSERT INTO 
                                    sppmcOutput (Site, mcnum , mchout_GoodCurrPalltQty, mchout_RedCurrPalltQty, mchout_SpoilCurrPalltQty, mchout_CleanShtCurrPallQty) 
                                    VALUES (@site, @mcnum,  @mchout_GoodCurrPalltQty, @mchout_RedCurrPalltQty, @mchout_SpoilCurrPalltQty, @mchout_CleanShtCurrPallQty) "
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@mchout_GoodCurrPalltQty", TXT_CurQty.Text)
                    .AddWithValue("@mchout_RedCurrPalltQty", TXT_RedQty.Text)
                    .AddWithValue("@mchout_SpoilCurrPalltQty", TXT_SpoilQty.Text)
                    .AddWithValue("@mchout_CleanShtCurrPallQty", TXT_CurCleanShtsQty.Text)

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


            Dim UC_OperatorDigiPress As New UC_OperatorDigiPress
            UC_OperatorDigiPress.BTN_AddProductionRun.Enabled = True

            UC_OperatorDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorDigiPress.Show()
            UC_OperatorDigiPress.Dock = DockStyle.Fill


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UC_OperatorDigiPress_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        'DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'LoadRecord()
        'con.Close()


        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        DataGridView1.ClearSelection()
        con.Close()

        'DataGridView1.Columns(0).DefaultCellStyle.ForeColor = Color.Blue
        DataGridView1.Columns(0).DefaultCellStyle.Font = New Font(DataGridView1.DefaultCellStyle.Font, FontStyle.Bold)







        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_DGP WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "' "
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
            cmd.CommandText = "SELECT * FROM sppmcPRR_DGP WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
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



        If position = "Operator" Then
            BTN_Recalculate.Enabled = True
            TXT_Remarks.Enabled = True
            BTN_Save.Enabled = True



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
            cmd.CommandText = "Select_MCTimecomputetotalDigiPress"
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

        cmd.CommandText = "SELECT * FROM sppmcPRR_DGP WHERE Site = @site And mcnum = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader
        While dr.Read()

            DataGridView1.Rows.Add("07:00", dr.Item("prr_DPInkLdC0700"), dr.Item("prr_DPInkLdM0700"), dr.Item("prr_DPInkLdY0700"), dr.Item("prr_DPInkLdK0700"), dr.Item("prr_DPInkLdO0700"), dr.Item("prr_DPInkLdG0700"), dr.Item("prr_DPInkLdV0700"), dr.Item("prr_DPSFmainp0700"), dr.Item("prr_DPSFdrwr10700"), dr.Item("prr_DPSFdrwr20700"), dr.Item("prr_DPOffcolor0700"), dr.Item("prr_DPOffcolor0700val"), dr.Item("prr_DPPlug0700"), dr.Item("prr_DPPlug0700val"), dr.Item("prr_DPHawa0700"), dr.Item("prr_DPHawa0700val"), dr.Item("prr_DPSlurring0700"), dr.Item("prr_DPSlurring0700val"), dr.Item("prr_DPghostng0700"), dr.Item("prr_DPghostng0700val"), dr.Item("prr_DPMisreg0700"), dr.Item("prr_DPMisreg0700val"), dr.Item("prr_DPDent0700"), dr.Item("prr_DPDent0700val"), dr.Item("prr_DPSpot0700"), dr.Item("prr_DPSpot0700val"), Convert.ToDecimal(total_0700).ToString("N0"))
            DataGridView1.Rows.Add("08:00", dr.Item("prr_DPInkLdC0800"), dr.Item("prr_DPInkLdM0800"), dr.Item("prr_DPInkLdY0800"), dr.Item("prr_DPInkLdK0800"), dr.Item("prr_DPInkLdO0800"), dr.Item("prr_DPInkLdG0800"), dr.Item("prr_DPInkLdV0800"), dr.Item("prr_DPSFmainp0800"), dr.Item("prr_DPSFdrwr10800"), dr.Item("prr_DPSFdrwr20800"), dr.Item("prr_DPOffcolor0800"), dr.Item("prr_DPOffcolor0800val"), dr.Item("prr_DPPlug0800"), dr.Item("prr_DPPlug0800val"), dr.Item("prr_DPHawa0800"), dr.Item("prr_DPHawa0800val"), dr.Item("prr_DPSlurring0800"), dr.Item("prr_DPSlurring0800val"), dr.Item("prr_DPghostng0800"), dr.Item("prr_DPghostng0800val"), dr.Item("prr_DPMisreg0800"), dr.Item("prr_DPMisreg0800val"), dr.Item("prr_DPDent0800"), dr.Item("prr_DPDent0800val"), dr.Item("prr_DPSpot0800"), dr.Item("prr_DPSpot0800val"), Convert.ToDecimal(total_0800).ToString("N0"))
            DataGridView1.Rows.Add("09:00", dr.Item("prr_DPInkLdC0900"), dr.Item("prr_DPInkLdM0900"), dr.Item("prr_DPInkLdY0900"), dr.Item("prr_DPInkLdK0900"), dr.Item("prr_DPInkLdO0900"), dr.Item("prr_DPInkLdG0900"), dr.Item("prr_DPInkLdV0900"), dr.Item("prr_DPSFmainp0900"), dr.Item("prr_DPSFdrwr10900"), dr.Item("prr_DPSFdrwr20900"), dr.Item("prr_DPOffcolor0900"), dr.Item("prr_DPOffcolor0900val"), dr.Item("prr_DPPlug0900"), dr.Item("prr_DPPlug0900val"), dr.Item("prr_DPHawa0900"), dr.Item("prr_DPHawa0900val"), dr.Item("prr_DPSlurring0900"), dr.Item("prr_DPSlurring0900val"), dr.Item("prr_DPghostng0900"), dr.Item("prr_DPghostng0900val"), dr.Item("prr_DPMisreg0900"), dr.Item("prr_DPMisreg0900val"), dr.Item("prr_DPDent0900"), dr.Item("prr_DPDent0900val"), dr.Item("prr_DPSpot0900"), dr.Item("prr_DPSpot0900val"), Convert.ToDecimal(total_0900).ToString("N0"))
            DataGridView1.Rows.Add("10:00", dr.Item("prr_DPInkLdC1000"), dr.Item("prr_DPInkLdM1000"), dr.Item("prr_DPInkLdY1000"), dr.Item("prr_DPInkLdK1000"), dr.Item("prr_DPInkLdO1000"), dr.Item("prr_DPInkLdG1000"), dr.Item("prr_DPInkLdV1000"), dr.Item("prr_DPSFmainp1000"), dr.Item("prr_DPSFdrwr11000"), dr.Item("prr_DPSFdrwr21000"), dr.Item("prr_DPOffcolor1000"), dr.Item("prr_DPOffcolor1000val"), dr.Item("prr_DPPlug1000"), dr.Item("prr_DPPlug1000val"), dr.Item("prr_DPHawa1000"), dr.Item("prr_DPHawa1000val"), dr.Item("prr_DPSlurring1000"), dr.Item("prr_DPSlurring1000val"), dr.Item("prr_DPghostng1000"), dr.Item("prr_DPghostng1000val"), dr.Item("prr_DPMisreg1000"), dr.Item("prr_DPMisreg1000val"), dr.Item("prr_DPDent1000"), dr.Item("prr_DPDent1000val"), dr.Item("prr_DPSpot1000"), dr.Item("prr_DPSpot1000val"), Convert.ToDecimal(total_1000).ToString("N0"))
            DataGridView1.Rows.Add("11:00", dr.Item("prr_DPInkLdC1100"), dr.Item("prr_DPInkLdM1100"), dr.Item("prr_DPInkLdY1100"), dr.Item("prr_DPInkLdK1100"), dr.Item("prr_DPInkLdO1100"), dr.Item("prr_DPInkLdG1100"), dr.Item("prr_DPInkLdV1100"), dr.Item("prr_DPSFmainp1100"), dr.Item("prr_DPSFdrwr11100"), dr.Item("prr_DPSFdrwr21100"), dr.Item("prr_DPOffcolor1100"), dr.Item("prr_DPOffcolor1100val"), dr.Item("prr_DPPlug1100"), dr.Item("prr_DPPlug1100val"), dr.Item("prr_DPHawa1100"), dr.Item("prr_DPHawa1100val"), dr.Item("prr_DPSlurring1100"), dr.Item("prr_DPSlurring1100val"), dr.Item("prr_DPghostng1100"), dr.Item("prr_DPghostng1100val"), dr.Item("prr_DPMisreg1100"), dr.Item("prr_DPMisreg1100val"), dr.Item("prr_DPDent1100"), dr.Item("prr_DPDent1100val"), dr.Item("prr_DPSpot1100"), dr.Item("prr_DPSpot1100val"), Convert.ToDecimal(total_1100).ToString("N0"))
            DataGridView1.Rows.Add("12:00", dr.Item("prr_DPInkLdC1200"), dr.Item("prr_DPInkLdM1200"), dr.Item("prr_DPInkLdY1200"), dr.Item("prr_DPInkLdK1200"), dr.Item("prr_DPInkLdO1200"), dr.Item("prr_DPInkLdG1200"), dr.Item("prr_DPInkLdV1200"), dr.Item("prr_DPSFmainp1200"), dr.Item("prr_DPSFdrwr11200"), dr.Item("prr_DPSFdrwr21200"), dr.Item("prr_DPOffcolor1200"), dr.Item("prr_DPOffcolor1200val"), dr.Item("prr_DPPlug1200"), dr.Item("prr_DPPlug1200val"), dr.Item("prr_DPHawa1200"), dr.Item("prr_DPHawa1200val"), dr.Item("prr_DPSlurring1200"), dr.Item("prr_DPSlurring1200val"), dr.Item("prr_DPghostng1200"), dr.Item("prr_DPghostng1200val"), dr.Item("prr_DPMisreg1200"), dr.Item("prr_DPMisreg1200val"), dr.Item("prr_DPDent1200"), dr.Item("prr_DPDent1200val"), dr.Item("prr_DPSpot1200"), dr.Item("prr_DPSpot1200val"), Convert.ToDecimal(total_1200).ToString("N0"))
            DataGridView1.Rows.Add("01:00", dr.Item("prr_DPInkLdC0100"), dr.Item("prr_DPInkLdM0100"), dr.Item("prr_DPInkLdY0100"), dr.Item("prr_DPInkLdK0100"), dr.Item("prr_DPInkLdO0100"), dr.Item("prr_DPInkLdG0100"), dr.Item("prr_DPInkLdV0100"), dr.Item("prr_DPSFmainp0100"), dr.Item("prr_DPSFdrwr10100"), dr.Item("prr_DPSFdrwr20100"), dr.Item("prr_DPOffcolor0100"), dr.Item("prr_DPOffcolor0100val"), dr.Item("prr_DPPlug0100"), dr.Item("prr_DPPlug0100val"), dr.Item("prr_DPHawa0100"), dr.Item("prr_DPHawa0100val"), dr.Item("prr_DPSlurring0100"), dr.Item("prr_DPSlurring0100val"), dr.Item("prr_DPghostng0100"), dr.Item("prr_DPghostng0100val"), dr.Item("prr_DPMisreg0100"), dr.Item("prr_DPMisreg0100val"), dr.Item("prr_DPDent0100"), dr.Item("prr_DPDent0100val"), dr.Item("prr_DPSpot0100"), dr.Item("prr_DPSpot0100val"), Convert.ToDecimal(total_0100).ToString("N0"))
            DataGridView1.Rows.Add("02:00", dr.Item("prr_DPInkLdC0200"), dr.Item("prr_DPInkLdM0200"), dr.Item("prr_DPInkLdY0200"), dr.Item("prr_DPInkLdK0200"), dr.Item("prr_DPInkLdO0200"), dr.Item("prr_DPInkLdG0200"), dr.Item("prr_DPInkLdV0200"), dr.Item("prr_DPSFmainp0200"), dr.Item("prr_DPSFdrwr10200"), dr.Item("prr_DPSFdrwr20200"), dr.Item("prr_DPOffcolor0200"), dr.Item("prr_DPOffcolor0200val"), dr.Item("prr_DPPlug0200"), dr.Item("prr_DPPlug0200val"), dr.Item("prr_DPHawa0200"), dr.Item("prr_DPHawa0200val"), dr.Item("prr_DPSlurring0200"), dr.Item("prr_DPSlurring0200val"), dr.Item("prr_DPghostng0200"), dr.Item("prr_DPghostng0200val"), dr.Item("prr_DPMisreg0200"), dr.Item("prr_DPMisreg0200val"), dr.Item("prr_DPDent0200"), dr.Item("prr_DPDent0200val"), dr.Item("prr_DPSpot0200"), dr.Item("prr_DPSpot0200val"), Convert.ToDecimal(total_0200).ToString("N0"))
            DataGridView1.Rows.Add("03:00", dr.Item("prr_DPInkLdC0300"), dr.Item("prr_DPInkLdM0300"), dr.Item("prr_DPInkLdY0300"), dr.Item("prr_DPInkLdK0300"), dr.Item("prr_DPInkLdO0300"), dr.Item("prr_DPInkLdG0300"), dr.Item("prr_DPInkLdV0300"), dr.Item("prr_DPSFmainp0300"), dr.Item("prr_DPSFdrwr10300"), dr.Item("prr_DPSFdrwr20300"), dr.Item("prr_DPOffcolor0300"), dr.Item("prr_DPOffcolor0300val"), dr.Item("prr_DPPlug0300"), dr.Item("prr_DPPlug0300val"), dr.Item("prr_DPHawa0300"), dr.Item("prr_DPHawa0300val"), dr.Item("prr_DPSlurring0300"), dr.Item("prr_DPSlurring0300val"), dr.Item("prr_DPghostng0300"), dr.Item("prr_DPghostng0300val"), dr.Item("prr_DPMisreg0300"), dr.Item("prr_DPMisreg0300val"), dr.Item("prr_DPDent0300"), dr.Item("prr_DPDent0300val"), dr.Item("prr_DPSpot0300"), dr.Item("prr_DPSpot0300val"), Convert.ToDecimal(total_0300).ToString("N0"))
            DataGridView1.Rows.Add("04:00", dr.Item("prr_DPInkLdC0400"), dr.Item("prr_DPInkLdM0400"), dr.Item("prr_DPInkLdY0400"), dr.Item("prr_DPInkLdK0400"), dr.Item("prr_DPInkLdO0400"), dr.Item("prr_DPInkLdG0400"), dr.Item("prr_DPInkLdV0400"), dr.Item("prr_DPSFmainp0400"), dr.Item("prr_DPSFdrwr10400"), dr.Item("prr_DPSFdrwr20400"), dr.Item("prr_DPOffcolor0400"), dr.Item("prr_DPOffcolor0400val"), dr.Item("prr_DPPlug0400"), dr.Item("prr_DPPlug0400val"), dr.Item("prr_DPHawa0400"), dr.Item("prr_DPHawa0400val"), dr.Item("prr_DPSlurring0400"), dr.Item("prr_DPSlurring0400val"), dr.Item("prr_DPghostng0400"), dr.Item("prr_DPghostng0400val"), dr.Item("prr_DPMisreg0400"), dr.Item("prr_DPMisreg0400val"), dr.Item("prr_DPDent0400"), dr.Item("prr_DPDent0400val"), dr.Item("prr_DPSpot0400"), dr.Item("prr_DPSpot0400val"), Convert.ToDecimal(total_0400).ToString("N0"))
            DataGridView1.Rows.Add("05:00", dr.Item("prr_DPInkLdC0500"), dr.Item("prr_DPInkLdM0500"), dr.Item("prr_DPInkLdY0500"), dr.Item("prr_DPInkLdK0500"), dr.Item("prr_DPInkLdO0500"), dr.Item("prr_DPInkLdG0500"), dr.Item("prr_DPInkLdV0500"), dr.Item("prr_DPSFmainp0500"), dr.Item("prr_DPSFdrwr10500"), dr.Item("prr_DPSFdrwr20500"), dr.Item("prr_DPOffcolor0500"), dr.Item("prr_DPOffcolor0500val"), dr.Item("prr_DPPlug0500"), dr.Item("prr_DPPlug0500val"), dr.Item("prr_DPHawa0500"), dr.Item("prr_DPHawa0500val"), dr.Item("prr_DPSlurring0500"), dr.Item("prr_DPSlurring0500val"), dr.Item("prr_DPghostng0500"), dr.Item("prr_DPghostng0500val"), dr.Item("prr_DPMisreg0500"), dr.Item("prr_DPMisreg0500val"), dr.Item("prr_DPDent0500"), dr.Item("prr_DPDent0500val"), dr.Item("prr_DPSpot0500"), dr.Item("prr_DPSpot0500val"), Convert.ToDecimal(total_0500).ToString("N0"))
            DataGridView1.Rows.Add("05:00", dr.Item("prr_DPInkLdC0500"), dr.Item("prr_DPInkLdM0500"), dr.Item("prr_DPInkLdY0500"), dr.Item("prr_DPInkLdK0500"), dr.Item("prr_DPInkLdO0500"), dr.Item("prr_DPInkLdG0500"), dr.Item("prr_DPInkLdV0500"), dr.Item("prr_DPSFmainp0500"), dr.Item("prr_DPSFdrwr10500"), dr.Item("prr_DPSFdrwr20500"), dr.Item("prr_DPOffcolor0500"), dr.Item("prr_DPOffcolor0500val"), dr.Item("prr_DPPlug0500"), dr.Item("prr_DPPlug0500val"), dr.Item("prr_DPHawa0500"), dr.Item("prr_DPHawa0500val"), dr.Item("prr_DPSlurring0500"), dr.Item("prr_DPSlurring0500val"), dr.Item("prr_DPghostng0500"), dr.Item("prr_DPghostng0500val"), dr.Item("prr_DPMisreg0500"), dr.Item("prr_DPMisreg0500val"), dr.Item("prr_DPDent0500"), dr.Item("prr_DPDent0500val"), dr.Item("prr_DPSpot0500"), dr.Item("prr_DPSpot0500val"), Convert.ToDecimal(total_0500).ToString("N0"))
            DataGridView1.Rows.Add("06:00", dr.Item("prr_DPInkLdC0600"), dr.Item("prr_DPInkLdM0600"), dr.Item("prr_DPInkLdY0600"), dr.Item("prr_DPInkLdK0600"), dr.Item("prr_DPInkLdO0600"), dr.Item("prr_DPInkLdG0600"), dr.Item("prr_DPInkLdV0600"), dr.Item("prr_DPSFmainp0600"), dr.Item("prr_DPSFdrwr10600"), dr.Item("prr_DPSFdrwr20600"), dr.Item("prr_DPOffcolor0600"), dr.Item("prr_DPOffcolor0600val"), dr.Item("prr_DPPlug0600"), dr.Item("prr_DPPlug0600val"), dr.Item("prr_DPHawa0600"), dr.Item("prr_DPHawa0600val"), dr.Item("prr_DPSlurring0600"), dr.Item("prr_DPSlurring0600val"), dr.Item("prr_DPghostng0600"), dr.Item("prr_DPghostng0600val"), dr.Item("prr_DPMisreg0600"), dr.Item("prr_DPMisreg0600val"), dr.Item("prr_DPDent0600"), dr.Item("prr_DPDent0600val"), dr.Item("prr_DPSpot0600"), dr.Item("prr_DPSpot0600val"), Convert.ToDecimal(total_0600).ToString("N0"))



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


                    If read_cmd_sppmcoutput("mchout_CleanShtCurrPallQty").ToString() = "" Then
                        TXT_CurCleanShtsQty.Text = 0
                    Else
                        TXT_CurCleanShtsQty.Text = Convert.ToDecimal(read_cmd_sppmcoutput("mchout_CleanShtCurrPallQty")).ToString("N0")
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
                        TXT_CurCleanShtsQty.Text = Convert.ToDecimal(read_cmd_calculate("cleansheetsqty")).ToString("N0")

                        TXT_CurQty.Text = read_cmd_calculate("completeqty").ToString
                        TXT_RedQty.Text = read_cmd_calculate("redtagsqty").ToString
                        TXT_SpoilQty.Text = read_cmd_calculate("scrappedqty").ToString
                        TXT_CleanShtsQty.Text = read_cmd_calculate("cleansheetsqty").ToString

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
                    TXT_CurCleanShtsQty.Text = Convert.ToDecimal(dr("cleansheetsqty")).ToString("N0")

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

    Private Sub BTN_AddProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_AddProductionRun.Click
        FRM_AddProductionRunDIGIPRESS.Show()
        FRM_MonitoringChecklistMain.Hide()
    End Sub
End Class
