Public Class UC_NxtProcessGluingLamina
    Private Sub UC_NxtProcessGluingLamina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcOutput"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@Site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With

            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read() Then

                    TXT_CurGoodQty.Text = Convert.ToDecimal(dr("mchout_GoodCurrPalltQty")).ToString("N0")
                    TXT_CurRedPalletQty.Text = Convert.ToDecimal(dr("mchout_RedCurrPalltQty")).ToString("N0")
                    TXT_CurSpoilageQty.Text = Convert.ToDecimal(dr("mchout_SpoilCurrPalltQty")).ToString("N0")


                    TXT_Remarks.Text = dr("output_Remrks").ToString()
                    TXT_Acknowledge.Text = dr("NxtNameSup").ToString()

                    If Not String.IsNullOrEmpty(dr("NxtNameSup").ToString()) Then
                        BTN_Acknowledge.Enabled = False
                    Else
                        BTN_Acknowledge.Enabled = True
                    End If

                    dr.Close()
                    con.Close()

                End If
                con.Close()
            End If

            'If RBT_Acknowledge.Text = "" Then
            '    BTN_Acknowledge.Enabled = True
            'Else
            '    BTN_Acknowledge.Enabled = False
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BTN_Acknowledge_Click(sender As Object, e As EventArgs) Handles BTN_Acknowledge.Click
        Try
            OpenConnection()
            'cmd.CommandText = "UPDATE sppmcOutput SET mchout_AckNxtProcSV = @mchout_AckNxtProcSV WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandText = "UPDATE sppmcOutput SET mchout_AckQAInsp = @mchout_AckQAInsp WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.Parameters.AddWithValue("@mchout_AckQAInsp", FRM_MonitoringChecklistMain.lbl_empnum.Text)
            'cmd.Parameters.AddWithValue("")
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("successfully acknowledge!")


            Dim i As Integer
            For i = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next




            Dim UC_NxtProcessGluingLamina As New UC_NxtProcessGluingLamina
            UC_NxtProcessGluingLamina.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessGluingLamina.Show()
            UC_NxtProcessGluingLamina.Dock = DockStyle.Fill


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
End Class
