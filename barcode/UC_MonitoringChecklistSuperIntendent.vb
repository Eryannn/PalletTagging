Public Class UC_MonitoringChecklistSuperIntendent


    Private Sub UC_MonitoringChecklistSuperIntendent_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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
                        CHK_FullCutTable.Checked = True
                    Else
                        CHK_FullCutTable.Checked = False

                    End If

                    If dr("flc_wasteBin").ToString() = "O" Then
                        CHK_FullWasteBin.Checked = True
                    Else
                        CHK_FullWasteBin.Checked = False
                    End If



                    If dr("flc_pallets").ToString() = "O" Then
                        CHK_FulPallets.Checked = True
                    Else
                        CHK_FulPallets.Checked = False
                    End If

                    If dr("flc_joggerTable").ToString() = "O" Then
                        CHK_FullLineJogTable.Checked = True
                    Else
                        CHK_FullLineJogTable.Checked = False
                    End If


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


                    If dr("gmp_SaniCuttingBlade").ToString() = "O" Then
                        CHK_GoodCuttingBlade.Checked = True
                    Else
                        CHK_GoodCuttingBlade.Checked = False
                    End If




                    If dr("gmp_SaniCuttingTable").ToString() = "O" Then
                        CHK_GoodCuttingTable.Checked = True
                    Else
                        CHK_GoodCuttingTable.Checked = False
                    End If



                    If dr("gmp_SaniControlPanel").ToString() = "O" Then
                        CHK_GoodControlPanel.Checked = True
                    Else
                        CHK_GoodControlPanel.Checked = False
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







            'Try
            '    OpenConnection()
            '    cmd.CommandText = "Select_sppmcGMP"
            '    cmd.CommandType = CommandType.StoredProcedure
            '    cmd.Parameters.Clear()
            '    cmd.Parameters.AddWithValue("Site", Form1.cmb_site.Text)
            '    cmd.Parameters.AddWithValue("mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            '    dr = cmd.ExecuteReader()
            '    If dr.HasRows Then
            '        If dr.Read() Then
            '            TXT_Supervisor.Text = dr("gmp_CondBySV").ToString()
            '        End If

            '        dr.Close()
            '        con.Close()
            '    End If
            '    dr.Close()
            '    con.Close()



            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'Finally
            '    con.Close()

            'End Try







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


                        TXT_Dimension1.Text = dr("mspa_CUChkDim1").ToString
                        TXT_Dimension2.Text = dr("mspa_CUChkDim2").ToString


                        If dr("mspa_CUGDShort").ToString() = "O" Then
                            CHK_GrainShort.Checked = True
                        Else
                            CHK_GrainShort.Checked = False
                        End If



                        If dr("mspa_CutGDLong").ToString() = "O" Then
                            CHK_GrainLong.Checked = True
                        Else
                            CHK_GrainLong.Checked = False
                        End If

                        If dr("mspa_CUBlGreasefree").ToString() = "O" Then
                            CHK_CuttingFreeFromGreaseOil.Checked = True
                        Else
                            CHK_CuttingFreeFromGreaseOil.Checked = False
                        End If


                        If dr("mspa_CUBlChippedOff").ToString() = "O" Then
                            CHK_CuttingFreeFromChippedOff.Checked = True
                        Else
                            CHK_CuttingFreeFromChippedOff.Checked = False
                        End If




                        If dr("mspa_CUSquareAllSide").ToString() = "O" Then
                            CHK_SquarenessAllSides.Checked = True
                        Else
                            CHK_SquarenessAllSides.Checked = False
                        End If


                        If dr("mspa_CUSquareAllSh").ToString() = "O" Then
                            CHK_SquarenessAllSheets.Checked = True
                        Else
                            CHK_SquarenessAllSheets.Checked = False
                        End If




                        If dr("mspa_CUChkUpsOuts").ToString() = "O" Then
                            CHK_CheckAllUps.Checked = True
                        Else
                            CHK_CheckAllUps.Checked = False
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


            'If FRM_MonitoringChecklistMain.TXT_VerifiedSup.Text <> "" Then
            '    BTN_VerifySupervisor.Enabled = False

            '    TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text
            '    TXT_OperatorNumSupervisor.Text = FRM_MonitoringChecklistMain.LBL_oper_numOperator.Text
            'Else
            '    BTN_VerifySupervisor.Enabled = True
            '    TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text
            '    TXT_OperatorNumSupervisor.Text = FRM_MonitoringChecklistMain.LBL_oper_numOperator.Text
            'End If


            If TXT_VerifiedSuperIntendent.Text <> "" Then
                BTN_VerifySupervisor.Enabled = False
                BTN_VerifySupervisor.BackColor = Color.LightGray

                TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text
                TXT_OperatorNumSupervisor.Text = FRM_MonitoringChecklistMain.LBL_oper_numOperator.Text
            Else
                BTN_VerifySupervisor.Enabled = True
                TXT_OperatorUCSupervisor.Text = FRM_MonitoringChecklistMain.txt_operator.Text
                TXT_OperatorNumSupervisor.Text = FRM_MonitoringChecklistMain.LBL_oper_numOperator.Text
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

    Private Sub CBO_Helper1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Helper1.SelectedIndexChanged

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

            Dim MonitoringChecklistSupervisorIntendent As New UC_MonitoringChecklistSuperIntendent
            MonitoringChecklistSupervisorIntendent.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            MonitoringChecklistSupervisorIntendent.Show()
            MonitoringChecklistSupervisorIntendent.Dock = DockStyle.Fill

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
