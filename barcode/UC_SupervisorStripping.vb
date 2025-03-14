Imports System.Data.SqlClient

Public Class UC_SupervisorStripping
    Private ReadOnly CHK_GoodCuttingTable As Object

    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SelectAllEnabled()
        'FULL A and B
        CHK_FullWasteSack.Checked = True
        CHK_FullPinBar.Checked = True
        CHK_FullPressingTable.Checked = True
        CHK_FullPlasticPallets.Checked = True
        CHK_FullViewingTable.Checked = True
        CHK_FullLifter.Checked = True
        CHK_FullOthers.Checked = True

        '7
        CHK_GoodMachineTable.Checked = True
        CHK_GoodStrippingPins.Checked = True

        '2
        CHK_GoodExcessiveDust.Checked = True
        CHK_GoodOilChemical.Checked = True
        CHK_GoodForeignMaterials.Checked = True
        CHK_GoodLiftsolNo5.Checked = True
        CHK_GoodMachineTable.Checked = True
        CHK_GoodStrippingPins.Checked = True
        CHK_GoodPads.Checked = True

        CHK_GoodProperlyTagged.Checked = True
        CHK_GoodPlasticPalltes.Checked = True
        CHK_GoodFollowingStandard.Checked = True

        CHK_GoodWearHair.Checked = True
        CHk_GoodWearsProperlyTucked.Checked = True
        CHk_GoodHandsWashed.Checked = True

        CHK_GoodTools.Checked = True
        CHK_GoodEquipment.Checked = True
        CHK_GoodCleaningMaterials.Checked = True
        CHK_GoodSafetyDevice.Checked = True

        '4
        CHK_MachineAPinPlate.Checked = True
        CHK_MachineBPrintLayout.Checked = True
        CHK_MachineCPerups.Checked = True
        CHK_MachinePerPalletNumber.Checked = True




    End Sub
    Private Sub SelectAllDisabled()
        'FULL A and B
        CHK_FullWasteSack.Checked = False
        CHK_FullPinBar.Checked = False
        CHK_FullPressingTable.Checked = False
        CHK_FullPlasticPallets.Checked = False
        CHK_FullViewingTable.Checked = False
        CHK_FullLifter.Checked = False
        CHK_FullOthers.Checked = False

        '7
        CHK_GoodMachineTable.Checked = False
        CHK_GoodStrippingPins.Checked = False

        '2
        CHK_GoodExcessiveDust.Checked = False
        CHK_GoodOilChemical.Checked = False
        CHK_GoodForeignMaterials.Checked = False
        CHK_GoodLiftsolNo5.Checked = False
        CHK_GoodMachineTable.Checked = False
        CHK_GoodStrippingPins.Checked = False
        CHK_GoodPads.Checked = False

        CHK_GoodProperlyTagged.Checked = False
        CHK_GoodPlasticPalltes.Checked = False
        CHK_GoodFollowingStandard.Checked = False

        CHK_GoodWearHair.Checked = False
        CHk_GoodWearsProperlyTucked.Checked = False
        CHk_GoodHandsWashed.Checked = False

        CHK_GoodTools.Checked = False
        CHK_GoodEquipment.Checked = False
        CHK_GoodCleaningMaterials.Checked = False
        CHK_GoodSafetyDevice.Checked = False

        '4
        CHK_MachineAPinPlate.Checked = False
        CHK_MachineBPrintLayout.Checked = False
        CHK_MachineCPerups.Checked = False
        CHK_MachinePerPalletNumber.Checked = False




    End Sub



    Private Sub EnabledSupervisorForm()
        'FULL A and B
        CHK_FullWasteSack.Enabled = True
        CHK_FullPinBar.Enabled = True
        CHK_FullPressingTable.Enabled = True
        CHK_FullPlasticPallets.Enabled = True
        CHK_FullViewingTable.Enabled = True
        CHK_FullLifter.Enabled = True
        CHK_FullOthers.Enabled = True
        TXT_BallpenQty.Enabled = True
        TXT_RagsQty.Enabled = True
        TXT_StrippingKnifeQty1.Enabled = True
        TXT_StrippingKnifeQty2.Enabled = True
        TXT_FullMarker.Enabled = True

        '7
        TXT_7BallpenQty.Enabled = True
        TXT_7RagsQty.Enabled = True
        TXT_StrippingBladeQty1.Enabled = True
        TXT_StrippingBladeQty2.Enabled = True
        TXT_7MarkerQty.Enabled = True
        CHK_GoodMachineTable.Enabled = True
        CHK_GoodStrippingPins.Enabled = True

        '2
        CHK_GoodExcessiveDust.Enabled = True
        CHK_GoodOilChemical.Enabled = True
        CHK_GoodForeignMaterials.Enabled = True
        CHK_GoodLiftsolNo5.Enabled = True
        CHK_GoodMachineTable.Enabled = True
        CHK_GoodStrippingPins.Enabled = True
        CHK_GoodPads.Enabled = True

        CHK_GoodProperlyTagged.Enabled = True
        CHK_GoodPlasticPalltes.Enabled = True
        CHK_GoodFollowingStandard.Enabled = True

        CHK_GoodWearHair.Enabled = True
        CHk_GoodWearsProperlyTucked.Enabled = True
        CHk_GoodHandsWashed.Enabled = True

        CHK_GoodTools.Enabled = True
        CHK_GoodEquipment.Enabled = True
        CHK_GoodCleaningMaterials.Enabled = True
        CHK_GoodSafetyDevice.Enabled = True

        RTB_JobInstruction.Enabled = True
        CBO_Helper1.Enabled = True

        '4
        CHK_MachineAPinPlate.Enabled = True
        CHK_MachineBPrintLayout.Enabled = True
        CHK_MachineCPerups.Enabled = True
        CHK_MachinePerPalletNumber.Enabled = True

        CHK_SelectAll.Enabled = True
        TXT_Helper1.Enabled = True
        DTPOperator.Enabled = True
        DTPHelper1.Enabled = True

        BTN_Save_Supervisor.Enabled = True

    End Sub



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
        TXT_7BallpenQty.Enabled = False
        TXT_7RagsQty.Enabled = False
        TXT_StrippingBladeQty1.Enabled = False
        TXT_StrippingBladeQty2.Enabled = False
        TXT_7MarkerQty.Enabled = False
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

        RTB_JobInstruction.Enabled = False
        CBO_Helper1.Enabled = False


        '4
        CHK_MachineAPinPlate.Enabled = False
        CHK_MachineBPrintLayout.Enabled = False
        CHK_MachineCPerups.Enabled = False
        CHK_MachinePerPalletNumber.Enabled = False

        CHK_SelectAll.Enabled = False
        TXT_Helper1.Enabled = False
        DTPOperator.Enabled = False
        DTPHelper1.Enabled = False



        BTN_Save_Supervisor.Enabled = False


    End Sub



    Private Sub UC_SupervisorStripping_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        DTPOperator.Format = DateTimePickerFormat.Custom
        DTPOperator.CustomFormat = "hh:mm tt"


        DTPHelper1.Format = DateTimePickerFormat.Custom
        DTPHelper1.CustomFormat = "hh:mm tt"


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
            BTN_Save_Supervisor.Visible = False
            CBO_Helper1.Enabled = False
            CHK_SelectAll.Visible = False



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


                    If dr("mspa_STConPinplatespecs").ToString() = "O" Then
                        CHK_MachineAPinPlate.Checked = True
                    Else
                        CHK_MachineAPinPlate.Checked = False
                    End If



                    If dr("mspa_STConPrintlayout").ToString() = "O" Then
                        CHK_MachineBPrintLayout.Checked = True
                    Else
                        CHK_MachineBPrintLayout.Checked = False
                    End If

                    If dr("mspa_STChkPallet#ups").ToString() = "O" Then
                        CHK_MachineCPerups.Checked = True
                    Else
                        CHK_MachineCPerups.Checked = False
                    End If


                    If dr("mspa_STChkPallet#Pnum").ToString() = "O" Then
                        CHK_MachinePerPalletNumber.Checked = True
                    Else
                        CHK_MachinePerPalletNumber.Checked = False
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







    End Sub

    Private Sub CHK_SeleclAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SelectAll.CheckedChanged
        If CHK_SelectAll.Checked = True Then
            SelectAllEnabled()
        Else
            SelectAllDisabled()
        End If
    End Sub

    Private Sub BTN_Save_Supervisor_Click(sender As Object, e As EventArgs) Handles BTN_Save_Supervisor.Click
        'FULL LINE CLearance variable
        Dim FullWasteSack As String = ""
        Dim FullPinBar As String = ""
        Dim FullPressingTable As String = ""
        Dim FullPlasticPallets As String = ""
        Dim FullViewingTable As String = ""
        Dim FullLifter As String = ""
        Dim FullOthers As String = ""



        If CHK_FullWasteSack.Checked Then
            FullWasteSack = "O"
        Else
            FullWasteSack = "X"
        End If

        If CHK_FullPinBar.Checked Then
            FullPinBar = "O"
        Else
            FullPinBar = "X"
        End If

        If CHK_FullPressingTable.Checked Then
            FullPressingTable = "O"
        Else
            FullPressingTable = "X"
        End If

        If CHK_FullPlasticPallets.Checked Then
            FullPlasticPallets = "O"
        Else
            FullPlasticPallets = "X"
        End If

        If CHK_FullViewingTable.Checked Then
            FullViewingTable = "O"
        Else
            FullViewingTable = "X"
        End If

        If CHK_FullLifter.Checked Then
            FullLifter = "O"
        Else
            FullLifter = "X"
        End If

        If CHK_FullOthers.Checked Then
            FullOthers = "O"
        Else
            FullOthers = "X"
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
                cmd.Parameters.AddWithValue("@flc_feederUnitTop", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitSF", "")
                cmd.Parameters.AddWithValue("@flc_gluingUnit", "")
                cmd.Parameters.AddWithValue("@flc_glueBin", "")
                cmd.Parameters.AddWithValue("@flc_DeliveryUnit", "")
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
                cmd.Parameters.AddWithValue("@flc_wasteSack", FullWasteSack)
                cmd.Parameters.AddWithValue("@flc_pinBar", FullPinBar)
                cmd.Parameters.AddWithValue("@flc_pressingTable", FullPressingTable)
                cmd.Parameters.AddWithValue("@flc_plasticPallets", FullPlasticPallets)
                cmd.Parameters.AddWithValue("@flc_rotatingTable", "")
                cmd.Parameters.AddWithValue("@flc_workingTable", "")
                cmd.Parameters.AddWithValue("@flc_Lifter", FullLifter)
                cmd.Parameters.AddWithValue("@flc_Others", FullOthers)
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
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FullMarker.Text)
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
                cmd.Parameters.AddWithValue("@flc_feederUnitTop", "")
                cmd.Parameters.AddWithValue("@flc_feederUnitSF", "")
                cmd.Parameters.AddWithValue("@flc_gluingUnit", "")
                cmd.Parameters.AddWithValue("@flc_glueBin", "")
                cmd.Parameters.AddWithValue("@flc_DeliveryUnit", "")
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
                cmd.Parameters.AddWithValue("@flc_wasteSack", FullWasteSack)
                cmd.Parameters.AddWithValue("@flc_pinBar", FullPinBar)
                cmd.Parameters.AddWithValue("@flc_pressingTable", FullPressingTable)
                cmd.Parameters.AddWithValue("@flc_plasticPallets", FullPlasticPallets)
                cmd.Parameters.AddWithValue("@flc_rotatingTable", "")
                cmd.Parameters.AddWithValue("@flc_workingTable", "")
                cmd.Parameters.AddWithValue("@flc_Lifter", FullLifter)
                cmd.Parameters.AddWithValue("@flc_Others", FullOthers)
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
                cmd.Parameters.AddWithValue("@flc_OLCmarkerqty", TXT_FullMarker.Text)
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

        Dim GoodLiftsolNo5 As String = ""
        Dim GoodMachineTable As String = ""
        Dim GoodStrippingPins As String = ""
        Dim GoodPads As String = ""


        Dim GoodProperlyTagged As String = ""
        Dim GoodPlasticPallets As String = ""
        Dim GoodFollowingStandardPall As String = ""

        Dim GoodWearHairCovers As String = ""
        Dim GoodWearProperlyTuckedIn As String = ""
        Dim GoodHandsWashed As String = ""


        Dim GoodTools As String = ""
        Dim GoodEquipment As String = ""
        Dim GoodCleaningMaterials As String = ""
        Dim GoodSafetyDevice As String = ""


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


        If CHK_GoodLiftsolNo5.Checked Then
            GoodLiftsolNo5 = "O"
        Else
            GoodLiftsolNo5 = "X"
        End If



        If CHK_GoodMachineTable.Checked Then
            GoodMachineTable = "O"
        Else
            GoodMachineTable = "X"
        End If



        If CHK_GoodStrippingPins.Checked Then
            GoodStrippingPins = "O"
        Else
            GoodStrippingPins = "X"
        End If



        If CHK_GoodPads.Checked Then
            GoodPads = "O"
        Else
            GoodPads = "X"
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
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", "")
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPall)
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

                'cmd.Parameters.AddWithValue("@gmp_Sanistation2", "")
                'cmd.Parameters.AddWithValue("@gmp_Sanistation1", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniLiftsol#5", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniMachtable", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniStripPins", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniPads", "")

                cmd.Parameters.AddWithValue("@gmp_Sanistation2", "")
                cmd.Parameters.AddWithValue("@gmp_Sanistation1", "")
                cmd.Parameters.AddWithValue("@gmp_SaniLiftsol#5", GoodLiftsolNo5)
                cmd.Parameters.AddWithValue("@gmp_SaniMachtable", GoodMachineTable)
                cmd.Parameters.AddWithValue("@gmp_SaniStripPins", GoodStrippingPins)
                cmd.Parameters.AddWithValue("@gmp_SaniPads", GoodPads)
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
                cmd.Parameters.AddWithValue("@gmp_Pre20inClearance", "")
                cmd.Parameters.AddWithValue("@gmp_PreFollowStdHeight", GoodFollowingStandardPall)
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
                cmd.Parameters.AddWithValue("@gmp_SaniLiftsol#5", GoodLiftsolNo5)
                cmd.Parameters.AddWithValue("@gmp_SaniMachtable", GoodMachineTable)
                cmd.Parameters.AddWithValue("@gmp_SaniStripPins", GoodStrippingPins)
                cmd.Parameters.AddWithValue("@gmp_SaniPads", GoodPads)
                'cmd.Parameters.AddWithValue("@gmp_Sanistation2", "")
                'cmd.Parameters.AddWithValue("@gmp_Sanistation1", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniLiftsol#5", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniMachtable", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniStripPins", "")
                'cmd.Parameters.AddWithValue("@gmp_SaniPads", "")
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







        Dim MachineAPinPlate As String = ""
        Dim MachineBPrintLayout As String = ""
        Dim MachineCPerups As String = ""
        Dim MachinePerPalletNumber As String = ""



        If CHK_MachineAPinPlate.Checked Then
            MachineAPinPlate = "O"
        Else
            MachineAPinPlate = "X"
        End If

        If CHK_MachineBPrintLayout.Checked Then
            MachineBPrintLayout = "O"
        Else
            MachineBPrintLayout = "X"
        End If

        If CHK_MachineCPerups.Checked Then
            MachineCPerups = "O"
        Else
            MachineCPerups = "X"
        End If

        If CHK_MachinePerPalletNumber.Checked Then
            MachinePerPalletNumber = "O"
        Else
            MachinePerPalletNumber = "X"
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
                cmd.Parameters.AddWithValue("@mspa_STConPinplatespecs", MachineAPinPlate)
                cmd.Parameters.AddWithValue("@mspa_STConPrintlayout", MachineBPrintLayout)
                cmd.Parameters.AddWithValue("@mspa_STConGMPstd", "")
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#ups", MachineCPerups)
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#Pnum", MachinePerPalletNumber)


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
                cmd.Parameters.AddWithValue("@mspa_STConPinplatespecs", MachineAPinPlate)
                cmd.Parameters.AddWithValue("@mspa_STConPrintlayout", MachineBPrintLayout)
                cmd.Parameters.AddWithValue("@mspa_STConGMPstd", "")
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#ups", MachineCPerups)
                cmd.Parameters.AddWithValue("@mspa_STChkPallet#Pnum", MachinePerPalletNumber)





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

        Dim UC_SupervisorStrip As New UC_SupervisorStripping
        UC_SupervisorStrip.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_SupervisorStrip.Show()
        UC_SupervisorStrip.Dock = DockStyle.Fill






    End Sub



    Private Sub TXT_BallpenQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_BallpenQty.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_RagsQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RagsQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_StrippingKnifeQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingKnifeQty1.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_StrippingKnifeQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StrippingKnifeQty2.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_FullMarker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FullMarker.KeyPress
        NumberOnly(e)
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


    Private Sub CBO_Helper1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged
        con.Close()
        load_helper_empnum1()
    End Sub


    Private Sub CBO_Helper1_DropDown(sender As Object, e As EventArgs) Handles CBO_Helper1.DropDown
        CBO_Helper1.Items.Clear()
        load_helper1()
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

    Private Sub TXT_StrippingKnifeQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_StrippingKnifeQty2.TextChanged

    End Sub
End Class
