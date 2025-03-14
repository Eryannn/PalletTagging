
Imports System.Data.SqlClient



Public Class UC_SupervisorDIeCutting
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


    Private Sub BTN_Save_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Save_Supervisor.Click
        'FULL LINE CLearance variable
        Dim FullFeeder As String = ""
        Dim FullStripping As String = ""
        Dim FullDelivery As String = ""
        Dim FullWasteBin As String = ""
        Dim FullViewingTable As String = ""


        'FULL LINE A
        If CHK_FullFeeder.Checked Then
            FullFeeder = "O"
        Else
            FullFeeder = "X"
        End If


        If CHK_FullStripping.Checked Then
            FullStripping = "O"
        Else
            FullStripping = "X"
        End If


        If CHK_FullDelivery.Checked Then
            FullDelivery = "O"
        Else
            FullDelivery = "X"
        End If


        If CHK_FullWasteBin.Checked Then
            FullWasteBin = "O"
        Else
            FullWasteBin = "X"
        End If


        If CHK_FullViewingTable.Checked Then
            FullViewingTable = "O"
        Else
            FullViewingTable = "X"
        End If


        'FULL LINE B
        Dim FullDieCuteBlade As String = ""
        Dim FullCounterDie As String = ""
        Dim FullEmbossingCliche As String = ""
        Dim FullCounterEmbossing As String = ""
        Dim FullStrippingBoard As String = ""
        Dim FullStrippingPins As String = ""
        Dim FullStampingCliche As String = ""
        Dim FullCounterStamping As String = ""
        Dim FullStampingFoil As String = ""


        If CHK_FullDieCutBlade.Checked Then
            FullDieCuteBlade = "O"
        Else
            FullDieCuteBlade = "X"
        End If


        If CHK_FullCounterDie.Checked Then
            FullCounterDie = "O"
        Else
            FullCounterDie = "X"
        End If

        If CHK_FullEmbossingCliche.Checked Then
            FullEmbossingCliche = "O"
        Else
            FullEmbossingCliche = "X"
        End If

        If CHK_FullCounterEmbossing.Checked Then
            FullCounterEmbossing = "O"
        Else
            FullCounterEmbossing = "X"
        End If

        If CHK_FullStrippingBoard.Checked Then
            FullStrippingBoard = "O"
        Else
            FullStrippingBoard = "X"
        End If


        If CHK_FullStrippingPins.Checked Then
            FullStrippingPins = "O"
        Else
            FullStrippingPins = "X"
        End If


        If CHK_FullStampingCliche.Checked Then
            FullStampingCliche = "O"
        Else
            FullStampingCliche = "X"
        End If


        If CHK_FullCounterStamping.Checked Then
            FullCounterStamping = "O"
        Else
            FullCounterStamping = "X"
        End If


        If CHK_FullStampingFoil.Checked Then
            FullStampingFoil = "O"
        Else
            FullStampingFoil = "X"
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBin)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", "")
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
                cmd.Parameters.AddWithValue("@flc_viewingTable", FullViewingTable)
                cmd.Parameters.AddWithValue("@flc_stripping", FullStripping)
                cmd.Parameters.AddWithValue("@flc_diecutBlade", FullDieCuteBlade)
                cmd.Parameters.AddWithValue("@flc_counterdie", FullCounterDie)
                cmd.Parameters.AddWithValue("@flc_embossingCliche", FullEmbossingCliche)
                cmd.Parameters.AddWithValue("@flc_counterEmbossing", FullCounterEmbossing)
                cmd.Parameters.AddWithValue("@flc_strippingBoard", FullStrippingBoard)
                cmd.Parameters.AddWithValue("@flc_strippingPins", FullStrippingPins)
                cmd.Parameters.AddWithValue("@flc_stampingCliche", FullStampingCliche)
                cmd.Parameters.AddWithValue("@flc_counterStamping", FullCounterStamping)
                cmd.Parameters.AddWithValue("@flc_stampingFoil", FullStampingFoil)
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
                cmd.Parameters.AddWithValue("@flc_OffFoilTo", "")


                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_BallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_RagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", TXT_StrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", TXT_StrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FLCMarterQty.Text)
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
                cmd.Parameters.AddWithValue("@flc_wasteBin", FullWasteBin)
                cmd.Parameters.AddWithValue("@flc_pallets", "")
                cmd.Parameters.AddWithValue("@flc_joggerTable", "")
                cmd.Parameters.AddWithValue("@flc_sticker", "")
                cmd.Parameters.AddWithValue("@flc_kraftPaper", "")
                cmd.Parameters.AddWithValue("@flc_corrugatedBox", "")
                cmd.Parameters.AddWithValue("@flc_cutLabel", "")
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
                cmd.Parameters.AddWithValue("@flc_viewingTable", FullViewingTable)
                cmd.Parameters.AddWithValue("@flc_stripping", FullStripping)
                cmd.Parameters.AddWithValue("@flc_diecutBlade", FullDieCuteBlade)
                cmd.Parameters.AddWithValue("@flc_counterdie", FullCounterDie)
                cmd.Parameters.AddWithValue("@flc_embossingCliche", FullEmbossingCliche)
                cmd.Parameters.AddWithValue("@flc_counterEmbossing", FullCounterEmbossing)
                cmd.Parameters.AddWithValue("@flc_strippingBoard", FullStrippingBoard)
                cmd.Parameters.AddWithValue("@flc_strippingPins", FullStrippingPins)
                cmd.Parameters.AddWithValue("@flc_stampingCliche", FullStampingCliche)
                cmd.Parameters.AddWithValue("@flc_counterStamping", FullCounterStamping)
                cmd.Parameters.AddWithValue("@flc_stampingFoil", FullStampingFoil)
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

                cmd.Parameters.AddWithValue("@flc_OLCbpenqty", TXT_BallpenQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCragqty", TXT_RagsQty.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripknife", TXT_StrippingKnifeQty1.Text)
                cmd.Parameters.AddWithValue("@flc_OLCstripbld", TXT_StrippingKnifeQty2.Text)
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FLCMarterQty.Text)
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





        'INSERTING TO GMP A
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






        'INSERTING TO GMP B
        Dim GoodRubberSucker As String = ""
        Dim GoodFeederTable As String = ""
        Dim GoodInspectionTable As String = ""
        Dim GoodPlasticPallets As String = ""



        If CHK_GoodRubberSuckers.Checked Then
            GoodRubberSucker = "O"
        Else
            GoodRubberSucker = "X"
        End If


        If CHK_GoodFeederTable.Checked Then
            GoodFeederTable = "O"
        Else
            GoodFeederTable = "X"
        End If


        If CHK_GoodInspectionTable.Checked Then
            GoodInspectionTable = "O"
        Else
            GoodInspectionTable = "X"
        End If


        If CHK_GoodPlasticPallets.Checked Then
            GoodPlasticPallets = "O"
        Else
            GoodPlasticPallets = "X"
        End If



        'INSERTING TO GMP C
        Dim GoodProperlyTagged As String = ""
        Dim GoodInPlasticPallets As String = ""
        Dim GoodWith20Wall As String = ""
        Dim GoodFollowingStandardPall As String = ""

        If CHK_GoodProperlyTagged.Checked Then
            GoodProperlyTagged = "O"
        Else
            GoodProperlyTagged = "X"
        End If

        If CHK_CGoodInPlasticPalltes.Checked Then
            GoodInPlasticPallets = "O"
        Else
            GoodInPlasticPallets = "X"
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


        'INSERTING TO GMP D
        Dim GoodWearProperlyTuckedIn As String = ""
        Dim GoodHandsWashed As String = ""

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


        'INSERTING TO GMP E
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
                cmd.Parameters.AddWithValue("@gmp_SaniJoggerTable", "")

                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTable", "")



                cmd.Parameters.AddWithValue("@gmp_SaniCuttingBlade", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCuttingTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniControlPanel", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRubberSucker", GoodRubberSucker)
                cmd.Parameters.AddWithValue("@gmp_SaniPaperSep", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGovfoot", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTable", GoodFeederTable)
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", "")
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", GoodPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTop", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederSF", "")
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", GoodInspectionTable)
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
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20Wall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPall)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", "")
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
                cmd.Parameters.AddWithValue("@gmp_SaniCuttingBlade", "")


                cmd.Parameters.AddWithValue("@gmp_SaniFeederbridge", "")
                cmd.Parameters.AddWithValue("@gmp_SaniStacker", "")
                cmd.Parameters.AddWithValue("@gmp_SaniProoftray", "")
                cmd.Parameters.AddWithValue("@gmp_SaniTable", "")



                cmd.Parameters.AddWithValue("@gmp_SaniCuttingTable", "")
                cmd.Parameters.AddWithValue("@gmp_SaniControlPanel", "")
                cmd.Parameters.AddWithValue("@gmp_SaniRubberSucker", GoodRubberSucker)
                cmd.Parameters.AddWithValue("@gmp_SaniPaperSep", "")
                cmd.Parameters.AddWithValue("@gmp_SaniGovfoot", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTable", GoodFeederTable)
                cmd.Parameters.AddWithValue("@gmp_SaniTransportBelt", "")
                cmd.Parameters.AddWithValue("@gmp_SaniImpCylinder", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelRakeBrd", "")
                cmd.Parameters.AddWithValue("@gmp_SaniCtrlConsoleTbl", "")
                cmd.Parameters.AddWithValue("@gmp_SaniPlasticPallet", GoodPlasticPallets)
                cmd.Parameters.AddWithValue("@gmp_SaniFeederTop", "")
                cmd.Parameters.AddWithValue("@gmp_SaniFeederSF", "")
                cmd.Parameters.AddWithValue("@gmp_SaniConveyor", "")
                cmd.Parameters.AddWithValue("@gmp_SaniDelivery", "")
                cmd.Parameters.AddWithValue("@gmp_SaniInspTable", GoodInspectionTable)
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
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", GoodWith20Wall)
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPall)
                cmd.Parameters.AddWithValue("@gmp_HygWearHairCovr", "")
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
                cmd.Parameters.AddWithValue("@jic_Helper2Time", DTPHelper2.Text)
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
                cmd.Parameters.AddWithValue("@jic_Helper2", TXT_Helper2.Text)
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
                cmd.Parameters.AddWithValue("@jic_Helper2Time", DTPHelper2.Text)
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











        '4. Machine Set-up / Prodcut approval

        'A INSERTING DIE CUTTING
        Dim ACorrectDieCut As String = ""
        Dim ACorrectDieCutBlade As String = ""
        Dim ABoxFunctionalityLockingSystem As String = ""
        Dim ACutEdgesAndScoreSurface As String = ""

        If CHK_MachineCorDiecutCode.Checked Then
            ACorrectDieCut = "O"
        Else
            ACorrectDieCut = "X"
        End If

        If CHK_MachineCorDiecutBlade.Checked Then
            ACorrectDieCutBlade = "O"
        Else
            ACorrectDieCutBlade = "X"
        End If

        If CHK_MachineBox.Checked Then
            ABoxFunctionalityLockingSystem = "O"
        Else
            ABoxFunctionalityLockingSystem = "X"
        End If

        If CHK_MachineCutEdges.Checked Then
            ACutEdgesAndScoreSurface = "O"
        Else
            ACutEdgesAndScoreSurface = "X"
        End If



        'B INSERTING DIE CUTTING
        Dim BCorrectUseOfStripping As String = ""
        Dim BCorrectWasteKnife As String = ""
        Dim BCorrectPinsAndBars As String = ""


        If CHK_MachineCorUseStripping.Checked Then
            BCorrectUseOfStripping = "O"
        Else
            BCorrectUseOfStripping = "X"
        End If


        If CHK_MachineCorWasteKnife.Checked Then
            BCorrectWasteKnife = "O"
        Else
            BCorrectWasteKnife = "X"
        End If

        If CHK_MachineCorPinsBars.Checked Then
            BCorrectPinsAndBars = "O"
        Else
            BCorrectPinsAndBars = "X"
        End If


        'C INSERTING DIE CUTTING
        Dim CEmbossingClicheVsFilm As String = ""
        Dim CClicheHeight As String = ""
        Dim CEmbossingOutput As String = ""


        If CHK_MachineEmbossingClicheVsFilm.Checked Then
            CEmbossingClicheVsFilm = "O"
        Else
            CEmbossingClicheVsFilm = "X"
        End If

        If CHK_MachineClicheHeight.Checked Then
            CClicheHeight = "O"
        Else
            CClicheHeight = "X"
        End If

        If CHK_MachineEmbossingOutput.Checked Then
            CEmbossingOutput = "O"
        Else
            CEmbossingOutput = "X"
        End If


        'D INSERTING DIE CUTTING
        Dim DStampingIssuedCliche As String = ""
        Dim DClicheHeight7mm As String = ""
        Dim DStampingOutput As String = ""
        Dim DFoilColorSize As String = ""
        Dim DHeaterTemp As String = ""


        If CHK_MachineStampingIssuedCliche.Checked Then
            DStampingIssuedCliche = "O"
        Else
            DStampingIssuedCliche = "X"
        End If

        If CHK_MachineClicheHeight7mm.Checked Then
            DClicheHeight7mm = "O"
        Else
            DClicheHeight7mm = "X"
        End If

        If CHK_MachineStampingOutput.Checked Then
            DStampingOutput = "O"
        Else
            DStampingOutput = "X"
        End If


        If CHK_MachineFoilColorSize.Checked Then
            DFoilColorSize = "O"
        Else
            DFoilColorSize = "X"
        End If

        If CHK_MachineHeaterTemp.Checked Then
            DHeaterTemp = "O"
        Else
            DHeaterTemp = "X"
        End If



        Dim ClicheHeight5mmDecimal As Double
        Dim CounterStampingThickDecimal As Double
        Dim MachineClicheHeightDecimal As Double
        Dim MachineCounterStampingDecimal As Double
        Dim MachineHeaterTempDecimal As Double

        Dim ScorebendRatioDecimal As Double

        Dim PunchingPressureDecimal As Double
        Dim MachineSubstrateThicknessDecimal As Double


        Double.TryParse(TXT_CClicheHeight5mm.Text, ClicheHeight5mmDecimal)
        Double.TryParse(TXT_CounterStampingThick.Text, CounterStampingThickDecimal)
        Double.TryParse(TXT_MachineClicheHeight.Text, MachineClicheHeightDecimal)
        Double.TryParse(TXT_MachineCounterStamping.Text, MachineCounterStampingDecimal)
        Double.TryParse(TXT_MachineHeaterTemp.Text, MachineHeaterTempDecimal)


        Double.TryParse(TXT_ScorebendRatio.Text, ScorebendRatioDecimal)
        Double.TryParse(TXT_PunchingPressure.Text, PunchingPressureDecimal)
        Double.TryParse(TXT_MachineSubstrateThickness.Text, MachineSubstrateThicknessDecimal)



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
                cmd.Parameters.AddWithValue("@mspa_Dcorrdiecut", ACorrectDieCut)
                cmd.Parameters.AddWithValue("@mspa_Ddiecutcode", TXT_CorrectDiecutCode.Text)
                cmd.Parameters.AddWithValue("@mspa_Dcorrdcblade", ACorrectDieCutBlade)
                cmd.Parameters.AddWithValue("@mspa_Dbxfuncnlock", ABoxFunctionalityLockingSystem)
                cmd.Parameters.AddWithValue("@mspa_Dcutedge", ACutEdgesAndScoreSurface)
                cmd.Parameters.AddWithValue("@mspa_DEmbcliche", CEmbossingClicheVsFilm)
                cmd.Parameters.AddWithValue("@mspa_DEclicht5mm", CClicheHeight)
                cmd.Parameters.AddWithValue("@mspa_DEclichht", ClicheHeight5mmDecimal)
                cmd.Parameters.AddWithValue("@mspa_DEmboutput", CEmbossingOutput)
                cmd.Parameters.AddWithValue("@mspa_DcountrEmbTh", CounterStampingThickDecimal)
                cmd.Parameters.AddWithValue("@mspa_DCorrStripBrd", BCorrectUseOfStripping)
                cmd.Parameters.AddWithValue("@mspa_DCorrWknife", BCorrectWasteKnife)
                cmd.Parameters.AddWithValue("@mspa_DCorrpinbarPos", BCorrectPinsAndBars)
                cmd.Parameters.AddWithValue("@mspa_DStmpclichvsfilm", DStampingIssuedCliche)
                cmd.Parameters.AddWithValue("@mspa_DStClichHt7mm", DClicheHeight7mm)
                cmd.Parameters.AddWithValue("@mspa_DStClichHt", MachineClicheHeightDecimal)
                cmd.Parameters.AddWithValue("@mspa_DStmpingOutput", DStampingOutput)
                cmd.Parameters.AddWithValue("@mspa_DcountrStmpTh", MachineCounterStampingDecimal)
                cmd.Parameters.AddWithValue("@mspa_Dfoilcolorsize", DFoilColorSize)
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp110", DHeaterTemp)
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp", MachineHeaterTempDecimal)
                cmd.Parameters.AddWithValue("@mspa_DScorbndratioAct", ScorebendRatioDecimal)
                cmd.Parameters.AddWithValue("@mspa_DPunchPressImpAct", PunchingPressureDecimal)
                cmd.Parameters.AddWithValue("@mspa_DSubstThickn", MachineSubstrateThicknessDecimal)
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
                cmd.Parameters.AddWithValue("@mspa_Dcorrdiecut", ACorrectDieCut)
                cmd.Parameters.AddWithValue("@mspa_Ddiecutcode", TXT_CorrectDiecutCode.Text)
                cmd.Parameters.AddWithValue("@mspa_Dcorrdcblade", ACorrectDieCutBlade)
                cmd.Parameters.AddWithValue("@mspa_Dbxfuncnlock", ABoxFunctionalityLockingSystem)
                cmd.Parameters.AddWithValue("@mspa_Dcutedge", ACutEdgesAndScoreSurface)
                cmd.Parameters.AddWithValue("@mspa_DEmbcliche", CEmbossingClicheVsFilm)
                cmd.Parameters.AddWithValue("@mspa_DEclicht5mm", CClicheHeight)
                cmd.Parameters.AddWithValue("@mspa_DEclichht", ClicheHeight5mmDecimal)
                cmd.Parameters.AddWithValue("@mspa_DEmboutput", CEmbossingOutput)
                cmd.Parameters.AddWithValue("@mspa_DcountrEmbTh", CounterStampingThickDecimal)
                cmd.Parameters.AddWithValue("@mspa_DCorrStripBrd", BCorrectUseOfStripping)
                cmd.Parameters.AddWithValue("@mspa_DCorrWknife", BCorrectWasteKnife)
                cmd.Parameters.AddWithValue("@mspa_DCorrpinbarPos", BCorrectPinsAndBars)
                cmd.Parameters.AddWithValue("@mspa_DStmpclichvsfilm", DStampingIssuedCliche)
                cmd.Parameters.AddWithValue("@mspa_DStClichHt7mm", DClicheHeight7mm)
                cmd.Parameters.AddWithValue("@mspa_DStClichHt", MachineClicheHeightDecimal)
                cmd.Parameters.AddWithValue("@mspa_DStmpingOutput", DStampingOutput)
                cmd.Parameters.AddWithValue("@mspa_DcountrStmpTh", MachineCounterStampingDecimal)
                cmd.Parameters.AddWithValue("@mspa_Dfoilcolorsize", DFoilColorSize)
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp110", DHeaterTemp)
                cmd.Parameters.AddWithValue("@mspa_DheatrTemp", MachineHeaterTempDecimal)
                cmd.Parameters.AddWithValue("@mspa_DScorbndratioAct", ScorebendRatioDecimal)
                cmd.Parameters.AddWithValue("@mspa_DPunchPressImpAct", PunchingPressureDecimal)
                cmd.Parameters.AddWithValue("@mspa_DSubstThickn", MachineSubstrateThicknessDecimal)
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
                cmd.Parameters.AddWithValue("@stripknife", TXT_StrippingBladeQty1.Text)
                cmd.Parameters.AddWithValue("@stripknifebld", TXT_StrippingBladeQty2.Text)
                cmd.Parameters.AddWithValue("@markerqty", TXT_7MarkerQty.Text)
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
                cmd.Parameters.AddWithValue("@markerqty", TXT_7MarkerQty.Text)
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

        Dim UC_SupervisorDIeCuttingForm As New UC_SupervisorDIeCutting
        UC_SupervisorDIeCuttingForm.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorDIeCuttingForm.Show()
        UC_SupervisorDIeCuttingForm.Dock = DockStyle.Fill






    End Sub


    Private Sub SelectAllEnableCheck()
        CHK_FullFeeder.Checked = True
        CHK_FullStripping.Checked = True
        CHK_FullDelivery.Checked = True
        CHK_FullWasteBin.Checked = True
        CHK_FullViewingTable.Checked = True
        CHK_FullDieCutBlade.Checked = True
        CHK_FullCounterDie.Checked = True
        CHK_FullEmbossingCliche.Checked = True
        CHK_FullCounterEmbossing.Checked = True
        CHK_FullStrippingBoard.Checked = True
        CHK_FullStampingCliche.Checked = True
        CHK_FullCounterStamping.Checked = True
        CHK_FullStampingFoil.Checked = True

        CHK_FullStrippingPins.Checked = True
        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodOilChemical.Checked = True
        CHK_GoodForeignMaterials.Checked = True
        CHK_GoodRubberSuckers.Checked = True
        CHK_GoodFeederTable.Checked = True
        CHK_GoodInspectionTable.Checked = True
        CHK_GoodPlasticPallets.Checked = True
        CHK_GoodProperlyTagged.Checked = True
        CHK_CGoodInPlasticPalltes.Checked = True
        CHK_GoodWith20WallClearance.Checked = True
        CHk_GoodWearsProperlyTucked.Checked = True
        CHk_GoodHandsWashed.Checked = True

        CHK_GoodFollowingStandard.Checked = True
        CHK_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaningMaterials.Checked = True
        CHK_GoodSafetyDevice.Checked = True




        'CHK_MachineCorDiecutCode.Checked = True

        'CHK_MachineCorDiecutBlade.Checked = True
        'CHK_MachineBox.Checked = True
        'CHK_MachineCutEdges.Checked = True

        'CHK_MachineCorUseStripping.Checked = True
        'CHK_MachineCorWasteKnife.Checked = True
        'CHK_MachineCorPinsBars.Checked = True

        'CHK_MachineEmbossingClicheVsFilm.Checked = True
        'CHK_MachineClicheHeight.Checked = True

        'CHK_MachineEmbossingOutput.Checked = True

        'CHK_MachineStampingIssuedCliche.Checked = True
        'CHK_MachineClicheHeight7mm.Checked = True

        'CHK_MachineStampingOutput.Checked = True

        'CHK_MachineFoilColorSize.Checked = True
        'CHK_MachineHeaterTemp.Checked = True

    End Sub


    Private Sub SelectAllDisabledCheck()
        CHK_FullFeeder.Checked = False
        CHK_FullStripping.Checked = False
        CHK_FullDelivery.Checked = False
        CHK_FullWasteBin.Checked = False
        CHK_FullViewingTable.Checked = False
        CHK_FullDieCutBlade.Checked = False
        CHK_FullCounterDie.Checked = False
        CHK_FullEmbossingCliche.Checked = False
        CHK_FullCounterEmbossing.Checked = False
        CHK_FullStrippingBoard.Checked = False
        CHK_FullStampingCliche.Checked = False
        CHK_FullCounterStamping.Checked = False
        CHK_FullStampingFoil.Checked = False

        CHK_FullStrippingPins.Checked = False
        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False
        CHK_GoodRubberSuckers.Checked = False
        CHK_GoodFeederTable.Checked = False
        CHK_GoodInspectionTable.Checked = False
        CHK_GoodPlasticPallets.Checked = False
        CHK_GoodProperlyTagged.Checked = False
        CHK_CGoodInPlasticPalltes.Checked = False
        CHK_GoodWith20WallClearance.Checked = False
        CHk_GoodWearsProperlyTucked.Checked = False

        CHk_GoodHandsWashed.Checked = False
        CHK_GoodFollowingStandard.Checked = False
        CHK_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaningMaterials.Checked = False
        CHK_GoodSafetyDevice.Checked = False


        'CHK_MachineCorDiecutCode.Checked = False

        'CHK_MachineCorDiecutBlade.Checked = False
        'CHK_MachineBox.Checked = False
        'CHK_MachineCutEdges.Checked = False

        'CHK_MachineCorUseStripping.Checked = False
        'CHK_MachineCorWasteKnife.Checked = False
        'CHK_MachineCorPinsBars.Checked = False

        'CHK_MachineEmbossingClicheVsFilm.Checked = False
        'CHK_MachineClicheHeight.Checked = False

        'CHK_MachineEmbossingOutput.Checked = False

        'CHK_MachineStampingIssuedCliche.Checked = False
        'CHK_MachineClicheHeight7mm.Checked = False

        'CHK_MachineStampingOutput.Checked = False

        'CHK_MachineFoilColorSize.Checked = False
        'CHK_MachineHeaterTemp.Checked = False

    End Sub


    Private Sub EnabledSupervisorForm()
        CHK_SelectAll.Enabled = True
        CHK_FullFeeder.Enabled = True
        CHK_FullStripping.Enabled = True
        CHK_FullDelivery.Enabled = True
        CHK_FullWasteBin.Enabled = True
        CHK_FullViewingTable.Enabled = True
        CHK_FullDieCutBlade.Enabled = True
        CHK_FullCounterDie.Enabled = True
        CHK_FullEmbossingCliche.Enabled = True
        CHK_FullCounterEmbossing.Enabled = True
        CHK_FullStrippingBoard.Enabled = True
        CHK_FullStampingCliche.Enabled = True
        CHK_FullCounterStamping.Enabled = True
        CHK_FullStampingFoil.Enabled = True

        TXT_BallpenQty.Enabled = True
        TXT_RagsQty.Enabled = True
        TXT_StrippingKnifeQty1.Enabled = True
        TXT_StrippingKnifeQty2.Enabled = True
        TXT_FLCMarterQty.Enabled = True

        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True
        TXT_StrippingBladeQty1.Enabled = True
        TXT_StrippingBladeQty2.Enabled = True
        TXT_7MarkerQty.Enabled = True

        DTPOperator.Enabled = True
        DTPHelper1.Enabled = True
        DTPHelper2.Enabled = True




        CHK_FullStrippingPins.Enabled = True
        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodOilChemical.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True
        CHK_GoodRubberSuckers.Enabled = True
        CHK_GoodFeederTable.Enabled = True
        CHK_GoodInspectionTable.Enabled = True
        CHK_GoodPlasticPallets.Enabled = True
        CHK_GoodProperlyTagged.Enabled = True
        CHK_CGoodInPlasticPalltes.Enabled = True
        CHK_GoodWith20WallClearance.Enabled = True
        CHk_GoodWearsProperlyTucked.Enabled = True
        CHk_GoodHandsWashed.Enabled = True
        CHK_GoodFollowingStandard.Enabled = True
        CHK_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaningMaterials.Enabled = True

        CHK_GoodSafetyDevice.Enabled = True
        RTB_JobInstruction.Enabled = True
        CBO_Helper1.Enabled = True
        CBO_Helper2.Enabled = True

        TXT_Helper1.Enabled = True
        TXT_Helper2.Enabled = True


        CHK_MachineCorDiecutCode.Enabled = True
        TXT_CorrectDiecutCode.Enabled = True
        CHK_MachineCorDiecutBlade.Enabled = True
        CHK_MachineBox.Enabled = True
        CHK_MachineCutEdges.Enabled = True

        CHK_MachineCorUseStripping.Enabled = True
        CHK_MachineCorWasteKnife.Enabled = True
        CHK_MachineCorPinsBars.Enabled = True

        CHK_MachineEmbossingClicheVsFilm.Enabled = True
        CHK_MachineClicheHeight.Enabled = True
        TXT_CClicheHeight5mm.Enabled = True
        CHK_MachineEmbossingOutput.Enabled = True

        CHK_MachineStampingIssuedCliche.Enabled = True
        CHK_MachineClicheHeight7mm.Enabled = True
        TXT_MachineClicheHeight.Enabled = True
        CHK_MachineStampingOutput.Enabled = True
        TXT_MachineCounterStamping.Enabled = True
        CHK_MachineFoilColorSize.Enabled = True
        CHK_MachineHeaterTemp.Enabled = True
        TXT_CounterStampingThick.Enabled = True

        TXT_MachineHeaterTemp.Enabled = True
        TXT_ScorebendRatio.Enabled = True
        TXT_PunchingPressure.Enabled = True
        TXT_MachineSubstrateThickness.Enabled = True

        BTN_Save_Supervisor.Enabled = True
    End Sub



    Private Sub DisabledSupervisorForm()
        CHK_SelectAll.Enabled = False
        CHK_FullFeeder.Enabled = False
        CHK_FullStripping.Enabled = False
        CHK_FullDelivery.Enabled = False
        CHK_FullWasteBin.Enabled = False
        CHK_FullViewingTable.Enabled = False
        CHK_FullDieCutBlade.Enabled = False
        CHK_FullCounterDie.Enabled = False
        CHK_FullEmbossingCliche.Enabled = False
        CHK_FullCounterEmbossing.Enabled = False
        CHK_FullStrippingBoard.Enabled = False
        CHK_FullStampingCliche.Enabled = False
        CHK_FullCounterStamping.Enabled = False
        CHK_FullStampingFoil.Enabled = False
        CHK_FullStrippingPins.Enabled = False

        TXT_BallpenQty.Enabled = False
        TXT_RagsQty.Enabled = False
        TXT_StrippingKnifeQty1.Enabled = False
        TXT_StrippingKnifeQty2.Enabled = False
        TXT_FLCMarterQty.Enabled = False

        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False
        TXT_StrippingBladeQty1.Enabled = False
        TXT_StrippingBladeQty2.Enabled = False
        TXT_7MarkerQty.Enabled = False


        DTPOperator.Enabled = False

        DTPHelper1.Enabled = False
        DTPHelper2.Enabled = False






        CHK_GoodExcessiveDust.Enabled = False
        CHK_GoodOilChemical.Enabled = False
        CHK_GoodForeignMaterials.Enabled = False
        CHK_GoodRubberSuckers.Enabled = False
        CHK_GoodFeederTable.Enabled = False
        CHK_GoodInspectionTable.Enabled = False
        CHK_GoodPlasticPallets.Enabled = False

        CHK_GoodProperlyTagged.Enabled = False
        CHK_CGoodInPlasticPalltes.Enabled = False
        CHK_GoodWith20WallClearance.Enabled = False
        CHk_GoodWearsProperlyTucked.Enabled = False
        CHk_GoodHandsWashed.Enabled = False
        CHK_GoodFollowingStandard.Enabled = False
        CHK_GoodTools.Enabled = False
        CHK_GoodEquipment.Enabled = False
        CHK_GoodCleaningMaterials.Enabled = False
        CHK_GoodSafetyDevice.Enabled = False
        RTB_JobInstruction.Enabled = False
        CBO_Helper1.Enabled = False
        CBO_Helper2.Enabled = False

        TXT_Helper1.Enabled = False
        TXT_Helper2.Enabled = False



        CHK_MachineCorDiecutCode.Enabled = False
        TXT_CorrectDiecutCode.Enabled = False
        CHK_MachineCorDiecutBlade.Enabled = False
        CHK_MachineBox.Enabled = False
        CHK_MachineCutEdges.Enabled = False

        CHK_MachineCorUseStripping.Enabled = False
        CHK_MachineCorWasteKnife.Enabled = False
        CHK_MachineCorPinsBars.Enabled = False

        CHK_MachineEmbossingClicheVsFilm.Enabled = False
        CHK_MachineClicheHeight.Enabled = False
        TXT_CClicheHeight5mm.Enabled = False
        CHK_MachineEmbossingOutput.Enabled = False

        CHK_MachineStampingIssuedCliche.Enabled = False
        CHK_MachineClicheHeight7mm.Enabled = False
        TXT_MachineClicheHeight.Enabled = False
        CHK_MachineStampingOutput.Enabled = False
        TXT_MachineCounterStamping.Enabled = False
        CHK_MachineFoilColorSize.Enabled = False
        CHK_MachineHeaterTemp.Enabled = False

        TXT_CounterStampingThick.Enabled = False

        TXT_MachineHeaterTemp.Enabled = False
        TXT_ScorebendRatio.Enabled = False
        TXT_PunchingPressure.Enabled = False
        TXT_MachineSubstrateThickness.Enabled = False

        BTN_Save_Supervisor.Enabled = False
    End Sub


    Private Sub UC_SupervisorDIeCutting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPOperator.Format = DateTimePickerFormat.Custom
        DTPOperator.CustomFormat = "hh:mm tt"


        DTPHelper1.Format = DateTimePickerFormat.Custom
        DTPHelper1.CustomFormat = "hh:mm tt"


        DTPHelper2.Format = DateTimePickerFormat.Custom
        DTPHelper2.CustomFormat = "hh:mm tt"

        DTPOperator.Text = "12:00 AM"
        DTPHelper1.Text = "12:00 AM"
        DTPHelper2.Text = "12:00 AM"

        ' Optional: Set value to default time when no time is selected
        If DTPOperator.Value = DTPOperator.MinDate Then
            DTPOperator.Text = "12:00 AM"
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
        'TXT_OperatorNumSupervisor.Text = FRM_MonitoringChecklistMain.LBL_oper_numOperator.Text
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

                    If dr("flc_stripping").ToString() = "O" Then
                        CHK_FullStripping.Checked = True
                    Else
                        CHK_FullStripping.Checked = False
                    End If



                    If dr("flc_delivery").ToString() = "O" Then
                        CHK_FullDelivery.Checked = True
                    Else
                        CHK_FullDelivery.Checked = False
                    End If

                    If dr("flc_wasteBin").ToString() = "O" Then
                        CHK_FullWasteBin.Checked = True
                    Else
                        CHK_FullWasteBin.Checked = False
                    End If


                    If dr("flc_viewingTable").ToString() = "O" Then
                        CHK_FullViewingTable.Checked = True
                    Else
                        CHK_FullViewingTable.Checked = False
                    End If


                    If dr("flc_diecutBlade").ToString() = "O" Then
                        CHK_FullDieCutBlade.Checked = True
                    Else
                        CHK_FullDieCutBlade.Checked = False
                    End If


                    If dr("flc_counterdie").ToString() = "O" Then
                        CHK_FullCounterDie.Checked = True
                    Else
                        CHK_FullCounterDie.Checked = False
                    End If


                    If dr("flc_embossingCliche").ToString() = "O" Then
                        CHK_FullEmbossingCliche.Checked = True
                    Else
                        CHK_FullEmbossingCliche.Checked = False
                    End If

                    If dr("flc_counterEmbossing").ToString() = "O" Then
                        CHK_FullCounterEmbossing.Checked = True
                    Else
                        CHK_FullCounterEmbossing.Checked = False
                    End If

                    If dr("flc_strippingBoard").ToString() = "O" Then
                        CHK_FullStrippingBoard.Checked = True
                    Else
                        CHK_FullStrippingBoard.Checked = False
                    End If

                    If dr("flc_strippingPins").ToString() = "O" Then
                        CHK_FullStrippingPins.Checked = True
                    Else
                        CHK_FullStrippingPins.Checked = False
                    End If


                    If dr("flc_stampingCliche").ToString() = "O" Then
                        CHK_FullStampingCliche.Checked = True
                    Else
                        CHK_FullStampingCliche.Checked = False
                    End If



                    If dr("flc_counterStamping").ToString() = "O" Then
                        CHK_FullCounterStamping.Checked = True
                    Else
                        CHK_FullCounterStamping.Checked = False
                    End If


                    If dr("flc_stampingFoil").ToString() = "O" Then
                        CHK_FullStampingFoil.Checked = True
                    Else
                        CHK_FullStampingFoil.Checked = False
                    End If




                    TXT_BallpenQty.Text = dr("flc_OLCbpenqty").ToString()
                    TXT_RagsQty.Text = dr("flc_OLCragqty").ToString()
                    TXT_StrippingKnifeQty1.Text = dr("flc_OLCstripknife").ToString()
                    TXT_StrippingKnifeQty2.Text = dr("flc_OLCstripbld").ToString()

                    TXT_FLCMarterQty.Text = dr("flc_OLCmarkerqty").ToString()









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



                    If dr("gmp_SaniRubberSucker").ToString() = "O" Then
                        CHK_GoodRubberSuckers.Checked = True
                    Else
                        CHK_GoodRubberSuckers.Checked = False
                    End If


                    If dr("gmp_SaniFeederTable").ToString() = "O" Then
                        CHK_GoodFeederTable.Checked = True
                    Else
                        CHK_GoodFeederTable.Checked = False
                    End If




                    If dr("gmp_SaniInspTable").ToString() = "O" Then
                        CHK_GoodInspectionTable.Checked = True
                    Else
                        CHK_GoodInspectionTable.Checked = False
                    End If



                    If dr("gmp_SaniPlasticPallet").ToString() = "O" Then
                        CHK_GoodPlasticPallets.Checked = True
                    Else
                        CHK_GoodPlasticPallets.Checked = False
                    End If





                    If dr("gmp_PrePropTagged").ToString() = "O" Then
                        CHK_GoodProperlyTagged.Checked = True
                    Else
                        CHK_GoodProperlyTagged.Checked = False
                    End If




                    If dr("gmp_PreInPlasticPallet").ToString() = "O" Then
                        CHK_CGoodInPlasticPalltes.Checked = True
                    Else
                        CHK_CGoodInPlasticPalltes.Checked = False
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
                    helper1 = dr("jic_Helper1").ToString()
                    helper2 = dr("jic_Helper2").ToString()

                    TXT_Helper1.Text = helper1
                    TXT_Helper2.Text = helper2


                    DTPOperator.Text = dr("jic_OperatorTime").ToString()
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


                    If dr("mspa_Dcorrdiecut").ToString() = "O" Then
                        CHK_MachineCorDiecutCode.Checked = True
                    Else
                        CHK_MachineCorDiecutCode.Checked = False
                    End If



                    If dr("mspa_Dcorrdcblade").ToString() = "O" Then
                        CHK_MachineCorDiecutBlade.Checked = True
                    Else
                        CHK_MachineCorDiecutBlade.Checked = False
                    End If

                    If dr("mspa_Dbxfuncnlock").ToString() = "O" Then
                        CHK_MachineBox.Checked = True
                    Else
                        CHK_MachineBox.Checked = False
                    End If


                    If dr("mspa_Dcutedge").ToString() = "O" Then
                        CHK_MachineCutEdges.Checked = True
                    Else
                        CHK_MachineCutEdges.Checked = False
                    End If




                    If dr("mspa_DCorrStripBrd").ToString() = "O" Then
                        CHK_MachineCorUseStripping.Checked = True
                    Else
                        CHK_MachineCorUseStripping.Checked = False
                    End If


                    If dr("mspa_DCorrWknife").ToString() = "O" Then
                        CHK_MachineCorWasteKnife.Checked = True
                    Else
                        CHK_MachineCorWasteKnife.Checked = False
                    End If




                    If dr("mspa_DCorrpinbarPos").ToString() = "O" Then
                        CHK_MachineCorPinsBars.Checked = True
                    Else
                        CHK_MachineCorPinsBars.Checked = False
                    End If




                    If dr("mspa_DEmbcliche").ToString() = "O" Then
                        CHK_MachineEmbossingClicheVsFilm.Checked = True
                    Else
                        CHK_MachineEmbossingClicheVsFilm.Checked = False
                    End If



                    If dr("mspa_DEclicht5mm").ToString() = "O" Then
                        CHK_MachineClicheHeight.Checked = True
                    Else
                        CHK_MachineClicheHeight.Checked = False
                    End If



                    If dr("mspa_DEmboutput").ToString() = "O" Then
                        CHK_MachineEmbossingOutput.Checked = True
                    Else
                        CHK_MachineEmbossingOutput.Checked = False
                    End If






                    If dr("mspa_DStmpclichvsfilm").ToString() = "O" Then
                        CHK_MachineStampingIssuedCliche.Checked = True
                    Else
                        CHK_MachineStampingIssuedCliche.Checked = False
                    End If



                    If dr("mspa_DStClichHt7mm").ToString() = "O" Then
                        CHK_MachineClicheHeight7mm.Checked = True
                    Else
                        CHK_MachineClicheHeight7mm.Checked = False
                    End If


                    If dr("mspa_DStmpingOutput").ToString() = "O" Then
                        CHK_MachineStampingOutput.Checked = True
                    Else
                        CHK_MachineStampingOutput.Checked = False
                    End If

                    If dr("mspa_Dfoilcolorsize").ToString() = "O" Then
                        CHK_MachineFoilColorSize.Checked = True
                    Else
                        CHK_MachineFoilColorSize.Checked = False
                    End If

                    If dr("mspa_DheatrTemp110").ToString() = "O" Then
                        CHK_MachineHeaterTemp.Checked = True
                    Else
                        CHK_MachineHeaterTemp.Checked = False
                    End If



                    TXT_CorrectDiecutCode.Text = dr("mspa_Ddiecutcode").ToString()
                    TXT_CClicheHeight5mm.Text = dr("mspa_DEclichht").ToString()
                    TXT_CounterStampingThick.Text = dr("mspa_DcountrEmbTh").ToString()
                    TXT_MachineClicheHeight.Text = dr("mspa_DStClichHt").ToString()
                    TXT_MachineCounterStamping.Text = dr("mspa_DcountrStmpTh").ToString()
                    TXT_MachineHeaterTemp.Text = dr("mspa_DheatrTemp").ToString()
                    TXT_ScorebendRatio.Text = dr("mspa_DScorbndratioAct").ToString()
                    TXT_PunchingPressure.Text = dr("mspa_DPunchPressImpAct").ToString()
                    TXT_MachineSubstrateThickness.Text = dr("mspa_DSubstThickn").ToString()



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
                    TXT_StrippingBladeQty1.Text = dr("stripknife").ToString()
                    TXT_StrippingBladeQty2.Text = dr("stripknifebld").ToString()
                    TXT_7MarkerQty.Text = dr("markerqty").ToString()



                End If

                dr.Close()
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try






        'If TXT_Supervisor.Text = "" Then
        '    BTN_Save_Supervisor.Text = "Save"
        'Else
        '    BTN_Save_Supervisor.Text = "Update"
        'End If



    End Sub

    Private Sub CHK_SeleclAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged
        If CHK_SelectAll.Checked = True Then
            SelectAllEnableCheck()
        Else
            SelectAllDisabledCheck()
        End If
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

    Private Sub load_helper_empnum1()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
		        Name, 
		        Emp_num, 
		        Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Helper' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_Helper1.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            While read_cmd_select_helper_empnum.Read
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_Helper1.Items.Add(helper_empname)
                TXT_Helper1.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_Helper1.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))
            End While
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub load_helper_empnum2()
        Dim cmd_select_helper_empnum As New SqlCommand("
        Select 
		        Name, 
		        Emp_num, 
		        Emp_num + ' - ' + Name as Emp_num_helper 
        FROM Employee WHERE Position = 'Helper' and

        (Emp_num + ' - ' + Name) = @helperempnum", con)

        cmd_select_helper_empnum.Parameters.AddWithValue("@helperempnum", CBO_Helper2.Text)

        Try
            con.Open()
            Dim read_cmd_select_helper_empnum As SqlDataReader = cmd_select_helper_empnum.ExecuteReader
            While read_cmd_select_helper_empnum.Read
                Dim helper_empname As String = read_cmd_select_helper_empnum("Name")
                CBO_Helper2.Items.Add(helper_empname)
                TXT_Helper2.Text = read_cmd_select_helper_empnum("Emp_num")
                CBO_Helper2.Text = read_cmd_select_helper_empnum("Name").ToString
                'MsgBox(read_cmd_select_helper_empnum("Name"))   
            End While
            read_cmd_select_helper_empnum.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub CBO_Helper2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBO_Helper2.SelectedIndexChanged
        load_helper_empnum2()
    End Sub

    Private Sub CBO_Helper2_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper2.DropDown
        CBO_Helper2.Items.Clear()
        load_helper2()
    End Sub

    Private Sub CBO_Helper1_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper1.DropDown
        CBO_Helper1.Items.Clear()
        load_helper1()
    End Sub

    Private Sub CBO_Helper1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged
        load_helper_empnum1()
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




    Private Sub TXT_MachineClicheHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineClicheHeight.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_MachineCounterStamping_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineCounterStamping.KeyPress
        NumberChar(e)
    End Sub


    Private Sub TXT_MachineHeaterTemp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineHeaterTemp.KeyPress
        NumberChar(e)
    End Sub


    Private Sub TXT_CClicheHeight5mm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CClicheHeight5mm.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_CounterStampingThick_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CounterStampingThick.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_ScorebendRatio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ScorebendRatio.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_PunchingPressure_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PunchingPressure.KeyPress
        NumberChar(e)
    End Sub


    Private Sub TXT_MachineSubstrateThickness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MachineSubstrateThickness.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_FLCMarterQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FLCMarterQty.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_7MarkerQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_7MarkerQty.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_StrippingKnifeQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingKnifeQty2.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_StrippingKnifeQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingKnifeQty1.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RagsQty.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_BallpenQty.KeyPress
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

    Private Sub TXT_StrippingBladeQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_StrippingBladeQty2.TextChanged

    End Sub

    Private Sub TXT_StrippingBladeQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingBladeQty2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_7MarkerQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_7MarkerQty.TextChanged

    End Sub

    Private Sub TXT_CClicheHeight5mm_TextChanged(sender As Object, e As EventArgs) Handles TXT_CClicheHeight5mm.TextChanged

    End Sub

    Private Sub TXT_7BallpenQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_7BallpenQty.TextChanged

    End Sub

    Private Sub TXT_7RagsQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_7RagsQty.TextChanged

    End Sub

    Private Sub TXT_ScorebendRatio_TextChanged(sender As Object, e As EventArgs) Handles TXT_ScorebendRatio.TextChanged

    End Sub
End Class
