Public Class FRM_AddProductionRunDIGIPRESS
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()
    End Sub

    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click


        Dim selectedC As String = ""
        Dim selectedM As String = ""
        Dim selectedY As String = ""
        Dim selectedK As String = ""
        Dim selectedO As String = ""
        Dim selectedG As String = ""
        Dim selectedV As String = ""
        Dim selectedMainPile As String = ""
        Dim selectedDrawer1 As String = ""
        Dim selectedDrawer2 As String = ""
        Dim selectedOffColorScum As String = ""
        Dim selectedPlugging As String = ""
        Dim selectedHawa As String = ""
        Dim selectedSlurring As String = ""
        Dim selectedGhosting As String = ""
        Dim selectedMisregistration As String = ""
        Dim selectedDent As String = ""
        Dim selectedSpot As String = ""

        If RBT_InkLoadCCheck.Checked Then
            selectedC = "O"
        ElseIf RBT_InkLoadCX.Checked Then
            selectedC = "X"
        ElseIf RBT_InkLoadCNA.Checked Then
            selectedC = "N"
        End If

        If RBT_InkLoadMCheck.Checked Then
            selectedM = "O"
        ElseIf RBT_InkLoadMX.Checked Then
            selectedM = "X"
        ElseIf RBT_InkLoadMNA.Checked Then
            selectedM = "N"
        End If

        If RBT_InkLoadYCheck.Checked Then
            selectedY = "O"
        ElseIf RBT_InkLoadYX.Checked Then
            selectedY = "X"
        ElseIf RBT_InkLoadYNA.Checked Then
            selectedY = "N"
        End If

        If RBT_InkLoadKCheck.Checked Then
            selectedK = "O"
        ElseIf RBT_InkLoadKX.Checked Then
            selectedK = "X"
        ElseIf RBT_InkLoadKNA.Checked Then
            selectedK = "N"
        End If

        If RBT_InkLoadOCheck.Checked Then
            selectedO = "O"
        ElseIf RBT_InkLoadOX.Checked Then
            selectedO = "X"
        ElseIf RBT_InkLoadONA.Checked Then
            selectedO = "N"
        End If

        If RBT_InkLoadGCheck.Checked Then
            selectedG = "O"
        ElseIf RBT_InkLoadGX.Checked Then
            selectedG = "X"
        ElseIf RBT_InkLoadGNA.Checked Then
            selectedG = "N"
        End If

        If RBT_InkLoadVCheck.Checked Then
            selectedV = "O"
        ElseIf RBT_InkLoadVX.Checked Then
            selectedV = "X"
        ElseIf RBT_InkLoadVNA.Checked Then
            selectedV = "N"
        End If


        If RBT_MainPileCheck.Checked Then
            selectedMainPile = "O"
        ElseIf RBT_MainPileX.Checked Then
            selectedMainPile = "X"
        ElseIf RBT_MainPileNA.Checked Then
            selectedMainPile = "N"
        End If


        If RBT_Drawer1Check.Checked Then
            selectedDrawer1 = "O"
        ElseIf RBT_Drawer1X.Checked Then
            selectedDrawer1 = "X"
        ElseIf RBT_Drawer1NA.Checked Then
            selectedDrawer1 = "N"
        End If

        If RBT_Drawer2Check.Checked Then
            selectedDrawer2 = "O"
        ElseIf RBT_Drawer2X.Checked Then
            selectedDrawer2 = "X"
        ElseIf RBT_Drawer2NA.Checked Then
            selectedDrawer2 = "N"
        End If


        If RBT_OffcolorCheck.Checked Then
            selectedOffColorScum = "O"
        ElseIf RBT_OffcolorX.Checked Then
            selectedOffColorScum = "X"
        ElseIf RBT_OffcolorNA.Checked Then
            selectedOffColorScum = "N"
        End If

        If RBT_PluggingCheck.Checked Then
            selectedPlugging = "O"
        ElseIf RBT_PluggingX.Checked Then
            selectedPlugging = "X"
        ElseIf RBT_PluggingNA.Checked Then
            selectedPlugging = "N"
        End If


        If RBT_HawaCheck.Checked Then
            selectedHawa = "O"
        ElseIf RBT_HawaX.Checked Then
            selectedHawa = "X"
        ElseIf RBT_HawaNA.Checked Then
            selectedHawa = "N"
        End If

        If RBT_SlurningCheck.Checked Then
            selectedSlurring = "O"
        ElseIf RBT_SlurningX.Checked Then
            selectedSlurring = "X"
        ElseIf RBT_SlurningNA.Checked Then
            selectedSlurring = "N"
        End If

        If RBT_GhostingCheck.Checked Then
            selectedGhosting = "O"
        ElseIf RBT_GhostingX.Checked Then
            selectedGhosting = "X"
        ElseIf RBT_GhostingNA.Checked Then
            selectedGhosting = "N"
        End If


        If RBT_MisregistrationCheck.Checked Then
            selectedMisregistration = "O"
        ElseIf RBT_MisregistrationX.Checked Then
            selectedMisregistration = "X"
        ElseIf RBT_MisregistrationNA.Checked Then
            selectedMisregistration = "N"
        End If

        If RBT_DentCheck.Checked Then
            selectedDent = "O"
        ElseIf RBT_DentX.Checked Then
            selectedDent = "X"
        ElseIf RBT_DentNA.Checked Then
            selectedDent = "N"
        End If



        If RBT_SpotCheck.Checked Then
            selectedSpot = "O"
        ElseIf RBT_SpotX.Checked Then
            selectedSpot = "X"
        ElseIf RBT_SpotNA.Checked Then
            selectedSpot = "N"
        End If




        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_DGP WHERE Site = @site  And mcnum  = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()


        If dr.HasRows Then
            dr.Close()
            con.Close()


            OpenConnection()


            ' 22 January 2025 due to not showing

            cmd.CommandText = "
                                SELECT time
                                FROM [dbo].[timemaintenance]
                                WHERE 
                                    (time NOT LIKE '%30%' OR time = '0300')
                                    AND time BETWEEN @FromTime AND @ToTime
                                ORDER BY time ASC"



            'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE (time NOT LIKE '%30%' OR time = '0300')AND ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "



            cmd.CommandType = CommandType.Text

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

                    cmd.CommandText = $"UPDATE sppmcPRR_DGP 
                           SET 
                               prr_DPInkLdC{vartime} = @prr_DPInkLdC, 
                               prr_DPInkLdM{vartime} = @prr_DPInkLdM, 
                               prr_DPInkLdY{vartime} = @prr_DPInkLdY, 
                               prr_DPInkLdK{vartime} = @prr_DPInkLdK, 
                               prr_DPInkLdO{vartime} = @prr_DPInkLdO, 
                               prr_DPInkLdG{vartime} = @prr_DPInkLdG,

                               prr_DPInkLdV{vartime} = @prr_DPInkLdV,
                               prr_DPSFmainp{vartime} = @prr_DPSFmainp,
                               prr_DPSFdrwr1{vartime} = @prr_DPSFdrwr1,
                               prr_DPSFdrwr2{vartime} = @prr_DPSFdrwr2,
                               prr_DPOffcolor{vartime} = @prr_DPOffcolor,
                               prr_DPOffcolor{vartime}val = @prr_DPOffcolorval,
                               prr_DPPlug{vartime} = @prr_DPPlug,
                               prr_DPPlug{vartime}val = @prr_DPPlugval,
                               prr_DPHawa{vartime} = @prr_DPHawa,
                               prr_DPHawa{vartime}val = @prr_DPHawaval,
                               prr_DPSlurring{vartime} = @prr_DPSlurring,
                               prr_DPSlurring{vartime}val = @prr_DPSlurringval,
                               prr_DPghostng{vartime} = @prr_DPghostng,
                               prr_DPghostng{vartime}val = @prr_DPghostngval,
                               prr_DPMisreg{vartime} = @prr_DPMisreg,
                               prr_DPMisreg{vartime}val = @prr_DPMisregval,
                               prr_DPDent{vartime} = @prr_DPDent,
                               prr_DPDent{vartime}val = @prr_DPDentval,
                               prr_DPSpot{vartime} = @prr_DPSpot,
                               prr_DPSpot{vartime}val = @prr_DPSpotval                
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_DPInkLdC", selectedC)
                        .AddWithValue("@prr_DPInkLdM", selectedM)
                        .AddWithValue("@prr_DPInkLdY", selectedY)
                        .AddWithValue("@prr_DPInkLdK", selectedK)
                        .AddWithValue("@prr_DPInkLdO", selectedO)
                        .AddWithValue("@prr_DPInkLdG", selectedG)
                        .AddWithValue("@prr_DPInkLdV", selectedV)

                        .AddWithValue("@prr_DPSFmainp", selectedMainPile)
                        .AddWithValue("@prr_DPSFdrwr1", selectedDrawer1)
                        .AddWithValue("@prr_DPSFdrwr2", selectedDrawer2)
                        .AddWithValue("@prr_DPOffcolor", selectedOffColorScum)
                        .AddWithValue("@prr_DPOffcolorval", TXT_Offcolor.Text)
                        .AddWithValue("@prr_DPPlug", selectedPlugging)
                        .AddWithValue("@prr_DPPlugval", TXT_Plugging.Text)
                        .AddWithValue("@prr_DPHawa", selectedHawa)
                        .AddWithValue("@prr_DPHawaval", TXT_Hawa.Text)
                        .AddWithValue("@prr_DPSlurring", selectedSlurring)
                        .AddWithValue("@prr_DPSlurringval", TXT_Slurning.Text)
                        .AddWithValue("@prr_DPghostng", selectedGhosting)
                        .AddWithValue("@prr_DPghostngval", TXT_Ghosting.Text)
                        .AddWithValue("@prr_DPMisreg", selectedGhosting)
                        .AddWithValue("@prr_DPMisregval", TXT_Misregistration.Text)
                        .AddWithValue("@prr_DPDent", selectedDent)
                        .AddWithValue("@prr_DPDentval", TXT_Dent.Text)
                        .AddWithValue("@prr_DPSpot", selectedSpot)
                        .AddWithValue("@prr_DPSpotval", TXT_Spot.Text)



                    End With
                    cmd.ExecuteNonQuery()
                Next
                con.Close()

            End If

            con.Close()

            Try
                OpenConnection()
                cmd.CommandText = "UPDATE sppmcPRR_DGP  SET prr_RESNum = @prr_resnum, prr_SASNum = @prr_sasnum  WHERE Site = @Site AND mcnum = @mcnum"
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
            dr.Close()
            con.Close()





            OpenConnection()

            cmd.CommandText = "INSERT INTO sppmcPRR_DGP (Site, mcnum, prr_RESNum , prr_SASnum) VALUES (@Site, @mcnum, @prr_RESNum, @prr_SASNum)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.Parameters.AddWithValue("@prr_RESNum", TXT_ResNo.Text)
            cmd.Parameters.AddWithValue("@prr_SASnum", TXT_SasNo.Text)

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

                    cmd.CommandText = $"UPDATE sppmcPRR_DGP 
                           SET 
                               prr_DPInkLdC{vartime} = @prr_DPInkLdC, 
                               prr_DPInkLdM{vartime} = @prr_DPInkLdM, 
                               prr_DPInkLdY{vartime} = @prr_DPInkLdY, 
                               prr_DPInkLdK{vartime} = @prr_DPInkLdK, 
                               prr_DPInkLdO{vartime} = @prr_DPInkLdO, 
                               prr_DPInkLdG{vartime} = @prr_DPInkLdG,

                               prr_DPInkLdV{vartime} = @prr_DPInkLdV,
                               prr_DPSFmainp{vartime} = @prr_DPSFmainp,
                               prr_DPSFdrwr1{vartime} = @prr_DPSFdrwr1,
                               prr_DPSFdrwr2{vartime} = @prr_DPSFdrwr2,
                               prr_DPOffcolor{vartime} = @prr_DPOffcolor,
                               prr_DPOffcolor{vartime}val = @prr_DPOffcolorval,
                               prr_DPPlug{vartime} = @prr_DPPlug,
                               prr_DPPlug{vartime}val = @prr_DPPlugval,
                               prr_DPHawa{vartime} = @prr_DPHawa,
                               prr_DPHawa{vartime}val = @prr_DPHawaval,
                               prr_DPSlurring{vartime} = @prr_DPSlurring,
                               prr_DPSlurring{vartime}val = @prr_DPSlurringval,
                               prr_DPghostng{vartime} = @prr_DPghostng,
                               prr_DPghostng{vartime}val = @prr_DPghostngval,
                               prr_DPMisreg{vartime} = @prr_DPMisreg,
                               prr_DPMisreg{vartime}val = @prr_DPMisregval,
                               prr_DPDent{vartime} = @prr_DPDent,
                               prr_DPDent{vartime}val = @prr_DPDentval,
                               prr_DPSpot{vartime} = @prr_DPSpot,
                               prr_DPSpot{vartime}val = @prr_DPSpotval                
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        .AddWithValue("@prr_DPInkLdC", selectedC)
                        .AddWithValue("@prr_DPInkLdM", selectedM)
                        .AddWithValue("@prr_DPInkLdY", selectedY)
                        .AddWithValue("@prr_DPInkLdK", selectedK)
                        .AddWithValue("@prr_DPInkLdO", selectedO)
                        .AddWithValue("@prr_DPInkLdG", selectedG)
                        .AddWithValue("@prr_DPInkLdV", selectedV)
                        .AddWithValue("@prr_DPSFmainp", selectedMainPile)
                        .AddWithValue("@prr_DPSFdrwr1", selectedDrawer1)
                        .AddWithValue("@prr_DPSFdrwr2", selectedDrawer2)
                        .AddWithValue("@prr_DPOffcolor", selectedOffColorScum)
                        .AddWithValue("@prr_DPOffcolorval", TXT_Offcolor.Text)
                        .AddWithValue("@prr_DPPlug", selectedPlugging)
                        .AddWithValue("@prr_DPPlugval", TXT_Plugging.Text)
                        .AddWithValue("@prr_DPHawa", selectedHawa)
                        .AddWithValue("@prr_DPHawaval", TXT_Hawa.Text)
                        .AddWithValue("@prr_DPSlurring", selectedSlurring)
                        .AddWithValue("@prr_DPSlurringval", TXT_Slurning.Text)
                        .AddWithValue("@prr_DPghostng", selectedGhosting)
                        .AddWithValue("@prr_DPghostngval", TXT_Ghosting.Text)
                        .AddWithValue("@prr_DPMisreg", selectedGhosting)
                        .AddWithValue("@prr_DPMisregval", TXT_Misregistration.Text)
                        .AddWithValue("@prr_DPDent", selectedDent)
                        .AddWithValue("@prr_DPDentval", TXT_Dent.Text)
                        .AddWithValue("@prr_DPSpot", selectedSpot)
                        .AddWithValue("@prr_DPSpotval", TXT_Spot.Text)



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

        con.Close()

        Dim int As Integer
        For int = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
        Next

        Dim UC_OperatorDigiPress As New UC_OperatorDigiPress
        UC_OperatorDigiPress.BTN_AddProductionRun.Enabled = True
        UC_OperatorDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorDigiPress.Show()
        UC_OperatorDigiPress.Dock = DockStyle.Fill

        FRM_MonitoringChecklistMain.Show()
        Me.Close()



    End Sub

    Private Sub FRM_AddProductionRunDIGIPRESS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        cmd.CommandText = "SELECT * FROM sppmcPRR_DGP WHERE Site = @site And mcnum = @mcnum"
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

    Private Sub RBT_OffcolorCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffcolorCheck.CheckedChanged
        TXT_Offcolor.Enabled = False
        TXT_Offcolor.Text = ""
    End Sub

    Private Sub RBT_OffcolorX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffcolorX.CheckedChanged
        TXT_Offcolor.Enabled = True

    End Sub

    Private Sub RBT_OffcolorNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffcolorNA.CheckedChanged
        TXT_Offcolor.Enabled = False
        TXT_Offcolor.Text = ""
    End Sub


    Private Sub RBT_PluggingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PluggingCheck.CheckedChanged
        TXT_Plugging.Enabled = False
        TXT_Plugging.Text = ""
    End Sub

    Private Sub RBT_PluggingX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PluggingX.CheckedChanged
        TXT_Plugging.Enabled = True

    End Sub

    Private Sub RBT_PluggingNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PluggingNA.CheckedChanged
        TXT_Plugging.Enabled = False
        TXT_Plugging.Text = ""
    End Sub



    Private Sub RBT_HawaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_HawaCheck.CheckedChanged
        TXT_Hawa.Enabled = False
        TXT_Hawa.Text = ""
    End Sub

    Private Sub RBT_HawaX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_HawaX.CheckedChanged
        TXT_Hawa.Enabled = True

    End Sub

    Private Sub RBT_HawaNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_HawaNA.CheckedChanged
        TXT_Hawa.Enabled = False
        TXT_Hawa.Text = ""
    End Sub


    Private Sub RBT_SlurningCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SlurningCheck.CheckedChanged
        TXT_Slurning.Enabled = False
        TXT_Slurning.Text = ""
    End Sub

    Private Sub RBT_SlurningX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SlurningX.CheckedChanged
        TXT_Slurning.Enabled = True

    End Sub

    Private Sub RBT_SlurningNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SlurningNA.CheckedChanged
        TXT_Slurning.Enabled = False
        TXT_Slurning.Text = ""
    End Sub



    Private Sub RBT_GhostingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GhostingCheck.CheckedChanged
        TXT_Ghosting.Enabled = False
        TXT_Ghosting.Text = ""
    End Sub

    Private Sub RBT_GhostingX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GhostingX.CheckedChanged
        TXT_Ghosting.Enabled = True
    End Sub


    Private Sub RBT_GhostingNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GhostingNA.CheckedChanged
        TXT_Ghosting.Enabled = False
        TXT_Ghosting.Text = ""
    End Sub



    Private Sub RBT_MisregistrationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_MisregistrationCheck.CheckedChanged
        TXT_Misregistration.Enabled = False
        TXT_Misregistration.Text = ""
    End Sub

    Private Sub RBT_MisregistrationX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_MisregistrationX.CheckedChanged
        TXT_Misregistration.Enabled = True

    End Sub

    Private Sub RBT_MisregistrationNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_MisregistrationNA.CheckedChanged
        TXT_Misregistration.Enabled = False
        TXT_Misregistration.Text = ""
    End Sub


    Private Sub RBT_DentCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_DentCheck.CheckedChanged
        TXT_Dent.Enabled = False
        TXT_Dent.Text = ""
    End Sub

    Private Sub RBT_SpotCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SpotCheck.CheckedChanged
        TXT_Spot.Enabled = False
        TXT_Spot.Text = ""
    End Sub

    Private Sub RBT_SpotX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SpotX.CheckedChanged
        TXT_Spot.Enabled = True

    End Sub

    Private Sub RBT_SpotNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SpotNA.CheckedChanged
        TXT_Spot.Enabled = False
        TXT_Spot.Text = ""
    End Sub

    Private Sub TXT_Offcolor_TextChanged(sender As Object, e As EventArgs) Handles TXT_Offcolor.TextChanged

    End Sub

    Private Sub TXT_Offcolor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Offcolor.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Plugging_TextChanged(sender As Object, e As EventArgs) Handles TXT_Plugging.TextChanged

    End Sub

    Private Sub TXT_Plugging_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Plugging.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Hawa_TextChanged(sender As Object, e As EventArgs) Handles TXT_Hawa.TextChanged

    End Sub

    Private Sub TXT_Hawa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Hawa.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Slurning_TextChanged(sender As Object, e As EventArgs) Handles TXT_Slurning.TextChanged

    End Sub

    Private Sub TXT_Slurning_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Slurning.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Ghosting_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ghosting.TextChanged

    End Sub

    Private Sub TXT_Ghosting_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Ghosting.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Misregistration_TextChanged(sender As Object, e As EventArgs) Handles TXT_Misregistration.TextChanged

    End Sub

    Private Sub TXT_Misregistration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Misregistration.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Dent_TextChanged(sender As Object, e As EventArgs) Handles TXT_Dent.TextChanged

    End Sub

    Private Sub TXT_Dent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Dent.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Spot_TextChanged(sender As Object, e As EventArgs) Handles TXT_Spot.TextChanged

    End Sub

    Private Sub TXT_Spot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Spot.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub RBT_DentX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_DentX.CheckedChanged
        TXT_Dent.Enabled = True
    End Sub

    Private Sub RBT_DentNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_DentNA.CheckedChanged
        TXT_Dent.Enabled = False
        TXT_Dent.Text = ""
    End Sub
End Class