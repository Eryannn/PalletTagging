Public Class FRM_AddProductionRunStripping
    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click
        Dim selectedPinMarkings As String = ""
        Dim selectedPrintedSheetAlignment As String = ""
        Dim selectedTom As String = ""

        If RBT_PinMarkingsCheck.Checked Then
            selectedPinMarkings = "O"
        ElseIf RBT_PinMarkingsChecX.Checked Then
            selectedPinMarkings = "X"
        ElseIf RBT_PinMarkingsNA.Checked Then
            selectedPinMarkings = "N"
        End If


        If RBT_PrintedSheetAlignmentCheck.Checked Then
            selectedPrintedSheetAlignment = "O"
        ElseIf RBT_PrintedSheetAlignmentX.Checked Then
            selectedPrintedSheetAlignment = "X"
        ElseIf RBT_PrintedSheetAlignmentNA.Checked Then
            selectedPrintedSheetAlignment = "N"
        End If


        If RBT_TomCheck.Checked Then
            selectedTom = "O"
        ElseIf RBT_TomX.Checked Then
            selectedTom = "X"
        ElseIf RBT_TomNA.Checked Then
            selectedTom = "N"
        End If




        Try
            OpenConnection()

            ' Check if mcnum exists
            cmd.CommandText = "SELECT * FROM sppmcPRR_STR WHERE Site = '" & Form1.cmb_site.Text & "' And mcnum  = '" & FRM_MonitoringChecklistMain.TXT_MCNO.Text & "' "
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader()



            If dr.HasRows Then
                dr.Close()
                con.Close()


                OpenConnection()


                cmd.CommandText = "Select_TimeMaintenance"
                cmd.CommandType = CommandType.StoredProcedure

                'cmd.CommandText = "Select time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime And @ToTime order by time ASC"
                'cmd.CommandType = CommandType.Text


                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@FromTime", CBO_FromTime.Text)
                cmd.Parameters.AddWithValue("@ToTime", ComboBox1.Text)
                dr = cmd.ExecuteReader()

                If dr.HasRows Then

                    Dim times As New List(Of String)
                    While dr.Read()
                        times.Add(dr("time").ToString())
                    End While
                    dr.Close()

                    For Each vartime As String In times


                        cmd.CommandText = $"UPDATE sppmcPRR_STR 
                           SET 
                                prr_STPinMrk{vartime} = @prr_STPinMrk, 
                                prr_STPinMrk{vartime}val = @prr_STPinMrkval, 
                                prr_STPSA{vartime} = @prr_STPSA, 
                                prr_STPSA{vartime}val = @prr_STPSAval, 
                                prr_STTorn{vartime} = @prr_STTorn, 
                                prr_STTorn{vartime}val = @prr_STTornval
                            WHERE Site = @Site AND mcnum = @mcnum"
                        With cmd.Parameters
                            .Clear()
                            .AddWithValue("@Site", Form1.cmb_site.Text)
                            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                            .AddWithValue("@prr_STPinMrk", selectedPinMarkings)
                            .AddWithValue("@prr_STPinMrkval", TXT_PinMarkings.Text)
                            .AddWithValue("@prr_STPSA", selectedPrintedSheetAlignment)
                            .AddWithValue("@prr_STPSAval", TXT_PrintedSheetAlignment.Text)
                            .AddWithValue("@prr_STTorn", selectedTom)
                            .AddWithValue("@prr_STTornval", TXT_Tom.Text)
                        End With
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                    Next
                    con.Close()

                End If
                con.Close()


                Try
                    OpenConnection()
                    cmd.CommandText = "UPDATE sppmcPRR_STR   SET prr_RESNum = @prr_resnum, prr_SASNum = @prr_sasnum  WHERE Site = @Site AND mcnum = @mcnum"
                    cmd.CommandType = CommandType.Text
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        .AddWithValue("@prr_resnum", TXT_ResNo.Text)
                        .AddWithValue("@prr_sasnum", TXT_SasNo.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    con.Close()

                End Try
                MsgBox("Successfully updated!")



                'Dim selectedPinMarkings As String = ""
                'Dim selectedPrintedSheetAlignment As String = ""
                'Dim selectedTom As String = ""


            Else
                dr.Close()
                con.Close()




                'Update to header





                OpenConnection()

                cmd.CommandText = "INSERT INTO sppmcPRR_STR (Site, mcnum, prr_RESNum , prr_SASnum) VALUES (@Site, @mcnum, @prr_RESNum, @prr_SASNum)"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                cmd.Parameters.AddWithValue("@prr_SASnum", TXT_SasNo.Text)


                cmd.ExecuteNonQuery()
                con.Close()

                OpenConnection()

                'cmd.CommandText = "SELECT time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime AND @ToTime order by time ASC"
                cmd.CommandText = "Select_TimeMaintenance"
                cmd.CommandType = CommandType.StoredProcedure

                'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "
                'cmd.CommandType = CommandType.Text

                'cmd.CommandText = "SELECT time FROM [dbo].[timemaintenance] WHERE time >= @FromTime OR time <= @ToTime"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@FromTime", CBO_FromTime.Text)
                cmd.Parameters.AddWithValue("@ToTime", ComboBox1.Text)
                dr = cmd.ExecuteReader()

                If dr.HasRows Then

                    Dim times As New List(Of String)
                    While dr.Read()
                        times.Add(dr("time").ToString())
                    End While
                    dr.Close()


                    For Each vartime As String In times


                        cmd.CommandText = $"UPDATE sppmcPRR_STR 
                           SET prr_resnum = @prr_resnum, 
                               prr_sasnum = @prr_sasnum, 
                                prr_STPinMrk{vartime} = @prr_STPinMrk, 
                                prr_STPinMrk{vartime}val = @prr_STPinMrkval, 
                                prr_STPSA{vartime} = @prr_STPSA, 
                                prr_STPSA{vartime}val = @prr_STPSAval, 
                                prr_STTorn{vartime} = @prr_STTorn, 
                                prr_STTorn{vartime}val = @prr_STTornval
                            WHERE Site = @Site AND mcnum = @mcnum"
                        With cmd.Parameters
                            .Clear()
                            .AddWithValue("@Site", Form1.cmb_site.Text)
                            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                            .AddWithValue("@prr_resnum", TXT_ResNo.Text)
                            .AddWithValue("@prr_sasnum", TXT_SasNo.Text)

                            .AddWithValue("@prr_STPinMrk", selectedPinMarkings)
                            .AddWithValue("@prr_STPinMrkval", TXT_PinMarkings.Text)

                            .AddWithValue("@prr_STPSA", selectedPrintedSheetAlignment)
                            .AddWithValue("@prr_STPSAval", TXT_PrintedSheetAlignment.Text)

                            .AddWithValue("@prr_STTorn", selectedTom)
                            .AddWithValue("@prr_STTornval", TXT_Tom.Text)
                        End With
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()

                    Next
                    con.Close()
                    MsgBox("successfully saved!")
                End If
            End If
            con.Close()




            If position = "Operator" Then
                OpenConnection()
                cmd.CommandText = "UPDATE sppmcHdr SET emp_num = @emp_num WHERE Site = @Site AND mcnum = @mcnum"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                With cmd.Parameters

                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@emp_num", FRM_MonitoringChecklistMain.lbl_empnum.Text)

                End With
                cmd.ExecuteNonQuery()
                con.Close()




                OpenConnection()
                cmd.CommandText = "UPDATE sppmcJIC SET jic_Operator = @jic_Operator  WHERE Site = @Site AND mcnum = @mcnum "
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                With cmd.Parameters

                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@jic_Operator", FRM_MonitoringChecklistMain.lbl_empnum.Text)

                End With
                cmd.ExecuteNonQuery()
                con.Close()

                FRM_MonitoringChecklistMain.txt_operator.Text = FRM_MonitoringChecklistMain.lbl_empname.Text

            End If






            Dim int As Integer
            For int = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
            Next

            Dim UC_OperatorStrip As New UC_OperatorStripping
            UC_OperatorStrip.BTN_AddProductionRun.Enabled = True
            UC_OperatorStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_OperatorStrip.Show()
            UC_OperatorStrip.Dock = DockStyle.Fill

            FRM_MonitoringChecklistMain.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()
    End Sub

    Private Sub RBT_PinMarkingsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PinMarkingsCheck.CheckedChanged
        TXT_PinMarkings.Enabled = False
        TXT_PinMarkings.Text = ""
    End Sub

    Private Sub RBT_PinMarkingsChecX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PinMarkingsChecX.CheckedChanged
        TXT_PinMarkings.Enabled = True
    End Sub

    Private Sub RBT_PinMarkingsNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PinMarkingsNA.CheckedChanged
        TXT_PinMarkings.Enabled = False
    End Sub

    Private Sub RBT_PrintedSheetAlignmentCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PrintedSheetAlignmentCheck.CheckedChanged
        TXT_PrintedSheetAlignment.Enabled = False
        TXT_PrintedSheetAlignment.Text = ""
    End Sub

    Private Sub RBT_PrintedSheetAlignmentX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PrintedSheetAlignmentX.CheckedChanged
        TXT_PrintedSheetAlignment.Enabled = True
        TXT_PrintedSheetAlignment.Text = ""
    End Sub

    Private Sub RBT_PrintedSheetAlignmentNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PrintedSheetAlignmentNA.CheckedChanged
        TXT_PrintedSheetAlignment.Enabled = False
        TXT_PrintedSheetAlignment.Text = ""
    End Sub

    Private Sub RBT_TomCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TomCheck.CheckedChanged
        TXT_Tom.Enabled = False

    End Sub

    Private Sub RBT_TomX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TomX.CheckedChanged
        TXT_Tom.Enabled = True
        TXT_Tom.Text = ""
    End Sub

    Private Sub RBT_TomNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TomNA.CheckedChanged
        TXT_Tom.Enabled = False
        TXT_Tom.Text = ""
    End Sub

    Private Sub FRM_AddProductionRunStripping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        cmd.CommandText = "SELECT * FROM sppmcPRR_STR WHERE mcnum = @mcnum"
        cmd.Connection = con
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
        con.Close()
    End Sub
End Class