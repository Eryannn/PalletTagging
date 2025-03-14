Public Class UC_SuperIntendentLamination
    Private Sub UC_SuperIntendentLamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CHK_SelectAll.Visible = False
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

                    'TXT_Supervisor.Text = dr("SupervisorName").ToString()
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

    Private Sub BTN_Back_Click(sender As Object, e As EventArgs)

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

            Dim UC_SuperIntendentLam As New UC_SuperIntendentLamination
            UC_SuperIntendentLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_SuperIntendentLam.Show()
            UC_SuperIntendentLam.Dock = DockStyle.Fill





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BTN_Back_Click_1(sender As Object, e As EventArgs) Handles BTN_Back.Click
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
