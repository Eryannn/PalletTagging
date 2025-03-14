Public Class UC_SuperIntendentDigiPress
    Private Sub UC_SuperIntendentDigiPress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    If dr("flc_cuttingtable").ToString() = "O" Then
                        CHK_FullCuttingTable.Checked = True
                    Else
                        CHK_FullCuttingTable.Checked = False

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

            Dim UC_SuperIntendentDigiPress As New UC_SuperIntendentDigiPress
            UC_SuperIntendentDigiPress.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentDigiPress.Show()
            UC_SuperIntendentDigiPress.Dock = DockStyle.Fill




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
