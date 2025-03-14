Imports System.Data.SqlClient

Public Class UC_SupervisorGluing

    Private Sub NumberChar(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub



    Private Sub SelectAllChecked()
        CHK_FullFeeder.Checked = True
        CHK_FullDelivery.Checked = True
        CHK_FullWasteBins.Checked = True
        CHK_FullRotatingTable.Checked = True
        CHK_FullWorkingTable.Checked = True

        CHK_FullGlue.Checked = True
        CHK_FullSticker.Checked = True
        CHK_FullKraftPaper.Checked = True
        CHK_FullCorrugatedBox.Checked = True
        CHK_FullCutLabel.Checked = True
        CHK_FullPalletTag.Checked = True

        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodOilChemical.Checked = True
        CHK_GoodForeignMaterials.Checked = True

        CHK_GoodJSortingTable.Checked = True
        CHK_GoodFeederUnit.Checked = True
        CHK_GoodPreFoldingUnit.Checked = True
        CHK_GoodGluingUnit.Checked = True
        CHK_GoodFinalFolding.Checked = True
        CHK_GoodFConveyor.Checked = True

        CHK_GoodJPacker.Checked = True
        CHK_GoodBundingMachine.Checked = True
        CHK_GoodRotatingTable.Checked = True
        CHK_GoodWeighingScale.Checked = True

        CHK_GoodProperlyTagged.Checked = True
        CHk_GoodInPlasticPallets.Checked = True
        CHK_GoodFollowingStandardPallet.Checked = True

        CHK_GoodWearHairCover.Checked = True
        CHk_GoodWearsProperlyTuckedIn.Checked = True
        CHk_GoodHandWashed.Checked = True

        CHk_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaingMaterials.Checked = True
        CHK_GoodSafetyDevicesWorking.Checked = True

        CHK_ChallengeFlyWheel.Checked = True
        CHK_ChallengeGlueGun1.Checked = True
        CHK_ChallengeGlueGun2.Checked = True
        CHK_ChallengeGlueGun3.Checked = True
        CHK_ChallengeGlueGun4.Checked = True
        CHK_ChallengeNA.Checked = True


        CHK_MachineFeederBell.Checked = True
        CHK_MachineTransportbelt.Checked = True
        CHK_MachineFoldingBelt.Checked = True
        CHK_MachineSquareness.Checked = True
        CHK_MachineLockingSystem.Checked = True
        CHK_MachineSlightlyOpened.Checked = True
        CHK_MachineOpeningForces.Checked = True
        CHK_MachineLow.Checked = True
        CHK_MachineMedium.Checked = True
        CHK_MachineHigh.Checked = True
        CHK_MachineFlywheel.Checked = True
        CHK_MachineBrush.Checked = True
        CHK_MachineGlueGun.Checked = True



    End Sub

    Private Sub SelectAllunChecked()
        CHK_FullFeeder.Checked = False
        CHK_FullDelivery.Checked = False
        CHK_FullWasteBins.Checked = False
        CHK_FullRotatingTable.Checked = False
        CHK_FullWorkingTable.Checked = False

        CHK_FullGlue.Checked = False
        CHK_FullSticker.Checked = False
        CHK_FullKraftPaper.Checked = False
        CHK_FullCorrugatedBox.Checked = False
        CHK_FullCutLabel.Checked = False
        CHK_FullPalletTag.Checked = False

        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False

        CHK_GoodJSortingTable.Checked = False
        CHK_GoodFeederUnit.Checked = False
        CHK_GoodPreFoldingUnit.Checked = False
        CHK_GoodGluingUnit.Checked = False
        CHK_GoodFinalFolding.Checked = False
        CHK_GoodFConveyor.Checked = False

        CHK_GoodJPacker.Checked = False
        CHK_GoodBundingMachine.Checked = False
        CHK_GoodRotatingTable.Checked = False
        CHK_GoodWeighingScale.Checked = False

        CHK_GoodProperlyTagged.Checked = False
        CHk_GoodInPlasticPallets.Checked = False
        CHK_GoodFollowingStandardPallet.Checked = False

        CHK_GoodWearHairCover.Checked = False
        CHk_GoodWearsProperlyTuckedIn.Checked = False
        CHk_GoodHandWashed.Checked = False

        CHk_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaingMaterials.Checked = False
        CHK_GoodSafetyDevicesWorking.Checked = False

        CHK_ChallengeFlyWheel.Checked = False
        CHK_ChallengeGlueGun1.Checked = False
        CHK_ChallengeGlueGun2.Checked = False
        CHK_ChallengeGlueGun3.Checked = False
        CHK_ChallengeGlueGun4.Checked = False
        CHK_ChallengeNA.Checked = False


        CHK_MachineFeederBell.Checked = False
        CHK_MachineTransportbelt.Checked = False
        CHK_MachineFoldingBelt.Checked = False
        CHK_MachineSquareness.Checked = False
        CHK_MachineLockingSystem.Checked = False
        CHK_MachineSlightlyOpened.Checked = False
        CHK_MachineOpeningForces.Checked = False
        CHK_MachineLow.Checked = False
        CHK_MachineMedium.Checked = False
        CHK_MachineHigh.Checked = False
        CHK_MachineFlywheel.Checked = False
        CHK_MachineBrush.Checked = False
        CHK_MachineGlueGun.Checked = False


    End Sub
    Private Sub EnabledSupervisorForm()
        CHK_SelectAll.Enabled = True

        CHK_FullFeeder.Enabled = True
        CHK_FullDelivery.Enabled = True
        CHK_FullWasteBins.Enabled = True
        CHK_FullRotatingTable.Enabled = True
        CHK_FullWorkingTable.Enabled = True

        CHK_FullGlue.Enabled = True
        CHK_FullSticker.Enabled = True
        CHK_FullKraftPaper.Enabled = True
        CHK_FullCorrugatedBox.Enabled = True
        CHK_FullCutLabel.Enabled = True
        CHK_FullPalletTag.Enabled = True

        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodOilChemical.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True

        CHK_GoodJSortingTable.Enabled = True
        CHK_GoodFeederUnit.Enabled = True
        CHK_GoodPreFoldingUnit.Enabled = True
        CHK_GoodGluingUnit.Enabled = True
        CHK_GoodFinalFolding.Enabled = True
        CHK_GoodFConveyor.Enabled = True

        CHK_GoodJPacker.Enabled = True
        CHK_GoodBundingMachine.Enabled = True
        CHK_GoodRotatingTable.Enabled = True
        CHK_GoodWeighingScale.Enabled = True

        CHK_GoodProperlyTagged.Enabled = True
        CHk_GoodInPlasticPallets.Enabled = True
        CHK_GoodFollowingStandardPallet.Enabled = True

        CHK_GoodWearHairCover.Enabled = True
        CHk_GoodWearsProperlyTuckedIn.Enabled = True
        CHk_GoodHandWashed.Enabled = True

        CHk_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaingMaterials.Enabled = True
        CHK_GoodSafetyDevicesWorking.Enabled = True

        CHK_ChallengeFlyWheel.Enabled = True
        CHK_ChallengeGlueGun1.Enabled = True
        CHK_ChallengeGlueGun2.Enabled = True
        CHK_ChallengeGlueGun3.Enabled = True
        CHK_ChallengeGlueGun4.Enabled = True
        CHK_ChallengeNA.Enabled = True



        CHK_MachineFeederBell.Enabled = True
        CHK_MachineTransportbelt.Enabled = True
        CHK_MachineFoldingBelt.Enabled = True
        CHK_MachineSquareness.Enabled = True
        CHK_MachineLockingSystem.Enabled = True
        CHK_MachineSlightlyOpened.Enabled = True
        CHK_MachineOpeningForces.Enabled = True
        CHK_MachineLow.Enabled = True
        CHK_MachineMedium.Enabled = True
        CHK_MachineHigh.Enabled = True
        CHK_MachineFlywheel.Enabled = True
        CHK_MachineBrush.Enabled = True
        CHK_MachineGlueGun.Enabled = True

        TXT_FullBallpenQty.Enabled = True
        TXT_FullRagsQty.Enabled = True
        CBO_AsstOperator1.Enabled = True
        TXT_AsstOperator1.Enabled = True
        DTP_AsstOperator1.Enabled = True
        CBO_Helper1.Enabled = True
        TXT_Helper1.Enabled = True
        DTPHelper1.Enabled = True

        TXT_StandardActualMM.Enabled = True
        TXT_MachineSlightlyOpened.Enabled = True
        TXT_MachineOpeningForces.Enabled = True

        TXT_MachineG1DotSize.Enabled = True
        TXT_MachineG2DotSize.Enabled = True
        TXT_MachineG3DotSize.Enabled = True
        TXT_MachineG4DotSize.Enabled = True


        TXT_MachineG1Start.Enabled = True
        TXT_MachineG2Start.Enabled = True
        TXT_MachineG3Start.Enabled = True
        TXT_MachineG4Start.Enabled = True


        TXT_MachineG1End.Enabled = True
        TXT_MachineG2End.Enabled = True
        TXT_MachineG3End.Enabled = True
        TXT_MachineG4End.Enabled = True

        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True


        TXT_MachineHSSActual.Enabled = True

        TXT_MachineActualGlueLap.Enabled = True
        TXT_MachineActualGlueWidth.Enabled = True


        RTB_JobInstruction.Enabled = True

        DTPOperator.Enabled = True

        BTN_Save_Supervisor.Enabled = True

    End Sub
    Private Sub DisabledSupervisorForm()

        CHK_SelectAll.Enabled = False

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


        CHK_MachineFeederBell.Enabled = False
        CHK_MachineTransportbelt.Enabled = False
        CHK_MachineFoldingBelt.Enabled = False
        CHK_MachineSquareness.Enabled = False
        CHK_MachineLockingSystem.Enabled = False
        CHK_MachineSlightlyOpened.Enabled = False
        CHK_MachineOpeningForces.Enabled = False
        CHK_MachineLow.Enabled = False
        CHK_MachineMedium.Enabled = False
        CHK_MachineHigh.Enabled = False
        CHK_MachineFlywheel.Enabled = False
        CHK_MachineBrush.Enabled = False
        CHK_MachineGlueGun.Enabled = False

        TXT_FullBallpenQty.Enabled = False
        TXT_FullRagsQty.Enabled = False
        CBO_AsstOperator1.Enabled = False
        TXT_AsstOperator1.Enabled = False
        DTP_AsstOperator1.Enabled = False
        CBO_Helper1.Enabled = False
        TXT_Helper1.Enabled = False
        DTPHelper1.Enabled = False

        TXT_StandardActualMM.Enabled = False
        TXT_MachineSlightlyOpened.Enabled = False
        TXT_MachineOpeningForces.Enabled = False


        TXT_MachineG1DotSize.Enabled = False
        TXT_MachineG2DotSize.Enabled = False
        TXT_MachineG3DotSize.Enabled = False
        TXT_MachineG4DotSize.Enabled = False


        TXT_MachineG1Start.Enabled = False
        TXT_MachineG2Start.Enabled = False
        TXT_MachineG3Start.Enabled = False
        TXT_MachineG4Start.Enabled = False



        TXT_MachineG1End.Enabled = False
        TXT_MachineG2End.Enabled = False
        TXT_MachineG3End.Enabled = False
        TXT_MachineG4End.Enabled = False

        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False


        TXT_MachineHSSActual.Enabled = False

        TXT_MachineActualGlueLap.Enabled = False
        TXT_MachineActualGlueWidth.Enabled = False

        RTB_JobInstruction.Enabled = False

        DTPOperator.Enabled = False

        BTN_Save_Supervisor.Enabled = False




    End Sub
    Private Sub UC_SupervisorGluing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then
            DisabledSupervisorForm()
        Else
            EnabledSupervisorForm()
        End If





        If position <> "Supervisor" Then
            BTN_Save_Supervisor.Visible = False

            CHK_SelectAll.Enabled = False

            BTN_Back.Visible = True

        End If

        If FRM_MonitoringChecklistMain.TXT_CreatedBy.Text <> "" Then

            If FRM_MonitoringChecklistMain.lbl_empname.Text <> FRM_MonitoringChecklistMain.TXT_CreatedBy.Text Then
                BTN_Save_Supervisor.Enabled = False
            End If
        End If



        DTPOperator.Format = DateTimePickerFormat.Custom
        DTPOperator.CustomFormat = "hh:mm tt"


        DTPHelper1.Format = DateTimePickerFormat.Custom
        DTPHelper1.CustomFormat = "hh:mm tt"



        DTP_AsstOperator1.Format = DateTimePickerFormat.Custom
        DTP_AsstOperator1.CustomFormat = "hh:mm tt"


        DTPOperator.Text = "12:00 AM"
        DTPHelper1.Text = "12:00 AM"

        DTP_AsstOperator1.Text = "12:00 AM"


        ' Optional: Set value to default time when no time is selected
        If DTPOperator.Value = DTPOperator.MinDate Then
            DTPOperator.Text = "12:00 AM"
        End If
        If DTPHelper1.Value = DTPHelper1.MinDate Then
            DTPHelper1.Text = "12:00 AM"
        End If

        If DTP_AsstOperator1.Value = DTP_AsstOperator1.MinDate Then
            DTP_AsstOperator1.Text = "12:00 AM"
        End If



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
                    'TXT_VerifiedSuperIntendent.Text = dr("VerifiedSupervisorName").ToString()


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



        TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text

        Dim helper1 As String = ""
        Dim AssOperator1 As String = ""




        Try

            OpenConnection()
            cmd.CommandText = "Select_sppmcJIC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    RTB_JobInstruction.Text = dr("jic_note").ToString()



                    TXT_OperatorNumSupervisor.Text = dr("jic_Operator").ToString()
                    AssOperator1 = dr("jic_AsstOper1").ToString()

                    helper1 = dr("jic_Helper1").ToString()
                    TXT_AsstOperator1.Text = AssOperator1

                    TXT_Helper1.Text = helper1


                    DTPOperator.Text = dr("jic_OperatorTime").ToString()
                    DTP_AsstOperator1.Text = dr("jic_AsstOper1Time").ToString()

                    DTPHelper1.Text = dr("jic_Helper1Time").ToString()
                    DTPHelper1.Text = dr("jic_Helper1Time").ToString()

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











        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", AssOperator1)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_AsstOperator1.Text = dr("Name")

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
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", helper1)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_Helper1.Text = dr("Name")

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
            cmd.CommandText = "Select_sppmcMSPA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then
                    'A

                    If dr("mspa_GLfdrbeltBBE").ToString() = "O" Then
                        CHK_MachineFeederBell.Checked = True
                    Else
                        CHK_MachineFeederBell.Checked = False
                    End If

                    If dr("mspa_GLftranbeltbox").ToString() = "O" Then
                        CHK_MachineTransportbelt.Checked = True
                    Else
                        CHK_MachineTransportbelt.Checked = False
                    End If

                    If dr("mspa_GLFoldbeltScrclr").ToString() = "O" Then
                        CHK_MachineFoldingBelt.Checked = True
                    Else
                        CHK_MachineFoldingBelt.Checked = False
                    End If

                    TXT_StandardActualMM.Text = dr("mspa_GLFoldbeltActual").ToString()



                    'B
                    If dr("mspa_GLBxSquare").ToString() = "O" Then
                        CHK_MachineSquareness.Checked = True
                    Else
                        CHK_MachineSquareness.Checked = False
                    End If


                    If dr("mspa_GLBxLockSys").ToString() = "O" Then
                        CHK_MachineLockingSystem.Checked = True
                    Else
                        CHK_MachineLockingSystem.Checked = False
                    End If


                    If dr("mspa_GLOpenCartn").ToString() = "O" Then
                        CHK_MachineSlightlyOpened.Checked = True
                    Else
                        CHK_MachineSlightlyOpened.Checked = False
                    End If



                    TXT_MachineSlightlyOpened.Text = dr("mspa_GLOpenCartnqty").ToString()

                    If dr("mspa_GLOpenforces").ToString() = "O" Then
                        CHK_MachineOpeningForces.Checked = True
                    Else
                        CHK_MachineOpeningForces.Checked = False
                    End If

                    TXT_MachineOpeningForces.Text = dr("mspa_GLOpenforceval").ToString()

                    'C
                    If dr("mspa_GLPRpressLow").ToString() = "O" Then
                        CHK_MachineLow.Checked = True
                    Else
                        CHK_MachineLow.Checked = False
                    End If

                    If dr("mspa_GLPRpressMed").ToString() = "O" Then
                        CHK_MachineMedium.Checked = True
                    Else
                        CHK_MachineMedium.Checked = False
                    End If

                    If dr("mspa_GLPRpressHigh").ToString() = "O" Then
                        CHK_MachineHigh.Checked = True
                    Else
                        CHK_MachineHigh.Checked = False
                    End If

                    If dr("mspa_GLFlywheel").ToString() = "O" Then
                        CHK_MachineFlywheel.Checked = True
                    Else
                        CHK_MachineFlywheel.Checked = False
                    End If

                    If dr("mspa_GLBrush").ToString() = "O" Then
                        CHK_MachineBrush.Checked = True
                    Else
                        CHK_MachineBrush.Checked = False
                    End If

                    'D
                    If dr("mspa_GLGLuegun").ToString() = "O" Then
                        CHK_MachineGlueGun.Checked = True
                    Else
                        CHK_MachineGlueGun.Checked = False
                    End If


                    TXT_MachineG1DotSize.Text = dr("mspa_GLG1Dotsize").ToString()
                    TXT_MachineG2DotSize.Text = dr("mspa_GLG2Dotsize").ToString()
                    TXT_MachineG3DotSize.Text = dr("mspa_GLG3Dotsize").ToString()
                    TXT_MachineG4DotSize.Text = dr("mspa_GLG4Dotsize").ToString()

                    TXT_MachineG1Start.Text = dr("mspa_GLG1LenStart").ToString()
                    TXT_MachineG2Start.Text = dr("mspa_GLG2LenStart").ToString()
                    TXT_MachineG3Start.Text = dr("mspa_GLG3LenStart").ToString()
                    TXT_MachineG4Start.Text = dr("mspa_GLG4LenStart").ToString()


                    TXT_MachineG1End.Text = dr("mspa_GLG1LenEnd").ToString()
                    TXT_MachineG2End.Text = dr("mspa_GLG2LenEnd").ToString()
                    TXT_MachineG3End.Text = dr("mspa_GLG3LenEnd").ToString()
                    TXT_MachineG4End.Text = dr("mspa_GLG4LenEnd").ToString()

                    TXT_MachineHSSActual.Text = dr("mspa_GLHSSAct").ToString()
                    TXT_MachineActualGlueLap.Text = dr("mspa_GLActGLuelap").ToString()
                    TXT_MachineActualGlueWidth.Text = dr("mspa_GLActGLuelwid").ToString()



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
            cmd.CommandText = "Select_sppmcROLIC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then
                    TXT_7BallpenQty.Text = dr("bpenqty").ToString()
                    TXT_7RagsQty.Text = dr("ragsqty").ToString()





                End If

                dr.Close()
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try






    End Sub

    Private Sub BTN_Save_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Save_Supervisor.Click


        'A

        Dim FullFeeder As String = ""
        Dim FullDelivery As String = ""
        Dim FullWasteBins As String = ""
        Dim FullRotatingTable As String = ""
        Dim FullWorkingTable As String = ""

        If CHK_FullFeeder.Checked Then
            FullFeeder = "O"
        Else
            FullFeeder = "X"
        End If


        If CHK_FullDelivery.Checked Then
            FullDelivery = "O"
        Else
            FullDelivery = "X"
        End If


        If CHK_FullWasteBins.Checked Then
            FullWasteBins = "O"
        Else
            FullWasteBins = "X"
        End If


        If CHK_FullRotatingTable.Checked Then
            FullRotatingTable = "O"
        Else
            FullRotatingTable = "X"
        End If


        If CHK_FullWorkingTable.Checked Then
            FullWorkingTable = "O"
        Else
            FullWorkingTable = "X"
        End If


        'B
        Dim FullGlue As String = ""
        Dim FullSticker As String = ""
        Dim FullKraftPaper As String = ""
        Dim FullCorrugatedBox As String = ""
        Dim FullCutLabel As String = ""
        Dim FullPalletTag As String = ""

        If CHK_FullGlue.Checked Then
            FullGlue = "O"
        Else
            FullGlue = "X"
        End If


        If CHK_FullSticker.Checked Then
            FullSticker = "O"
        Else
            FullSticker = "X"
        End If


        If CHK_FullKraftPaper.Checked Then
            FullKraftPaper = "O"
        Else
            FullKraftPaper = "X"
        End If


        If CHK_FullCorrugatedBox.Checked Then
            FullCorrugatedBox = "O"
        Else
            FullCorrugatedBox = "X"
        End If


        If CHK_FullCutLabel.Checked Then
            FullCutLabel = "O"
        Else
            FullCutLabel = "X"
        End If


        If CHK_FullPalletTag.Checked Then
            FullPalletTag = "O"
        Else
            FullPalletTag = "X"
        End If







        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcFLC"
            cmd.CommandType = CommandType.StoredProcedure

            ' Clear any existing parameters
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Update_sppmcFLC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@flc_cuttingtable", "")
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBins)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", FullSticker)
                cmd.Parameters.AddWithValue("@flc_kraftPaper", FullKraftPaper)
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", FullCorrugatedBox)
                cmd.Parameters.AddWithValue("@flc_cutLabel", FullCutLabel)
                cmd.Parameters.AddWithValue("@flc_palletTag", FullPalletTag)
                cmd.Parameters.AddWithValue("@flc_feeder", FullFeeder)
                cmd.Parameters.AddWithValue("@flc_delivery", FullDelivery)
                cmd.Parameters.AddWithValue("@flc_drawers", "")
                cmd.Parameters.AddWithValue("@flc_inks", "")
                cmd.Parameters.AddWithValue("@flc_varnish", "")
                cmd.Parameters.AddWithValue("@flc_foil", "")
                cmd.Parameters.AddWithValue("@flc_supplies", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitTop", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitSF", "")
                cmd.Parameters.AddWithValue("@flc_gluingUnit", "")
                cmd.Parameters.AddWithValue("@flc_glueBin", "")
                cmd.Parameters.AddWithValue("@flc_DeliveryUnit", "")
                cmd.Parameters.AddWithValue("@flc_viewingTable", "")
                cmd.Parameters.AddWithValue("@flc_stripping", "")
                cmd.Parameters.AddWithValue("@flc_diecutBlade", "")
                cmd.Parameters.AddWithValue("@flc_counterdie", "")
                cmd.Parameters.AddWithValue("@flc_embossingCliche", "")
                cmd.Parameters.AddWithValue("@flc_counterEmbossing", "")
                cmd.Parameters.AddWithValue("@flc_strippingBoard", "")
                cmd.Parameters.AddWithValue("@flc_strippingPins", "")
                cmd.Parameters.AddWithValue("@flc_stampingCliche", "")
                cmd.Parameters.AddWithValue("@flc_counterStamping", "")
                cmd.Parameters.AddWithValue("@flc_stampingFoil", "")
                cmd.Parameters.AddWithValue("@flc_wasteSack", "")
                cmd.Parameters.AddWithValue("@flc_pinBar", "")
                cmd.Parameters.AddWithValue("@flc_pressingTable", "")
                cmd.Parameters.AddWithValue("@flc_plasticPallets", "")
                cmd.Parameters.AddWithValue("@flc_rotatingTable", FullRotatingTable)
                cmd.Parameters.AddWithValue("@flc_workingTable", FullWorkingTable)
                cmd.Parameters.AddWithValue("@flc_Lifter", "")
                cmd.Parameters.AddWithValue("@flc_Others", "")
                cmd.Parameters.AddWithValue("@flc_glue", FullGlue)
                cmd.Parameters.AddWithValue("@flc_FinSpoilagePrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinProductPrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsNotReqd", "")
                cmd.Parameters.AddWithValue("@flc_FinQualityLimits", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsSupplies", "")
                cmd.Parameters.AddWithValue("@flc_FinRefDoc", "")
                cmd.Parameters.AddWithValue("@flc_proofTray", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", "")
                cmd.Parameters.AddWithValue("@flc_OffInkFr", "")
                cmd.Parameters.AddWithValue("@flc_OffInkTo", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilTo  ", "")


                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_FullBallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_FullRagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", "")
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", "")
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", "")
                cmd.Parameters.AddWithValue("@flc_OLCgluebottle", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersdesc", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersqty", "")
                cmd.Parameters.AddWithValue("@flc_chairs", "")
                cmd.Parameters.AddWithValue("@flc_OLCcotglovQty", "")
                cmd.ExecuteNonQuery()
                con.Close()



            Else
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Insert_sppmcFLC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@flc_cuttingtable", "")
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBins)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", FullSticker)
                cmd.Parameters.AddWithValue("@flc_kraftPaper", FullKraftPaper)
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", FullCorrugatedBox)
                cmd.Parameters.AddWithValue("@flc_cutLabel", FullCutLabel)
                cmd.Parameters.AddWithValue("@flc_palletTag", FullPalletTag)
                cmd.Parameters.AddWithValue("@flc_feeder", FullFeeder)
                cmd.Parameters.AddWithValue("@flc_delivery", FullDelivery)
                cmd.Parameters.AddWithValue("@flc_drawers", "")
                cmd.Parameters.AddWithValue("@flc_inks", "")
                cmd.Parameters.AddWithValue("@flc_varnish", "")
                cmd.Parameters.AddWithValue("@flc_foil", "")
                cmd.Parameters.AddWithValue("@flc_supplies", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitTop", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitSF", "")
                cmd.Parameters.AddWithValue("@flc_gluingUnit", "")
                cmd.Parameters.AddWithValue("@flc_glueBin", "")
                cmd.Parameters.AddWithValue("@flc_DeliveryUnit", "")
                cmd.Parameters.AddWithValue("@flc_viewingTable", "")
                cmd.Parameters.AddWithValue("@flc_stripping", "")
                cmd.Parameters.AddWithValue("@flc_diecutBlade", "")
                cmd.Parameters.AddWithValue("@flc_counterdie", "")
                cmd.Parameters.AddWithValue("@flc_embossingCliche", "")
                cmd.Parameters.AddWithValue("@flc_counterEmbossing", "")
                cmd.Parameters.AddWithValue("@flc_strippingBoard", "")
                cmd.Parameters.AddWithValue("@flc_strippingPins", "")
                cmd.Parameters.AddWithValue("@flc_stampingCliche", "")
                cmd.Parameters.AddWithValue("@flc_counterStamping", "")
                cmd.Parameters.AddWithValue("@flc_stampingFoil", "")
                cmd.Parameters.AddWithValue("@flc_wasteSack", "")
                cmd.Parameters.AddWithValue("@flc_pinBar", "")
                cmd.Parameters.AddWithValue("@flc_pressingTable", "")
                cmd.Parameters.AddWithValue("@flc_plasticPallets", "")
                cmd.Parameters.AddWithValue("@flc_rotatingTable", FullRotatingTable)
                cmd.Parameters.AddWithValue("@flc_workingTable", FullWorkingTable)
                cmd.Parameters.AddWithValue("@flc_Lifter", "")
                cmd.Parameters.AddWithValue("@flc_Others", "")
                cmd.Parameters.AddWithValue("@flc_glue", FullGlue)
                cmd.Parameters.AddWithValue("@flc_FinSpoilagePrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinProductPrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsNotReqd", "")
                cmd.Parameters.AddWithValue("@flc_FinQualityLimits", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsSupplies", "")
                cmd.Parameters.AddWithValue("@flc_FinRefDoc", "")
                cmd.Parameters.AddWithValue("@flc_proofTray", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", "")
                cmd.Parameters.AddWithValue("@flc_OffInkFr", "")
                cmd.Parameters.AddWithValue("@flc_OffInkTo", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilTo  ", "")

                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_FullBallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_FullRagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", "")
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", "")
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", "")
                cmd.Parameters.AddWithValue("@flc_OLCgluebottle", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersdesc", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersqty", "")
                cmd.Parameters.AddWithValue("@flc_chairs", "")
                cmd.Parameters.AddWithValue("@flc_OLCcotglovQty", "")
                cmd.ExecuteNonQuery()
                con.Close()

            End If
            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try




        'INSERTING TO GMP
        Dim GoodExcessiveDust As String = ""
        Dim GoodOilChemical As String = ""
        Dim GoodForeignMaterials As String = ""

        If CHK_GoodExcessiveDust.Checked Then
            GoodExcessiveDust = "O"
        Else
            GoodExcessiveDust = "X"
        End If


        If CHK_GoodOilChemical.Checked Then
            GoodOilChemical = "O"
        Else
            GoodOilChemical = "X"
        End If


        If CHK_GoodForeignMaterials.Checked Then
            GoodForeignMaterials = "O"
        Else
            GoodForeignMaterials = "X"
        End If



        Dim GoodSortingTable As String = ""
        Dim GoodFeederUnit As String = ""
        Dim GoodPreFoldingUnit As String = ""
        Dim GoodGluingUnit As String = ""
        Dim GoodFinalFolding As String = ""
        Dim GoodConveyor As String = ""



        If CHK_GoodJSortingTable.Checked Then
            GoodSortingTable = "O"
        Else
            GoodSortingTable = "X"
        End If



        If CHK_GoodFeederUnit.Checked Then
            GoodFeederUnit = "O"
        Else
            GoodFeederUnit = "X"
        End If



        If CHK_GoodPreFoldingUnit.Checked Then
            GoodPreFoldingUnit = "O"
        Else
            GoodPreFoldingUnit = "X"
        End If



        If CHK_GoodGluingUnit.Checked Then
            GoodGluingUnit = "O"
        Else
            GoodGluingUnit = "X"
        End If



        If CHK_GoodFinalFolding.Checked Then
            GoodFinalFolding = "O"
        Else
            GoodFinalFolding = "X"
        End If


        If CHK_GoodFConveyor.Checked Then
            GoodConveyor = "O"
        Else
            GoodConveyor = "X"
        End If



        Dim GoodJPacker As String = ""
        Dim GoodBundingMachine As String = ""
        Dim GoodRotatingTable As String = ""
        Dim GoodWeighingScale As String = ""


        If CHK_GoodJPacker.Checked Then
            GoodJPacker = "O"
        Else
            GoodJPacker = "X"
        End If


        If CHK_GoodBundingMachine.Checked Then
            GoodBundingMachine = "O"
        Else
            GoodBundingMachine = "X"
        End If



        If CHK_GoodRotatingTable.Checked Then
            GoodRotatingTable = "O"
        Else
            GoodRotatingTable = "X"
        End If

        If CHK_GoodWeighingScale.Checked Then
            GoodWeighingScale = "O"
        Else
            GoodWeighingScale = "X"
        End If



        Dim GoodProperlyTagged As String = ""
        Dim GoodInPlasticPalltes As String = ""
        Dim GoodInStandardPalletizingHeight As String = ""


        If CHK_GoodProperlyTagged.Checked Then
            GoodProperlyTagged = "O"
        Else
            GoodProperlyTagged = "X"
        End If


        If CHk_GoodInPlasticPallets.Checked Then
            GoodInPlasticPalltes = "O"
        Else
            GoodInPlasticPalltes = "X"
        End If


        If CHK_GoodFollowingStandardPallet.Checked Then
            GoodInStandardPalletizingHeight = "O"
        Else
            GoodInStandardPalletizingHeight = "X"
        End If









        Dim GoodWearHairCovers As String = ""
        Dim GoodWearProperlyTuckedIn As String = ""
        Dim GoodHandsWashed As String = ""



        If CHK_GoodWearHairCover.Checked Then
            GoodWearHairCovers = "O"
        Else
            GoodWearHairCovers = "X"
        End If



        If CHk_GoodWearsProperlyTuckedIn.Checked Then
            GoodWearProperlyTuckedIn = "O"
        Else
            GoodWearProperlyTuckedIn = "X"
        End If


        If CHk_GoodHandWashed.Checked Then
            GoodHandsWashed = "O"
        Else
            GoodHandsWashed = "X"
        End If




        Dim GoodTools As String = ""
        Dim GoodEquipment As String = ""
        Dim GoodCleaningMaterials As String = ""
        Dim GoodSafetyDevice As String = ""






        If CHk_GoodTools.Checked Then
            GoodTools = "O"
        Else
            GoodTools = "X"
        End If



        If CHK_GoodEquipment.Checked Then
            GoodEquipment = "O"
        Else
            GoodEquipment = "X"
        End If


        If CHK_GoodCleaingMaterials.Checked Then
            GoodCleaningMaterials = "O"
        Else
            GoodCleaningMaterials = "X"
        End If


        If CHK_GoodSafetyDevicesWorking.Checked Then
            GoodSafetyDevice = "O"
        Else
            GoodSafetyDevice = "X"
        End If







        Try

            OpenConnection()
            cmd.CommandText = "Select_sppmcGMP"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Update_sppmcGMP"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@gmp_NoExcessDustDirt", GoodExcessiveDust)
                cmd.Parameters.AddWithValue("@gmp_NoOilChemSpill", GoodOilChemical)
                cmd.Parameters.AddWithValue("@gmp_NoForeignMatls", GoodForeignMaterials)

                cmd.Parameters.AddWithValue("@gmp_SaniJoggerTable", "")

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTable", "")



                cmd.Parameters.AddWithValue("@gmp_SaniCuttingBlade", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCuttingTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniControlPanel", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRubberSucker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPaperSep", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGovfoot", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", "")
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTop", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederSF", "")
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", GoodConveyor)
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTiltTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBars", "")
                cmd.Parameters.AddWithValue("@gmp_SaniSortTable", GoodSortingTable)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederUnit", GoodFeederUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", GoodPreFoldingUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", GoodGluingUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", GoodFinalFolding)
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", GoodJPacker)
                cmd.Parameters.AddWithValue("@gmp_SaniBundlingMch", GoodBundingMachine)
                cmd.Parameters.AddWithValue("@gmp_SaniRotatingTbl", GoodRotatingTable)
                cmd.Parameters.AddWithValue("@gmp_SaniWeighScale", GoodWeighingScale)
                cmd.Parameters.AddWithValue("@gmp_PrePropTagged", GoodProperlyTagged)
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodInPlasticPalltes)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", "")
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodInStandardPalletizingHeight)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCovers)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandsWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", GoodTools)
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaningMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", GoodSafetyDevice)
                cmd.Parameters.AddWithValue("@ghk_FinNoExcDustDirt", "")
                cmd.Parameters.AddWithValue("@ghk_FinNoToolEqpt", "")
                cmd.Parameters.AddWithValue("@gmpCondBySV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                cmd.Parameters.AddWithValue("@gmpVerBySup", "")
                cmd.Parameters.AddWithValue("@gmp_Sanistation2", "")
                cmd.Parameters.AddWithValue("@gmp_Sanistation1", "")
                cmd.Parameters.AddWithValue("@gmp_SaniLiftsol#5", "")
                cmd.Parameters.AddWithValue("@gmp_SaniMachtable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStripPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPads", "")
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                dr.Close()
                con.Close()
                OpenConnection()
                cmd.CommandText = "Insert_sppmcGMP"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()


                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@gmp_NoExcessDustDirt", GoodExcessiveDust)
                cmd.Parameters.AddWithValue("@gmp_NoOilChemSpill", GoodOilChemical)
                cmd.Parameters.AddWithValue("@gmp_NoForeignMatls", GoodForeignMaterials)
                cmd.Parameters.AddWithValue("@gmp_SaniJoggerTable", "")

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTable", "")



                cmd.Parameters.AddWithValue("@gmp_SaniCuttingBlade", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCuttingTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniControlPanel", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRubberSucker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPaperSep", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGovfoot", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", "")
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTop", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederSF", "")
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", GoodConveyor)
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTiltTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBars", "")
                cmd.Parameters.AddWithValue("@gmp_SaniSortTable", GoodSortingTable)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederUnit", GoodFeederUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", GoodPreFoldingUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", GoodGluingUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", GoodFinalFolding)
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", GoodJPacker)
                cmd.Parameters.AddWithValue("@gmp_SaniBundlingMch", GoodBundingMachine)
                cmd.Parameters.AddWithValue("@gmp_SaniRotatingTbl", GoodRotatingTable)
                cmd.Parameters.AddWithValue("@gmp_SaniWeighScale", GoodWeighingScale)
                cmd.Parameters.AddWithValue("@gmp_PrePropTagged", GoodProperlyTagged)
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodInPlasticPalltes)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", "")
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodInStandardPalletizingHeight)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCovers)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandsWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", GoodTools)
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaningMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", GoodSafetyDevice)
                cmd.Parameters.AddWithValue("@ghk_FinNoExcDustDirt", "")
                cmd.Parameters.AddWithValue("@ghk_FinNoToolEqpt", "")
                cmd.Parameters.AddWithValue("@gmpCondBySV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                cmd.Parameters.AddWithValue("@gmpVerBySup", "")
                cmd.Parameters.AddWithValue("@gmp_Sanistation2", "")
                cmd.Parameters.AddWithValue("@gmp_Sanistation1", "")
                cmd.Parameters.AddWithValue("@gmp_SaniLiftsol#5", "")
                cmd.Parameters.AddWithValue("@gmp_SaniMachtable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStripPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPads", "")
                cmd.ExecuteNonQuery()
                con.Close()


            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try





        Dim ChallengeFlywheel As String = ""
        Dim ChallengeGlueGun1 As String = ""
        Dim ChallengeGlueGun2 As String = ""
        Dim ChallengeGlueGun3 As String = ""
        Dim ChallengeGlueGun4 As String = ""
        Dim ChallengeNA As String = ""





        If CHK_ChallengeFlyWheel.Checked Then
            ChallengeFlywheel = "O"
        Else
            ChallengeFlywheel = "X"
        End If



        If CHK_ChallengeGlueGun1.Checked Then
            ChallengeGlueGun1 = "O"
        Else
            ChallengeGlueGun1 = "X"
        End If


        If CHK_ChallengeGlueGun2.Checked Then
            ChallengeGlueGun2 = "O"
        Else
            ChallengeGlueGun2 = "X"
        End If


        If CHK_ChallengeGlueGun3.Checked Then
            ChallengeGlueGun3 = "O"
        Else
            ChallengeGlueGun3 = "X"
        End If


        If CHK_ChallengeGlueGun4.Checked Then
            ChallengeGlueGun4 = "O"
        Else
            ChallengeGlueGun4 = "X"
        End If


        If CHK_ChallengeNA.Checked Then
            ChallengeNA = "O"
        Else
            ChallengeNA = "X"
        End If







        Try

            OpenConnection()
            cmd.CommandText = "Select_sppmcCHT"
            cmd.CommandType = CommandType.StoredProcedure

            ' Clear any existing parameters
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Close()
                con.Close()


                OpenConnection()
                cmd.CommandText = "Update_sppmcCHT"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()


                cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@cht_GLflywheel", ChallengeFlywheel)
                cmd.Parameters.AddWithValue("@cht_GLglugun1", ChallengeGlueGun1)
                cmd.Parameters.AddWithValue("@cht_GLglugun2", ChallengeGlueGun2)
                cmd.Parameters.AddWithValue("@cht_GLglugun3", ChallengeGlueGun3)
                cmd.Parameters.AddWithValue("@cht_GLglugun4", ChallengeGlueGun4)
                cmd.Parameters.AddWithValue("@cht_QCCam1", "")
                cmd.Parameters.AddWithValue("@cht_QCCam2", "")
                cmd.Parameters.AddWithValue("@cht_QCCam3", "")
                cmd.Parameters.AddWithValue("@cht_QCCam4", "")
                cmd.Parameters.AddWithValue("@cht_QCSpot", "")
                cmd.Parameters.AddWithValue("@cht_QCStrk", "")
                cmd.Parameters.AddWithValue("@cht_QCReg", "")
                cmd.Parameters.AddWithValue("@cht_QCTxt", "")
                cmd.Parameters.AddWithValue("@cht_QCColor", "")
                cmd.Parameters.AddWithValue("@cht_QCC2ScrLine", "")
                cmd.Parameters.AddWithValue("@cht_QCFrntPanel", "")
                cmd.Parameters.AddWithValue("@cht_QCEmbos", "")
                cmd.Parameters.AddWithValue("@cht_QCDebos", "")
                cmd.Parameters.AddWithValue("@cht_QCUnvarnsh", "")
                cmd.Parameters.AddWithValue("@cht_QCC3ScrLine", "")
                cmd.Parameters.AddWithValue("@cht_QCBckwPrint", "")
                cmd.Parameters.AddWithValue("@cht_QCBckwOPrint", "")
                cmd.Parameters.AddWithValue("@cht_QCHotfoil", "")
                cmd.Parameters.AddWithValue("@cht_QCCldfoil", "")
                cmd.Parameters.AddWithValue("@cht_GLothmachine", ChallengeNA)
                cmd.ExecuteNonQuery()
                con.Close()

            Else
                dr.Close()
                con.Close()


                OpenConnection()
                cmd.CommandText = "Insert_sppmcCHT"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@cht_GLflywheel", ChallengeFlywheel)
                cmd.Parameters.AddWithValue("@cht_GLglugun1", ChallengeGlueGun1)
                cmd.Parameters.AddWithValue("@cht_GLglugun2", ChallengeGlueGun2)
                cmd.Parameters.AddWithValue("@cht_GLglugun3", ChallengeGlueGun3)
                cmd.Parameters.AddWithValue("@cht_GLglugun4", ChallengeGlueGun4)
                cmd.Parameters.AddWithValue("@cht_QCCam1", "")
                cmd.Parameters.AddWithValue("@cht_QCCam2", "")
                cmd.Parameters.AddWithValue("@cht_QCCam3", "")
                cmd.Parameters.AddWithValue("@cht_QCCam4", "")
                cmd.Parameters.AddWithValue("@cht_QCSpot", "")
                cmd.Parameters.AddWithValue("@cht_QCStrk", "")
                cmd.Parameters.AddWithValue("@cht_QCReg", "")
                cmd.Parameters.AddWithValue("@cht_QCTxt", "")
                cmd.Parameters.AddWithValue("@cht_QCColor", "")
                cmd.Parameters.AddWithValue("@cht_QCC2ScrLine", "")
                cmd.Parameters.AddWithValue("@cht_QCFrntPanel", "")
                cmd.Parameters.AddWithValue("@cht_QCEmbos", "")
                cmd.Parameters.AddWithValue("@cht_QCDebos", "")
                cmd.Parameters.AddWithValue("@cht_QCUnvarnsh", "")
                cmd.Parameters.AddWithValue("@cht_QCC3ScrLine", "")
                cmd.Parameters.AddWithValue("@cht_QCBckwPrint", "")
                cmd.Parameters.AddWithValue("@cht_QCBckwOPrint", "")
                cmd.Parameters.AddWithValue("@cht_QCHotfoil", "")
                cmd.Parameters.AddWithValue("@cht_QCCldfoil", "")
                cmd.Parameters.AddWithValue("@cht_GLothmachine", ChallengeNA)
                cmd.ExecuteNonQuery()
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
            'insert JIC


            OpenConnection()
            cmd.CommandText = "Select_sppmcJIC"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Update_sppmcJIC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@jic_note", RTB_JobInstruction.Text)
                cmd.Parameters.AddWithValue("@jic_Operator", TXT_OperatorNumSupervisor.Text)
                cmd.Parameters.AddWithValue("@jic_Helper", "")
                cmd.Parameters.AddWithValue("@jic_Helper1", TXT_Helper1.Text)
                cmd.Parameters.AddWithValue("@jic_Helper2", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1", TXT_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2", "")
                cmd.Parameters.AddWithValue("@jic_ConductedBySV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                cmd.Parameters.AddWithValue("@jic_FIWrkInst", "")
                cmd.Parameters.AddWithValue("@jic_FIWrkArea", "")
                cmd.Parameters.AddWithValue("@jic_FITimeStart", "")
                cmd.Parameters.AddWithValue("@jic_FITimeEnd", "")
                cmd.Parameters.AddWithValue("@jic_FITotTime", "")
                cmd.Parameters.AddWithValue("@jic_FIManHr", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdr", "")
                cmd.Parameters.AddWithValue("@jic_FIFeeder", "")
                cmd.Parameters.AddWithValue("@jic_FIPicker", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker1", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker2", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker3", "")
                cmd.Parameters.AddWithValue("@jic_FISorter1", "")
                cmd.Parameters.AddWithValue("@jic_FISorter2", "")
                cmd.Parameters.AddWithValue("@jic_FISorter3", "")
                cmd.Parameters.AddWithValue("@jic_FISorter4", "")
                cmd.Parameters.AddWithValue("@jic_FISorter5", "")
                cmd.Parameters.AddWithValue("@jic_FISorter6", "")
                cmd.Parameters.AddWithValue("@jic_FISorter7", "")
                cmd.Parameters.AddWithValue("@jic_FISorter8", "")
                cmd.Parameters.AddWithValue("@jic_FISorter9", "")
                cmd.Parameters.AddWithValue("@jic_FISorter10", "")
                cmd.Parameters.AddWithValue("@jic_FISorter11", "")
                cmd.Parameters.AddWithValue("@jic_OperatorTime", DTPOperator.Text)
                cmd.Parameters.AddWithValue("@jic_Helper1Time", DTPHelper1.Text)
                cmd.Parameters.AddWithValue("@jic_Helper2Time", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", DTP_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2Time", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdrStart", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdrEnd", "")
                cmd.Parameters.AddWithValue("@jic_FIFeederStart", "")
                cmd.Parameters.AddWithValue("@jic_FIFeederEnd", "")
                cmd.Parameters.AddWithValue("@jic_FIPickerStart", "")
                cmd.Parameters.AddWithValue("@jic_FIPickerEnd", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker1End", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker1Start", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker2End", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker2Start", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker3End", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker3Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter10End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter10Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter11End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter11Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter1End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter1Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter2End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter2Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter3End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter3Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter4End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter4Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter5End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter5Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter6End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter6Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter7End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter7Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter8End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter8Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter9End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter9Start", "")
                cmd.Parameters.AddWithValue("@jic_FIStickrqty", "")
                cmd.Parameters.AddWithValue("@jic_FICutoutlbl", "")
                cmd.Parameters.AddWithValue("@jic_FIQtyperpk", "")


                cmd.ExecuteNonQuery()
                con.Close()

            Else
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Insert_sppmcJIC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@jic_note", RTB_JobInstruction.Text)
                cmd.Parameters.AddWithValue("@jic_Operator", TXT_OperatorNumSupervisor.Text)
                cmd.Parameters.AddWithValue("@jic_Helper", "")
                cmd.Parameters.AddWithValue("@jic_Helper1", TXT_Helper1.Text)
                cmd.Parameters.AddWithValue("@jic_Helper2", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1", TXT_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2", "")
                cmd.Parameters.AddWithValue("@jic_ConductedBySV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                cmd.Parameters.AddWithValue("@jic_FIWrkInst", "")
                cmd.Parameters.AddWithValue("@jic_FIWrkArea", "")
                cmd.Parameters.AddWithValue("@jic_FITimeStart", "")
                cmd.Parameters.AddWithValue("@jic_FITimeEnd", "")
                cmd.Parameters.AddWithValue("@jic_FITotTime", "")
                cmd.Parameters.AddWithValue("@jic_FIManHr", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdr", "")
                cmd.Parameters.AddWithValue("@jic_FIFeeder", "")
                cmd.Parameters.AddWithValue("@jic_FIPicker", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker1", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker2", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker3", "")
                cmd.Parameters.AddWithValue("@jic_FISorter1", "")
                cmd.Parameters.AddWithValue("@jic_FISorter2", "")
                cmd.Parameters.AddWithValue("@jic_FISorter3", "")
                cmd.Parameters.AddWithValue("@jic_FISorter4", "")
                cmd.Parameters.AddWithValue("@jic_FISorter5", "")
                cmd.Parameters.AddWithValue("@jic_FISorter6", "")
                cmd.Parameters.AddWithValue("@jic_FISorter7", "")
                cmd.Parameters.AddWithValue("@jic_FISorter8", "")
                cmd.Parameters.AddWithValue("@jic_FISorter9", "")
                cmd.Parameters.AddWithValue("@jic_FISorter10", "")
                cmd.Parameters.AddWithValue("@jic_FISorter11", "")
                cmd.Parameters.AddWithValue("@jic_OperatorTime", DTPOperator.Text)
                cmd.Parameters.AddWithValue("@jic_Helper1Time", DTPHelper1.Text)
                cmd.Parameters.AddWithValue("@jic_Helper2Time", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", DTP_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2Time", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdrStart", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdrEnd", "")
                cmd.Parameters.AddWithValue("@jic_FIFeederStart", "")
                cmd.Parameters.AddWithValue("@jic_FIFeederEnd", "")
                cmd.Parameters.AddWithValue("@jic_FIPickerStart", "")
                cmd.Parameters.AddWithValue("@jic_FIPickerEnd", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker1End", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker1Start", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker2End", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker2Start", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker3End", "")
                cmd.Parameters.AddWithValue("@jic_FIPacker3Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter10End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter10Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter11End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter11Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter1End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter1Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter2End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter2Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter3End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter3Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter4End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter4Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter5End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter5Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter6End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter6Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter7End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter7Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter8End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter8Start", "")
                cmd.Parameters.AddWithValue("@jic_FISorter9End", "")
                cmd.Parameters.AddWithValue("@jic_FISorter9Start", "")
                cmd.Parameters.AddWithValue("@jic_FIStickrqty", "")
                cmd.Parameters.AddWithValue("@jic_FICutoutlbl", "")
                cmd.Parameters.AddWithValue("@jic_FIQtyperpk", "")

                cmd.ExecuteNonQuery()
                con.Close()


            End If
            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try






        Dim selectedMachineFeederBell As String = ""
        Dim selectedMachineTransportbelt As String = ""
        Dim selectedMachineFoldingBelt As String = ""
        Dim StandardActualMMDecimal As Double

        If CHK_MachineFeederBell.Checked Then
            selectedMachineFeederBell = "O"
        Else
            selectedMachineFeederBell = "X"
        End If

        If CHK_MachineTransportbelt.Checked Then
            selectedMachineTransportbelt = "O"
        Else
            selectedMachineTransportbelt = "X"
        End If

        If CHK_MachineFoldingBelt.Checked Then
            selectedMachineFoldingBelt = "O"
        Else
            selectedMachineFoldingBelt = "X"
        End If




        Double.TryParse(TXT_StandardActualMM.Text, StandardActualMMDecimal)






        Dim selectedMachineSquareness As String = ""
        Dim selectedMachineLockingSystem As String = ""
        Dim selectedMachineSlightlyOpened As String = ""
        Dim selectedMachineOpeningForces As String = ""
        Dim MachineSlightlyOpenedDecimal As Double
        Dim MachineOpeningForcesDecimal As Double

        If CHK_MachineSquareness.Checked Then
            selectedMachineSquareness = "O"
        Else
            selectedMachineSquareness = "X"
        End If

        If CHK_MachineLockingSystem.Checked Then
            selectedMachineLockingSystem = "O"
        Else
            selectedMachineLockingSystem = "X"
        End If

        If CHK_MachineSlightlyOpened.Checked Then
            selectedMachineSlightlyOpened = "O"
        Else
            selectedMachineSlightlyOpened = "X"
        End If

        If CHK_MachineOpeningForces.Checked Then
            selectedMachineOpeningForces = "O"
        Else
            selectedMachineOpeningForces = "X"
        End If


        Double.TryParse(TXT_MachineSlightlyOpened.Text, MachineSlightlyOpenedDecimal)
        Double.TryParse(TXT_MachineOpeningForces.Text, MachineOpeningForcesDecimal)








        Dim SelectedMachineLow As String = ""
        Dim SelectedMachineMedium As String = ""
        Dim SelectedMachineHigh As String = ""
        Dim SelectedMachineFlywheel As String = ""
        Dim SelectedMachineBrush As String = ""

        If CHK_MachineLow.Checked Then
            SelectedMachineLow = "O"
        Else
            SelectedMachineLow = "X"
        End If

        If CHK_MachineMedium.Checked Then
            SelectedMachineMedium = "O"
        Else
            SelectedMachineMedium = "X"
        End If

        If CHK_MachineHigh.Checked Then
            SelectedMachineHigh = "O"
        Else
            SelectedMachineHigh = "X"
        End If

        If CHK_MachineFlywheel.Checked Then
            SelectedMachineFlywheel = "O"
        Else
            SelectedMachineFlywheel = "X"
        End If

        If CHK_MachineBrush.Checked Then
            SelectedMachineBrush = "O"
        Else
            SelectedMachineBrush = "X"
        End If


        Dim SelectedMachineGlueGun As String = ""

        If CHK_MachineGlueGun.Checked Then
            SelectedMachineGlueGun = "O"
        Else
            SelectedMachineGlueGun = "X"
        End If

        'D


        Dim G1DotsizeDecimal As Double
        Dim G2DotsizeDecimal As Double
        Dim G3DotsizeDecimal As Double
        Dim G4DotsizeDecimal As Double



        Double.TryParse(TXT_MachineG1DotSize.Text, G1DotsizeDecimal)
        Double.TryParse(TXT_MachineG2DotSize.Text, G2DotsizeDecimal)
        Double.TryParse(TXT_MachineG3DotSize.Text, G3DotsizeDecimal)
        Double.TryParse(TXT_MachineG4DotSize.Text, G4DotsizeDecimal)




        Dim G1StartDecimal As Double
        Dim G2StartDecimal As Double
        Dim G3StartDecimal As Double
        Dim G4StartDecimal As Double



        Double.TryParse(TXT_MachineG1Start.Text, G1StartDecimal)
        Double.TryParse(TXT_MachineG2Start.Text, G2StartDecimal)
        Double.TryParse(TXT_MachineG3Start.Text, G3StartDecimal)
        Double.TryParse(TXT_MachineG4Start.Text, G4StartDecimal)


        Dim G1EndDecimal As Double
        Dim G2EndDecimal As Double
        Dim G3EndDecimal As Double
        Dim G4EndDecimal As Double



        Double.TryParse(TXT_MachineG1End.Text, G1EndDecimal)
        Double.TryParse(TXT_MachineG2End.Text, G2EndDecimal)
        Double.TryParse(TXT_MachineG3End.Text, G3EndDecimal)
        Double.TryParse(TXT_MachineG4End.Text, G4EndDecimal)


        Dim HSSActualDecimal As Double
        Dim ActualGlueLapDecimal As Double
        Dim ActualGlueWidthDecimal As Double




        Double.TryParse(TXT_MachineHSSActual.Text, HSSActualDecimal)
        Double.TryParse(TXT_MachineActualGlueLap.Text, ActualGlueLapDecimal)
        Double.TryParse(TXT_MachineActualGlueWidth.Text, ActualGlueWidthDecimal)



        Try

            OpenConnection()
            cmd.CommandText = "Select_sppmcMSPA"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Update_sppmcMSPA"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@mspa_CUGDShort", "")
                cmd.Parameters.AddWithValue("@mspa_CutGDLong", "")
                cmd.Parameters.AddWithValue("@mspa_CUBlGreasefree", "")
                cmd.Parameters.AddWithValue("@mspa_CUBlChippedOff", "")
                cmd.Parameters.AddWithValue("@mspa_CUSquareAllSh", "")
                cmd.Parameters.AddWithValue("@mspa_CUSquareAllSide", "")
                cmd.Parameters.AddWithValue("@mspa_CUChkUpsOuts", "")
                cmd.Parameters.AddWithValue("@mspa_CUChkDim1", 0.00)
                cmd.Parameters.AddWithValue("@mspa_CUChkDim2", 0.00)
                cmd.Parameters.AddWithValue("@mspa_OFSGOperator", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGDrive", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGRollGuide", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA1", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA2", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA3", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA4", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA5", "")
                cmd.Parameters.AddWithValue("@mspa_OFDFMechanic", "")
                cmd.Parameters.AddWithValue("@mspa_OFDFUltrasonic", "")
                cmd.Parameters.AddWithValue("@mspa_OFUABBE", "")
                cmd.Parameters.AddWithValue("@mspa_OFUAFlap", "")
                cmd.Parameters.AddWithValue("@mspa_OFUAGluelap", "")
                cmd.Parameters.AddWithValue("@mspa_OFGDShort", "")
                cmd.Parameters.AddWithValue("@mspa_OFGDLong", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1Varnish", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry3", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry4", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraAnilox", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2Varnish", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry3", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry4", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraAnilox", "")
                cmd.Parameters.AddWithValue("@mspa_OFEndPress1", "")
                cmd.Parameters.AddWithValue("@mspa_OFEndPress2", "")
                cmd.Parameters.AddWithValue("@mspa_OFEndPress3", "")
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrType", "")
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrSet", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkUntTemp", "")
                cmd.Parameters.AddWithValue("@mspa_LAFluteVert", "")
                cmd.Parameters.AddWithValue("@mspa_LAFluteHor", "")
                cmd.Parameters.AddWithValue("@mspa_LAEFlute", "")
                cmd.Parameters.AddWithValue("@mspa_LACFlute", "")
                cmd.Parameters.AddWithValue("@mspa_LABFlute", "")
                cmd.Parameters.AddWithValue("@mspa_LASFBdim1", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LASFBdim2", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAFGTopsh", "")
                cmd.Parameters.AddWithValue("@mspa_LAFGSF", "")
                cmd.Parameters.AddWithValue("@mspa_LAFGBottsh", "")
                cmd.Parameters.AddWithValue("@mspa_LAFGBottshs", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LASGOper", "")
                cmd.Parameters.AddWithValue("@mspa_LASGDrive", "")
                cmd.Parameters.AddWithValue("@mspa_LAThickTar", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAThickAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAMoistTar", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAMoistAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LANoExcGlu", "")
                cmd.Parameters.AddWithValue("@mspa_LANoWkGlu", "")
                cmd.Parameters.AddWithValue("@mspa_LANoDWarp", "")
                cmd.Parameters.AddWithValue("@mspa_LANoUWarp", "")
                cmd.Parameters.AddWithValue("@mspa_QCPprFeed", "")
                cmd.Parameters.AddWithValue("@mspa_QCInpSamp", "")
                cmd.Parameters.AddWithValue("@mspa_QCLwrUprLmt", "")
                cmd.Parameters.AddWithValue("@mspa_QCSpotSize", "")
                cmd.Parameters.AddWithValue("@mspa_QCInsScope", "")
                cmd.Parameters.AddWithValue("@mspa_QCTracrCode", "")
                cmd.Parameters.AddWithValue("@mspa_QCTrnsprtGuid", "")
                cmd.Parameters.AddWithValue("@mspa_QCBlwers", "")
                cmd.Parameters.AddWithValue("@mspa_Dcorrdiecut", "")
                cmd.Parameters.AddWithValue("@mspa_Ddiecutcode", "")
                cmd.Parameters.AddWithValue("@mspa_Dcorrdcblade", "")
                cmd.Parameters.AddWithValue("@mspa_Dbxfuncnlock", "")
                cmd.Parameters.AddWithValue("@mspa_Dcutedge", "")
                cmd.Parameters.AddWithValue("@mspa_DEmbcliche", "")
                cmd.Parameters.AddWithValue("@mspa_DEclicht5mm", "")
                cmd.Parameters.AddWithValue("@mspa_DEclichht", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DEmboutput", "")
                cmd.Parameters.AddWithValue("@mspa_DcountrEmbTh", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DCorrStripBrd", "")
                cmd.Parameters.AddWithValue("@mspa_DCorrWknife", "")
                cmd.Parameters.AddWithValue("@mspa_DCorrpinbarPos", "")
                cmd.Parameters.AddWithValue("@mspa_DStmpclichvsfilm", "")
                cmd.Parameters.AddWithValue("@mspa_DStClichHt7mm", "")
                cmd.Parameters.AddWithValue("@mspa_DStClichHt", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DStmpingOutput", "")
                cmd.Parameters.AddWithValue("@mspa_DcountrStmpTh", 0.00)
                cmd.Parameters.AddWithValue("@mspa_Dfoilcolorsize", "")
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp110", "")
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DScorbndratioAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DPunchPressImpAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DSubstThickn", 0.00)
                cmd.Parameters.AddWithValue("@mspa_STConPinplatespecs", "")
                cmd.Parameters.AddWithValue("@mspa_STConPrintlayout", "")
                cmd.Parameters.AddWithValue("@mspa_STConGMPstd", "")
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#ups", "")
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#Pnum", "")
                cmd.Parameters.AddWithValue("@mspa_GLfdrbeltBBE", selectedMachineFeederBell)
                cmd.Parameters.AddWithValue("@mspa_GLftranbeltbox", selectedMachineTransportbelt)
                cmd.Parameters.AddWithValue("@mspa_GLBxSquare", selectedMachineSquareness)
                cmd.Parameters.AddWithValue("@mspa_GLBxLockSys", selectedMachineLockingSystem)
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartn", selectedMachineSlightlyOpened)
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartnqty", MachineSlightlyOpenedDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforces", selectedMachineOpeningForces)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforceval", MachineOpeningForcesDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLFlywheel", SelectedMachineFlywheel)
                cmd.Parameters.AddWithValue("@mspa_GLGLuegun", SelectedMachineGlueGun)
                cmd.Parameters.AddWithValue("@mspa_GLHSSAct", HSSActualDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelap", ActualGlueLapDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelwid", ActualGlueWidthDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1Dotsize", G1DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenStart", G1StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenEnd", G1EndDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG2Dotsize", G2DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenStart", G2StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenEnd", G2EndDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG3Dotsize", G3DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenStart", G3StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenEnd", G3EndDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG4Dotsize", G4DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenStart", G4StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenEnd", G4EndDecimal)



                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltScrclr", selectedMachineFoldingBelt)
                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltActual", StandardActualMMDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressLow", SelectedMachineLow)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressMed", SelectedMachineMedium)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressHigh", SelectedMachineHigh)
                cmd.Parameters.AddWithValue("@mspa_GLBrush", SelectedMachineBrush)
                cmd.Parameters.AddWithValue("@mspa_GLFeedrvacuum", "")
                cmd.Parameters.AddWithValue("@mspa_GLPressarm", "")

                cmd.Parameters.AddWithValue("@mspa_GLS1G1startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_Glcold", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLhot", 0.00)





                cmd.Parameters.AddWithValue("@mspa_Operator", "")
                cmd.Parameters.AddWithValue("@mspa_AsstOper1", "")
                cmd.Parameters.AddWithValue("@mspa_AsstOper2", "")
                cmd.Parameters.AddWithValue("@mspa_Feedrman1", "")
                cmd.Parameters.AddWithValue("@mspa_Feedrman2", "")
                cmd.Parameters.AddWithValue("@mspa_CondBySV", "")
                cmd.Parameters.AddWithValue("@mspa_Helpr1", "")

                cmd.Parameters.AddWithValue("@mspa_OFColdAir", 0.00)
                cmd.Parameters.AddWithValue("@mspa_OFSFacfybar", "")
                cmd.Parameters.AddWithValue("@mspa_OFSFsecmatrix", "")
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlock", "")
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlockval", "")

                cmd.Parameters.AddWithValue("@mspa_SDboth", "")
                cmd.Parameters.AddWithValue("@mspa_SDsideA", "")
                cmd.Parameters.AddWithValue("@mspa_SDsideB", "")
                cmd.Parameters.AddWithValue("@mspa_SDsimplex", "")
                cmd.Parameters.AddWithValue("@mspa_PMmulshot", "")
                cmd.Parameters.AddWithValue("@mspa_PM1shot", "")
                cmd.Parameters.AddWithValue("@mspa_CPinhertcolor", "")
                cmd.Parameters.AddWithValue("@mspa_SUdesc", "")
                cmd.Parameters.AddWithValue("@mspa_SUweight", "")
                cmd.Parameters.AddWithValue("@mspa_SUthickness", "")
                cmd.Parameters.AddWithValue("@mspa_GDShort", "")
                cmd.Parameters.AddWithValue("@mspa_GDLong", "")
                cmd.Parameters.AddWithValue("@mspa_SAfront", "")
                cmd.Parameters.AddWithValue("@mspa_SArear", "")
                cmd.Parameters.AddWithValue("@mspa_SAcollate", "")
                cmd.Parameters.AddWithValue("@mspa_SJFLFU", "")
                cmd.Parameters.AddWithValue("@mspa_SJFLFD", "")
                cmd.Parameters.AddWithValue("@mspa_SJLFFU", "")
                cmd.Parameters.AddWithValue("@mspa_SJLFFD", "")
                cmd.Parameters.AddWithValue("@mspa_GLglossy", "")
                cmd.Parameters.AddWithValue("@mspa_GLsemimatte", "")
                cmd.Parameters.AddWithValue("@mspa_GLmatte", "")
                cmd.Parameters.AddWithValue("@mspa_IPmirror", "")
                cmd.Parameters.AddWithValue("@mspa_IPnormal", "")
                cmd.Parameters.AddWithValue("@mspa_IProtate", "")
                cmd.Parameters.AddWithValue("@mspa_IPtumble", "")
                cmd.Parameters.AddWithValue("@mspa_CCLUTname", "")
                cmd.Parameters.AddWithValue("@mspa_CCcontrast", "")
                cmd.Parameters.AddWithValue("@mspa_CCbrightness", "")
                cmd.Parameters.AddWithValue("@mspa_CCdot50per", "")
                cmd.Parameters.AddWithValue("@mspa_CCopticdenadj", "")
                cmd.Parameters.AddWithValue("@mspa_CCC1", "")
                cmd.Parameters.AddWithValue("@mspa_CCC2", "")
                cmd.Parameters.AddWithValue("@mspa_CCC3", "")
                cmd.Parameters.AddWithValue("@mspa_CCC4", "")
                cmd.Parameters.AddWithValue("@mspa_CCC5", "")
                cmd.Parameters.AddWithValue("@mspa_CCM1", "")
                cmd.Parameters.AddWithValue("@mspa_CCM2", "")
                cmd.Parameters.AddWithValue("@mspa_CCM3", "")
                cmd.Parameters.AddWithValue("@mspa_CCM4", "")
                cmd.Parameters.AddWithValue("@mspa_CCM5", "")
                cmd.Parameters.AddWithValue("@mspa_CCY1", "")
                cmd.Parameters.AddWithValue("@mspa_CCY2", "")
                cmd.Parameters.AddWithValue("@mspa_CCY3", "")
                cmd.Parameters.AddWithValue("@mspa_CCY4", "")
                cmd.Parameters.AddWithValue("@mspa_CCY5", "")
                cmd.Parameters.AddWithValue("@mspa_CCK1", "")
                cmd.Parameters.AddWithValue("@mspa_CCK2", "")
                cmd.Parameters.AddWithValue("@mspa_CCK3", "")
                cmd.Parameters.AddWithValue("@mspa_CCK4", "")
                cmd.Parameters.AddWithValue("@mspa_CCK5", "")
                cmd.Parameters.AddWithValue("@mspa_CCO1", "")
                cmd.Parameters.AddWithValue("@mspa_CCO2", "")
                cmd.Parameters.AddWithValue("@mspa_CCO3", "")
                cmd.Parameters.AddWithValue("@mspa_CCO4", "")
                cmd.Parameters.AddWithValue("@mspa_CCO5", "")
                cmd.Parameters.AddWithValue("@mspa_CCG1", "")
                cmd.Parameters.AddWithValue("@mspa_CCG2", "")
                cmd.Parameters.AddWithValue("@mspa_CCG3", "")
                cmd.Parameters.AddWithValue("@mspa_CCG4", "")
                cmd.Parameters.AddWithValue("@mspa_CCG5", "")
                cmd.Parameters.AddWithValue("@mspa_CCV1", "")
                cmd.Parameters.AddWithValue("@mspa_CCV2", "")
                cmd.Parameters.AddWithValue("@mspa_CCV3", "")
                cmd.Parameters.AddWithValue("@mspa_CCV4", "")
                cmd.Parameters.AddWithValue("@mspa_CCV5", "")
                cmd.Parameters.AddWithValue("@mspa_CATP", "")
                cmd.Parameters.AddWithValue("@mspa_VerBySV", "")


                cmd.ExecuteNonQuery()
                con.Close()





            Else
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Insert_sppmcMSPA"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@mspa_CUGDShort", "")
                cmd.Parameters.AddWithValue("@mspa_CutGDLong", "")
                cmd.Parameters.AddWithValue("@mspa_CUBlGreasefree", "")
                cmd.Parameters.AddWithValue("@mspa_CUBlChippedOff", "")
                cmd.Parameters.AddWithValue("@mspa_CUSquareAllSh", "")
                cmd.Parameters.AddWithValue("@mspa_CUSquareAllSide", "")
                cmd.Parameters.AddWithValue("@mspa_CUChkUpsOuts", "")
                cmd.Parameters.AddWithValue("@mspa_CUChkDim1", 0.00)
                cmd.Parameters.AddWithValue("@mspa_CUChkDim2", 0.00)
                cmd.Parameters.AddWithValue("@mspa_OFSGOperator", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGDrive", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGRollGuide", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA1", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA2", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA3", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA4", "")
                cmd.Parameters.AddWithValue("@mspa_OFSGA5", "")
                cmd.Parameters.AddWithValue("@mspa_OFDFMechanic", "")
                cmd.Parameters.AddWithValue("@mspa_OFDFUltrasonic", "")
                cmd.Parameters.AddWithValue("@mspa_OFUABBE", "")
                cmd.Parameters.AddWithValue("@mspa_OFUAFlap", "")
                cmd.Parameters.AddWithValue("@mspa_OFUAGluelap", "")
                cmd.Parameters.AddWithValue("@mspa_OFGDShort", "")
                cmd.Parameters.AddWithValue("@mspa_OFGDLong", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFColorPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU1", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU2", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU3", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU4", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU5", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU6", "")
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU7", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1Varnish", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry3", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry4", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraAnilox", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2Varnish", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry3", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry4", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry1", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry2", "")
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraAnilox", "")
                cmd.Parameters.AddWithValue("@mspa_OFEndPress1", "")
                cmd.Parameters.AddWithValue("@mspa_OFEndPress2", "")
                cmd.Parameters.AddWithValue("@mspa_OFEndPress3", "")
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrType", "")
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrSet", "")
                cmd.Parameters.AddWithValue("@mspa_OFInkUntTemp", "")
                cmd.Parameters.AddWithValue("@mspa_LAFluteVert", "")
                cmd.Parameters.AddWithValue("@mspa_LAFluteHor", "")
                cmd.Parameters.AddWithValue("@mspa_LAEFlute", "")
                cmd.Parameters.AddWithValue("@mspa_LACFlute", "")
                cmd.Parameters.AddWithValue("@mspa_LABFlute", "")
                cmd.Parameters.AddWithValue("@mspa_LASFBdim1", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LASFBdim2", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAFGTopsh", "")
                cmd.Parameters.AddWithValue("@mspa_LAFGSF", "")
                cmd.Parameters.AddWithValue("@mspa_LAFGBottsh", "")
                cmd.Parameters.AddWithValue("@mspa_LAFGBottshs", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LASGOper", "")
                cmd.Parameters.AddWithValue("@mspa_LASGDrive", "")
                cmd.Parameters.AddWithValue("@mspa_LAThickTar", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAThickAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAMoistTar", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LAMoistAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_LANoExcGlu", "")
                cmd.Parameters.AddWithValue("@mspa_LANoWkGlu", "")
                cmd.Parameters.AddWithValue("@mspa_LANoDWarp", "")
                cmd.Parameters.AddWithValue("@mspa_LANoUWarp", "")
                cmd.Parameters.AddWithValue("@mspa_QCPprFeed", "")
                cmd.Parameters.AddWithValue("@mspa_QCInpSamp", "")
                cmd.Parameters.AddWithValue("@mspa_QCLwrUprLmt", "")
                cmd.Parameters.AddWithValue("@mspa_QCSpotSize", "")
                cmd.Parameters.AddWithValue("@mspa_QCInsScope", "")
                cmd.Parameters.AddWithValue("@mspa_QCTracrCode", "")
                cmd.Parameters.AddWithValue("@mspa_QCTrnsprtGuid", "")
                cmd.Parameters.AddWithValue("@mspa_QCBlwers", "")
                cmd.Parameters.AddWithValue("@mspa_Dcorrdiecut", "")
                cmd.Parameters.AddWithValue("@mspa_Ddiecutcode", "")
                cmd.Parameters.AddWithValue("@mspa_Dcorrdcblade", "")
                cmd.Parameters.AddWithValue("@mspa_Dbxfuncnlock", "")
                cmd.Parameters.AddWithValue("@mspa_Dcutedge", "")
                cmd.Parameters.AddWithValue("@mspa_DEmbcliche", "")
                cmd.Parameters.AddWithValue("@mspa_DEclicht5mm", "")
                cmd.Parameters.AddWithValue("@mspa_DEclichht", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DEmboutput", "")
                cmd.Parameters.AddWithValue("@mspa_DcountrEmbTh", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DCorrStripBrd", "")
                cmd.Parameters.AddWithValue("@mspa_DCorrWknife", "")
                cmd.Parameters.AddWithValue("@mspa_DCorrpinbarPos", "")
                cmd.Parameters.AddWithValue("@mspa_DStmpclichvsfilm", "")
                cmd.Parameters.AddWithValue("@mspa_DStClichHt7mm", "")
                cmd.Parameters.AddWithValue("@mspa_DStClichHt", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DStmpingOutput", "")
                cmd.Parameters.AddWithValue("@mspa_DcountrStmpTh", 0.00)
                cmd.Parameters.AddWithValue("@mspa_Dfoilcolorsize", "")
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp110", "")
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DScorbndratioAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DPunchPressImpAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_DSubstThickn", 0.00)
                cmd.Parameters.AddWithValue("@mspa_STConPinplatespecs", "")
                cmd.Parameters.AddWithValue("@mspa_STConPrintlayout", "")
                cmd.Parameters.AddWithValue("@mspa_STConGMPstd", "")
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#ups", "")
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#Pnum", "")
                cmd.Parameters.AddWithValue("@mspa_GLfdrbeltBBE", selectedMachineFeederBell)
                cmd.Parameters.AddWithValue("@mspa_GLftranbeltbox", selectedMachineTransportbelt)
                cmd.Parameters.AddWithValue("@mspa_GLBxSquare", selectedMachineSquareness)
                cmd.Parameters.AddWithValue("@mspa_GLBxLockSys", selectedMachineLockingSystem)
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartn", selectedMachineSlightlyOpened)
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartnqty", MachineSlightlyOpenedDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforces", selectedMachineOpeningForces)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforceval", MachineOpeningForcesDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLFlywheel", SelectedMachineFlywheel)
                cmd.Parameters.AddWithValue("@mspa_GLGLuegun", SelectedMachineGlueGun)
                cmd.Parameters.AddWithValue("@mspa_GLHSSAct", HSSActualDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelap", ActualGlueLapDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelwid", ActualGlueWidthDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1Dotsize", G1DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenStart", G1StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenEnd", G1EndDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG2Dotsize", G2DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenStart", G2StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenEnd", G2EndDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG3Dotsize", G3DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenStart", G3StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenEnd", G3EndDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG4Dotsize", G4DotsizeDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenStart", G4StartDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenEnd", G4EndDecimal)



                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltScrclr", selectedMachineFoldingBelt)
                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltActual", StandardActualMMDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressLow", SelectedMachineLow)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressMed", SelectedMachineMedium)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressHigh", SelectedMachineHigh)
                cmd.Parameters.AddWithValue("@mspa_GLBrush", SelectedMachineBrush)
                cmd.Parameters.AddWithValue("@mspa_GLFeedrvacuum", "")
                cmd.Parameters.AddWithValue("@mspa_GLPressarm", "")

                cmd.Parameters.AddWithValue("@mspa_GLS1G1startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endA", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endB", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endC", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endD", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endE", 0.00)
                cmd.Parameters.AddWithValue("@mspa_Glcold", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLhot", 0.00)





                cmd.Parameters.AddWithValue("@mspa_Operator", "")
                cmd.Parameters.AddWithValue("@mspa_AsstOper1", "")
                cmd.Parameters.AddWithValue("@mspa_AsstOper2", "")
                cmd.Parameters.AddWithValue("@mspa_Feedrman1", "")
                cmd.Parameters.AddWithValue("@mspa_Feedrman2", "")
                cmd.Parameters.AddWithValue("@mspa_CondBySV", "")
                cmd.Parameters.AddWithValue("@mspa_Helpr1", "")

                cmd.Parameters.AddWithValue("@mspa_OFColdAir", 0.00)
                cmd.Parameters.AddWithValue("@mspa_OFSFacfybar", "")
                cmd.Parameters.AddWithValue("@mspa_OFSFsecmatrix", "")
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlock", "")
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlockval", "")

                cmd.Parameters.AddWithValue("@mspa_SDboth", "")
                cmd.Parameters.AddWithValue("@mspa_SDsideA", "")
                cmd.Parameters.AddWithValue("@mspa_SDsideB", "")
                cmd.Parameters.AddWithValue("@mspa_SDsimplex", "")
                cmd.Parameters.AddWithValue("@mspa_PMmulshot", "")
                cmd.Parameters.AddWithValue("@mspa_PM1shot", "")
                cmd.Parameters.AddWithValue("@mspa_CPinhertcolor", "")
                cmd.Parameters.AddWithValue("@mspa_SUdesc", "")
                cmd.Parameters.AddWithValue("@mspa_SUweight", "")
                cmd.Parameters.AddWithValue("@mspa_SUthickness", "")
                cmd.Parameters.AddWithValue("@mspa_GDShort", "")
                cmd.Parameters.AddWithValue("@mspa_GDLong", "")
                cmd.Parameters.AddWithValue("@mspa_SAfront", "")
                cmd.Parameters.AddWithValue("@mspa_SArear", "")
                cmd.Parameters.AddWithValue("@mspa_SAcollate", "")
                cmd.Parameters.AddWithValue("@mspa_SJFLFU", "")
                cmd.Parameters.AddWithValue("@mspa_SJFLFD", "")
                cmd.Parameters.AddWithValue("@mspa_SJLFFU", "")
                cmd.Parameters.AddWithValue("@mspa_SJLFFD", "")
                cmd.Parameters.AddWithValue("@mspa_GLglossy", "")
                cmd.Parameters.AddWithValue("@mspa_GLsemimatte", "")
                cmd.Parameters.AddWithValue("@mspa_GLmatte", "")
                cmd.Parameters.AddWithValue("@mspa_IPmirror", "")
                cmd.Parameters.AddWithValue("@mspa_IPnormal", "")
                cmd.Parameters.AddWithValue("@mspa_IProtate", "")
                cmd.Parameters.AddWithValue("@mspa_IPtumble", "")
                cmd.Parameters.AddWithValue("@mspa_CCLUTname", "")
                cmd.Parameters.AddWithValue("@mspa_CCcontrast", "")
                cmd.Parameters.AddWithValue("@mspa_CCbrightness", "")
                cmd.Parameters.AddWithValue("@mspa_CCdot50per", "")
                cmd.Parameters.AddWithValue("@mspa_CCopticdenadj", "")
                cmd.Parameters.AddWithValue("@mspa_CCC1", "")
                cmd.Parameters.AddWithValue("@mspa_CCC2", "")
                cmd.Parameters.AddWithValue("@mspa_CCC3", "")
                cmd.Parameters.AddWithValue("@mspa_CCC4", "")
                cmd.Parameters.AddWithValue("@mspa_CCC5", "")
                cmd.Parameters.AddWithValue("@mspa_CCM1", "")
                cmd.Parameters.AddWithValue("@mspa_CCM2", "")
                cmd.Parameters.AddWithValue("@mspa_CCM3", "")
                cmd.Parameters.AddWithValue("@mspa_CCM4", "")
                cmd.Parameters.AddWithValue("@mspa_CCM5", "")
                cmd.Parameters.AddWithValue("@mspa_CCY1", "")
                cmd.Parameters.AddWithValue("@mspa_CCY2", "")
                cmd.Parameters.AddWithValue("@mspa_CCY3", "")
                cmd.Parameters.AddWithValue("@mspa_CCY4", "")
                cmd.Parameters.AddWithValue("@mspa_CCY5", "")
                cmd.Parameters.AddWithValue("@mspa_CCK1", "")
                cmd.Parameters.AddWithValue("@mspa_CCK2", "")
                cmd.Parameters.AddWithValue("@mspa_CCK3", "")
                cmd.Parameters.AddWithValue("@mspa_CCK4", "")
                cmd.Parameters.AddWithValue("@mspa_CCK5", "")
                cmd.Parameters.AddWithValue("@mspa_CCO1", "")
                cmd.Parameters.AddWithValue("@mspa_CCO2", "")
                cmd.Parameters.AddWithValue("@mspa_CCO3", "")
                cmd.Parameters.AddWithValue("@mspa_CCO4", "")
                cmd.Parameters.AddWithValue("@mspa_CCO5", "")
                cmd.Parameters.AddWithValue("@mspa_CCG1", "")
                cmd.Parameters.AddWithValue("@mspa_CCG2", "")
                cmd.Parameters.AddWithValue("@mspa_CCG3", "")
                cmd.Parameters.AddWithValue("@mspa_CCG4", "")
                cmd.Parameters.AddWithValue("@mspa_CCG5", "")
                cmd.Parameters.AddWithValue("@mspa_CCV1", "")
                cmd.Parameters.AddWithValue("@mspa_CCV2", "")
                cmd.Parameters.AddWithValue("@mspa_CCV3", "")
                cmd.Parameters.AddWithValue("@mspa_CCV4", "")
                cmd.Parameters.AddWithValue("@mspa_CCV5", "")
                cmd.Parameters.AddWithValue("@mspa_CATP", "")
                cmd.Parameters.AddWithValue("@mspa_VerBySV", "")


                cmd.ExecuteNonQuery()
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
            cmd.CommandText = "Select_sppmcROLIC"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Update_sppmcROLIC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@bpenqty", TXT_7BallpenQty.Text)
                cmd.Parameters.AddWithValue("@ragsqty", TXT_7RagsQty.Text)
                cmd.Parameters.AddWithValue("@stripknife", DBNull.Value)
                cmd.Parameters.AddWithValue("@stripknifebld", DBNull.Value)
                cmd.Parameters.AddWithValue("@markerqty", DBNull.Value)
                cmd.Parameters.AddWithValue("@gluebottle", DBNull.Value)
                cmd.Parameters.AddWithValue("@othersdesc", DBNull.Value)
                cmd.Parameters.AddWithValue("@othersqty", DBNull.Value)
                cmd.Parameters.AddWithValue("@CotglovQty", DBNull.Value)
                cmd.ExecuteNonQuery()
                con.Close()






            Else
                con.Close()

                OpenConnection()
                cmd.CommandText = "Insert_sppmcROLIC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@bpenqty", TXT_7BallpenQty.Text)
                cmd.Parameters.AddWithValue("@ragsqty", TXT_7RagsQty.Text)
                cmd.Parameters.AddWithValue("@stripknife", DBNull.Value)
                cmd.Parameters.AddWithValue("@stripknifebld", DBNull.Value)
                cmd.Parameters.AddWithValue("@markerqty", DBNull.Value)
                cmd.Parameters.AddWithValue("@gluebottle", DBNull.Value)
                cmd.Parameters.AddWithValue("@othersdesc", DBNull.Value)
                cmd.Parameters.AddWithValue("@othersqty", DBNull.Value)
                cmd.Parameters.AddWithValue("@CotglovQty", DBNull.Value)
                cmd.ExecuteNonQuery()
                con.Close()

            End If
            con.Close()




        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try









        MsgBox("successfully save!")



        Dim i As Integer
        For i = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        Dim UC_SupervisorGluing As New UC_SupervisorGluing
        UC_SupervisorGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorGluing.Show()
        UC_SupervisorGluing.Dock = DockStyle.Fill



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

    Private Sub CHK_SelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged
        If CHK_SelectAll.Checked = True Then
            SelectAllChecked()
        Else
            SelectAllunChecked()
        End If
    End Sub

    Private Sub CBO_AsstOperator1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.SelectedIndexChanged
        con.Close()
        load_AssOperator_empnum1()
    End Sub
    Private Sub CBO_AsstOperator1_DropDown(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.DropDown
        CBO_AsstOperator1.Items.Clear()
        load_AssOperator1()
    End Sub



    Private Sub load_AssOperator1()


        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Operator' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_AsstOperator1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



        'Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name as Emp_num_helper FROM Employee WHERE Position = 'Helper'", con)

        'Try
        '    con.Open()
        '    Dim read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader
        '    While read_cmd_select_helper.Read
        '        CBO_Helper1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
        '    End While
        '    read_cmd_select_helper.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    con.Close()
        'End Try
    End Sub

    Private Sub load_AssOperator_empnum1()



        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Operator' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_AsstOperator1.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_AsstOperator1.Items.Add(helper_empname)
                TXT_AsstOperator1.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_AsstOperator1.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_Helper1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged
        con.Close()
        load_helper_empnum1()
    End Sub
    Private Sub CBO_Helper1_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper1.DropDown
        CBO_Helper1.Items.Clear()
        load_helper1()
    End Sub
    Private Sub load_helper1()


        Dim cmd_select_helper As New SqlCommand("SELECT Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Helper' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_Helper1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



        'Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name as Emp_num_helper FROM Employee WHERE Position = 'Helper'", con)

        'Try
        '    con.Open()
        '    Dim read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader
        '    While read_cmd_select_helper.Read
        '        CBO_Helper1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
        '    End While
        '    read_cmd_select_helper.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    con.Close()
        'End Try
    End Sub

    Private Sub load_helper_empnum1()

        Dim cmd_select_helper_empnum As New SqlCommand("
        SELECT 
            Name, 
            Emp_num, 
            Emp_num + ' - ' + Name AS Emp_num_helper 
        FROM Employee 
        WHERE Position = 'Helper' 
        AND (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_Helper1.Text)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader()
                If read_cmd_select_helper_empnum.Read() Then
                    Dim helper_empname As String = read_cmd_select_helper_empnum("Name").ToString()

                    ' Optional: Clear the ComboBox if necessary before adding new item
                    CBO_Helper1.Items.Clear()

                    CBO_Helper1.Items.Add(helper_empname) ' Add the employee name to the ComboBox
                    TXT_Helper1.Text = read_cmd_select_helper_empnum("Emp_num").ToString() ' Set the Emp_num text
                    CBO_Helper1.Text = read_cmd_select_helper_empnum("Name").ToString() ' Set the selected text for ComboBox
                End If
            End Using

        Catch ex As Exception
            ' Handle the exception (optional MsgBox or logging)
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try




        'Dim cmd_select_helper_empnum As New SqlCommand("
        'Select 
        '  Name, 
        '  Emp_num, 
        '  Emp_num + ' - ' + Name as Emp_num_helper 
        'FROM Employee WHERE Position = 'Helper' and

        '(Emp_num + ' - ' + Name) = @helperempnum", con)

        'cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_Helper1.Text)

        'Try
        '    con.Open()
        '    Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
        '    If read_cmd_select_helper_empnum.Read Then
        '        Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
        '        CBO_Helper1.Items.Add(helper_empname)
        '        TXT_Helper1.Text = read_cmd_select_helper_empnum("Emp_num")
        '        CBO_Helper1.Text = read_cmd_select_helper_empnum("Name").ToString
        '        'MsgBox(read_cmd_select_helper_empnum("Name"))
        '    End If
        '    read_cmd_select_helper_empnum.Close()
        'Catch ex As Exception
        'Finally
        '    con.Close()
        'End Try
    End Sub

    Private Sub TXT_MachineActualGlueLap_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineActualGlueLap.TextChanged

    End Sub

    Private Sub TXT_MachineActualGlueLap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineActualGlueLap.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineActualGlueWidth_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineActualGlueWidth.TextChanged

    End Sub

    Private Sub TXT_MachineG1DotSize_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG1DotSize.TextChanged

    End Sub

    Private Sub TXT_MachineG1DotSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG1DotSize.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG2DotSize_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG2DotSize.TextChanged

    End Sub

    Private Sub TXT_MachineG2DotSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG2DotSize.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG3DotSize_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG3DotSize.TextChanged

    End Sub

    Private Sub TXT_MachineG3DotSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG3DotSize.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG4DotSize_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG4DotSize.TextChanged

    End Sub

    Private Sub TXT_MachineG4DotSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG4DotSize.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG1Start_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG1Start.TextChanged

    End Sub

    Private Sub TXT_MachineG1Start_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG1Start.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG2Start_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG2Start.TextChanged

    End Sub

    Private Sub TXT_MachineG2Start_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG2Start.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG3Start_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG3Start.TextChanged

    End Sub

    Private Sub TXT_MachineG3Start_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG3Start.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG4Start_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG4Start.TextChanged

    End Sub

    Private Sub TXT_MachineG4Start_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG4Start.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG1End_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG1End.TextChanged

    End Sub

    Private Sub TXT_MachineG1End_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG1End.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG2End_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG2End.TextChanged

    End Sub

    Private Sub TXT_MachineG2End_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG2End.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG3End_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG3End.TextChanged

    End Sub

    Private Sub TXT_MachineG3End_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG3End.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineG4End_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineG4End.TextChanged

    End Sub

    Private Sub TXT_MachineG4End_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineG4End.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_StandardActualMM_TextChanged(sender As Object, e As EventArgs) Handles TXT_StandardActualMM.TextChanged

    End Sub

    Private Sub TXT_StandardActualMM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StandardActualMM.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineSlightlyOpened_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineSlightlyOpened.TextChanged

    End Sub

    Private Sub TXT_MachineOpeningForces_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineOpeningForces.TextChanged

    End Sub

    Private Sub TXT_MachineSlightlyOpened_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineSlightlyOpened.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineOpeningForces_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineOpeningForces.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineActualGlueWidth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineActualGlueWidth.KeyPress
        NumberChar(e)
    End Sub
End Class
