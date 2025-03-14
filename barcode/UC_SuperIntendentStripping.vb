Public Class UC_SuperIntendentStripping
    Private Sub DisabledSupervisorForm()

        'FULL A and B
        CHK_FullWasteSack.Enabled = False
        CHK_FullPinBar.Enabled = False
        CHK_FullPressingTable.Enabled = False
        CHK_FullPlasticPallets.Enabled = False
        CHK_FullViewingTable.Enabled = False
        CHK_FullLifter.Enabled = False
        CHK_FullOthers.Enabled = False
        TXT_BallpenQty.Enabled = False
        TXT_RagsQty.Enabled = False
        TXT_StrippingKnifeQty1.Enabled = False
        TXT_StrippingKnifeQty2.Enabled = False
        TXT_FullMarker.Enabled = False





        '7

        CHK_GoodMachineTable.Enabled = False
        CHK_GoodStrippingPins.Enabled = False

        '2
        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodOilChemical.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False
        CHK_GoodLiftsolNo5.Enabled = False
        CHK_GoodMachineTable.Enabled = False
        CHK_GoodStrippingPins.Enabled = False
        CHK_GoodPads.Enabled = False

        CHK_GoodProperlyTagged.Enabled = False
        CHK_GoodPlasticPalltes.Enabled = False
        CHK_GoodFollowingStandard.Enabled = False

        CHK_GoodWearHair.Enabled = False
        CHk_GoodWearsProperlyTucked.Enabled = False
        CHk_GoodHandsWashed.Enabled = False

        CHK_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaningMaterials.Enabled = False
        CHK_GoodSafetyDevice.Enabled = False



    End Sub
    Private Sub UC_SuperIntendentStripping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisabledSupervisorForm()

        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcFLC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    If dr("flc_wasteSack").ToString() = "O" Then
                        CHK_FullWasteSack.Checked = True
                    Else
                        CHK_FullWasteSack.Checked = False

                    End If


                    If dr("flc_pinBar").ToString() = "O" Then
                        CHK_FullPinBar.Checked = True
                    Else
                        CHK_FullPinBar.Checked = False
                    End If




                    If dr("flc_pressingTable").ToString() = "O" Then
                        CHK_FullPressingTable.Checked = True
                    Else
                        CHK_FullPressingTable.Checked = False
                    End If


                    If dr("flc_plasticPallets").ToString() = "O" Then
                        CHK_FullPlasticPallets.Checked = True
                    Else
                        CHK_FullPlasticPallets.Checked = False
                    End If



                    If dr("flc_viewingTable").ToString() = "O" Then
                        CHK_FullViewingTable.Checked = True
                    Else
                        CHK_FullViewingTable.Checked = False
                    End If



                    If dr("flc_Lifter").ToString() = "O" Then
                        CHK_FullLifter.Checked = True
                    Else
                        CHK_FullLifter.Checked = False
                    End If


                    If dr("flc_Others").ToString() = "O" Then
                        CHK_FullOthers.Checked = True
                    Else
                        CHK_FullOthers.Checked = False
                    End If






                    TXT_BallpenQty.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_RagsQty.Text = dr("flc_OLCragqty").ToString()
                    TXT_StrippingKnifeQty1.Text = dr("flc_OLCstripknife").ToString()
                    TXT_StrippingKnifeQty2.Text = dr("flc_OLCstripbld").ToString()
                    TXT_FullMarker.Text = dr("flc_OLCmarkerqty").ToString()

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



        Try

            OpenConnection()
            cmd.CommandText = "Select_sppmcGMP"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    TXT_Supervisor.Text = dr("SupervisorName").ToString()
                    TXT_VerifiedSuperIntendent.Text = dr("VerifiedSupervisorName").ToString()


                    If dr("gmp_NoexcessDustDirt").ToString() = "O" Then
                        CHK_GoodExcessiveDust.Checked = True
                    Else
                        CHK_GoodExcessiveDust.Checked = False
                    End If


                    If dr("gmp_NoOilChemSpill").ToString() = "O" Then
                        CHK_GoodOilChemical.Checked = True
                    Else
                        CHK_GoodOilChemical.Checked = False
                    End If



                    If dr("gmp_NoforeignMatls").ToString() = "O" Then
                        CHK_GoodForeignMaterials.Checked = True
                    Else
                        CHK_GoodForeignMaterials.Checked = False
                    End If




                    If dr("gmp_SaniLiftsol#5").ToString() = "O" Then
                        CHK_GoodLiftsolNo5.Checked = True
                    Else
                        CHK_GoodLiftsolNo5.Checked = False
                    End If


                    If dr("gmp_SaniMachtable").ToString() = "O" Then
                        CHK_GoodMachineTable.Checked = True
                    Else
                        CHK_GoodMachineTable.Checked = False
                    End If




                    If dr("gmp_SaniStripPins").ToString() = "O" Then
                        CHK_GoodStrippingPins.Checked = True
                    Else
                        CHK_GoodStrippingPins.Checked = False
                    End If



                    If dr("gmp_SaniPads").ToString() = "O" Then
                        CHK_GoodPads.Checked = True
                    Else
                        CHK_GoodPads.Checked = False
                    End If





                    If dr("gmp_PrePropTagged").ToString() = "O" Then
                        CHK_GoodProperlyTagged.Checked = True
                    Else
                        CHK_GoodProperlyTagged.Checked = False
                    End If




                    If dr("gmp_PreInPlasticPallet").ToString() = "O" Then
                        CHK_GoodPlasticPalltes.Checked = True
                    Else
                        CHK_GoodPlasticPalltes.Checked = False
                    End If




                    If dr("gmp_PreFollowStdHeight").ToString() = "O" Then
                        CHK_GoodFollowingStandard.Checked = True
                    Else
                        CHK_GoodFollowingStandard.Checked = False
                    End If



                    If dr("gmp_HygWearHairCovr").ToString() = "O" Then
                        CHK_GoodWearHair.Checked = True
                    Else
                        CHK_GoodWearHair.Checked = False
                    End If


                    If dr("gmp_HygPropUniform").ToString() = "O" Then
                        CHk_GoodWearsProperlyTucked.Checked = True
                    Else
                        CHk_GoodWearsProperlyTucked.Checked = False
                    End If





                    If dr("gmp_HygHandsWashed").ToString() = "O" Then
                        CHk_GoodHandsWashed.Checked = True
                    Else
                        CHk_GoodHandsWashed.Checked = False
                    End If



                    If dr("gmp_SafeTools").ToString() = "O" Then
                        CHK_GoodTools.Checked = True
                    Else
                        CHK_GoodTools.Checked = False
                    End If



                    If dr("gmp_SafeEqpmt").ToString() = "O" Then
                        CHK_GoodEquipment.Checked = True
                    Else
                        CHK_GoodEquipment.Checked = False
                    End If



                    If dr("gmp_SafeCleaningMatls").ToString() = "O" Then
                        CHK_GoodCleaningMaterials.Checked = True
                    Else
                        CHK_GoodCleaningMaterials.Checked = False
                    End If


                    If dr("gmp_SafeWorkingDevices").ToString() = "O" Then
                        CHK_GoodSafetyDevice.Checked = True
                    Else
                        CHK_GoodSafetyDevice.Checked = False
                    End If


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




        If TXT_VerifiedSuperIntendent.Text <> "" Then
            BTN_VerifySupervisor.Enabled = False
            BTN_VerifySupervisor.BackColor = Color.LightGray

        Else
            BTN_VerifySupervisor.Enabled = True

        End If



    End Sub

    Private Sub BTN_VerifySupervisor_Click(sender As Object, e As EventArgs) Handles BTN_VerifySupervisor.Click
        Try
            OpenConnection()
            cmd.CommandText = "UPDATE sppmcGMP SET gmpVerBySup = @gmpVerBySup WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.Parameters.AddWithValue("@gmpVerBySup", FRM_MonitoringChecklistMain.lbl_empnum.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Verified successfully!")

            Dim i As Integer
            For i = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next

            Dim UC_SuperIntendentStrip As New UC_SuperIntendentStripping
            UC_SuperIntendentStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentStrip.Show()
            UC_SuperIntendentStrip.Dock = DockStyle.Fill




        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
End Class
