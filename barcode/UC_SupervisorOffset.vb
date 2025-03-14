Imports System.Data.SqlClient

Public Class UC_SupervisorOffset
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub DisabledSupervisorForm()
        CHK_SelectAll.Enabled = False

        '1. Full line
        CHK_FullFeeder.Enabled = False
        CHK_FullDelivery.Enabled = False
        CHK_FullDrawer.Enabled = False
        CHK_FullJogTable.Enabled = False
        CHK_FullInk.Enabled = False
        CHK_FullVarnish.Enabled = False
        CHK_FullFoil.Enabled = False
        CHK_FullSupplies.Enabled = False
        TXT_FullBallpenQty.Enabled = False
        TXT_FullRagsQty.Enabled = False
        TXT_FullStrippingKnifeQty1.Enabled = False
        TXT_FullStrippingKnifeQty2.Enabled = False
        TXT_FullMarterQty.Enabled = False
        TXT_PaperFrom.Enabled = False
        TXT_PaperTo.Enabled = False
        TXT_InksFrom.Enabled = False
        TXT_InksTo.Enabled = False
        TXT_VanishFrom.Enabled = False
        TXT_VanishTo.Enabled = False
        TXT_FoilFrom.Enabled = False
        TXT_FoilTo.Enabled = False

        '2. Good Manu
        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodOilChemical.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False

        CHK_GoodJoggerTable.Enabled = False
        CHK_GoodRubberSuckers.Enabled = False
        CHK_GoodPaperSeparator.Enabled = False
        CHK_GoodGovernorFoot.Enabled = False
        CHK_GoodFeederTable.Enabled = False
        CHK_GoodImpressionCylinder.Enabled = False
        CHK_GoodDelivery.Enabled = False
        CHK_GoodControlConsole.Enabled = False
        CHK_GoodPlasticPallets.Enabled = False
        CHK_GoodTransportBelt.Enabled = False
        CHK_GoodProperlyTagged.Enabled = False
        CHk_GoodInPlasticPallets.Enabled = False
        CHK_GoodWith20thWall.Enabled = False
        CHK_GoodFollowingStandardPallet.Enabled = False
        CHK_GoodWearHairCover.Enabled = False
        CHk_GoodWearsProperlyTuckedIn.Enabled = False
        CHk_GoodHandWashed.Enabled = False
        CHk_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaingMaterials.Enabled = False
        CHK_GoodSafetyDevicesWorking.Enabled = False

        '3. Job Ins
        RTB_JobInstruction.Enabled = False

        TXT_OperatorNumSupervisor.Enabled = False
        TXT_OperatorUCSupervisor.Enabled = False
        DTPOperator.Enabled = False
        DTP_AsstOperator1.Enabled = False
        DTP_AsstOperator2.Enabled = False
        DTPHelper1.Enabled = False
        DTPHelper2.Enabled = False

        CBO_AsstOperator1.Enabled = False
        CBO_AsstOperator2.Enabled = False
        CBO_Helper1.Enabled = False
        CBO_Helper2.Enabled = False

        TXT_AsstOperator1.Enabled = False
        TXT_AsstOperator2.Enabled = False
        TXT_Helper1.Enabled = False
        TXT_Helper2.Enabled = False






        '4.  MACHINE SET-UP  / PRODUCT APPROVAL
        CHK_MachineOperator.Enabled = False
        CHK_MachineDrive.Enabled = False
        CHK_MachineRollerGuide.Enabled = False

        CHK_MachineCheck1.Enabled = False
        CHK_MachineCheck2.Enabled = False
        CHK_MachineCheck3.Enabled = False
        CHK_MachineCheck4.Enabled = False
        CHK_MachineCheck5.Enabled = False
        CHK_MachineMechanical.Enabled = False
        CHK_MachineUltrasonic.Enabled = False
        CHK_MachineACFYellowBar.Enabled = False
        CHK_MachineSecurityMatrix.Enabled = False
        CHK_MachinePowerlock.Enabled = False
        TXT_MachinePowerlock.Enabled = False

        TXT_ColorPU1.Enabled = False
        TXT_ColorPU2.Enabled = False
        TXT_ColorPU3.Enabled = False
        TXT_ColorPU4.Enabled = False
        TXT_ColorPU5.Enabled = False
        TXT_ColorPU6.Enabled = False
        TXT_ColorPU7.Enabled = False


        CBO_RollerSettingPU1.Enabled = False
        CBO_RollerSettingPU2.Enabled = False
        CBO_RollerSettingPU3.Enabled = False
        CBO_RollerSettingPU4.Enabled = False
        CBO_RollerSettingPU5.Enabled = False
        CBO_RollerSettingPU6.Enabled = False
        CBO_RollerSettingPU7.Enabled = False

        TXT_RollerSeparationPU1.Enabled = False
        TXT_RollerSeparationPU2.Enabled = False
        TXT_RollerSeparationPU3.Enabled = False
        TXT_RollerSeparationPU4.Enabled = False
        TXT_RollerSeparationPU5.Enabled = False
        TXT_RollerSeparationPU6.Enabled = False
        TXT_RollerSeparationPU7.Enabled = False

        TXT_ImpPressurePU1.Enabled = False
        TXT_ImpPressurePU2.Enabled = False
        TXT_ImpPressurePU3.Enabled = False
        TXT_ImpPressurePU4.Enabled = False
        TXT_ImpPressurePU5.Enabled = False
        TXT_ImpPressurePU6.Enabled = False
        TXT_ImpPressurePU7.Enabled = False

        TXT_MachineInkDensityPU1.Enabled = False
        TXT_MachineInkDensityPU2.Enabled = False
        TXT_MachineInkDensityPU3.Enabled = False
        TXT_MachineInkDensityPU4.Enabled = False
        TXT_MachineInkDensityPU5.Enabled = False
        TXT_MachineInkDensityPU6.Enabled = False
        TXT_MachineInkDensityPU7.Enabled = False

        TXT_MachineInterdeckPU1.Enabled = False
        TXT_MachineInterdeckPU2.Enabled = False
        TXT_MachineInterdeckPU3.Enabled = False
        TXT_MachineInterdeckPU4.Enabled = False
        TXT_MachineInterdeckPU5.Enabled = False
        TXT_MachineInterdeckPU6.Enabled = False
        TXT_MachineInterdeckPU7.Enabled = False

        CHK_UnvarnishBBE.Enabled = False
        CHK_UnvarnishFlap.Enabled = False
        CHK_GlueLap.Enabled = False

        CHK_MachineGrainShort.Enabled = False
        CHK_MachineGrainLong.Enabled = False

        TXT_CoatingUnit1Varnish.Enabled = False
        TXT_CoatingUnit1HotAirDryer1.Enabled = False
        TXT_CoatingUnit1HotAirDryer2.Enabled = False
        TXT_CoatingUnit1HotAirDryer3.Enabled = False
        TXT_CoatingUnit1HotAirDryer4.Enabled = False

        TXT_CoatingUnit1InfraRedDryer1.Enabled = False
        TXT_CoatingUnit1InfraRedDryer2.Enabled = False
        TXT_MachineEndOfPress1.Enabled = False
        TXT_MachineEndOfPress2.Enabled = False
        TXT_MachineEndOfPress3.Enabled = False



        TXT_CoatingUnit1Anilox.Enabled = False
        TXT_MachineColdAit100.Enabled = False
        TXT_CoatingUnit2Varnish.Enabled = False

        TXT_CoatingUnit2HotAirDryer1.Enabled = False
        TXT_CoatingUnit2HotAirDryer2.Enabled = False
        TXT_CoatingUnit2HotAirDryer3.Enabled = False
        TXT_CoatingUnit2HotAirDryer4.Enabled = False

        TXT_MachineSprayType.Enabled = False

        TXT_CoatingUnit2InfraRedDryer1.Enabled = False
        TXT_CoatingUnit2InfraRedDryer2.Enabled = False
        TXT_CoatingUnit2Anilox.Enabled = False
        TXT_MachineSpraySetting.Enabled = False
        TXT_MachineInkingUnitTemp.Enabled = False


        BTN_Save_Supervisor.Enabled = False



        '7.  RETURNED OPERATIONAL LOOSE ITEM 
        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False
        TXT_StrippingBladeQty1.Enabled = False
        TXT_StrippingBladeQty2.Enabled = False

    End Sub


    Private Sub EnabledSupervisorForm()
        CHK_SelectAll.Enabled = True

        '1. Full line
        CHK_FullFeeder.Enabled = True
        CHK_FullDelivery.Enabled = True
        CHK_FullDrawer.Enabled = True
        CHK_FullJogTable.Enabled = True
        CHK_FullInk.Enabled = True
        CHK_FullVarnish.Enabled = True
        CHK_FullFoil.Enabled = True
        CHK_FullSupplies.Enabled = True
        TXT_FullBallpenQty.Enabled = True
        TXT_FullRagsQty.Enabled = True
        TXT_FullStrippingKnifeQty1.Enabled = True
        TXT_FullStrippingKnifeQty2.Enabled = True
        TXT_FullMarterQty.Enabled = True
        TXT_PaperFrom.Enabled = True
        TXT_PaperTo.Enabled = True
        TXT_InksFrom.Enabled = True
        TXT_InksTo.Enabled = True
        TXT_VanishFrom.Enabled = True
        TXT_VanishTo.Enabled = True
        TXT_FoilFrom.Enabled = True
        TXT_FoilTo.Enabled = True

        '2. Good Manu
        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodOilChemical.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True

        CHK_GoodJoggerTable.Enabled = True
        CHK_GoodRubberSuckers.Enabled = True
        CHK_GoodPaperSeparator.Enabled = True
        CHK_GoodGovernorFoot.Enabled = True
        CHK_GoodFeederTable.Enabled = True
        CHK_GoodImpressionCylinder.Enabled = True
        CHK_GoodDelivery.Enabled = True
        CHK_GoodControlConsole.Enabled = True
        CHK_GoodPlasticPallets.Enabled = True
        CHK_GoodTransportBelt.Enabled = True
        CHK_GoodProperlyTagged.Enabled = True
        CHk_GoodInPlasticPallets.Enabled = True
        CHK_GoodWith20thWall.Enabled = True
        CHK_GoodFollowingStandardPallet.Enabled = True
        CHK_GoodWearHairCover.Enabled = True
        CHk_GoodWearsProperlyTuckedIn.Enabled = True
        CHk_GoodHandWashed.Enabled = True
        CHk_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaingMaterials.Enabled = True
        CHK_GoodSafetyDevicesWorking.Enabled = True

        '3. Job Ins
        RTB_JobInstruction.Enabled = True

        TXT_OperatorNumSupervisor.Enabled = True
        TXT_OperatorUCSupervisor.Enabled = True
        DTPOperator.Enabled = True
        DTP_AsstOperator1.Enabled = True
        DTP_AsstOperator2.Enabled = True
        DTPHelper1.Enabled = True
        DTPHelper2.Enabled = True

        CBO_AsstOperator1.Enabled = True
        CBO_AsstOperator2.Enabled = True
        CBO_Helper1.Enabled = True
        CBO_Helper2.Enabled = True

        TXT_AsstOperator1.Enabled = True
        TXT_AsstOperator2.Enabled = True
        TXT_Helper1.Enabled = True
        TXT_Helper2.Enabled = True

        '4. MACHINE SET-UP  / PRODUCT APPROVAL
        CHK_MachineOperator.Enabled = True
        CHK_MachineDrive.Enabled = True
        CHK_MachineRollerGuide.Enabled = True

        CHK_MachineCheck1.Enabled = True
        CHK_MachineCheck2.Enabled = True
        CHK_MachineCheck3.Enabled = True
        CHK_MachineCheck4.Enabled = True
        CHK_MachineCheck5.Enabled = True
        CHK_MachineMechanical.Enabled = True
        CHK_MachineUltrasonic.Enabled = True
        CHK_MachineACFYellowBar.Enabled = True
        CHK_MachineSecurityMatrix.Enabled = True
        CHK_MachinePowerlock.Enabled = True
        TXT_MachinePowerlock.Enabled = True

        TXT_ColorPU1.Enabled = True
        TXT_ColorPU2.Enabled = True
        TXT_ColorPU3.Enabled = True
        TXT_ColorPU4.Enabled = True
        TXT_ColorPU5.Enabled = True
        TXT_ColorPU6.Enabled = True
        TXT_ColorPU7.Enabled = True

        CBO_RollerSettingPU1.Enabled = True
        CBO_RollerSettingPU2.Enabled = True
        CBO_RollerSettingPU3.Enabled = True
        CBO_RollerSettingPU4.Enabled = True
        CBO_RollerSettingPU5.Enabled = True
        CBO_RollerSettingPU6.Enabled = True
        CBO_RollerSettingPU7.Enabled = True

        TXT_RollerSeparationPU1.Enabled = True
        TXT_RollerSeparationPU2.Enabled = True
        TXT_RollerSeparationPU3.Enabled = True
        TXT_RollerSeparationPU4.Enabled = True
        TXT_RollerSeparationPU5.Enabled = True
        TXT_RollerSeparationPU6.Enabled = True
        TXT_RollerSeparationPU7.Enabled = True

        TXT_ImpPressurePU1.Enabled = True
        TXT_ImpPressurePU2.Enabled = True
        TXT_ImpPressurePU3.Enabled = True
        TXT_ImpPressurePU4.Enabled = True
        TXT_ImpPressurePU5.Enabled = True
        TXT_ImpPressurePU6.Enabled = True
        TXT_ImpPressurePU7.Enabled = True

        TXT_MachineInkDensityPU1.Enabled = True
        TXT_MachineInkDensityPU2.Enabled = True
        TXT_MachineInkDensityPU3.Enabled = True
        TXT_MachineInkDensityPU4.Enabled = True
        TXT_MachineInkDensityPU5.Enabled = True
        TXT_MachineInkDensityPU6.Enabled = True
        TXT_MachineInkDensityPU7.Enabled = True

        TXT_MachineInterdeckPU1.Enabled = True
        TXT_MachineInterdeckPU2.Enabled = True
        TXT_MachineInterdeckPU3.Enabled = True
        TXT_MachineInterdeckPU4.Enabled = True
        TXT_MachineInterdeckPU5.Enabled = True
        TXT_MachineInterdeckPU6.Enabled = True
        TXT_MachineInterdeckPU7.Enabled = True

        CHK_UnvarnishBBE.Enabled = True
        CHK_UnvarnishFlap.Enabled = True
        CHK_GlueLap.Enabled = True
        CHK_MachineGrainShort.Enabled = True
        CHK_MachineGrainLong.Enabled = True

        TXT_CoatingUnit1Varnish.Enabled = True
        TXT_CoatingUnit1HotAirDryer1.Enabled = True
        TXT_CoatingUnit1HotAirDryer2.Enabled = True
        TXT_CoatingUnit1HotAirDryer3.Enabled = True
        TXT_CoatingUnit1HotAirDryer4.Enabled = True

        TXT_CoatingUnit1InfraRedDryer1.Enabled = True
        TXT_CoatingUnit1InfraRedDryer2.Enabled = True
        TXT_MachineEndOfPress1.Enabled = True
        TXT_MachineEndOfPress2.Enabled = True
        TXT_MachineEndOfPress3.Enabled = True

        TXT_CoatingUnit1Anilox.Enabled = True
        TXT_MachineColdAit100.Enabled = True
        TXT_CoatingUnit2Varnish.Enabled = True

        TXT_CoatingUnit2HotAirDryer1.Enabled = True
        TXT_CoatingUnit2HotAirDryer2.Enabled = True
        TXT_CoatingUnit2HotAirDryer3.Enabled = True
        TXT_CoatingUnit2HotAirDryer4.Enabled = True

        TXT_MachineSprayType.Enabled = True

        TXT_CoatingUnit2InfraRedDryer1.Enabled = True
        TXT_CoatingUnit2InfraRedDryer2.Enabled = True
        TXT_CoatingUnit2Anilox.Enabled = True
        TXT_MachineSpraySetting.Enabled = True
        TXT_MachineInkingUnitTemp.Enabled = True



        BTN_Save_Supervisor.Enabled = True

        '7. RETURNED OPERATIONAL LOOSE ITEM
        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True
        TXT_StrippingBladeQty1.Enabled = True
        TXT_StrippingBladeQty2.Enabled = True
    End Sub


    Private Sub SelectAllEnableCheck()
        '1. Full line (Non-CHK controls will be removed)
        CHK_FullFeeder.Checked = True
        CHK_FullDelivery.Checked = True
        CHK_FullDrawer.Checked = True
        CHK_FullJogTable.Checked = True
        CHK_FullInk.Checked = True
        CHK_FullVarnish.Checked = True
        CHK_FullFoil.Checked = True
        CHK_FullSupplies.Checked = True

        '2. Good Manu (Set .Checked = True for CHK_ controls)
        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodOilChemical.Checked = True
        CHK_GoodForeignMaterials.Checked = True

        CHK_GoodJoggerTable.Checked = True
        CHK_GoodRubberSuckers.Checked = True
        CHK_GoodPaperSeparator.Checked = True
        CHK_GoodGovernorFoot.Checked = True
        CHK_GoodFeederTable.Checked = True
        CHK_GoodImpressionCylinder.Checked = True
        CHK_GoodDelivery.Checked = True
        CHK_GoodControlConsole.Checked = True
        CHK_GoodPlasticPallets.Checked = True
        CHK_GoodTransportBelt.Checked = True
        CHK_GoodProperlyTagged.Checked = True
        CHk_GoodInPlasticPallets.Checked = True
        CHK_GoodWith20thWall.Checked = True
        CHK_GoodFollowingStandardPallet.Checked = True
        CHK_GoodWearHairCover.Checked = True
        CHk_GoodWearsProperlyTuckedIn.Checked = True
        CHk_GoodHandWashed.Checked = True
        CHk_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaingMaterials.Checked = True
        CHK_GoodSafetyDevicesWorking.Checked = True

        '3. Job Ins (Non-CHK controls will be removed)
        RTB_JobInstruction.Enabled = True

        '4. MACHINE SET-UP  / PRODUCT APPROVAL (Set .Checked = True for CHK_ controls)
        CHK_MachineOperator.Checked = True
        CHK_MachineDrive.Checked = True
        CHK_MachineRollerGuide.Checked = True

        CHK_MachineCheck1.Checked = True
        CHK_MachineCheck2.Checked = True
        CHK_MachineCheck3.Checked = True
        CHK_MachineCheck4.Checked = True
        CHK_MachineCheck5.Checked = True
        CHK_MachineMechanical.Checked = True
        CHK_MachineUltrasonic.Checked = True
        CHK_MachineACFYellowBar.Checked = True
        CHK_MachineSecurityMatrix.Checked = True
        CHK_MachinePowerlock.Checked = True

        CHK_UnvarnishBBE.Checked = True
        CHK_UnvarnishFlap.Checked = True
        CHK_GlueLap.Checked = True

        CHK_MachineGrainShort.Checked = True
        CHK_MachineGrainLong.Checked = True

    End Sub
    Private Sub SelectAllDisabledCheck()
        '1. Full line (Non-CHK controls will be removed)
        CHK_FullFeeder.Checked = False
        CHK_FullDelivery.Checked = False
        CHK_FullDrawer.Checked = False
        CHK_FullJogTable.Checked = False
        CHK_FullInk.Checked = False
        CHK_FullVarnish.Checked = False
        CHK_FullFoil.Checked = False
        CHK_FullSupplies.Checked = False

        '2. Good Manu (Set .Checked = False for CHK_ controls)
        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False

        CHK_GoodJoggerTable.Checked = False
        CHK_GoodRubberSuckers.Checked = False
        CHK_GoodPaperSeparator.Checked = False
        CHK_GoodGovernorFoot.Checked = False
        CHK_GoodFeederTable.Checked = False
        CHK_GoodImpressionCylinder.Checked = False
        CHK_GoodDelivery.Checked = False
        CHK_GoodControlConsole.Checked = False
        CHK_GoodPlasticPallets.Checked = False
        CHK_GoodTransportBelt.Checked = False
        CHK_GoodProperlyTagged.Checked = False
        CHk_GoodInPlasticPallets.Checked = False
        CHK_GoodWith20thWall.Checked = False
        CHK_GoodFollowingStandardPallet.Checked = False
        CHK_GoodWearHairCover.Checked = False
        CHk_GoodWearsProperlyTuckedIn.Checked = False
        CHk_GoodHandWashed.Checked = False
        CHk_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaingMaterials.Checked = False
        CHK_GoodSafetyDevicesWorking.Checked = False


        '4. MACHINE SET-UP  / PRODUCT APPROVAL (Set .Checked = False for CHK_ controls)
        CHK_MachineOperator.Checked = False
        CHK_MachineDrive.Checked = False
        CHK_MachineRollerGuide.Checked = False

        CHK_MachineCheck1.Checked = False
        CHK_MachineCheck2.Checked = False
        CHK_MachineCheck3.Checked = False
        CHK_MachineCheck4.Checked = False
        CHK_MachineCheck5.Checked = False
        CHK_MachineMechanical.Checked = False
        CHK_MachineUltrasonic.Checked = False
        CHK_MachineACFYellowBar.Checked = False
        CHK_MachineSecurityMatrix.Checked = False
        CHK_MachinePowerlock.Checked = False

        CHK_UnvarnishBBE.Checked = False
        CHK_UnvarnishFlap.Checked = False
        CHK_GlueLap.Checked = False


        CHK_MachineGrainShort.Checked = False
        CHK_MachineGrainLong.Checked = False


    End Sub







    Private Sub UC_SupervisorOffset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_helper_empnum1()

        DTPOperator.Format = DateTimePickerFormat.Custom
        DTPOperator.CustomFormat = "hh:mm tt"

        DTP_AsstOperator1.Format = DateTimePickerFormat.Custom
        DTP_AsstOperator1.CustomFormat = "hh:mm tt"



        DTP_AsstOperator2.Format = DateTimePickerFormat.Custom
        DTP_AsstOperator2.CustomFormat = "hh:mm tt"

        DTPHelper1.Format = DateTimePickerFormat.Custom
        DTPHelper1.CustomFormat = "hh:mm tt"


        DTPHelper2.Format = DateTimePickerFormat.Custom
        DTPHelper2.CustomFormat = "hh:mm tt"

        DTPOperator.Text = "12:00 AM"
        DTP_AsstOperator1.Text = "12:00 AM"
        DTP_AsstOperator2.Text = "12:00 AM"
        DTPHelper1.Text = "12:00 AM"
        DTPHelper2.Text = "12:00 AM"

        ' Optional: Set value to default time when no time is selected
        If DTPOperator.Value = DTPOperator.MinDate Then
            DTPOperator.Text = "12:00 AM"
        End If

        If DTP_AsstOperator1.Value = DTP_AsstOperator1.MinDate Then
            DTP_AsstOperator1.Text = "12:00 AM"
        End If

        If DTP_AsstOperator2.Value = DTP_AsstOperator2.MinDate Then
            DTP_AsstOperator2.Text = "12:00 AM"
        End If

        If DTPHelper1.Value = DTPHelper1.MinDate Then
            DTPHelper1.Text = "12:00 AM"
        End If
        If DTPHelper2.Value = DTPHelper2.MinDate Then
            DTPHelper2.Text = "12:00 AM"
        End If

        If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then
            DisabledSupervisorForm()
        Else
            EnabledSupervisorForm()
        End If

        If position <> "Supervisor" Then
            BTN_Save_Supervisor.Visible = False
            CBO_Helper1.Enabled = False
            CBO_Helper2.Enabled = False
            CHK_SelectAll.Visible = False



        End If

        If FRM_MonitoringChecklistMain.TXT_CreatedBy.Text <> "" Then

            If FRM_MonitoringChecklistMain.lbl_empname.Text <> FRM_MonitoringChecklistMain.TXT_CreatedBy.Text Then
                BTN_Save_Supervisor.Enabled = False
            End If
        End If



        TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text



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

                    If dr("flc_drawers").ToString() = "O" Then
                        CHK_FullDrawer.Checked = True
                    Else
                        CHK_FullDrawer.Checked = False
                    End If


                    If dr("flc_joggerTable").ToString() = "O" Then
                        CHK_FullJogTable.Checked = True
                    Else
                        CHK_FullJogTable.Checked = False
                    End If


                    'B
                    If dr("flc_inks").ToString() = "O" Then
                        CHK_FullInk.Checked = True
                    Else
                        CHK_FullInk.Checked = False
                    End If


                    If dr("flc_varnish").ToString() = "O" Then
                        CHK_FullVarnish.Checked = True
                    Else
                        CHK_FullVarnish.Checked = False
                    End If


                    If dr("flc_foil").ToString() = "O" Then
                        CHK_FullFoil.Checked = True
                    Else
                        CHK_FullFoil.Checked = False
                    End If

                    If dr("flc_supplies").ToString() = "O" Then
                        CHK_FullSupplies.Checked = True
                    Else
                        CHK_FullSupplies.Checked = False
                    End If





                    TXT_PaperFrom.Text = dr("flc_OffPaperFr").ToString()
                    TXT_PaperTo.Text = dr("flc_OffPaperTo").ToString()
                    TXT_InksFrom.Text = dr("flc_OffInkFr").ToString()
                    TXT_InksTo.Text = dr("flc_OffInkTo").ToString()
                    TXT_VanishFrom.Text = dr("flc_OffVrnshFr").ToString()
                    TXT_VanishTo.Text = dr("flc_OffVrnshTo").ToString()

                    TXT_FoilFrom.Text = dr("flc_OffFoilFr").ToString()
                    TXT_FoilTo.Text = dr("flc_OffFoilTo").ToString()



                    TXT_FullBallpenQty.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_FullRagsQty.Text = dr("flc_OLCragqty").ToString()
                    TXT_FullStrippingKnifeQty1.Text = dr("flc_OLCstripknife").ToString()
                    TXT_FullStrippingKnifeQty2.Text = dr("flc_OLCstripbld").ToString()
                    TXT_FullMarterQty.Text = dr("flc_OLCmarkerqty").ToString()















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

                    'A

                    If dr("gmp_NoExcessDustDirt").ToString() = "O" Then
                        CHK_GoodExcessiveDust.Checked = True
                    Else
                        CHK_GoodExcessiveDust.Checked = False
                    End If


                    If dr("gmp_NoOilChemSpill").ToString() = "O" Then
                        CHK_GoodOilChemical.Checked = True
                    Else
                        CHK_GoodOilChemical.Checked = False
                    End If



                    If dr("gmp_NoForeignMatls").ToString() = "O" Then
                        CHK_GoodForeignMaterials.Checked = True
                    Else
                        CHK_GoodForeignMaterials.Checked = False
                    End If


                    'B


                    If dr("gmp_SaniJoggerTable").ToString() = "O" Then
                        CHK_GoodJoggerTable.Checked = True
                    Else
                        CHK_GoodJoggerTable.Checked = False
                    End If


                    If dr("gmp_SaniRubberSucker").ToString() = "O" Then
                        CHK_GoodRubberSuckers.Checked = True
                    Else
                        CHK_GoodRubberSuckers.Checked = False
                    End If




                    If dr("gmp_SaniPaperSep").ToString() = "O" Then
                        CHK_GoodPaperSeparator.Checked = True
                    Else
                        CHK_GoodPaperSeparator.Checked = False
                    End If



                    If dr("gmp_SaniGovfoot").ToString() = "O" Then
                        CHK_GoodGovernorFoot.Checked = True
                    Else
                        CHK_GoodGovernorFoot.Checked = False
                    End If





                    If dr("gmp_SaniFeederTable").ToString() = "O" Then
                        CHK_GoodFeederTable.Checked = True
                    Else
                        CHK_GoodFeederTable.Checked = False
                    End If





                    If dr("gmp_SaniTransportBelt").ToString() = "O" Then
                        CHK_GoodTransportBelt.Checked = True
                    Else
                        CHK_GoodTransportBelt.Checked = False
                    End If


                    If dr("gmp_SaniImpCylinder").ToString() = "O" Then
                        CHK_GoodImpressionCylinder.Checked = True
                    Else
                        CHK_GoodImpressionCylinder.Checked = False
                    End If



                    If dr("gmp_SaniDelRakeBrd").ToString() = "O" Then
                        CHK_GoodDelivery.Checked = True
                    Else
                        CHK_GoodDelivery.Checked = False
                    End If



                    If dr("gmp_SaniCtrlConsoleTbl").ToString() = "O" Then
                        CHK_GoodControlConsole.Checked = True
                    Else
                        CHK_GoodControlConsole.Checked = False
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
                        CHk_GoodInPlasticPallets.Checked = True
                    Else
                        CHk_GoodInPlasticPallets.Checked = False
                    End If

                    If dr("gmp_Pre20inClearance").ToString() = "O" Then
                        CHK_GoodWith20thWall.Checked = True
                    Else
                        CHK_GoodWith20thWall.Checked = False
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


                    'E

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
        Dim AssOperator1 As String = ""
        Dim AssOperator2 As String = ""

        Dim helper1 As String = ""
        Dim helper2 As String = ""



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
                    AssOperator2 = dr("jic_AsstOper2").ToString()
                    helper1 = dr("jic_Helper1").ToString()
                    helper2 = dr("jic_Helper2").ToString()

                    TXT_AsstOperator1.Text = AssOperator1
                    TXT_AsstOperator2.Text = AssOperator2
                    TXT_Helper1.Text = helper1
                    TXT_Helper2.Text = helper2

                    DTPOperator.Text = dr("jic_OperatorTime").ToString()
                    DTP_AsstOperator1.Text = dr("jic_AsstOper1Time").ToString()
                    DTP_AsstOperator2.Text = dr("jic_AsstOper2Time").ToString()
                    DTPHelper1.Text = dr("jic_Helper1Time").ToString()
                    DTPHelper1.Text = dr("jic_Helper1Time").ToString()
                    DTPHelper2.Text = dr("jic_Helper2Time").ToString()
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
            cmd.Parameters.AddWithValue("@emp_num", AssOperator2)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_AsstOperator2.Text = dr("Name")

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
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", helper2)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_Helper2.Text = dr("Name").ToString()
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
            cmd.CommandText = "Select_sppmcMSPA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then


                    If dr("mspa_OFSGOperator").ToString() = "O" Then
                        CHK_MachineOperator.Checked = True
                    Else
                        CHK_MachineOperator.Checked = False
                    End If

                    If dr("mspa_OFSGDrive").ToString() = "O" Then
                        CHK_MachineDrive.Checked = True
                    Else
                        CHK_MachineDrive.Checked = False
                    End If

                    If dr("mspa_OFSGRollGuide").ToString() = "O" Then
                        CHK_MachineRollerGuide.Checked = True
                    Else
                        CHK_MachineRollerGuide.Checked = False
                    End If





                    'ddsadsa
                    If dr("mspa_OFSGA1").ToString() = "O" Then
                        CHK_MachineCheck1.Checked = True
                    Else
                        CHK_MachineCheck1.Checked = False
                    End If


                    If dr("mspa_OFSGA2").ToString() = "O" Then
                        CHK_MachineCheck2.Checked = True
                    Else
                        CHK_MachineCheck2.Checked = False
                    End If


                    If dr("mspa_OFSGA3").ToString() = "O" Then
                        CHK_MachineCheck3.Checked = True
                    Else
                        CHK_MachineCheck3.Checked = False
                    End If


                    If dr("mspa_OFSGA4").ToString() = "O" Then
                        CHK_MachineCheck4.Checked = True
                    Else
                        CHK_MachineCheck4.Checked = False
                    End If


                    If dr("mspa_OFSGA5").ToString() = "O" Then
                        CHK_MachineCheck5.Checked = True
                    Else
                        CHK_MachineCheck5.Checked = False
                    End If




                    If dr("mspa_OFDFMechanic").ToString() = "O" Then
                        CHK_MachineMechanical.Checked = True
                    Else
                        CHK_MachineMechanical.Checked = False
                    End If



                    If dr("mspa_OFDFUltrasonic").ToString() = "O" Then
                        CHK_MachineUltrasonic.Checked = True
                    Else
                        CHK_MachineUltrasonic.Checked = False
                    End If



                    'security

                    If dr("mspa_OFSFacfybar").ToString() = "O" Then
                        CHK_MachineACFYellowBar.Checked = True
                    Else
                        CHK_MachineACFYellowBar.Checked = False
                    End If


                    If dr("mspa_OFSFsecmatrix").ToString() = "O" Then
                        CHK_MachineSecurityMatrix.Checked = True
                    Else
                        CHK_MachineSecurityMatrix.Checked = False
                    End If

                    If dr("mspa_OFSFpwrlock").ToString() = "O" Then
                        CHK_MachinePowerlock.Checked = True
                    Else
                        CHK_MachinePowerlock.Checked = False
                    End If

                    If dr("mspa_OFWtrFounMRLB").ToString() = "O" Then
                        CHK_WtrFounMRLB.Checked = True
                    Else
                        CHK_WtrFounMRLB.Checked = False
                    End If
                    TXT_MachinePowerlock.Text = dr("mspa_OFSFpwrlockval").ToString()


                        TXT_ColorPU1.Text = dr("mspa_OFColorPU1").ToString()
                        TXT_ColorPU2.Text = dr("mspa_OFColorPU2").ToString()
                        TXT_ColorPU3.Text = dr("mspa_OFColorPU3").ToString()
                        TXT_ColorPU4.Text = dr("mspa_OFColorPU4").ToString()
                        TXT_ColorPU5.Text = dr("mspa_OFColorPU5").ToString()
                        TXT_ColorPU6.Text = dr("mspa_OFColorPU6").ToString()
                        TXT_ColorPU7.Text = dr("mspa_OFColorPU7").ToString()


                        If dr("mspa_OFRollStPU1").ToString() = "O" Then
                            CBO_RollerSettingPU1.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU1").ToString() = "X" Then
                            CBO_RollerSettingPU1.Text = "X"
                        Else
                            CBO_RollerSettingPU1.Text = "N/A"
                        End If




                        If dr("mspa_OFRollStPU2").ToString() = "O" Then
                            CBO_RollerSettingPU2.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU2").ToString() = "X" Then
                            CBO_RollerSettingPU2.Text = "X"
                        Else
                            CBO_RollerSettingPU2.Text = "N/A"
                        End If

                        If dr("mspa_OFRollStPU3").ToString() = "O" Then
                            CBO_RollerSettingPU3.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU3").ToString() = "X" Then
                            CBO_RollerSettingPU3.Text = "X"
                        Else
                            CBO_RollerSettingPU3.Text = "N/A"
                        End If

                        If dr("mspa_OFRollStPU4").ToString() = "O" Then
                            CBO_RollerSettingPU4.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU4").ToString() = "X" Then
                            CBO_RollerSettingPU4.Text = "X"
                        Else
                            CBO_RollerSettingPU4.Text = "N/A"
                        End If

                        If dr("mspa_OFRollStPU5").ToString() = "O" Then
                            CBO_RollerSettingPU5.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU5").ToString() = "X" Then
                            CBO_RollerSettingPU5.Text = "X"
                        Else
                            CBO_RollerSettingPU5.Text = "N/A"
                        End If

                        If dr("mspa_OFRollStPU6").ToString() = "O" Then
                            CBO_RollerSettingPU6.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU6").ToString() = "X" Then
                            CBO_RollerSettingPU6.Text = "X"
                        Else
                            CBO_RollerSettingPU6.Text = "N/A"
                        End If

                        If dr("mspa_OFRollStPU7").ToString() = "O" Then
                            CBO_RollerSettingPU7.Text = "✓"
                        ElseIf dr("mspa_OFRollStPU7").ToString() = "X" Then
                            CBO_RollerSettingPU7.Text = "X"
                        Else
                            CBO_RollerSettingPU7.Text = "N/A"
                        End If

                        TXT_RollerSeparationPU1.Text = dr("mspa_OFRollSepPU1").ToString()
                        TXT_RollerSeparationPU2.Text = dr("mspa_OFRollSepPU2").ToString()
                        TXT_RollerSeparationPU3.Text = dr("mspa_OFRollSepPU3").ToString()
                        TXT_RollerSeparationPU4.Text = dr("mspa_OFRollSepPU4").ToString()
                        TXT_RollerSeparationPU5.Text = dr("mspa_OFRollSepPU5").ToString()
                        TXT_RollerSeparationPU6.Text = dr("mspa_OFRollSepPU6").ToString()
                        TXT_RollerSeparationPU7.Text = dr("mspa_OFRollSepPU7").ToString()


                        TXT_ImpPressurePU1.Text = dr("mspa_OFImPrePU1").ToString()
                        TXT_ImpPressurePU2.Text = dr("mspa_OFImPrePU2").ToString()
                        TXT_ImpPressurePU3.Text = dr("mspa_OFImPrePU3").ToString()
                        TXT_ImpPressurePU4.Text = dr("mspa_OFImPrePU4").ToString()
                        TXT_ImpPressurePU5.Text = dr("mspa_OFImPrePU5").ToString()
                        TXT_ImpPressurePU6.Text = dr("mspa_OFImPrePU6").ToString()
                        TXT_ImpPressurePU7.Text = dr("mspa_OFImPrePU7").ToString()



                        TXT_MachineInkDensityPU1.Text = dr("mspa_OFInkDenPU1").ToString()
                        TXT_MachineInkDensityPU2.Text = dr("mspa_OFInkDenPU2").ToString()
                        TXT_MachineInkDensityPU3.Text = dr("mspa_OFInkDenPU3").ToString()
                        TXT_MachineInkDensityPU4.Text = dr("mspa_OFInkDenPU4").ToString()
                        TXT_MachineInkDensityPU5.Text = dr("mspa_OFInkDenPU5").ToString()
                        TXT_MachineInkDensityPU6.Text = dr("mspa_OFInkDenPU6").ToString()
                        TXT_MachineInkDensityPU7.Text = dr("mspa_OFInkDenPU7").ToString()



                        TXT_MachineInterdeckPU1.Text = dr("mspa_OFIntdeckPU1").ToString()
                        TXT_MachineInterdeckPU2.Text = dr("mspa_OFIntdeckPU2").ToString()
                        TXT_MachineInterdeckPU3.Text = dr("mspa_OFIntdeckPU3").ToString()
                        TXT_MachineInterdeckPU4.Text = dr("mspa_OFIntdeckPU4").ToString()
                        TXT_MachineInterdeckPU5.Text = dr("mspa_OFIntdeckPU5").ToString()
                        TXT_MachineInterdeckPU6.Text = dr("mspa_OFIntdeckPU6").ToString()
                        TXT_MachineInterdeckPU7.Text = dr("mspa_OFIntdeckPU7").ToString()


                        If dr("mspa_OFUABBE").ToString() = "O" Then
                            CHK_UnvarnishBBE.Checked = True
                        Else
                            CHK_UnvarnishBBE.Checked = False
                        End If


                        If dr("mspa_OFUAFlap").ToString() = "O" Then
                            CHK_UnvarnishFlap.Checked = True
                        Else
                            CHK_UnvarnishFlap.Checked = False
                        End If

                        '
                        If dr("mspa_OFUAGluelap").ToString() = "O" Then
                            CHK_GlueLap.Checked = True
                        Else
                            CHK_GlueLap.Checked = False
                        End If



                        If dr("mspa_OFGDShort").ToString() = "O" Then
                            CHK_MachineGrainShort.Checked = True
                        Else
                            CHK_MachineGrainShort.Checked = False
                        End If


                        If dr("mspa_OFGDLong").ToString() = "O" Then
                            CHK_MachineGrainLong.Checked = True
                        Else
                            CHK_MachineGrainLong.Checked = False
                        End If



                        'COATING 1
                        TXT_CoatingUnit1Varnish.Text = dr("mspa_OFCU1Varnish").ToString()
                        TXT_CoatingUnit1HotAirDryer1.Text = dr("mspa_OFCU1HotDry1").ToString()
                        TXT_CoatingUnit1HotAirDryer2.Text = dr("mspa_OFCU1HotDry2").ToString()
                        TXT_CoatingUnit1HotAirDryer3.Text = dr("mspa_OFCU1HotDry3").ToString()
                        TXT_CoatingUnit1HotAirDryer4.Text = dr("mspa_OFCU1HotDry4").ToString()


                        TXT_CoatingUnit1InfraRedDryer1.Text = dr("mspa_OFCU1InfraDry1").ToString()
                        TXT_CoatingUnit1InfraRedDryer2.Text = dr("mspa_OFCU1InfraDry2").ToString()
                        TXT_CoatingUnit1Anilox.Text = dr("mspa_OFCU1InfraAnilox").ToString()
                        TXT_MachineColdAit100.Text = dr("mspa_OFColdAir").ToString()



                        TXT_MachineEndOfPress1.Text = dr("mspa_OFEndPress1").ToString()
                        TXT_MachineEndOfPress2.Text = dr("mspa_OFEndPress2").ToString()
                        TXT_MachineEndOfPress3.Text = dr("mspa_OFEndPress3").ToString()
                        TXT_MachineColdAit100.Text = dr("mspa_OFColdAir").ToString()




                        'COATING 2
                        TXT_CoatingUnit2Varnish.Text = dr("mspa_OFCU2Varnish").ToString()
                        TXT_CoatingUnit2HotAirDryer1.Text = dr("mspa_OFCU2HotDry1").ToString()
                        TXT_CoatingUnit2HotAirDryer2.Text = dr("mspa_OFCU2HotDry2").ToString()
                        TXT_CoatingUnit2HotAirDryer3.Text = dr("mspa_OFCU2HotDry3").ToString()
                        TXT_CoatingUnit2HotAirDryer4.Text = dr("mspa_OFCU2HotDry4").ToString()

                        TXT_CoatingUnit2InfraRedDryer1.Text = dr("mspa_OFCU2InfraDry1").ToString()
                        TXT_CoatingUnit2InfraRedDryer2.Text = dr("mspa_OFCU2InfraDry2").ToString()
                        TXT_CoatingUnit2Anilox.Text = dr("mspa_OFCU2InfraAnilox").ToString()

                        TXT_MachineSprayType.Text = dr("mspa_OFSprPowdrType").ToString()
                        TXT_MachineSpraySetting.Text = dr("mspa_OFSprPowdrSet").ToString()

                        TXT_MachineInkingUnitTemp.Text = dr("mspa_OFInkUntTemp").ToString()



                    End If
                End If


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
                    TXT_StrippingBladeQty1.Text = dr("stripknife").ToString()
                    TXT_StrippingBladeQty2.Text = dr("stripknifebld").ToString()




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
        Dim FullFeeder As String = ""
        Dim FullDelivery As String = ""
        Dim FullDrawer As String = ""
        Dim FullJogTable As String = ""

        Dim FullInk As String = ""
        Dim FullVarnish As String = ""
        Dim FullFoil As String = ""
        Dim FullSupplies As String = ""

        'FULL LINE A


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

        If CHK_FullDrawer.Checked Then
            FullDrawer = "O"
        Else
            FullDrawer = "X"
        End If


        If CHK_FullJogTable.Checked Then
            FullJogTable = "O"
        Else
            FullJogTable = "X"
        End If



        'FULL LINE B

        If CHK_FullInk.Checked Then
            FullInk = "O"
        Else
            FullInk = "X"
        End If


        If CHK_FullVarnish.Checked Then
            FullVarnish = "O"
        Else
            FullVarnish = "X"
        End If


        If CHK_FullFoil.Checked Then
            FullFoil = "O"
        Else
            FullFoil = "X"
        End If


        If CHK_FullSupplies.Checked Then
            FullSupplies = "O"
        Else
            FullSupplies = "X"
        End If




        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcFLC"
            cmd.CommandType = CommandType.StoredProcedure

            'Clear any existing parameters
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", "")
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", FullJogTable)
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", "")
                cmd.Parameters.AddWithValue("@flc_palletTag", "")
                cmd.Parameters.AddWithValue("@flc_feeder", FullFeeder)
                cmd.Parameters.AddWithValue("@flc_delivery", FullDelivery)
                cmd.Parameters.AddWithValue("@flc_drawers", FullDrawer)
                cmd.Parameters.AddWithValue("@flc_inks", FullInk)
                cmd.Parameters.AddWithValue("@flc_varnish", FullVarnish)
                cmd.Parameters.AddWithValue("@flc_foil", FullFoil)
                cmd.Parameters.AddWithValue("@flc_supplies", FullSupplies)
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
                cmd.Parameters.AddWithValue("@flc_proofTray", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", TXT_PaperFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", TXT_PaperTo.Text)
                cmd.Parameters.AddWithValue("@flc_OffInkFr", TXT_InksFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffInkTo", TXT_InksTo.Text)
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", TXT_VanishFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", TXT_VanishTo.Text)
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", TXT_FoilFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffFoilTo", TXT_FoilTo.Text)


                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_FullBallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_FullRagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", TXT_FullStrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", TXT_FullStrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FullMarterQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCgluebottle", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersdesc", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersqty", "")
                cmd.Parameters.AddWithValue("@flc_chairs", "")
                cmd.Parameters.AddWithValue("@flc_OLCcotglovQty", "")
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                con.Close()

                OpenConnection()
                cmd.CommandText = "Insert_sppmcFLC"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@flc_cuttingtable", "")
                cmd.Parameters.AddWithValue("@flc_wasteBin", "")
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", FullJogTable)
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", "")
                cmd.Parameters.AddWithValue("@flc_palletTag", "")
                cmd.Parameters.AddWithValue("@flc_feeder", FullFeeder)
                cmd.Parameters.AddWithValue("@flc_delivery", FullDelivery)
                cmd.Parameters.AddWithValue("@flc_drawers", FullDrawer)
                cmd.Parameters.AddWithValue("@flc_inks", FullInk)
                cmd.Parameters.AddWithValue("@flc_varnish", FullVarnish)
                cmd.Parameters.AddWithValue("@flc_foil", FullFoil)
                cmd.Parameters.AddWithValue("@flc_supplies", FullSupplies)
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
                cmd.Parameters.AddWithValue("@flc_proofTray", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", TXT_PaperFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", TXT_PaperTo.Text)
                cmd.Parameters.AddWithValue("@flc_OffInkFr", TXT_InksFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffInkTo", TXT_InksTo.Text)
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", TXT_VanishFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", TXT_VanishTo.Text)
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", TXT_FoilFrom.Text)
                cmd.Parameters.AddWithValue("@flc_OffFoilTo", TXT_FoilTo.Text)


                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_FullBallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_FullRagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", TXT_FullStrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", TXT_FullStrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FullMarterQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCgluebottle", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersdesc", "")
                cmd.Parameters.AddWithValue("@flc_OLCothersqty", "")
                cmd.Parameters.AddWithValue("@flc_chairs", "")
                cmd.Parameters.AddWithValue("@flc_OLCcotglovQty", "")
                cmd.ExecuteNonQuery()
                con.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'GOOD A
        Dim GoodExcessiveDust As String = ""
        Dim GoodOilChemical As String = ""
        Dim GoodForeignMaterials As String = ""
        Dim GoodCuttingTable As String = ""



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








        'GOOD B
        Dim GoodJoggerTable As String = ""
        Dim GoodRubberSuckers As String = ""
        Dim GoodPaperSeparator As String = ""
        Dim GoodGovernorFoot As String = ""
        Dim GoodFeederTable As String = ""
        Dim GoodTransportBelt As String = ""
        Dim GoodImpressionCylinder As String = ""
        Dim GoodDelivery As String = ""
        Dim GoodControlConsole As String = ""
        Dim GoodPlasticPallets As String = ""

        If CHK_GoodJoggerTable.Checked Then
            GoodJoggerTable = "O"
        Else
            GoodJoggerTable = "X"
        End If


        If CHK_GoodRubberSuckers.Checked Then
            GoodRubberSuckers = "O"
        Else
            GoodRubberSuckers = "X"
        End If


        If CHK_GoodPaperSeparator.Checked Then
            GoodPaperSeparator = "O"
        Else
            GoodPaperSeparator = "X"
        End If


        If CHK_GoodGovernorFoot.Checked Then
            GoodGovernorFoot = "O"
        Else
            GoodGovernorFoot = "X"
        End If


        If CHK_GoodFeederTable.Checked Then
            GoodFeederTable = "O"
        Else
            GoodFeederTable = "X"
        End If




        If CHK_GoodTransportBelt.Checked Then
            GoodTransportBelt = "O"
        Else
            GoodTransportBelt = "X"
        End If


        If CHK_GoodImpressionCylinder.Checked Then
            GoodImpressionCylinder = "O"
        Else
            GoodImpressionCylinder = "X"
        End If


        If CHK_GoodDelivery.Checked Then
            GoodDelivery = "O"
        Else
            GoodDelivery = "X"
        End If


        If CHK_GoodControlConsole.Checked Then
            GoodControlConsole = "O"
        Else
            GoodControlConsole = "X"
        End If


        If CHK_GoodPlasticPallets.Checked Then
            GoodPlasticPallets = "O"
        Else
            GoodPlasticPallets = "X"
        End If






        'GOOD C
        Dim GoodProperlyTagged As String = ""
        Dim GoodInPlasticPallets As String = ""
        Dim GoodWith20thWall As String = ""
        Dim GoodFollowingStandardPallet As String = ""



        If CHK_GoodProperlyTagged.Checked Then
            GoodProperlyTagged = "O"
        Else
            GoodProperlyTagged = "X"
        End If


        If CHk_GoodInPlasticPallets.Checked Then
            GoodInPlasticPallets = "O"
        Else
            GoodInPlasticPallets = "X"
        End If



        If CHK_GoodWith20thWall.Checked Then
            GoodWith20thWall = "O"
        Else
            GoodWith20thWall = "X"
        End If



        If CHK_GoodFollowingStandardPallet.Checked Then
            GoodFollowingStandardPallet = "O"
        Else
            GoodFollowingStandardPallet = "X"
        End If



        'GOOD D
        Dim GoodWearHairCover As String = ""
        Dim GoodWearsProperlyTuckedIn As String = ""
        Dim GoodHandWashed As String = ""

        If CHK_GoodWearHairCover.Checked Then
            GoodWearHairCover = "O"
        Else
            GoodWearHairCover = "X"
        End If

        If CHk_GoodWearsProperlyTuckedIn.Checked Then
            GoodWearsProperlyTuckedIn = "O"
        Else
            GoodWearsProperlyTuckedIn = "X"
        End If

        If CHk_GoodHandWashed.Checked Then
            GoodHandWashed = "O"
        Else
            GoodHandWashed = "X"
        End If

        'GOOD E
        Dim GoodTools As String = ""
        Dim GoodEquipment As String = ""
        Dim GoodCleaingMaterials As String = ""
        Dim GoodSafetyMaterialsWorking As String = ""

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
            GoodCleaingMaterials = "O"
        Else
            GoodCleaingMaterials = "X"
        End If

        If CHK_GoodSafetyDevicesWorking.Checked Then
            GoodSafetyMaterialsWorking = "O"
        Else
            GoodSafetyMaterialsWorking = "X"
        End If



        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcGMP"
            cmd.CommandType = CommandType.StoredProcedure

            'Clear any existing parameters
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

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTable", "")



                cmd.Parameters.AddWithValue("@gmp_SaniCuttingBlade", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCuttingTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniControlPanel", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRubberSucker", GoodRubberSuckers)
                cmd.Parameters.AddWithValue("@gmp_SaniPaperSep", GoodPaperSeparator)
                cmd.Parameters.AddWithValue("@gmp_SaniGovfoot", GoodGovernorFoot)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTable", GoodFeederTable)
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", GoodTransportBelt)
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", GoodImpressionCylinder)
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", GoodDelivery)
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", GoodControlConsole)
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", GoodPlasticPallets)
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
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodInPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20thWall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPallet)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCover)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearsProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", GoodTools)
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaingMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", GoodSafetyMaterialsWorking)
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

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTable", "")

                cmd.Parameters.AddWithValue("@gmp_SaniCuttingBlade", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCuttingTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniControlPanel", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRubberSucker", GoodRubberSuckers)
                cmd.Parameters.AddWithValue("@gmp_SaniPaperSep", GoodPaperSeparator)
                cmd.Parameters.AddWithValue("@gmp_SaniGovfoot", GoodGovernorFoot)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTable", GoodFeederTable)
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", GoodTransportBelt)
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", GoodImpressionCylinder)
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", GoodDelivery)
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", GoodControlConsole)
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", GoodPlasticPallets)
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
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodInPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20thWall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPallet)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCover)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearsProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", GoodTools)
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaingMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", GoodSafetyMaterialsWorking)
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
                cmd.Parameters.AddWithValue("@jic_Helper2", TXT_Helper2.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper1", TXT_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2", TXT_AsstOperator2.Text)
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
                cmd.Parameters.AddWithValue("@jic_Helper2Time", DTPHelper2.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", DTP_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2Time", DTP_AsstOperator2.Text)
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
                cmd.Parameters.AddWithValue("@jic_Helper2", TXT_Helper2.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper1", TXT_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2", TXT_AsstOperator2.Text)
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
                cmd.Parameters.AddWithValue("@jic_Helper2Time", DTPHelper2.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", DTP_AsstOperator1.Text)
                cmd.Parameters.AddWithValue("@jic_AsstOper2Time", DTP_AsstOperator2.Text)
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


        Dim MachineOperator As String = ""
        Dim MachineDrive As String = ""
        Dim MachineRollerGuide As String = ""
        Dim MachineDoubleFeedDetector As String = ""

        Dim MachineCheck1 As String = ""
        Dim MachineCheck2 As String = ""
        Dim MachineCheck3 As String = ""
        Dim MachineCheck4 As String = ""
        Dim MachineCheck5 As String = ""
        Dim MachineMechanical As String = ""
        Dim MachineUltrasonic As String = ""



        If CHK_MachineOperator.Checked Then
            MachineOperator = "O"
        Else
            MachineOperator = "X"
        End If



        If CHK_MachineDrive.Checked Then
            MachineDrive = "O"
        Else
            MachineDrive = "X"
        End If




        If CHK_MachineRollerGuide.Checked Then
            MachineRollerGuide = "O"
        Else
            MachineRollerGuide = "X"
        End If







        If CHK_MachineCheck1.Checked Then
            MachineCheck1 = "O"
        Else
            MachineCheck1 = "X"
        End If




        If CHK_MachineCheck2.Checked Then
            MachineCheck2 = "O"
        Else
            MachineCheck2 = "X"
        End If



        If CHK_MachineCheck3.Checked Then
            MachineCheck3 = "O"
        Else
            MachineCheck3 = "X"
        End If



        If CHK_MachineCheck4.Checked Then
            MachineCheck4 = "O"
        Else
            MachineCheck4 = "X"
        End If



        If CHK_MachineCheck5.Checked Then
            MachineCheck5 = "O"
        Else
            MachineCheck5 = "X"
        End If



        If CHK_MachineMechanical.Checked Then
            MachineMechanical = "O"
        Else
            MachineMechanical = "X"
        End If



        If CHK_MachineUltrasonic.Checked Then
            MachineUltrasonic = "O"
        Else
            MachineUltrasonic = "X"
        End If




        Dim MachineACFYellowBar As String = ""
        Dim MachineSecurityMatrix As String = ""
        Dim MachinePowerlock As String = ""



        If CHK_MachineACFYellowBar.Checked Then
            MachineACFYellowBar = "O"
        Else
            MachineACFYellowBar = "X"
        End If



        If CHK_MachineSecurityMatrix.Checked Then
            MachineSecurityMatrix = "O"
        Else
            MachineSecurityMatrix = "X"
        End If



        If CHK_MachinePowerlock.Checked Then
            MachinePowerlock = "O"
        Else
            MachinePowerlock = "X"
        End If


        'unvarnish application

        Dim UnvarnishBBE As String = ""
        Dim UnvarnishFlap As String = ""
        Dim GlueLap As String = ""

        Dim MachineGrainShort As String = ""
        Dim MachineGrainLong As String = ""
        Dim WtrFounMRLB As String = ""



        If CHK_UnvarnishBBE.Checked Then
            UnvarnishBBE = "O"
        Else
            UnvarnishBBE = "X"
        End If



        If CHK_UnvarnishFlap.Checked Then
            UnvarnishFlap = "O"
        Else
            UnvarnishFlap = "X"
        End If



        If CHK_GlueLap.Checked Then
            GlueLap = "O"
        Else
            GlueLap = "X"
        End If




        If CHK_MachineGrainShort.Checked Then
            MachineGrainShort = "O"
        Else
            MachineGrainShort = "X"
        End If



        If CHK_MachineGrainLong.Checked Then
            MachineGrainLong = "O"
        Else
            MachineGrainLong = "X"
        End If


        If CHK_WtrFounMRLB.Checked Then
            WtrFounMRLB = "O"
        Else
            WtrFounMRLB = "X"
        End If



        Dim ColdAirDecimal As Double


        Double.TryParse(TXT_MachineColdAit100.Text, ColdAirDecimal)


        Dim selectedRollerSetting1 As String = ""
        Dim selectedRollerSetting2 As String = ""
        Dim selectedRollerSetting3 As String = ""
        Dim selectedRollerSetting4 As String = ""
        Dim selectedRollerSetting5 As String = ""
        Dim selectedRollerSetting6 As String = ""
        Dim selectedRollerSetting7 As String = ""




        If CBO_RollerSettingPU1.Text.Trim() = "✓" Then
            selectedRollerSetting1 = "O"
        ElseIf CBO_RollerSettingPU1.Text.Trim() = "X" Then
            selectedRollerSetting1 = "X"
        Else
            selectedRollerSetting1 = "N"
        End If

        If CBO_RollerSettingPU2.Text.Trim() = "✓" Then
            selectedRollerSetting2 = "O"
        ElseIf CBO_RollerSettingPU2.Text.Trim() = "X" Then
            selectedRollerSetting2 = "X"
        Else
            selectedRollerSetting2 = "N"
        End If

        If CBO_RollerSettingPU3.Text.Trim() = "✓" Then
            selectedRollerSetting3 = "O"
        ElseIf CBO_RollerSettingPU3.Text.Trim() = "X" Then
            selectedRollerSetting3 = "X"
        Else
            selectedRollerSetting3 = "N"
        End If

        If CBO_RollerSettingPU4.Text.Trim() = "✓" Then
            selectedRollerSetting4 = "O"
        ElseIf CBO_RollerSettingPU4.Text.Trim() = "X" Then
            selectedRollerSetting4 = "X"
        Else
            selectedRollerSetting4 = "N"
        End If

        If CBO_RollerSettingPU5.Text.Trim() = "✓" Then
            selectedRollerSetting5 = "O"
        ElseIf CBO_RollerSettingPU5.Text.Trim() = "X" Then
            selectedRollerSetting5 = "X"
        Else
            selectedRollerSetting5 = "N"
        End If

        If CBO_RollerSettingPU6.Text.Trim() = "✓" Then
            selectedRollerSetting6 = "O"
        ElseIf CBO_RollerSettingPU6.Text.Trim() = "X" Then
            selectedRollerSetting6 = "X"
        Else
            selectedRollerSetting6 = "N"
        End If


        If CBO_RollerSettingPU7.Text.Trim() = "✓" Then
            selectedRollerSetting7 = "O"
        ElseIf CBO_RollerSettingPU7.Text.Trim() = "X" Then
            selectedRollerSetting7 = "X"
        Else
            selectedRollerSetting7 = "N"
        End If









        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcMSPA"
            cmd.CommandType = CommandType.StoredProcedure

            'Clear any existing parameters
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

                cmd.Parameters.AddWithValue("@mspa_OFSGOperator", MachineOperator)
                cmd.Parameters.AddWithValue("@mspa_OFSGDrive", MachineDrive)
                cmd.Parameters.AddWithValue("@mspa_OFSGRollGuide", MachineRollerGuide)
                cmd.Parameters.AddWithValue("@mspa_OFSGA1", MachineCheck1)
                cmd.Parameters.AddWithValue("@mspa_OFSGA2", MachineCheck2)
                cmd.Parameters.AddWithValue("@mspa_OFSGA3", MachineCheck3)
                cmd.Parameters.AddWithValue("@mspa_OFSGA4", MachineCheck4)
                cmd.Parameters.AddWithValue("@mspa_OFSGA5", MachineCheck5)
                cmd.Parameters.AddWithValue("@mspa_OFDFMechanic", MachineMechanical)
                cmd.Parameters.AddWithValue("@mspa_OFDFUltrasonic", MachineUltrasonic)
                cmd.Parameters.AddWithValue("@mspa_OFUABBE", UnvarnishBBE)
                cmd.Parameters.AddWithValue("@mspa_OFUAFlap", UnvarnishFlap)
                cmd.Parameters.AddWithValue("@mspa_OFUAGluelap", GlueLap)
                cmd.Parameters.AddWithValue("@mspa_OFGDShort", MachineGrainShort)
                cmd.Parameters.AddWithValue("@mspa_OFGDLong", MachineGrainLong)

                cmd.Parameters.AddWithValue("@mspa_OFWtrFounMRLB", WtrFounMRLB) 'ADD THIS NEW PARAMETER ERIAN 4 MARCH 2025 1:43 PM

                cmd.Parameters.AddWithValue("@mspa_OFColorPU1", TXT_ColorPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU2", TXT_ColorPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU3", TXT_ColorPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU4", TXT_ColorPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU5", TXT_ColorPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU6", TXT_ColorPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU7", TXT_ColorPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU1", selectedRollerSetting1)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU2", selectedRollerSetting2)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU3", selectedRollerSetting3)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU4", selectedRollerSetting4)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU5", selectedRollerSetting5)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU6", selectedRollerSetting6)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU7", selectedRollerSetting7)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU1", TXT_RollerSeparationPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU2", TXT_RollerSeparationPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU3", TXT_RollerSeparationPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU4", TXT_RollerSeparationPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU5", TXT_RollerSeparationPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU6", TXT_RollerSeparationPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU7", TXT_RollerSeparationPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU1", TXT_ImpPressurePU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU2", TXT_ImpPressurePU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU3", TXT_ImpPressurePU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU4", TXT_ImpPressurePU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU5", TXT_ImpPressurePU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU6", TXT_ImpPressurePU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU7", TXT_ImpPressurePU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU1", TXT_MachineInkDensityPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU2", TXT_MachineInkDensityPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU3", TXT_MachineInkDensityPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU4", TXT_MachineInkDensityPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU5", TXT_MachineInkDensityPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU6", TXT_MachineInkDensityPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU7", TXT_MachineInkDensityPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU1", TXT_MachineInterdeckPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU2", TXT_MachineInterdeckPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU3", TXT_MachineInterdeckPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU4", TXT_MachineInterdeckPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU5", TXT_MachineInterdeckPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU6", TXT_MachineInterdeckPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU7", TXT_MachineInterdeckPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1Varnish", TXT_CoatingUnit1Varnish.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry1", TXT_CoatingUnit1HotAirDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry2", TXT_CoatingUnit1HotAirDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry3", TXT_CoatingUnit1HotAirDryer3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry4", TXT_CoatingUnit1HotAirDryer4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry1", TXT_CoatingUnit1InfraRedDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry2", TXT_CoatingUnit1InfraRedDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraAnilox", TXT_CoatingUnit1Anilox.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2Varnish", TXT_CoatingUnit2Varnish.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry1", TXT_CoatingUnit2HotAirDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry2", TXT_CoatingUnit2HotAirDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry3", TXT_CoatingUnit2HotAirDryer3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry4", TXT_CoatingUnit2HotAirDryer4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry1", TXT_CoatingUnit2InfraRedDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry2", TXT_CoatingUnit2InfraRedDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraAnilox", TXT_CoatingUnit2Anilox.Text)
                cmd.Parameters.AddWithValue("@mspa_OFEndPress1", TXT_MachineEndOfPress1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFEndPress2", TXT_MachineEndOfPress2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFEndPress3", TXT_MachineEndOfPress3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrType", TXT_MachineSprayType.Text)
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrSet", TXT_MachineSpraySetting.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkUntTemp", TXT_MachineInkingUnitTemp.Text)
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

                cmd.Parameters.AddWithValue("@mspa_OFColdAir", ColdAirDecimal)
                cmd.Parameters.AddWithValue("@mspa_OFSFacfybar", MachineACFYellowBar)
                cmd.Parameters.AddWithValue("@mspa_OFSFsecmatrix", MachineSecurityMatrix)
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlock", MachinePowerlock)
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlockval", TXT_MachinePowerlock.Text)

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

                cmd.Parameters.AddWithValue("@mspa_OFSGOperator", MachineOperator)
                cmd.Parameters.AddWithValue("@mspa_OFSGDrive", MachineDrive)
                cmd.Parameters.AddWithValue("@mspa_OFSGRollGuide", MachineRollerGuide)
                cmd.Parameters.AddWithValue("@mspa_OFSGA1", MachineCheck1)
                cmd.Parameters.AddWithValue("@mspa_OFSGA2", MachineCheck2)
                cmd.Parameters.AddWithValue("@mspa_OFSGA3", MachineCheck3)
                cmd.Parameters.AddWithValue("@mspa_OFSGA4", MachineCheck4)
                cmd.Parameters.AddWithValue("@mspa_OFSGA5", MachineCheck5)
                cmd.Parameters.AddWithValue("@mspa_OFDFMechanic", MachineMechanical)
                cmd.Parameters.AddWithValue("@mspa_OFDFUltrasonic", MachineUltrasonic)
                cmd.Parameters.AddWithValue("@mspa_OFUABBE", UnvarnishBBE)
                cmd.Parameters.AddWithValue("@mspa_OFUAFlap", UnvarnishFlap)
                cmd.Parameters.AddWithValue("@mspa_OFUAGluelap", GlueLap)
                cmd.Parameters.AddWithValue("@mspa_OFGDShort", MachineGrainShort)
                cmd.Parameters.AddWithValue("@mspa_OFGDLong", MachineGrainLong)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU1", TXT_ColorPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU2", TXT_ColorPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU3", TXT_ColorPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU4", TXT_ColorPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU5", TXT_ColorPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU6", TXT_ColorPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFColorPU7", TXT_ColorPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU1", selectedRollerSetting1)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU2", selectedRollerSetting2)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU3", selectedRollerSetting3)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU4", selectedRollerSetting4)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU5", selectedRollerSetting5)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU6", selectedRollerSetting6)
                cmd.Parameters.AddWithValue("@mspa_OFRollStPU7", selectedRollerSetting7)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU1", TXT_RollerSeparationPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU2", TXT_RollerSeparationPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU3", TXT_RollerSeparationPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU4", TXT_RollerSeparationPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU5", TXT_RollerSeparationPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU6", TXT_RollerSeparationPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFRollSepPU7", TXT_RollerSeparationPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU1", TXT_ImpPressurePU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU2", TXT_ImpPressurePU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU3", TXT_ImpPressurePU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU4", TXT_ImpPressurePU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU5", TXT_ImpPressurePU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU6", TXT_ImpPressurePU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFImPrePU7", TXT_ImpPressurePU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU1", TXT_MachineInkDensityPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU2", TXT_MachineInkDensityPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU3", TXT_MachineInkDensityPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU4", TXT_MachineInkDensityPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU5", TXT_MachineInkDensityPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU6", TXT_MachineInkDensityPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkDenPU7", TXT_MachineInkDensityPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU1", TXT_MachineInterdeckPU1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU2", TXT_MachineInterdeckPU2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU3", TXT_MachineInterdeckPU3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU4", TXT_MachineInterdeckPU4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU5", TXT_MachineInterdeckPU5.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU6", TXT_MachineInterdeckPU6.Text)
                cmd.Parameters.AddWithValue("@mspa_OFIntdeckPU7", TXT_MachineInterdeckPU7.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1Varnish", TXT_CoatingUnit1Varnish.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry1", TXT_CoatingUnit1HotAirDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry2", TXT_CoatingUnit1HotAirDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry3", TXT_CoatingUnit1HotAirDryer3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1HotDry4", TXT_CoatingUnit1HotAirDryer4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry1", TXT_CoatingUnit1InfraRedDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraDry2", TXT_CoatingUnit1InfraRedDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU1InfraAnilox", TXT_CoatingUnit1Anilox.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2Varnish", TXT_CoatingUnit2Varnish.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry1", TXT_CoatingUnit2HotAirDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry2", TXT_CoatingUnit2HotAirDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry3", TXT_CoatingUnit2HotAirDryer3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2HotDry4", TXT_CoatingUnit2HotAirDryer4.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry1", TXT_CoatingUnit2InfraRedDryer1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraDry2", TXT_CoatingUnit2InfraRedDryer2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFCU2InfraAnilox", TXT_CoatingUnit2Anilox.Text)
                cmd.Parameters.AddWithValue("@mspa_OFEndPress1", TXT_MachineEndOfPress1.Text)
                cmd.Parameters.AddWithValue("@mspa_OFEndPress2", TXT_MachineEndOfPress2.Text)
                cmd.Parameters.AddWithValue("@mspa_OFEndPress3", TXT_MachineEndOfPress3.Text)
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrType", TXT_MachineSprayType.Text)
                cmd.Parameters.AddWithValue("@mspa_OFSprPowdrSet", TXT_MachineSpraySetting.Text)
                cmd.Parameters.AddWithValue("@mspa_OFInkUntTemp", TXT_MachineInkingUnitTemp.Text)
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

                cmd.Parameters.AddWithValue("@mspa_OFColdAir", ColdAirDecimal)
                cmd.Parameters.AddWithValue("@mspa_OFSFacfybar", MachineACFYellowBar)
                cmd.Parameters.AddWithValue("@mspa_OFSFsecmatrix", MachineSecurityMatrix)
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlock", MachinePowerlock)
                cmd.Parameters.AddWithValue("@mspa_OFSFpwrlockval", TXT_MachinePowerlock.Text)

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
                cmd.Parameters.AddWithValue("@stripknife", TXT_StrippingBladeQty1.Text)
                cmd.Parameters.AddWithValue("@stripknifebld", TXT_StrippingBladeQty2.Text)
                cmd.Parameters.AddWithValue("@markerqty", "")
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
                cmd.Parameters.AddWithValue("@stripknife", TXT_StrippingBladeQty1.Text)
                cmd.Parameters.AddWithValue("@stripknifebld", TXT_StrippingBladeQty2.Text)
                cmd.Parameters.AddWithValue("@markerqty", "")
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

        Dim UC_SupervisorOff As New UC_SupervisorOffset
        UC_SupervisorOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorOff.Show()
        UC_SupervisorOff.Dock = DockStyle.Fill


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

    Private Sub load_AssOperator2()


        Dim cmd_select_helper As New SqlCommand("SELECT Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Operator' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_AsstOperator2.Items.Add(read_cmd_select_helper("Emp_num_helper"))
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

    Private Sub load_AssOperator_empnum2()



        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Operator' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_AsstOperator2.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_AsstOperator2.Items.Add(helper_empname)
                TXT_AsstOperator2.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_AsstOperator2.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
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
    Private Sub load_helper2()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name as Emp_num_helper FROM Employee WHERE Position = 'Helper' ORDER BY NAME", con)

        Try
            con.Open()
            Dim read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader
            While read_cmd_select_helper.Read
                CBO_Helper2.Items.Add(read_cmd_select_helper("Emp_num_helper").ToString)
            End While
            read_cmd_select_helper.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub load_helper_empnum2()

        Dim cmd_select_helper_empnum As New SqlCommand("
        SELECT 
            Name, 
            Emp_num, 
            Emp_num + ' - ' + Name AS Emp_num_helper 
        FROM Employee 
        WHERE Position = 'Helper' 
        AND (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_Helper2.Text)

        Try
            con.Open()

            ' Use the Using block to ensure the SqlDataReader is disposed of correctly
            Using read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader()
                If read_cmd_select_helper_empnum.Read() Then
                    Dim helper_empname As String = read_cmd_select_helper_empnum("Name").ToString()
                    CBO_Helper2.Items.Clear() ' Optional: Clear previous items if needed
                    CBO_Helper2.Items.Add(helper_empname)
                    TXT_Helper2.Text = read_cmd_select_helper_empnum("Emp_num").ToString()
                    CBO_Helper2.Text = read_cmd_select_helper_empnum("Name").ToString()
                End If
            End Using

        Catch ex As Exception
            ' Handle the exception (optional MsgBox or logging)
            MsgBox(ex.Message)
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

        'cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_Helper2.Text)

        'Try
        '    con.Open()
        '    Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
        '    If read_cmd_select_helper_empnum.Read Then
        '        Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
        '        CBO_Helper2.Items.Add(helper_empname)
        '        TXT_Helper2.Text = read_cmd_select_helper_empnum("Emp_num")
        '        CBO_Helper2.Text = read_cmd_select_helper_empnum("Name").ToString
        '        'MsgBox(read_cmd_select_helper_empnum("Name"))   
        '    End If
        '    read_cmd_select_helper_empnum.Close()
        'Catch ex As Exception
        'Finally
        '    con.Close()
        'End Try
    End Sub


    Private Sub CHK_SelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged

        If CHK_SelectAll.Checked = True Then
            SelectAllEnableCheck()
        Else
            SelectAllDisabledCheck()
        End If
    End Sub

    Private Sub CBO_Helper1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged
        con.Close()
        load_helper_empnum1()
    End Sub

    Private Sub CBO_Helper1_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper1.DropDown
        CBO_Helper1.Items.Clear()
        load_helper1()
    End Sub

    Private Sub CBO_Helper2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper2.SelectedIndexChanged
        con.Close()
        load_helper_empnum2()


    End Sub



    Private Sub CBO_Helper2_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper2.DropDown
        CBO_Helper2.Items.Clear()
        load_helper2()
    End Sub

    Private Sub CBO_AsstOperator1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.SelectedIndexChanged
        con.Close()
        load_AssOperator_empnum1()

    End Sub

    Private Sub CBO_AsstOperator1_DropDown(sender As Object, e As EventArgs) Handles CBO_AsstOperator1.DropDown
        CBO_AsstOperator1.Items.Clear()
        load_AssOperator1()
    End Sub

    Private Sub CBO_AsstOperator2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_AsstOperator2.SelectedIndexChanged
        con.Close()
        load_AssOperator_empnum2()
    End Sub

    Private Sub CBO_AsstOperator2_DropDown(sender As Object, e As EventArgs) Handles CBO_AsstOperator2.DropDown
        CBO_AsstOperator2.Items.Clear()
        load_AssOperator2()
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



    Private Sub TXT_FullBallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullBallpenQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_FullRagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullRagsQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_FullStrippingKnifeQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullStrippingKnifeQty1.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub BTN_Back_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTN_Back.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_FullMarterQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullMarterQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_7BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7BallpenQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_7RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7RagsQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_StrippingBladeQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingBladeQty1.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_StrippingBladeQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingBladeQty2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_MachineColdAit100_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineColdAit100.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_FullStrippingKnifeQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_FullStrippingKnifeQty2.TextChanged

    End Sub

    Private Sub TXT_FullStrippingKnifeQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullStrippingKnifeQty2.KeyPress
        NumberOnly(e)
    End Sub


End Class
