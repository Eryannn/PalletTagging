Imports System.Data.SqlClient

Public Class UC_SupervisorFinishing
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SelectAllEnableCheck()
        CHK_WP.Checked = True
        CHK_FinishedGoods.Checked = True
        CHK_ManualFinising.Checked = True

        'CHK_Gluing.Checked = True
        'CHK_Ambition50.Checked = True
        'CHK_Media68.Checked = True
        'CHK_Expertfold80.Checked = True
        'CHK_Mouse650.Checked = True
        'CHK_Sun1300.Checked = True
        'CHK_Sun850.Checked = True
        'CHK_Expertfold110.Checked = True
        'CHK_LaminaA.Checked = True
        'CHK_LaminaB.Checked = True

        'CHK_Stripping.Checked = True
        'CHK_StrippingA.Checked = True
        'CHK_StrippingB.Checked = True
        'CHK_StrippingC.Checked = True
        'CHK_StrippingD.Checked = True
        'CHK_StrippingE.Checked = True
        CHK_Resorting.Checked = True

        CHK_FullWasteBinss.Checked = True
        CHK_FullChairs.Checked = True
        CHK_FullWorkingTable.Checked = True
        CHK_FullSticker.Checked = True
        CHK_FullKraftPaper.Checked = True
        CHK_FullCorrugatedBox.Checked = True
        CHK_FullCutLabel.Checked = True
        CHK_FullPalletTag.Checked = True

        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodForeignMaterials.Checked = True
        CHK_GoodJSortingTable.Checked = True
        CHK_GoodBundlingMachine.Checked = True
        CHK_GoodWeighingScale.Checked = True
        CHK_GoodProperlyTagged.Checked = True
        CHk_GoodInPlasticPallets.Checked = True
        CHK_GoodWith20WallClearance.Checked = True
        CHK_GoodWearHairCover.Checked = True
        CHk_GoodWearsProperlyTuckedIn.Checked = True
        CHk_GoodHandWashed.Checked = True
        CHK_GoodCleaingMaterials.Checked = True
        CHK_GoodEquipments.Checked = True

    End Sub

    Private Sub SelectAllDisabledCheck()
        CHK_WP.Checked = False
        CHK_FinishedGoods.Checked = False
        CHK_ManualFinising.Checked = False

        'CHK_Gluing.Checked = False
        'CHK_Ambition50.Checked = False
        'CHK_Media68.Checked = False
        'CHK_Expertfold80.Checked = False
        'CHK_Mouse650.Checked = False
        'CHK_Sun1300.Checked = False
        'CHK_Sun850.Checked = False
        'CHK_Expertfold110.Checked = False
        'CHK_LaminaA.Checked = False
        'CHK_LaminaB.Checked = False

        'CHK_Stripping.Checked = False
        'CHK_StrippingA.Checked = False
        'CHK_StrippingB.Checked = False
        'CHK_StrippingC.Checked = False
        'CHK_StrippingD.Checked = False
        'CHK_StrippingE.Checked = False
        CHK_Resorting.Checked = False

        CHK_FullWasteBinss.Checked = False
        CHK_FullChairs.Checked = False
        CHK_FullWorkingTable.Checked = False
        CHK_FullSticker.Checked = False
        CHK_FullKraftPaper.Checked = False
        CHK_FullCorrugatedBox.Checked = False
        CHK_FullCutLabel.Checked = False
        CHK_FullPalletTag.Checked = False

        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodForeignMaterials.Checked = False
        CHK_GoodJSortingTable.Checked = False
        CHK_GoodBundlingMachine.Checked = False
        CHK_GoodWeighingScale.Checked = False
        CHK_GoodProperlyTagged.Checked = False
        CHk_GoodInPlasticPallets.Checked = False
        CHK_GoodWith20WallClearance.Checked = False
        CHK_GoodWearHairCover.Checked = False
        CHk_GoodWearsProperlyTuckedIn.Checked = False
        CHk_GoodHandWashed.Checked = False
        CHK_GoodCleaingMaterials.Checked = False
        CHK_GoodEquipments.Checked = False


    End Sub

    Private Sub EnabledSupervisorForm()

        CHK_SelectAll.Enabled = True

        CHK_WP.Enabled = True
        TXT_FullWP.Enabled = True
        CHK_ManualFinising.Enabled = True
        RBT_ManualFinishing.Enabled = True
        CHK_Gluing.Enabled = True
        CHK_Ambition50.Enabled = True
        CHK_Media68.Enabled = True
        CHK_Expertfold80.Enabled = True
        CHK_Mouse650.Enabled = True
        CHK_Sun1300.Enabled = True
        CHK_Sun850.Enabled = True
        CHK_Expertfold110.Enabled = True
        CHK_LaminaA.Enabled = True
        CHK_LaminaB.Enabled = True
        CHK_Stripping.Enabled = True
        CHK_StrippingA.Enabled = True
        CHK_StrippingB.Enabled = True
        CHK_StrippingC.Enabled = True
        CHK_StrippingD.Enabled = True
        CHK_StrippingE.Enabled = True
        CHK_Resorting.Enabled = True
        TXT_Nonconformity.Enabled = True
        TXT_NCR.Enabled = True
        TXT_QNR.Enabled = True

        CHK_FullWasteBinss.Enabled = True
        CHK_FullChairs.Enabled = True
        CHK_FullWorkingTable.Enabled = True
        CHK_FullSticker.Enabled = True
        CHK_FullKraftPaper.Enabled = True
        CHK_FullCorrugatedBox.Enabled = True
        CHK_FullCutLabel.Enabled = True
        CHK_FullPalletTag.Enabled = True
        TXT_FullBallpenQty.Enabled = True
        TXT_FullRagsQty.Enabled = True
        TXT_FullGlueBottle.Enabled = True
        TXT_FullOtherSpecify.Enabled = True
        TXT_FullQtyStartPC.Enabled = True


        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True
        CHK_GoodJSortingTable.Enabled = True
        CHK_GoodBundlingMachine.Enabled = True
        CHK_GoodWeighingScale.Enabled = True
        CHK_GoodProperlyTagged.Enabled = True
        CHk_GoodInPlasticPallets.Enabled = True
        CHK_GoodWith20WallClearance.Enabled = True
        CHK_GoodWearHairCover.Enabled = True
        CHk_GoodWearsProperlyTuckedIn.Enabled = True
        CHk_GoodHandWashed.Enabled = True
        CHK_GoodCleaingMaterials.Enabled = True
        CHK_GoodEquipments.Enabled = True

        '3
        RTB_JobInstruction.Enabled = True
        RTB_JobPackingInstraction.Enabled = True
        TXT_JobStickerQuantity.Enabled = True
        TXT_JobCutOutLabelQty.Enabled = True
        TXT_JobQtyPerPack.Enabled = True

        CBO_JobLineLeader.Enabled = True
        CBO_JobFeeder.Enabled = True
        CBO_JobPicker.Enabled = True
        CBO_JobPicker1.Enabled = True
        CBO_JobPicker2.Enabled = True
        CBO_JobPicker3.Enabled = True
        CBO_JobSorter1.Enabled = True
        CBO_JobSorter2.Enabled = True
        CBO_JobSorter3.Enabled = True
        CBO_JobSorter4.Enabled = True
        CBO_JobSorter5.Enabled = True
        CBO_JobSorter6.Enabled = True
        CBO_JobSorter7.Enabled = True
        CBO_JobSorter8.Enabled = True
        CBO_JobSorter9.Enabled = True
        CBO_JobSorter10.Enabled = True
        CBO_JobSorter11.Enabled = True

        TXT_JobLineLeader.Enabled = True
        TXT_JobFeeder.Enabled = True
        TXT_JobPicker.Enabled = True
        TXT_JobPacker1.Enabled = True
        TXT_JobPacker2.Enabled = True
        TXT_JobPacker3.Enabled = True
        TXT_JobSorter1.Enabled = True
        TXT_JobSorter2.Enabled = True
        TXT_JobSorter3.Enabled = True
        TXT_JobSorter4.Enabled = True
        TXT_JobSorter5.Enabled = True
        TXT_JobSorter6.Enabled = True
        TXT_JobSorter7.Enabled = True
        TXT_JobSorter8.Enabled = True
        TXT_JobSorter9.Enabled = True
        TXT_JobSorter10.Enabled = True
        TXT_JobSorter11.Enabled = True

        DTP_JobLineLeaderStart.Enabled = True
        DTP_JobFeederStart.Enabled = True
        DTP_JobPickerStart.Enabled = True
        DTP_JobPacker1Start.Enabled = True
        DTP_JobPacker2Start.Enabled = True
        DTP_JobPacker3Start.Enabled = True

        DTP_JobSorter1Start.Enabled = True
        DTP_JobSorter2Start.Enabled = True
        DTP_JobSorter3Start.Enabled = True
        DTP_JobSorter4Start.Enabled = True
        DTP_JobSorter5Start.Enabled = True
        DTP_JobSorter6Start.Enabled = True
        DTP_JobSorter7Start.Enabled = True
        DTP_JobSorter8Start.Enabled = True
        DTP_JobSorter9Start.Enabled = True
        DTP_JobSorter10Start.Enabled = True
        DTP_JobSorter11Start.Enabled = True

        DTP_JobSorter1End.Enabled = True
        DTP_JobSorter2End.Enabled = True
        DTP_JobSorter3End.Enabled = True
        DTP_JobSorter4End.Enabled = True
        DTP_JobSorter5End.Enabled = True
        DTP_JobSorter6End.Enabled = True
        DTP_JobSorter7End.Enabled = True
        DTP_JobSorter8End.Enabled = True
        DTP_JobSorter9End.Enabled = True
        DTP_JobSorter10End.Enabled = True
        DTP_JobSorter11End.Enabled = True

        DTP_JobLineLeaderEnd.Enabled = True
        DTP_JobFeederEnd.Enabled = True
        DTP_JobPickerEnd.Enabled = True
        DTP_JobPacker1End.Enabled = True
        DTP_JobPacker2End.Enabled = True
        DTP_JobPacker3End.Enabled = True

        '4
        TXT_ProductOffColorQty.Enabled = True
        TXT_ProductSpotQty.Enabled = True
        TXT_ProductScumQty.Enabled = True
        TXT_ProductMissingPrintQty.Enabled = True
        TXT_ProductSetOffQty.Enabled = True
        TXT_ProductMisregistrationQty.Enabled = True
        TXT_ProductRapturedScoring.Enabled = True
        TXT_ProductMisalignedGluing.Enabled = True
        TXT_ProductExcessGluingSlicking.Enabled = True
        TXT_NonConformity1.Enabled = True
        TXT_NonConformity2.Enabled = True
        TXT_NonConformity3.Enabled = True
        TXT_NonConformity1QTY.Enabled = True
        TXT_NonConformity2QTY.Enabled = True
        TXT_NonConformity3QTY.Enabled = True

        TXT_7BallpenQty.Enabled = True
        TXT_RagsQuantityPC.Enabled = True
        TXT_7GlueBottlerQty.Enabled = True
        TXT_OthersSpecify.Enabled = True
        TXT_7DesOthersSpecify.Enabled = True



    End Sub
    Private Sub DisabledSupervisorForm()
        CHK_SelectAll.Enabled = False

        CHK_WP.Enabled = False
        TXT_FullWP.Enabled = False
        CHK_ManualFinising.Enabled = False
        RBT_ManualFinishing.Enabled = False
        CHK_Gluing.Enabled = False
        CHK_Ambition50.Enabled = False
        CHK_Media68.Enabled = False
        CHK_Expertfold80.Enabled = False
        CHK_Mouse650.Enabled = False
        CHK_Sun1300.Enabled = False
        CHK_Sun850.Enabled = False
        CHK_Expertfold110.Enabled = False
        CHK_LaminaA.Enabled = False
        CHK_LaminaB.Enabled = False
        CHK_Stripping.Enabled = False
        CHK_StrippingA.Enabled = False
        CHK_StrippingB.Enabled = False
        CHK_StrippingC.Enabled = False
        CHK_StrippingD.Enabled = False
        CHK_StrippingE.Enabled = False
        CHK_Resorting.Enabled = False
        TXT_Nonconformity.Enabled = False
        TXT_NCR.Enabled = False
        TXT_QNR.Enabled = False

        CHK_FullWasteBinss.Enabled = False
        CHK_FullChairs.Enabled = False
        CHK_FullWorkingTable.Enabled = False
        CHK_FullSticker.Enabled = False
        CHK_FullKraftPaper.Enabled = False
        CHK_FullCorrugatedBox.Enabled = False
        CHK_FullCutLabel.Enabled = False
        CHK_FullPalletTag.Enabled = False
        TXT_FullBallpenQty.Enabled = False
        TXT_FullRagsQty.Enabled = False
        TXT_FullGlueBottle.Enabled = False
        TXT_FullOtherSpecify.Enabled = False
        TXT_FullQtyStartPC.Enabled = False

        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False
        CHK_GoodJSortingTable.Enabled = False
        CHK_GoodBundlingMachine.Enabled = False
        CHK_GoodWeighingScale.Enabled = False
        CHK_GoodProperlyTagged.Enabled = False
        CHk_GoodInPlasticPallets.Enabled = False
        CHK_GoodWith20WallClearance.Enabled = False
        CHK_GoodWearHairCover.Enabled = False
        CHk_GoodWearsProperlyTuckedIn.Enabled = False
        CHk_GoodHandWashed.Enabled = False
        CHK_GoodCleaingMaterials.Enabled = False
        CHK_GoodEquipments.Enabled = False

        '3
        RTB_JobInstruction.Enabled = False
        RTB_JobPackingInstraction.Enabled = False
        TXT_JobStickerQuantity.Enabled = False
        TXT_JobCutOutLabelQty.Enabled = False
        TXT_JobQtyPerPack.Enabled = False

        CBO_JobLineLeader.Enabled = False
        CBO_JobFeeder.Enabled = False
        CBO_JobPicker.Enabled = False
        CBO_JobPicker1.Enabled = False
        CBO_JobPicker2.Enabled = False
        CBO_JobPicker3.Enabled = False
        CBO_JobSorter1.Enabled = False
        CBO_JobSorter2.Enabled = False
        CBO_JobSorter3.Enabled = False
        CBO_JobSorter4.Enabled = False
        CBO_JobSorter5.Enabled = False
        CBO_JobSorter6.Enabled = False
        CBO_JobSorter7.Enabled = False
        CBO_JobSorter8.Enabled = False
        CBO_JobSorter9.Enabled = False
        CBO_JobSorter10.Enabled = False
        CBO_JobSorter11.Enabled = False

        TXT_JobLineLeader.Enabled = False
        TXT_JobFeeder.Enabled = False
        TXT_JobPicker.Enabled = False
        TXT_JobPacker1.Enabled = False
        TXT_JobPacker2.Enabled = False
        TXT_JobPacker3.Enabled = False
        TXT_JobSorter1.Enabled = False
        TXT_JobSorter2.Enabled = False
        TXT_JobSorter3.Enabled = False
        TXT_JobSorter4.Enabled = False
        TXT_JobSorter5.Enabled = False
        TXT_JobSorter6.Enabled = False
        TXT_JobSorter7.Enabled = False
        TXT_JobSorter8.Enabled = False
        TXT_JobSorter9.Enabled = False
        TXT_JobSorter10.Enabled = False
        TXT_JobSorter11.Enabled = False

        DTP_JobLineLeaderStart.Enabled = False
        DTP_JobFeederStart.Enabled = False
        DTP_JobPickerStart.Enabled = False
        DTP_JobPacker1Start.Enabled = False
        DTP_JobPacker2Start.Enabled = False
        DTP_JobPacker3Start.Enabled = False

        DTP_JobSorter1Start.Enabled = False
        DTP_JobSorter2Start.Enabled = False
        DTP_JobSorter3Start.Enabled = False
        DTP_JobSorter4Start.Enabled = False
        DTP_JobSorter5Start.Enabled = False
        DTP_JobSorter6Start.Enabled = False
        DTP_JobSorter7Start.Enabled = False
        DTP_JobSorter8Start.Enabled = False
        DTP_JobSorter9Start.Enabled = False
        DTP_JobSorter10Start.Enabled = False
        DTP_JobSorter11Start.Enabled = False

        DTP_JobSorter1End.Enabled = False
        DTP_JobSorter2End.Enabled = False
        DTP_JobSorter3End.Enabled = False
        DTP_JobSorter4End.Enabled = False
        DTP_JobSorter5End.Enabled = False
        DTP_JobSorter6End.Enabled = False
        DTP_JobSorter7End.Enabled = False
        DTP_JobSorter8End.Enabled = False
        DTP_JobSorter9End.Enabled = False
        DTP_JobSorter10End.Enabled = False
        DTP_JobSorter11End.Enabled = False





        '4
        TXT_ProductOffColorQty.Enabled = False
        TXT_ProductSpotQty.Enabled = False
        TXT_ProductScumQty.Enabled = False
        TXT_ProductMissingPrintQty.Enabled = False
        TXT_ProductSetOffQty.Enabled = False
        TXT_ProductMisregistrationQty.Enabled = False
        TXT_ProductRapturedScoring.Enabled = False
        TXT_ProductMisalignedGluing.Enabled = False
        TXT_ProductExcessGluingSlicking.Enabled = False
        TXT_NonConformity1.Enabled = False
        TXT_NonConformity2.Enabled = False
        TXT_NonConformity3.Enabled = False
        TXT_NonConformity1QTY.Enabled = False
        TXT_NonConformity2QTY.Enabled = False
        TXT_NonConformity3QTY.Enabled = False


    End Sub
    Private Sub UC_SupervisorFinishing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_JobLineLeaderStart.Format = DateTimePickerFormat.Custom
        DTP_JobLineLeaderStart.CustomFormat = "hh:mm tt"


        DTP_JobLineLeaderEnd.Format = DateTimePickerFormat.Custom
        DTP_JobLineLeaderEnd.CustomFormat = "hh:mm tt"

        DTP_JobFeederStart.Format = DateTimePickerFormat.Custom
        DTP_JobFeederStart.CustomFormat = "hh:mm tt"

        DTP_JobFeederEnd.Format = DateTimePickerFormat.Custom
        DTP_JobFeederEnd.CustomFormat = "hh:mm tt"

        DTP_JobPickerStart.Format = DateTimePickerFormat.Custom
        DTP_JobPickerStart.CustomFormat = "hh:mm tt"

        DTP_JobPickerEnd.Format = DateTimePickerFormat.Custom
        DTP_JobPickerEnd.CustomFormat = "hh:mm tt"

        DTP_JobPacker1Start.Format = DateTimePickerFormat.Custom
        DTP_JobPacker1Start.CustomFormat = "hh:mm tt"

        DTP_JobPacker1End.Format = DateTimePickerFormat.Custom
        DTP_JobPacker1End.CustomFormat = "hh:mm tt"

        DTP_JobPacker2Start.Format = DateTimePickerFormat.Custom
        DTP_JobPacker2Start.CustomFormat = "hh:mm tt"

        DTP_JobPacker2End.Format = DateTimePickerFormat.Custom
        DTP_JobPacker2End.CustomFormat = "hh:mm tt"

        DTP_JobPacker3Start.Format = DateTimePickerFormat.Custom
        DTP_JobPacker3Start.CustomFormat = "hh:mm tt"

        DTP_JobPacker3End.Format = DateTimePickerFormat.Custom
        DTP_JobPacker3End.CustomFormat = "hh:mm tt"


        DTP_JobSorter1Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter1Start.CustomFormat = "hh:mm tt"


        DTP_JobSorter1End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter1End.CustomFormat = "hh:mm tt"

        DTP_JobSorter2Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter2Start.CustomFormat = "hh:mm tt"


        DTP_JobSorter2End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter2End.CustomFormat = "hh:mm tt"


        DTP_JobSorter3Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter3Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter3End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter3End.CustomFormat = "hh:mm tt"

        DTP_JobSorter4Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter4Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter4End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter4End.CustomFormat = "hh:mm tt"

        DTP_JobSorter5Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter5Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter5End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter5End.CustomFormat = "hh:mm tt"

        DTP_JobSorter6Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter6Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter6End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter6End.CustomFormat = "hh:mm tt"

        DTP_JobSorter7Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter7Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter7End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter7End.CustomFormat = "hh:mm tt"

        DTP_JobSorter8Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter8Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter8End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter8End.CustomFormat = "hh:mm tt"

        DTP_JobSorter9Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter9Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter9End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter9End.CustomFormat = "hh:mm tt"

        DTP_JobSorter10Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter10Start.CustomFormat = "hh:mm tt"

        DTP_JobSorter10End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter10End.CustomFormat = "hh:mm tt"


        DTP_JobSorter11Start.Format = DateTimePickerFormat.Custom
        DTP_JobSorter11Start.CustomFormat = "hh:mm tt"


        DTP_JobSorter11End.Format = DateTimePickerFormat.Custom
        DTP_JobSorter11End.CustomFormat = "hh:mm tt"


        DTP_JobLineLeaderStart.Text = "12:00 AM"
        DTP_JobFeederStart.Text = "12:00 AM"
        DTP_JobPickerStart.Text = "12:00 AM"


        DTP_JobPacker1Start.Text = "12:00 AM"
        DTP_JobPacker2Start.Text = "12:00 AM"
        DTP_JobPacker3Start.Text = "12:00 AM"


        DTP_JobSorter1Start.Text = "12:00 AM"
        DTP_JobSorter2Start.Text = "12:00 AM"
        DTP_JobSorter3Start.Text = "12:00 AM"
        DTP_JobSorter4Start.Text = "12:00 AM"
        DTP_JobSorter5Start.Text = "12:00 AM"
        DTP_JobSorter6Start.Text = "12:00 AM"
        DTP_JobSorter7Start.Text = "12:00 AM"
        DTP_JobSorter8Start.Text = "12:00 AM"
        DTP_JobSorter9Start.Text = "12:00 AM"
        DTP_JobSorter10Start.Text = "12:00 AM"
        DTP_JobSorter11Start.Text = "12:00 AM"

        DTP_JobLineLeaderEnd.Text = "12:00 AM"
        DTP_JobFeederEnd.Text = "12:00 AM"
        DTP_JobPickerEnd.Text = "12:00 AM"

        DTP_JobPacker1End.Text = "12:00 AM"
        DTP_JobPacker2End.Text = "12:00 AM"
        DTP_JobPacker3End.Text = "12:00 AM"

        DTP_JobSorter1End.Text = "12:00 AM"
        DTP_JobSorter2End.Text = "12:00 AM"
        DTP_JobSorter3End.Text = "12:00 AM"
        DTP_JobSorter4End.Text = "12:00 AM"
        DTP_JobSorter5End.Text = "12:00 AM"
        DTP_JobSorter6End.Text = "12:00 AM"
        DTP_JobSorter7End.Text = "12:00 AM"
        DTP_JobSorter8End.Text = "12:00 AM"
        DTP_JobSorter9End.Text = "12:00 AM"
        DTP_JobSorter10End.Text = "12:00 AM"
        DTP_JobSorter11End.Text = "12:00 AM"



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
            cmd.CommandText = "Select_sppmcHdrAnother"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    If dr("sppmc_FIwip").ToString() = "O" Then
                        CHK_WP.Checked = True
                    Else
                        CHK_WP.Checked = False

                    End If
                    TXT_FullWP.Text = dr("sppmc_FIwipval").ToString()




                    If dr("sppmc_FIfingoods").ToString() = "O" Then
                        CHK_FinishedGoods.Checked = True
                    Else
                        CHK_FinishedGoods.Checked = False

                    End If





                    If dr("sppmc_FIManFin").ToString() = "O" Then
                        CHK_ManualFinising.Checked = True
                    Else
                        CHK_ManualFinising.Checked = False
                    End If

                    RBT_ManualFinishing.Text = dr("sppmc_FIManFinNote").ToString()




                    If dr("sppmc_FIGluing").ToString() = "O" Then
                        CHK_Gluing.Checked = True
                    Else
                        CHK_Gluing.Checked = False
                    End If



                    If dr("sppmc_FIAmb50").ToString() = "O" Then
                        CHK_Ambition50.Checked = True
                    Else
                        CHK_Ambition50.Checked = False
                    End If


                    If dr("sppmc_FIMedia68").ToString() = "O" Then
                        CHK_Media68.Checked = True
                    Else
                        CHK_Media68.Checked = False
                    End If

                    If dr("sppmc_FIExptfld80").ToString() = "O" Then
                        CHK_Expertfold80.Checked = True
                    Else
                        CHK_Expertfold80.Checked = False
                    End If

                    If dr("sppmc_FISun650").ToString() = "O" Then
                        CHK_Mouse650.Checked = True
                    Else
                        CHK_Mouse650.Checked = False
                    End If


                    If dr("sppmc_FISun1300").ToString() = "O" Then
                        CHK_Sun1300.Checked = True
                    Else
                        CHK_Sun1300.Checked = False
                    End If






                    If dr("sppmc_FISun850").ToString() = "O" Then
                        CHK_Sun850.Checked = True
                    Else
                        CHK_Sun850.Checked = False
                    End If






                    If dr("sppmc_FIExptfld110").ToString() = "O" Then
                        CHK_Expertfold110.Checked = True
                    Else
                        CHK_Expertfold110.Checked = False
                    End If






                    If dr("sppmc_FILaminaA").ToString() = "O" Then
                        CHK_LaminaA.Checked = True
                    Else
                        CHK_LaminaA.Checked = False
                    End If



                    If dr("sppmc_FILaminaB").ToString() = "O" Then
                        CHK_LaminaB.Checked = True
                    Else
                        CHK_LaminaB.Checked = False
                    End If



                    If dr("sppmc_FIStrpng").ToString() = "O" Then
                        CHK_Stripping.Checked = True
                    Else
                        CHK_Stripping.Checked = False
                    End If


                    If dr("sppmc_FIStrpngA").ToString() = "O" Then
                        CHK_StrippingA.Checked = True
                    Else
                        CHK_StrippingA.Checked = False
                    End If


                    If dr("sppmc_FIStrpngB").ToString() = "O" Then
                        CHK_StrippingB.Checked = True
                    Else
                        CHK_StrippingB.Checked = False
                    End If


                    If dr("sppmc_FIStrpngC").ToString() = "O" Then
                        CHK_StrippingC.Checked = True
                    Else
                        CHK_StrippingC.Checked = False
                    End If


                    If dr("sppmc_FIStrpngD").ToString() = "O" Then
                        CHK_StrippingD.Checked = True
                    Else
                        CHK_StrippingD.Checked = False
                    End If


                    If dr("sppmc_FIStrpngE").ToString() = "O" Then
                        CHK_StrippingE.Checked = True
                    Else
                        CHK_StrippingE.Checked = False
                    End If

                    If dr("sppmc_FIResorting").ToString() = "O" Then
                        CHK_StrippingE.Checked = True
                    Else
                        CHK_StrippingE.Checked = False
                    End If




                    If dr("sppmc_FIStrpngE").ToString() = "O" Then
                        CHK_Resorting.Checked = True
                    Else
                        CHK_Resorting.Checked = False
                    End If


                    TXT_Nonconformity.Text = dr("sppmc_FINCR").ToString()
                    TXT_NCR.Text = dr("sppmc_FINCRno").ToString()
                    TXT_QNR.Text = dr("sppmc_FIQNRno").ToString()
















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
            cmd.CommandText = "Select_sppmcFLC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    'A
                    If dr("flc_wasteBin").ToString() = "O" Then
                        CHK_FullWasteBinss.Checked = True
                    Else
                        CHK_FullWasteBinss.Checked = False

                    End If

                    If dr("flc_chairs").ToString() = "O" Then
                        CHK_FullChairs.Checked = True
                    Else
                        CHK_FullChairs.Checked = False
                    End If



                    If dr("flc_workingTable").ToString() = "O" Then
                        CHK_FullWorkingTable.Checked = True
                    Else
                        CHK_FullWorkingTable.Checked = False
                    End If

                    'B

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

                    TXT_FullGlueBottle.Text = dr("flc_OLCgluebottle").ToString()
                    TXT_FullOtherSpecify.Text = dr("flc_OLCothersdesc").ToString()
                    TXT_FullQtyStartPC.Text = dr("flc_OLCothersqty").ToString()



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
                    If dr("gmp_NoexcessDustDirt").ToString() = "O" Then
                        CHK_GoodExcessiveDust.Checked = True
                    Else
                        CHK_GoodExcessiveDust.Checked = False
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


                    If dr("gmp_SaniBundlingMch").ToString() = "O" Then
                        CHK_GoodBundlingMachine.Checked = True
                    Else
                        CHK_GoodBundlingMachine.Checked = False
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

                    If dr("gmp_Pre20inClearance").ToString() = "O" Then
                        CHK_GoodWith20WallClearance.Checked = True
                    Else
                        CHK_GoodWith20WallClearance.Checked = False
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

                    If dr("gmp_SafeCleaningMatls").ToString() = "O" Then
                        CHK_GoodCleaingMaterials.Checked = True
                    Else
                        CHK_GoodCleaingMaterials.Checked = False
                    End If


                    If dr("gmp_SafeEqpmt").ToString() = "O" Then
                        CHK_GoodEquipments.Checked = True
                    Else
                        CHK_GoodEquipments.Checked = False
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



        Dim lineLeader As String = ""
        Dim Feeder As String = ""
        Dim Picker As String = ""
        Dim Packer1 As String = ""
        Dim Packer2 As String = ""
        Dim Packer3 As String = ""
        Dim Sorter1 As String = ""
        Dim Sorter2 As String = ""
        Dim Sorter3 As String = ""
        Dim Sorter4 As String = ""
        Dim Sorter5 As String = ""
        Dim Sorter6 As String = ""
        Dim Sorter7 As String = ""
        Dim Sorter8 As String = ""
        Dim Sorter9 As String = ""
        Dim Sorter10 As String = ""
        Dim Sorter11 As String = ""








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

                    lineLeader = dr("jic_FILineLdr").ToString()
                    Feeder = dr("jic_FIFeeder").ToString()
                    Picker = dr("jic_FIPicker").ToString()
                    Packer1 = dr("jic_FIPacker1").ToString()
                    Packer2 = dr("jic_FIPacker2").ToString()
                    Packer3 = dr("jic_FIPacker3").ToString()
                    Sorter1 = dr("jic_FISorter1").ToString()
                    Sorter2 = dr("jic_FISorter2").ToString()
                    Sorter3 = dr("jic_FISorter3").ToString()
                    Sorter4 = dr("jic_FISorter4").ToString()
                    Sorter5 = dr("jic_FISorter5").ToString()
                    Sorter6 = dr("jic_FISorter6").ToString()
                    Sorter7 = dr("jic_FISorter7").ToString()
                    Sorter8 = dr("jic_FISorter8").ToString()
                    Sorter9 = dr("jic_FISorter9").ToString()
                    Sorter10 = dr("jic_FISorter10").ToString()
                    Sorter11 = dr("jic_FISorter11").ToString()



                    RTB_JobInstruction.Text = dr("jic_FIWrkInst").ToString()
                    RTB_JobPackingInstraction.Text = dr("jic_FIWrkArea").ToString()

                    TXT_JobStickerQuantity.Text = dr("jic_FIStickrqty").ToString()
                    TXT_JobCutOutLabelQty.Text = dr("jic_FICutoutlbl").ToString()
                    TXT_JobQtyPerPack.Text = dr("jic_FIQtyperpk").ToString()

                    TXT_JobLineLeader.Text = dr("jic_FILineLdr").ToString()
                    TXT_JobFeeder.Text = dr("jic_FIFeeder").ToString()
                    TXT_JobPicker.Text = dr("jic_FIPicker").ToString()
                    TXT_JobPacker1.Text = dr("jic_FIPacker1").ToString()
                    TXT_JobPacker2.Text = dr("jic_FIPacker2").ToString()
                    TXT_JobPacker3.Text = dr("jic_FIPacker3").ToString()
                    TXT_JobSorter1.Text = dr("jic_FISorter1").ToString()
                    TXT_JobSorter2.Text = dr("jic_FISorter2").ToString()
                    TXT_JobSorter3.Text = dr("jic_FISorter3").ToString()
                    TXT_JobSorter4.Text = dr("jic_FISorter4").ToString()
                    TXT_JobSorter5.Text = dr("jic_FISorter5").ToString()
                    TXT_JobSorter6.Text = dr("jic_FISorter6").ToString()
                    TXT_JobSorter7.Text = dr("jic_FISorter7").ToString()
                    TXT_JobSorter8.Text = dr("jic_FISorter8").ToString()
                    TXT_JobSorter9.Text = dr("jic_FISorter9").ToString()
                    TXT_JobSorter10.Text = dr("jic_FISorter10").ToString()
                    TXT_JobSorter11.Text = dr("jic_FISorter11").ToString()



                    DTP_JobLineLeaderStart.Text = dr("jic_FILineLdrStart").ToString()
                    DTP_JobLineLeaderEnd.Text = dr("jic_FILineLdrEnd").ToString()

                    DTP_JobFeederStart.Text = dr("jic_FIFeederStart").ToString()
                    DTP_JobFeederEnd.Text = dr("jic_FIFeederEnd").ToString()

                    DTP_JobPickerStart.Text = dr("jic_FIPickerStart").ToString()
                    DTP_JobPickerEnd.Text = dr("jic_FIPickerEnd").ToString()

                    DTP_JobPacker1Start.Text = dr("jic_FIPacker1Start").ToString()
                    DTP_JobPacker1End.Text = dr("jic_FIPacker1End").ToString()

                    DTP_JobPacker2Start.Text = dr("jic_FIPacker2Start").ToString()
                    DTP_JobPacker2End.Text = dr("jic_FIPacker2End").ToString()

                    DTP_JobPacker3Start.Text = dr("jic_FIPacker3Start").ToString()
                    DTP_JobPacker3End.Text = dr("jic_FIPacker3End").ToString()


                    DTP_JobSorter1Start.Text = dr("jic_FISorter1Start").ToString()
                    DTP_JobSorter1End.Text = dr("jic_FISorter1End").ToString()

                    DTP_JobSorter2Start.Text = dr("jic_FISorter2Start").ToString()
                    DTP_JobSorter2End.Text = dr("jic_FISorter2End").ToString()

                    DTP_JobSorter3Start.Text = dr("jic_FISorter3Start").ToString()
                    DTP_JobSorter3End.Text = dr("jic_FISorter3End").ToString()

                    DTP_JobSorter4Start.Text = dr("jic_FISorter4Start").ToString()
                    DTP_JobSorter4End.Text = dr("jic_FISorter4End").ToString()

                    DTP_JobSorter5Start.Text = dr("jic_FISorter5Start").ToString()
                    DTP_JobSorter5End.Text = dr("jic_FISorter5End").ToString()

                    DTP_JobSorter6Start.Text = dr("jic_FISorter6Start").ToString()
                    DTP_JobSorter6End.Text = dr("jic_FISorter6End").ToString()

                    DTP_JobSorter7Start.Text = dr("jic_FISorter7Start").ToString()
                    DTP_JobSorter7End.Text = dr("jic_FISorter7End").ToString()

                    DTP_JobSorter8Start.Text = dr("jic_FISorter8Start").ToString()
                    DTP_JobSorter8End.Text = dr("jic_FISorter8End").ToString()

                    DTP_JobSorter9Start.Text = dr("jic_FISorter9Start").ToString()
                    DTP_JobSorter9End.Text = dr("jic_FISorter9End").ToString()

                    DTP_JobSorter10Start.Text = dr("jic_FISorter10Start").ToString()
                    DTP_JobSorter10End.Text = dr("jic_FISorter10End").ToString()

                    DTP_JobSorter11Start.Text = dr("jic_FISorter11Start").ToString()
                    DTP_JobSorter11End.Text = dr("jic_FISorter11End").ToString()




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
            cmd.Parameters.AddWithValue("@emp_num", lineLeader)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobLineLeader.Text = dr("Name")

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


        'Feeder
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Feeder)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobFeeder.Text = dr("Name")

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



        'Picker
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Picker)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobPicker.Text = dr("Name")

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



        'Packer 1
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Packer1)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobPicker1.Text = dr("Name")

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


        'Packer 2
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Packer2)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobPicker2.Text = dr("Name")

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




        'Packer 3
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Packer3)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobPicker3.Text = dr("Name")

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


        'Sorter1
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter1)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter1.Text = dr("Name")

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

        'Sorter2
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter2)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter2.Text = dr("Name")

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

        'Sorter3
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter3)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter3.Text = dr("Name")

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


        'Sorter4
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter4)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter4.Text = dr("Name")

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


        'Sorter5
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter5)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter5.Text = dr("Name")

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



        'Sorter6
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter6)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter6.Text = dr("Name")

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


        'Sorter7
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter7)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter7.Text = dr("Name")

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


        'Sorter8
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter8)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter8.Text = dr("Name")

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




        'Sorter9
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter9)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter9.Text = dr("Name")

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


        'Sorter10
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter10)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter10.Text = dr("Name")

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


        'Sorter11
        Try
            OpenConnection()
            cmd.CommandText = "SELECT Name FROM Employee WHERE Emp_num = @emp_num"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@emp_num", Sorter11)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                If dr.Read() Then
                    CBO_JobSorter11.Text = dr("Name")

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
            cmd.CommandText = "Select_sppmcPRR_FIN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then
                    TXT_ProductOffColorQty.Text = dr("prr_FIOffClr").ToString()
                    TXT_ProductSpotQty.Text = dr("prr_FISpot").ToString()
                    TXT_ProductScumQty.Text = dr("prr_FIScum").ToString()
                    TXT_ProductMissingPrintQty.Text = dr("prr_FIMissPrn").ToString()
                    TXT_ProductSetOffQty.Text = dr("prr_FISetoff").ToString()
                    TXT_ProductMisregistrationQty.Text = dr("prr_FIMisregDi").ToString()
                    TXT_ProductRapturedScoring.Text = dr("prr_FIRapScor").ToString()
                    TXT_ProductMisalignedGluing.Text = dr("prr_FIMisaGlu").ToString()
                    TXT_ProductExcessGluingSlicking.Text = dr("prr_FIExcGlu").ToString()
                    TXT_NonConformity1.Text = dr("prr_FIOth1Desc").ToString()
                    TXT_NonConformity2.Text = dr("prr_FIOth2Desc").ToString()
                    TXT_NonConformity3.Text = dr("prr_FIOth3Desc").ToString()
                    TXT_NonConformity1QTY.Text = dr("prr_FIOthers1").ToString()
                    TXT_NonConformity2QTY.Text = dr("prr_FIOthers2").ToString()
                    TXT_NonConformity3QTY.Text = dr("prr_FIOthers3").ToString()
                End If

                dr.Close()
                con.Close()
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
                    TXT_RagsQuantityPC.Text = dr("ragsqty").ToString()
                    TXT_7GlueBottlerQty.Text = dr("gluebottle").ToString()
                    TXT_OthersSpecify.Text = dr("othersqty").ToString()
                    TXT_7DesOthersSpecify.Text = dr("othersdesc").ToString()



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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXT_JobStickerQuantity.TextChanged

    End Sub

    Private Sub CHK_SelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged
        If CHK_SelectAll.Checked = True Then
            SelectAllEnableCheck()
        Else
            SelectAllDisabledCheck()
        End If
    End Sub

    Private Sub BTN_Save_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Save_Supervisor.Click
        Dim SelectedWP As String = ""
        Dim SelectedFinishedGoods As String = ""
        Dim SelectedManualFinisings As String = ""
        Dim SelectedGluing As String = ""

        Dim SelectedAmbition50 As String = ""
        Dim SelectedMedia68 As String = ""

        Dim SelectedExpertfold80 As String = ""
        Dim SelectedMouse650 As String = ""


        Dim SelectedSun1300 As String = ""
        Dim SelectedSun850 As String = ""
        Dim SelectedExpertfold110 As String = ""
        Dim SelectedLaminaA As String = ""
        Dim SelectedLaminaB As String = ""
        Dim SelectedStripping As String = ""
        Dim SelectedStrippingA As String = ""
        Dim SelectedStrippingB As String = ""
        Dim SelectedStrippingC As String = ""
        Dim SelectedStrippingD As String = ""
        Dim SelectedStrippingE As String = ""
        Dim SelectedCResorting As String = ""



        If CHK_WP.Checked Then
            SelectedWP = "O"
        Else
            SelectedWP = "X"
        End If


        If CHK_ManualFinising.Checked Then
            SelectedFinishedGoods = "O"
        Else
            SelectedFinishedGoods = "X"
        End If



        If CHK_ManualFinising.Checked Then
            SelectedManualFinisings = "O"
        Else
            SelectedManualFinisings = "X"
        End If



        If CHK_Gluing.Checked Then
            SelectedGluing = "O"
        Else
            SelectedGluing = "X"
        End If


        If CHK_Ambition50.Checked Then
            SelectedAmbition50 = "O"
        Else
            SelectedAmbition50 = "X"
        End If



        If CHK_Media68.Checked Then
            SelectedMedia68 = "O"
        Else
            SelectedMedia68 = "X"
        End If



        If CHK_Expertfold80.Checked Then
            SelectedExpertfold80 = "O"
        Else
            SelectedExpertfold80 = "X"
        End If



        If CHK_Mouse650.Checked Then
            SelectedMouse650 = "O"
        Else
            SelectedMouse650 = "X"
        End If



        If CHK_Sun1300.Checked Then
            SelectedSun1300 = "O"
        Else
            SelectedSun1300 = "X"
        End If



        If CHK_Sun850.Checked Then
            SelectedSun850 = "O"
        Else
            SelectedSun850 = "X"
        End If



        If CHK_Expertfold110.Checked Then
            SelectedExpertfold110 = "O"
        Else
            SelectedExpertfold110 = "X"
        End If


        If CHK_LaminaA.Checked Then
            SelectedLaminaA = "O"
        Else
            SelectedLaminaA = "X"
        End If


        If CHK_LaminaB.Checked Then
            SelectedLaminaB = "O"
        Else
            SelectedLaminaB = "X"
        End If



        If CHK_Stripping.Checked Then
            SelectedStripping = "O"
        Else
            SelectedStripping = "X"
        End If


        If CHK_StrippingA.Checked Then
            SelectedStrippingA = "O"
        Else
            SelectedStrippingA = "X"
        End If


        If CHK_StrippingB.Checked Then
            SelectedStrippingB = "O"
        Else
            SelectedStrippingB = "X"
        End If


        If CHK_StrippingC.Checked Then
            SelectedStrippingC = "O"
        Else
            SelectedStrippingC = "X"
        End If



        If CHK_StrippingD.Checked Then
            SelectedStrippingD = "O"
        Else
            SelectedStrippingD = "X"
        End If



        If CHK_StrippingE.Checked Then
            SelectedStrippingE = "O"
        Else
            SelectedStrippingE = "X"
        End If


        If CHK_Resorting.Checked Then
            SelectedCResorting = "O"
        Else
            SelectedCResorting = "X"
        End If





        Try
            OpenConnection()
            cmd.CommandText = "Update_sppmcHdr"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.Parameters.AddWithValue("@sppmc_FIwip", SelectedWP)
            cmd.Parameters.AddWithValue("@sppmc_FIwipval", TXT_FullWP.Text)
            cmd.Parameters.AddWithValue("@sppmc_FIfingoods", SelectedFinishedGoods)
            cmd.Parameters.AddWithValue("@sppmc_FIshft1", "")
            cmd.Parameters.AddWithValue("@sppmc_FIshft2", "")
            cmd.Parameters.AddWithValue("@sppmc_FIshft3", "")
            cmd.Parameters.AddWithValue("@sppmc_FIManFin", SelectedManualFinisings)
            cmd.Parameters.AddWithValue("@sppmc_FIManFinNote", RBT_ManualFinishing.Text)
            cmd.Parameters.AddWithValue("@sppmc_FIGluing", SelectedGluing)
            cmd.Parameters.AddWithValue("@sppmc_FIAmb50", SelectedAmbition50)
            cmd.Parameters.AddWithValue("@sppmc_FIExptfld80", SelectedExpertfold80)
            cmd.Parameters.AddWithValue("@sppmc_FIExptfld110", SelectedExpertfold110)
            cmd.Parameters.AddWithValue("@sppmc_FILaminaA", SelectedLaminaA)
            cmd.Parameters.AddWithValue("@sppmc_FILaminaB", SelectedLaminaB)
            cmd.Parameters.AddWithValue("@sppmc_FISun1300", SelectedSun1300)
            cmd.Parameters.AddWithValue("@sppmc_FISun650", SelectedMouse650)
            cmd.Parameters.AddWithValue("@sppmc_FISun850", SelectedSun850)
            cmd.Parameters.AddWithValue("@sppmc_FIMedia68", SelectedMedia68)
            cmd.Parameters.AddWithValue("@sppmc_FIStrpngA", SelectedStrippingA)
            cmd.Parameters.AddWithValue("@sppmc_FIStrpngB", SelectedStrippingB)
            cmd.Parameters.AddWithValue("@sppmc_FIStrpngC", SelectedStrippingC)
            cmd.Parameters.AddWithValue("@sppmc_FIStrpngD", SelectedStrippingD)
            cmd.Parameters.AddWithValue("@sppmc_FIResorting", SelectedCResorting)
            cmd.Parameters.AddWithValue("@sppmc_FINCR", TXT_Nonconformity.Text)
            cmd.Parameters.AddWithValue("@sppmc_FINCRno", TXT_NCR.Text)
            cmd.Parameters.AddWithValue("@sppmc_FIQNRno", TXT_QNR.Text)
            cmd.Parameters.AddWithValue("@sppmc_FIStrpng", SelectedStripping)
            cmd.Parameters.AddWithValue("@sppmc_FIStrpngE", SelectedStrippingE)
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


        'A
        Dim FullWasteBinss As String = ""
        Dim FullChairs As String = ""
        Dim FullWorkingTable As String = ""


        If CHK_FullWasteBinss.Checked Then
            FullWasteBinss = "O"
        Else
            FullWasteBinss = "X"
        End If



        If CHK_FullChairs.Checked Then
            FullChairs = "O"
        Else
            FullChairs = "X"
        End If



        If CHK_FullWorkingTable.Checked Then
            FullWorkingTable = "O"
        Else
            FullWorkingTable = "X"
        End If



        'B
        Dim FullSticker As String = ""
        Dim FullKraftPaper As String = ""
        Dim FullCorrugatedBox As String = ""
        Dim FullCutLabel As String = ""
        Dim FullPalletTag As String = ""


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
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBinss)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", FullSticker)
                cmd.Parameters.AddWithValue("@flc_kraftPaper", FullKraftPaper)
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", FullCorrugatedBox)
                cmd.Parameters.AddWithValue("@flc_cutLabel", FullCutLabel)
                cmd.Parameters.AddWithValue("@flc_palletTag", FullPalletTag)
                cmd.Parameters.AddWithValue("@flc_feeder", "")
                cmd.Parameters.AddWithValue("@flc_delivery", "")
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
                cmd.Parameters.AddWithValue("@flc_workingTable", FullWorkingTable)
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
                cmd.Parameters.AddWithValue("@flc_OLCgluebottle", TXT_FullGlueBottle.Text)
                cmd.Parameters.AddWithValue("@flc_OLCothersdesc", TXT_FullOtherSpecify.Text)
                cmd.Parameters.AddWithValue("@flc_OLCothersqty", TXT_FullQtyStartPC.Text)
                cmd.Parameters.AddWithValue("@flc_chairs", FullChairs)
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBinss)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", FullSticker)
                cmd.Parameters.AddWithValue("@flc_kraftPaper", FullKraftPaper)
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", FullCorrugatedBox)
                cmd.Parameters.AddWithValue("@flc_cutLabel", FullCutLabel)
                cmd.Parameters.AddWithValue("@flc_palletTag", FullPalletTag)
                cmd.Parameters.AddWithValue("@flc_feeder", "")
                cmd.Parameters.AddWithValue("@flc_delivery", "")
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
                cmd.Parameters.AddWithValue("@flc_workingTable", FullWorkingTable)
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
                cmd.Parameters.AddWithValue("@flc_OLCgluebottle", TXT_FullGlueBottle.Text)
                cmd.Parameters.AddWithValue("@flc_OLCothersdesc", TXT_FullOtherSpecify.Text)
                cmd.Parameters.AddWithValue("@flc_OLCothersqty", TXT_FullQtyStartPC.Text)
                cmd.Parameters.AddWithValue("@flc_chairs", FullChairs)
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
            'A
            Dim GoodExcessiveDust As String = ""
            Dim GoodForeignMaterials As String = ""

            If CHK_GoodExcessiveDust.Checked Then
                GoodExcessiveDust = "O"
            Else
                GoodExcessiveDust = "X"
            End If


            If CHK_GoodForeignMaterials.Checked Then
                GoodForeignMaterials = "O"
            Else
                GoodForeignMaterials = "X"
            End If




            'B
            Dim GoodJSortingTable As String = ""
            Dim GoodBundlingMachine As String = ""
            Dim GoodWeighingScale As String = ""


            If CHK_GoodJSortingTable.Checked Then
                GoodJSortingTable = "O"
            Else
                GoodJSortingTable = "X"
            End If



            If CHK_GoodBundlingMachine.Checked Then
                GoodBundlingMachine = "O"
            Else
                GoodBundlingMachine = "X"
            End If



            If CHK_GoodWeighingScale.Checked Then
                GoodWeighingScale = "O"
            Else
                GoodWeighingScale = "X"
            End If


            'C
            Dim GoodProperlyTagged As String = ""
            Dim GoodPlasticPallets As String = ""
            Dim GoodWith20Wall As String = ""



            If CHK_GoodProperlyTagged.Checked Then
                GoodProperlyTagged = "O"
            Else
                GoodProperlyTagged = "X"
            End If


            If CHk_GoodInPlasticPallets.Checked Then
                GoodPlasticPallets = "O"
            Else
                GoodPlasticPallets = "X"
            End If




            If CHK_GoodWith20WallClearance.Checked Then
                GoodWith20Wall = "O"
            Else
                GoodWith20Wall = "X"
            End If







            'D
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

            'E
            Dim GoodCleaningMaterials As String = ""
            Dim GoodEquipment As String = ""




            If CHK_GoodCleaingMaterials.Checked Then
                GoodCleaningMaterials = "O"
            Else
                GoodCleaningMaterials = "X"
            End If




            If CHK_GoodEquipments.Checked Then
                GoodEquipment = "O"
            Else
                GoodEquipment = "X"
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
                cmd.Parameters.AddWithValue("@gmp_NoOilChemSpill", "")
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
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTiltTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBars", "")
                cmd.Parameters.AddWithValue("@gmp_SaniSortTable", GoodJSortingTable)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", "")
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBundlingMch", GoodBundlingMachine)
                cmd.Parameters.AddWithValue("@gmp_SaniRotatingTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniWeighScale", GoodWeighingScale)
                cmd.Parameters.AddWithValue("@gmp_PrePropTagged", GoodProperlyTagged)
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20Wall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", "")
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCovers)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandsWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", "")
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaningMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", "")
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
                cmd.Parameters.AddWithValue("@gmp_NoOilChemSpill", "")
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
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTiltTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPins", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBars", "")
                cmd.Parameters.AddWithValue("@gmp_SaniSortTable", GoodJSortingTable)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPrefoldUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGluingUnit", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFinalFold", "")
                cmd.Parameters.AddWithValue("@gmp_SaniJPacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniBundlingMch", GoodBundlingMachine)
                cmd.Parameters.AddWithValue("@gmp_SaniRotatingTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniWeighScale", GoodWeighingScale)
                cmd.Parameters.AddWithValue("@gmp_PrePropTagged", GoodProperlyTagged)
                cmd.Parameters.AddWithValue("@gmp_PreInPlasticPallet", GoodPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20Wall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", "")
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", GoodWearHairCovers)
                cmd.Parameters.AddWithValue("@gmp_HygPropUniform", GoodWearProperlyTuckedIn)
                cmd.Parameters.AddWithValue("@gmp_HygHandsWashed", GoodHandsWashed)
                cmd.Parameters.AddWithValue("@gmp_SafeTools", "")
                cmd.Parameters.AddWithValue("@gmp_SafeEqpmt", GoodEquipment)
                cmd.Parameters.AddWithValue("@gmp_SafeCleaningMatls", GoodCleaningMaterials)
                cmd.Parameters.AddWithValue("@gmp_SafeWorkingDevices", "")
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
                cmd.Parameters.AddWithValue("@jic_note", "")
                cmd.Parameters.AddWithValue("@jic_Operator", "")
                cmd.Parameters.AddWithValue("@jic_Helper", "")
                cmd.Parameters.AddWithValue("@jic_Helper1", "")
                cmd.Parameters.AddWithValue("@jic_Helper2", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper2", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2", "")
                cmd.Parameters.AddWithValue("@jic_ConductedBySV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                cmd.Parameters.AddWithValue("@jic_FIWrkInst", RTB_JobInstruction.Text)
                cmd.Parameters.AddWithValue("@jic_FIWrkArea", RTB_JobPackingInstraction.Text)
                cmd.Parameters.AddWithValue("@jic_FITimeStart", "")
                cmd.Parameters.AddWithValue("@jic_FITimeEnd", "")
                cmd.Parameters.AddWithValue("@jic_FITotTime", "")
                cmd.Parameters.AddWithValue("@jic_FIManHr", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdr", TXT_JobLineLeader.Text)
                cmd.Parameters.AddWithValue("@jic_FIFeeder", TXT_JobFeeder.Text)
                cmd.Parameters.AddWithValue("@jic_FIPicker", TXT_JobPicker.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker1", TXT_JobPacker1.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker2", TXT_JobPacker2.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker3", TXT_JobPacker3.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter1", TXT_JobSorter1.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter2", TXT_JobSorter2.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter3", TXT_JobSorter3.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter4", TXT_JobSorter4.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter5", TXT_JobSorter5.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter6", TXT_JobSorter6.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter7", TXT_JobSorter7.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter8", TXT_JobSorter8.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter9", TXT_JobSorter9.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter10", TXT_JobSorter10.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter11", TXT_JobSorter11.Text)
                cmd.Parameters.AddWithValue("@jic_OperatorTime", "")
                cmd.Parameters.AddWithValue("@jic_Helper1Time", "")
                cmd.Parameters.AddWithValue("@jic_Helper2Time", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper2Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2Time", "")


                'cmd.Parameters.AddWithValue("@jic_FILineLdrStart", DTP_JobLineLeaderStart.Text)
                'cmd.Parameters.AddWithValue("@jic_FILineLdrEnd", DTP_JobLineLeaderEnd.Text)
                cmd.Parameters.AddWithValue("@jic_FILineLdrStart", DTP_JobLineLeaderStart.Value)
                cmd.Parameters.AddWithValue("@jic_FILineLdrEnd", DTP_JobLineLeaderEnd.Value)
                cmd.Parameters.AddWithValue("@jic_FIFeederStart", DTP_JobFeederStart.Text)
                cmd.Parameters.AddWithValue("@jic_FIFeederEnd", DTP_JobFeederEnd.Text)


                cmd.Parameters.AddWithValue("@jic_FIPickerStart", DTP_JobPickerStart.Text)
                cmd.Parameters.AddWithValue("@jic_FIPickerEnd", DTP_JobPickerEnd.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker1End", DTP_JobPacker1End.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker1Start", DTP_JobPacker1Start.Text)


                cmd.Parameters.AddWithValue("@jic_FIPacker2End", DTP_JobPacker2End.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker2Start", DTP_JobPacker2Start.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker3End", DTP_JobPacker3End.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker3Start", DTP_JobPacker3Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter10End", DTP_JobSorter10End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter10Start", DTP_JobSorter10Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter11End", DTP_JobSorter11End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter11Start", DTP_JobSorter11Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter1End", DTP_JobSorter1End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter1Start", DTP_JobSorter1Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter2End", DTP_JobSorter2End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter2Start", DTP_JobSorter2Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter3End", DTP_JobSorter3End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter3Start", DTP_JobSorter3Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter4End", DTP_JobSorter4End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter4Start", DTP_JobSorter4Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter5End", DTP_JobSorter5End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter5Start", DTP_JobSorter5Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter6End", DTP_JobSorter6End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter6Start", DTP_JobSorter6Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter7End", DTP_JobSorter7End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter7Start", DTP_JobSorter7Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter8End", DTP_JobSorter8End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter8Start", DTP_JobSorter8Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter9End", DTP_JobSorter9End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter9Start", DTP_JobSorter9Start.Text)
                cmd.Parameters.AddWithValue("@jic_FIStickrqty", TXT_JobStickerQuantity.Text)
                cmd.Parameters.AddWithValue("@jic_FICutoutlbl", TXT_JobCutOutLabelQty.Text)
                cmd.Parameters.AddWithValue("@jic_FIQtyperpk", TXT_JobQtyPerPack.Text)


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
                cmd.Parameters.AddWithValue("@jic_note", "")
                cmd.Parameters.AddWithValue("@jic_Operator", "")
                cmd.Parameters.AddWithValue("@jic_Helper", "")
                cmd.Parameters.AddWithValue("@jic_Helper1", "")
                cmd.Parameters.AddWithValue("@jic_Helper2", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper2", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2", "")
                cmd.Parameters.AddWithValue("@jic_ConductedBySV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
                cmd.Parameters.AddWithValue("@jic_FIWrkInst", RTB_JobInstruction.Text)
                cmd.Parameters.AddWithValue("@jic_FIWrkArea", RTB_JobPackingInstraction.Text)
                cmd.Parameters.AddWithValue("@jic_FITimeStart", "")
                cmd.Parameters.AddWithValue("@jic_FITimeEnd", "")
                cmd.Parameters.AddWithValue("@jic_FITotTime", "")
                cmd.Parameters.AddWithValue("@jic_FIManHr", "")
                cmd.Parameters.AddWithValue("@jic_FILineLdr", TXT_JobLineLeader.Text)
                cmd.Parameters.AddWithValue("@jic_FIFeeder", TXT_JobFeeder.Text)
                cmd.Parameters.AddWithValue("@jic_FIPicker", TXT_JobPicker.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker1", TXT_JobPacker1.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker2", TXT_JobPacker2.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker3", TXT_JobPacker3.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter1", TXT_JobSorter1.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter2", TXT_JobSorter2.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter3", TXT_JobSorter3.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter4", TXT_JobSorter4.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter5", TXT_JobSorter5.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter6", TXT_JobSorter6.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter7", TXT_JobSorter7.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter8", TXT_JobSorter8.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter9", TXT_JobSorter9.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter10", TXT_JobSorter10.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter11", TXT_JobSorter11.Text)
                cmd.Parameters.AddWithValue("@jic_OperatorTime", "")
                cmd.Parameters.AddWithValue("@jic_Helper1Time", "")
                cmd.Parameters.AddWithValue("@jic_Helper2Time", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", "")
                cmd.Parameters.AddWithValue("@jic_AsstOper2Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman1Time", "")
                cmd.Parameters.AddWithValue("@jic_Feedrman2Time", "")

                cmd.Parameters.AddWithValue("@jic_FILineLdrStart", DTP_JobLineLeaderStart.Text)
                cmd.Parameters.AddWithValue("@jic_FILineLdrEnd", DTP_JobLineLeaderEnd.Text)
                cmd.Parameters.AddWithValue("@jic_FIFeederStart", DTP_JobFeederStart.Text)
                cmd.Parameters.AddWithValue("@jic_FIFeederEnd", DTP_JobFeederEnd.Text)
                cmd.Parameters.AddWithValue("@jic_FIPickerStart", DTP_JobPickerStart.Text)
                cmd.Parameters.AddWithValue("@jic_FIPickerEnd", DTP_JobPickerEnd.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker1End", DTP_JobPacker1End.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker1Start", DTP_JobPacker1Start.Text)

                cmd.Parameters.AddWithValue("@jic_FIPacker2End", DTP_JobPacker2End.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker2Start", DTP_JobPacker2Start.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker3End", DTP_JobPacker3End.Text)
                cmd.Parameters.AddWithValue("@jic_FIPacker3Start", DTP_JobPacker3Start.Text)

                cmd.Parameters.AddWithValue("@jic_FISorter10End", DTP_JobSorter10End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter10Start", DTP_JobSorter10Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter11End", DTP_JobSorter11End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter11Start", DTP_JobSorter11Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter1End", DTP_JobSorter1End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter1Start", DTP_JobSorter1Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter2End", DTP_JobSorter2End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter2Start", DTP_JobSorter2Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter3End", DTP_JobSorter3End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter3Start", DTP_JobSorter3Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter4End", DTP_JobSorter4End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter4Start", DTP_JobSorter4Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter5End", DTP_JobSorter5End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter5Start", DTP_JobSorter5Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter6End", DTP_JobSorter6End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter6Start", DTP_JobSorter6Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter7End", DTP_JobSorter7End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter7Start", DTP_JobSorter7Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter8End", DTP_JobSorter8End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter8Start", DTP_JobSorter8Start.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter9End", DTP_JobSorter9End.Text)
                cmd.Parameters.AddWithValue("@jic_FISorter9Start", DTP_JobSorter9Start.Text)
                cmd.Parameters.AddWithValue("@jic_FIStickrqty", TXT_JobStickerQuantity.Text)
                cmd.Parameters.AddWithValue("@jic_FICutoutlbl", TXT_JobCutOutLabelQty.Text)
                cmd.Parameters.AddWithValue("@jic_FIQtyperpk", TXT_JobQtyPerPack.Text)

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
            cmd.CommandText = "Select_sppmcPRR_FIN"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            dr = cmd.ExecuteReader()



            If dr.HasRows Then
                dr.Close()
                con.Close()

                OpenConnection()
                cmd.CommandText = "Update_sppmcPRR_FIN"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@prr_RESNum", "")
                cmd.Parameters.AddWithValue("@prr_SASNum", "")
                cmd.Parameters.AddWithValue("@prr_FIOffClr", TXT_ProductOffColorQty.Text)
                cmd.Parameters.AddWithValue("@prr_FISpot", TXT_ProductSpotQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIScum", TXT_ProductScumQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIMisregPr", "")
                cmd.Parameters.AddWithValue("@prr_FIMissPrn", TXT_ProductMissingPrintQty.Text)
                cmd.Parameters.AddWithValue("@prr_FISetoff", TXT_ProductSetOffQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIMisregDi", TXT_ProductMisregistrationQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIRapScor", TXT_ProductRapturedScoring.Text)
                cmd.Parameters.AddWithValue("@prr_FIMisaGlu", TXT_ProductMisalignedGluing.Text)
                cmd.Parameters.AddWithValue("@prr_FIExcGlu", TXT_ProductExcessGluingSlicking.Text)
                cmd.Parameters.AddWithValue("@prr_FINotes", "")
                cmd.Parameters.AddWithValue("@prr_FIOth1Desc", TXT_NonConformity1.Text)
                cmd.Parameters.AddWithValue("@prr_FIOth2Desc", TXT_NonConformity2.Text)
                cmd.Parameters.AddWithValue("@prr_FIOth3Desc", TXT_NonConformity3.Text)
                cmd.Parameters.AddWithValue("@prr_FIOthers1", TXT_NonConformity1QTY.Text)
                cmd.Parameters.AddWithValue("@prr_FIOthers2", TXT_NonConformity2QTY.Text)
                cmd.Parameters.AddWithValue("@prr_FIOthers3", TXT_NonConformity3QTY.Text)

                cmd.ExecuteNonQuery()
                con.Close()


            Else
                con.Close()

                OpenConnection()
                cmd.CommandText = "Insert_sppmcPRR_FIN"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()


                cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                cmd.Parameters.AddWithValue("@prr_RESNum", "")
                cmd.Parameters.AddWithValue("@prr_SASNum", "")
                cmd.Parameters.AddWithValue("@prr_FIOffClr", TXT_ProductOffColorQty.Text)
                cmd.Parameters.AddWithValue("@prr_FISpot", TXT_ProductSpotQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIScum", TXT_ProductScumQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIMisregPr", "")
                cmd.Parameters.AddWithValue("@prr_FIMissPrn", TXT_ProductMissingPrintQty.Text)
                cmd.Parameters.AddWithValue("@prr_FISetoff", TXT_ProductSetOffQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIMisregDi", TXT_ProductMisregistrationQty.Text)
                cmd.Parameters.AddWithValue("@prr_FIRapScor", TXT_ProductRapturedScoring.Text)
                cmd.Parameters.AddWithValue("@prr_FIMisaGlu", TXT_ProductMisalignedGluing.Text)
                cmd.Parameters.AddWithValue("@prr_FIExcGlu", TXT_ProductExcessGluingSlicking.Text)
                cmd.Parameters.AddWithValue("@prr_FINotes", "")
                cmd.Parameters.AddWithValue("@prr_FIOth1Desc", TXT_NonConformity1.Text)
                cmd.Parameters.AddWithValue("@prr_FIOth2Desc", TXT_NonConformity2.Text)
                cmd.Parameters.AddWithValue("@prr_FIOth3Desc", TXT_NonConformity3.Text)
                cmd.Parameters.AddWithValue("@prr_FIOthers1", TXT_NonConformity1QTY.Text)
                cmd.Parameters.AddWithValue("@prr_FIOthers2", TXT_NonConformity2QTY.Text)
                cmd.Parameters.AddWithValue("@prr_FIOthers3", TXT_NonConformity3QTY.Text)

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
                cmd.Parameters.AddWithValue("@ragsqty", TXT_RagsQuantityPC.Text)
                cmd.Parameters.AddWithValue("@stripknife", DBNull.Value)
                cmd.Parameters.AddWithValue("@stripknifebld", DBNull.Value)
                cmd.Parameters.AddWithValue("@markerqty", DBNull.Value)
                cmd.Parameters.AddWithValue("@gluebottle", TXT_7GlueBottlerQty.Text)
                cmd.Parameters.AddWithValue("@othersdesc", TXT_7DesOthersSpecify.Text)
                cmd.Parameters.AddWithValue("@othersqty", TXT_OthersSpecify.Text)
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
                cmd.Parameters.AddWithValue("@ragsqty", TXT_RagsQuantityPC.Text)
                cmd.Parameters.AddWithValue("@stripknife", DBNull.Value)
                cmd.Parameters.AddWithValue("@stripknifebld", DBNull.Value)
                cmd.Parameters.AddWithValue("@markerqty", DBNull.Value)
                cmd.Parameters.AddWithValue("@gluebottle", TXT_7GlueBottlerQty.Text)
                cmd.Parameters.AddWithValue("@othersdesc", TXT_7DesOthersSpecify.Text)
                cmd.Parameters.AddWithValue("@othersqty", TXT_OthersSpecify.Text)
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

        Dim UC_SupervisorFinishing As New UC_SupervisorFinishing
        UC_SupervisorFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorFinishing.Show()
        UC_SupervisorFinishing.Dock = DockStyle.Fill




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

        section = FRM_MonitoringChecklistMain.TXT_OrigSection.Text
        section_code = FRM_MonitoringChecklistMain.TXT_OrigSectionCode.Text
        FRM_MonitoringChecklistMain.LBL_SectionName.Text = section
        FRM_MonitoringChecklistMain.LBL_Title.Visible = True
        FRM_MonitoringChecklistMain.LBL_Title.Text = "MONITORING CHECKLIST - "
        FRM_MonitoringChecklistMain.LBL_SectionName.Visible = True




        'FRM_ProcessJob.BTN_AddMonitoringChecklist.Enabled = True
    End Sub


    Private Sub TXT_ProductOffColorQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductOffColorQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_ProductSpotQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductSpotQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_ProductScumQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductScumQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_ProductMissingPrintQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductMissingPrintQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_ProductSetOffQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductSetOffQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_ProductMisregistrationQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductMisregistrationQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_ProductRapturedScoring_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductRapturedScoring.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_ProductMisalignedGluing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductMisalignedGluing.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_ProductExcessGluingSlicking_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ProductExcessGluingSlicking.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_NonConformity1QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NonConformity1QTY.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_NonConformity2QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NonConformity2QTY.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_NonConformity3QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NonConformity3QTY.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_7BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7BallpenQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_RagsQuantityPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RagsQuantityPC.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_7GlueBottlerQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7GlueBottlerQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_OthersSpecify_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_OthersSpecify.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_JobStickerQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_JobStickerQuantity.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_JobCutOutLabelQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_JobCutOutLabelQty.KeyPress
        NumberOnly(e)
    End Sub




    Private Sub TXT_JobQtyPerPack_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_JobQtyPerPack.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_FullBallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullBallpenQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_FullRagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullRagsQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_FullGlueBottle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullGlueBottle.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_FullOtherSpecify_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullOtherSpecify.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_FullQtyStartPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullQtyStartPC.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub CBO_JobLineLeader_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobLineLeader.SelectedIndexChanged
        con.Close()
        load_LineLeader_empnum1()
    End Sub
    Private Sub load_LineLeader_empnum1()

        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Line Leader' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobLineLeader.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobLineLeader.Items.Add(helper_empname)
                TXT_JobLineLeader.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobLineLeader.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobLineLeader_DropDown(sender As Object, e As EventArgs) Handles CBO_JobLineLeader.DropDown
        CBO_JobLineLeader.Items.Clear()
        load_LineLeader()
    End Sub
    Private Sub load_LineLeader()


        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Line Leader' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobLineLeader.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobFeeder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobFeeder.SelectedIndexChanged
        con.Close()
        load_Feeder_empnum1()
    End Sub

    Private Sub load_Feeder_empnum1()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Feeder' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobFeeder.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobFeeder.Items.Add(helper_empname)
                TXT_JobFeeder.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobFeeder.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobFeeder_DropDown(sender As Object, e As EventArgs) Handles CBO_JobFeeder.DropDown
        CBO_JobFeeder.Items.Clear()
        load_Feeder()
    End Sub

    Private Sub load_Feeder()


        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Feeder' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobFeeder.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobPicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobPicker.SelectedIndexChanged
        con.Close()
        load_Picker_empnum()
    End Sub

    Private Sub load_Picker_empnum()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Picker' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobPicker.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobPicker.Items.Add(helper_empname)
                TXT_JobPicker.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobPicker.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobPicker_DropDown(sender As Object, e As EventArgs) Handles CBO_JobPicker.DropDown
        CBO_JobPicker.Items.Clear()
        load_Picker()
    End Sub

    Private Sub load_Picker()
        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Picker' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobPicker.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobFeederPicker1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobPicker1.SelectedIndexChanged
        con.Close()
        load_Packer_empnum1()
    End Sub

    Private Sub load_Packer_empnum1()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Packer' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobPicker1.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobPicker1.Items.Add(helper_empname)
                TXT_JobPacker1.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobPicker1.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobFeederPicker1_DropDown(sender As Object, e As EventArgs) Handles CBO_JobPicker1.DropDown
        CBO_JobPicker1.Items.Clear()
        load_Packer1()
    End Sub

    Private Sub load_Packer1()


        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Packer' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobPicker1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobFeederPicker2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobPicker2.SelectedIndexChanged
        con.Close()
        load_Packer_empnum2()
    End Sub

    Private Sub load_Packer_empnum2()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Packer' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobPicker2.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobPicker2.Items.Add(helper_empname)
                TXT_JobPacker2.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobPicker2.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobFeederPicker2_DropDown(sender As Object, e As EventArgs) Handles CBO_JobPicker2.DropDown
        CBO_JobPicker2.Items.Clear()
        load_Packer2()
    End Sub

    Private Sub load_Packer2()


        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Packer' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobPicker2.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobFeederPicker3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobPicker3.SelectedIndexChanged
        con.Close()
        load_Packer_empnum3()
    End Sub

    Private Sub load_Packer_empnum3()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Packer' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobPicker3.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobPicker3.Items.Add(helper_empname)
                TXT_JobPacker3.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobPicker3.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobFeederPicker3_DropDown(sender As Object, e As EventArgs) Handles CBO_JobPicker3.DropDown

        CBO_JobPicker3.Items.Clear()
        load_Packer3()
    End Sub

    Private Sub load_Packer3()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Packer' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobPicker3.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter1.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum1()
    End Sub

    Private Sub load_Sorter_empnum1()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter1.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter1.Items.Add(helper_empname)
                TXT_JobSorter1.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter1.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter1_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter1.DropDown
        CBO_JobSorter1.Items.Clear()
        load_Sorter1()
    End Sub

    Private Sub load_Sorter1()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter2.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum2()
    End Sub

    Private Sub load_Sorter_empnum2()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter2.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter2.Items.Add(helper_empname)
                TXT_JobSorter2.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter2.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter2_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter2.DropDown
        CBO_JobSorter2.Items.Clear()
        load_Sorter2()
    End Sub

    Private Sub load_Sorter2()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter2.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter3.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum3()
    End Sub


    Private Sub load_Sorter_empnum3()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter3.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter3.Items.Add(helper_empname)
                TXT_JobSorter3.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter3.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter3_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter3.DropDown
        CBO_JobSorter3.Items.Clear()
        load_Sorter3()
    End Sub

    Private Sub load_Sorter3()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter3.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter4.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum4()
    End Sub


    Private Sub load_Sorter_empnum4()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter4.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter4.Items.Add(helper_empname)
                TXT_JobSorter4.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter4.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter4_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter4.DropDown
        CBO_JobSorter4.Items.Clear()
        load_Sorter4()
    End Sub

    Private Sub load_Sorter4()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter4.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter5.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum5()
    End Sub

    Private Sub load_Sorter_empnum5()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter5.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter5.Items.Add(helper_empname)
                TXT_JobSorter5.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter5.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter5_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter5.DropDown
        CBO_JobSorter5.Items.Clear()
        load_Sorter5()
    End Sub

    Private Sub load_Sorter5()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter5.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter6.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum6()
    End Sub

    Private Sub load_Sorter_empnum6()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter6.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter6.Items.Add(helper_empname)
                TXT_JobSorter6.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter6.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter6_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter6.DropDown
        CBO_JobSorter6.Items.Clear()
        load_Sorter6()
    End Sub
    Private Sub load_Sorter6()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter6.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter7.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum7()
    End Sub
    Private Sub load_Sorter_empnum7()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter7.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter7.Items.Add(helper_empname)
                TXT_JobSorter7.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter7.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter7_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter7.DropDown
        CBO_JobSorter7.Items.Clear()
        load_Sorter7()
    End Sub

    Private Sub load_Sorter7()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter7.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter8.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum8()
    End Sub

    Private Sub load_Sorter_empnum8()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter8.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter8.Items.Add(helper_empname)
                TXT_JobSorter8.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter8.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter8_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter8.DropDown
        CBO_JobSorter8.Items.Clear()
        load_Sorter8()
    End Sub

    Private Sub load_Sorter8()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter8.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter9.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum9()
    End Sub

    Private Sub load_Sorter_empnum9()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter9.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter9.Items.Add(helper_empname)
                TXT_JobSorter9.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter9.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter9_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter9.DropDown
        CBO_JobSorter9.Items.Clear()
        load_Sorter9()
    End Sub

    Private Sub load_Sorter9()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter9.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter10.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum10()
    End Sub
    Private Sub load_Sorter_empnum10()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter10.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter10.Items.Add(helper_empname)
                TXT_JobSorter10.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter10.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter10_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter10.DropDown
        CBO_JobSorter10.Items.Clear()
        load_Sorter10()
    End Sub

    Private Sub load_Sorter10()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter10.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub CBO_JobSorter11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_JobSorter11.SelectedIndexChanged
        con.Close()
        load_Sorter_empnum11()
    End Sub

    Private Sub load_Sorter_empnum11()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
          Name, 
          Emp_num, 
          Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Sorter' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_JobSorter11.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            If read_cmd_select_helper_empnum.Read Then
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_JobSorter11.Items.Add(helper_empname)
                TXT_JobSorter11.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_JobSorter11.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End If
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CBO_JobSorter11_DropDown(sender As Object, e As EventArgs) Handles CBO_JobSorter11.DropDown
        CBO_JobSorter11.Items.Clear()
        load_Sorter11()
    End Sub

    Private Sub load_Sorter11()

        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name AS Emp_num_helper FROM Employee WHERE Position = 'Sorter' ORDER BY NAME", con)

        Try
            con.Open()

            ' Use Using block to ensure the reader is disposed of correctly
            Using read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader()
                While read_cmd_select_helper.Read()
                    CBO_JobSorter11.Items.Add(read_cmd_select_helper("Emp_num_helper"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class
