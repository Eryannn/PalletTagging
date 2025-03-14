Public Class FRM_AddProductionRunOffset
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub


    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        FRM_MonitoringChecklistMain.Show()
        Me.Close()

        Dim i As Integer
        For i = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(i)
        Next

        Dim UC_OperatorOff As New UC_OperatorOffset
        UC_OperatorOff.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorOff.Show()
        UC_OperatorOff.Dock = DockStyle.Fill



    End Sub

    Private Sub BTN_SaveProcessMonitoring_Click(sender As Object, e As EventArgs) Handles BTN_SaveProcessMonitoring.Click


        Dim OFVrnVisc07to09valDecimal As Double
        Dim OFVrnVisc10to12valDecimal As Double
        Dim OFVrnVisc01to03valDecimal As Double
        Dim OFVrnVisc04to06valDecimal As Double


        Double.TryParse(TXT_Vanish7AM_9AM.Text, OFVrnVisc07to09valDecimal)
        Double.TryParse(TXT_Vanish10AM_12PN.Text, OFVrnVisc10to12valDecimal)
        Double.TryParse(TXT_Vanish1PM_300PM.Text, OFVrnVisc01to03valDecimal)
        Double.TryParse(TXT_Vanish4PM_600PM.Text, OFVrnVisc04to06valDecimal)


        Dim Temp7AM_900AMDecimal As Double
        Dim Temp10AM_1200PMDecimal As Double
        Dim Temp1PM_3PMDecimal As Double
        Dim Temp4PM_6PMDecimal As Double


        Double.TryParse(TXT_Temp7AM_900AM.Text, Temp7AM_900AMDecimal)
        Double.TryParse(TXT_Temp10AM_1200PM.Text, Temp10AM_1200PMDecimal)
        Double.TryParse(TXT_Temp1PM_3PM.Text, Temp1PM_3PMDecimal)
        Double.TryParse(TXT_Temp4PM_6PM.Text, Temp4PM_6PMDecimal)




        Dim Conductivity7AM_9AMDecimal As Double
        Dim Conductivity10AM_12PMDecimal As Double
        Dim Conductivity1PM_3PMDecimal As Double
        Dim Conductivity4PM_6PMDecimal As Double


        Double.TryParse(TXT_Conductivity7AM_9AM.Text, Conductivity7AM_9AMDecimal)
        Double.TryParse(TXT_Conductivity10AM_12PM.Text, Conductivity10AM_12PMDecimal)
        Double.TryParse(TXT_Conductivity1PM_3PM.Text, Conductivity1PM_3PMDecimal)
        Double.TryParse(TXT_Conductivity4PM_6PM.Text, Conductivity4PM_6PMDecimal)



        Dim ph7AM_9AMDecimal As Double
        Dim ph10AM_12PMDecimal As Double
        Dim ph1PM_3PMDecimal As Double
        Dim ph4PM_6PMDecimal As Double


        Double.TryParse(TXT_ph7AM_9AM.Text, ph7AM_9AMDecimal)
        Double.TryParse(TXT_ph10AM_12PM.Text, ph10AM_12PMDecimal)
        Double.TryParse(TXT_ph1PM_3PM.Text, ph1PM_3PMDecimal)
        Double.TryParse(TXT_ph4PM_6PM.Text, ph4PM_6PMDecimal)




        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_OFF WHERE Site = @site  And mcnum  = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            con.Close()


            Try

                OpenConnection()
                cmd.CommandText = "UPDATE sppmcPRR_OFF SET " &
                              "prr_RESNum = @prr_RESNum, " &
                              "prr_SASNum = @prr_SASNum, " &
                              "prr_OFVrnVisc07to09val = @prr_OFVrnVisc07to09val, " &
                              "prr_OFVrnVisc10to12val = @prr_OFVrnVisc10to12val, " &
                              "prr_OFVrnVisc01to03val = @prr_OFVrnVisc01to03val, " &
                              "prr_OFVrnVisc04to06val = @prr_OFVrnVisc04to06val, " &
                              "prr_OFFSTemp07to09val = @prr_OFFSTemp07to09val, " &
                              "prr_OFFSTemp10to12val = @prr_OFFSTemp10to12val, " &
                              "prr_OFFSTemp01to03val = @prr_OFFSTemp01to03val, " &
                              "prr_OFFSTemp04to06val = @prr_OFFSTemp04to06val, " &
                              "prr_OFFSCndtvty07to09val = @prr_OFFSCndtvty07to09val, " &
                              "prr_OFFSCndtvty10to12val = @prr_OFFSCndtvty10to12val, " &
                              "prr_OFFSCndtvty01to03val = @prr_OFFSCndtvty01to03val, " &
                              "prr_OFFSCndtvty04to06val = @prr_OFFSCndtvty04to06val, " &
                              "prr_OFFSpH07to09val = @prr_OFFSpH07to09val, " &
                              "prr_OFFSpH10to12val = @prr_OFFSpH10to12val, " &
                              "prr_OFFSpH01to03val = @prr_OFFSpH01to03val, " &
                              "prr_OFFSpH04to06val = @prr_OFFSpH04to06val " &
                              "WHERE Site = @Site AND mcnum = @mcnum"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()

                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text) ' Add your actual values
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)

                    .AddWithValue("@prr_OFVrnVisc07to09val", OFVrnVisc07to09valDecimal)
                    .AddWithValue("@prr_OFVrnVisc10to12val", OFVrnVisc10to12valDecimal)
                    .AddWithValue("@prr_OFVrnVisc01to03val", OFVrnVisc01to03valDecimal)
                    .AddWithValue("@prr_OFVrnVisc04to06val", OFVrnVisc04to06valDecimal)

                    .AddWithValue("@prr_OFFSTemp07to09val", Temp7AM_900AMDecimal)
                    .AddWithValue("@prr_OFFSTemp10to12val", Temp10AM_1200PMDecimal)
                    .AddWithValue("@prr_OFFSTemp01to03val", Temp1PM_3PMDecimal)
                    .AddWithValue("@prr_OFFSTemp04to06val", Temp4PM_6PMDecimal)

                    .AddWithValue("@prr_OFFSCndtvty07to09val", Conductivity7AM_9AMDecimal)
                    .AddWithValue("@prr_OFFSCndtvty10to12val", Conductivity10AM_12PMDecimal)
                    .AddWithValue("@prr_OFFSCndtvty01to03val", Conductivity1PM_3PMDecimal)
                    .AddWithValue("@prr_OFFSCndtvty04to06val", Conductivity4PM_6PMDecimal)

                    .AddWithValue("@prr_OFFSpH07to09val", ph7AM_9AMDecimal)
                    .AddWithValue("@prr_OFFSpH10to12val", ph10AM_12PMDecimal)
                    .AddWithValue("@prr_OFFSpH01to03val", ph1PM_3PMDecimal)
                    .AddWithValue("@prr_OFFSpH04to06val", ph4PM_6PMDecimal)

                    '.AddWithValue("@prr_OFVrnVisc07to09val", TXT_Vanish7AM_9AM.Text)
                    '.AddWithValue("@prr_OFVrnVisc10to12val", TXT_Vanish10AM_12PN.Text)
                    '.AddWithValue("@prr_OFVrnVisc01to03val", TXT_Vanish1PM_300PM.Text)
                    '.AddWithValue("@prr_OFVrnVisc04to06val", TXT_Vanish4PM_600PM.Text)

                    '.AddWithValue("@prr_OFFSTemp07to09val", TXT_Temp7AM_900AM.Text)
                    '.AddWithValue("@prr_OFFSTemp10to12val", TXT_Vanish10AM_12PN.Text)
                    '.AddWithValue("@prr_OFFSTemp01to03val", TXT_Temp1PM_3PM.Text)
                    '.AddWithValue("@prr_OFFSTemp04to06val", TXT_Temp4PM_6PM.Text)

                    '.AddWithValue("@prr_OFFSCndtvty07to09val", TXT_Conductivity7AM_9AM.Text)
                    '.AddWithValue("@prr_OFFSCndtvty10to12val", TXT_Conductivity10AM_12PM.Text)
                    '.AddWithValue("@prr_OFFSCndtvty01to03val", TXT_Conductivity1PM_3PM.Text)
                    '.AddWithValue("@prr_OFFSCndtvty04to06val", TXT_Conductivity4PM_6PM.Text)

                    '.AddWithValue("@prr_OFFSpH07to09val", TXT_ph7AM_9AM.Text)
                    '.AddWithValue("@prr_OFFSpH10to12val", TXT_ph10AM_12PM.Text)
                    '.AddWithValue("@prr_OFFSpH01to03val", TXT_ph1PM_3PM.Text)
                    '.AddWithValue("@prr_OFFSpH04to06val", TXT_ph4PM_6PM.Text)

                End With

                cmd.ExecuteNonQuery()
                con.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try






        Else
            con.Close()



            Try

                OpenConnection()
                cmd.CommandText = "Insert_sppmcPRR_OFF"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)
                    .AddWithValue("@prr_OFInkVrnLd0700", "")
                    .AddWithValue("@prr_OFInkVrnLd0800", "")
                    .AddWithValue("@prr_OFInkVrnLd0900", "")
                    .AddWithValue("@prr_OFInkVrnLd1000", "")
                    .AddWithValue("@prr_OFInkVrnLd1100", "")
                    .AddWithValue("@prr_OFInkVrnLd1200", "")
                    .AddWithValue("@prr_OFInkVrnLd0100", "")
                    .AddWithValue("@prr_OFInkVrnLd0200", "")
                    .AddWithValue("@prr_OFInkVrnLd0300", "")
                    .AddWithValue("@prr_OFInkVrnLd0400", "")
                    .AddWithValue("@prr_OFInkVrnLd0500", "")
                    .AddWithValue("@prr_OFInkVrnLd0600", "")
                    .AddWithValue("@prr_OFInkVrnLd07to09val", 0.00)
                    .AddWithValue("@prr_OFInkVrnLd10to12val", 0.00)
                    .AddWithValue("@prr_OFInkVrnLd01to03val", 0.00)
                    .AddWithValue("@prr_OFInkVrnLd04to06val", 0.00)

                    .AddWithValue("@prr_OFVrnVisc07to09val", OFVrnVisc07to09valDecimal)
                    .AddWithValue("@prr_OFVrnVisc10to12val", OFVrnVisc10to12valDecimal)
                    .AddWithValue("@prr_OFVrnVisc01to03val", OFVrnVisc01to03valDecimal)
                    .AddWithValue("@prr_OFVrnVisc04to06val", OFVrnVisc04to06valDecimal)

                    .AddWithValue("@prr_OFFSTemp07to09val", Temp7AM_900AMDecimal)
                    .AddWithValue("@prr_OFFSTemp10to12val", Temp10AM_1200PMDecimal)
                    .AddWithValue("@prr_OFFSTemp01to03val", Temp1PM_3PMDecimal)
                    .AddWithValue("@prr_OFFSTemp04to06val", Temp4PM_6PMDecimal)

                    .AddWithValue("@prr_OFFSCndtvty07to09val", Conductivity7AM_9AMDecimal)
                    .AddWithValue("@prr_OFFSCndtvty10to12val", Conductivity10AM_12PMDecimal)
                    .AddWithValue("@prr_OFFSCndtvty01to03val", Conductivity1PM_3PMDecimal)
                    .AddWithValue("@prr_OFFSCndtvty04to06val", Conductivity4PM_6PMDecimal)

                    .AddWithValue("@prr_OFFSpH07to09val", ph7AM_9AMDecimal)
                    .AddWithValue("@prr_OFFSpH10to12val", ph10AM_12PMDecimal)
                    .AddWithValue("@prr_OFFSpH01to03val", ph1PM_3PMDecimal)
                    .AddWithValue("@prr_OFFSpH04to06val", ph4PM_6PMDecimal)
                    .AddWithValue("@prr_OFOffColor0700", "")
                    .AddWithValue("@prr_OFOffColor0800", "")
                    .AddWithValue("@prr_OFOffColor0900", "")
                    .AddWithValue("@prr_OFOffColor1000", "")
                    .AddWithValue("@prr_OFOffColor1100", "")
                    .AddWithValue("@prr_OFOffColor1200", "")
                    .AddWithValue("@prr_OFOffColor0100", "")
                    .AddWithValue("@prr_OFOffColor0200", "")
                    .AddWithValue("@prr_OFOffColor0300", "")
                    .AddWithValue("@prr_OFOffColor0400", "")
                    .AddWithValue("@prr_OFOffColor0500", "")
                    .AddWithValue("@prr_OFOffColor0600", "")
                    .AddWithValue("@prr_OFOffColor0700val", "")
                    .AddWithValue("@prr_OFOffColor0800val", "")
                    .AddWithValue("@prr_OFOffColor0900val", "")
                    .AddWithValue("@prr_OFOffColor1000val", "")
                    .AddWithValue("@prr_OFOffColor1100val", "")
                    .AddWithValue("@prr_OFOffColor1200val", "")
                    .AddWithValue("@prr_OFOffColor0100val", "")
                    .AddWithValue("@prr_OFOffColor0200val", "")
                    .AddWithValue("@prr_OFOffColor0300val", "")
                    .AddWithValue("@prr_OFOffColor0400val", "")
                    .AddWithValue("@prr_OFOffColor0500val", "")
                    .AddWithValue("@prr_OFOffColor0600val", "")
                    .AddWithValue("@prr_OFBarbak0700", "")
                    .AddWithValue("@prr_OFBarbak0800", "")
                    .AddWithValue("@prr_OFBarbak0900", "")
                    .AddWithValue("@prr_OFBarbak1000", "")
                    .AddWithValue("@prr_OFBarbak1100", "")
                    .AddWithValue("@prr_OFBarbak1200", "")
                    .AddWithValue("@prr_OFBarbak0100", "")
                    .AddWithValue("@prr_OFBarbak0200", "")
                    .AddWithValue("@prr_OFBarbak0300", "")
                    .AddWithValue("@prr_OFBarbak0400", "")
                    .AddWithValue("@prr_OFBarbak0500", "")
                    .AddWithValue("@prr_OFBarbak0600", "")
                    .AddWithValue("@prr_OFBarbak0700val", "")
                    .AddWithValue("@prr_OFBarbak0800val", "")
                    .AddWithValue("@prr_OFBarbak0900val", "")
                    .AddWithValue("@prr_OFBarbak1000val", "")
                    .AddWithValue("@prr_OFBarbak1100val", "")
                    .AddWithValue("@prr_OFBarbak1200val", "")
                    .AddWithValue("@prr_OFBarbak0100val", "")
                    .AddWithValue("@prr_OFBarbak0200val", "")
                    .AddWithValue("@prr_OFBarbak0300val", "")
                    .AddWithValue("@prr_OFBarbak0400val", "")
                    .AddWithValue("@prr_OFBarbak0500val", "")
                    .AddWithValue("@prr_OFBarbak0600val", "")
                    .AddWithValue("@prr_OFHawa0700", "")
                    .AddWithValue("@prr_OFHawa0800", "")
                    .AddWithValue("@prr_OFHawa0900", "")
                    .AddWithValue("@prr_OFHawa1000", "")
                    .AddWithValue("@prr_OFHawa1100", "")
                    .AddWithValue("@prr_OFHawa1200", "")
                    .AddWithValue("@prr_OFHawa0100", "")
                    .AddWithValue("@prr_OFHawa0200", "")
                    .AddWithValue("@prr_OFHawa0300", "")
                    .AddWithValue("@prr_OFHawa0400", "")
                    .AddWithValue("@prr_OFHawa0500", "")
                    .AddWithValue("@prr_OFHawa0600", "")
                    .AddWithValue("@prr_OFHawa0700val", "")
                    .AddWithValue("@prr_OFHawa0800val", "")
                    .AddWithValue("@prr_OFHawa0900val", "")
                    .AddWithValue("@prr_OFHawa1000val", "")
                    .AddWithValue("@prr_OFHawa1100val", "")
                    .AddWithValue("@prr_OFHawa1200val", "")
                    .AddWithValue("@prr_OFHawa0100val", "")
                    .AddWithValue("@prr_OFHawa0200val", "")
                    .AddWithValue("@prr_OFHawa0300val", "")
                    .AddWithValue("@prr_OFHawa0400val", "")
                    .AddWithValue("@prr_OFHawa0500val", "")
                    .AddWithValue("@prr_OFHawa0600val", "")
                    .AddWithValue("@prr_OFSlurring0700", "")
                    .AddWithValue("@prr_OFSlurring0800", "")
                    .AddWithValue("@prr_OFSlurring0900", "")
                    .AddWithValue("@prr_OFSlurring1000", "")
                    .AddWithValue("@prr_OFSlurring1100", "")
                    .AddWithValue("@prr_OFSlurring1200", "")
                    .AddWithValue("@prr_OFSlurring0100", "")
                    .AddWithValue("@prr_OFSlurring0200", "")
                    .AddWithValue("@prr_OFSlurring0300", "")
                    .AddWithValue("@prr_OFSlurring0400", "")
                    .AddWithValue("@prr_OFSlurring0500", "")
                    .AddWithValue("@prr_OFSlurring0600", "")
                    .AddWithValue("@prr_OFSlurring0700val", "")
                    .AddWithValue("@prr_OFSlurring0800val", "")
                    .AddWithValue("@prr_OFSlurring0900val", "")
                    .AddWithValue("@prr_OFSlurring1000val", "")
                    .AddWithValue("@prr_OFSlurring1100val", "")
                    .AddWithValue("@prr_OFSlurring1200val", "")
                    .AddWithValue("@prr_OFSlurring0100val", "")
                    .AddWithValue("@prr_OFSlurring0200val", "")
                    .AddWithValue("@prr_OFSlurring0300val", "")
                    .AddWithValue("@prr_OFSlurring0400val", "")
                    .AddWithValue("@prr_OFSlurring0500val", "")
                    .AddWithValue("@prr_OFSlurring0600val", "")
                    .AddWithValue("@prr_OFGhostng0700", "")
                    .AddWithValue("@prr_OFGhostng0800", "")
                    .AddWithValue("@prr_OFGhostng0900", "")
                    .AddWithValue("@prr_OFGhostng1000", "")
                    .AddWithValue("@prr_OFGhostng1100", "")
                    .AddWithValue("@prr_OFGhostng1200", "")
                    .AddWithValue("@prr_OFGhostng0100", "")
                    .AddWithValue("@prr_OFGhostng0200", "")
                    .AddWithValue("@prr_OFGhostng0300", "")
                    .AddWithValue("@prr_OFGhostng0400", "")
                    .AddWithValue("@prr_OFGhostng0500", "")
                    .AddWithValue("@prr_OFGhostng0600", "")
                    .AddWithValue("@prr_OFGhostng0700val", "")

                    .AddWithValue("@prr_OFGhostng0800val", "")
                    .AddWithValue("@prr_OFGhostng0900val", "")
                    .AddWithValue("@prr_OFGhostng1000val", "")
                    .AddWithValue("@prr_OFGhostng1100val", "")
                    .AddWithValue("@prr_OFGhostng1200val", "")
                    .AddWithValue("@prr_OFGhostng0100val", "")
                    .AddWithValue("@prr_OFGhostng0200val", "")
                    .AddWithValue("@prr_OFGhostng0300val", "")
                    .AddWithValue("@prr_OFGhostng0400val", "")
                    .AddWithValue("@prr_OFGhostng0500val", "")
                    .AddWithValue("@prr_OFGhostng0600val", "")
                    .AddWithValue("@prr_OFGalaw0700", "")
                    .AddWithValue("@prr_OFGalaw0800", "")
                    .AddWithValue("@prr_OFGalaw0900", "")
                    .AddWithValue("@prr_OFGalaw1000", "")
                    .AddWithValue("@prr_OFGalaw1100", "")
                    .AddWithValue("@prr_OFGalaw1200", "")
                    .AddWithValue("@prr_OFGalaw0100", "")
                    .AddWithValue("@prr_OFGalaw0200", "")
                    .AddWithValue("@prr_OFGalaw0300", "")
                    .AddWithValue("@prr_OFGalaw0400", "")
                    .AddWithValue("@prr_OFGalaw0500", "")
                    .AddWithValue("@prr_OFGalaw0600", "")
                    .AddWithValue("@prr_OFGalaw0700val", "")
                    .AddWithValue("@prr_OFGalaw0800val", "")
                    .AddWithValue("@prr_OFGalaw0900val", "")
                    .AddWithValue("@prr_OFGalaw1000val", "")
                    .AddWithValue("@prr_OFGalaw1100val", "")
                    .AddWithValue("@prr_OFGalaw1200val", "")
                    .AddWithValue("@prr_OFGalaw0100val", "")
                    .AddWithValue("@prr_OFGalaw0200val", "")
                    .AddWithValue("@prr_OFGalaw0300val", "")
                    .AddWithValue("@prr_OFGalaw0400val", "")
                    .AddWithValue("@prr_OFGalaw0500val", "")
                    .AddWithValue("@prr_OFGalaw0600val", "")
                    .AddWithValue("@prr_OFLubog0700", "")
                    .AddWithValue("@prr_OFLubog0800", "")
                    .AddWithValue("@prr_OFLubog0900", "")
                    .AddWithValue("@prr_OFLubog1000", "")
                    .AddWithValue("@prr_OFLubog1100", "")
                    .AddWithValue("@prr_OFLubog1200", "")
                    .AddWithValue("@prr_OFLubog0100", "")
                    .AddWithValue("@prr_OFLubog0200", "")
                    .AddWithValue("@prr_OFLubog0300", "")
                    .AddWithValue("@prr_OFLubog0400", "")
                    .AddWithValue("@prr_OFLubog0500", "")
                    .AddWithValue("@prr_OFLubog0600", "")
                    .AddWithValue("@prr_OFLubog0700val", "")
                    .AddWithValue("@prr_OFLubog0800val", "")
                    .AddWithValue("@prr_OFLubog0900val", "")
                    .AddWithValue("@prr_OFLubog1000val", "")
                    .AddWithValue("@prr_OFLubog1100val", "")
                    .AddWithValue("@prr_OFLubog1200val", "")
                    .AddWithValue("@prr_OFLubog0100val", "")
                    .AddWithValue("@prr_OFLubog0200val", "")
                    .AddWithValue("@prr_OFLubog0300val", "")
                    .AddWithValue("@prr_OFLubog0400val", "")
                    .AddWithValue("@prr_OFLubog0500val", "")
                    .AddWithValue("@prr_OFLubog0600val", "")
                    .AddWithValue("@prr_OFSpot0700", "")
                    .AddWithValue("@prr_OFSpot0800", "")
                    .AddWithValue("@prr_OFSpot0900", "")
                    .AddWithValue("@prr_OFSpot1000", "")
                    .AddWithValue("@prr_OFSpot1100", "")
                    .AddWithValue("@prr_OFSpot1200", "")
                    .AddWithValue("@prr_OFSpot0100", "")
                    .AddWithValue("@prr_OFSpot0200", "")
                    .AddWithValue("@prr_OFSpot0300", "")
                    .AddWithValue("@prr_OFSpot0400", "")
                    .AddWithValue("@prr_OFSpot0500", "")
                    .AddWithValue("@prr_OFSpot0600", "")
                    .AddWithValue("@prr_OFSpot0700val", "")
                    .AddWithValue("@prr_OFSpot0800val", "")
                    .AddWithValue("@prr_OFSpot0900val", "")
                    .AddWithValue("@prr_OFSpot1000val", "")
                    .AddWithValue("@prr_OFSpot1100val", "")
                    .AddWithValue("@prr_OFSpot1200val", "")
                    .AddWithValue("@prr_OFSpot0100val", "")
                    .AddWithValue("@prr_OFSpot0200val", "")
                    .AddWithValue("@prr_OFSpot0300val", "")
                    .AddWithValue("@prr_OFSpot0400val", "")
                    .AddWithValue("@prr_OFSpot0500val", "")
                    .AddWithValue("@prr_OFSpot0600val", "")
                    .AddWithValue("@prr_OFTapetst0700", "")
                    .AddWithValue("@prr_OFTapetst0800", "")
                    .AddWithValue("@prr_OFTapetst0900", "")
                    .AddWithValue("@prr_OFTapetst1000", "")
                    .AddWithValue("@prr_OFTapetst1100", "")
                    .AddWithValue("@prr_OFTapetst1200", "")
                    .AddWithValue("@prr_OFTapetst0100", "")
                    .AddWithValue("@prr_OFTapetst0200", "")
                    .AddWithValue("@prr_OFTapetst0300", "")
                    .AddWithValue("@prr_OFTapetst0400", "")
                    .AddWithValue("@prr_OFTapetst0500", "")
                    .AddWithValue("@prr_OFTapetst0600", "")
                    .AddWithValue("@prr_OFTapetst0700val", "")
                    .AddWithValue("@prr_OFTapetst0800val", "")
                    .AddWithValue("@prr_OFTapetst0900val", "")
                    .AddWithValue("@prr_OFTapetst1000val", "")
                    .AddWithValue("@prr_OFTapetst1100val", "")
                    .AddWithValue("@prr_OFTapetst1200val", "")
                    .AddWithValue("@prr_OFTapetst0100val", "")
                    .AddWithValue("@prr_OFTapetst0200val", "")
                    .AddWithValue("@prr_OFTapetst0300val", "")
                    .AddWithValue("@prr_OFTapetst0400val", "")
                    .AddWithValue("@prr_OFTapetst0500val", "")
                    .AddWithValue("@prr_OFTapetst0600val", "")
                End With
                cmd.ExecuteNonQuery()
                con.Close()



            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try







        End If
        dr.Close()
        con.Close()



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

        MsgBox("Successfully saved!")

    End Sub


    Private Sub FRM_AddProductionRunOffset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcPRR_OFF"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@Site", Form1.cmb_site.Text)
                .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            End With

            ' Execute the reader
            dr = cmd.ExecuteReader()

            ' Check if there are rows before accessing the data
            If dr.HasRows Then
                While dr.Read() ' Use While to read all rows if needed
                    TXT_Vanish7AM_9AM.Text = dr("prr_OFVrnVisc07to09val").ToString()
                    TXT_Vanish10AM_12PN.Text = dr("prr_OFVrnVisc10to12val").ToString()
                    TXT_Vanish1PM_300PM.Text = dr("prr_OFVrnVisc01to03val").ToString()
                    TXT_Vanish4PM_600PM.Text = dr("prr_OFVrnVisc04to06val").ToString()

                    TXT_Temp7AM_900AM.Text = dr("prr_OFFSTemp07to09val").ToString()
                    TXT_Temp10AM_1200PM.Text = dr("prr_OFFSTemp10to12val").ToString()
                    TXT_Temp1PM_3PM.Text = dr("prr_OFFSTemp01to03val").ToString()
                    TXT_Temp4PM_6PM.Text = dr("prr_OFFSTemp04to06val").ToString()

                    TXT_Conductivity7AM_9AM.Text = dr("prr_OFFSCndtvty07to09val").ToString()
                    TXT_Conductivity10AM_12PM.Text = dr("prr_OFFSCndtvty10to12val").ToString()
                    TXT_Conductivity1PM_3PM.Text = dr("prr_OFFSCndtvty01to03val").ToString()
                    TXT_Conductivity4PM_6PM.Text = dr("prr_OFFSCndtvty04to06val").ToString()

                    TXT_ph7AM_9AM.Text = dr("prr_OFFSpH07to09val").ToString()
                    TXT_ph10AM_12PM.Text = dr("prr_OFFSpH10to12val").ToString()
                    TXT_ph1PM_3PM.Text = dr("prr_OFFSpH01to03val").ToString()
                    TXT_ph4PM_6PM.Text = dr("prr_OFFSpH04to06val").ToString()

                    TXT_ResNo.Text = dr("prr_RESNum").ToString()
                    TXT_SasNo.Text = dr("prr_SASNum").ToString()
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the reader and the connection in the Finally block
            If Not dr Is Nothing Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click

        Dim selectedInkVarnishLoad As String = ""

        If RBT_InkVarnishLoadCheck.Checked Then
            selectedInkVarnishLoad = "O"
        ElseIf RBT_InkVarnishLoadX.Checked Then
            selectedInkVarnishLoad = "X"
        ElseIf RBT_InkVarnishLoadNA.Checked Then
            selectedInkVarnishLoad = "N"
        End If



        Dim selectedOffColorScum As String = ""

        If RBT_OffColorScumCheck.Checked Then
            selectedOffColorScum = "O"
        ElseIf RBT_OffColorScumX.Checked Then
            selectedOffColorScum = "X"
        ElseIf RBT_OffColorScumNA.Checked Then
            selectedOffColorScum = "N"
        End If



        Dim selectedBaradoBakbak As String = ""

        If RBT_BaradoBakbakCheck.Checked Then
            selectedBaradoBakbak = "O"
        ElseIf RBT_BaradoBakbakX.Checked Then
            selectedBaradoBakbak = "X"
        ElseIf RBT_BaradoBakbakNA.Checked Then
            selectedBaradoBakbak = "N"
        End If


        Dim selectedHawaDoubling As String = ""

        If RBT_HawaDoublingCheck.Checked Then
            selectedHawaDoubling = "O"
        ElseIf RBT_HawaDoublingX.Checked Then
            selectedHawaDoubling = "X"
        ElseIf RBT_HawaDoublingNA.Checked Then
            selectedHawaDoubling = "N"
        End If



        Dim selectedSlurring As String = ""

        If RBT_SlurringCheck.Checked Then
            selectedSlurring = "O"
        ElseIf RBT_SlurringX.Checked Then
            selectedSlurring = "X"
        ElseIf RBT_SlurringNA.Checked Then
            selectedSlurring = "N"
        End If



        Dim selectedGhosting As String = ""

        If RBT_GhostingCheck.Checked Then
            selectedGhosting = "O"
        ElseIf RBT_GhostingX.Checked Then
            selectedGhosting = "X"
        ElseIf RBT_GhostingNA.Checked Then
            selectedGhosting = "N"
        End If



        Dim selectedGalaw As String = ""

        If RBT_GalawCheck.Checked Then
            selectedGalaw = "O"
        ElseIf RBT_GalawX.Checked Then
            selectedGalaw = "X"
        ElseIf RBT_GalawNA.Checked Then
            selectedGalaw = "N"
        End If




        Dim selectedLubog As String = ""

        If RBT_LubogCheck.Checked Then
            selectedLubog = "O"
        ElseIf RBT_LubogX.Checked Then
            selectedLubog = "X"
        ElseIf RBT_LubogNA.Checked Then
            selectedLubog = "N"
        End If



        Dim selectedSpot As String = ""

        If RBT_SpotCheck.Checked Then
            selectedSpot = "O"
        ElseIf RBT_SpotX.Checked Then
            selectedSpot = "X"
        ElseIf RBT_SpotNA.Checked Then
            selectedSpot = "N"
        End If





        Dim selectedTapeTest As String = ""

        If RBT_TapeTestCheck.Checked Then
            selectedTapeTest = "O"
        ElseIf RBT_TapeTestX.Checked Then
            selectedTapeTest = "X"
        ElseIf RBT_TapeTestNA.Checked Then
            selectedTapeTest = "N"
        End If

        Dim selectedEReading As String = ""

        If RBT_EReadingCheck.Checked Then
            selectedEReading = "O"
        ElseIf RBT_EReadingX.Checked Then
            selectedEReading = "X"
        ElseIf RBT_EReadingNA.Checked Then
            selectedEReading = "N"
        End If



        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_OFF WHERE Site = @site  And mcnum  = @mcnum"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@site", Form1.cmb_site.Text)
        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        dr = cmd.ExecuteReader()


        If dr.HasRows Then
            dr.Close()
            con.Close()


            OpenConnection()

            cmd.CommandText = "
                                SELECT time
                                FROM [dbo].[timemaintenance]
                                WHERE 
                                    (time NOT LIKE '%30%' OR time = '0300')
                                    AND time BETWEEN @FromTime AND @ToTime
                                ORDER BY time ASC"
            cmd.CommandType = CommandType.Text

            'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE (time NOT LIKE '%30%' OR time = '0300')AND ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "
            'cmd.CommandType = CommandType.Text

            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance] WHERE time >= @FromTime Or time <= @ToTime"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FromTime", CBO_FromTime.Text)
            cmd.Parameters.AddWithValue("@ToTime", ComboBox1.Text)
            dr = cmd.ExecuteReader()

            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime And @ToTime order by time ASC"

            If dr.HasRows Then

                Dim times As New List(Of String)
                While dr.Read()
                    times.Add(dr("time").ToString())
                End While
                dr.Close()

                For Each vartime As String In times



                    cmd.CommandText = $"UPDATE sppmcPRR_OFF 
                           SET prr_OFInkVrnLd{vartime} = @prr_OFInkVrnLd, 
                               prr_OFOffColor{vartime} = @prr_OFOffColor, 
                               prr_OFOffColor{vartime}val = @prr_OFOffColorval, 
                               prr_OFEread{vartime} = @prr_OFEread,
                               prr_OFEread{vartime}val = @prr_OFEreadval,
                               prr_OFBarbak{vartime} = @prr_OFBarbak, 
                               prr_OFBarbak{vartime}val = @prr_OFBarbakval, 
                               prr_OFHawa{vartime} = @prr_OFHawa, 
                               prr_OFHawa{vartime}val = @prr_OFHawaval, 
                               prr_OFSlurring{vartime} = @prr_OFSlurring, 
                               prr_OFSlurring{vartime}val = @prr_OFSlurringval, 
                               prr_OFGhostng{vartime} = @prr_OFGhostng, 
                               prr_OFGhostng{vartime}val = @prr_OFGhostngval, 
                               prr_OFGalaw{vartime} = @prr_OFGalaw, 
                               prr_OFGalaw{vartime}val = @prr_OFGalawval, 
                               prr_OFLubog{vartime} = @prr_OFLubog, 
                               prr_OFLubog{vartime}val = @prr_OFLubogval,
                               prr_OFSpot{vartime} = @prr_OFSpot, 
                               prr_OFSpot{vartime}val = @prr_OFSpotval,
                               prr_OFTapetst{vartime} = @prr_OFTapetst, 
                               prr_OFTapetst{vartime}val = @prr_OFTapetstval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_OFInkVrnLd", selectedInkVarnishLoad)
                        .AddWithValue("@prr_OFOffColor", selectedOffColorScum)
                        .AddWithValue("@prr_OFOffColorval", TXT_OffColorScum.Text)

                        .AddWithValue("@prr_OFBarbak", selectedBaradoBakbak)
                        .AddWithValue("@prr_OFBarbakval", TXT_BaradoBakbak.Text)

                        .AddWithValue("@prr_OFHawa", selectedHawaDoubling)
                        .AddWithValue("@prr_OFHawaval", TXT_HawaDoubling.Text)

                        .AddWithValue("@prr_OFSlurring", selectedSlurring)
                        .AddWithValue("@prr_OFSlurringval", TXT_Slurring.Text)

                        .AddWithValue("@prr_OFGhostng", selectedGhosting)
                        .AddWithValue("@prr_OFGhostngval", TXT_Ghosting.Text)

                        .AddWithValue("@prr_OFGalaw", selectedGalaw)
                        .AddWithValue("@prr_OFGalawval", TXT_Galaw.Text)

                        .AddWithValue("@prr_OFLubog", selectedLubog)
                        .AddWithValue("@prr_OFLubogval", TXT_Lubog.Text)

                        .AddWithValue("@prr_OFSpot", selectedSpot)
                        .AddWithValue("@prr_OFSpotval", TXT_Spot.Text)

                        .AddWithValue("@prr_OFTapetst", selectedTapeTest)
                        .AddWithValue("@prr_OFTapetstval", TXT_TapeTest.Text)

                        .AddWithValue("@prr_OFEread", selectedEReading)
                        .AddWithValue("@prr_OFEreadval", TXT_EReading.Text)
                    End With
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                MsgBox("Successfully updated!")
            End If



        Else
            dr.Close()
            con.Close()





            OpenConnection()

            cmd.CommandText = "INSERT INTO sppmcPRR_OFF (Site, mcnum) VALUES (@Site, @mcnum)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            OpenConnection()

            cmd.CommandText = "
                                SELECT time
                                FROM [dbo].[timemaintenance]
                                WHERE 
                                    (time NOT LIKE '%30%' OR time = '0300')
                                    AND time BETWEEN @FromTime AND @ToTime
                                ORDER BY time ASC"
            cmd.CommandType = CommandType.Text
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


                    cmd.CommandText = $"UPDATE sppmcPRR_OFF 
                           SET prr_OFInkVrnLd{vartime} = @prr_OFInkVrnLd, 
                               prr_OFOffColor{vartime} = @prr_OFOffColor, 
                               prr_OFOffColor{vartime}val = @prr_OFOffColorval, 
                               prr_OFEread{vartime} = @prr_OFEread,
                               prr_OFEread{vartime}val = @prr_OFEreadval,
                               prr_OFBarbak{vartime} = @prr_OFBarbak, 
                               prr_OFBarbak{vartime}val = @prr_OFBarbakval, 
                               prr_OFHawa{vartime} = @prr_OFHawa, 
                               prr_OFHawa{vartime}val = @prr_OFHawaval, 
                               prr_OFSlurring{vartime} = @prr_OFSlurring, 
                               prr_OFSlurring{vartime}val = @prr_OFSlurringval, 
                               prr_OFGhostng{vartime} = @prr_OFGhostng, 
                               prr_OFGhostng{vartime}val = @prr_OFGhostngval, 
                               prr_OFGalaw{vartime} = @prr_OFGalaw, 
                               prr_OFGalaw{vartime}val = @prr_OFGalawval, 
                               prr_OFLubog{vartime} = @prr_OFLubog, 
                               prr_OFLubog{vartime}val = @prr_OFLubogval,
                               prr_OFSpot{vartime} = @prr_OFSpot, 
                               prr_OFSpot{vartime}val = @prr_OFSpotval,
                               prr_OFTapetst{vartime} = @prr_OFTapetst, 
                               prr_OFTapetst{vartime}val = @prr_OFTapetstval
                            WHERE Site = @Site AND mcnum  = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_OFInkVrnLd", selectedInkVarnishLoad)
                        .AddWithValue("@prr_OFOffColor", selectedOffColorScum)
                        .AddWithValue("@prr_OFOffColorval", TXT_OffColorScum.Text)

                        .AddWithValue("@prr_OFBarbak", selectedBaradoBakbak)
                        .AddWithValue("@prr_OFBarbakval", TXT_BaradoBakbak.Text)

                        .AddWithValue("@prr_OFHawa", selectedHawaDoubling)
                        .AddWithValue("@prr_OFHawaval", TXT_HawaDoubling.Text)

                        .AddWithValue("@prr_OFSlurring", selectedSlurring)
                        .AddWithValue("@prr_OFSlurringval", TXT_Slurring.Text)

                        .AddWithValue("@prr_OFGhostng", selectedGhosting)
                        .AddWithValue("@prr_OFGhostngval", TXT_Ghosting.Text)

                        .AddWithValue("@prr_OFGalaw", selectedGalaw)
                        .AddWithValue("@prr_OFGalawval", TXT_Galaw.Text)

                        .AddWithValue("@prr_OFLubog", selectedLubog)
                        .AddWithValue("@prr_OFLubogval", TXT_Lubog.Text)

                        .AddWithValue("@prr_OFSpot", selectedSpot)
                        .AddWithValue("@prr_OFSpotval", TXT_Spot.Text)

                        .AddWithValue("@prr_OFTapetst", selectedTapeTest)
                        .AddWithValue("@prr_OFTapetstval", TXT_TapeTest.Text)

                        .AddWithValue("@prr_OFEread", selectedEReading)
                        .AddWithValue("@prr_OFEreadval", TXT_EReading.Text)
                    End With

                    cmd.ExecuteNonQuery()
                Next
                con.Close()

                MsgBox("successfully saved!")
            End If
        End If
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








    End Sub

    Private Sub RBT_OffColorScumNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffColorScumNA.CheckedChanged
        TXT_OffColorScum.Enabled = False
        TXT_OffColorScum.Text = ""
    End Sub

    Private Sub RBT_OffColorScumX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffColorScumX.CheckedChanged
        TXT_OffColorScum.Enabled = True
    End Sub

    Private Sub RBT_OffColorScumCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_OffColorScumCheck.CheckedChanged
        TXT_OffColorScum.Enabled = False
        TXT_OffColorScum.Text = ""
    End Sub



    Private Sub RBT_BaradoBakbakNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_BaradoBakbakNA.CheckedChanged
        TXT_BaradoBakbak.Enabled = False
        TXT_BaradoBakbak.Text = ""
    End Sub

    Private Sub RBT_BaradoBakbakX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_BaradoBakbakX.CheckedChanged
        TXT_BaradoBakbak.Enabled = True

    End Sub

    Private Sub RBT_BaradoBakbakCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_BaradoBakbakCheck.CheckedChanged
        TXT_BaradoBakbak.Enabled = False
        TXT_BaradoBakbak.Text = ""
    End Sub


    Private Sub RBT_HawaDoublingNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_HawaDoublingNA.CheckedChanged
        TXT_HawaDoubling.Enabled = False
        TXT_HawaDoubling.Text = ""

    End Sub

    Private Sub RBT_HawaDoublingX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_HawaDoublingX.CheckedChanged
        TXT_HawaDoubling.Enabled = True

    End Sub

    Private Sub RBT_HawaDoublingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_HawaDoublingCheck.CheckedChanged
        TXT_HawaDoubling.Enabled = False
        TXT_HawaDoubling.Text = ""
    End Sub

    Private Sub RBT_SlurringNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SlurringNA.CheckedChanged
        TXT_Slurring.Enabled = False
        TXT_Slurring.Text = ""
    End Sub



    Private Sub RBT_SlurringX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SlurringX.CheckedChanged
        TXT_Slurring.Enabled = True

    End Sub

    Private Sub RBT_SlurringCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SlurringCheck.CheckedChanged
        TXT_Slurring.Enabled = False
        TXT_Slurring.Text = ""
    End Sub




    Private Sub RBT_GhostingNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GhostingNA.CheckedChanged
        TXT_Ghosting.Enabled = False
        TXT_Ghosting.Text = ""
    End Sub

    Private Sub RBT_GhostingX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GhostingX.CheckedChanged
        TXT_Ghosting.Enabled = True

    End Sub

    Private Sub RBT_GhostingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GhostingCheck.CheckedChanged
        TXT_Ghosting.Enabled = False
        TXT_Ghosting.Text = ""
    End Sub



    Private Sub RBT_GalawNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GalawNA.CheckedChanged
        TXT_Galaw.Enabled = False
        TXT_Galaw.Text = ""
    End Sub

    Private Sub RBT_GalawX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GalawX.CheckedChanged
        TXT_Galaw.Enabled = True

    End Sub

    Private Sub RBT_GalawCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GalawCheck.CheckedChanged
        TXT_Galaw.Enabled = False
        TXT_Galaw.Text = ""
    End Sub




    Private Sub RBT_LubogNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_LubogNA.CheckedChanged
        TXT_Lubog.Enabled = False
        TXT_Lubog.Text = ""

    End Sub

    Private Sub RBT_LubogX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_LubogX.CheckedChanged
        TXT_Lubog.Enabled = True

    End Sub

    Private Sub RBT_LubogCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_LubogCheck.CheckedChanged
        TXT_Lubog.Enabled = False
        TXT_Lubog.Text = ""
    End Sub

    Private Sub RBT_SpotNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SpotNA.CheckedChanged
        TXT_Spot.Enabled = False
        TXT_Spot.Text = ""
    End Sub

    Private Sub RBT_SpotX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SpotX.CheckedChanged
        TXT_Spot.Enabled = True

    End Sub

    Private Sub RBT_SpotCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_SpotCheck.CheckedChanged
        TXT_Spot.Enabled = False
        TXT_Spot.Text = ""
    End Sub

    Private Sub RBT_TapeTestNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TapeTestNA.CheckedChanged
        TXT_TapeTest.Enabled = False
        TXT_TapeTest.Text = ""

    End Sub

    Private Sub RBT_TapeTestX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TapeTestX.CheckedChanged
        TXT_TapeTest.Enabled = True

    End Sub

    Private Sub RBT_TapeTestCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TapeTestCheck.CheckedChanged
        TXT_TapeTest.Enabled = False
        TXT_TapeTest.Text = ""
    End Sub



    Private Sub TXT_OffColorScum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_OffColorScum.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_BaradoBakbak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_BaradoBakbak.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_HawaDoubling_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_HawaDoubling.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_Slurring_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Slurring.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Ghosting_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Ghosting.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Galaw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Galaw.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Lubog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Lubog.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Spot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Spot.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_TapeTest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TapeTest.KeyPress
        NumberOnly(e)
    End Sub










    Private Sub TXT_Vanish7AM_9AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Vanish7AM_9AM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Vanish10AM_12PN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Vanish10AM_12PN.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Vanish1PM_300PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Vanish1PM_300PM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Vanish4PM_600PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Vanish4PM_600PM.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Temp7AM_900AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Temp7AM_900AM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Temp10AM_1200PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Temp10AM_1200PM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Temp1PM_3PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Temp1PM_3PM.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_Temp4PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Temp4PM_6PM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Conductivity7AM_9AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Conductivity7AM_9AM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Conductivity10AM_12PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Conductivity10AM_12PM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Conductivity1PM_3PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Conductivity1PM_3PM.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_Conductivity4PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Conductivity4PM_6PM.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_ph7AM_9AM_TextChanged(sender As Object, e As EventArgs) Handles TXT_ph7AM_9AM.TextChanged

    End Sub

    Private Sub TXT_ph7AM_9AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ph7AM_9AM.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_ph10AM_12PM_TextChanged(sender As Object, e As EventArgs) Handles TXT_ph10AM_12PM.TextChanged

    End Sub

    Private Sub TXT_ph10AM_12PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ph10AM_12PM.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_ph1PM_3PM_TextChanged(sender As Object, e As EventArgs) Handles TXT_ph1PM_3PM.TextChanged

    End Sub

    Private Sub TXT_ph1PM_3PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ph1PM_3PM.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_ph4PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ph4PM_6PM.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub RBT_EReadingNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_EReadingNA.CheckedChanged
        TXT_EReading.Enabled = False
        TXT_EReading.Text = ""
    End Sub

    Private Sub RBT_EReadingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_EReadingCheck.CheckedChanged
        TXT_EReading.Enabled = False
        TXT_EReading.Text = ""
    End Sub

    Private Sub RBT_EReadingX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_EReadingX.CheckedChanged
        TXT_EReading.Enabled = True
    End Sub
End Class