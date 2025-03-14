Public Class FRM_AddProductionRunQCMachine
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()

        Dim i As Integer
        For i = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        Dim UC_OperatorQCMach As New UC_OperatorQCMachine
        UC_OperatorQCMach.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorQCMach.Show()
        UC_OperatorQCMach.Dock = DockStyle.Fill
    End Sub

    Private Sub BTN_SaveProcessMonitoring_Click(sender As Object, e As EventArgs) Handles BTN_SaveProcessMonitoring.Click

        Dim selectedAlignment7to9AM As String = ""
        Dim selectedAlignment10to12PM As String = ""
        Dim selectedAlignment1to3PM As String = ""
        Dim selectedAlignment4t6PM As String = ""




        If RBT_Alignment7to9AMCheck.Checked Then
            selectedAlignment7to9AM = "O"
        ElseIf RBT_Alignment7to9AMX.Checked Then
            selectedAlignment7to9AM = "X"
        ElseIf RBT_Alignment7to9AMNA.Checked Then
            selectedAlignment7to9AM = "N"
        End If


        If RBT_Alignment10to12PMCheck.Checked Then
            selectedAlignment10to12PM = "O"
        ElseIf RBT_Alignment10to12PMX.Checked Then
            selectedAlignment10to12PM = "X"
        ElseIf RBT_Alignment10to12PMNA.Checked Then
            selectedAlignment10to12PM = "N"
        End If

        If RBT_Alignment1to3PMCheck.Checked Then
            selectedAlignment1to3PM = "O"
        ElseIf RBT_Alignment1to3PMX.Checked Then
            selectedAlignment1to3PM = "X"
        ElseIf RBT_Alignment1to3PMNA.Checked Then
            selectedAlignment1to3PM = "N"
        End If


        If RBT_Alignment4to6PMCheck.Checked Then
            selectedAlignment4t6PM = "O"
        ElseIf RBT_Alignment4to6PMX.Checked Then
            selectedAlignment4t6PM = "X"
        ElseIf RBT_Alignment4to6PMNA.Checked Then
            selectedAlignment4t6PM = "N"
        End If


        Dim selectedFeederGauge7to9AM As String = ""
        Dim selectedFeederGauge10to12PM As String = ""
        Dim selectedFeederGauge1to3PM As String = ""
        Dim selectedFeederGauge4t6PM As String = ""



        If RBT_Feeder7to9AMCheck.Checked Then
            selectedFeederGauge7to9AM = "O"
        ElseIf RBT_Feeder7to9AMX.Checked Then
            selectedFeederGauge7to9AM = "X"
        ElseIf RBT_Feeder7to9AMNA.Checked Then
            selectedFeederGauge7to9AM = "N"
        End If



        If RBT_Feeder10to12PMCheck.Checked Then
            selectedFeederGauge10to12PM = "O"
        ElseIf RBT_Feeder10to12PMX.Checked Then
            selectedFeederGauge10to12PM = "X"
        ElseIf RBT_Feeder10to12PMNA.Checked Then
            selectedFeederGauge10to12PM = "N"
        End If



        If RBT_Feeder1to3PMCheck.Checked Then
            selectedFeederGauge1to3PM = "O"
        ElseIf RBT_Feeder1to3PMX.Checked Then
            selectedFeederGauge1to3PM = "X"
        ElseIf RBT_Feeder1to3PMNA.Checked Then
            selectedFeederGauge1to3PM = "N"
        End If



        If RBT_Feeder4to6PMCheck.Checked Then
            selectedFeederGauge4t6PM = "O"
        ElseIf RBT_Feeder4to6PMX.Checked Then
            selectedFeederGauge4t6PM = "X"
        ElseIf RBT_Feeder4to6PMNA.Checked Then
            selectedFeederGauge4t6PM = "N"
        End If









        'Dim Alignment7AM_9AM_Decimal As Double
        'Dim Alignment10AM_12PM_Decimal As Double
        'Dim Alignment1PM_300PM_Decimal As Double
        'Dim Alignment4PM_600PM_Decimal As Double


        'Double.TryParse(TXT_Alignment7AM_9AM.Text, Alignment7AM_9AM_Decimal)
        'Double.TryParse(TXT_Alignment10AM_12PN.Text, Alignment10AM_12PM_Decimal)
        'Double.TryParse(TXT_Alignment1PM_300PM.Text, Alignment1PM_300PM_Decimal)
        'Double.TryParse(TXT_Alignment4PM_600PM.Text, Alignment4PM_600PM_Decimal)


        'Dim FeederGauge7AM_900AM_Decimal As Double
        'Dim FeederGauge10AM_1200PM_Decimal As Double
        'Dim FeederGauge1PM_3PM_Decimal As Double
        'Dim FeederGauge4PM_6PM_Decimal As Double


        'Double.TryParse(TXT_FeederGauge7AM_900AM.Text, FeederGauge7AM_900AM_Decimal)
        'Double.TryParse(TXT_FeederGauge10AM_1200PM.Text, FeederGauge10AM_1200PM_Decimal)
        'Double.TryParse(TXT_FeederGauge1PM_3PM.Text, FeederGauge1PM_3PM_Decimal)
        'Double.TryParse(TXT_FeederGauge4PM_6PM.Text, FeederGauge4PM_6PM_Decimal)




        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_QCM WHERE Site = @site  And mcnum  = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            con.Close()



            Try

                OpenConnection()
                cmd.CommandText = "UPDATE sppmcPRR_QCM SET " &
                                          "prr_RESNum = @prr_RESNum, " &
                                          "prr_SASNum = @prr_SASNum, " &
                                          "prr_QCAlign070809 = @prr_QCAlign070809, " &
                                          "prr_QCAlign101112 = @prr_QCAlign101112, " &
                                          "prr_QCAlign010203 = @prr_QCAlign010203, " &
                                          "prr_QCAlign040506 = @prr_QCAlign040506, " &
                                          "prr_QCFdrGa070809 = @prr_QCFdrGa070809, " &
                                          "prr_QCFdrGa101112 = @prr_QCFdrGa101112, " &
                                          "prr_QCFdrGa010203 = @prr_QCFdrGa010203, " &
                                          "prr_QCFdrGa040506 = @prr_QCFdrGa040506 " &
                                          "WHERE Site = @Site AND mcnum = @mcnum"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()

                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text) ' Add your actual values
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)


                    .AddWithValue("@prr_QCAlign070809", selectedAlignment7to9AM)
                    .AddWithValue("@prr_QCAlign101112", selectedAlignment10to12PM)
                    .AddWithValue("@prr_QCAlign010203", selectedAlignment1to3PM)
                    .AddWithValue("@prr_QCAlign040506", selectedAlignment4t6PM)
                    .AddWithValue("@prr_QCFdrGa070809", selectedFeederGauge7to9AM)
                    .AddWithValue("@prr_QCFdrGa101112", selectedFeederGauge10to12PM)
                    .AddWithValue("@prr_QCFdrGa010203", selectedFeederGauge1to3PM)
                    .AddWithValue("@prr_QCFdrGa040506", selectedFeederGauge4t6PM)

                End With

                cmd.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try






        Else
            con.Close()



            Try

                OpenConnection()
                cmd.CommandText = "Insert_sppmcPRR_QCM"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)

                    .AddWithValue("@prr_QCAlign070809", selectedAlignment7to9AM)
                    .AddWithValue("@prr_QCAlign101112", selectedAlignment10to12PM)
                    .AddWithValue("@prr_QCAlign010203", selectedAlignment1to3PM)
                    .AddWithValue("@prr_QCAlign040506", selectedAlignment4t6PM)
                    .AddWithValue("@prr_QCFdrGa070809", selectedFeederGauge7to9AM)
                    .AddWithValue("@prr_QCFdrGa101112", selectedFeederGauge10to12PM)
                    .AddWithValue("@prr_QCFdrGa010203", selectedFeederGauge1to3PM)
                    .AddWithValue("@prr_QCFdrGa040506", selectedFeederGauge4t6PM)

                    .AddWithValue("@prr_QCTagpts0700", "")
                    .AddWithValue("@prr_QCTagpts0800", "")
                    .AddWithValue("@prr_QCTagpts0900", "")
                    .AddWithValue("@prr_QCTagpts1000", "")
                    .AddWithValue("@prr_QCTagpts1100", "")
                    .AddWithValue("@prr_QCTagpts1200", "")
                    .AddWithValue("@prr_QCTagpts0100", "")
                    .AddWithValue("@prr_QCTagpts0200", "")
                    .AddWithValue("@prr_QCTagpts0300", "")
                    .AddWithValue("@prr_QCTagpts0400", "")
                    .AddWithValue("@prr_QCTagpts0500", "")
                    .AddWithValue("@prr_QCTagpts0600", "")
                    .AddWithValue("@prr_QCTagpts0700val", "")
                    .AddWithValue("@prr_QCTagpts0800val", "")
                    .AddWithValue("@prr_QCTagpts0900val", "")
                    .AddWithValue("@prr_QCTagpts1000val", "")
                    .AddWithValue("@prr_QCTagpts1100val", "")
                    .AddWithValue("@prr_QCTagpts1200val", "")
                    .AddWithValue("@prr_QCTagpts0100val", "")
                    .AddWithValue("@prr_QCTagpts0200val", "")
                    .AddWithValue("@prr_QCTagpts0300val", "")
                    .AddWithValue("@prr_QCTagpts0400val", "")
                    .AddWithValue("@prr_QCTagpts0500val", "")
                    .AddWithValue("@prr_QCTagpts0600val", "")
                    .AddWithValue("@prr_QCScratch0700", "")
                    .AddWithValue("@prr_QCScratch0800", "")
                    .AddWithValue("@prr_QCScratch0900", "")
                    .AddWithValue("@prr_QCScratch1000", "")
                    .AddWithValue("@prr_QCScratch1100", "")
                    .AddWithValue("@prr_QCScratch1200", "")
                    .AddWithValue("@prr_QCScratch0100", "")
                    .AddWithValue("@prr_QCScratch0200", "")
                    .AddWithValue("@prr_QCScratch0300", "")
                    .AddWithValue("@prr_QCScratch0400", "")
                    .AddWithValue("@prr_QCScratch0500", "")
                    .AddWithValue("@prr_QCScratch0600", "")
                    .AddWithValue("@prr_QCScratch0700val", "")
                    .AddWithValue("@prr_QCScratch0800val", "")
                    .AddWithValue("@prr_QCScratch0900val", "")
                    .AddWithValue("@prr_QCScratch1000val", "")
                    .AddWithValue("@prr_QCScratch1100val", "")
                    .AddWithValue("@prr_QCScratch1200val", "")
                    .AddWithValue("@prr_QCScratch0100val", "")
                    .AddWithValue("@prr_QCScratch0200val", "")
                    .AddWithValue("@prr_QCScratch0300val", "")
                    .AddWithValue("@prr_QCScratch0400val", "")
                    .AddWithValue("@prr_QCScratch0500val", "")
                    .AddWithValue("@prr_QCScratch0600val", "")
                    .AddWithValue("@prr_QCCrump0700", "")
                    .AddWithValue("@prr_QCCrump0800", "")
                    .AddWithValue("@prr_QCCrump0900", "")
                    .AddWithValue("@prr_QCCrump1000", "")
                    .AddWithValue("@prr_QCCrump1100", "")
                    .AddWithValue("@prr_QCCrump1200", "")
                    .AddWithValue("@prr_QCCrump0100", "")
                    .AddWithValue("@prr_QCCrump0200", "")
                    .AddWithValue("@prr_QCCrump0300", "")
                    .AddWithValue("@prr_QCCrump0400", "")
                    .AddWithValue("@prr_QCCrump0500", "")
                    .AddWithValue("@prr_QCCrump0600", "")
                    .AddWithValue("@prr_QCCrump0700val", "")
                    .AddWithValue("@prr_QCCrump0800val", "")
                    .AddWithValue("@prr_QCCrump0900val", "")
                    .AddWithValue("@prr_QCCrump1000val", "")
                    .AddWithValue("@prr_QCCrump1100val", "")
                    .AddWithValue("@prr_QCCrump1200val", "")
                    .AddWithValue("@prr_QCCrump0100val", "")
                    .AddWithValue("@prr_QCCrump0200val", "")
                    .AddWithValue("@prr_QCCrump0300val", "")
                    .AddWithValue("@prr_QCCrump0400val", "")
                    .AddWithValue("@prr_QCCrump0500val", "")
                    .AddWithValue("@prr_QCCrump0600val", "")



                End With
                cmd.ExecuteNonQuery()
                con.Close()



            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try







        End If
        dr.Close()
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



        MsgBox("Successfully saved!")




    End Sub

    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click
        Dim selectedtagpoints As String = ""
        Dim selectedScratches As String = ""
        Dim selectedCrupied As String = ""




        If RBT_TagPointsCheck.Checked Then
            selectedtagpoints = "O"
        ElseIf RBT_TagPointsX.Checked Then
            selectedtagpoints = "X"
        ElseIf RBT_TagPointsNA.Checked Then
            selectedtagpoints = "N"
        End If




        If RBT_ScratchesCheck.Checked Then
            selectedScratches = "O"
        ElseIf RBT_ScratchesX.Checked Then
            selectedScratches = "X"
        ElseIf RBT_ScratchesNA.Checked Then
            selectedScratches = "N"
        End If




        If RBT_CrupiedChek.Checked Then
            selectedCrupied = "O"
        ElseIf RBT_CrupiedX.Checked Then
            selectedCrupied = "X"
        ElseIf RBT_CrupiedNA.Checked Then
            selectedCrupied = "N"
        End If



        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_QCM WHERE Site = @site  And mcnum  = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()


        If dr.HasRows Then
            dr.Close()
            con.Close()


            OpenConnection()

            cmd.CommandText = "
                                SELECT time
                                FROM [dbo].[timemaintenance]
                                WHERE 
                                    (time NOT LIKE '%30%' OR time = '0300')
                                    AND time BETWEEN @FromTime AND @ToTime
                                ORDER BY time ASC"
            cmd.CommandType = CommandType.Text

            'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE (time NOT LIKE '%30%' OR time = '0300')AND ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "
            'cmd.CommandType = CommandType.Text

            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance] WHERE time >= @FromTime Or time <= @ToTime"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FromTime", CBO_FromTime.Text)
            cmd.Parameters.AddWithValue("@ToTime", ComboBox1.Text)
            dr = cmd.ExecuteReader()

            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime And @ToTime order by time ASC"

            If dr.HasRows Then

                Dim times As New List(Of String)
                While dr.Read()
                    times.Add(dr("time").ToString())
                End While
                dr.Close()

                For Each vartime As String In times

                    cmd.CommandText = $"UPDATE sppmcPRR_QCM 
                           SET prr_QCTagpts{vartime} = @prr_QCTagpts, 
                               prr_QCTagpts{vartime}val = @prr_QCTagptsval, 
                               prr_QCScratch{vartime} = @prr_QCScratch, 
                               prr_QCScratch{vartime}val = @prr_QCScratchval, 
                               prr_QCCrump{vartime} = @prr_QCCrump, 
                               prr_QCCrump{vartime}val = @prr_QCCrumpval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_QCTagpts", selectedtagpoints)
                        .AddWithValue("@prr_QCTagptsval", TXT_TagPoints.Text)
                        .AddWithValue("@prr_QCScratch", selectedScratches)
                        .AddWithValue("@prr_QCScratchval", TXT_Scratches.Text)
                        .AddWithValue("@prr_QCCrump", selectedCrupied)
                        .AddWithValue("@prr_QCCrumpval", TXT_Crupied.Text)

                    End With
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                MsgBox("Successfully updated!")
            End If


        Else
            dr.Close()
            con.Close()





            OpenConnection()

            cmd.CommandText = "INSERT INTO sppmcPRR_QCM (Site, mcnum) VALUES (@Site, @mcnum)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            OpenConnection()

            cmd.CommandText = "
                                SELECT time
                                FROM [dbo].[timemaintenance]
                                WHERE 
                                    (time NOT LIKE '%30%' OR time = '0300')
                                    AND time BETWEEN @FromTime AND @ToTime
                                ORDER BY time ASC"
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance] WHERE time >= @FromTime Or time <= @ToTime"
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


                    cmd.CommandText = $"UPDATE sppmcPRR_QCM 
                           SET prr_QCTagpts{vartime} = @prr_QCTagpts, 
                               prr_QCTagpts{vartime}val = @prr_QCTagptsval, 
                               prr_QCScratch{vartime} = @prr_QCScratch, 
                               prr_QCScratch{vartime}val = @prr_QCScratchval, 
                               prr_QCCrump{vartime} = @prr_QCCrump, 
                               prr_QCCrump{vartime}val = @prr_QCCrumpval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_QCTagpts", selectedtagpoints)
                        .AddWithValue("@prr_QCTagptsval", TXT_TagPoints.Text)
                        .AddWithValue("@prr_QCScratch", selectedScratches)
                        .AddWithValue("@prr_QCScratchval", TXT_Scratches.Text)
                        .AddWithValue("@prr_QCCrump", selectedCrupied)
                        .AddWithValue("@prr_QCCrumpval", TXT_Crupied.Text)

                    End With
                    cmd.ExecuteNonQuery()
                Next
                con.Close()

                MsgBox("successfully saved!")
            End If
        End If
        con.Close()

        'Update to header
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






    End Sub

    Private Sub FRM_AddProductionRunQCMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcPRR_QCM"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@Site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With

            ' Execute the reader
            dr = cmd.ExecuteReader()

            ' Check if there are rows before accessing the data
            If dr.HasRows Then
                If dr.Read() Then ' Use While to read all rows if needed


                    If dr("prr_QCAlign070809").ToString() = "O" Then
                        RBT_Alignment7to9AMCheck.Checked = True
                    ElseIf dr("prr_QCFdrGa070809").ToString() = "X"
                        RBT_Alignment7to9AMX.Checked = True
                    Else
                        RBT_Alignment7to9AMNA.Checked = True
                    End If


                    If dr("prr_QCAlign101112").ToString() = "O" Then
                        RBT_Alignment10to12PMCheck.Checked = True
                    ElseIf dr("prr_QCAlign101112").ToString() = "X"
                        RBT_Alignment10to12PMX.Checked = True
                    Else
                        RBT_Alignment10to12PMNA.Checked = True
                    End If



                    If dr("prr_QCAlign010203").ToString() = "O" Then
                        RBT_Alignment1to3PMCheck.Checked = True
                    ElseIf dr("prr_QCAlign101112").ToString() = "X"
                        RBT_Alignment1to3PMX.Checked = True
                    Else
                        RBT_Alignment1to3PMNA.Checked = True
                    End If


                    If dr("prr_QCAlign040506").ToString() = "O" Then
                        RBT_Alignment4to6PMCheck.Checked = True
                    ElseIf dr("prr_QCAlign101112").ToString() = "X"
                        RBT_Alignment4to6PMX.Checked = True
                    Else
                        RBT_Alignment4to6PMNA.Checked = True
                    End If


                    If dr("prr_QCFdrGa070809").ToString() = "O" Then
                        RBT_Feeder7to9AMCheck.Checked = True
                    ElseIf dr("prr_QCFdrGa070809").ToString() = "X"
                        RBT_Feeder7to9AMX.Checked = True
                    Else
                        RBT_Feeder7to9AMNA.Checked = True
                    End If



                    If dr("prr_QCFdrGa101112").ToString() = "O" Then
                        RBT_Feeder10to12PMCheck.Checked = True
                    ElseIf dr("prr_QCFdrGa101112").ToString() = "X"
                        RBT_Feeder10to12PMX.Checked = True
                    Else
                        RBT_Feeder10to12PMNA.Checked = True
                    End If




                    If dr("prr_QCFdrGa010203").ToString() = "O" Then
                        RBT_Feeder1to3PMCheck.Checked = True
                    ElseIf dr("prr_QCFdrGa010203").ToString() = "X"
                        RBT_Feeder1to3PMX.Checked = True
                    Else
                        RBT_Feeder1to3PMNA.Checked = True
                    End If



                    If dr("prr_QCFdrGa040506").ToString() = "O" Then
                        RBT_Feeder4to6PMCheck.Checked = True
                    ElseIf dr("prr_QCFdrGa040506").ToString() = "X"
                        RBT_Feeder4to6PMX.Checked = True
                    Else
                        RBT_Feeder4to6PMNA.Checked = True
                    End If













                    TXT_ResNo.Text = dr("prr_RESNum").ToString()
                    TXT_SasNo.Text = dr("prr_SASNum").ToString()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the reader and the connection in the Finally block
            If Not dr Is Nothing Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub RBT_TagPointsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TagPointsCheck.CheckedChanged
        TXT_TagPoints.Enabled = False
        TXT_TagPoints.Text = ""
    End Sub

    Private Sub RBT_TagPointsX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TagPointsX.CheckedChanged
        TXT_TagPoints.Enabled = True

    End Sub

    Private Sub RBT_TagPointsNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TagPointsNA.CheckedChanged
        TXT_TagPoints.Enabled = False
        TXT_TagPoints.Text = ""
    End Sub


    Private Sub RBT_ScratchesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_ScratchesCheck.CheckedChanged
        TXT_Scratches.Enabled = False
        TXT_Scratches.Text = ""
    End Sub

    Private Sub RBT_ScratchesX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_ScratchesX.CheckedChanged
        TXT_Scratches.Enabled = True
    End Sub

    Private Sub RBT_ScratchesNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_ScratchesNA.CheckedChanged
        TXT_Scratches.Enabled = False
        TXT_Scratches.Text = ""
    End Sub


    Private Sub RBT_CrupiedChek_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrupiedChek.CheckedChanged

        TXT_Crupied.Enabled = False
        TXT_Crupied.Text = ""

    End Sub

    Private Sub RBT_CrupiedX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrupiedX.CheckedChanged
        TXT_Crupied.Enabled = True
    End Sub

    Private Sub RBT_CrupiedNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrupiedNA.CheckedChanged
        TXT_Crupied.Enabled = False
        TXT_Crupied.Text = ""
    End Sub




    Private Sub TXT_TagPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TagPoints.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Scratches_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Scratches.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Crupied_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Crupied.KeyPress
        NumberOnly(e)
    End Sub
End Class