Imports System.Data.SqlClient

Public Class UC_SupervisorLamination
    Private Sub NumberChar(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DisabledSupervisorForm()
        CHK_SelectAll.Enabled = False

        'FULL A
        CHK_FullFeederUnitTopSheet.Enabled = False
        CHK_FullFeederUnitSingleFace.Enabled = False
        CHK_FullGluingUnit.Enabled = False
        CHK_FullGlueBin.Enabled = False
        CHK_FullDeliveryUnit.Enabled = False
        CHK_FullViewingTable.Enabled = False


        'FULL B
        TXT_FullBallpenQtyStartPC.Enabled = False
        TXT_FullRagsQtyStartPC.Enabled = False
        TXT_FullMarkerQtyStartPC.Enabled = False



        'GMPA
        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodOilChemical.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False


        'GMPB
        CHK_GoodFeederTop.Enabled = False
        CHK_GoodFeederSF.Enabled = False
        CHK_GoodConveyor.Enabled = False
        CHK_GoodTransportBelt.Enabled = False
        CHK_GoodDelivery.Enabled = False

        'GMPC
        CHK_GoodProperlyTagged.Enabled = False
        CHK_GoodPlasticPalltes.Enabled = False
        CHK_GoodFollowingStandard.Enabled = False

        'GMPD
        CHK_GoodWearHair.Enabled = False
        CHk_GoodWearsProperlyTucked.Enabled = False
        CHk_GoodHandsWashed.Enabled = False

        'GMPE
        CHK_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaningMaterials.Enabled = False
        CHK_GoodSafetyDevice.Enabled = False

        '3.
        RTB_JobInstruction.Enabled = False
        TXT_OperatorNumSupervisor.Enabled = False
        TXT_OperatorUCSupervisor.Enabled = False
        DTPOperator.Enabled = False
        CBO_Helper1.Enabled = False
        TXT_Helper1.Enabled = False
        DTPHelper1.Enabled = False


        '4.
        CHK_4AVertical.Enabled = False
        CHK_4AHorizontal.Enabled = False
        CHK_4BEFlute.Enabled = False
        CHK_4BCFlute.Enabled = False
        CHK_4BBFlute.Enabled = False
        TXT_4CCheckSinglemm1.Enabled = False
        TXT_4CCheckSinglemm2.Enabled = False
        CHK_4DTopSheet.Enabled = False
        CHK_4DSingleFace.Enabled = False
        CHK_4DBottomSheet.Enabled = False
        TXT_4DBottomSheet.Enabled = False
        CHK_4EOperator.Enabled = False
        CHK_4EDrive.Enabled = False
        TXT_4FTarget.Enabled = False
        TXT_4FTargetActual.Enabled = False
        TXT_4GTarget.Enabled = False
        TXT_4GTargetActual.Enabled = False
        CHK_4HNoExcessGlue.Enabled = False
        CHK_4HNoWeakGlue.Enabled = False
        CHK_4JNoDownloadwarping.Enabled = False
        CHK_4JNoUpwardwarping.Enabled = False

        '7
        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False
        TXT_7Marker.Enabled = False


        BTN_Save_Supervisor.Enabled = False


    End Sub

    Private Sub EnabledSupervisorForm()
        CHK_SelectAll.Enabled = True

        'FULL A
        CHK_FullFeederUnitTopSheet.Enabled = True
        CHK_FullFeederUnitSingleFace.Enabled = True
        CHK_FullGluingUnit.Enabled = True
        CHK_FullGlueBin.Enabled = True
        CHK_FullDeliveryUnit.Enabled = True
        CHK_FullViewingTable.Enabled = True

        'FULL B
        TXT_FullBallpenQtyStartPC.Enabled = True
        TXT_FullRagsQtyStartPC.Enabled = True
        TXT_FullMarkerQtyStartPC.Enabled = True

        'GMPA
        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodOilChemical.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True

        'GMPB
        CHK_GoodFeederTop.Enabled = True
        CHK_GoodFeederSF.Enabled = True
        CHK_GoodConveyor.Enabled = True
        CHK_GoodTransportBelt.Enabled = True
        CHK_GoodDelivery.Enabled = True

        'GMPC
        CHK_GoodProperlyTagged.Enabled = True
        CHK_GoodPlasticPalltes.Enabled = True
        CHK_GoodFollowingStandard.Enabled = True

        'GMPD
        CHK_GoodWearHair.Enabled = True
        CHk_GoodWearsProperlyTucked.Enabled = True
        CHk_GoodHandsWashed.Enabled = True

        'GMPE
        CHK_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaningMaterials.Enabled = True
        CHK_GoodSafetyDevice.Enabled = True

        '3.
        RTB_JobInstruction.Enabled = True
        TXT_OperatorNumSupervisor.Enabled = True
        TXT_OperatorUCSupervisor.Enabled = True
        DTPOperator.Enabled = True
        CBO_Helper1.Enabled = True
        TXT_Helper1.Enabled = True
        DTPHelper1.Enabled = True

        '4.
        CHK_4AVertical.Enabled = True
        CHK_4AHorizontal.Enabled = True
        CHK_4BEFlute.Enabled = True
        CHK_4BCFlute.Enabled = True
        CHK_4BBFlute.Enabled = True
        TXT_4CCheckSinglemm1.Enabled = True
        TXT_4CCheckSinglemm2.Enabled = True
        CHK_4DTopSheet.Enabled = True
        CHK_4DSingleFace.Enabled = True
        CHK_4DBottomSheet.Enabled = True
        TXT_4DBottomSheet.Enabled = True
        CHK_4EOperator.Enabled = True
        CHK_4EDrive.Enabled = True
        TXT_4FTarget.Enabled = True
        TXT_4FTargetActual.Enabled = True
        TXT_4GTarget.Enabled = True
        TXT_4GTargetActual.Enabled = True
        CHK_4HNoExcessGlue.Enabled = True
        CHK_4HNoWeakGlue.Enabled = True
        CHK_4JNoDownloadwarping.Enabled = True
        CHK_4JNoUpwardwarping.Enabled = True

        '7
        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True
        TXT_7Marker.Enabled = True
        BTN_Save_Supervisor.Enabled = True
    End Sub





    Private Sub BTN_Save_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Save_Supervisor.Click
        'FULL LINE CLearance variable A
        Dim FullFeederUnitTopSheet As String = ""
        Dim FullFeederUnitSingleFace As String = ""
        Dim FullGluingUnit As String = ""
        Dim FullGlueBin As String = ""
        Dim FullDeliveryUnit As String = ""
        Dim FullViewingTable As String = ""



        If CHK_FullFeederUnitTopSheet.Checked Then
            FullFeederUnitTopSheet = "O"
        Else
            FullFeederUnitTopSheet = "X"
        End If


        If CHK_FullFeederUnitSingleFace.Checked Then
            FullFeederUnitSingleFace = "O"
        Else
            FullFeederUnitSingleFace = "X"
        End If


        If CHK_FullGluingUnit.Checked Then
            FullGluingUnit = "O"
        Else
            FullGluingUnit = "X"
        End If


        If CHK_FullGlueBin.Checked Then
            FullGlueBin = "O"
        Else
            FullGlueBin = "X"
        End If


        If CHK_FullDeliveryUnit.Checked Then
            FullDeliveryUnit = "O"
        Else
            FullDeliveryUnit = "X"
        End If


        If CHK_FullViewingTable.Checked Then
            FullViewingTable = "O"
        Else
            FullViewingTable = "X"
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", "")
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", "")
                cmd.Parameters.AddWithValue("@flc_palletTag", "")
                cmd.Parameters.AddWithValue("@flc_feeder", "")
                cmd.Parameters.AddWithValue("@flc_delivery", "")
                cmd.Parameters.AddWithValue("@flc_drawers", "")
                cmd.Parameters.AddWithValue("@flc_inks", "")
                cmd.Parameters.AddWithValue("@flc_varnish", "")
                cmd.Parameters.AddWithValue("@flc_foil", "")
                cmd.Parameters.AddWithValue("@flc_supplies", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitTop", FullFeederUnitTopSheet)
                cmd.Parameters.AddWithValue("@flc_feederUnitSF", FullFeederUnitSingleFace)
                cmd.Parameters.AddWithValue("@flc_gluingUnit", FullGluingUnit)
                cmd.Parameters.AddWithValue("@flc_glueBin", FullGlueBin)
                cmd.Parameters.AddWithValue("@flc_DeliveryUnit", FullDeliveryUnit)
                cmd.Parameters.AddWithValue("@flc_viewingTable", FullViewingTable)
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
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", "")
                cmd.Parameters.AddWithValue("@flc_OffInkFr", "")
                cmd.Parameters.AddWithValue("@flc_OffInkTo", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilTo  ", "")

                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_FullBallpenQtyStartPC.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_FullBallpenQtyStartPC.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", "")
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", "")
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FullMarkerQtyStartPC.Text)
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", "")
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", "")
                cmd.Parameters.AddWithValue("@flc_palletTag", "")
                cmd.Parameters.AddWithValue("@flc_feeder", "")
                cmd.Parameters.AddWithValue("@flc_delivery", "")
                cmd.Parameters.AddWithValue("@flc_drawers", "")
                cmd.Parameters.AddWithValue("@flc_inks", "")
                cmd.Parameters.AddWithValue("@flc_varnish", "")
                cmd.Parameters.AddWithValue("@flc_foil", "")
                cmd.Parameters.AddWithValue("@flc_supplies", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitTop", FullFeederUnitTopSheet)
                cmd.Parameters.AddWithValue("@flc_feederUnitSF", FullFeederUnitSingleFace)
                cmd.Parameters.AddWithValue("@flc_gluingUnit", FullGluingUnit)
                cmd.Parameters.AddWithValue("@flc_glueBin", FullGlueBin)
                cmd.Parameters.AddWithValue("@flc_DeliveryUnit", FullDeliveryUnit)
                cmd.Parameters.AddWithValue("@flc_viewingTable", FullViewingTable)
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
                cmd.Parameters.AddWithValue("@flc_OffPaperFr", "")
                cmd.Parameters.AddWithValue("@flc_OffPaperTo", "")
                cmd.Parameters.AddWithValue("@flc_OffInkFr", "")
                cmd.Parameters.AddWithValue("@flc_OffInkTo", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshFr", "")
                cmd.Parameters.AddWithValue("@flc_OffVrnshTo", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilFr", "")
                cmd.Parameters.AddWithValue("@flc_OffFoilTo  ", "")

                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_FullBallpenQtyStartPC.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_FullRagsQtyStartPC.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", "")
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", "")
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FullMarkerQtyStartPC.Text)
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

        Dim GoodFeederTop As String = ""
        Dim GoodFeederSF As String = ""
        Dim GoodConveyor As String = ""
        Dim GoodTransportBelt As String = ""
        Dim GoodDelivery As String = ""


        Dim GoodProperlyTagged As String = ""
        Dim GoodPlasticPallets As String = ""
        Dim GoodFollowingStandardPall As String = ""


        Dim GoodWearHairCovers As String = ""
        Dim GoodWearProperlyTuckedIn As String = ""
        Dim GoodHandsWashed As String = ""


        Dim GoodTools As String = ""
        Dim GoodEquipment As String = ""
        Dim GoodCleaningMaterials As String = ""
        Dim GoodSafetyDevicesWorkingProperly As String = ""


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





        If CHK_GoodFeederTop.Checked Then
            GoodFeederTop = "O"
        Else
            GoodFeederTop = "X"
        End If


        If CHK_GoodFeederSF.Checked Then
            GoodFeederSF = "O"
        Else
            GoodFeederSF = "X"
        End If



        If CHK_GoodConveyor.Checked Then
            GoodConveyor = "O"
        Else
            GoodConveyor = "X"
        End If

        If CHK_GoodTransportBelt.Checked Then
            GoodConveyor = "O"
        Else
            GoodConveyor = "X"
        End If

        If CHK_GoodDelivery.Checked Then
            GoodTransportBelt = "O"
        Else
            GoodTransportBelt = "X"
        End If

        If CHK_GoodDelivery.Checked Then
            GoodDelivery = "O"
        Else
            GoodDelivery = "X"
        End If




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






        If CHK_GoodFollowingStandard.Checked Then
            GoodFollowingStandardPall = "O"
        Else
            GoodFollowingStandardPall = "X"
        End If



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
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", GoodTransportBelt)
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTop", GoodFeederTop)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederSF", GoodFeederSF)
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", GoodConveyor)
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", GoodDelivery)
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
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", "")
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
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", GoodTransportBelt)
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTop", GoodFeederTop)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederSF", GoodFeederSF)
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", GoodConveyor)
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", GoodDelivery)
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
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", "")
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
                cmd.Parameters.AddWithValue("@jic_AsstOper1", "")
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
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", "")
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
                cmd.Parameters.AddWithValue("@jic_AsstOper1", "")
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
                cmd.Parameters.AddWithValue("@jic_AsstOper1Time", "")
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










        'INSERTING TO Machine Set-up / Product Approval
        Dim AVertical As String = ""
        Dim AHorizontal As String = ""



        If CHK_4AVertical.Checked Then
            AVertical = "O"
        Else
            AVertical = "X"
        End If

        If CHK_4AHorizontal.Checked Then
            AHorizontal = "O"
        Else
            AHorizontal = "X"
        End If



        Dim BEFlute As String = ""
        Dim BCFlute As String = ""
        Dim BBFlute As String = ""


        If CHK_4BEFlute.Checked Then
            BEFlute = "O"
        Else
            BEFlute = "X"
        End If


        If CHK_4BCFlute.Checked Then
            BCFlute = "O"
        Else
            BCFlute = "X"
        End If


        If CHK_4BBFlute.Checked Then
            BBFlute = "O"
        Else
            BBFlute = "X"
        End If




        Dim CCheckSinglemm1Decimal As Double
        Dim CCheckSinglemm2Decimal As Double


        Double.TryParse(TXT_4CCheckSinglemm1.Text, CCheckSinglemm1Decimal)
        Double.TryParse(TXT_4CCheckSinglemm2.Text, CCheckSinglemm2Decimal)







        Dim DTopSheet As String = ""
        Dim DSingleFace As String = ""
        Dim DBottomSheet As String = ""
        Dim DBottomSheetDecimal As Double



        Double.TryParse(TXT_4DBottomSheet.Text, DBottomSheetDecimal)


        If CHK_4DTopSheet.Checked Then
            DTopSheet = "O"
        Else
            DTopSheet = "X"
        End If



        If CHK_4DSingleFace.Checked Then
            DSingleFace = "O"
        Else
            DSingleFace = "X"
        End If



        If CHK_4DBottomSheet.Checked Then
            DBottomSheet = "O"
        Else
            DBottomSheet = "X"
        End If






        Dim EOperator As String = ""
        Dim EDrive As String = ""



        If CHK_4EOperator.Checked Then
            EOperator = "O"
        Else
            EOperator = "X"
        End If



        If CHK_4EDrive.Checked Then
            EDrive = "O"
        Else
            EDrive = "X"
        End If





        'F
        Dim FTargetDecimal As Double
        Dim FTargetActual As Double

        Double.TryParse(TXT_4FTarget.Text, FTargetDecimal)
        Double.TryParse(TXT_4FTargetActual.Text, FTargetActual)

        'G
        Dim GTargetDecimal As Double
        Dim GTargetActualDecimal As Double

        Double.TryParse(TXT_4GTarget.Text, GTargetDecimal)
        Double.TryParse(TXT_4GTargetActual.Text, GTargetActualDecimal)


        'H


        Dim HNoExcessGlue As String = ""
        Dim HNoWeakGlue As String = ""


        If CHK_4HNoExcessGlue.Checked Then
            HNoExcessGlue = "O"
        Else
            HNoExcessGlue = "X"
        End If

        If CHK_4HNoWeakGlue.Checked Then
            HNoWeakGlue = "O"
        Else
            HNoWeakGlue = "X"
        End If


        'J

        Dim JNoDownloadwarping As String = ""
        Dim JNoUpwardwarping As String = ""


        If CHK_4JNoDownloadwarping.Checked Then
            JNoDownloadwarping = "O"
        Else
            JNoDownloadwarping = "X"
        End If

        If CHK_4JNoUpwardwarping.Checked Then
            JNoUpwardwarping = "O"
        Else
            JNoUpwardwarping = "X"
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
                cmd.Parameters.AddWithValue("@mspa_LAFluteVert", AVertical)
                cmd.Parameters.AddWithValue("@mspa_LAFluteHor", AHorizontal)
                cmd.Parameters.AddWithValue("@mspa_LAEFlute", BEFlute)
                cmd.Parameters.AddWithValue("@mspa_LACFlute", BCFlute)
                cmd.Parameters.AddWithValue("@mspa_LABFlute", BBFlute)
                cmd.Parameters.AddWithValue("@mspa_LASFBdim1", CCheckSinglemm1Decimal)
                cmd.Parameters.AddWithValue("@mspa_LASFBdim2", CCheckSinglemm2Decimal)
                cmd.Parameters.AddWithValue("@mspa_LAFGTopsh", DTopSheet)
                cmd.Parameters.AddWithValue("@mspa_LAFGSF", DSingleFace)
                cmd.Parameters.AddWithValue("@mspa_LAFGBottsh", DBottomSheet)
                cmd.Parameters.AddWithValue("@mspa_LAFGBottshs", DBottomSheetDecimal)
                cmd.Parameters.AddWithValue("@mspa_LASGOper", EOperator)
                cmd.Parameters.AddWithValue("@mspa_LASGDrive", EDrive)
                cmd.Parameters.AddWithValue("@mspa_LAThickTar", FTargetDecimal)
                cmd.Parameters.AddWithValue("@mspa_LAThickAct", FTargetActual)
                cmd.Parameters.AddWithValue("@mspa_LAMoistTar", GTargetDecimal)
                cmd.Parameters.AddWithValue("@mspa_LAMoistAct", GTargetActualDecimal)
                cmd.Parameters.AddWithValue("@mspa_LANoExcGlu", HNoExcessGlue)
                cmd.Parameters.AddWithValue("@mspa_LANoWkGlu", HNoWeakGlue)
                cmd.Parameters.AddWithValue("@mspa_LANoDWarp", JNoDownloadwarping)
                cmd.Parameters.AddWithValue("@mspa_LANoUWarp", JNoUpwardwarping)
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
                cmd.Parameters.AddWithValue("@mspa_LAFluteVert", AVertical)
                cmd.Parameters.AddWithValue("@mspa_LAFluteHor", AHorizontal)
                cmd.Parameters.AddWithValue("@mspa_LAEFlute", BEFlute)
                cmd.Parameters.AddWithValue("@mspa_LACFlute", BCFlute)
                cmd.Parameters.AddWithValue("@mspa_LABFlute", BBFlute)
                cmd.Parameters.AddWithValue("@mspa_LASFBdim1", CCheckSinglemm1Decimal)
                cmd.Parameters.AddWithValue("@mspa_LASFBdim2", CCheckSinglemm2Decimal)
                cmd.Parameters.AddWithValue("@mspa_LAFGTopsh", DTopSheet)
                cmd.Parameters.AddWithValue("@mspa_LAFGSF", DSingleFace)
                cmd.Parameters.AddWithValue("@mspa_LAFGBottsh", DBottomSheet)
                cmd.Parameters.AddWithValue("@mspa_LAFGBottshs", DBottomSheetDecimal)
                cmd.Parameters.AddWithValue("@mspa_LASGOper", EOperator)
                cmd.Parameters.AddWithValue("@mspa_LASGDrive", EDrive)
                cmd.Parameters.AddWithValue("@mspa_LAThickTar", FTargetDecimal)
                cmd.Parameters.AddWithValue("@mspa_LAThickAct", FTargetActual)
                cmd.Parameters.AddWithValue("@mspa_LAMoistTar", GTargetDecimal)
                cmd.Parameters.AddWithValue("@mspa_LAMoistAct", GTargetActualDecimal)
                cmd.Parameters.AddWithValue("@mspa_LANoExcGlu", HNoExcessGlue)
                cmd.Parameters.AddWithValue("@mspa_LANoWkGlu", HNoWeakGlue)
                cmd.Parameters.AddWithValue("@mspa_LANoDWarp", JNoDownloadwarping)
                cmd.Parameters.AddWithValue("@mspa_LANoUWarp", JNoUpwardwarping)
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





        MsgBox("Successfully save!")
        Dim i As Integer
        For i = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        Dim UC_SupervisorLam As New UC_SupervisorLamination
        UC_SupervisorLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorLam.Show()
        UC_SupervisorLam.Dock = DockStyle.Fill






    End Sub
    Private Sub SelectAllEnableCheck()
        CHK_SelectAll.Checked = True

        'FULL A
        CHK_FullFeederUnitTopSheet.Checked = True
        CHK_FullFeederUnitSingleFace.Checked = True
        CHK_FullGluingUnit.Checked = True
        CHK_FullGlueBin.Checked = True
        CHK_FullDeliveryUnit.Checked = True
        CHK_FullViewingTable.Checked = True

        'GMPA
        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodOilChemical.Checked = True
        CHK_GoodForeignMaterials.Checked = True

        'GMPB
        CHK_GoodFeederTop.Checked = True
        CHK_GoodFeederSF.Checked = True
        CHK_GoodConveyor.Checked = True
        CHK_GoodTransportBelt.Checked = True
        CHK_GoodDelivery.Checked = True

        'GMPC
        CHK_GoodProperlyTagged.Checked = True
        CHK_GoodPlasticPalltes.Checked = True
        CHK_GoodFollowingStandard.Checked = True

        'GMPD
        CHK_GoodWearHair.Checked = True
        CHk_GoodWearsProperlyTucked.Checked = True
        CHk_GoodHandsWashed.Checked = True

        'GMPE
        CHK_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaningMaterials.Checked = True
        CHK_GoodSafetyDevice.Checked = True

        '4.
        CHK_4AVertical.Checked = True
        CHK_4AHorizontal.Checked = True
        CHK_4BEFlute.Checked = True
        CHK_4BCFlute.Checked = True
        CHK_4BBFlute.Checked = True
        CHK_4DTopSheet.Checked = True
        CHK_4DSingleFace.Checked = True
        CHK_4DBottomSheet.Checked = True
        CHK_4EOperator.Checked = True
        CHK_4EDrive.Checked = True
        CHK_4HNoExcessGlue.Checked = True
        CHK_4HNoWeakGlue.Checked = True
        CHK_4JNoDownloadwarping.Checked = True
        CHK_4JNoUpwardwarping.Checked = True

    End Sub



    Private Sub SelectAllDisabledCheck()
        CHK_SelectAll.Checked = False

        'FULL A
        CHK_FullFeederUnitTopSheet.Checked = False
        CHK_FullFeederUnitSingleFace.Checked = False
        CHK_FullGluingUnit.Checked = False
        CHK_FullGlueBin.Checked = False
        CHK_FullDeliveryUnit.Checked = False
        CHK_FullViewingTable.Checked = False

        'GMPA
        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False

        'GMPB
        CHK_GoodFeederTop.Checked = False
        CHK_GoodFeederSF.Checked = False
        CHK_GoodConveyor.Checked = False
        CHK_GoodTransportBelt.Checked = False
        CHK_GoodDelivery.Checked = False

        'GMPC
        CHK_GoodProperlyTagged.Checked = False
        CHK_GoodPlasticPalltes.Checked = False
        CHK_GoodFollowingStandard.Checked = False

        'GMPD
        CHK_GoodWearHair.Checked = False
        CHk_GoodWearsProperlyTucked.Checked = False
        CHk_GoodHandsWashed.Checked = False

        'GMPE
        CHK_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaningMaterials.Checked = False
        CHK_GoodSafetyDevice.Checked = False

        '4.
        CHK_4AVertical.Checked = False
        CHK_4AHorizontal.Checked = False
        CHK_4BEFlute.Checked = False
        CHK_4BCFlute.Checked = False
        CHK_4BBFlute.Checked = False
        CHK_4DTopSheet.Checked = False
        CHK_4DSingleFace.Checked = False
        CHK_4DBottomSheet.Checked = False
        CHK_4EOperator.Checked = False
        CHK_4EDrive.Checked = False
        CHK_4HNoExcessGlue.Checked = False
        CHK_4HNoWeakGlue.Checked = False
        CHK_4JNoDownloadwarping.Checked = False
        CHK_4JNoUpwardwarping.Checked = False
    End Sub



    Private Sub UC_SupervisorLamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTPOperator.Format = DateTimePickerFormat.Custom
        DTPOperator.CustomFormat = "hh:mm tt"


        DTPHelper1.Format = DateTimePickerFormat.Custom
        DTPHelper1.CustomFormat = "hh:mm tt"


        DTPOperator.Text = "12:00 AM"
        DTPHelper1.Text = "12:00 AM"


        ' Optional: Set value to default time when no time is selected
        If DTPOperator.Value = DTPOperator.MinDate Then
            DTPOperator.Text = "12:00 AM"
        End If
        If DTPHelper1.Value = DTPHelper1.MinDate Then
            DTPHelper1.Text = "12:00 AM"
        End If

        If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then
            DisabledSupervisorForm()
        Else
            EnabledSupervisorForm()
        End If



        If position <> "Supervisor" Then
            CHK_SelectAll.Visible = False
            BTN_Save_Supervisor.Visible = False
            BTN_Back.Visible = False
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

                    If dr("flc_feederUnitTop").ToString() = "O" Then
                        CHK_FullFeederUnitTopSheet.Checked = True
                    Else
                        CHK_FullFeederUnitTopSheet.Checked = False

                    End If

                    If dr("flc_feederUnitSF").ToString() = "O" Then
                        CHK_FullFeederUnitSingleFace.Checked = True
                    Else
                        CHK_FullFeederUnitSingleFace.Checked = False
                    End If



                    If dr("flc_gluingUnit").ToString() = "O" Then
                        CHK_FullGluingUnit.Checked = True
                    Else
                        CHK_FullGluingUnit.Checked = False
                    End If

                    If dr("flc_glueBin").ToString() = "O" Then
                        CHK_FullGlueBin.Checked = True
                    Else
                        CHK_FullGlueBin.Checked = False
                    End If


                    If dr("flc_DeliveryUnit").ToString() = "O" Then
                        CHK_FullDeliveryUnit.Checked = True
                    Else
                        CHK_FullDeliveryUnit.Checked = False
                    End If


                    If dr("flc_viewingTable").ToString() = "O" Then
                        CHK_FullViewingTable.Checked = True
                    Else
                        CHK_FullViewingTable.Checked = False
                    End If


                    TXT_FullBallpenQtyStartPC.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_FullRagsQtyStartPC.Text = dr("flc_OLCragqty").ToString()
                    TXT_FullMarkerQtyStartPC.Text = dr("flc_OLCmarkerqty").ToString()


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





                    If dr("gmp_SaniFeederTop").ToString() = "O" Then
                        CHK_GoodFeederTop.Checked = True
                    Else
                        CHK_GoodFeederTop.Checked = False
                    End If


                    If dr("gmp_SaniFeederSF").ToString() = "O" Then
                        CHK_GoodFeederSF.Checked = True
                    Else
                        CHK_GoodFeederSF.Checked = False
                    End If




                    If dr("gmp_SaniConveyor").ToString() = "O" Then
                        CHK_GoodConveyor.Checked = True
                    Else
                        CHK_GoodConveyor.Checked = False
                    End If



                    If dr("gmp_SaniTransportBelt").ToString() = "O" Then
                        CHK_GoodTransportBelt.Checked = True
                    Else
                        CHK_GoodTransportBelt.Checked = False
                    End If

                    If dr("gmp_SaniDelivery").ToString() = "O" Then
                        CHK_GoodDelivery.Checked = True
                    Else
                        CHK_GoodDelivery.Checked = False
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








        TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text

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
                    helper1 = dr("jic_Helper1").ToString()





                    TXT_Helper1.Text = helper1


                    DTPOperator.Text = dr("jic_OperatorTime").ToString()
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
            cmd.CommandText = "Select Name FROM Employee WHERE Emp_num = @emp_num"
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


                    'TXT_Dimension1.Text = dr("mspa_CUChkDim1").ToString
                    'TXT_Dimension2.Text = dr("mspa_CUChkDim2").ToString


                    If dr("mspa_LAFluteVert").ToString() = "O" Then
                        CHK_4AVertical.Checked = True
                    Else
                        CHK_4AVertical.Checked = False
                    End If



                    If dr("mspa_LAFluteHor").ToString() = "O" Then
                        CHK_4AHorizontal.Checked = True
                    Else
                        CHK_4AHorizontal.Checked = False
                    End If

                    If dr("mspa_LAEFlute").ToString() = "O" Then
                        CHK_4BEFlute.Checked = True
                    Else
                        CHK_4BEFlute.Checked = False
                    End If


                    If dr("mspa_LACFlute").ToString() = "O" Then
                        CHK_4BCFlute.Checked = True
                    Else
                        CHK_4BCFlute.Checked = False
                    End If


                    If dr("mspa_LABFlute").ToString() = "O" Then
                        CHK_4BBFlute.Checked = True
                    Else
                        CHK_4BBFlute.Checked = False
                    End If

                    TXT_4CCheckSinglemm1.Text = dr("mspa_LASFBdim1").ToString()
                    TXT_4CCheckSinglemm2.Text = dr("mspa_LASFBdim2").ToString()




                    If dr("mspa_LAFGTopsh").ToString() = "O" Then
                        CHK_4DTopSheet.Checked = True
                    Else
                        CHK_4DTopSheet.Checked = False
                    End If


                    If dr("mspa_LAFGSF").ToString() = "O" Then
                        CHK_4DSingleFace.Checked = True
                    Else
                        CHK_4DSingleFace.Checked = False
                    End If


                    If dr("mspa_LAFGBottsh").ToString() = "O" Then
                        CHK_4DBottomSheet.Checked = True
                    Else
                        CHK_4DBottomSheet.Checked = False
                    End If

                    TXT_4DBottomSheet.Text = dr("mspa_LAFGBottshs").ToString()


                    If dr("mspa_LASGOper").ToString() = "O" Then
                        CHK_4EOperator.Checked = True
                    Else
                        CHK_4EOperator.Checked = False
                    End If


                    If dr("mspa_LASGDrive").ToString() = "O" Then
                        CHK_4EDrive.Checked = True
                    Else
                        CHK_4EDrive.Checked = False
                    End If


                    'F
                    TXT_4FTarget.Text = dr("mspa_LAThickTar").ToString()
                    TXT_4FTargetActual.Text = dr("mspa_LAThickAct").ToString()


                    'G
                    TXT_4GTarget.Text = dr("mspa_LAMoistTar").ToString()
                    TXT_4GTargetActual.Text = dr("mspa_LAMoistAct").ToString()

                    'H
                    If dr("mspa_LANoExcGlu").ToString() = "O" Then
                        CHK_4HNoExcessGlue.Checked = True
                    Else
                        CHK_4HNoExcessGlue.Checked = False
                    End If


                    If dr("mspa_LANoWkGlu").ToString() = "O" Then
                        CHK_4HNoWeakGlue.Checked = True
                    Else
                        CHK_4HNoWeakGlue.Checked = False
                    End If

                    'I
                    If dr("mspa_LANoDWarp").ToString() = "O" Then
                        CHK_4JNoDownloadwarping.Checked = True
                    Else
                        CHK_4JNoDownloadwarping.Checked = False
                    End If



                    If dr("mspa_LANoUWarp").ToString() = "O" Then
                        CHK_4JNoUpwardwarping.Checked = True
                    Else
                        CHK_4JNoUpwardwarping.Checked = False
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
            SelectAllEnableCheck()
        Else
            SelectAllDisabledCheck()
        End If
    End Sub



    Private Sub TXT_FullBallpenQtyStartPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullBallpenQtyStartPC.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_FullRagsQtyStartPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullRagsQtyStartPC.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_FullMarkerQtyStartPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullMarkerQtyStartPC.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_7BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7BallpenQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_7RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7RagsQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_7Marker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7Marker.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub CBO_Helper1_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper1.DropDown
        CBO_Helper1.Items.Clear()
        load_helper1()
    End Sub

    Private Sub CBO_Helper1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged
        con.Close()

        load_helper_empnum1()
    End Sub


    Private Sub load_helper1()
        Dim cmd_select_helper As New SqlCommand("Select Name, Emp_num, Emp_num + ' - ' + Name as Emp_num_helper FROM Employee WHERE Position = 'Helper' ORDER BY NAME", con)

        Try
            con.Open()
            Dim read_cmd_select_helper As SqlDataReader = cmd_select_helper.ExecuteReader
            While read_cmd_select_helper.Read
                CBO_Helper1.Items.Add(read_cmd_select_helper("Emp_num_helper"))
            End While
            read_cmd_select_helper.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub load_helper_empnum1()

        Try
            OpenConnection()
            cmd.CommandText = " Select Name, Emp_num, Emp_num + ' - ' + Name as Emp_num_helper FROM Employee WHERE Position = 'Helper' and (Emp_num + ' - ' + Name) = @helperempnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@helperempnum", CBO_Helper1.Text)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Dim helper_empname As String = dr("Name")
                CBO_Helper1.Items.Add(helper_empname)
                TXT_Helper1.Text = dr("Emp_num").ToString()
                CBO_Helper1.Text = dr("Name").ToString()
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




    Private Sub TXT_4CCheckSinglemm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4CCheckSinglemm1.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_4CCheckSinglemm2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4CCheckSinglemm2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_4DBottomSheet_TextChanged(sender As Object, e As EventArgs) Handles TXT_4DBottomSheet.TextChanged

    End Sub

    Private Sub TXT_4DBottomSheet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4DBottomSheet.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_4FTarget_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4FTarget.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_4FTargetActual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4FTargetActual.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_4GTarget_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4GTarget.KeyPress
        NumberChar(e)
    End Sub


    Private Sub TXT_4GTargetActual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_4GTargetActual.KeyPress
        NumberChar(e)
    End Sub


End Class
