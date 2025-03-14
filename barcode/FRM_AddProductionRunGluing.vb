Public Class FRM_AddProductionRunGluing
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub FRM_AddProductionRunGluing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcPRR_GLU"
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
                While dr.Read() ' Use While to read all rows if needed

                    If dr("prr_GLFdrGS070809").ToString() = "O" Then
                        RBT_FeederGaugeSet7to9AMCheck.Checked = True
                    ElseIf dr("prr_GLFdrGS070809").ToString() = "X"
                        RBT_FeederGaugeSet7to9AMX.Checked = True
                    Else
                        RBT_FeederGaugeSet7to9AMNA.Checked = True
                    End If



                    If dr("prr_GLFdrGS101112").ToString() = "O" Then
                        RBT_FeederGaugeSet10to12PMCheck.Checked = True
                    ElseIf dr("prr_GLFdrGS101112").ToString() = "X"
                        RBT_FeederGaugeSet10to12PMX.Checked = True
                    Else
                        RBT_FeederGaugeSet10to12PMNA.Checked = True
                    End If




                    If dr("prr_GLFdrGS010203").ToString() = "O" Then
                        RBT_FeederGaugeSet1to3PMCheck.Checked = True
                    ElseIf dr("prr_GLFdrGS010203").ToString() = "X"
                        RBT_FeederGaugeSet1to3PMX.Checked = True
                    Else
                        RBT_FeederGaugeSet1to3PMNA.Checked = True
                    End If


                    If dr("prr_GLFdrGS040506").ToString() = "O" Then
                        RBT_FeederGaugeSet4to6PMCheck.Checked = True
                    ElseIf dr("prr_GLFdrGS040506").ToString() = "X"
                        RBT_FeederGaugeSet4to6PMX.Checked = True
                    Else
                        RBT_FeederGaugeSet4to6PMNA.Checked = True
                    End If







                    TXT_ResNo.Text = dr("prr_RESNum").ToString()
                    TXT_SasNo.Text = dr("prr_SASNum").ToString()
                End While
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

    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click
        Dim selectedFlywheelPressure As String = ""

        If RBT_FlywheelPressureCheck.Checked Then
            selectedFlywheelPressure = "O"
        ElseIf RBT_FlywheelPressureX.Checked Then
            selectedFlywheelPressure = "X"
        ElseIf RBT_FlywheelPressureNA.Checked Then
            selectedFlywheelPressure = "N"
        End If



        Dim selectedGlueTank As String = ""

        If RBT_GlueTankCheck.Checked Then
            selectedGlueTank = "O"
        ElseIf RBT_GlueTankX.Checked Then
            selectedGlueTank = "X"
        ElseIf RBT_GlueTankNA.Checked Then
            selectedGlueTank = "N"
        End If




        Dim selectedGlueBottled As String = ""

        If RBT_GlueBottleCheck.Checked Then
            selectedGlueBottled = "O"
        ElseIf RBT_GlueBottleX.Checked Then
            selectedGlueBottled = "X"
        ElseIf RBT_GlueBottleNA.Checked Then
            selectedGlueBottled = "N"
        End If



        Dim selectedShippingCase As String = ""

        If RBT_ShippingCaseCheck.Checked Then
            selectedShippingCase = "O"
        ElseIf RBT_ShippingCaseX.Checked Then
            selectedShippingCase = "X"
        ElseIf RBT_ShippingCaseNA.Checked Then
            selectedShippingCase = "N"
        End If



        Dim selectedExcessWeak As String = ""

        If RBT_ExcessWeakCheck.Checked Then
            selectedExcessWeak = "O"
        ElseIf RBT_ExcessWeakX.Checked Then
            selectedExcessWeak = "X"
        ElseIf RBT_ExcessWeakNA.Checked Then
            selectedExcessWeak = "N"
        End If



        Dim selectedCrumpledScratches As String = ""

        If RBT_CrumpledScratchesCheck.Checked Then
            selectedCrumpledScratches = "O"
        ElseIf RBT_CrumpledScratchesX.Checked Then
            selectedCrumpledScratches = "X"
        ElseIf RBT_CrumpledScratchesNA.Checked Then
            selectedCrumpledScratches = "N"
        End If



        Dim selectedOverlappingBox As String = ""

        If RBT_OverlappingBoxCheck.Checked Then
            selectedOverlappingBox = "O"
        ElseIf RBT_OverlappingBoxX.Checked Then
            selectedOverlappingBox = "X"
        ElseIf RBT_OverlappingBoxNA.Checked Then
            selectedOverlappingBox = "N"
        End If





        Dim selectedIncorrectCount As String = ""

        If RBT_IncorrectCountCheck.Checked Then
            selectedIncorrectCount = "O"
        ElseIf RBT_IncorrectCountX.Checked Then
            selectedIncorrectCount = "X"
        ElseIf RBT_IncorrectCountNA.Checked Then
            selectedIncorrectCount = "N"
        End If


        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_GLU WHERE Site = @site  And mcnum  = @mcnum"
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

                    cmd.CommandText = $"UPDATE sppmcPRR_GLU 
                           SET prr_GLFlywh{vartime} = @prr_GLFlywh,
                               prr_GLGluTnk{vartime} = @prr_GLGluTnk, 
                               prr_GLGluBotld{vartime} = @prr_GLGluBotld, 
                               prr_GLShiCa{vartime} = @prr_GLShiCa,  
                               prr_GLExWkGl{vartime} = @prr_GLExWkGl, 
                               prr_GLExWkGl{vartime}val = @prr_GLExWkGlval, 
                               prr_GLCrumSc{vartime} = @prr_GLCrumSc, 
                               prr_GLCrumSc{vartime}val = @prr_GLCrumScval,
                               prr_GLOvrlap{vartime} = @prr_GLOvrlap, 
                               prr_GLOvrlap{vartime}val = @prr_GLOvrlapval, 
                               prr_GLIncCnt{vartime} = @prr_GLIncCnt, 
                               prr_GLIncCnt{vartime}val = @prr_GLIncCntval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        .AddWithValue("@prr_GLFlywh", selectedFlywheelPressure)
                        .AddWithValue("@prr_GLGluTnk", selectedGlueTank)
                        .AddWithValue("@prr_GLGluBotld", selectedGlueBottled)
                        .AddWithValue("@prr_GLShiCa", selectedShippingCase)

                        .AddWithValue("@prr_GLExWkGl", selectedExcessWeak)
                        .AddWithValue("@prr_GLExWkGlval", TXT_ExcessWeak.Text)
                        .AddWithValue("@prr_GLCrumSc", selectedCrumpledScratches)
                        .AddWithValue("@prr_GLCrumScval", TXT_CrumpledScratches.Text)
                        .AddWithValue("@prr_GLOvrlap", selectedOverlappingBox)
                        .AddWithValue("@prr_GLOvrlapval", TXT_OverlappingBox.Text)
                        .AddWithValue("@prr_GLIncCnt", selectedIncorrectCount)
                        .AddWithValue("@prr_GLIncCntval", TXT_IncorrectCount.Text)

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

            cmd.CommandText = "INSERT INTO sppmcPRR_GLU (Site, mcnum) VALUES (@Site, @mcnum)"
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

                    cmd.CommandText = $"UPDATE sppmcPRR_GLU 
                           SET prr_GLFlywh{vartime} = @prr_GLFlywh,
                               prr_GLGluTnk{vartime} = @prr_GLGluTnk, 
                               prr_GLGluBotld{vartime} = @prr_GLGluBotld, 
                               prr_GLShiCa{vartime} = @prr_GLShiCa,  
                  
                               prr_GLExWkGl{vartime} = @prr_GLExWkGl, 
                               prr_GLExWkGl{vartime}val = @prr_GLExWkGlval, 
                               prr_GLCrumSc{vartime} = @prr_GLCrumSc, 
                               prr_GLCrumSc{vartime}val = @prr_GLCrumScval,
                               prr_GLOvrlap{vartime} = @prr_GLOvrlap, 
                               prr_GLOvrlap{vartime}val = @prr_GLOvrlapval, 
                               prr_GLIncCnt{vartime} = @prr_GLIncCnt, 
                               prr_GLIncCnt{vartime}val = @prr_GLIncCntval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        .AddWithValue("@prr_GLFlywh", selectedFlywheelPressure)
                        .AddWithValue("@prr_GLGluTnk", selectedGlueTank)
                        .AddWithValue("@prr_GLGluBotld", selectedGlueBottled)
                        .AddWithValue("@prr_GLShiCa", selectedShippingCase)

                        .AddWithValue("@prr_GLExWkGl", selectedExcessWeak)
                        .AddWithValue("@prr_GLExWkGlval", TXT_ExcessWeak.Text)
                        .AddWithValue("@prr_GLCrumSc", selectedCrumpledScratches)
                        .AddWithValue("@prr_GLCrumScval", TXT_CrumpledScratches.Text)
                        .AddWithValue("@prr_GLOvrlap", selectedOverlappingBox)
                        .AddWithValue("@prr_GLOvrlapval", TXT_OverlappingBox.Text)
                        .AddWithValue("@prr_GLIncCnt", selectedIncorrectCount)
                        .AddWithValue("@prr_GLIncCntval", TXT_IncorrectCount.Text)

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

    Private Sub BTN_SaveProcessMonitoring_Click(sender As Object, e As EventArgs) Handles BTN_SaveProcessMonitoring.Click

        Dim selectedFeederGaugeSet7to9AM As String = ""
        Dim selectedFeederGaugeSet10to12PM As String = ""
        Dim selectedFeederGaugeSet1to3PM As String = ""

        Dim selectedFeederGaugeSet4to6PM As String = ""


        If RBT_FeederGaugeSet7to9AMCheck.Checked Then
            selectedFeederGaugeSet7to9AM = "O"
        ElseIf RBT_FeederGaugeSet7to9AMX.Checked Then
            selectedFeederGaugeSet7to9AM = "X"
        ElseIf RBT_FeederGaugeSet7to9AMNA.Checked Then
            selectedFeederGaugeSet7to9AM = "N"
        End If


        If RBT_FeederGaugeSet10to12PMCheck.Checked Then
            selectedFeederGaugeSet10to12PM = "O"
        ElseIf RBT_FeederGaugeSet10to12PMX.Checked Then
            selectedFeederGaugeSet10to12PM = "X"
        ElseIf RBT_FeederGaugeSet10to12PMNA.Checked Then
            selectedFeederGaugeSet10to12PM = "N"
        End If


        If RBT_FeederGaugeSet1to3PMCheck.Checked Then
            selectedFeederGaugeSet1to3PM = "O"
        ElseIf RBT_FeederGaugeSet1to3PMX.Checked Then
            selectedFeederGaugeSet1to3PM = "X"
        ElseIf RBT_FeederGaugeSet1to3PMNA.Checked Then
            selectedFeederGaugeSet1to3PM = "N"
        End If

        If RBT_FeederGaugeSet4to6PMCheck.Checked Then
            selectedFeederGaugeSet4to6PM = "O"
        ElseIf RBT_FeederGaugeSet4to6PMX.Checked Then
            selectedFeederGaugeSet4to6PM = "X"
        ElseIf RBT_FeederGaugeSet4to6PMNA.Checked Then
            selectedFeederGaugeSet4to6PM = "N"
        End If


        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_GLU WHERE Site = @site  And mcnum  = @mcnum"
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
                cmd.CommandText = "UPDATE sppmcPRR_GLU SET " +
                                    "prr_GLFdrGS070809 = @prr_GLFdrGS070809, " +
                                    "prr_GLFdrGS101112 = @prr_GLFdrGS101112, " +
                                    "prr_GLFdrGS010203 = @prr_GLFdrGS010203, " +
                                    "prr_GLFdrGS040506 = @prr_GLFdrGS040506, " +
                                    "prr_RESNum = @prr_RESNum, " +
                                    "prr_SASNum = @prr_SASNum " +
                                    "WHERE Site = @Site AND mcnum = @mcnum"

                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()

                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_GLFdrGS070809", selectedFeederGaugeSet7to9AM)
                    .AddWithValue("@prr_GLFdrGS101112", selectedFeederGaugeSet10to12PM)
                    .AddWithValue("@prr_GLFdrGS010203", selectedFeederGaugeSet1to3PM)
                    .AddWithValue("@prr_GLFdrGS040506", selectedFeederGaugeSet4to6PM)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)
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
                cmd.CommandText = "INSERT INTO sppmcPRR_GLU (Site, mcnum, prr_GLFdrGS070809, prr_GLFdrGS101112, prr_GLFdrGS010203, prr_GLFdrGS040506, prr_RESNum, prr_SASNum) VALUES  (@Site, @mcnum, @prr_GLFdrGS070809, @prr_GLFdrGS101112, @prr_GLFdrGS010203, @prr_GLFdrGS040506, @prr_RESNum, @prr_SASNum)"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_GLFdrGS070809", selectedFeederGaugeSet7to9AM)
                    .AddWithValue("@prr_GLFdrGS101112", selectedFeederGaugeSet10to12PM)
                    .AddWithValue("@prr_GLFdrGS010203", selectedFeederGaugeSet1to3PM)
                    .AddWithValue("@prr_GLFdrGS040506", selectedFeederGaugeSet4to6PM)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)

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

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()

        Dim i As Integer
        For i = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        Dim UC_OperatorGluing As New UC_OperatorGluing
        UC_OperatorGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorGluing.Show()
        UC_OperatorGluing.Dock = DockStyle.Fill

    End Sub

    Private Sub RBT_ExcessWeakCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_ExcessWeakCheck.CheckedChanged
        TXT_ExcessWeak.Enabled = False
        TXT_ExcessWeak.Text = ""
    End Sub

    Private Sub RBT_ExcessWeakX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_ExcessWeakX.CheckedChanged
        TXT_ExcessWeak.Enabled = True

    End Sub

    Private Sub RBT_ExcessWeakNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_ExcessWeakNA.CheckedChanged
        TXT_ExcessWeak.Enabled = False
        TXT_ExcessWeak.Text = ""
    End Sub


    Private Sub RBT_CrumpledScratchesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrumpledScratchesCheck.CheckedChanged
        TXT_CrumpledScratches.Enabled = False
        TXT_CrumpledScratches.Text = ""
    End Sub

    Private Sub RBT_CrumpledScratchesX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrumpledScratchesX.CheckedChanged
        TXT_CrumpledScratches.Enabled = True


    End Sub

    Private Sub RBT_CrumpledScratchesNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrumpledScratchesNA.CheckedChanged
        TXT_CrumpledScratches.Enabled = False
        TXT_CrumpledScratches.Text = ""
    End Sub



    Private Sub RBT_OverlappingBoxCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OverlappingBoxCheck.CheckedChanged
        TXT_OverlappingBox.Enabled = False
        TXT_OverlappingBox.Text = ""
    End Sub


    Private Sub RBT_OverlappingBoxX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OverlappingBoxX.CheckedChanged
        TXT_OverlappingBox.Enabled = True

    End Sub

    Private Sub RBT_OverlappingBoxNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OverlappingBoxNA.CheckedChanged
        TXT_OverlappingBox.Enabled = False
        TXT_OverlappingBox.Text = ""
    End Sub


    Private Sub RBT_IncorrectCountCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectCountCheck.CheckedChanged
        TXT_IncorrectCount.Enabled = False
        TXT_IncorrectCount.Text = ""
    End Sub

    Private Sub RBT_IncorrectCountX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectCountX.CheckedChanged
        TXT_IncorrectCount.Enabled = True

    End Sub

    Private Sub RBT_IncorrectCountNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectCountNA.CheckedChanged
        TXT_IncorrectCount.Enabled = False
        TXT_IncorrectCount.Text = ""
    End Sub




    Private Sub TXT_ExcessWeak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ExcessWeak.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_CrumpledScratches_TextChanged(sender As Object, e As EventArgs) Handles TXT_CrumpledScratches.TextChanged

    End Sub

    Private Sub TXT_CrumpledScratches_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CrumpledScratches.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_OverlappingBox_TextChanged(sender As Object, e As EventArgs) Handles TXT_OverlappingBox.TextChanged

    End Sub

    Private Sub TXT_OverlappingBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_OverlappingBox.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_IncorrectCount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_IncorrectCount.KeyPress
        NumberOnly(e)
    End Sub



End Class