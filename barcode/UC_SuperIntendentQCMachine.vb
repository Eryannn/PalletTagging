Public Class UC_SuperIntendentQCMachine
    Private Sub UC_SuperIntendentQCMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    If dr("flc_feeder").ToString() = "O" Then
                        CHK_FullFeeder.Checked = True
                    Else
                        CHK_FullFeeder.Checked = False

                    End If

                    If dr("flc_delivery").ToString() = "O" Then
                        CHK_FullDelivery.Checked = True
                    Else
                        CHK_FullDelivery.Checked = False
                    End If



                    If dr("flc_wasteBin").ToString() = "O" Then
                        CHK_FullWastebins.Checked = True
                    Else
                        CHK_FullWastebins.Checked = False
                    End If

                    If dr("flc_workingTable").ToString() = "O" Then
                        CHK_FullWorkingtable.Checked = True
                    Else
                        CHK_FullWorkingtable.Checked = False
                    End If





                    TXT_FullBallpenQtyStartPC.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_FullRagsQtyStartPC.Text = dr("flc_OLCragqty").ToString()




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

                    'A

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




                    'B

                    If dr("gmp_SaniSortTable").ToString() = "O" Then
                        CHK_GoodSortingTable.Checked = True
                    Else
                        CHK_GoodSortingTable.Checked = False
                    End If

                    If dr("gmp_SaniFeederUnit").ToString() = "O" Then
                        CHK_GoodFeederUnit.Checked = True
                    Else
                        CHK_GoodFeederUnit.Checked = False
                    End If


                    If dr("gmp_SaniPrefoldUnit").ToString() = "O" Then
                        CHK_GoodPreFoldingUnit.Checked = True
                    Else
                        CHK_GoodPreFoldingUnit.Checked = False
                    End If


                    If dr("gmp_SaniConveyor").ToString() = "O" Then
                        CHK_GoodConveyor.Checked = True
                    Else
                        CHK_GoodConveyor.Checked = False
                    End If


                    If dr("gmp_SaniPlasticPallet").ToString() = "O" Then
                        CHK_GoodPlasticPallets.Checked = True
                    Else
                        CHK_GoodPlasticPallets.Checked = False
                    End If




                    'C





                    If dr("gmp_PrePropTagged").ToString() = "O" Then
                        CHK_GoodProperlyTagged.Checked = True
                    Else
                        CHK_GoodProperlyTagged.Checked = False
                    End If




                    If dr("gmp_PreInPlasticPallet").ToString() = "O" Then
                        CHK_GoodInPlasticPalltes.Checked = True
                    Else
                        CHK_GoodInPlasticPalltes.Checked = False
                    End If





                    If dr("gmp_PreFollowStdHeight").ToString() = "O" Then
                        CHK_GoodInStandardPalletizingHeight.Checked = True
                    Else
                        CHK_GoodInStandardPalletizingHeight.Checked = False
                    End If


                    'D

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





        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcCHT"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then

                If dr.Read() Then

                    'Camera1
                    If dr("cht_QCCam1").ToString() = "O" Then
                        CHK_Camera1.Checked = True
                    Else
                        CHK_Camera1.Checked = False
                    End If


                    If dr("cht_QCSpot").ToString() = "O" Then
                        CHK_Camera1Spot.Checked = True
                    Else
                        CHK_Camera1Spot.Checked = False
                    End If


                    If dr("cht_QCStrk").ToString() = "O" Then
                        CHK_Camera1Streak.Checked = True
                    Else
                        CHK_Camera1Streak.Checked = False
                    End If

                    If dr("cht_QCReg").ToString() = "O" Then
                        CHK_Camera1Registration.Checked = True
                    Else
                        CHK_Camera1Registration.Checked = False
                    End If


                    If dr("cht_QCTxt").ToString() = "O" Then
                        CHK_Camera1Text.Checked = True
                    Else
                        CHK_Camera1Text.Checked = False
                    End If


                    If dr("cht_QCColor").ToString() = "O" Then
                        CHK_Camera1Color.Checked = True
                    Else
                        CHK_Camera1Color.Checked = False
                    End If


                    'Camera2
                    If dr("cht_QCCam2").ToString() = "O" Then
                        CHK_Camera2.Checked = True
                    Else
                        CHK_Camera2.Checked = False
                    End If

                    If dr("cht_QCC2ScrLine").ToString() = "O" Then
                        CHK_Camera2ScoreLine.Checked = True
                    Else
                        CHK_Camera2ScoreLine.Checked = False
                    End If

                    If dr("cht_QCFrntPanel").ToString() = "O" Then
                        CHK_Camera2FrontPanel.Checked = True
                    Else
                        CHK_Camera2FrontPanel.Checked = False
                    End If

                    If dr("cht_QCEmbos").ToString() = "O" Then
                        CHK_Camera2Embossed.Checked = True
                    Else
                        CHK_Camera2Embossed.Checked = False
                    End If

                    If dr("cht_QCDebos").ToString() = "O" Then
                        CHK_Camera2Debosed.Checked = True
                    Else
                        CHK_Camera2Debosed.Checked = False
                    End If

                    If dr("cht_QCUnvarnsh").ToString() = "O" Then
                        CHK_Camera2Unvarnish.Checked = True
                    Else
                        CHK_Camera2Unvarnish.Checked = False
                    End If

                    'Camera3

                    If dr("cht_QCCam3").ToString() = "O" Then
                        CHK_Camera3.Checked = True
                    Else
                        CHK_Camera3.Checked = False
                    End If


                    If dr("cht_QCC3ScrLine").ToString() = "O" Then
                        CHK_Camera3ScoreLine.Checked = True
                    Else
                        CHK_Camera3ScoreLine.Checked = False
                    End If


                    If dr("cht_QCBckwPrint").ToString() = "O" Then
                        CHK_Camera3BacksideWithPrint.Checked = True
                    Else
                        CHK_Camera3BacksideWithPrint.Checked = False
                    End If


                    If dr("cht_QCBckwOPrint").ToString() = "O" Then
                        CHK_Camera3BacksideWithoutPrint.Checked = True
                    Else
                        CHK_Camera3BacksideWithoutPrint.Checked = False
                    End If


                    'Camera4
                    If dr("cht_QCCam4").ToString() = "O" Then
                        CHK_Camera4.Checked = True
                    Else
                        CHK_Camera4.Checked = False
                    End If


                    If dr("cht_QCHotfoil").ToString() = "O" Then
                        CHK_Camera4HotFoil.Checked = True
                    Else
                        CHK_Camera4HotFoil.Checked = False
                    End If


                    If dr("cht_QCCldfoil").ToString() = "O" Then
                        CHK_Camera4ColdFoil.Checked = True
                    Else
                        CHK_Camera4ColdFoil.Checked = False
                    End If


                    dr.Close()
                    con.Close()
                End If
                dr.Close()
                con.Close()

            End If
            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
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

            Dim UC_SuperIntendentQCMach As New UC_SuperIntendentQCMachine
            UC_SuperIntendentQCMach.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentQCMach.Show()
            UC_SuperIntendentQCMach.Dock = DockStyle.Fill

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
                                       FRM_ProcessJob.Show()
                                       FRM_MonitoringChecklistMain.Hide()
                                   End If
                               End Sub
        timer.Interval = 100 ' Adjust the interval as ne ended

    End Sub

End Class
