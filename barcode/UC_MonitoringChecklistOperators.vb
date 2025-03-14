Imports System.Data.SqlClient
Public Class UC_MonitoringChecklistOperators
    Dim Privatejob As String = joborder
    Dim Privatesuffix As String = suffix
    Dim Privateoper_num As String = oper_num




    'Public Sub SumOfPrevCurGood()
    '    If TXT_CurGoodPallet.Text = "" Then
    '        TXT_CurGoodPallet.Text = 0
    '    End If

    '    If TXT_PrevGoodPallet.Text = "" Then
    '        TXT_PrevGoodPallet.Text = 0
    '    End If

    '    Dim PrevGood As Integer = CInt(TXT_CurGoodPallet.Text)
    '    Dim CurGood As Integer = CInt(TXT_PrevGoodPallet.Text)


    '    Dim total As Integer = PrevGood + CurGood
    '    ' Convert the total back to a string and display it in the text box
    '    TXT_GoodPalletTotal.Text = total.ToString()
    'End Sub



    'Public Sub SumOfPrevCurGoodQty()
    '    If TXT_CurGoodQty.Text = "" Then
    '        TXT_CurGoodQty.Text = 0
    '    End If

    '    If TXT_PrevGoodQty.Text = "" Then
    '        TXT_PrevGoodQty.Text = 0
    '    End If

    '    Dim PrevGood As Integer = CInt(TXT_CurGoodQty.Text)
    '    Dim CurGood As Integer = CInt(TXT_PrevGoodQty.Text)

    '    Dim total As Integer = PrevGood + CurGood
    '    ' Convert the total back to a string and display it in the text box
    '    TXT_GoodQtyTotal.Text = total.ToString()
    'End Sub



    'Public Sub SumOfPrevCurRedtag()
    '    If TXT_PrevRedPallet.Text = "" Then
    '        TXT_PrevRedPallet.Text = 0
    '    End If

    '    'If TXT_CurRedPallet.Text = "" Then
    '    '    TXT_CurRedPallet.Text = 0
    '    'End If

    '    Dim PrevGood As Integer = CInt(TXT_PrevRedPallet.Text)
    '    'Dim CurGood As Integer = CInt(TXT_CurRedPallet.Text)


    '    'Dim total As Integer = PrevGood + CurGood
    '    '' Convert the total back to a string and display it in the text box
    '    'TXT_RedPalletTotal.Text = total.ToString()
    'End Sub

    'Public Sub SumOfPrevCurRedtagQTY()

    '    If TXT_PrevRedPalletQty.Text = "" Then
    '        TXT_PrevRedPalletQty.Text = 0
    '    End If

    '    If TXT_CurRedPalletQty.Text = "" Then
    '        TXT_CurRedPalletQty.Text = 0
    '    End If

    '    Dim PrevGood As Integer = CInt(TXT_PrevRedPalletQty.Text)
    '    Dim CurGood As Integer = CInt(TXT_CurRedPalletQty.Text)


    '    Dim total As Integer = PrevGood + CurGood
    '    ' Convert the total back to a string and display it in the text box
    '    TXT_RedPalletQtyTotal.Text = total.ToString()
    'End Sub


    'Public Sub SumOfPrevCurSpoilageQty()
    '    If TXT_PrevSpoilageQty.Text = "" Then
    '        TXT_PrevSpoilageQty.Text = 0
    '    End If

    '    If TXT_CurSpoilageQty.Text = "" Then
    '        TXT_CurSpoilageQty.Text = 0
    '    End If

    '    Dim PrevGood As Integer = CInt(TXT_PrevSpoilageQty.Text)
    '    Dim CurGood As Integer = CInt(TXT_CurSpoilageQty.Text)

    '    Dim total As Integer = PrevGood + CurGood
    '    ' Convert the total back to a string and display it in the text box
    '    TXT_SpoilageQtyTotal.Text = total.ToString()
    'End Sub



    'Public Sub EnableButtonMachineOutput()
    '    TXT_PrevGoodPallet.Enabled = True
    '    TXT_PrevGoodQty.Enabled = True
    '    TXT_CurGoodPallet.Enabled = True
    '    TXT_CurGoodQty.Enabled = True
    '    TXT_PrevRedPallet.Enabled = True
    '    TXT_PrevRedPalletQty.Enabled = True
    '    TXT_PrevGoodQty.Enabled = True
    '    'TXT_CurRedPallet.Enabled = True
    '    TXT_CurRedPalletQty.Enabled = True
    '    TXT_PrevSpoilageQty.Enabled = True
    '    TXT_CurSpoilageQty.Enabled = True
    '    TXT_Remarks.Enabled = True
    'End Sub


    'Public Sub DisabledButtonMachineOutput()
    '    TXT_PrevGoodPallet.Enabled = False
    '    TXT_PrevGoodQty.Enabled = False
    '    TXT_CurGoodPallet.Enabled = False
    '    TXT_CurGoodQty.Enabled = False
    '    TXT_PrevRedPallet.Enabled = False
    '    TXT_PrevRedPalletQty.Enabled = False
    '    TXT_PrevGoodQty.Enabled = False
    '    'TXT_CurRedPallet.Enabled = False
    '    TXT_CurRedPalletQty.Enabled = False
    '    TXT_PrevSpoilageQty.Enabled = False
    '    TXT_CurSpoilageQty.Enabled = False
    '    TXT_Remarks.Enabled = False
    'End Sub


    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub UC_MonitoringChecklistOperators_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LBL_MCNO.Text = FRM_MonitoringChecklistMain.lbl_empname.Text
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LoadRecord()
        con.Close()

        Try
            OpenConnection()
            cmd.CommandText = "SELECT * FROM sppmcPRR_CUT WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "' "
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
            cmd.CommandText = "SELECT * FROM sppmcPRR_CUT WHERE  Site = '" & Form1.cmb_site.Text & "'  And mcnum = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "'"
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

            If FRM_MonitoringChecklistMain.BTN_AddMCNo.Visible = False Then
                BTN_AddProductionRun.Enabled = True
            Else
                BTN_AddProductionRun.Enabled = True
            End If


            If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then
                BTN_AddProductionRun.Enabled = False

            End If

        Else
            BTN_AddProductionRun.Enabled = False

            BTN_Save.Visible = False
            TXT_Remarks.Enabled = False

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
            TXT_Remarks.Enabled = False
            BTN_Save.Enabled = False
        Else
            TXT_Remarks.Enabled = True
            calculate_output_sfms_jobtran()
            If position <> "Operator" Then

                TXT_Remarks.Enabled = False

            Else


                BTN_Recalculate.Enabled = True
                TXT_Remarks.Enabled = True

            End If

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
            cmd.CommandText = "Select_MCTimecomputetotal"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@MCNo", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
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

        cmd.CommandText = "SELECT * FROM sppmcPRR_CUT WHERE Site = @site And mcnum = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader
        While dr.Read()
            DataGridView1.Rows.Add("07:00", dr.Item("prr_CUbladeshrp0700"), dr.Item("prr_CUbladecond0700"), dr.Item("prr_CULosefibr0700"), dr.Item("prr_CULosefibr0700val"), dr.Item("prr_CUOffsquare0700"), dr.Item("prr_CUOffsquare0700val"), dr.Item("prr_CUIncordimen0700"), dr.Item("prr_CUIncordimen0700val"), dr.Item("prr_CUTearoff0700"), dr.Item("prr_CUTearoff0700val"), dr.Item("prr_CUIncorGrainDir0700"), dr.Item("prr_CUIncorGrainDir0700val"), "07:30", dr.Item("prr_CUbladeshrp0730"), dr.Item("prr_CUbladecond0730"), dr.Item("prr_CULosefibr0730"), dr.Item("prr_CULosefibr0730val"), dr.Item("prr_CUOffsquare0730"), dr.Item("prr_CUOffsquare0730val"), dr.Item("prr_CUIncordimen0730"), dr.Item("prr_CUIncordimen0730val"), dr.Item("prr_CUTearoff0730"), dr.Item("prr_CUTearoff0730val"), dr.Item("prr_CUIncorGrainDir0730"), dr.Item("prr_CUIncorGrainDir0730val"), Convert.ToDecimal(Total_0700_0730).ToString("N0"))
            DataGridView1.Rows.Add("08:00", dr.Item("prr_CUbladeshrp0800"), dr.Item("prr_CUbladecond0800"), dr.Item("prr_CULosefibr0800"), dr.Item("prr_CULosefibr0800val"), dr.Item("prr_CUOffsquare0800"), dr.Item("prr_CUOffsquare0800val"), dr.Item("prr_CUIncordimen0800"), dr.Item("prr_CUIncordimen0800val"), dr.Item("prr_CUTearoff0800"), dr.Item("prr_CUTearoff0800val"), dr.Item("prr_CUIncorGrainDir0800"), dr.Item("prr_CUIncorGrainDir0800val"), "08:30", dr.Item("prr_CUbladeshrp0830"), dr.Item("prr_CUbladecond0830"), dr.Item("prr_CULosefibr0830"), dr.Item("prr_CULosefibr0830val"), dr.Item("prr_CUOffsquare0830"), dr.Item("prr_CUOffsquare0830val"), dr.Item("prr_CUIncordimen0830"), dr.Item("prr_CUIncordimen0830val"), dr.Item("prr_CUTearoff0830"), dr.Item("prr_CUTearoff0830val"), dr.Item("prr_CUIncorGrainDir0830"), dr.Item("prr_CUIncorGrainDir0830val"), Convert.ToDecimal(total_0800_0830).ToString("N0"))
            DataGridView1.Rows.Add("09:00", dr.Item("prr_CUbladeshrp0900"), dr.Item("prr_CUbladecond0900"), dr.Item("prr_CULosefibr0900"), dr.Item("prr_CULosefibr0900val"), dr.Item("prr_CUOffsquare0900"), dr.Item("prr_CUOffsquare0900val"), dr.Item("prr_CUIncordimen0900"), dr.Item("prr_CUIncordimen0900val"), dr.Item("prr_CUTearoff0900"), dr.Item("prr_CUTearoff0900val"), dr.Item("prr_CUIncorGrainDir0900"), dr.Item("prr_CUIncorGrainDir0900val"), "09:30", dr.Item("prr_CUbladeshrp0930"), dr.Item("prr_CUbladecond0930"), dr.Item("prr_CULosefibr0930"), dr.Item("prr_CULosefibr0930val"), dr.Item("prr_CUOffsquare0930"), dr.Item("prr_CUOffsquare0930val"), dr.Item("prr_CUIncordimen0930"), dr.Item("prr_CUIncordimen0930val"), dr.Item("prr_CUTearoff0930"), dr.Item("prr_CUTearoff0930val"), dr.Item("prr_CUIncorGrainDir0930"), dr.Item("prr_CUIncorGrainDir0930val"), Convert.ToDecimal(total_0900_0930).ToString("N0"))
            DataGridView1.Rows.Add("10:00", dr.Item("prr_CUbladeshrp1000"), dr.Item("prr_CUbladecond1000"), dr.Item("prr_CULosefibr1000"), dr.Item("prr_CULosefibr1000val"), dr.Item("prr_CUOffsquare1000"), dr.Item("prr_CUOffsquare1000val"), dr.Item("prr_CUIncordimen1000"), dr.Item("prr_CUIncordimen1000val"), dr.Item("prr_CUTearoff1000"), dr.Item("prr_CUTearoff1000val"), dr.Item("prr_CUIncorGrainDir1000"), dr.Item("prr_CUIncorGrainDir1000val"), "10:30", dr.Item("prr_CUbladeshrp1030"), dr.Item("prr_CUbladecond1030"), dr.Item("prr_CULosefibr1030"), dr.Item("prr_CULosefibr1030val"), dr.Item("prr_CUOffsquare1030"), dr.Item("prr_CUOffsquare1030val"), dr.Item("prr_CUIncordimen1030"), dr.Item("prr_CUIncordimen1030val"), dr.Item("prr_CUTearoff1030"), dr.Item("prr_CUTearoff1030val"), dr.Item("prr_CUIncorGrainDir1030"), dr.Item("prr_CUIncorGrainDir1030val"), Convert.ToDecimal(total_1000_1030).ToString("N0"))
            DataGridView1.Rows.Add("11:00", dr.Item("prr_CUbladeshrp1100"), dr.Item("prr_CUbladecond1100"), dr.Item("prr_CULosefibr1100"), dr.Item("prr_CULosefibr1100val"), dr.Item("prr_CUOffsquare1100"), dr.Item("prr_CUOffsquare1100val"), dr.Item("prr_CUIncordimen1100"), dr.Item("prr_CUIncordimen1100val"), dr.Item("prr_CUTearoff1100"), dr.Item("prr_CUTearoff1100val"), dr.Item("prr_CUIncorGrainDir1100"), dr.Item("prr_CUIncorGrainDir1100val"), "11:30", dr.Item("prr_CUbladeshrp1130"), dr.Item("prr_CUbladecond1130"), dr.Item("prr_CULosefibr1130"), dr.Item("prr_CULosefibr1130val"), dr.Item("prr_CUOffsquare1130"), dr.Item("prr_CUOffsquare1130val"), dr.Item("prr_CUIncordimen1130"), dr.Item("prr_CUIncordimen1130val"), dr.Item("prr_CUTearoff1130"), dr.Item("prr_CUTearoff1130val"), dr.Item("prr_CUIncorGrainDir1130"), dr.Item("prr_CUIncorGrainDir1130val"), Convert.ToDecimal(total_1100_1130).ToString("N0"))
            DataGridView1.Rows.Add("12:00", dr.Item("prr_CUbladeshrp1200"), dr.Item("prr_CUbladecond1200"), dr.Item("prr_CULosefibr1200"), dr.Item("prr_CULosefibr1200val"), dr.Item("prr_CUOffsquare1200"), dr.Item("prr_CUOffsquare1200val"), dr.Item("prr_CUIncordimen1200"), dr.Item("prr_CUIncordimen1200val"), dr.Item("prr_CUTearoff1200"), dr.Item("prr_CUTearoff1200val"), dr.Item("prr_CUIncorGrainDir1200"), dr.Item("prr_CUIncorGrainDir1200val"), "12:30", dr.Item("prr_CUbladeshrp1230"), dr.Item("prr_CUbladecond1230"), dr.Item("prr_CULosefibr1230"), dr.Item("prr_CULosefibr1230val"), dr.Item("prr_CUOffsquare1230"), dr.Item("prr_CUOffsquare1230val"), dr.Item("prr_CUIncordimen1230"), dr.Item("prr_CUIncordimen1230val"), dr.Item("prr_CUTearoff1230"), dr.Item("prr_CUTearoff1230val"), dr.Item("prr_CUIncorGrainDir1230"), dr.Item("prr_CUIncorGrainDir1230val"), Convert.ToDecimal(total_1200_1230).ToString("N0"))
            DataGridView1.Rows.Add("01:00", dr.Item("prr_CUbladeshrp0100"), dr.Item("prr_CUbladecond0100"), dr.Item("prr_CULosefibr0100"), dr.Item("prr_CULosefibr0100val"), dr.Item("prr_CUOffsquare0100"), dr.Item("prr_CUOffsquare0100val"), dr.Item("prr_CUIncordimen0100"), dr.Item("prr_CUIncordimen0100val"), dr.Item("prr_CUTearoff0100"), dr.Item("prr_CUTearoff0100val"), dr.Item("prr_CUIncorGrainDir0100"), dr.Item("prr_CUIncorGrainDir0100val"), "01:30", dr.Item("prr_CUbladeshrp0130"), dr.Item("prr_CUbladecond0130"), dr.Item("prr_CULosefibr0130"), dr.Item("prr_CULosefibr0130val"), dr.Item("prr_CUOffsquare0130"), dr.Item("prr_CUOffsquare0130val"), dr.Item("prr_CUIncordimen0130"), dr.Item("prr_CUIncordimen0130val"), dr.Item("prr_CUTearoff0130"), dr.Item("prr_CUTearoff0130val"), dr.Item("prr_CUIncorGrainDir0130"), dr.Item("prr_CUIncorGrainDir0130val"), Convert.ToDecimal(total_0100_0130).ToString("N0"))
            DataGridView1.Rows.Add("02:00", dr.Item("prr_CUbladeshrp0200"), dr.Item("prr_CUbladecond0200"), dr.Item("prr_CULosefibr0200"), dr.Item("prr_CULosefibr0200val"), dr.Item("prr_CUOffsquare0200"), dr.Item("prr_CUOffsquare0200val"), dr.Item("prr_CUIncordimen0200"), dr.Item("prr_CUIncordimen0200val"), dr.Item("prr_CUTearoff0200"), dr.Item("prr_CUTearoff0200val"), dr.Item("prr_CUIncorGrainDir0200"), dr.Item("prr_CUIncorGrainDir0200val"), "02:30", dr.Item("prr_CUbladeshrp0230"), dr.Item("prr_CUbladecond0230"), dr.Item("prr_CULosefibr0230"), dr.Item("prr_CULosefibr0230val"), dr.Item("prr_CUOffsquare0230"), dr.Item("prr_CUOffsquare0230val"), dr.Item("prr_CUIncordimen0230"), dr.Item("prr_CUIncordimen0230val"), dr.Item("prr_CUTearoff0230"), dr.Item("prr_CUTearoff0230val"), dr.Item("prr_CUIncorGrainDir0230"), dr.Item("prr_CUIncorGrainDir0230val"), Convert.ToDecimal(total_0200_0230).ToString("N0"))
            DataGridView1.Rows.Add("03:00", dr.Item("prr_CUbladeshrp0300"), dr.Item("prr_CUbladecond0300"), dr.Item("prr_CULosefibr0300"), dr.Item("prr_CULosefibr0300val"), dr.Item("prr_CUOffsquare0300"), dr.Item("prr_CUOffsquare0300val"), dr.Item("prr_CUIncordimen0300"), dr.Item("prr_CUIncordimen0300val"), dr.Item("prr_CUTearoff0300"), dr.Item("prr_CUTearoff0300val"), dr.Item("prr_CUIncorGrainDir0300"), dr.Item("prr_CUIncorGrainDir0300val"), "03:30", dr.Item("prr_CUbladeshrp0330"), dr.Item("prr_CUbladecond0330"), dr.Item("prr_CULosefibr0330"), dr.Item("prr_CULosefibr0330val"), dr.Item("prr_CUOffsquare0330"), dr.Item("prr_CUOffsquare0330val"), dr.Item("prr_CUIncordimen0330"), dr.Item("prr_CUIncordimen0330val"), dr.Item("prr_CUTearoff0330"), dr.Item("prr_CUTearoff0330val"), dr.Item("prr_CUIncorGrainDir0330"), dr.Item("prr_CUIncorGrainDir0330val"), Convert.ToDecimal(total_0300_0330).ToString("N0"))
            DataGridView1.Rows.Add("04:00", dr.Item("prr_CUbladeshrp0400"), dr.Item("prr_CUbladecond0400"), dr.Item("prr_CULosefibr0400"), dr.Item("prr_CULosefibr0400val"), dr.Item("prr_CUOffsquare0400"), dr.Item("prr_CUOffsquare0400val"), dr.Item("prr_CUIncordimen0400"), dr.Item("prr_CUIncordimen0400val"), dr.Item("prr_CUTearoff0400"), dr.Item("prr_CUTearoff0400val"), dr.Item("prr_CUIncorGrainDir0400"), dr.Item("prr_CUIncorGrainDir0400val"), "04:30", dr.Item("prr_CUbladeshrp0430"), dr.Item("prr_CUbladecond0430"), dr.Item("prr_CULosefibr0430"), dr.Item("prr_CULosefibr0430val"), dr.Item("prr_CUOffsquare0430"), dr.Item("prr_CUOffsquare0430val"), dr.Item("prr_CUIncordimen0430"), dr.Item("prr_CUIncordimen0430val"), dr.Item("prr_CUTearoff0430"), dr.Item("prr_CUTearoff0430val"), dr.Item("prr_CUIncorGrainDir0430"), dr.Item("prr_CUIncorGrainDir0430val"), Convert.ToDecimal(total_0400_0430).ToString("N0"))
            DataGridView1.Rows.Add("05:00", dr.Item("prr_CUbladeshrp0500"), dr.Item("prr_CUbladecond0500"), dr.Item("prr_CULosefibr0500"), dr.Item("prr_CULosefibr0500val"), dr.Item("prr_CUOffsquare0500"), dr.Item("prr_CUOffsquare0500val"), dr.Item("prr_CUIncordimen0500"), dr.Item("prr_CUIncordimen0500val"), dr.Item("prr_CUTearoff0500"), dr.Item("prr_CUTearoff0500val"), dr.Item("prr_CUIncorGrainDir0500"), dr.Item("prr_CUIncorGrainDir0500val"), "05:30", dr.Item("prr_CUbladeshrp0530"), dr.Item("prr_CUbladecond0530"), dr.Item("prr_CULosefibr0530"), dr.Item("prr_CULosefibr0530val"), dr.Item("prr_CUOffsquare0530"), dr.Item("prr_CUOffsquare0530val"), dr.Item("prr_CUIncordimen0530"), dr.Item("prr_CUIncordimen0530val"), dr.Item("prr_CUTearoff0530"), dr.Item("prr_CUTearoff0530val"), dr.Item("prr_CUIncorGrainDir0530"), dr.Item("prr_CUIncorGrainDir0530val"), Convert.ToDecimal(total_0500_0530).ToString("N0"))
            DataGridView1.Rows.Add("06:00", dr.Item("prr_CUbladeshrp0600"), dr.Item("prr_CUbladecond0600"), dr.Item("prr_CULosefibr0600"), dr.Item("prr_CULosefibr0600val"), dr.Item("prr_CUOffsquare0600"), dr.Item("prr_CUOffsquare0600val"), dr.Item("prr_CUIncordimen0600"), dr.Item("prr_CUIncordimen0600val"), dr.Item("prr_CUTearoff0600"), dr.Item("prr_CUTearoff0600val"), dr.Item("prr_CUIncorGrainDir0600"), dr.Item("prr_CUIncorGrainDir0600val"), "06:30", dr.Item("prr_CUbladeshrp0630"), dr.Item("prr_CUbladecond0630"), dr.Item("prr_CULosefibr0630"), dr.Item("prr_CULosefibr0630val"), dr.Item("prr_CUOffsquare0630"), dr.Item("prr_CUOffsquare0630val"), dr.Item("prr_CUIncordimen0630"), dr.Item("prr_CUIncordimen0630val"), dr.Item("prr_CUTearoff0630"), dr.Item("prr_CUTearoff0630val"), dr.Item("prr_CUIncorGrainDir0630"), dr.Item("prr_CUIncorGrainDir0630val"), Convert.ToDecimal(total_0600_0630).ToString("N0"))
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

        'If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
        '    If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
        '        e.Value = "N"
        '    End If
        'End If

        If e.ColumnIndex >= 1 AndAlso e.ColumnIndex <= 100 Then ' Adjust the column range if necessary
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "N" Then
                e.Value = "N/A"
            End If
        End If
    End Sub


    Private Sub BTN_AddProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_AddProductionRun.Click
        FRM_AddProductionRun.Show()
        FRM_MonitoringChecklistMain.Hide()

        FRM_AddProductionRun.TXT_DummyResNo.Text = TXT_ResNo.Text
        FRM_AddProductionRun.TXT_DummySasNo.Text = TXT_SasNo.Text

        FRM_AddProductionRun.TXT_CheckMCNo.Text = FRM_MonitoringChecklistMain.TXT_MCNO.Text






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


    Private Sub TXT_PrevOutPallet1_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub

    Private Sub TXT_PrevOutQty1_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub

    Private Sub TXT_PrevOutPallet2_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub


    Private Sub TXT_PrevOutQty2_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub

    Private Sub TXT_PrevOutQty3_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub

    Private Sub TXT_CurrentPallet1_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub



    Private Sub TXT_CurrentQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CurGoodQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_CurrentPallet2_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberOnly(e)
    End Sub


    Private Sub TXT_CurrentQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CurRedPalletQty.KeyPress
        NumberOnly(e)
    End Sub




    Private Sub TXT_CurrentQty3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CurSpoilageQty.KeyPress
        NumberOnly(e)
    End Sub

    'Private Sub BTN_SaveMchOut_Click(sender As Object, e As EventArgs)
    '    Try

    '        If BTN_SaveMchOut.Text = "Save" Then
    '            OpenConnection()
    '            cmd.CommandText = "Insert_sppmcOutput" 'this Is my stored procedure name
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.Clear()

    '            With cmd.Parameters
    '                With cmd.Parameters
    '                    .AddWithValue("@Site", Form1.cmb_site.Text)
    '                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
    '                    .AddWithValue("@mchout_GoodPrevPallt", TXT_PrevGoodPallet.Text)
    '                    .AddWithValue("@mchout_GoodPrevPalltQty", TXT_PrevGoodQty.Text)
    '                    .AddWithValue("@mchout_GoodCurrPallt", TXT_CurGoodPallet.Text)
    '                    .AddWithValue("@mchout_GoodCurrPalltQty", TXT_CurGoodQty.Text)
    '                    .AddWithValue("@mchout_RedPrevPallt", TXT_PrevRedPallet.Text)
    '                    .AddWithValue("@mchout_RedPrevPalltQty", TXT_PrevGoodQty.Text)
    '                    '.AddWithValue("@mchout_RedCurrPallt", TXT_CurRedPallet.Text)
    '                    .AddWithValue("@mchout_RedCurrPalltQty", TXT_CurRedPalletQty.Text)
    '                    .AddWithValue("@mchout_SpoilPrevPalltQty", TXT_PrevSpoilageQty.Text)
    '                    .AddWithValue("@mchout_SpoilCurrPalltQty", TXT_CurSpoilageQty.Text)

    '                    .AddWithValue("@mchout_Remrks", TXT_Remarks.Text)


    '                End With

    '                BTN_AddMachineOutput.Text = "Edit"
    '                BTN_SaveMchOut.Text = "Update"

    '                BTN_AddMachineOutput.Enabled = True

    '                BTN_SaveMchOut.Enabled = False
    '                DisabledButtonMachineOutput()



    '            End With
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '            MsgBox("Sucessfully added!")



    '        ElseIf BTN_SaveMchOut.Text = "Update"
    '            OpenConnection()
    '            cmd.CommandText = "Update_sppmcOutput" 'this Is my stored procedure name
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.Clear()

    '            With cmd.Parameters
    '                With cmd.Parameters
    '                    .AddWithValue("@Site", Form1.cmb_site.Text)
    '                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
    '                    .AddWithValue("@mchout_GoodPrevPallt", TXT_PrevGoodPallet.Text)
    '                    .AddWithValue("@mchout_GoodPrevPalltQty", TXT_PrevGoodQty.Text)
    '                    .AddWithValue("@mchout_GoodCurrPallt", TXT_CurGoodPallet.Text)
    '                    .AddWithValue("@mchout_GoodCurrPalltQty", TXT_CurGoodQty.Text)
    '                    .AddWithValue("@mchout_RedPrevPallt", TXT_PrevRedPallet.Text)
    '                    .AddWithValue("@mchout_RedPrevPalltQty", TXT_PrevGoodQty.Text)
    '                    '.AddWithValue("@mchout_RedCurrPallt", TXT_CurRedPallet.Text)
    '                    .AddWithValue("@mchout_RedCurrPalltQty", TXT_CurRedPalletQty.Text)
    '                    .AddWithValue("@mchout_SpoilPrevPalltQty", TXT_PrevSpoilageQty.Text)
    '                    .AddWithValue("@mchout_SpoilCurrPalltQty", TXT_CurSpoilageQty.Text)

    '                    .AddWithValue("@mchout_Remrks", TXT_Remarks.Text)

    '                End With

    '            End With
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '            MsgBox("Sucessfully Updated!")

    '            BTN_AddMachineOutput.Enabled = True
    '            BTN_SaveMchOut.Enabled = False

    '            DisabledButtonMachineOutput()


    '        End If



    '        BTN_SaveMchOut.ForeColor = Color.Blue
    '        BTN_SaveMchOut.BackColor = Color.White


    '        BTN_AddMachineOutput.ForeColor = Color.White
    '        BTN_AddMachineOutput.BackColor = Color.Green



    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub

    'Private Sub BTN_AddMachineOutput_Click(sender As Object, e As EventArgs)
    '    EnableButtonMachineOutput()
    '    BTN_AddMachineOutput.Enabled = False
    '    BTN_SaveMchOut.Enabled = True


    '    BTN_AddMachineOutput.ForeColor = Color.Blue
    '    BTN_AddMachineOutput.BackColor = Color.White


    '    BTN_SaveMchOut.ForeColor = Color.White
    '    BTN_SaveMchOut.BackColor = Color.Green



    'End Sub

    Private Sub TXT_PrevGoodPallet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_CurGoodPallet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_PrevGoodQty_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_CurGoodQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_CurGoodQty.TextChanged

    End Sub

    Private Sub TXT_PrevRedPallet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_CurRedPallet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_PrevRedPalletQty_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_CurRedPalletQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_CurRedPalletQty.TextChanged

    End Sub

    Private Sub TXT_PrevSpoilageQty_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_CurSpoilageQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_CurSpoilageQty.TextChanged

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

            Dim MonitoringChecklistOperator1 As New UC_MonitoringChecklistOperators
            MonitoringChecklistOperator1.BTN_AddProductionRun.Enabled = True
            MonitoringChecklistOperator1.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistOperator1.Show()
            MonitoringChecklistOperator1.Dock = DockStyle.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try











    End Sub
End Class
