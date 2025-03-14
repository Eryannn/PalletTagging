Imports System.Data.SqlClient

Public Class UC_OperatorGluingLamina
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


            Dim UC_OperatorGluingLamina As New UC_OperatorGluingLamina
            UC_OperatorGluingLamina.BTN_AddProductionRun.Enabled = True

            UC_OperatorGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorGluingLamina.Show()
            UC_OperatorGluingLamina.Dock = DockStyle.Fill


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UC_OperatorGluingLamina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        DataGridView1.ClearSelection()
        con.Close()

        'DataGridView1.Columns(0).DefaultCellStyle.ForeColor = Color.Blue
        DataGridView1.Columns(0).DefaultCellStyle.Font = New Font(DataGridView1.DefaultCellStyle.Font, FontStyle.Bold)



        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_GLU  WHERE Site = @site And mcnum = @mcnum"
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



        'SHOWING THE VALUE FOR RES No SAS No
        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_GLU WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "'"
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
            BTN_Save.Visible = True
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
            BTN_Save.Enabled = False
            BTN_AddProductionRun.Enabled = False

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
            cmd.CommandText = "Select_MCTimecomputetotalGLU"
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

        cmd.CommandText = "SELECT * FROM sppmcPRR_GLU WHERE Site = @site And mcnum = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader
        While dr.Read()

            DataGridView1.Rows.Add("07:00", dr.Item("prr_GLFlywh0700"), dr.Item("prr_GLGluTnk0700"), dr.Item("prr_GLShiCa0700"), dr.Item("prr_GLFdrGS070809"), dr.Item("prr_GLExWkGl0700"), dr.Item("prr_GLExWkGl0700val"), dr.Item("prr_GLCrumSc0700"), dr.Item("prr_GLCrumSc0700val"), dr.Item("prr_GLOvrlap0700"), dr.Item("prr_GLOvrlap0700val"), dr.Item("prr_GLIncCnt0700"), dr.Item("prr_GLIncCnt0700val"), Convert.ToDecimal(total_0700).ToString("N0"))
            DataGridView1.Rows.Add("08:00", dr.Item("prr_GLFlywh0800"), dr.Item("prr_GLGluTnk0800"), dr.Item("prr_GLShiCa0800"), dr.Item("prr_GLFdrGS070809"), dr.Item("prr_GLExWkGl0800"), dr.Item("prr_GLExWkGl0800val"), dr.Item("prr_GLCrumSc0800"), dr.Item("prr_GLCrumSc0800val"), dr.Item("prr_GLOvrlap0800"), dr.Item("prr_GLOvrlap0800val"), dr.Item("prr_GLIncCnt0800"), dr.Item("prr_GLIncCnt0800val"), Convert.ToDecimal(total_0800).ToString("N0"))
            DataGridView1.Rows.Add("09:00", dr.Item("prr_GLFlywh0900"), dr.Item("prr_GLGluTnk0900"), dr.Item("prr_GLShiCa0900"), dr.Item("prr_GLFdrGS070809"), dr.Item("prr_GLExWkGl0900"), dr.Item("prr_GLExWkGl0900val"), dr.Item("prr_GLCrumSc0900"), dr.Item("prr_GLCrumSc0900val"), dr.Item("prr_GLOvrlap0900"), dr.Item("prr_GLOvrlap0900val"), dr.Item("prr_GLIncCnt0900"), dr.Item("prr_GLIncCnt0900val"), Convert.ToDecimal(total_0900).ToString("N0"))
            DataGridView1.Rows.Add("10:00", dr.Item("prr_GLFlywh1000"), dr.Item("prr_GLGluTnk1000"), dr.Item("prr_GLShiCa1000"), dr.Item("prr_GLFdrGS101112"), dr.Item("prr_GLExWkGl1000"), dr.Item("prr_GLExWkGl1000val"), dr.Item("prr_GLCrumSc1000"), dr.Item("prr_GLCrumSc1000val"), dr.Item("prr_GLOvrlap1000"), dr.Item("prr_GLOvrlap1000val"), dr.Item("prr_GLIncCnt1000"), dr.Item("prr_GLIncCnt1000val"), Convert.ToDecimal(total_1000).ToString("N0"))
            DataGridView1.Rows.Add("11:00", dr.Item("prr_GLFlywh1100"), dr.Item("prr_GLGluTnk1100"), dr.Item("prr_GLShiCa1100"), dr.Item("prr_GLFdrGS101112"), dr.Item("prr_GLExWkGl1100"), dr.Item("prr_GLExWkGl1100val"), dr.Item("prr_GLCrumSc1100"), dr.Item("prr_GLCrumSc1100val"), dr.Item("prr_GLOvrlap1100"), dr.Item("prr_GLOvrlap1100val"), dr.Item("prr_GLIncCnt1100"), dr.Item("prr_GLIncCnt1100val"), Convert.ToDecimal(total_1100).ToString("N0"))
            DataGridView1.Rows.Add("12:00", dr.Item("prr_GLFlywh1200"), dr.Item("prr_GLGluTnk1200"), dr.Item("prr_GLShiCa1200"), dr.Item("prr_GLFdrGS101112"), dr.Item("prr_GLExWkGl1200"), dr.Item("prr_GLExWkGl1200val"), dr.Item("prr_GLCrumSc1200"), dr.Item("prr_GLCrumSc1200val"), dr.Item("prr_GLOvrlap1200"), dr.Item("prr_GLOvrlap1200val"), dr.Item("prr_GLIncCnt1200"), dr.Item("prr_GLIncCnt1200val"), Convert.ToDecimal(total_1200).ToString("N0"))
            DataGridView1.Rows.Add("01:00", dr.Item("prr_GLFlywh0100"), dr.Item("prr_GLGluTnk0100"), dr.Item("prr_GLShiCa0100"), dr.Item("prr_GLFdrGS010203"), dr.Item("prr_GLExWkGl0100"), dr.Item("prr_GLExWkGl0100val"), dr.Item("prr_GLCrumSc0100"), dr.Item("prr_GLCrumSc0100val"), dr.Item("prr_GLOvrlap0100"), dr.Item("prr_GLOvrlap0100val"), dr.Item("prr_GLIncCnt0100"), dr.Item("prr_GLIncCnt0100val"), Convert.ToDecimal(total_0100).ToString("N0"))
            DataGridView1.Rows.Add("02:00", dr.Item("prr_GLFlywh0200"), dr.Item("prr_GLGluTnk0200"), dr.Item("prr_GLShiCa0200"), dr.Item("prr_GLFdrGS010203"), dr.Item("prr_GLExWkGl0200"), dr.Item("prr_GLExWkGl0200val"), dr.Item("prr_GLCrumSc0200"), dr.Item("prr_GLCrumSc0200val"), dr.Item("prr_GLOvrlap0200"), dr.Item("prr_GLOvrlap0200val"), dr.Item("prr_GLIncCnt0200"), dr.Item("prr_GLIncCnt0200val"), Convert.ToDecimal(total_0200).ToString("N0"))
            DataGridView1.Rows.Add("03:00", dr.Item("prr_GLFlywh0300"), dr.Item("prr_GLGluTnk0300"), dr.Item("prr_GLShiCa0300"), dr.Item("prr_GLFdrGS010203"), dr.Item("prr_GLExWkGl0300"), dr.Item("prr_GLExWkGl0300val"), dr.Item("prr_GLCrumSc0300"), dr.Item("prr_GLCrumSc0300val"), dr.Item("prr_GLOvrlap0300"), dr.Item("prr_GLOvrlap0300val"), dr.Item("prr_GLIncCnt0300"), dr.Item("prr_GLIncCnt0300val"), Convert.ToDecimal(total_0300).ToString("N0"))
            DataGridView1.Rows.Add("04:00", dr.Item("prr_GLFlywh0400"), dr.Item("prr_GLGluTnk0400"), dr.Item("prr_GLShiCa0400"), dr.Item("prr_GLFdrGS040506"), dr.Item("prr_GLExWkGl0400"), dr.Item("prr_GLExWkGl0400val"), dr.Item("prr_GLCrumSc0400"), dr.Item("prr_GLCrumSc0400val"), dr.Item("prr_GLOvrlap0400"), dr.Item("prr_GLOvrlap0400val"), dr.Item("prr_GLIncCnt0400"), dr.Item("prr_GLIncCnt0400val"), Convert.ToDecimal(total_0400).ToString("N0"))
            DataGridView1.Rows.Add("05:00", dr.Item("prr_GLFlywh0500"), dr.Item("prr_GLGluTnk0500"), dr.Item("prr_GLShiCa0500"), dr.Item("prr_GLFdrGS040506"), dr.Item("prr_GLExWkGl0500"), dr.Item("prr_GLExWkGl0500val"), dr.Item("prr_GLCrumSc0500"), dr.Item("prr_GLCrumSc0500val"), dr.Item("prr_GLOvrlap0500"), dr.Item("prr_GLOvrlap0500val"), dr.Item("prr_GLIncCnt0500"), dr.Item("prr_GLIncCnt0500val"), Convert.ToDecimal(total_0500).ToString("N0"))
            DataGridView1.Rows.Add("06:00", dr.Item("prr_GLFlywh0600"), dr.Item("prr_GLGluTnk0600"), dr.Item("prr_GLShiCa0600"), dr.Item("prr_GLFdrGS040506"), dr.Item("prr_GLExWkGl0600"), dr.Item("prr_GLExWkGl0600val"), dr.Item("prr_GLCrumSc0600"), dr.Item("prr_GLCrumSc0600val"), dr.Item("prr_GLOvrlap0600"), dr.Item("prr_GLOvrlap0600val"), dr.Item("prr_GLIncCnt0600"), dr.Item("prr_GLIncCnt0600val"), Convert.ToDecimal(total_0600).ToString("N0"))


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


        'If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
        '    If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
        '        e.Value = ""
        '    End If
        'End If

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
        FRM_AddProductionRunGluingLamina.Show()
        FRM_MonitoringChecklistMain.Hide()
    End Sub

End Class
