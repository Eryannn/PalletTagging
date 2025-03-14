Imports System.Data.SqlClient

Public Class FRM_AddProductionRun
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub





    Private Sub RBT_LooseFiberFCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_LooseFiberFCheck.CheckedChanged
        TXT_LooseFiberQty.Enabled = False
        TXT_LooseFiberQty.Text = ""

    End Sub

    Private Sub RBT_LooseFiberFX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_LooseFiberFX.CheckedChanged
        TXT_LooseFiberQty.Enabled = True

    End Sub

    Private Sub RBT_LooseFiberNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_LooseFiberNa.CheckedChanged
        TXT_LooseFiberQty.Enabled = False
        TXT_LooseFiberQty.Text = ""
    End Sub


    Private Sub RBT_OffSquareCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffSquareCheck.CheckedChanged
        TXT_OffSquareQty.Enabled = False
        TXT_OffSquareQty.Text = ""
    End Sub

    Private Sub RBT_OffSquareX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffSquareX.CheckedChanged
        TXT_OffSquareQty.Enabled = True

    End Sub

    Private Sub RBT_OffSquareNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffSquareNa.CheckedChanged
        TXT_OffSquareQty.Enabled = False
        TXT_OffSquareQty.Text = ""

    End Sub

    Private Sub RBT_IncorrectDimensionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectDimensionCheck.CheckedChanged
        TXT_IncorrectDimensionQty.Enabled = False
        TXT_IncorrectDimensionQty.Text = ""
    End Sub

    Private Sub RBT_IncorrectDimensionX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectDimensionX.CheckedChanged
        TXT_IncorrectDimensionQty.Enabled = True

    End Sub

    Private Sub RBT_IncorrectDimensionNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectDimensionNa.CheckedChanged
        TXT_IncorrectDimensionQty.Enabled = False
        TXT_IncorrectDimensionQty.Text = ""
    End Sub

    Private Sub RBT_TearOffCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TearOffCheck.CheckedChanged
        TXT_TearOffQTY.Enabled = False
        TXT_TearOffQTY.Text = ""

    End Sub

    Private Sub RBT_TearOffX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TearOffX.CheckedChanged
        TXT_TearOffQTY.Enabled = True


    End Sub

    Private Sub RBT_TearOffNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TearOffNa.CheckedChanged
        TXT_TearOffQTY.Enabled = False
        TXT_TearOffQTY.Text = ""
    End Sub

    Private Sub RBT_IncorrectGrainDirectionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectGrainDirectionCheck.CheckedChanged
        TXT_IncorrectGrainDirectionQty.Enabled = False
        TXT_IncorrectGrainDirectionQty.Text = ""



    End Sub

    Private Sub RBT_IncorrectGrainDirectionX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectGrainDirectionX.CheckedChanged
        TXT_IncorrectGrainDirectionQty.Enabled = True
    End Sub


    Private Sub RBT_IncorrectGrainDirectionNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_IncorrectGrainDirectionNa.CheckedChanged
        TXT_IncorrectGrainDirectionQty.Enabled = False
        TXT_IncorrectGrainDirectionQty.Text = ""
    End Sub

    'Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click
    '    Dim Site As String = "PI"
    '    Dim selectedCuttingBladeShrp As String = ""
    '    Dim selectedCuttingBladeCon As String = ""
    '    Dim selectedLooseFiber As String = ""
    '    Dim selectedOffSquare As String = ""
    '    Dim selectedIncorDimen As String = ""
    '    Dim selectedTearOff As String = ""
    '    Dim selectedIncorGrain As String = ""


    '    'Radio button for Cutting Blade Shrp
    '    If RBT_CuttingBladeSharpCheck.Checked Then
    '        selectedCuttingBladeShrp = "O"
    '    ElseIf RBT_LooseFiberFX.Checked Then
    '        selectedCuttingBladeShrp = "X"
    '    ElseIf RBT_LooseFiberNa.Checked Then
    '        selectedCuttingBladeShrp = "N"
    '    End If



    '    'Radio button for Cutting Blade Con
    '    If RBT_CuttingBladeConditionCheck.Checked Then
    '        selectedCuttingBladeCon = "O"
    '    ElseIf RBT_LooseFiberFX.Checked Then
    '        selectedCuttingBladeCon = "X"
    '    ElseIf RBT_LooseFiberNa.Checked Then
    '        selectedCuttingBladeCon = "N"
    '    End If




    '    'Radio button for Loose Fiber
    '    If RBT_LooseFiberFCheck.Checked Then
    '        selectedLooseFiber = "O"
    '    ElseIf RBT_LooseFiberFX.Checked Then
    '        selectedLooseFiber = "X"
    '    ElseIf RBT_LooseFiberNa.Checked Then
    '        selectedLooseFiber = "N"
    '    End If


    '    'Radio button for OffSquare
    '    If RBT_OffSquareCheck.Checked Then
    '        selectedOffSquare = "O"
    '    ElseIf RBT_OffSquareX.Checked Then
    '        selectedOffSquare = "X"
    '    ElseIf RBT_TearOffNa.Checked Then
    '        selectedOffSquare = "N"
    '    End If


    '    'Radio button for Incorporation Dimen
    '    If RBT_IncorrectDimensionCheck.Checked Then
    '        selectedIncorDimen = "O"
    '    ElseIf RBT_IncorrectDimensionX.Checked Then
    '        selectedIncorDimen = "X"
    '    ElseIf RBT_IncorrectDimensionNa.Checked Then
    '        selectedIncorDimen = "N"
    '    End If

    '    'Radio button for Tear Off
    '    If RBT_TearOffCheck.Checked Then
    '        selectedTearOff = "O"
    '    ElseIf RBT_TearOffX.Checked Then
    '        selectedTearOff = "X"
    '    ElseIf RBT_TearOffNa.Checked Then
    '        selectedTearOff = "N"
    '    End If





    '    'Radio button for Incor Grain
    '    If RBT_IncorrectGrainDirectionCheck.Checked Then
    '        selectedIncorGrain = "O"
    '    ElseIf RBT_IncorrectGrainDirectionX.Checked Then
    '        selectedIncorGrain = "X"
    '    ElseIf RBT_IncorrectGrainDirectionNa.Checked Then
    '        selectedIncorGrain = "N"
    '    End If





    '    If CBO_FromTime.Text = "07:00" Then
    '        OpenConnection()
    '        cmd.CommandText = "INSERT INTO sppmcPRR_CUT 
    '                           (Site, mcnum, prr_resnum, prr_sasnum, prr_CUbladeshrp0700, prr_CUbladecond0700, prr_CULosefibr0700, prr_CULosefibr0700val,  prr_CUOffsquare0700, prr_CUOffsquare0700val, prr_CUIncordimen0700,prr_CUIncordimen0700val, prr_CUTearoff0700, prr_CUTearoff0700val, prr_CUIncorGrainDir0700, prr_CUIncorGrainDir0700val)
    '                           VALUES (@Site, @mcnum, @prr_resnum, @prr_sasnum, @prr_CUbladeshrp0700, @prr_CUbladecond0700, @prr_CULosefibr0700, @prr_CULosefibr0700val, @prr_CUOffsquare0700, @prr_CUOffsquare0700val,  @prr_CUIncordimen0700, @prr_CUIncordimen0700val, @prr_CUTearoff0700, @prr_CUTearoff0700val, @prr_CUIncorGrainDir0700, @prr_CUIncorGrainDir0700val)"

    '        With cmd.Parameters
    '            .Clear()
    '            .AddWithValue("@Site", Site) ' Change as needed
    '            .AddWithValue("@mcnum", TXT_DummyMCNo.Text) ' Change as needed
    '            .AddWithValue("@prr_resnum", TXT_DummyResNo.Text) ' Change as needed
    '            .AddWithValue("@prr_sasnum", TXT_DummySasNo.Text) ' Change as needed


    '            ' For "7:00" values
    '            .AddWithValue("@prr_CUbladeshrp0700", selectedCuttingBladeShrp) ' Change as needed
    '            .AddWithValue("@prr_CUbladecond0700", selectedCuttingBladeCon) ' Change as needed
    '            .AddWithValue("@prr_CULosefibr0700", selectedLooseFiber) ' Change as needed
    '            .AddWithValue("@prr_CULosefibr0700val", TXT_LooseFiberQty.Text) ' Change as needed
    '            .AddWithValue("@prr_CUOffsquare0700", selectedOffSquare) ' Change as needed
    '            .AddWithValue("@prr_CUOffsquare0700val", TXT_OffSquareQty.Text) ' Change as needed
    '            .AddWithValue("@prr_CUIncordimen0700", selectedIncorDimen) ' Change as needed
    '            .AddWithValue("@prr_CUIncordimen0700val", TXT_IncorrectDimensionQty.Text) ' Change as needed
    '            .AddWithValue("@prr_CUTearoff0700", selectedTearOff) ' Change as needed
    '            .AddWithValue("@prr_CUTearoff0700val", TXT_TearOffQTY.Text) ' Change as needed
    '            .AddWithValue("@prr_CUIncorGrainDir0700", selectedIncorGrain) ' Change as needed
    '            .AddWithValue("@prr_CUIncorGrainDir0700val", TXT_IncorrectGrainDirectionNaQty.Text) ' Change as needed
    '            ' Execute the insert command


    '        End With
    '        cmd.ExecuteNonQuery()


    '        MessageBox.Show("Success", "My Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        con.Close()

    '        FRM_MonitoringChecklistMain.Show()
    '        Me.Close()
    '    Else
    '        MessageBox.Show("Error", "My Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    End If
    'End Sub


    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click




        Dim Site As String = Form1.cmb_site.Text
        Dim selectedCuttingBladeShrp As String = ""
        Dim selectedCuttingBladeCon As String = ""
        Dim selectedLooseFiber As String = ""
        Dim selectedOffSquare As String = ""
        Dim selectedIncorDimen As String = ""
        Dim selectedTearOff As String = ""
        Dim selectedIncorGrain As String = ""
        Dim fromTime As String = CBO_FromTime.Text

        ' Assign values based on radio buttons
        ' (This part remains unchanged from your original code)
        If RBT_CuttingBladeSharpCheck.Checked Then
            selectedCuttingBladeShrp = "O"
        ElseIf RBT_CuttingBladeSharpX.Checked Then
            selectedCuttingBladeShrp = "X"
        ElseIf RBT_CuttingBladeSharpNa.Checked Then
            selectedCuttingBladeShrp = "N"
        End If

        If RBT_CuttingBladeConditionCheck.Checked Then
            selectedCuttingBladeCon = "O"
        ElseIf RBT_CuttingBladeConditionX.Checked Then
            selectedCuttingBladeCon = "X"
        ElseIf RBT_CuttingBladeConditionNa.Checked Then
            selectedCuttingBladeCon = "N"
        End If

        If RBT_LooseFiberFCheck.Checked Then
            selectedLooseFiber = "O"
        ElseIf RBT_LooseFiberFX.Checked Then
            selectedLooseFiber = "X"
        ElseIf RBT_LooseFiberNa.Checked Then
            selectedLooseFiber = "N"
        End If

        If RBT_OffSquareCheck.Checked Then
            selectedOffSquare = "O"
        ElseIf RBT_OffSquareX.Checked Then
            selectedOffSquare = "X"
        ElseIf RBT_OffSquareNa.Checked Then
            selectedOffSquare = "N"
        End If

        If RBT_IncorrectDimensionCheck.Checked Then
            selectedIncorDimen = "O"
        ElseIf RBT_IncorrectDimensionX.Checked Then
            selectedIncorDimen = "X"
        ElseIf RBT_IncorrectDimensionNa.Checked Then
            selectedIncorDimen = "N"
        End If

        If RBT_TearOffCheck.Checked Then
            selectedTearOff = "O"
        ElseIf RBT_TearOffX.Checked Then
            selectedTearOff = "X"
        ElseIf RBT_TearOffNa.Checked Then
            selectedTearOff = "N"
        End If

        If RBT_IncorrectGrainDirectionCheck.Checked Then
            selectedIncorGrain = "O"
        ElseIf RBT_IncorrectGrainDirectionX.Checked Then
            selectedIncorGrain = "X"
        ElseIf RBT_IncorrectGrainDirectionNa.Checked Then
            selectedIncorGrain = "N"
        End If


        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_CUT WHERE Site = '" & Form1.cmb_site.Text & "' And mcnum  = '" & TXT_CheckMCNo.Text & "' "
        dr = cmd.ExecuteReader()


        If dr.HasRows Then
            dr.Close()
            con.Close()



            OpenConnection()

            'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "


            cmd.CommandText = "Select_TimeMaintenance"
            cmd.CommandType = CommandType.StoredProcedure

            'cmd.CommandText = "Select [time] FROM [dbo].[timemaintenance] WHERE ([time] >= @FromTime And [time] <= @ToTime) Or ([time] >= @FromTime And @ToTime < @FromTime) ORDER BY [time] ASC"




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


                        cmd.CommandText = $"UPDATE sppmcPRR_CUT 
                           SET 
                               prr_CUbladeshrp{vartime} = @prr_CUbladeshrp, 
                               prr_CUbladecond{vartime} = @prr_CUbladecond, 
                               prr_CULosefibr{vartime} = @prr_CULosefibr, 
                               prr_CULosefibr{vartime}val = @prr_CULosefibrval, 
                               prr_CUOffsquare{vartime} = @prr_CUOffsquare, 
                               prr_CUOffsquare{vartime}val = @prr_CUOffsquareval, 
                               prr_CUIncordimen{vartime} = @prr_CUIncordimen, 
                               prr_CUIncordimen{vartime}val = @prr_CUIncordimenval, 
                               prr_CUTearoff{vartime} = @prr_CUTearoff, 
                               prr_CUTearoff{vartime}val = @prr_CUTearoffval, 
                               prr_CUIncorGrainDir{vartime} = @prr_CUIncorGrainDir, 
                               prr_CUIncorGrainDir{vartime}val = @prr_CUIncorGrainDirval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        .AddWithValue("@prr_CUbladeshrp", selectedCuttingBladeShrp)
                        .AddWithValue("@prr_CUbladecond", selectedCuttingBladeCon)
                        .AddWithValue("@prr_CULosefibr", selectedLooseFiber)
                        .AddWithValue("@prr_CULosefibrval", TXT_LooseFiberQty.Text)
                        .AddWithValue("@prr_CUOffsquare", selectedOffSquare)
                        .AddWithValue("@prr_CUOffsquareval", TXT_OffSquareQty.Text)
                        .AddWithValue("@prr_CUIncordimen", selectedIncorDimen)
                        .AddWithValue("@prr_CUIncordimenval", TXT_IncorrectDimensionQty.Text)
                        .AddWithValue("@prr_CUTearoff", selectedTearOff)
                        .AddWithValue("@prr_CUTearoffval", TXT_TearOffQTY.Text)
                        .AddWithValue("@prr_CUIncorGrainDir", selectedIncorGrain)
                        .AddWithValue("@prr_CUIncorGrainDirval", TXT_IncorrectGrainDirectionQty.Text)
                    End With
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                    Next
                    con.Close()




                End If
                con.Close()

                Try
                    OpenConnection()
                    cmd.CommandText = "UPDATE sppmcPRR_CUT SET prr_RESNum = @prr_resnum, prr_SASNum = @prr_sasnum  WHERE Site = @Site AND mcnum = @mcnum"
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



            Else

                MsgBox("insert")

            dr.Close()
            con.Close()




            'Update to header
            If position = "Operator" Then
                OpenConnection()
                cmd.CommandText = "UPDATE sppmcHdr Set emp_num = @emp_num WHERE Site = @Site And mcnum = @mcnum"
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
                cmd.CommandText = "UPDATE sppmcJIC Set jic_Operator = @jic_Operator  WHERE Site = @Site And mcnum = @mcnum "
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




            OpenConnection()

            cmd.CommandText = "INSERT INTO sppmcPRR_CUT (Site, mcnum, prr_RESNum , prr_SASnum) VALUES (@Site, @mcnum, @prr_RESNum, @prr_SASNum)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Site)
            cmd.Parameters.AddWithValue("@mcnum", TXT_CheckMCNo.Text)
            cmd.Parameters.AddWithValue("@prr_RESNum", TXT_ResNo.Text)
            cmd.Parameters.AddWithValue("@prr_SASnum", TXT_SasNo.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            OpenConnection()

            cmd.CommandText = "Select time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime And @ToTime order by time ASC"

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


                    cmd.CommandText = $"UPDATE sppmcPRR_CUT 
                           SET 
                               prr_CUbladeshrp{vartime} = @prr_CUbladeshrp, 
                               prr_CUbladecond{vartime} = @prr_CUbladecond, 
                               prr_CULosefibr{vartime} = @prr_CULosefibr, 
                               prr_CULosefibr{vartime}val = @prr_CULosefibrval, 
                               prr_CUOffsquare{vartime} = @prr_CUOffsquare, 
                               prr_CUOffsquare{vartime}val = @prr_CUOffsquareval, 
                               prr_CUIncordimen{vartime} = @prr_CUIncordimen, 
                               prr_CUIncordimen{vartime}val = @prr_CUIncordimenval, 
                               prr_CUTearoff{vartime} = @prr_CUTearoff, 
                               prr_CUTearoff{vartime}val = @prr_CUTearoffval, 
                               prr_CUIncorGrainDir{vartime} = @prr_CUIncorGrainDir, 
                               prr_CUIncorGrainDir{vartime}val = @prr_CUIncorGrainDirval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@Site", Site)
                        .AddWithValue("@mcnum", TXT_CheckMCNo.Text)
                        .AddWithValue("@prr_CUbladeshrp", selectedCuttingBladeShrp)
                        .AddWithValue("@prr_CUbladecond", selectedCuttingBladeCon)
                        .AddWithValue("@prr_CULosefibr", selectedLooseFiber)
                        .AddWithValue("@prr_CULosefibrval", TXT_LooseFiberQty.Text)
                        .AddWithValue("@prr_CUOffsquare", selectedOffSquare)
                        .AddWithValue("@prr_CUOffsquareval", TXT_OffSquareQty.Text)
                        .AddWithValue("@prr_CUIncordimen", selectedIncorDimen)
                        .AddWithValue("@prr_CUIncordimenval", TXT_IncorrectDimensionQty.Text)
                        .AddWithValue("@prr_CUTearoff", selectedTearOff)
                        .AddWithValue("@prr_CUTearoffval", TXT_TearOffQTY.Text)
                        .AddWithValue("@prr_CUIncorGrainDir", selectedIncorGrain)
                        .AddWithValue("@prr_CUIncorGrainDirval", TXT_IncorrectGrainDirectionQty.Text)
                    End With
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                MsgBox("successfully saved!")
            End If
        End If
        con.Close()



        Dim int As Integer
        For int = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
        Next

        Dim MonitoringChecklistOperator1 As New UC_MonitoringChecklistOperators
        MonitoringChecklistOperator1.BTN_AddProductionRun.Enabled = True
        MonitoringChecklistOperator1.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        MonitoringChecklistOperator1.Show()
        MonitoringChecklistOperator1.Dock = DockStyle.Fill

        FRM_MonitoringChecklistMain.Show()
        Me.Close()






    End Sub

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()
    End Sub

    Private Sub FRM_AddProductionRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenConnection()
        cmd.CommandText = "SELECT * FROM sppmcPRR_CUT WHERE Site = @site And mcnum = @mcnum"
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
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


    Private Sub TXT_LooseFiberQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_LooseFiberQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_OffSquareQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_OffSquareQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_IncorrectDimensionQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_IncorrectDimensionQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_TearOffQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TearOffQTY.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_IncorrectGrainDirectionQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_IncorrectGrainDirectionQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub RBT_CuttingBladeSharpCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CuttingBladeSharpCheck.CheckedChanged

    End Sub
End Class