Public Class UC_SuperIntendentOffset
    Private Sub UC_SuperIntendentOffset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                    TXT_InksTo.Text = dr("flc_OffInkFr").ToString()
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
                    TXT_VerifiedSuperIntendent.Text = dr("VerifiedSupervisorName").ToString()

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

            Dim UC_SuperIntendentOff As New UC_SuperIntendentOffset
            UC_SuperIntendentOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentOff.Show()
            UC_SuperIntendentOff.Dock = DockStyle.Fill




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
