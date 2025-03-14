Public Class UC_SuperIntendentDieCutting


    Private Sub DisabledSupervisorForm()

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

    End Sub
    Private Sub UC_SuperIntendentDieCutting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    TXT_VerifiedSuperIntendent.Text = dr("VerifiedSupervisorName").ToString()


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


            If TXT_VerifiedSuperIntendent.Text <> "" Then
                BTN_VerifySupervisor.Enabled = False
                BTN_VerifySupervisor.BackColor = Color.LightGray

            Else
                BTN_VerifySupervisor.Enabled = True

            End If




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

            Dim UC_SuperIntendentDieCuttingForm As New UC_SuperIntendentDieCutting
            UC_SuperIntendentDieCuttingForm.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentDieCuttingForm.Show()
            UC_SuperIntendentDieCuttingForm.Dock = DockStyle.Fill


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
