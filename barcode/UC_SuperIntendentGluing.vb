Public Class UC_SuperIntendentGluing
    Private Sub DisabledSupervisorForm()
        CHK_FullFeeder.Enabled = False
        CHK_FullDelivery.Enabled = False
        CHK_FullWasteBins.Enabled = False
        CHK_FullRotatingTable.Enabled = False
        CHK_FullWorkingTable.Enabled = False

        CHK_FullGlue.Enabled = False
        CHK_FullSticker.Enabled = False
        CHK_FullKraftPaper.Enabled = False
        CHK_FullCorrugatedBox.Enabled = False
        CHK_FullCutLabel.Enabled = False
        CHK_FullPalletTag.Enabled = False

        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodOilChemical.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False

        CHK_GoodJSortingTable.Enabled = False
        CHK_GoodFeederUnit.Enabled = False
        CHK_GoodPreFoldingUnit.Enabled = False
        CHK_GoodGluingUnit.Enabled = False
        CHK_GoodFinalFolding.Enabled = False
        CHK_GoodFConveyor.Enabled = False

        CHK_GoodJPacker.Enabled = False
        CHK_GoodBundingMachine.Enabled = False
        CHK_GoodRotatingTable.Enabled = False
        CHK_GoodWeighingScale.Enabled = False

        CHK_GoodProperlyTagged.Enabled = False
        CHk_GoodInPlasticPallets.Enabled = False
        CHK_GoodFollowingStandardPallet.Enabled = False

        CHK_GoodWearHairCover.Enabled = False
        CHk_GoodWearsProperlyTuckedIn.Enabled = False
        CHk_GoodHandWashed.Enabled = False

        CHk_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaingMaterials.Enabled = False
        CHK_GoodSafetyDevicesWorking.Enabled = False

        CHK_ChallengeFlyWheel.Enabled = False
        CHK_ChallengeGlueGun1.Enabled = False
        CHK_ChallengeGlueGun2.Enabled = False
        CHK_ChallengeGlueGun3.Enabled = False
        CHK_ChallengeGlueGun4.Enabled = False
        CHK_ChallengeNA.Enabled = False



    End Sub
    Private Sub UC_SuperIntendentGluing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    'A
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
                        CHK_FullWasteBins.Checked = True
                    Else
                        CHK_FullWasteBins.Checked = False
                    End If

                    If dr("flc_rotatingTable").ToString() = "O" Then
                        CHK_FullRotatingTable.Checked = True
                    Else
                        CHK_FullRotatingTable.Checked = False
                    End If


                    If dr("flc_workingTable").ToString() = "O" Then
                        CHK_FullWorkingTable.Checked = True
                    Else
                        CHK_FullWorkingTable.Checked = False
                    End If

                    'B


                    If dr("flc_glue").ToString() = "O" Then
                        CHK_FullGlue.Checked = True
                    Else
                        CHK_FullGlue.Checked = False
                    End If


                    If dr("flc_sticker").ToString() = "O" Then
                        CHK_FullSticker.Checked = True
                    Else
                        CHK_FullSticker.Checked = False
                    End If


                    If dr("flc_kraftPaper").ToString() = "O" Then
                        CHK_FullKraftPaper.Checked = True
                    Else
                        CHK_FullKraftPaper.Checked = False
                    End If

                    If dr("flc_corrugatedBox").ToString() = "O" Then
                        CHK_FullCorrugatedBox.Checked = True
                    Else
                        CHK_FullCorrugatedBox.Checked = False
                    End If

                    If dr("flc_cutLabel").ToString() = "O" Then
                        CHK_FullCutLabel.Checked = True
                    Else
                        CHK_FullCutLabel.Checked = False
                    End If


                    If dr("flc_palletTag").ToString() = "O" Then
                        CHK_FullPalletTag.Checked = True
                    Else
                        CHK_FullPalletTag.Checked = False
                    End If




                    TXT_FullBallpenQty.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_FullRagsQty.Text = dr("flc_OLCragqty").ToString()


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
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    If dr("cht_GLflywheel").ToString() = "O" Then
                        CHK_ChallengeFlyWheel.Checked = True
                    Else
                        CHK_ChallengeFlyWheel.Checked = False
                    End If


                    If dr("cht_GLglugun1").ToString() = "O" Then
                        CHK_ChallengeGlueGun1.Checked = True
                    Else
                        CHK_ChallengeGlueGun1.Checked = False
                    End If



                    If dr("cht_GLglugun2").ToString() = "O" Then
                        CHK_ChallengeGlueGun2.Checked = True
                    Else
                        CHK_ChallengeGlueGun2.Checked = False
                    End If



                    If dr("cht_GLglugun3").ToString() = "O" Then
                        CHK_ChallengeGlueGun3.Checked = True
                    Else
                        CHK_ChallengeGlueGun3.Checked = False
                    End If



                    If dr("cht_GLglugun4").ToString() = "O" Then
                        CHK_ChallengeGlueGun4.Checked = True
                    Else
                        CHK_ChallengeGlueGun4.Checked = False
                    End If


                    If dr("cht_GLothmachine").ToString() = "O" Then
                        CHK_ChallengeNA.Checked = True
                    Else
                        CHK_ChallengeNA.Checked = False
                    End If


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


                    'B

                    If dr("gmp_SaniSortTable").ToString() = "O" Then
                        CHK_GoodJSortingTable.Checked = True
                    Else
                        CHK_GoodJSortingTable.Checked = False
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



                    If dr("gmp_SaniGluingUnit").ToString() = "O" Then
                        CHK_GoodGluingUnit.Checked = True
                    Else
                        CHK_GoodGluingUnit.Checked = False
                    End If





                    If dr("gmp_SaniFinalFold").ToString() = "O" Then
                        CHK_GoodFinalFolding.Checked = True
                    Else
                        CHK_GoodFinalFolding.Checked = False
                    End If


                    If dr("gmp_SaniConveyor").ToString() = "O" Then
                        CHK_GoodFConveyor.Checked = True
                    Else
                        CHK_GoodFConveyor.Checked = False
                    End If





                    If dr("gmp_SaniJPacker").ToString() = "O" Then
                        CHK_GoodJPacker.Checked = True
                    Else
                        CHK_GoodJPacker.Checked = False
                    End If



                    If dr("gmp_SaniBundlingMch").ToString() = "O" Then
                        CHK_GoodBundingMachine.Checked = True
                    Else
                        CHK_GoodBundingMachine.Checked = False
                    End If



                    If dr("gmp_SaniRotatingTbl").ToString() = "O" Then
                        CHK_GoodRotatingTable.Checked = True
                    Else
                        CHK_GoodRotatingTable.Checked = False
                    End If


                    If dr("gmp_SaniWeighScale").ToString() = "O" Then
                        CHK_GoodWeighingScale.Checked = True
                    Else
                        CHK_GoodWeighingScale.Checked = False
                    End If

                    'C


                    If dr("gmp_PrePropTagged").ToString() = "O" Then
                        CHK_GoodProperlyTagged.Checked = True
                    Else
                        CHK_GoodProperlyTagged.Checked = False
                    End If


                    If dr("gmp_PreInPlasticPallet").ToString() = "O" Then
                        CHk_GoodInPlasticPallets.Checked = True
                    Else
                        CHk_GoodInPlasticPallets.Checked = False
                    End If


                    If dr("gmp_PreFollowStdHeight").ToString() = "O" Then
                        CHK_GoodFollowingStandardPallet.Checked = True
                    Else
                        CHK_GoodFollowingStandardPallet.Checked = False
                    End If


                    'D

                    If dr("gmp_HygWearHairCovr").ToString() = "O" Then
                        CHK_GoodWearHairCover.Checked = True
                    Else
                        CHK_GoodWearHairCover.Checked = False
                    End If


                    If dr("gmp_HygPropUniform").ToString() = "O" Then
                        CHk_GoodWearsProperlyTuckedIn.Checked = True
                    Else
                        CHk_GoodWearsProperlyTuckedIn.Checked = False
                    End If


                    If dr("gmp_HygHandsWashed").ToString() = "O" Then
                        CHk_GoodHandWashed.Checked = True
                    Else
                        CHk_GoodHandWashed.Checked = False
                    End If

                    'D


                    If dr("gmp_SafeTools").ToString() = "O" Then
                        CHk_GoodTools.Checked = True
                    Else
                        CHk_GoodTools.Checked = False
                    End If



                    If dr("gmp_SafeEqpmt").ToString() = "O" Then
                        CHK_GoodEquipment.Checked = True
                    Else
                        CHK_GoodEquipment.Checked = False
                    End If



                    If dr("gmp_SafeCleaningMatls").ToString() = "O" Then
                        CHK_GoodCleaingMaterials.Checked = True
                    Else
                        CHK_GoodCleaingMaterials.Checked = False
                    End If



                    If dr("gmp_SafeWorkingDevices").ToString() = "O" Then
                        CHK_GoodSafetyDevicesWorking.Checked = True
                    Else
                        CHK_GoodSafetyDevicesWorking.Checked = False
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

            Dim UC_SuperIntendentGluing As New UC_SuperIntendentGluing
            UC_SuperIntendentGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentGluing.Show()
            UC_SuperIntendentGluing.Dock = DockStyle.Fill




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
        timer.Interval = 100 ' Adjust the interval as needed
        timer.Start()
    End Sub
End Class
