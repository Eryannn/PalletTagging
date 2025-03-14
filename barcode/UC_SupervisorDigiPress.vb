Imports System.Data.SqlClient

Public Class UC_SupervisorDigiPress
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SelectAllDisabledCheck()
        CHK_SelectAll.Checked = False
        CHK_FullFeeder.Checked = False
        CHK_FullDelivery.Checked = False
        CHK_FullJoggerTable.Checked = False
        CHK_FullProofTray.Checked = False
        CHK_FullWasteBin.Checked = False

        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False
        CHK_GoodJoggerTable.Checked = False
        CHK_GoodFeederBridge.Checked = False
        CHK_GoodStacker.Checked = False
        CHK_GoodProoftray.Checked = False
        CHK_GoodTable.Checked = False
        CHK_GoodProperlyTagged.Checked = False
        CHK_GoodPlasticPalltes.Checked = False
        CHK_GoodWith20WallClearance.Checked = False
        CHK_GoodFollowingStandard.Checked = False
        CHK_GoodWearHair.Checked = False
        CHk_GoodWearsProperlyTucked.Checked = False
        CHk_GoodHandsWashed.Checked = False
        CHK_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaningMaterials.Checked = False
        CHK_GoodSafetyDevice.Checked = False

        CBO_MachineABoth.Text = ""
        CBO_MachineASideA.Text = ""
        CBO_MachineASideB.Text = ""
        CBO_MachineASimplex.Text = ""

        CBO_MachineBMultiShot.Text = ""
        CBO_MachineBOneShot.Text = ""

        CBO_MachineDInheritColor.Text = ""
        CBO_MachineELong.Text = ""
        CBO_MachineEShort.Text = ""
        CBO_MachineFFront.Text = ""
        CBO_MachineFRear.Text = ""
        CBO_MachineFCollate.Text = ""
        CBO_MachineGFirstFaceup.Text = ""
        CBO_MachineGFirstFaceDown.Text = ""
        CBO_MachineGLastFaceup.Text = ""
        CBO_MachineGLastFaceDown.Text = ""
        CBO_MachineGlossy.Text = ""
        CBO_MachineMatte.Text = ""
        CBO_MachineSemiMatte.Text = ""
        CBO_MachineMirror.Text = ""
        CBO_MachineRotate.Text = ""
        CBO_MachineNormal.Text = ""
        CBO_MachineTumble.Text = ""

        CBO_MachineContrast.Text = ""
        CBO_MachineBrightness.Text = ""
        CBO_MachineDotArea.Text = ""
        CBO_MachineOpticalDensity.Text = ""
        CBO_MachineColorControl.Text = ""





    End Sub
    Private Sub SelectAllChecked()
        CHK_SelectAll.Checked = True
        CHK_FullFeeder.Checked = True
        CHK_FullDelivery.Checked = True
        CHK_FullJoggerTable.Checked = True
        CHK_FullProofTray.Checked = True
        CHK_FullWasteBin.Checked = True

        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodOilChemical.Checked = True
        CHK_GoodForeignMaterials.Checked = True
        CHK_GoodJoggerTable.Checked = True
        CHK_GoodFeederBridge.Checked = True
        CHK_GoodStacker.Checked = True
        CHK_GoodProoftray.Checked = True
        CHK_GoodTable.Checked = True
        CHK_GoodProperlyTagged.Checked = True
        CHK_GoodPlasticPalltes.Checked = True
        CHK_GoodWith20WallClearance.Checked = True
        CHK_GoodFollowingStandard.Checked = True
        CHK_GoodWearHair.Checked = True
        CHk_GoodWearsProperlyTucked.Checked = True
        CHk_GoodHandsWashed.Checked = True
        CHK_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaningMaterials.Checked = True
        CHK_GoodSafetyDevice.Checked = True


        CBO_MachineABoth.Text = "✓"
        CBO_MachineASideA.Text = "✓"
        CBO_MachineASideB.Text = "✓"
        CBO_MachineASimplex.Text = "✓"

        CBO_MachineBMultiShot.Text = "✓"
        CBO_MachineBOneShot.Text = "✓"

        CBO_MachineDInheritColor.Text = "✓"
        CBO_MachineELong.Text = "✓"
        CBO_MachineEShort.Text = "✓"
        CBO_MachineFFront.Text = "✓"
        CBO_MachineFRear.Text = "✓"
        CBO_MachineFCollate.Text = "✓"
        CBO_MachineGFirstFaceup.Text = "✓"
        CBO_MachineGFirstFaceDown.Text = "✓"
        CBO_MachineGLastFaceup.Text = "✓"
        CBO_MachineGLastFaceDown.Text = "✓"
        CBO_MachineGlossy.Text = "✓"
        CBO_MachineMatte.Text = "✓"
        CBO_MachineSemiMatte.Text = "✓"
        CBO_MachineMirror.Text = "✓"
        CBO_MachineRotate.Text = "✓"
        CBO_MachineNormal.Text = "✓"
        CBO_MachineTumble.Text = "✓"

        CBO_MachineContrast.Text = "✓"
        CBO_MachineBrightness.Text = "✓"
        CBO_MachineDotArea.Text = "✓"
        CBO_MachineOpticalDensity.Text = "✓"
        CBO_MachineColorControl.Text = "✓"


    End Sub
    Private Sub EnabledSupervisorForm()
        CHK_SelectAll.Enabled = True
        CHK_FullFeeder.Enabled = True
        CHK_FullDelivery.Enabled = True
        CHK_FullJoggerTable.Enabled = True
        CHK_FullProofTray.Enabled = True
        CHK_FullWasteBin.Enabled = True
        TXT_BallpenQty.Enabled = True
        TXT_RagsQty.Enabled = True
        TXT_StrippingKnifeQty1.Enabled = True
        TXT_StrippingKnifeQty2.Enabled = True

        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodOilChemical.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True
        CHK_GoodJoggerTable.Enabled = True
        CHK_GoodFeederBridge.Enabled = True
        CHK_GoodStacker.Enabled = True
        CHK_GoodProoftray.Enabled = True
        CHK_GoodTable.Enabled = True
        CHK_GoodProperlyTagged.Enabled = True
        CHK_GoodPlasticPalltes.Enabled = True
        CHK_GoodWith20WallClearance.Enabled = True
        CHK_GoodFollowingStandard.Enabled = True
        CHK_GoodWearHair.Enabled = True
        CHk_GoodWearsProperlyTucked.Enabled = True
        CHk_GoodHandsWashed.Enabled = True
        CHK_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaningMaterials.Enabled = True
        CHK_GoodSafetyDevice.Enabled = True

        RTB_JobInstruction.Enabled = True
        TXT_OperatorNumSupervisor.Enabled = True
        TXT_OperatorUCSupervisor.Enabled = True
        DTPOperator.Enabled = True
        CBO_AsstOperator1.Enabled = True
        TXT_AsstOperator1.Enabled = True
        DTP_AsstOperator1.Enabled = True
        CBO_Helper1.Enabled = True
        TXT_Helper1.Enabled = True
        DTPHelper1.Enabled = True

        CBO_MachineABoth.Enabled = True
        CBO_MachineASideA.Enabled = True
        CBO_MachineASideB.Enabled = True
        CBO_MachineASimplex.Enabled = True
        CBO_MachineBMultiShot.Enabled = True
        CBO_MachineBOneShot.Enabled = True
        TXT_MachineCSubstrate.Enabled = True
        TXT_MachineCWeight.Enabled = True
        TXT_MachineCThickness.Enabled = True
        CBO_MachineDInheritColor.Enabled = True
        CBO_MachineELong.Enabled = True
        CBO_MachineEShort.Enabled = True
        CBO_MachineFFront.Enabled = True
        CBO_MachineFRear.Enabled = True
        CBO_MachineFCollate.Enabled = True
        CBO_MachineGFirstFaceup.Enabled = True
        CBO_MachineGFirstFaceDown.Enabled = True
        CBO_MachineGLastFaceup.Enabled = True
        CBO_MachineGLastFaceDown.Enabled = True

        CBO_MachineGlossy.Enabled = True
        CBO_MachineSemiMatte.Enabled = True
        CBO_MachineMatte.Enabled = True

        TXT_MachineJLutName.Enabled = True
        CBO_MachineMirror.Enabled = True
        CBO_MachineNormal.Enabled = True
        CBO_MachineRotate.Enabled = True
        CBO_MachineTumble.Enabled = True

        CBO_MachineContrast.Enabled = True
        CBO_MachineBrightness.Enabled = True
        CBO_MachineDotArea.Enabled = True
        CBO_MachineOpticalDensity.Enabled = True
        CBO_MachineColorControl.Enabled = True

        CBO_MachineC1.Enabled = True
        CBO_MachineC2.Enabled = True
        CBO_MachineC3.Enabled = True
        CBO_MachineC4.Enabled = True
        CBO_MachineC5.Enabled = True

        CBO_MachineM1.Enabled = True
        CBO_MachineM2.Enabled = True
        CBO_MachineM3.Enabled = True
        CBO_MachineM4.Enabled = True
        CBO_MachineM5.Enabled = True

        CBO_MachineY1.Enabled = True
        CBO_MachineY2.Enabled = True
        CBO_MachineY3.Enabled = True
        CBO_MachineY4.Enabled = True
        CBO_MachineY5.Enabled = True

        CBO_MachineK1.Enabled = True
        CBO_MachineK2.Enabled = True
        CBO_MachineK3.Enabled = True
        CBO_MachineK4.Enabled = True
        CBO_MachineK5.Enabled = True

        CBO_MachineO1.Enabled = True
        CBO_MachineO2.Enabled = True
        CBO_MachineO3.Enabled = True
        CBO_MachineO4.Enabled = True
        CBO_MachineO5.Enabled = True

        CBO_MachineG1.Enabled = True
        CBO_MachineG2.Enabled = True
        CBO_MachineG3.Enabled = True
        CBO_MachineG4.Enabled = True
        CBO_MachineG5.Enabled = True

        CBO_MachineV1.Enabled = True
        CBO_MachineV2.Enabled = True
        CBO_MachineV3.Enabled = True
        CBO_MachineV4.Enabled = True
        CBO_MachineV5.Enabled = True

        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True
        TXT_7Marker.Enabled = True
        BTN_Save_Supervisor.Enabled = True

    End Sub

    Private Sub DisabledSupervisorForm()
        CHK_SelectAll.Enabled = False
        CHK_FullFeeder.Enabled = False
        CHK_FullDelivery.Enabled = False
        CHK_FullJoggerTable.Enabled = False
        CHK_FullProofTray.Enabled = False
        CHK_FullWasteBin.Enabled = False
        TXT_BallpenQty.Enabled = False
        TXT_RagsQty.Enabled = False
        TXT_StrippingKnifeQty1.Enabled = False
        TXT_StrippingKnifeQty2.Enabled = False

        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodOilChemical.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False
        CHK_GoodJoggerTable.Enabled = False
        CHK_GoodFeederBridge.Enabled = False
        CHK_GoodStacker.Enabled = False
        CHK_GoodProoftray.Enabled = False
        CHK_GoodTable.Enabled = False
        CHK_GoodProperlyTagged.Enabled = False
        CHK_GoodPlasticPalltes.Enabled = False
        CHK_GoodWith20WallClearance.Enabled = False
        CHK_GoodFollowingStandard.Enabled = False
        CHK_GoodWearHair.Enabled = False
        CHk_GoodWearsProperlyTucked.Enabled = False
        CHk_GoodHandsWashed.Enabled = False
        CHK_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaningMaterials.Enabled = False
        CHK_GoodSafetyDevice.Enabled = False

        RTB_JobInstruction.Enabled = False
        TXT_OperatorNumSupervisor.Enabled = False
        TXT_OperatorUCSupervisor.Enabled = False
        DTPOperator.Enabled = False
        CBO_AsstOperator1.Enabled = False
        TXT_AsstOperator1.Enabled = False
        DTP_AsstOperator1.Enabled = False
        CBO_Helper1.Enabled = False
        TXT_Helper1.Enabled = False
        DTPHelper1.Enabled = False

        CBO_MachineABoth.Enabled = False
        CBO_MachineASideA.Enabled = False
        CBO_MachineASideB.Enabled = False
        CBO_MachineASimplex.Enabled = False
        CBO_MachineBMultiShot.Enabled = False
        CBO_MachineBOneShot.Enabled = False
        TXT_MachineCSubstrate.Enabled = False
        TXT_MachineCWeight.Enabled = False
        TXT_MachineCThickness.Enabled = False
        CBO_MachineDInheritColor.Enabled = False
        CBO_MachineELong.Enabled = False
        CBO_MachineEShort.Enabled = False
        CBO_MachineFFront.Enabled = False
        CBO_MachineFRear.Enabled = False
        CBO_MachineFCollate.Enabled = False
        CBO_MachineGFirstFaceup.Enabled = False
        CBO_MachineGFirstFaceDown.Enabled = False
        CBO_MachineGLastFaceup.Enabled = False
        CBO_MachineGLastFaceDown.Enabled = False

        CBO_MachineGlossy.Enabled = False
        CBO_MachineSemiMatte.Enabled = False
        CBO_MachineMatte.Enabled = False

        TXT_MachineJLutName.Enabled = False
        CBO_MachineMirror.Enabled = False
        CBO_MachineNormal.Enabled = False
        CBO_MachineRotate.Enabled = False
        CBO_MachineTumble.Enabled = False

        CBO_MachineContrast.Enabled = False
        CBO_MachineBrightness.Enabled = False
        CBO_MachineDotArea.Enabled = False
        CBO_MachineOpticalDensity.Enabled = False
        CBO_MachineColorControl.Enabled = False

        CBO_MachineC1.Enabled = False
        CBO_MachineC2.Enabled = False
        CBO_MachineC3.Enabled = False
        CBO_MachineC4.Enabled = False
        CBO_MachineC5.Enabled = False

        CBO_MachineM1.Enabled = False
        CBO_MachineM2.Enabled = False
        CBO_MachineM3.Enabled = False
        CBO_MachineM4.Enabled = False
        CBO_MachineM5.Enabled = False

        CBO_MachineY1.Enabled = False
        CBO_MachineY2.Enabled = False
        CBO_MachineY3.Enabled = False
        CBO_MachineY4.Enabled = False
        CBO_MachineY5.Enabled = False

        CBO_MachineK1.Enabled = False
        CBO_MachineK2.Enabled = False
        CBO_MachineK3.Enabled = False
        CBO_MachineK4.Enabled = False
        CBO_MachineK5.Enabled = False

        CBO_MachineO1.Enabled = False
        CBO_MachineO2.Enabled = False
        CBO_MachineO3.Enabled = False
        CBO_MachineO4.Enabled = False
        CBO_MachineO5.Enabled = False

        CBO_MachineG1.Enabled = False
        CBO_MachineG2.Enabled = False
        CBO_MachineG3.Enabled = False
        CBO_MachineG4.Enabled = False
        CBO_MachineG5.Enabled = False

        CBO_MachineV1.Enabled = False
        CBO_MachineV2.Enabled = False
        CBO_MachineV3.Enabled = False
        CBO_MachineV4.Enabled = False
        CBO_MachineV5.Enabled = False

        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False
        TXT_7Marker.Enabled = False
        BTN_Save_Supervisor.Enabled = False



    End Sub


    Private Sub UC_SupervisorDigiPress_Load(sender As Object, e As EventArgs) Handles MyBase.Load






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




                    If dr("flc_joggerTable").ToString() = "O" Then
                        CHK_FullJoggerTable.Checked = True
                    Else
                        CHK_FullJoggerTable.Checked = False
                    End If

                    If dr("flc_wasteBin").ToString() = "O" Then
                        CHK_FullWasteBin.Checked = True
                    Else
                        CHK_FullWasteBin.Checked = False
                    End If


                    If dr("flc_proofTray").ToString() = "O" Then
                        CHK_FullProofTray.Checked = True
                    Else
                        CHK_FullProofTray.Checked = False
                    End If





                    TXT_BallpenQty.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_RagsQty.Text = dr("flc_OLCragqty").ToString()
                    TXT_StrippingKnifeQty1.Text = dr("flc_OLCstripknife").ToString()
                    TXT_StrippingKnifeQty2.Text = dr("flc_OLCstripbld").ToString()
                    TXT_MarkerQty.Text = dr("flc_OLCmarkerqty").ToString


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





                    If dr("gmp_SaniJoggerTable").ToString() = "O" Then
                        CHK_GoodJoggerTable.Checked = True
                    Else
                        CHK_GoodJoggerTable.Checked = False
                    End If


                    If dr("gmp_SaniFeederbridge").ToString() = "O" Then
                        CHK_GoodFeederBridge.Checked = True
                    Else
                        CHK_GoodFeederBridge.Checked = False
                    End If




                    If dr("gmp_SaniStacker").ToString() = "O" Then
                        CHK_GoodStacker.Checked = True
                    Else
                        CHK_GoodStacker.Checked = False
                    End If

                    If dr("gmp_SaniProoftray").ToString() = "O" Then
                        CHK_GoodProoftray.Checked = True
                    Else
                        CHK_GoodProoftray.Checked = False
                    End If

                    If dr("gmp_SaniTable").ToString() = "O" Then
                        CHK_GoodTable.Checked = True
                    Else
                        CHK_GoodTable.Checked = False
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


                    If dr("gmp_Pre20inClearance").ToString() = "O" Then
                        CHK_GoodWith20WallClearance.Checked = True
                    Else
                        CHK_GoodWith20WallClearance.Checked = False
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



        TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text
        Dim AssOperator1 As String = ""


        Dim helper1 As String = ""


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

                    If dr("mspa_Sdboth").ToString() = "O" Then
                        CBO_MachineABoth.Text = "✓"
                    Else
                        CBO_MachineABoth.Text = "N/A"
                    End If

                    If dr("mspa_SDsideA").ToString() = "O" Then
                        CBO_MachineASideA.Text = "✓"
                    Else
                        CBO_MachineASideA.Text = "N/A"
                    End If


                    If dr("mspa_SDsideB").ToString() = "O" Then
                        CBO_MachineASideB.Text = "✓"
                    Else
                        CBO_MachineASideB.Text = "N/A"
                    End If

                    If dr("mspa_SDsimplex").ToString() = "O" Then
                        CBO_MachineASimplex.Text = "✓"
                    Else
                        CBO_MachineASimplex.Text = "N/A"
                    End If






                    'B
                    If dr("mspa_PMmulshot").ToString() = "O" Then
                        CBO_MachineBMultiShot.Text = "✓"
                    Else
                        CBO_MachineBMultiShot.Text = "N/A"
                    End If


                    If dr("mspa_PM1shot").ToString() = "O" Then
                        CBO_MachineBOneShot.Text = "✓"
                    Else
                        CBO_MachineBOneShot.Text = "N/A"
                    End If




                    'C
                    TXT_MachineCSubstrate.Text = dr("mspa_SUdesc").ToString()
                    TXT_MachineCWeight.Text = dr("mspa_SUweight").ToString()
                    TXT_MachineCThickness.Text = dr("mspa_SUthickness").ToString()





                    'D
                    If dr("mspa_CPinhertcolor").ToString() = "O" Then
                        CBO_MachineDInheritColor.Text = "✓"
                    Else
                        CBO_MachineDInheritColor.Text = "N/A"
                    End If


                    'E


                    If dr("mspa_GDLong").ToString() = "O" Then
                        CBO_MachineELong.Text = "✓"
                    Else
                        CBO_MachineELong.Text = "N/A"
                    End If

                    If dr("mspa_GDShort").ToString() = "O" Then
                        CBO_MachineEShort.Text = "✓"
                    Else
                        CBO_MachineEShort.Text = "N/A"
                    End If



                    'F

                    If dr("mspa_SAfront").ToString() = "O" Then
                        CBO_MachineFFront.Text = "✓"
                    Else
                        CBO_MachineFFront.Text = "N/A"
                    End If


                    If dr("mspa_SArear").ToString() = "O" Then
                        CBO_MachineFRear.Text = "✓"
                    Else
                        CBO_MachineFRear.Text = "N/A"
                    End If


                    If dr("mspa_SAcollate").ToString() = "O" Then
                        CBO_MachineFCollate.Text = "✓"
                    Else
                        CBO_MachineFCollate.Text = "N/A"
                    End If


                    'G


                    If dr("mspa_SJFLFU").ToString() = "O" Then
                        CBO_MachineGFirstFaceup.Text = "✓"
                    Else
                        CBO_MachineGFirstFaceup.Text = "N/A"
                    End If


                    If dr("mspa_SJFLFD").ToString() = "O" Then
                        CBO_MachineGFirstFaceDown.Text = "✓"
                    Else
                        CBO_MachineGFirstFaceDown.Text = "N/A"
                    End If


                    If dr("mspa_SJLFFU").ToString() = "O" Then
                        CBO_MachineGLastFaceup.Text = "✓"
                    Else
                        CBO_MachineGLastFaceup.Text = "N/A"
                    End If


                    If dr("mspa_SJLFFD").ToString() = "O" Then
                        CBO_MachineGLastFaceDown.Text = "✓"
                    Else
                        CBO_MachineGLastFaceDown.Text = "N/A"
                    End If



                    'H

                    If dr("mspa_GLglossy").ToString() = "O" Then
                        CBO_MachineGlossy.Text = "✓"
                    Else
                        CBO_MachineGlossy.Text = "N/A"
                    End If

                    If dr("mspa_GLmatte").ToString() = "O" Then
                        CBO_MachineMatte.Text = "✓"
                    Else
                        CBO_MachineMatte.Text = "N/A"
                    End If

                    If dr("mspa_GLsemimatte").ToString() = "O" Then
                        CBO_MachineSemiMatte.Text = "✓"
                    Else
                        CBO_MachineSemiMatte.Text = "N/A"
                    End If




                    'I


                    If dr("mspa_IPmirror").ToString() = "O" Then
                        CBO_MachineMirror.Text = "✓"
                    Else
                        CBO_MachineMirror.Text = "N/A"
                    End If

                    If dr("mspa_IProtate").ToString() = "O" Then
                        CBO_MachineRotate.Text = "✓"
                    Else
                        CBO_MachineRotate.Text = "N/A"
                    End If

                    If dr("mspa_IPnormal").ToString() = "O" Then
                        CBO_MachineNormal.Text = "✓"
                    Else
                        CBO_MachineNormal.Text = "N/A"
                    End If

                    If dr("mspa_IPtumble").ToString() = "O" Then
                        CBO_MachineTumble.Text = "✓"
                    Else
                        CBO_MachineTumble.Text = "N/A"
                    End If


                    'J
                    TXT_MachineJLutName.Text = dr("mspa_CCLUTname").ToString()



                    If dr("mspa_CCcontrast").ToString() = "O" Then
                        CBO_MachineContrast.Text = "✓"
                    Else
                        CBO_MachineContrast.Text = "N/A"
                    End If


                    If dr("mspa_CCbrightness").ToString() = "O" Then
                        CBO_MachineBrightness.Text = "✓"
                    Else
                        CBO_MachineBrightness.Text = "N/A"
                    End If


                    If dr("mspa_CCdot50per").ToString() = "O" Then
                        CBO_MachineDotArea.Text = "✓"
                    Else
                        CBO_MachineDotArea.Text = "N/A"
                    End If


                    If dr("mspa_CCopticdenadj").ToString() = "O" Then
                        CBO_MachineOpticalDensity.Text = "✓"
                    Else
                        CBO_MachineOpticalDensity.Text = "N/A"
                    End If



                    'K


                    If dr("mspa_CATP").ToString() = "O" Then
                        CBO_MachineColorControl.Text = "✓"
                    Else
                        CBO_MachineColorControl.Text = "N/A"
                    End If

                    'LETTER C

                    If dr("mspa_CCC1").ToString() = "O" Then
                        CBO_MachineC1.Text = "✓"
                    ElseIf dr("mspa_CCC1").ToString() = "N" Then
                        CBO_MachineC1.Text = "N/A"
                    Else
                        CBO_MachineC1.Text = dr("mspa_CCC1").ToString()
                    End If


                    If dr("mspa_CCC2").ToString() = "O" Then
                        CBO_MachineC2.Text = "✓"
                    ElseIf dr("mspa_CCC2").ToString() = "N" Then
                        CBO_MachineC2.Text = "N/A"
                    Else
                        CBO_MachineC2.Text = dr("mspa_CCC2").ToString()
                    End If


                    If dr("mspa_CCC3").ToString() = "O" Then
                        CBO_MachineC3.Text = "✓"
                    ElseIf dr("mspa_CCC3").ToString() = "N" Then
                        CBO_MachineC3.Text = "N/A"
                    Else
                        CBO_MachineC3.Text = dr("mspa_CCC3").ToString()
                    End If


                    If dr("mspa_CCC4").ToString() = "O" Then
                        CBO_MachineC4.Text = "✓"
                    ElseIf dr("mspa_CCC4").ToString() = "N" Then
                        CBO_MachineC4.Text = "N/A"
                    Else
                        CBO_MachineC4.Text = dr("mspa_CCC4").ToString()
                    End If


                    If dr("mspa_CCC5").ToString() = "O" Then
                        CBO_MachineC5.Text = "✓"
                    ElseIf dr("mspa_CCC5").ToString() = "N" Then
                        CBO_MachineC5.Text = "N/A"
                    Else
                        CBO_MachineC5.Text = dr("mspa_CCC5").ToString()
                    End If


                    'LETTER M

                    If dr("mspa_CCM1").ToString() = "O" Then
                        CBO_MachineM1.Text = "✓"
                    ElseIf dr("mspa_CCM1").ToString() = "N" Then
                        CBO_MachineM1.Text = "N/A"
                    Else
                        CBO_MachineM1.Text = dr("mspa_CCM1").ToString()
                    End If


                    If dr("mspa_CCM2").ToString() = "O" Then
                        CBO_MachineM2.Text = "✓"
                    ElseIf dr("mspa_CCM2").ToString() = "N" Then
                        CBO_MachineM2.Text = "N/A"
                    Else
                        CBO_MachineM2.Text = dr("mspa_CCM2").ToString()
                    End If


                    If dr("mspa_CCM3").ToString() = "O" Then
                        CBO_MachineM3.Text = "✓"
                    ElseIf dr("mspa_CCM3").ToString() = "N" Then
                        CBO_MachineM3.Text = "N/A"
                    Else
                        CBO_MachineM3.Text = dr("mspa_CCM3").ToString()
                    End If


                    If dr("mspa_CCM4").ToString() = "O" Then
                        CBO_MachineM4.Text = "✓"
                    ElseIf dr("mspa_CCM4").ToString() = "N" Then
                        CBO_MachineM4.Text = "N/A"
                    Else
                        CBO_MachineM4.Text = dr("mspa_CCM4").ToString()
                    End If


                    If dr("mspa_CCM5").ToString() = "O" Then
                        CBO_MachineM5.Text = "✓"
                    ElseIf dr("mspa_CCM5").ToString() = "N" Then
                        CBO_MachineM5.Text = "N/A"
                    Else
                        CBO_MachineM5.Text = dr("mspa_CCM5").ToString()
                    End If


                    'LETTER Y


                    If dr("mspa_CCY1").ToString() = "O" Then
                        CBO_MachineY1.Text = "✓"
                    ElseIf dr("mspa_CCY1").ToString() = "N" Then
                        CBO_MachineY1.Text = "N/A"
                    Else
                        CBO_MachineY1.Text = dr("mspa_CCY1").ToString()
                    End If


                    If dr("mspa_CCY2").ToString() = "O" Then
                        CBO_MachineY2.Text = "✓"
                    ElseIf dr("mspa_CCY2").ToString() = "N" Then
                        CBO_MachineY2.Text = "N/A"
                    Else
                        CBO_MachineY2.Text = dr("mspa_CCY2").ToString()
                    End If

                    If dr("mspa_CCY3").ToString() = "O" Then
                        CBO_MachineY3.Text = "✓"
                    ElseIf dr("mspa_CCY3").ToString() = "N" Then
                        CBO_MachineY3.Text = "N/A"
                    Else
                        CBO_MachineY3.Text = dr("mspa_CCY3").ToString()
                    End If


                    If dr("mspa_CCY4").ToString() = "O" Then
                        CBO_MachineY4.Text = "✓"
                    ElseIf dr("mspa_CCY4").ToString() = "N" Then
                        CBO_MachineY4.Text = "N/A"
                    Else
                        CBO_MachineY4.Text = dr("mspa_CCY4").ToString()
                    End If


                    If dr("mspa_CCY5").ToString() = "O" Then
                        CBO_MachineY5.Text = "✓"
                    ElseIf dr("mspa_CCY5").ToString() = "N" Then
                        CBO_MachineY5.Text = "N/A"
                    Else
                        CBO_MachineY5.Text = dr("mspa_CCY5").ToString()
                    End If


                    'LETTER K


                    If dr("mspa_CCK1").ToString() = "O" Then
                        CBO_MachineK1.Text = "✓"
                    ElseIf dr("mspa_CCK1").ToString() = "N" Then
                        CBO_MachineK1.Text = "N/A"
                    Else
                        CBO_MachineK1.Text = dr("mspa_CCK1").ToString()
                    End If


                    If dr("mspa_CCK2").ToString() = "O" Then
                        CBO_MachineK2.Text = "✓"
                    ElseIf dr("mspa_CCK2").ToString() = "N" Then
                        CBO_MachineK2.Text = "N/A"
                    Else
                        CBO_MachineK2.Text = dr("mspa_CCK2").ToString()
                    End If



                    If dr("mspa_CCK3").ToString() = "O" Then
                        CBO_MachineK3.Text = "✓"
                    ElseIf dr("mspa_CCK3").ToString() = "N" Then
                        CBO_MachineK3.Text = "N/A"
                    Else
                        CBO_MachineK3.Text = dr("mspa_CCK3").ToString()
                    End If



                    If dr("mspa_CCK4").ToString() = "O" Then
                        CBO_MachineK4.Text = "✓"
                    ElseIf dr("mspa_CCK4").ToString() = "N" Then
                        CBO_MachineK4.Text = "N/A"
                    Else
                        CBO_MachineK4.Text = dr("mspa_CCK4").ToString()
                    End If



                    If dr("mspa_CCK5").ToString() = "O" Then
                        CBO_MachineK5.Text = "✓"
                    ElseIf dr("mspa_CCK5").ToString() = "N" Then
                        CBO_MachineK5.Text = "N/A"
                    Else
                        CBO_MachineK5.Text = dr("mspa_CCK5").ToString()
                    End If


                    'LETTER O


                    If dr("mspa_CCO1").ToString() = "O" Then
                        CBO_MachineO1.Text = "✓"
                    ElseIf dr("mspa_CCO1").ToString() = "N" Then
                        CBO_MachineO1.Text = "N/A"
                    Else
                        CBO_MachineO1.Text = dr("mspa_CCO1").ToString()
                    End If

                    If dr("mspa_CCO2").ToString() = "O" Then
                        CBO_MachineO2.Text = "✓"
                    ElseIf dr("mspa_CCO2").ToString() = "N" Then
                        CBO_MachineO2.Text = "N/A"
                    Else
                        CBO_MachineO2.Text = dr("mspa_CCO2").ToString()
                    End If

                    If dr("mspa_CCO3").ToString() = "O" Then
                        CBO_MachineO3.Text = "✓"
                    ElseIf dr("mspa_CCO3").ToString() = "N" Then
                        CBO_MachineO3.Text = "N/A"
                    Else
                        CBO_MachineO3.Text = dr("mspa_CCO3").ToString()
                    End If

                    If dr("mspa_CCO4").ToString() = "O" Then
                        CBO_MachineO4.Text = "✓"
                    ElseIf dr("mspa_CCO4").ToString() = "N" Then
                        CBO_MachineO4.Text = "N/A"
                    Else
                        CBO_MachineO4.Text = dr("mspa_CCO4").ToString()
                    End If

                    If dr("mspa_CCO5").ToString() = "O" Then
                        CBO_MachineO5.Text = "✓"
                    ElseIf dr("mspa_CCO5").ToString() = "N" Then
                        CBO_MachineO5.Text = "N/A"
                    Else
                        CBO_MachineO5.Text = dr("mspa_CCO5").ToString()
                    End If


                    'LETTER G

                    If dr("mspa_CCG1").ToString() = "O" Then
                        CBO_MachineG1.Text = "✓"
                    ElseIf dr("mspa_CCG1").ToString() = "N" Then
                        CBO_MachineG1.Text = "N/A"
                    Else
                        CBO_MachineG1.Text = dr("mspa_CCG1").ToString()
                    End If

                    If dr("mspa_CCG2").ToString() = "O" Then
                        CBO_MachineG2.Text = "✓"
                    ElseIf dr("mspa_CCG2").ToString() = "N" Then
                        CBO_MachineG2.Text = "N/A"
                    Else
                        CBO_MachineG2.Text = dr("mspa_CCG2").ToString()
                    End If


                    If dr("mspa_CCG3").ToString() = "O" Then
                        CBO_MachineG3.Text = "✓"
                    ElseIf dr("mspa_CCG3").ToString() = "N" Then
                        CBO_MachineG3.Text = "N/A"
                    Else
                        CBO_MachineG3.Text = dr("mspa_CCG3").ToString()
                    End If


                    If dr("mspa_CCG4").ToString() = "O" Then
                        CBO_MachineG4.Text = "✓"
                    ElseIf dr("mspa_CCG4").ToString() = "N" Then
                        CBO_MachineG4.Text = "N/A"
                    Else
                        CBO_MachineG4.Text = dr("mspa_CCG4").ToString()
                    End If


                    If dr("mspa_CCG5").ToString() = "O" Then
                        CBO_MachineG5.Text = "✓"
                    ElseIf dr("mspa_CCG5").ToString() = "N" Then
                        CBO_MachineG5.Text = "N/A"
                    Else
                        CBO_MachineG5.Text = dr("mspa_CCG5").ToString()
                    End If







                    'LETTER V
                    If dr("mspa_CCV1").ToString() = "O" Then
                        CBO_MachineV1.Text = "✓"
                    ElseIf dr("mspa_CCV1").ToString() = "N" Then
                        CBO_MachineV1.Text = "N/A"
                    Else
                        CBO_MachineV1.Text = dr("mspa_CCV1").ToString()
                    End If

                    If dr("mspa_CCV2").ToString() = "O" Then
                        CBO_MachineV2.Text = "✓"
                    ElseIf dr("mspa_CCV2").ToString() = "N" Then
                        CBO_MachineV2.Text = "N/A"
                    Else
                        CBO_MachineV2.Text = dr("mspa_CCV2").ToString()
                    End If

                    If dr("mspa_CCV3").ToString() = "O" Then
                        CBO_MachineV3.Text = "✓"
                    ElseIf dr("mspa_CCV3").ToString() = "N" Then
                        CBO_MachineV3.Text = "N/A"
                    Else
                        CBO_MachineV3.Text = dr("mspa_CCV3").ToString()
                    End If

                    If dr("mspa_CCV4").ToString() = "O" Then
                        CBO_MachineV4.Text = "✓"
                    ElseIf dr("mspa_CCV4").ToString() = "N" Then
                        CBO_MachineV4.Text = "N/A"
                    Else
                        CBO_MachineV4.Text = dr("mspa_CCV4").ToString()
                    End If

                    If dr("mspa_CCV5").ToString() = "O" Then
                        CBO_MachineV5.Text = "✓"
                    ElseIf dr("mspa_CCV5").ToString() = "N" Then
                        CBO_MachineV5.Text = "N/A"
                    Else
                        CBO_MachineV5.Text = dr("mspa_CCV5").ToString()
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
                    TXT_7Marker.Text = dr("markerqty").ToString()
                    TXT_7StrippingKnifeQty1.Text = dr("stripknife").ToString()
                    TXT_7StrippingKnifeQty2.Text = dr("stripknifebld").ToString()

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



    Private Sub CHK_SelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged
        If CHK_SelectAll.Checked = True Then
            SelectAllChecked()
        Else
            SelectAllDisabledCheck()
        End If
    End Sub

    Private Sub BTN_Save_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Save_Supervisor.Click
        'FULL LINE CLearance variable
        Dim FullCutTable As String = ""
        Dim FullDelivery As String = ""
        Dim FullJoggerTable As String = ""
        Dim FullProofTray As String = ""
        Dim FullWasteBin As String = ""
        Dim FullFeeder As String = ""

        If CHK_FullFeeder.Checked Then
            FullFeeder = "O"
        Else
            FullFeeder = "X"
        End If

        If CHK_FullFeeder.Checked Then
            FullCutTable = "O"
        Else
            FullCutTable = "X"
        End If


        If CHK_FullDelivery.Checked Then
            FullDelivery = "O"
        Else
            FullDelivery = "X"
        End If


        If CHK_FullJoggerTable.Checked Then
            FullJoggerTable = "O"
        Else
            FullJoggerTable = "X"
        End If


        If CHK_FullProofTray.Checked Then
            FullProofTray = "O"
        Else
            FullProofTray = "X"
        End If


        If CHK_FullWasteBin.Checked Then
            FullWasteBin = "O"
        Else
            FullWasteBin = "X"
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBin)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", FullJoggerTable)
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", FullCutTable)
                cmd.Parameters.AddWithValue("@flc_palletTag", "")
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
                cmd.Parameters.AddWithValue("@flc_rotatingTable", "")
                cmd.Parameters.AddWithValue("@flc_workingTable", "")
                cmd.Parameters.AddWithValue("@flc_Lifter", "")
                cmd.Parameters.AddWithValue("@flc_Others", "")
                cmd.Parameters.AddWithValue("@flc_glue", "")
                cmd.Parameters.AddWithValue("@flc_FinSpoilagePrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinProductPrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsNotReqd", "")
                cmd.Parameters.AddWithValue("@flc_FinQualityLimits", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsSupplies", "")
                cmd.Parameters.AddWithValue("@flc_FinRefDoc", "")
                cmd.Parameters.AddWithValue("@flc_proofTray", FullProofTray)
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", "")
                cmd.Parameters.AddWithValue("@flc_OffInkFr", "")
                cmd.Parameters.AddWithValue("@flc_OffInkTo", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilTo  ", "")
                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_BallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_RagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", TXT_StrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", TXT_StrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_MarkerQty.Text)
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
                cmd.Parameters.AddWithValue("@flc_cuttingtable", FullCutTable)
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBin)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", FullJoggerTable)
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", FullCutTable)
                cmd.Parameters.AddWithValue("@flc_palletTag", "")
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
                cmd.Parameters.AddWithValue("@flc_rotatingTable", "")
                cmd.Parameters.AddWithValue("@flc_workingTable", "")
                cmd.Parameters.AddWithValue("@flc_Lifter", "")
                cmd.Parameters.AddWithValue("@flc_Others", "")
                cmd.Parameters.AddWithValue("@flc_glue", "")
                cmd.Parameters.AddWithValue("@flc_FinSpoilagePrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinProductPrevJob", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsNotReqd", "")
                cmd.Parameters.AddWithValue("@flc_FinQualityLimits", "")
                cmd.Parameters.AddWithValue("@flc_FinMatlsSupplies", "")
                cmd.Parameters.AddWithValue("@flc_FinRefDoc", "")
                cmd.Parameters.AddWithValue("@flc_proofTray", FullProofTray)
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", "")
                cmd.Parameters.AddWithValue("@flc_OffInkFr", "")
                cmd.Parameters.AddWithValue("@flc_OffInkTo", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilTo  ", "")
                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_BallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_RagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", TXT_StrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", TXT_StrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_MarkerQty.Text)
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





        Try

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


            Dim GoodJoggerTable As String = ""
            Dim GoodFeederBridge As String = ""
            Dim GoodStacker As String = ""
            Dim GoodProoftray As String = ""
            Dim GoodTable As String = ""


            If CHK_GoodJoggerTable.Checked Then
                GoodJoggerTable = "O"
            Else
                GoodJoggerTable = "X"
            End If



            If CHK_GoodFeederBridge.Checked Then
                GoodFeederBridge = "O"
            Else
                GoodFeederBridge = "X"
            End If



            If CHK_GoodStacker.Checked Then
                GoodStacker = "O"
            Else
                GoodStacker = "X"
            End If



            If CHK_GoodProoftray.Checked Then
                GoodProoftray = "O"
            Else
                GoodProoftray = "X"
            End If


            If CHK_GoodTable.Checked Then
                GoodTable = "O"
            Else
                GoodTable = "X"
            End If





            Dim GoodProperlyTagged As String = ""
            Dim GoodPlasticPallets As String = ""
            Dim GoodWith20Wall As String = ""
            Dim GoodFollowingStandardPall As String = ""


            If CHK_GoodProperlyTagged.Checked Then
                GoodProperlyTagged = "O"
            Else
                GoodProperlyTagged = "X"
            End If


            If CHK_GoodPlasticPalltes.Checked Then
                GoodPlasticPallets = "O"
            Else
                GoodPlasticPallets = "X"
            End If



            If CHK_GoodWith20WallClearance.Checked Then
                GoodWith20Wall = "O"
            Else
                GoodWith20Wall = "X"
            End If



            If CHK_GoodFollowingStandard.Checked Then
                GoodFollowingStandardPall = "O"
            Else
                GoodFollowingStandardPall = "X"
            End If





            Dim GoodWearHairCovers As String = ""
            Dim GoodWearProperlyTuckedIn As String = ""
            Dim GoodHandsWashed As String = ""


            If CHK_GoodWearHair.Checked Then
                GoodWearHairCovers = "O"
            Else
                GoodWearHairCovers = "X"
            End If



            If CHk_GoodWearsProperlyTucked.Checked Then
                GoodWearProperlyTuckedIn = "O"
            Else
                GoodWearProperlyTuckedIn = "X"
            End If


            If CHk_GoodHandsWashed.Checked Then
                GoodHandsWashed = "O"
            Else
                GoodHandsWashed = "X"
            End If



            Dim GoodTools As String = ""
            Dim GoodEquipment As String = ""
            Dim GoodCleaningMaterials As String = ""
            Dim GoodSafetyDevicesWorkingProperly As String = ""








            If CHK_GoodTools.Checked Then
                GoodTools = "O"
            Else
                GoodTools = "X"
            End If



            If CHK_GoodEquipment.Checked Then
                GoodEquipment = "O"
            Else
                GoodEquipment = "X"
            End If


            If CHK_GoodCleaningMaterials.Checked Then
                GoodCleaningMaterials = "O"
            Else
                GoodCleaningMaterials = "X"
            End If


            If CHK_GoodSafetyDevice.Checked Then
                GoodSafetyDevicesWorkingProperly = "O"
            Else
                GoodSafetyDevicesWorkingProperly = "X"
            End If




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
                cmd.Parameters.AddWithValue("@gmp_SaniJoggerTable", GoodJoggerTable)

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", GoodFeederBridge)
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", GoodStacker)
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", GoodProoftray)
                cmd.Parameters.AddWithValue("@gmp_SaniTable", GoodTable)


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
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTiltTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBars", "")
                cmd.Parameters.AddWithValue("@gmp_SaniSortTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", "")
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBundlingMch", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRotatingTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniWeighScale", "")
                cmd.Parameters.AddWithValue("@gmp_PrePropTagged", GoodProperlyTagged)
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20Wall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPall)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCovers)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandsWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", GoodTools)
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaningMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", GoodSafetyDevicesWorkingProperly)
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
                cmd.Parameters.AddWithValue("@gmp_SaniJoggerTable", GoodJoggerTable)

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", GoodFeederBridge)
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", GoodStacker)
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", GoodProoftray)
                cmd.Parameters.AddWithValue("@gmp_SaniTable", GoodTable)


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
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTiltTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBars", "")
                cmd.Parameters.AddWithValue("@gmp_SaniSortTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", "")
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBundlingMch", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRotatingTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniWeighScale", "")
                cmd.Parameters.AddWithValue("@gmp_PrePropTagged", GoodProperlyTagged)
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20Wall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPall)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCovers)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandsWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", GoodTools)
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaningMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", GoodSafetyDevicesWorkingProperly)
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


        'A
        Dim selectedMachineABoth As String = ""
        Dim selectedMachineASideA As String = ""
        Dim selectedMachineASideB As String = ""
        Dim selectedMachineASimplex As String = ""


        If CBO_MachineABoth.Text = "✓" Then
            selectedMachineABoth = "O"
        Else
            selectedMachineABoth = "N"
        End If

        If CBO_MachineASideA.Text = "✓" Then
            selectedMachineASideA = "O"
        Else
            selectedMachineASideA = "N"
        End If



        If CBO_MachineASideB.Text = "✓" Then
            selectedMachineASideB = "O"
        Else
            selectedMachineASideB = "N"
        End If



        If CBO_MachineASimplex.Text = "✓" Then
            selectedMachineASimplex = "O"
        Else
            selectedMachineASimplex = "N"
        End If


        'B
        Dim selectedMachineBMultiShot As String = ""
        Dim selectedMachineBOneShot As String = ""



        If CBO_MachineBMultiShot.Text = "✓" Then
            selectedMachineBMultiShot = "O"
        Else
            selectedMachineBMultiShot = "N"
        End If



        If CBO_MachineBOneShot.Text = "✓" Then
            selectedMachineBOneShot = "O"
        Else
            selectedMachineBOneShot = "N"
        End If

        'D 
        Dim selectedMachineDInheritColor As String = ""

        If CBO_MachineDInheritColor.Text = "✓" Then
            selectedMachineDInheritColor = "O"
        Else
            selectedMachineDInheritColor = "N"
        End If

        'E
        Dim selectedMachineELong As String = ""
        Dim selectedMachineEShort As String = ""

        If CBO_MachineELong.Text = "✓" Then
            selectedMachineELong = "O"
        Else CBO_MachineELong.Text = "N/A"
            selectedMachineELong = "N"
        End If

        If CBO_MachineEShort.Text = "✓" Then
            selectedMachineEShort = "O"
        Else
            selectedMachineEShort = "N"
        End If

        'F
        Dim selectedMachineFFront As String = ""
        Dim selectedMachineFRear As String = ""
        Dim selectedMachineFCollate As String = ""

        If CBO_MachineFFront.Text = "✓" Then
            selectedMachineFFront = "O"
        Else
            selectedMachineFFront = "N"
        End If

        If CBO_MachineFRear.Text = "✓" Then
            selectedMachineFRear = "O"
        Else
            selectedMachineFRear = "N"
        End If

        If CBO_MachineFCollate.Text = "✓" Then
            selectedMachineFCollate = "O"
        Else
            selectedMachineFCollate = "N"
        End If

        'G
        Dim selectedMachineGFirstFaceup As String = ""
        Dim selectedMachineGFirstFaceDown As String = ""
        Dim selectedMachineGLastFaceup As String = ""
        Dim selectedMachineGLastFaceDown As String = ""

        If CBO_MachineGFirstFaceup.Text = "✓" Then
            selectedMachineGFirstFaceup = "O"
        Else
            selectedMachineGFirstFaceup = "N"
        End If

        If CBO_MachineGFirstFaceDown.Text = "✓" Then
            selectedMachineGFirstFaceDown = "O"
        Else
            selectedMachineGFirstFaceDown = "N"
        End If

        If CBO_MachineGLastFaceup.Text = "✓" Then
            selectedMachineGLastFaceup = "O"
        Else
            selectedMachineGLastFaceup = "N"
        End If

        If CBO_MachineGLastFaceDown.Text = "✓" Then
            selectedMachineGLastFaceDown = "O"
        Else
            selectedMachineGLastFaceDown = "N"
        End If



        'H
        Dim selectedMachineGlossy As String = ""
        Dim selectedMachineSemiMatte As String = ""
        Dim selectedMachineGMachineMatte As String = ""

        If CBO_MachineGlossy.Text = "✓" Then
            selectedMachineGlossy = "O"
        Else
            selectedMachineGlossy = "N"
        End If

        If CBO_MachineSemiMatte.Text = "✓" Then
            selectedMachineSemiMatte = "O"
        Else CBO_MachineSemiMatte.Text = "N/A"
            selectedMachineSemiMatte = "N"
        End If

        If CBO_MachineMatte.Text = "✓" Then
            selectedMachineGMachineMatte = "O"
        Else
            selectedMachineGMachineMatte = "N"
        End If




        'I
        Dim selectedMachineMirror As String = ""
        Dim selectedMachineNormal As String = ""
        Dim selectedMachineRotate As String = ""
        Dim selectedMachineTumble As String = ""

        If CBO_MachineMirror.Text = "✓" Then
            selectedMachineMirror = "O"
        Else
            selectedMachineMirror = "N"
        End If

        If CBO_MachineNormal.Text = "✓" Then
            selectedMachineNormal = "O"
        Else
            selectedMachineNormal = "N"
        End If

        If CBO_MachineRotate.Text = "✓" Then
            selectedMachineRotate = "O"
        Else
            selectedMachineRotate = "N"
        End If

        If CBO_MachineTumble.Text = "✓" Then
            selectedMachineTumble = "O"
        Else
            selectedMachineTumble = "N"
        End If

        'J
        Dim selectedMachineContrast As String = ""
        Dim selectedMachineBrightness As String = ""
        Dim selectedMachineDotArea As String = ""
        Dim selectedMachineOpticalDensity As String = ""
        Dim selectedMachineColorControl As String = ""

        If CBO_MachineContrast.Text = "✓" Then
            selectedMachineContrast = "O"
        Else
            selectedMachineContrast = "N"
        End If

        If CBO_MachineBrightness.Text = "✓" Then
            selectedMachineBrightness = "O"
        Else
            selectedMachineBrightness = "N"
        End If

        If CBO_MachineDotArea.Text = "✓" Then
            selectedMachineDotArea = "O"
        Else
            selectedMachineDotArea = "N"
        End If

        If CBO_MachineOpticalDensity.Text = "✓" Then
            selectedMachineOpticalDensity = "O"
        Else
            selectedMachineOpticalDensity = "N"
        End If


        If CBO_MachineColorControl.Text = "✓" Then
            selectedMachineColorControl = "O"
        Else
            selectedMachineColorControl = "N"
        End If

        'K
        Dim selectedMachineColor As String = ""

        If CBO_MachineColorControl.Text = "✓" Then
            selectedMachineColor = "O"
        Else
            selectedMachineColor = "N"
        End If



        'LETTER C
        Dim selectedMachineC1 As String = ""
        Dim selectedMachineC2 As String = ""
        Dim selectedMachineC3 As String = ""
        Dim selectedMachineC4 As String = ""
        Dim selectedMachineC5 As String = ""

        If CBO_MachineC1.Text.Trim() = "✓" Then
            selectedMachineC1 = "O"
        ElseIf CBO_MachineC1.Text.Trim() = "N/A" Then
            selectedMachineC1 = "N"
        Else
            selectedMachineC1 = CBO_MachineC1.Text
        End If


        If CBO_MachineC2.Text.Trim() = "✓" Then
            selectedMachineC2 = "O"
        ElseIf CBO_MachineC2.Text.Trim() = "N/A" Then
            selectedMachineC2 = "N"
        Else
            selectedMachineC2 = CBO_MachineC2.Text
        End If

        If CBO_MachineC3.Text.Trim() = "✓" Then
            selectedMachineC3 = "O"
        ElseIf CBO_MachineC3.Text.Trim() = "N/A" Then
            selectedMachineC3 = "N"
        Else
            selectedMachineC3 = CBO_MachineC3.Text
        End If


        If CBO_MachineC4.Text.Trim() = "✓" Then
            selectedMachineC4 = "O"
        ElseIf CBO_MachineC4.Text.Trim() = "N/A" Then
            selectedMachineC4 = "N"
        Else
            selectedMachineC4 = CBO_MachineC4.Text
        End If



        If CBO_MachineC5.Text.Trim() = "✓" Then
            selectedMachineC5 = "O"
        ElseIf CBO_MachineC5.Text.Trim() = "N/A" Then
            selectedMachineC5 = "N"
        Else
            selectedMachineC5 = CBO_MachineC5.Text
        End If








        'LETTER M
        Dim selectedMachineM1 As String = ""
        Dim selectedMachineM2 As String = ""
        Dim selectedMachineM3 As String = ""
        Dim selectedMachineM4 As String = ""
        Dim selectedMachineM5 As String = ""

        If CBO_MachineM1.Text.Trim() = "✓" Then
            selectedMachineM1 = "O"
        ElseIf CBO_MachineM1.Text.Trim() = "N/A" Then
            selectedMachineM1 = "N"
        Else
            selectedMachineM1 = CBO_MachineM1.Text
        End If

        If CBO_MachineM2.Text.Trim() = "✓" Then
            selectedMachineM2 = "O"
        ElseIf CBO_MachineM2.Text.Trim() = "N/A" Then
            selectedMachineM2 = "N"
        Else
            selectedMachineM2 = CBO_MachineM2.Text
        End If


        If CBO_MachineM3.Text.Trim() = "✓" Then
            selectedMachineM3 = "O"
        ElseIf CBO_MachineM3.Text.Trim() = "N/A" Then
            selectedMachineM3 = "N"
        Else
            selectedMachineM3 = CBO_MachineM3.Text
        End If



        If CBO_MachineM4.Text.Trim() = "✓" Then
            selectedMachineM4 = "O"
        ElseIf CBO_MachineM4.Text.Trim() = "N/A" Then
            selectedMachineM4 = "N"
        Else
            selectedMachineM4 = CBO_MachineM4.Text
        End If


        If CBO_MachineM5.Text.Trim() = "✓" Then
            selectedMachineM5 = "O"
        ElseIf CBO_MachineM5.Text.Trim() = "N/A" Then
            selectedMachineM5 = "N"
        Else
            selectedMachineM5 = CBO_MachineM5.Text
        End If


        'LETTER Y
        Dim selectedMachineY1 As String = ""
        Dim selectedMachineY2 As String = ""
        Dim selectedMachineY3 As String = ""
        Dim selectedMachineY4 As String = ""
        Dim selectedMachineY5 As String = ""

        If CBO_MachineY1.Text.Trim() = "✓" Then
            selectedMachineY1 = "O"
        ElseIf CBO_MachineY1.Text.Trim() = "N/A" Then
            selectedMachineY1 = "N"
        Else
            selectedMachineY1 = CBO_MachineY1.Text
        End If

        If CBO_MachineY2.Text.Trim() = "✓" Then
            selectedMachineY2 = "O"
        ElseIf CBO_MachineY1.Text.Trim() = "N/A" Then
            selectedMachineY2 = "N"
        Else
            selectedMachineY2 = CBO_MachineY2.Text
        End If


        If CBO_MachineY3.Text.Trim() = "✓" Then
            selectedMachineY3 = "O"
        ElseIf CBO_MachineY3.Text.Trim() = "N/A" Then
            selectedMachineY3 = "N"
        Else
            selectedMachineY3 = CBO_MachineY3.Text
        End If

        If CBO_MachineY4.Text.Trim() = "✓" Then
            selectedMachineY4 = "O"
        ElseIf CBO_MachineY4.Text.Trim() = "N/A" Then
            selectedMachineY4 = "N"
        Else
            selectedMachineY4 = CBO_MachineY4.Text
        End If


        If CBO_MachineY5.Text.Trim() = "✓" Then
            selectedMachineY5 = "O"
        ElseIf CBO_MachineY5.Text.Trim() = "N/A" Then
            selectedMachineY5 = "N"
        Else
            selectedMachineY5 = CBO_MachineY5.Text
        End If


        'LETTER K
        Dim selectedMachineK1 As String = ""
        Dim selectedMachineK2 As String = ""
        Dim selectedMachineK3 As String = ""
        Dim selectedMachineK4 As String = ""
        Dim selectedMachineK5 As String = ""

        If CBO_MachineK1.Text.Trim() = "✓" Then
            selectedMachineK1 = "O"
        ElseIf CBO_MachineK1.Text.Trim() = "N/A" Then
            selectedMachineK1 = "N"
        Else
            selectedMachineK1 = CBO_MachineK1.Text
        End If

        If CBO_MachineK2.Text.Trim() = "✓" Then
            selectedMachineK2 = "O"
        ElseIf CBO_MachineK2.Text.Trim() = "N/A" Then
            selectedMachineK2 = "N"
        Else
            selectedMachineK2 = CBO_MachineK2.Text
        End If

        If CBO_MachineK3.Text.Trim() = "✓" Then
            selectedMachineK3 = "O"
        ElseIf CBO_MachineK3.Text.Trim() = "N/A" Then
            selectedMachineK3 = "N"
        Else
            selectedMachineK3 = CBO_MachineK3.Text
        End If

        If CBO_MachineK4.Text.Trim() = "✓" Then
            selectedMachineK4 = "O"
        ElseIf CBO_MachineK4.Text.Trim() = "N/A" Then
            selectedMachineK4 = "N"
        Else
            selectedMachineK4 = CBO_MachineK4.Text
        End If


        If CBO_MachineK5.Text.Trim() = "✓" Then
            selectedMachineK5 = "O"
        ElseIf CBO_MachineK5.Text.Trim() = "N/A" Then
            selectedMachineK5 = "N"
        Else
            selectedMachineK5 = CBO_MachineK5.Text
        End If





        'LETTER O
        Dim selectedMachineO1 As String = ""
        Dim selectedMachineO2 As String = ""
        Dim selectedMachineO3 As String = ""
        Dim selectedMachineO4 As String = ""
        Dim selectedMachineO5 As String = ""

        If CBO_MachineO1.Text.Trim() = "✓" Then
            selectedMachineO1 = "O"
        ElseIf CBO_MachineO1.Text.Trim() = "N/A" Then
            selectedMachineO1 = "N"
        Else
            selectedMachineO1 = CBO_MachineO1.Text
        End If


        If CBO_MachineO2.Text.Trim() = "✓" Then
            selectedMachineO2 = "O"
        ElseIf CBO_MachineO2.Text.Trim() = "N/A" Then
            selectedMachineO2 = "N"
        Else
            selectedMachineO2 = CBO_MachineO2.Text
        End If


        If CBO_MachineO3.Text.Trim() = "✓" Then
            selectedMachineO3 = "O"
        ElseIf CBO_MachineO3.Text.Trim() = "N/A" Then
            selectedMachineO3 = "N"
        Else
            selectedMachineO3 = CBO_MachineO3.Text
        End If


        If CBO_MachineO4.Text.Trim() = "✓" Then
            selectedMachineO4 = "O"
        ElseIf CBO_MachineO4.Text.Trim() = "N/A" Then
            selectedMachineO4 = "N"
        Else
            selectedMachineO4 = CBO_MachineO4.Text
        End If


        If CBO_MachineO5.Text.Trim() = "✓" Then
            selectedMachineO5 = "O"
        ElseIf CBO_MachineO5.Text.Trim() = "N/A" Then
            selectedMachineO5 = "N"
        Else
            selectedMachineO5 = CBO_MachineO5.Text
        End If







        'LETTER G
        Dim selectedMachineG1 As String = ""
        Dim selectedMachineG2 As String = ""
        Dim selectedMachineG3 As String = ""
        Dim selectedMachineG4 As String = ""
        Dim selectedMachineG5 As String = ""



        If CBO_MachineG1.Text.Trim() = "✓" Then
            selectedMachineG1 = "O"
        ElseIf CBO_MachineG1.Text.Trim() = "N/A" Then
            selectedMachineG1 = "N"
        Else
            selectedMachineG1 = CBO_MachineG1.Text
        End If

        If CBO_MachineG2.Text.Trim() = "✓" Then
            selectedMachineG2 = "O"
        ElseIf CBO_MachineG2.Text.Trim() = "N/A" Then
            selectedMachineG2 = "N"
        Else
            selectedMachineG2 = CBO_MachineG2.Text
        End If


        If CBO_MachineG3.Text.Trim() = "✓" Then
            selectedMachineG3 = "O"
        ElseIf CBO_MachineG3.Text.Trim() = "N/A" Then
            selectedMachineG3 = "N"
        Else
            selectedMachineG3 = CBO_MachineG3.Text
        End If


        If CBO_MachineG4.Text.Trim() = "✓" Then
            selectedMachineG4 = "O"
        ElseIf CBO_MachineG4.Text.Trim() = "N/A" Then
            selectedMachineG4 = "N"
        Else
            selectedMachineG4 = CBO_MachineG4.Text
        End If

        If CBO_MachineG5.Text.Trim() = "✓" Then
            selectedMachineG5 = "O"
        ElseIf CBO_MachineG5.Text.Trim() = "N/A" Then
            selectedMachineG5 = "N"
        Else
            selectedMachineG5 = CBO_MachineG5.Text
        End If



        'LETTER V
        Dim selectedMachineV1 As String = ""
        Dim selectedMachineV2 As String = ""
        Dim selectedMachineV3 As String = ""
        Dim selectedMachineV4 As String = ""
        Dim selectedMachineV5 As String = ""



        If CBO_MachineV1.Text.Trim() = "✓" Then
            selectedMachineV1 = "O"
        ElseIf CBO_MachineV1.Text.Trim() = "N/A" Then
            selectedMachineV1 = "N"
        Else
            selectedMachineV1 = CBO_MachineV1.Text
        End If


        If CBO_MachineV2.Text.Trim() = "✓" Then
            selectedMachineV2 = "O"
        ElseIf CBO_MachineV2.Text.Trim() = "N/A" Then
            selectedMachineV2 = "N"
        Else
            selectedMachineV2 = CBO_MachineV2.Text
        End If


        If CBO_MachineV3.Text.Trim() = "✓" Then
            selectedMachineV3 = "O"
        ElseIf CBO_MachineV3.Text.Trim() = "N/A" Then
            selectedMachineV3 = "N"
        Else
            selectedMachineV3 = CBO_MachineV3.Text
        End If


        If CBO_MachineV4.Text.Trim() = "✓" Then
            selectedMachineV4 = "O"
        ElseIf CBO_MachineV4.Text.Trim() = "N/A" Then
            selectedMachineV4 = "N"
        Else
            selectedMachineV4 = CBO_MachineV4.Text
        End If




        If CBO_MachineV5.Text.Trim() = "✓" Then
            selectedMachineV5 = "O"
        ElseIf CBO_MachineV5.Text.Trim() = "N/A" Then
            selectedMachineV5 = "N"
        Else
            selectedMachineV5 = CBO_MachineV5.Text
        End If



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
                cmd.Parameters.AddWithValue("@mspa_GLfdrbeltBBE", "")
                cmd.Parameters.AddWithValue("@mspa_GLftranbeltbox", "")
                cmd.Parameters.AddWithValue("@mspa_GLBxSquare", "")
                cmd.Parameters.AddWithValue("@mspa_GLBxLockSys", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartn", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartnqty", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforces", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenforceval", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLFlywheel", "")
                cmd.Parameters.AddWithValue("@mspa_GLGLuegun", "")
                cmd.Parameters.AddWithValue("@mspa_GLHSSAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelap", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelwid", 0.00)
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


                cmd.Parameters.AddWithValue("@mspa_SDboth", selectedMachineABoth)
                cmd.Parameters.AddWithValue("@mspa_SDsideA", selectedMachineASideA)
                cmd.Parameters.AddWithValue("@mspa_SDsideB", selectedMachineASideB)
                cmd.Parameters.AddWithValue("@mspa_SDsimplex", selectedMachineASimplex)
                cmd.Parameters.AddWithValue("@mspa_PMmulshot", selectedMachineBMultiShot)
                cmd.Parameters.AddWithValue("@mspa_PM1shot", selectedMachineBOneShot)
                cmd.Parameters.AddWithValue("@mspa_CPinhertcolor", selectedMachineDInheritColor)
                cmd.Parameters.AddWithValue("@mspa_SUdesc", TXT_MachineCSubstrate.Text)
                cmd.Parameters.AddWithValue("@mspa_SUweight", TXT_MachineCWeight.Text)
                cmd.Parameters.AddWithValue("@mspa_SUthickness", TXT_MachineCThickness.Text)
                cmd.Parameters.AddWithValue("@mspa_GDShort", selectedMachineEShort)
                cmd.Parameters.AddWithValue("@mspa_GDLong", selectedMachineELong)
                cmd.Parameters.AddWithValue("@mspa_SAfront", selectedMachineFFront)
                cmd.Parameters.AddWithValue("@mspa_SArear", selectedMachineFRear)
                cmd.Parameters.AddWithValue("@mspa_SAcollate", selectedMachineFCollate)
                cmd.Parameters.AddWithValue("@mspa_SJFLFU", selectedMachineGFirstFaceup)
                cmd.Parameters.AddWithValue("@mspa_SJFLFD", selectedMachineGFirstFaceDown)
                cmd.Parameters.AddWithValue("@mspa_SJLFFU", selectedMachineGLastFaceup)
                cmd.Parameters.AddWithValue("@mspa_SJLFFD", selectedMachineGLastFaceDown)
                cmd.Parameters.AddWithValue("@mspa_GLglossy", selectedMachineGlossy)
                cmd.Parameters.AddWithValue("@mspa_GLsemimatte", selectedMachineSemiMatte)
                cmd.Parameters.AddWithValue("@mspa_GLmatte", selectedMachineGMachineMatte)
                cmd.Parameters.AddWithValue("@mspa_IPmirror", selectedMachineMirror)
                cmd.Parameters.AddWithValue("@mspa_IPnormal", selectedMachineNormal)
                cmd.Parameters.AddWithValue("@mspa_IProtate", selectedMachineRotate)
                cmd.Parameters.AddWithValue("@mspa_IPtumble", selectedMachineTumble)
                cmd.Parameters.AddWithValue("@mspa_CCLUTname", TXT_MachineJLutName.Text)
                cmd.Parameters.AddWithValue("@mspa_CCcontrast", selectedMachineContrast)
                cmd.Parameters.AddWithValue("@mspa_CCbrightness", selectedMachineBrightness)
                cmd.Parameters.AddWithValue("@mspa_CCdot50per", selectedMachineDotArea)
                cmd.Parameters.AddWithValue("@mspa_CCopticdenadj", selectedMachineOpticalDensity)
                cmd.Parameters.AddWithValue("@mspa_CCC1", selectedMachineC1)
                cmd.Parameters.AddWithValue("@mspa_CCC2", selectedMachineC2)
                cmd.Parameters.AddWithValue("@mspa_CCC3", selectedMachineC3)
                cmd.Parameters.AddWithValue("@mspa_CCC4", selectedMachineC4)
                cmd.Parameters.AddWithValue("@mspa_CCC5", selectedMachineC5)
                cmd.Parameters.AddWithValue("@mspa_CCM1", selectedMachineM1)
                cmd.Parameters.AddWithValue("@mspa_CCM2", selectedMachineM2)
                cmd.Parameters.AddWithValue("@mspa_CCM3", selectedMachineM3)
                cmd.Parameters.AddWithValue("@mspa_CCM4", selectedMachineM4)
                cmd.Parameters.AddWithValue("@mspa_CCM5", selectedMachineM5)
                cmd.Parameters.AddWithValue("@mspa_CCY1", selectedMachineY1)
                cmd.Parameters.AddWithValue("@mspa_CCY2", selectedMachineY2)
                cmd.Parameters.AddWithValue("@mspa_CCY3", selectedMachineY3)
                cmd.Parameters.AddWithValue("@mspa_CCY4", selectedMachineY4)
                cmd.Parameters.AddWithValue("@mspa_CCY5", selectedMachineY5)
                cmd.Parameters.AddWithValue("@mspa_CCK1", selectedMachineK1)
                cmd.Parameters.AddWithValue("@mspa_CCK2", selectedMachineK2)
                cmd.Parameters.AddWithValue("@mspa_CCK3", selectedMachineK3)
                cmd.Parameters.AddWithValue("@mspa_CCK4", selectedMachineK4)
                cmd.Parameters.AddWithValue("@mspa_CCK5", selectedMachineK5)
                cmd.Parameters.AddWithValue("@mspa_CCO1", selectedMachineO1)
                cmd.Parameters.AddWithValue("@mspa_CCO2", selectedMachineO2)
                cmd.Parameters.AddWithValue("@mspa_CCO3", selectedMachineO3)
                cmd.Parameters.AddWithValue("@mspa_CCO4", selectedMachineO4)
                cmd.Parameters.AddWithValue("@mspa_CCO5", selectedMachineO5)
                cmd.Parameters.AddWithValue("@mspa_CCG1", selectedMachineG1)
                cmd.Parameters.AddWithValue("@mspa_CCG2", selectedMachineG2)
                cmd.Parameters.AddWithValue("@mspa_CCG3", selectedMachineG3)
                cmd.Parameters.AddWithValue("@mspa_CCG4", selectedMachineG4)
                cmd.Parameters.AddWithValue("@mspa_CCG5", selectedMachineG5)
                cmd.Parameters.AddWithValue("@mspa_CCV1", selectedMachineV1)
                cmd.Parameters.AddWithValue("@mspa_CCV2", selectedMachineV2)
                cmd.Parameters.AddWithValue("@mspa_CCV3", selectedMachineV3)
                cmd.Parameters.AddWithValue("@mspa_CCV4", selectedMachineV4)
                cmd.Parameters.AddWithValue("@mspa_CCV5", selectedMachineV5)
                cmd.Parameters.AddWithValue("@mspa_CATP", selectedMachineColor)
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
                cmd.Parameters.AddWithValue("@mspa_GLfdrbeltBBE", "")
                cmd.Parameters.AddWithValue("@mspa_GLftranbeltbox", "")
                cmd.Parameters.AddWithValue("@mspa_GLBxSquare", "")
                cmd.Parameters.AddWithValue("@mspa_GLBxLockSys", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartn", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenCartnqty", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLOpenforces", "")
                cmd.Parameters.AddWithValue("@mspa_GLOpenforceval", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLFlywheel", "")
                cmd.Parameters.AddWithValue("@mspa_GLGLuegun", "")
                cmd.Parameters.AddWithValue("@mspa_GLHSSAct", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelap", 0.00)
                cmd.Parameters.AddWithValue("@mspa_GLActGLuelwid", 0.00)
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


                cmd.Parameters.AddWithValue("@mspa_SDboth", selectedMachineABoth)
                cmd.Parameters.AddWithValue("@mspa_SDsideA", selectedMachineASideA)
                cmd.Parameters.AddWithValue("@mspa_SDsideB", selectedMachineASideB)
                cmd.Parameters.AddWithValue("@mspa_SDsimplex", selectedMachineASimplex)
                cmd.Parameters.AddWithValue("@mspa_PMmulshot", selectedMachineBMultiShot)
                cmd.Parameters.AddWithValue("@mspa_PM1shot", selectedMachineBOneShot)
                cmd.Parameters.AddWithValue("@mspa_CPinhertcolor", selectedMachineDInheritColor)
                cmd.Parameters.AddWithValue("@mspa_SUdesc", TXT_MachineCSubstrate.Text)
                cmd.Parameters.AddWithValue("@mspa_SUweight", TXT_MachineCWeight.Text)
                cmd.Parameters.AddWithValue("@mspa_SUthickness", TXT_MachineCThickness.Text)
                cmd.Parameters.AddWithValue("@mspa_GDShort", selectedMachineEShort)
                cmd.Parameters.AddWithValue("@mspa_GDLong", selectedMachineELong)
                cmd.Parameters.AddWithValue("@mspa_SAfront", selectedMachineFFront)
                cmd.Parameters.AddWithValue("@mspa_SArear", selectedMachineFRear)
                cmd.Parameters.AddWithValue("@mspa_SAcollate", selectedMachineFCollate)
                cmd.Parameters.AddWithValue("@mspa_SJFLFU", selectedMachineGFirstFaceup)
                cmd.Parameters.AddWithValue("@mspa_SJFLFD", selectedMachineGFirstFaceDown)
                cmd.Parameters.AddWithValue("@mspa_SJLFFU", selectedMachineGLastFaceup)
                cmd.Parameters.AddWithValue("@mspa_SJLFFD", selectedMachineGLastFaceDown)
                cmd.Parameters.AddWithValue("@mspa_GLglossy", selectedMachineGlossy)
                cmd.Parameters.AddWithValue("@mspa_GLsemimatte", selectedMachineSemiMatte)
                cmd.Parameters.AddWithValue("@mspa_GLmatte", selectedMachineGMachineMatte)
                cmd.Parameters.AddWithValue("@mspa_IPmirror", selectedMachineMirror)
                cmd.Parameters.AddWithValue("@mspa_IPnormal", selectedMachineNormal)
                cmd.Parameters.AddWithValue("@mspa_IProtate", selectedMachineRotate)
                cmd.Parameters.AddWithValue("@mspa_IPtumble", selectedMachineTumble)
                cmd.Parameters.AddWithValue("@mspa_CCLUTname", TXT_MachineJLutName.Text)
                cmd.Parameters.AddWithValue("@mspa_CCcontrast", selectedMachineContrast)
                cmd.Parameters.AddWithValue("@mspa_CCbrightness", selectedMachineBrightness)
                cmd.Parameters.AddWithValue("@mspa_CCdot50per", selectedMachineDotArea)
                cmd.Parameters.AddWithValue("@mspa_CCopticdenadj", selectedMachineOpticalDensity)
                cmd.Parameters.AddWithValue("@mspa_CCC1", selectedMachineC1)
                cmd.Parameters.AddWithValue("@mspa_CCC2", selectedMachineC2)
                cmd.Parameters.AddWithValue("@mspa_CCC3", selectedMachineC3)
                cmd.Parameters.AddWithValue("@mspa_CCC4", selectedMachineC4)
                cmd.Parameters.AddWithValue("@mspa_CCC5", selectedMachineC5)
                cmd.Parameters.AddWithValue("@mspa_CCM1", selectedMachineM1)
                cmd.Parameters.AddWithValue("@mspa_CCM2", selectedMachineM2)
                cmd.Parameters.AddWithValue("@mspa_CCM3", selectedMachineM3)
                cmd.Parameters.AddWithValue("@mspa_CCM4", selectedMachineM4)
                cmd.Parameters.AddWithValue("@mspa_CCM5", selectedMachineM5)
                cmd.Parameters.AddWithValue("@mspa_CCY1", selectedMachineY1)
                cmd.Parameters.AddWithValue("@mspa_CCY2", selectedMachineY2)
                cmd.Parameters.AddWithValue("@mspa_CCY3", selectedMachineY3)
                cmd.Parameters.AddWithValue("@mspa_CCY4", selectedMachineY4)
                cmd.Parameters.AddWithValue("@mspa_CCY5", selectedMachineY5)
                cmd.Parameters.AddWithValue("@mspa_CCK1", selectedMachineK1)
                cmd.Parameters.AddWithValue("@mspa_CCK2", selectedMachineK2)
                cmd.Parameters.AddWithValue("@mspa_CCK3", selectedMachineK3)
                cmd.Parameters.AddWithValue("@mspa_CCK4", selectedMachineK4)
                cmd.Parameters.AddWithValue("@mspa_CCK5", selectedMachineK5)
                cmd.Parameters.AddWithValue("@mspa_CCO1", selectedMachineO1)
                cmd.Parameters.AddWithValue("@mspa_CCO2", selectedMachineO2)
                cmd.Parameters.AddWithValue("@mspa_CCO3", selectedMachineO3)
                cmd.Parameters.AddWithValue("@mspa_CCO4", selectedMachineO4)
                cmd.Parameters.AddWithValue("@mspa_CCO5", selectedMachineO5)
                cmd.Parameters.AddWithValue("@mspa_CCG1", selectedMachineG1)
                cmd.Parameters.AddWithValue("@mspa_CCG2", selectedMachineG2)
                cmd.Parameters.AddWithValue("@mspa_CCG3", selectedMachineG3)
                cmd.Parameters.AddWithValue("@mspa_CCG4", selectedMachineG4)
                cmd.Parameters.AddWithValue("@mspa_CCG5", selectedMachineG5)
                cmd.Parameters.AddWithValue("@mspa_CCV1", selectedMachineV1)
                cmd.Parameters.AddWithValue("@mspa_CCV2", selectedMachineV2)
                cmd.Parameters.AddWithValue("@mspa_CCV3", selectedMachineV3)
                cmd.Parameters.AddWithValue("@mspa_CCV4", selectedMachineV4)
                cmd.Parameters.AddWithValue("@mspa_CCV5", selectedMachineV5)
                cmd.Parameters.AddWithValue("@mspa_CATP", selectedMachineColor)
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
                cmd.Parameters.AddWithValue("@stripknife", TXT_7StrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@stripknifebld", TXT_7StrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@markerqty", TXT_7Marker.Text)
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
                cmd.Parameters.AddWithValue("@markerqty", TXT_7Marker.Text)
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

        Dim UC_SupervisorDigiPress As New UC_SupervisorDigiPress
        UC_SupervisorDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorDigiPress.Show()
        UC_SupervisorDigiPress.Dock = DockStyle.Fill






    End Sub

    Private Sub CBO_AsstOperator1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.SelectedIndexChanged
        con.Close()
        load_AssOperator_empnum1()

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

    End Sub

    Private Sub CBO_Helper1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged
        con.Close()
        load_helper_empnum1()
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


    Private Sub TXT_7BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7BallpenQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_7RagsQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_7RagsQty.TextChanged

    End Sub

    Private Sub TXT_7RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7RagsQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_7Marker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7Marker.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_MachineCWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineCWeight.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_MachineCThickness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineCThickness.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_BallpenQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_BallpenQty.TextChanged

    End Sub

    Private Sub TXT_BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_BallpenQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_RagsQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_RagsQty.TextChanged

    End Sub

    Private Sub TXT_RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RagsQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_StrippingKnifeQty1_TextChanged(sender As Object, e As EventArgs) Handles TXT_StrippingKnifeQty1.TextChanged

    End Sub

    Private Sub TXT_StrippingKnifeQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingKnifeQty1.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_StrippingKnifeQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_StrippingKnifeQty2.TextChanged

    End Sub

    Private Sub TXT_StrippingKnifeQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingKnifeQty2.KeyPress
        NumberOnly(e)
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
