Imports System.Data.SqlClient

Public Class UC_SupervisorGluingLamina
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

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
        CHK_GoodStation1.Checked = True
        CHK_GoodJSortingTable.Checked = True
        CHK_GoodFeederUnit.Checked = True

        CHK_GoodGluingUnit.Checked = True
        CHK_GoodStation2.Checked = True
        CHK_GoodFConveyor.Checked = True


        CHK_GoodBundingMachine.Checked = True
        CHK_GoodRotatingTable.Checked = True
        CHK_GoodWeighingScale.Checked = True

        CHK_GoodProperlyTagged.Checked = True
        CHk_GoodInPlasticPalltes.Checked = True
        CHK_GoodFollowingStandardPallet.Checked = True

        CHK_GoodWearHairCover.Checked = True
        CHk_GoodWearsProperlyTuckedIn.Checked = True
        CHk_GoodHandWashed.Checked = True

        CHk_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaingMaterials.Checked = True
        CHK_GoodSafetyDevicesWorking.Checked = True


        CHK_MachineFeederbelt.Checked = True
        CHK_MachinePressArm.Checked = True
        CHK_MachineTransportRollers.Checked = True
        CHK_MachineFeederVacuum.Checked = True





        CHK_MachineSquareness.Checked = True
        CHK_MachineLockingSystem.Checked = True




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
        CHK_GoodStation1.Checked = False
        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False

        CHK_GoodJSortingTable.Checked = False
        CHK_GoodFeederUnit.Checked = False

        CHK_GoodGluingUnit.Checked = False
        CHK_GoodStation2.Checked = False
        CHK_GoodFConveyor.Checked = False

        CHK_GoodBundingMachine.Checked = False
        CHK_GoodRotatingTable.Checked = False
        CHK_GoodWeighingScale.Checked = False

        CHK_GoodProperlyTagged.Checked = False
        CHk_GoodInPlasticPalltes.Checked = False
        CHK_GoodFollowingStandardPallet.Checked = False

        CHK_GoodWearHairCover.Checked = False
        CHk_GoodWearsProperlyTuckedIn.Checked = False
        CHk_GoodHandWashed.Checked = False

        CHk_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaingMaterials.Checked = False
        CHK_GoodSafetyDevicesWorking.Checked = False

        CHK_MachineFeederbelt.Checked = False
        CHK_MachinePressArm.Checked = False
        CHK_MachineTransportRollers.Checked = False
        CHK_MachineFeederVacuum.Checked = False



        CHK_MachineSquareness.Checked = False
        CHK_MachineLockingSystem.Checked = False



    End Sub
    Private Sub EnabledSupervisorForm()
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

        CHK_GoodGluingUnit.Enabled = True
        CHK_GoodStation2.Enabled = True
        CHK_GoodFConveyor.Enabled = True

        CHK_GoodBundingMachine.Enabled = True
        CHK_GoodRotatingTable.Enabled = True
        CHK_GoodWeighingScale.Enabled = True

        CHK_GoodProperlyTagged.Enabled = True
        CHk_GoodInPlasticPalltes.Enabled = True
        CHK_GoodFollowingStandardPallet.Enabled = True

        CHK_GoodWearHairCover.Enabled = True
        CHk_GoodWearsProperlyTuckedIn.Enabled = True
        CHk_GoodHandWashed.Enabled = True

        CHk_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaingMaterials.Enabled = True
        CHK_GoodSafetyDevicesWorking.Enabled = True
        CHK_GoodStation1.Enabled = True
        CHK_SelectAll.Enabled = True

        CHK_MachineSquareness.Enabled = True
        CHK_MachineLockingSystem.Enabled = True

        TXT_FullBallpenQty.Enabled = True
        TXT_FullRagsQty.Enabled = True
        CBO_AsstOperator1.Enabled = True
        TXT_AsstOperator1.Enabled = True
        DTPOperator.Enabled = False
        DTP_AsstOperator1.Enabled = True

        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True

        TXT_Station1Gun1Start1.Enabled = True
        TXT_Station1Gun1Start2.Enabled = True
        TXT_Station1Gun1Start3.Enabled = True
        TXT_Station1Gun1Start4.Enabled = True
        TXT_Station1Gun1Start5.Enabled = True
        TXT_Station1Gun1End1.Enabled = True
        TXT_Station1Gun1End2.Enabled = True
        TXT_Station1Gun1End3.Enabled = True
        TXT_Station1Gun1End4.Enabled = True
        TXT_Station1Gun1End5.Enabled = True
        TXT_Station1Gun2Start1.Enabled = True
        TXT_Station1Gun2Start2.Enabled = True
        TXT_Station1Gun2Start3.Enabled = True
        TXT_Station1Gun2Start4.Enabled = True
        TXT_Station1Gun2Start5.Enabled = True
        TXT_Station1Gun2End1.Enabled = True
        TXT_Station1Gun2End2.Enabled = True
        TXT_Station1Gun2End3.Enabled = True
        TXT_Station1Gun2End4.Enabled = True
        TXT_Station1Gun2End5.Enabled = True

        TXT_Station2Gun1Start1.Enabled = True
        TXT_Station2Gun1Start2.Enabled = True
        TXT_Station2Gun1Start3.Enabled = True
        TXT_Station2Gun1Start4.Enabled = True
        TXT_Station2Gun1Start5.Enabled = True
        TXT_Station2Gun1End1.Enabled = True
        TXT_Station2Gun1End2.Enabled = True
        TXT_Station2Gun1End3.Enabled = True
        TXT_Station2Gun1End4.Enabled = True
        TXT_Station2Gun1End5.Enabled = True
        TXT_Station2Gun2Start1.Enabled = True
        TXT_Station2Gun2Start2.Enabled = True
        TXT_Station2Gun2Start3.Enabled = True
        TXT_Station2Gun2Start4.Enabled = True
        TXT_Station2Gun2Start5.Enabled = True
        TXT_Station2Gun2End1.Enabled = True
        TXT_Station2Gun2End2.Enabled = True
        TXT_Station2Gun2End3.Enabled = True
        TXT_Station2Gun2End4.Enabled = True
        TXT_Station2Gun2End5.Enabled = True
        TXT_MachineCold.Enabled = True
        TXT_MachineColdmmHot.Enabled = True
        TXT_MachineActualGlueLap.Enabled = True
        TXT_MachineActualGlueWidth.Enabled = True
        DTPOperator.Enabled = True

        CHK_MachineFeederbelt.Enabled = True
        CHK_MachinePressArm.Enabled = True
        CHK_MachineTransportRollers.Enabled = True
        CHK_MachineFeederVacuum.Enabled = True

        BTN_Save_Supervisor.Enabled = True


    End Sub
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

        CHK_GoodGluingUnit.Enabled = False
        CHK_GoodStation2.Enabled = False
        CHK_GoodFConveyor.Enabled = False

        CHK_GoodBundingMachine.Enabled = False
        CHK_GoodRotatingTable.Enabled = False
        CHK_GoodWeighingScale.Enabled = False

        CHK_GoodProperlyTagged.Enabled = False
        CHk_GoodInPlasticPalltes.Enabled = False
        CHK_GoodFollowingStandardPallet.Enabled = False

        CHK_GoodWearHairCover.Enabled = False
        CHk_GoodWearsProperlyTuckedIn.Enabled = False
        CHk_GoodHandWashed.Enabled = False

        CHk_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaingMaterials.Enabled = False
        CHK_GoodSafetyDevicesWorking.Enabled = False
        CHK_GoodStation1.Enabled = False
        CHK_SelectAll.Enabled = False


        CHK_MachineSquareness.Enabled = False
        CHK_MachineLockingSystem.Enabled = False
        DTPOperator.Enabled = False
        TXT_FullBallpenQty.Enabled = False
        TXT_FullRagsQty.Enabled = False
        CBO_AsstOperator1.Enabled = False
        TXT_AsstOperator1.Enabled = False
        DTP_AsstOperator1.Enabled = False

        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False


        TXT_Station1Gun1Start1.Enabled = False
        TXT_Station1Gun1Start2.Enabled = False
        TXT_Station1Gun1Start3.Enabled = False
        TXT_Station1Gun1Start4.Enabled = False
        TXT_Station1Gun1Start5.Enabled = False
        TXT_Station1Gun1End1.Enabled = False
        TXT_Station1Gun1End2.Enabled = False
        TXT_Station1Gun1End3.Enabled = False
        TXT_Station1Gun1End4.Enabled = False
        TXT_Station1Gun1End5.Enabled = False
        TXT_Station1Gun2Start1.Enabled = False
        TXT_Station1Gun2Start2.Enabled = False
        TXT_Station1Gun2Start3.Enabled = False
        TXT_Station1Gun2Start4.Enabled = False
        TXT_Station1Gun2Start5.Enabled = False
        TXT_Station1Gun2End1.Enabled = False
        TXT_Station1Gun2End2.Enabled = False
        TXT_Station1Gun2End3.Enabled = False
        TXT_Station1Gun2End4.Enabled = False
        TXT_Station1Gun2End5.Enabled = False

        TXT_Station2Gun1Start1.Enabled = False
        TXT_Station2Gun1Start2.Enabled = False
        TXT_Station2Gun1Start3.Enabled = False
        TXT_Station2Gun1Start4.Enabled = False
        TXT_Station2Gun1Start5.Enabled = False
        TXT_Station2Gun1End1.Enabled = False
        TXT_Station2Gun1End2.Enabled = False
        TXT_Station2Gun1End3.Enabled = False
        TXT_Station2Gun1End4.Enabled = False
        TXT_Station2Gun1End5.Enabled = False
        TXT_Station2Gun2Start1.Enabled = False
        TXT_Station2Gun2Start2.Enabled = False
        TXT_Station2Gun2Start3.Enabled = False
        TXT_Station2Gun2Start4.Enabled = False
        TXT_Station2Gun2Start5.Enabled = False
        TXT_Station2Gun2End1.Enabled = False
        TXT_Station2Gun2End2.Enabled = False
        TXT_Station2Gun2End3.Enabled = False
        TXT_Station2Gun2End4.Enabled = False
        TXT_Station2Gun2End5.Enabled = False
        TXT_MachineCold.Enabled = False
        TXT_MachineColdmmHot.Enabled = False
        TXT_MachineActualGlueLap.Enabled = False
        TXT_MachineActualGlueWidth.Enabled = False

        BTN_Save_Supervisor.Enabled = False

        CHK_MachineFeederbelt.Enabled = False
        CHK_MachinePressArm.Enabled = False
        CHK_MachineTransportRollers.Enabled = False
        CHK_MachineFeederVacuum.Enabled = False



    End Sub

    Private Sub UC_SupervisorGluingLamina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        DTP_AsstOperator1.Format = DateTimePickerFormat.Custom
        DTP_AsstOperator1.CustomFormat = "hh:mm tt"


        DTPOperator.Text = "12:00 AM"
        DTP_AsstOperator1.Text = "12:00 AM"


        ' Optional: Set value to default time when no time is selected
        If DTPOperator.Value = DTPOperator.MinDate Then
            DTPOperator.Text = "12:00 AM"
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







                    If dr("gmp_SaniGluingUnit").ToString() = "O" Then
                        CHK_GoodGluingUnit.Checked = True
                    Else
                        CHK_GoodGluingUnit.Checked = False
                    End If







                    If dr("gmp_SaniConveyor").ToString() = "O" Then
                        CHK_GoodFConveyor.Checked = True
                    Else
                        CHK_GoodFConveyor.Checked = False
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
                        CHk_GoodInPlasticPalltes.Checked = True
                    Else
                        CHk_GoodInPlasticPalltes.Checked = False
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




                    If dr("gmp_Sanistation2").ToString() = "O" Then
                        CHK_GoodStation2.Checked = True
                    Else
                        CHK_GoodStation2.Checked = False
                    End If



                    If dr("gmp_Sanistation1").ToString() = "O" Then
                        CHK_GoodStation1.Checked = True
                    Else
                        CHK_GoodStation1.Checked = False
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


                    TXT_AsstOperator1.Text = AssOperator1




                    DTPOperator.Text = dr("jic_OperatorTime").ToString()
                    DTP_AsstOperator1.Text = dr("jic_AsstOper1Time").ToString()



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
                        CHK_MachineFeederbelt.Checked = True
                    Else
                        CHK_MachineFeederbelt.Checked = False
                    End If

                    If dr("mspa_GLftranbeltbox").ToString() = "O" Then
                        CHK_MachineTransportRollers.Checked = True
                    Else
                        CHK_MachineTransportRollers.Checked = False
                    End If

                    If dr("mspa_GLPressarm").ToString() = "O" Then
                        CHK_MachinePressArm.Checked = True
                    Else
                        CHK_MachinePressArm.Checked = False
                    End If


                    If dr("mspa_GLFeedrvacuum").ToString() = "O" Then
                        CHK_MachineFeederVacuum.Checked = True
                    Else
                        CHK_MachineFeederVacuum.Checked = False
                    End If



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

                    TXT_Station1Gun1Start1.Text = dr("mspa_GLS1G1startA").ToString()
                    TXT_Station1Gun1Start2.Text = dr("mspa_GLS1G1startB").ToString()
                    TXT_Station1Gun1Start3.Text = dr("mspa_GLS1G1startC").ToString()
                    TXT_Station1Gun1Start4.Text = dr("mspa_GLS1G1startD").ToString()
                    TXT_Station1Gun1Start5.Text = dr("mspa_GLS1G1startE").ToString()

                    TXT_Station1Gun1End1.Text = dr("mspa_GLS1G1endA").ToString()
                    TXT_Station1Gun1End2.Text = dr("mspa_GLS1G1endB").ToString()
                    TXT_Station1Gun1End3.Text = dr("mspa_GLS1G1endC").ToString()
                    TXT_Station1Gun1End4.Text = dr("mspa_GLS1G1endD").ToString()
                    TXT_Station1Gun1End5.Text = dr("mspa_GLS1G1endE").ToString()


                    TXT_Station1Gun2Start1.Text = dr("mspa_GLS1G2startA").ToString()
                    TXT_Station1Gun2Start2.Text = dr("mspa_GLS1G2startB").ToString()
                    TXT_Station1Gun2Start3.Text = dr("mspa_GLS1G2startC").ToString()
                    TXT_Station1Gun2Start4.Text = dr("mspa_GLS1G2startD").ToString()
                    TXT_Station1Gun2Start5.Text = dr("mspa_GLS1G2startE").ToString()


                    TXT_Station1Gun2End1.Text = dr("mspa_GLS1G2endA").ToString()
                    TXT_Station1Gun2End2.Text = dr("mspa_GLS1G2endB").ToString()
                    TXT_Station1Gun2End3.Text = dr("mspa_GLS1G2endC").ToString()
                    TXT_Station1Gun2End4.Text = dr("mspa_GLS1G2endD").ToString()
                    TXT_Station1Gun2End5.Text = dr("mspa_GLS1G2endE").ToString()



                    TXT_Station2Gun1Start1.Text = dr("mspa_GLS2G1startA").ToString()
                    TXT_Station2Gun1Start2.Text = dr("mspa_GLS2G1startB").ToString()
                    TXT_Station2Gun1Start3.Text = dr("mspa_GLS2G1startC").ToString()
                    TXT_Station2Gun1Start4.Text = dr("mspa_GLS2G1startD").ToString()
                    TXT_Station2Gun1Start5.Text = dr("mspa_GLS2G1startE").ToString()

                    TXT_Station2Gun1End1.Text = dr("mspa_GLS2G1endA").ToString()
                    TXT_Station2Gun1End2.Text = dr("mspa_GLS2G1endB").ToString()
                    TXT_Station2Gun1End3.Text = dr("mspa_GLS2G1endC").ToString()
                    TXT_Station2Gun1End4.Text = dr("mspa_GLS2G1endD").ToString()
                    TXT_Station2Gun1End5.Text = dr("mspa_GLS2G1endE").ToString()


                    TXT_Station2Gun2Start1.Text = dr("mspa_GLS2G2startA").ToString()
                    TXT_Station2Gun2Start2.Text = dr("mspa_GLS2G2startB").ToString()
                    TXT_Station2Gun2Start3.Text = dr("mspa_GLS2G2startC").ToString()
                    TXT_Station2Gun2Start4.Text = dr("mspa_GLS2G2startD").ToString()
                    TXT_Station2Gun2Start5.Text = dr("mspa_GLS2G2startE").ToString()

                    TXT_Station2Gun2End1.Text = dr("mspa_GLS2G2endA").ToString()
                    TXT_Station2Gun2End2.Text = dr("mspa_GLS2G2endB").ToString()
                    TXT_Station2Gun2End3.Text = dr("mspa_GLS2G2endC").ToString()
                    TXT_Station2Gun2End4.Text = dr("mspa_GLS2G2endD").ToString()
                    TXT_Station2Gun2End5.Text = dr("mspa_GLS2G2endE").ToString()


                    TXT_MachineActualGlueLap.Text = dr("mspa_GLActGLuelap").ToString()
                    TXT_MachineActualGlueWidth.Text = dr("mspa_GLActGLuelwid").ToString()
                    TXT_MachineCold.Text = dr("mspa_GLcold").ToString()
                    TXT_MachineColdmmHot.Text = dr("mspa_GLhot").ToString()

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
        Dim GoodGluingUnit As String = ""

        Dim GoodStation2 As String = ""

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





        If CHK_GoodGluingUnit.Checked Then
            GoodGluingUnit = "O"
        Else
            GoodGluingUnit = "X"
        End If


        If CHK_GoodStation2.Checked Then
            GoodStation2 = "O"
        Else
            GoodStation2 = "X"
        End If





        If CHK_GoodFConveyor.Checked Then
            GoodConveyor = "O"
        Else
            GoodConveyor = "X"
        End If







        Dim GoodBundingMachine As String = ""
        Dim GoodRotatingTable As String = ""
        Dim GoodStation1 As String = ""
        Dim GoodWeighingScale As String = ""


        If CHK_GoodStation1.Checked Then
            GoodStation1 = "O"
        Else
            GoodStation1 = "X"
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



        If CHK_GoodBundingMachine.Checked Then
            GoodBundingMachine = "O"
        Else
            GoodBundingMachine = "X"
        End If








        Dim GoodProperlyTagged As String = ""
        Dim GoodInPlasticPalltes As String = ""
        Dim GoodInStandardPalletizingHeight As String = ""

        If CHK_GoodProperlyTagged.Checked Then
            GoodProperlyTagged = "O"
        Else
            GoodProperlyTagged = "X"
        End If


        If CHk_GoodInPlasticPalltes.Checked Then
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
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", GoodGluingUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", "")
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", "")
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
                cmd.Parameters.AddWithValue("@gmp_Sanistation2", GoodStation2)
                cmd.Parameters.AddWithValue("@gmp_Sanistation1", GoodStation1)
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
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", GoodGluingUnit)
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", "")
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", "")
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
                cmd.Parameters.AddWithValue("@gmp_Sanistation2", GoodStation2)
                cmd.Parameters.AddWithValue("@gmp_Sanistation1", GoodStation1)
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
                cmd.Parameters.AddWithValue("@jic_Helper1", "")
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
                cmd.Parameters.AddWithValue("@jic_Helper1Time", "")
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
                cmd.Parameters.AddWithValue("@jic_Helper1", "")
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
                cmd.Parameters.AddWithValue("@jic_Helper1Time", "")
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



        Dim MachineFeederbelt As String = ""
        Dim MachineTransportRollers As String = ""
        Dim MachinePressArm As String = ""
        Dim MachineFeederVacuum As String = ""



        If CHK_MachineFeederbelt.Checked Then
            MachineFeederbelt = "O"
        Else
            MachineFeederbelt = "X"
        End If


        If CHK_MachineFeederbelt.Checked Then
            MachineTransportRollers = "O"
        Else
            MachineTransportRollers = "X"
        End If




        If CHK_MachinePressArm.Checked Then
            MachinePressArm = "O"
        Else
            MachinePressArm = "X"
        End If




        If CHK_MachineFeederVacuum.Checked Then
            MachineFeederVacuum = "O"
        Else
            MachineFeederVacuum = "X"
        End If


        Dim MachineSquareness As String = ""
        Dim MachineLockingSystem As String = ""



        If CHK_MachineSquareness.Checked Then
            MachineSquareness = "O"
        Else
            MachineSquareness = "X"
        End If


        If CHK_MachineLockingSystem.Checked Then
            MachineLockingSystem = "O"
        Else
            MachineLockingSystem = "X"
        End If



        Dim Station1Gun1Start1Decimal As Double
        Dim Station1Gun1Start2Decimal As Double
        Dim Station1Gun1Start3Decimal As Double
        Dim Station1Gun1Start4Decimal As Double
        Dim Station1Gun1Start5Decimal As Double

        Dim Station1Gun1End1Decimal As Double
        Dim Station1Gun1End2Decimal As Double
        Dim Station1Gun1End3Decimal As Double
        Dim Station1Gun1End4Decimal As Double
        Dim Station1Gun1End5Decimal As Double

        Dim Station1Gun2Start1Decimal As Double
        Dim Station1Gun2Start2Decimal As Double
        Dim Station1Gun2Start3Decimal As Double
        Dim Station1Gun2Start4Decimal As Double
        Dim Station1Gun2Start5Decimal As Double

        Dim Station1Gun2End1Decimal As Double
        Dim Station1Gun2End2Decimal As Double
        Dim Station1Gun2End3Decimal As Double
        Dim Station1Gun2End4Decimal As Double
        Dim Station1Gun2End5Decimal As Double

        Dim Station2Gun1Start1Decimal As Double
        Dim Station2Gun1Start2Decimal As Double
        Dim Station2Gun1Start3Decimal As Double
        Dim Station2Gun1Start4Decimal As Double
        Dim Station2Gun1Start5Decimal As Double

        Dim Station2Gun1End1Decimal As Double
        Dim Station2Gun1End2Decimal As Double
        Dim Station2Gun1End3Decimal As Double
        Dim Station2Gun1End4Decimal As Double
        Dim Station2Gun1End5Decimal As Double

        Dim Station2Gun2Start1Decimal As Double
        Dim Station2Gun2Start2Decimal As Double
        Dim Station2Gun2Start3Decimal As Double
        Dim Station2Gun2Start4Decimal As Double
        Dim Station2Gun2Start5Decimal As Double

        Dim Station2Gun2End1Decimal As Double
        Dim Station2Gun2End2Decimal As Double
        Dim Station2Gun2End3Decimal As Double
        Dim Station2Gun2End4Decimal As Double
        Dim Station2Gun2End5Decimal As Double


        Double.TryParse(TXT_Station1Gun1Start1.Text, Station1Gun1Start1Decimal)
        Double.TryParse(TXT_Station1Gun1Start2.Text, Station1Gun1Start2Decimal)
        Double.TryParse(TXT_Station1Gun1Start3.Text, Station1Gun1Start3Decimal)
        Double.TryParse(TXT_Station1Gun1Start4.Text, Station1Gun1Start4Decimal)
        Double.TryParse(TXT_Station1Gun1Start5.Text, Station1Gun1Start5Decimal)

        Double.TryParse(TXT_Station1Gun1End1.Text, Station1Gun1End1Decimal)
        Double.TryParse(TXT_Station1Gun1End2.Text, Station1Gun1End2Decimal)
        Double.TryParse(TXT_Station1Gun1End3.Text, Station1Gun1End3Decimal)
        Double.TryParse(TXT_Station1Gun1End4.Text, Station1Gun1End4Decimal)
        Double.TryParse(TXT_Station1Gun1End5.Text, Station1Gun1End5Decimal)

        Double.TryParse(TXT_Station1Gun2Start1.Text, Station1Gun2Start1Decimal)
        Double.TryParse(TXT_Station1Gun2Start2.Text, Station1Gun2Start2Decimal)
        Double.TryParse(TXT_Station1Gun2Start3.Text, Station1Gun2Start3Decimal)
        Double.TryParse(TXT_Station1Gun2Start4.Text, Station1Gun2Start4Decimal)
        Double.TryParse(TXT_Station1Gun2Start5.Text, Station1Gun2Start5Decimal)

        Double.TryParse(TXT_Station1Gun2End1.Text, Station1Gun2End1Decimal)
        Double.TryParse(TXT_Station1Gun2End2.Text, Station1Gun2End2Decimal)
        Double.TryParse(TXT_Station1Gun2End3.Text, Station1Gun2End3Decimal)
        Double.TryParse(TXT_Station1Gun2End4.Text, Station1Gun2End4Decimal)
        Double.TryParse(TXT_Station1Gun2End5.Text, Station1Gun2End5Decimal)

        Double.TryParse(TXT_Station2Gun1Start1.Text, Station2Gun1Start1Decimal)
        Double.TryParse(TXT_Station2Gun1Start2.Text, Station2Gun1Start2Decimal)
        Double.TryParse(TXT_Station2Gun1Start3.Text, Station2Gun1Start3Decimal)
        Double.TryParse(TXT_Station2Gun1Start4.Text, Station2Gun1Start4Decimal)
        Double.TryParse(TXT_Station2Gun1Start5.Text, Station2Gun1Start5Decimal)

        Double.TryParse(TXT_Station2Gun1End1.Text, Station2Gun1End1Decimal)
        Double.TryParse(TXT_Station2Gun1End2.Text, Station2Gun1End2Decimal)
        Double.TryParse(TXT_Station2Gun1End3.Text, Station2Gun1End3Decimal)
        Double.TryParse(TXT_Station2Gun1End4.Text, Station2Gun1End4Decimal)
        Double.TryParse(TXT_Station2Gun1End5.Text, Station2Gun1End5Decimal)

        Double.TryParse(TXT_Station2Gun2Start1.Text, Station2Gun2Start1Decimal)
        Double.TryParse(TXT_Station2Gun2Start2.Text, Station2Gun2Start2Decimal)
        Double.TryParse(TXT_Station2Gun2Start3.Text, Station2Gun2Start3Decimal)
        Double.TryParse(TXT_Station2Gun2Start4.Text, Station2Gun2Start4Decimal)
        Double.TryParse(TXT_Station2Gun2Start5.Text, Station2Gun2Start5Decimal)

        Double.TryParse(TXT_Station2Gun2End1.Text, Station2Gun2End1Decimal)
        Double.TryParse(TXT_Station2Gun2End2.Text, Station2Gun2End2Decimal)
        Double.TryParse(TXT_Station2Gun2End3.Text, Station2Gun2End3Decimal)
        Double.TryParse(TXT_Station2Gun2End4.Text, Station2Gun2End4Decimal)
        Double.TryParse(TXT_Station2Gun2End5.Text, Station2Gun2End5Decimal)

        'Double.TryParse(TXT_Dimension2.Text, DimensionDecimal2)


        Dim MachineActualGlueLapDecimal As Double
        Dim MachineActualGlueWidthDecimal As Double

        Dim MachineColdDecimal As Double
        Dim MachineColdmmHotDecimal As Double

        Double.TryParse(TXT_MachineActualGlueLap.Text, MachineActualGlueLapDecimal)
        Double.TryParse(TXT_MachineActualGlueWidth.Text, MachineActualGlueWidthDecimal)
        Double.TryParse(TXT_MachineCold.Text, MachineColdDecimal)
        Double.TryParse(TXT_MachineColdmmHot.Text, MachineColdmmHotDecimal)

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
                cmd.Parameters.AddWithValue("@mspa_GLfdrbeltBBE", MachineFeederbelt)
                cmd.Parameters.AddWithValue("@mspa_GLftranbeltbox", MachineTransportRollers)
                cmd.Parameters.AddWithValue("@mspa_GLBxSquare", MachineSquareness)
                cmd.Parameters.AddWithValue("@mspa_GLBxLockSys", MachineLockingSystem)
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartn", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartnqty", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforces", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenforceval", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLFlywheel", "")
                cmd.Parameters.AddWithValue("@mspa_GLGLuegun", "")
                cmd.Parameters.AddWithValue("@mspa_GLHSSAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelap", MachineActualGlueLapDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelwid", MachineActualGlueWidthDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenEnd", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG2Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenEnd", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG3Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenEnd", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG4Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenEnd", 0.00)

                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltScrclr", "")
                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltActual", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressLow", "")
                cmd.Parameters.AddWithValue("@mspa_GLPRpressMed", "")
                cmd.Parameters.AddWithValue("@mspa_GLPRpressHigh", "")
                cmd.Parameters.AddWithValue("@mspa_GLBrush", "")
                cmd.Parameters.AddWithValue("@mspa_GLFeedrvacuum", MachineFeederVacuum)
                cmd.Parameters.AddWithValue("@mspa_GLPressarm", MachinePressArm)

                cmd.Parameters.AddWithValue("@mspa_GLS1G1startA", Station1Gun1Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startB", Station1Gun1Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startC", Station1Gun1Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startD", Station1Gun1Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startE", Station1Gun1Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endA", Station1Gun1End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endB", Station1Gun1End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endC", Station1Gun1End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endD", Station1Gun1End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endE", Station1Gun1End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startA", Station1Gun2Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startB", Station1Gun2Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startC", Station1Gun2Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startD", Station1Gun2Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startE", Station1Gun2Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endA", Station1Gun2End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endB", Station1Gun2End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endC", Station1Gun2End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endD", Station1Gun2End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endE", Station1Gun2End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startA", Station2Gun1Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startB", Station2Gun1Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startC", Station2Gun1Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startD", Station2Gun1Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startE", Station2Gun1Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endA", Station2Gun1End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endB", Station2Gun1End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endC", Station2Gun1End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endD", Station2Gun1End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endE", Station2Gun1End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startA", Station2Gun2Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startB", Station2Gun2Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startC", Station2Gun2Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startD", Station2Gun2Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startE", Station2Gun2Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endA", Station2Gun2End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endB", Station2Gun2End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endC", Station2Gun2End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endD", Station2Gun2End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endE", Station2Gun2End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_Glcold", MachineColdDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLhot", MachineColdmmHotDecimal)





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
                cmd.Parameters.AddWithValue("@mspa_GLfdrbeltBBE", MachineFeederbelt)
                cmd.Parameters.AddWithValue("@mspa_GLftranbeltbox", MachineTransportRollers)
                cmd.Parameters.AddWithValue("@mspa_GLBxSquare", MachineSquareness)
                cmd.Parameters.AddWithValue("@mspa_GLBxLockSys", MachineLockingSystem)
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartn", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartnqty", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforces", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenforceval", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLFlywheel", "")
                cmd.Parameters.AddWithValue("@mspa_GLGLuegun", "")
                cmd.Parameters.AddWithValue("@mspa_GLHSSAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelap", MachineActualGlueLapDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelwid", MachineActualGlueWidthDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLG1Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG1LenEnd", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG2Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG2LenEnd", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG3Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG3LenEnd", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG4Dotsize", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenStart", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLG4LenEnd", 0.00)

                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltScrclr", "")
                cmd.Parameters.AddWithValue("@mspa_GLFoldbeltActual", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLPRpressLow", "")
                cmd.Parameters.AddWithValue("@mspa_GLPRpressMed", "")
                cmd.Parameters.AddWithValue("@mspa_GLPRpressHigh", "")
                cmd.Parameters.AddWithValue("@mspa_GLBrush", "")
                cmd.Parameters.AddWithValue("@mspa_GLFeedrvacuum", MachineFeederVacuum)
                cmd.Parameters.AddWithValue("@mspa_GLPressarm", MachinePressArm)

                cmd.Parameters.AddWithValue("@mspa_GLS1G1startA", Station1Gun1Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startB", Station1Gun1Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startC", Station1Gun1Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startD", Station1Gun1Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1startE", Station1Gun1Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endA", Station1Gun1End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endB", Station1Gun1End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endC", Station1Gun1End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endD", Station1Gun1End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G1endE", Station1Gun1End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startA", Station1Gun2Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startB", Station1Gun2Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startC", Station1Gun2Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startD", Station1Gun2Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2startE", Station1Gun2Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endA", Station1Gun2End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endB", Station1Gun2End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endC", Station1Gun2End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endD", Station1Gun2End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS1G2endE", Station1Gun2End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startA", Station2Gun1Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startB", Station2Gun1Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startC", Station2Gun1Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startD", Station2Gun1Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1startE", Station2Gun1Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endA", Station2Gun1End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endB", Station2Gun1End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endC", Station2Gun1End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endD", Station2Gun1End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G1endE", Station2Gun1End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startA", Station2Gun2Start1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startB", Station2Gun2Start2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startC", Station2Gun2Start3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startD", Station2Gun2Start4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2startE", Station2Gun2Start5Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endA", Station2Gun2End1Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endB", Station2Gun2End2Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endC", Station2Gun2End3Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endD", Station2Gun2End4Decimal)
                cmd.Parameters.AddWithValue("@mspa_GLS2G2endE", Station2Gun2End5Decimal)
                cmd.Parameters.AddWithValue("@mspa_Glcold", MachineColdDecimal)
                cmd.Parameters.AddWithValue("@mspa_GLhot", MachineColdmmHotDecimal)





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

        Dim UC_SupervisorGluingLamina As New UC_SupervisorGluingLamina
        UC_SupervisorGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorGluingLamina.Show()
        UC_SupervisorGluingLamina.Dock = DockStyle.Fill



    End Sub

    Private Sub CHK_SelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged
        If CHK_SelectAll.Checked = True Then
            SelectAllChecked()
        Else
            SelectAllunChecked()
        End If
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

    Private Sub CBO_AsstOperator1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.SelectedIndexChanged
        con.Close()
        load_AssOperator_empnum1()
    End Sub

    Private Sub CBO_AsstOperator1_DropDown(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.DropDown
        CBO_AsstOperator1.Items.Clear()
        load_AssOperator1()
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


    Private Sub TXT_Station1Gun1Start1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1Start1.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun1Start2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1Start2.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun1Start3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1Start3.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun1Start4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1Start4.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun1Start5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1Start5.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun1End1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1End1.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun1End2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1End2.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun1End3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1End3.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun1End4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1End4.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun1End5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun1End5.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2Start1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2Start1.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2Start2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2Start2.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2Start3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2Start3.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun2Start4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2Start4.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun2Start5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2Start5.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2End1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2End1.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station1Gun2End2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2End2.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2End3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2End3.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2End4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2End4.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station1Gun2End5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station1Gun2End5.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station2Gun1Start1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1Start1.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Station2Gun1Start2_TextChanged(sender As Object, e As EventArgs) Handles TXT_Station2Gun1Start2.TextChanged

    End Sub

    Private Sub TXT_Station2Gun1Start2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1Start2.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun1Start3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1Start3.KeyPress
        NumberOnly(e)
    End Sub
    Private Sub TXT_Station2Gun1Start4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1Start4.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station2Gun1Start5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1Start5.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Station2Gun1End1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1End1.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun1End2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1End2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Station2Gun1End3_KeyPress(sender As Object, e As EventArgs) Handles TXT_Station2Gun1End3.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun1End4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1End4.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun1End5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun1End5.KeyPress
        NumberOnly(e)
    End Sub
    Private Sub TXT_Station2Gun2Start1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2Start1.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2Start2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2Start2.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2Start3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2Start3.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2Start4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2Start4.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2Start5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2Start5.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2End1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2End1.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station2Gun2End2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2End2.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Station2Gun2End3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2End3.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2End4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2End4.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Station2Gun2End5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Station2Gun2End5.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_FullBallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullBallpenQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_FullRagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullRagsQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_7BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7BallpenQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_7RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7RagsQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub RTB_JobInstruction_TextChanged(sender As Object, e As EventArgs) Handles RTB_JobInstruction.TextChanged

    End Sub

    Private Sub TXT_MachineActualGlueLap_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineActualGlueLap.TextChanged

    End Sub

    Private Sub TXT_MachineActualGlueLap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineActualGlueLap.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineActualGlueWidth_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineActualGlueWidth.TextChanged

    End Sub

    Private Sub TXT_MachineActualGlueWidth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineActualGlueWidth.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineCold_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineCold.TextChanged

    End Sub

    Private Sub TXT_MachineCold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineCold.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_MachineColdmmHot_TextChanged(sender As Object, e As EventArgs) Handles TXT_MachineColdmmHot.TextChanged

    End Sub

    Private Sub TXT_MachineColdmmHot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineColdmmHot.KeyPress
        NumberChar(e)
    End Sub
End Class
