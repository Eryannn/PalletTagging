Public Class UC_SuperIntendentFinishing
    Private Sub UC_SuperIntendentFinishing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    TXT_VerifiedSuperIntendent.Text = dr("VerifiedSupervisorName").ToString()


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

            Dim UC_SuperIntendentFinishing As New UC_SuperIntendentFinishing
            UC_SuperIntendentFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentFinishing.Show()
            UC_SuperIntendentFinishing.Dock = DockStyle.Fill




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
