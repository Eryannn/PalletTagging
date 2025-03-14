Public Class UC_NxtProcessGluing
    Private Sub UC_NxtProcessGluing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cmd.CommandText = "UPDATE sppmcOutput SET mchout_AckNxtProcSV = @mchout_AckNxtProcSV WHERE Site = @site And mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.Parameters.AddWithValue("@mchout_AckNxtProcSV", FRM_MonitoringChecklistMain.lbl_empnum.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("successfully acknowledge!")


            Dim i As Integer
            For i = 0 To 0
                FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
            Next




            Dim UC_NxtProcessGluing As New UC_NxtProcessGluing
            UC_NxtProcessGluing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
            UC_NxtProcessGluing.Show()
            UC_NxtProcessGluing.Dock = DockStyle.Fill


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

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub TXT_Acknowledge_TextChanged(sender As Object, e As EventArgs) Handles TXT_Acknowledge.TextChanged

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TXT_Remarks_TextChanged(sender As Object, e As EventArgs) Handles TXT_Remarks.TextChanged

    End Sub

    Private Sub TXT_CurSpoilageQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_CurSpoilageQty.TextChanged

    End Sub

    Private Sub TXT_CurRedPalletQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_CurRedPalletQty.TextChanged

    End Sub

    Private Sub TXT_CurGoodQty_TextChanged(sender As Object, e As EventArgs) Handles TXT_CurGoodQty.TextChanged

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub
End Class
