Public Class FRM_AddProductionRunDieCutting
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click
        Dim Site As String = Form1.cmb_site.Text
        Dim selectedMisregistration As String = ""
        Dim selectedCracking As String = ""
        Dim selectedRoughCut As String = ""
        Dim selectedPoorPerforation As String = ""
        Dim selectedWeakEmbossing As String = ""
        Dim selectedBoxFormation As String = ""
        Dim selectedStamping As String = ""




        Dim fromTime As String = CBO_FromTime.Text

        ' Assign values based on radio buttons
        ' (This part remains unchanged from your original code)
        If RBT_MisregistrationCheck.Checked Then
            selectedMisregistration = "O"
        ElseIf RBT_MisregistrationX.Checked Then
            selectedMisregistration = "X"
        ElseIf RBT_MisregistrationCheckNa.Checked Then
            selectedMisregistration = "N"
        End If

        If RBT_CrackingCheck.Checked Then
            selectedCracking = "O"
        ElseIf RBT_CrackingClose.Checked Then
            selectedCracking = "X"
        ElseIf RBT_CrackingCheckNa.Checked Then
            selectedCracking = "N"
        End If



        If RBT_RoughCutCheck.Checked Then
            selectedRoughCut = "O"
        ElseIf RBT_RoughCutClose.Checked Then
            selectedRoughCut = "X"
        ElseIf RBT_RoughCutNa.Checked Then
            selectedRoughCut = "N"
        End If



        If RBT_PoorPerforationCheck.Checked Then
            selectedPoorPerforation = "O"
        ElseIf RBT_PoorPerforationClose.Checked Then
            selectedPoorPerforation = "X"
        ElseIf RBT_PoorPerforationNa.Checked Then
            selectedPoorPerforation = "N"
        End If



        If RBT_WeakEmbossingCheck.Checked Then
            selectedWeakEmbossing = "O"
        ElseIf RBT_WeakEmbossingClose.Checked Then
            selectedWeakEmbossing = "X"
        ElseIf RBT_WeakEmbossingNa.Checked Then
            selectedWeakEmbossing = "N"
        End If

        If RBT_BoxFormationCheck.Checked Then
            selectedBoxFormation = "O"
        ElseIf RBT_BoxFormationClose.Checked Then
            selectedBoxFormation = "X"
        ElseIf RBT_BoxFormationNa.Checked Then
            selectedBoxFormation = "N"
        End If

        If RBT_StampingCheck.Checked Then
            selectedStamping = "O"
        ElseIf RBT_StampingClose.Checked Then
            selectedStamping = "X"
        ElseIf RBT_StampingNa.Checked Then
            selectedStamping = "N"
        End If


        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_DES WHERE Site = @site  And mcnum  = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()


        If dr.HasRows Then
            dr.Close()
            con.Close()


            OpenConnection()

            cmd.CommandText = "Select_TimeMaintenance"
            cmd.CommandType = CommandType.StoredProcedure


            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime And @ToTime order by time ASC"
            'cmd.CommandType = CommandType.Text

            'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "
            'cmd.CommandType = CommandType.Text
            'cmd.CommandText = "SELECT time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime AND @ToTime order by time ASC"

            'cmd.CommandText = "SELECT time FROM [dbo].[timemaintenance] WHERE time >= @FromTime OR time <= @ToTime"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FromTime", CBO_FromTime.Text)
            cmd.Parameters.AddWithValue("@ToTime", ComboBox1.Text)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then

                Dim times As New List(Of String)
                While dr.Read()
                    times.Add(dr("time").ToString())
                End While
                dr.Close()

                For Each vartime As String In times


                    cmd.CommandText = $"UPDATE sppmcPRR_DES 
                           SET 
                               prr_DIMisreg{vartime} = @prr_DIMisreg, 
                               prr_DIMisreg{vartime}val = @prr_DIMisregval, 

                               prr_DICrack{vartime} = @prr_DICrack, 
                               prr_DICrack{vartime}val = @prr_DICrackval, 

                               prr_DIRoughc{vartime} = @prr_DIRoughc, 
                               prr_DIRoughc{vartime}val = @prr_DIRoughcval, 

                               prr_DIPoorPerf{vartime} = @prr_DIPoorPerf, 
                               prr_DIPoorPerf{vartime}val = @prr_DIPoorPerfval, 

                               prr_DIWkEmb{vartime} = @prr_DIWkEmb, 
                               prr_DIWkEmb{vartime}val = @prr_DIWkEmbval, 

                               prr_DIBxForLS{vartime} = @prr_DIBxForLS, 
                               prr_DIBxForLS{vartime}val = @prr_DIBxForLSval, 

                               prr_DIStmpDef{vartime} = @prr_DIStmpDef, 
                               prr_DIStmpDef{vartime}val = @prr_DIStmpDefval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@Site", Site)
                        .AddWithValue("@mcnum", TXT_CheckMCNo.Text)


                        .AddWithValue("@prr_DIMisreg", selectedMisregistration)
                        .AddWithValue("@prr_DIMisregval", TXT_Misregistration.Text)

                        .AddWithValue("@prr_DICrack", selectedCracking)
                        .AddWithValue("@prr_DICrackval", TXT_Crack.Text)


                        .AddWithValue("@prr_DIRoughc", selectedRoughCut)
                        .AddWithValue("@prr_DIRoughcval", TXT_Rough.Text)

                        .AddWithValue("@prr_DIPoorPerf", selectedPoorPerforation)
                        .AddWithValue("@prr_DIPoorPerfval", TXT_PoorPerforation.Text)

                        .AddWithValue("@prr_DIWkEmb", selectedWeakEmbossing)
                        .AddWithValue("@prr_DIWkEmbval", TXT_WeakEmbossing.Text)


                        .AddWithValue("@prr_DIBxForLS", selectedBoxFormation)
                        .AddWithValue("@prr_DIBxForLSval", TXT_BoxFormation.Text)


                        .AddWithValue("@prr_DIStmpDef", selectedStamping)
                        .AddWithValue("@prr_DIStmpDefval", TXT_StampingDefect.Text)

                    End With
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                Next
                con.Close()



                'OpenConnection()
                'cmd.CommandText = "UPDATE "





            End If

            con.Close()

            Try
                OpenConnection()
                cmd.CommandText = "UPDATE sppmcPRR_DES  SET prr_RESNum = @prr_resnum, prr_SASNum = @prr_sasnum  WHERE Site = @Site AND mcnum = @mcnum"
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_resnum", TXT_ResNo.Text)
                    .AddWithValue("@prr_sasnum", TXT_SasNo.Text)
                End With
                cmd.ExecuteNonQuery()
                con.Close()


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                con.Close()

            End Try
            MsgBox("Successfully updated!")



        Else
            dr.Close()
            con.Close()


            'Update to header
            If position = "Operator" Then
                OpenConnection()
                cmd.CommandText = "UPDATE sppmcHdr SET emp_num = @emp_num WHERE Site = @Site AND mcnum = @mcnum"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                With cmd.Parameters

                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@emp_num", FRM_MonitoringChecklistMain.lbl_empnum.Text)

                End With
                cmd.ExecuteNonQuery()
                con.Close()




                OpenConnection()
                cmd.CommandText = "UPDATE sppmcJIC SET jic_Operator = @jic_Operator  WHERE Site = @Site AND mcnum = @mcnum "
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                With cmd.Parameters

                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@jic_Operator", FRM_MonitoringChecklistMain.lbl_empnum.Text)

                End With
                cmd.ExecuteNonQuery()
                con.Close()

                FRM_MonitoringChecklistMain.txt_operator.Text = FRM_MonitoringChecklistMain.lbl_empname.Text

            End If






            OpenConnection()

            cmd.CommandText = "INSERT INTO sppmcPRR_DES (Site, mcnum, prr_RESNum , prr_SASnum) VALUES (@Site, @mcnum, @prr_RESNum, @prr_SASNum)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Site)
            cmd.Parameters.AddWithValue("@mcnum", TXT_CheckMCNo.Text)
            cmd.Parameters.AddWithValue("@prr_RESNum", TXT_ResNo.Text)
            cmd.Parameters.AddWithValue("@prr_SASnum", TXT_SasNo.Text)
            cmd.ExecuteNonQuery()
            con.Close()




            OpenConnection()

            cmd.CommandText = "Select_TimeMaintenance"
            cmd.CommandType = CommandType.StoredProcedure

            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance] WHERE time >= @FromTime Or time <= @ToTime"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FromTime", CBO_FromTime.Text)
            cmd.Parameters.AddWithValue("@ToTime", ComboBox1.Text)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then

                Dim times As New List(Of String)
                While dr.Read()
                    times.Add(dr("time").ToString())
                End While
                dr.Close()

                For Each vartime As String In times


                    cmd.CommandText = $"UPDATE sppmcPRR_DES 
                           SET  
                               prr_DIMisreg{vartime} = @prr_DIMisreg, 
                               prr_DIMisreg{vartime}val = @prr_DIMisregval, 

                               prr_DICrack{vartime} = @prr_DICrack, 
                               prr_DICrack{vartime}val = @prr_DICrackval, 

                               prr_DIRoughc{vartime} = @prr_DIRoughc, 
                               prr_DIRoughc{vartime}val = @prr_DIRoughcval, 

                               prr_DIPoorPerf{vartime} = @prr_DIPoorPerf, 
                               prr_DIPoorPerf{vartime}val = @prr_DIPoorPerfval, 

                               prr_DIWkEmb{vartime} = @prr_DIWkEmb, 
                               prr_DIWkEmb{vartime}val = @prr_DIWkEmbval, 

                               prr_DIBxForLS{vartime} = @prr_DIBxForLS, 
                               prr_DIBxForLS{vartime}val = @prr_DIBxForLSval, 

                               prr_DIStmpDef{vartime} = @prr_DIStmpDef, 
                               prr_DIStmpDef{vartime}val = @prr_DIStmpDefval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)


                        .AddWithValue("@prr_DIMisreg", selectedMisregistration)
                        .AddWithValue("@prr_DIMisregval", TXT_Misregistration.Text)

                        .AddWithValue("@prr_DICrack", selectedCracking)
                        .AddWithValue("@prr_DICrackval", TXT_Crack.Text)


                        .AddWithValue("@prr_DIRoughc", selectedRoughCut)
                        .AddWithValue("@prr_DIRoughcval", TXT_Rough.Text)

                        .AddWithValue("@prr_DIPoorPerf", selectedPoorPerforation)
                        .AddWithValue("@prr_DIPoorPerfval", TXT_PoorPerforation.Text)

                        .AddWithValue("@prr_DIWkEmb", selectedWeakEmbossing)
                        .AddWithValue("@prr_DIWkEmbval", TXT_WeakEmbossing.Text)


                        .AddWithValue("@prr_DIBxForLS", selectedBoxFormation)
                        .AddWithValue("@prr_DIBxForLSval", TXT_BoxFormation.Text)


                        .AddWithValue("@prr_DIStmpDef", selectedStamping)
                        .AddWithValue("@prr_DIStmpDefval", TXT_StampingDefect.Text)

                    End With
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                Next
                con.Close()

                MsgBox("successfully saved!")
            End If
        End If
        con.Close()

        Dim int As Integer
        For int = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
        Next

        Dim UC_OperatorDC As New UC_OperatorDIeCutting
        UC_OperatorDC.BTN_AddProductionRun.Enabled = True
        UC_OperatorDC.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorDC.Show()
        UC_OperatorDC.Dock = DockStyle.Fill

        FRM_MonitoringChecklistMain.Show()
        Me.Close()

    End Sub

    Private Sub FRM_AddProductionRunDieCutting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenConnection()
        cmd.CommandText = "SELECT * FROM sppmcPRR_DES WHERE Site = @site And mcnum = @mcnum"
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            If dr.Read() Then
                TXT_ResNo.Text = dr("prr_RESNum").ToString()
                TXT_SasNo.Text = dr("prr_SASNum").ToString()
                dr.Close()
                con.Close()
            End If
            con.Close()
        End If
        con.Close()
    End Sub



    Private Sub RBT_MisregistrationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_MisregistrationCheck.CheckedChanged
        TXT_Misregistration.Enabled = False
        TXT_Misregistration.Text = ""
    End Sub

    Private Sub RBT_MisregistrationX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_MisregistrationX.CheckedChanged
        TXT_Misregistration.Enabled = True
    End Sub

    Private Sub RBT_MisregistrationCheckNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_MisregistrationCheckNa.CheckedChanged
        TXT_Misregistration.Enabled = False
        TXT_Misregistration.Text = ""
    End Sub


    Private Sub RBT_CrackingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrackingCheck.CheckedChanged
        TXT_Crack.Enabled = False
        TXT_Crack.Text = ""

    End Sub

    Private Sub RBT_CrackingClose_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrackingClose.CheckedChanged
        TXT_Crack.Enabled = True
    End Sub

    Private Sub RBT_CrackingCheckNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_CrackingCheckNa.CheckedChanged
        TXT_Crack.Enabled = False
        TXT_Crack.Text = ""
    End Sub


    Private Sub RBT_RoughCutCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_RoughCutCheck.CheckedChanged
        TXT_Rough.Enabled = False
        TXT_Rough.Text = ""
    End Sub

    Private Sub RBT_RoughCutClose_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_RoughCutClose.CheckedChanged
        TXT_Rough.Enabled = True

    End Sub

    Private Sub RBT_RoughCutNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_RoughCutNa.CheckedChanged
        TXT_Rough.Enabled = False
        TXT_Rough.Text = ""

    End Sub



    Private Sub RBT_PoorPerforationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PoorPerforationCheck.CheckedChanged
        TXT_PoorPerforation.Enabled = False
        TXT_PoorPerforation.Text = ""
    End Sub

    Private Sub RBT_PoorPerforationClose_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PoorPerforationClose.CheckedChanged
        TXT_PoorPerforation.Enabled = True
    End Sub

    Private Sub RBT_PoorPerforationNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_PoorPerforationNa.CheckedChanged
        TXT_PoorPerforation.Enabled = False
        TXT_PoorPerforation.Text = ""
    End Sub



    Private Sub RBT_WeakEmbossingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_WeakEmbossingCheck.CheckedChanged
        TXT_WeakEmbossing.Enabled = False
        TXT_WeakEmbossing.Text = ""

    End Sub

    Private Sub RBT_WeakEmbossingClose_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_WeakEmbossingClose.CheckedChanged
        TXT_WeakEmbossing.Enabled = True

    End Sub

    Private Sub RBT_WeakEmbossingNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_WeakEmbossingNa.CheckedChanged
        TXT_WeakEmbossing.Enabled = False
        TXT_WeakEmbossing.Text = ""
    End Sub


    Private Sub RBT_BoxFormationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_BoxFormationCheck.CheckedChanged
        TXT_BoxFormation.Enabled = False
        TXT_BoxFormation.Text = ""
    End Sub

    Private Sub RBT_BoxFormationClose_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_BoxFormationClose.CheckedChanged
        TXT_BoxFormation.Enabled = True
    End Sub

    Private Sub RBT_BoxFormationNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_BoxFormationNa.CheckedChanged
        TXT_BoxFormation.Enabled = False
        TXT_BoxFormation.Text = ""
    End Sub

    Private Sub RBT_StampingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_StampingCheck.CheckedChanged
        TXT_StampingDefect.Enabled = False
        TXT_StampingDefect.Text = ""
    End Sub


    Private Sub RBT_StampingClose_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_StampingClose.CheckedChanged
        TXT_StampingDefect.Enabled = True


    End Sub


    Private Sub RBT_StampingNa_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_StampingNa.CheckedChanged
        TXT_StampingDefect.Enabled = False
        TXT_StampingDefect.Text = ""
    End Sub



    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()
    End Sub



    Private Sub TXT_WeakEmbossing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_WeakEmbossing.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_BoxFormation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_BoxFormation.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_StampingDefect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_StampingDefect.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_StampingDefect_TextChanged(sender As Object, e As EventArgs) Handles TXT_StampingDefect.TextChanged

    End Sub

    Private Sub TXT_Misregistration_TextChanged(sender As Object, e As EventArgs) Handles TXT_Misregistration.TextChanged

    End Sub
End Class