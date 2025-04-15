Public Class FRM_AddProductionRunLamination
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub NumberChar(ByVal e As KeyPressEventArgs)
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

        Dim UC_OperatorLam As New UC_OperatorLamination
        UC_OperatorLam.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorLam.Show()
        UC_OperatorLam.Dock = DockStyle.Fill
    End Sub

    Private Sub BTN_SaveProcessMonitoring_Click(sender As Object, e As EventArgs) Handles BTN_SaveProcessMonitoring.Click
        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        'Glue Load
        Dim selectedGlueLoad7to8AM As String = ""
        Dim selectedGlueLoad7to730AM As String = ""
        Dim selectedGlueLoad9to10AM As String = ""
        Dim selectedGlueLoad930to1030AM As String = ""
        Dim selectedGlueLoad11to12AM As String = ""
        Dim selectedGlueLoad1130to1230PM As String = ""
        Dim selectedGlueLoad1to2PM As String = ""
        Dim selectedGlueLoad130to230PM As String = ""
        Dim selectedGlueLoad3to4PM As String = ""
        Dim selectedGlueLoad330to430PM As String = ""
        Dim selectedGlueLoad5to6PM As String = ""
        Dim selectedGlueLoad530to630PM As String = ""



        If RBT_GlueLoad7to8AMCheck.Checked Then
            selectedGlueLoad7to8AM = "O"
        ElseIf RBT_GlueLoad7to8AMX.Checked Then
            selectedGlueLoad7to8AM = "X"
        Else
            selectedGlueLoad7to8AM = "N"
        End If


        If RBT_GlueLoad730to830AMCheck.Checked Then
            selectedGlueLoad7to730AM = "O"
        ElseIf RBT_GlueLoad730to830AMX.Checked Then
            selectedGlueLoad7to730AM = "X"
        Else
            selectedGlueLoad7to730AM = "N"
        End If


        If RBT_GlueLoad9to10AMCheck.Checked Then
            selectedGlueLoad9to10AM = "O"
        ElseIf RBT_GlueLoad9to10AMX.Checked Then
            selectedGlueLoad9to10AM = "X"
        Else
            selectedGlueLoad9to10AM = "N"
        End If


        If RBT_GlueLoad930to1030AMCheck.Checked Then
            selectedGlueLoad930to1030AM = "O"
        ElseIf RBT_GlueLoad930to1030AMX.Checked Then
            selectedGlueLoad930to1030AM = "X"
        Else
            selectedGlueLoad930to1030AM = "N"
        End If


        If RBT_GlueLoad11to12Check.Checked Then
            selectedGlueLoad11to12AM = "O"
        ElseIf RBT_GlueLoad11to12X.Checked Then
            selectedGlueLoad11to12AM = "X"
        Else
            selectedGlueLoad11to12AM = "N"
        End If


        If RBT_GlueLoad1130to1230Check.Checked Then
            selectedGlueLoad1130to1230PM = "O"
        ElseIf RBT_GlueLoad1130to1230X.Checked Then
            selectedGlueLoad1130to1230PM = "X"
        Else
            selectedGlueLoad1130to1230PM = "N"
        End If



        If RBT_GlueLoad1to2Check.Checked Then
            selectedGlueLoad1to2PM = "O"
        ElseIf RBT_GlueLoad1to2X.Checked Then
            selectedGlueLoad1to2PM = "X"
        Else
            selectedGlueLoad1to2PM = "N"
        End If


        If RBT_GlueLoad130to230Check.Checked Then
            selectedGlueLoad130to230PM = "O"
        ElseIf RBT_GlueLoad130to230X.Checked Then
            selectedGlueLoad130to230PM = "X"
        Else
            selectedGlueLoad130to230PM = "N"
        End If


        If RBT_GlueLoad3to4Check.Checked Then
            selectedGlueLoad3to4PM = "O"
        ElseIf RBT_GlueLoad3to4X.Checked Then
            selectedGlueLoad3to4PM = "X"
        Else
            selectedGlueLoad3to4PM = "N"
        End If


        If RBT_GlueLoad330to430Check.Checked Then
            selectedGlueLoad330to430PM = "O"
        ElseIf RBT_GlueLoad330to430X.Checked Then
            selectedGlueLoad330to430PM = "X"
        Else
            selectedGlueLoad330to430PM = "N"
        End If



        If RBT_GlueLoad5to6Check.Checked Then
            selectedGlueLoad5to6PM = "O"
        ElseIf RBT_GlueLoad5to6X.Checked Then
            selectedGlueLoad5to6PM = "X"
        Else
            selectedGlueLoad5to6PM = "N"
        End If



        If RBT_GlueLoad530to630Check.Checked Then
            selectedGlueLoad530to630PM = "O"
        ElseIf RBT_GlueLoad530to630X.Checked Then
            selectedGlueLoad530to630PM = "X"
        Else
            selectedGlueLoad530to630PM = "N"
        End If
















        'Water load Load

        Dim selectedWaterLoad7to8AM As String = ""
        Dim selectedWaterLoad7to730AM As String = ""
        Dim selectedWaterLoad9to10AM As String = ""
        Dim selectedWaterLoad930to1030AM As String = ""
        Dim selectedWaterLoad11to12AM As String = ""
        Dim selectedWaterLoad1130to1230PM As String = ""
        Dim selectedWaterLoad1to2PM As String = ""
        Dim selectedWaterLoad130to230PM As String = ""
        Dim selectedWaterLoad3to4PM As String = ""
        Dim selectedWaterLoad330to430PM As String = ""
        Dim selectedWaterLoad5to6PM As String = ""
        Dim selectedWaterLoad530to630PM As String = ""




        If RBT_WaterLoad7to8AMCheck.Checked Then
            selectedWaterLoad7to8AM = "O"
        ElseIf RBT_WaterLoad7to8AMX.Checked Then
            selectedWaterLoad7to8AM = "X"
        Else
            selectedWaterLoad7to8AM = "N"
        End If


        If RBT_WaterLoad730to830Check.Checked Then
            selectedWaterLoad7to730AM = "O"
        ElseIf RBT_WaterLoad730to830X.Checked Then
            selectedWaterLoad7to730AM = "X"
        Else
            selectedWaterLoad7to730AM = "N"
        End If


        If RBT_WaterLoad9to10AMCheck.Checked Then
            selectedWaterLoad9to10AM = "O"
        ElseIf RBT_WaterLoad9to10AMX.Checked Then
            selectedWaterLoad9to10AM = "X"
        Else
            selectedWaterLoad9to10AM = "N"
        End If


        If RBT_WaterLoad930to1030Check.Checked Then
            selectedWaterLoad930to1030AM = "O"
        ElseIf RBT_WaterLoad930to1030X.Checked Then
            selectedWaterLoad930to1030AM = "X"
        Else
            selectedWaterLoad930to1030AM = "N"
        End If


        If RBT_WaterLoad11to12Check.Checked Then
            selectedWaterLoad11to12AM = "O"
        ElseIf RBT_WaterLoad11to12X.Checked Then
            selectedWaterLoad11to12AM = "X"
        Else
            selectedWaterLoad11to12AM = "N"
        End If


        If RBT_WaterLoad1130to1230Check.Checked Then
            selectedWaterLoad1130to1230PM = "O"
        ElseIf RBT_WaterLoad1130to1230X.Checked Then
            selectedWaterLoad1130to1230PM = "X"
        Else
            selectedWaterLoad1130to1230PM = "N"
        End If



        If RBT_WaterLoad1to2Check.Checked Then
            selectedWaterLoad1to2PM = "O"
        ElseIf RBT_WaterLoad1to2X.Checked Then
            selectedWaterLoad1to2PM = "X"
        Else
            selectedWaterLoad1to2PM = "N"
        End If



        If RBT_WaterLoad130to230Check.Checked Then
            selectedWaterLoad130to230PM = "O"
        ElseIf RBT_WaterLoad130to230X.Checked Then
            selectedWaterLoad130to230PM = "X"
        Else
            selectedWaterLoad130to230PM = "N"
        End If


        If RBT_WaterLoad3to4Check.Checked Then
            selectedWaterLoad3to4PM = "O"
        ElseIf RBT_WaterLoad3to4X.Checked Then
            selectedWaterLoad3to4PM = "X"
        Else
            selectedWaterLoad3to4PM = "N"
        End If


        If RBT_WaterLoad330to430Check.Checked Then
            selectedWaterLoad330to430PM = "O"
        ElseIf RBT_WaterLoad330to430X.Checked Then
            selectedWaterLoad330to430PM = "X"
        Else
            selectedWaterLoad330to430PM = "N"
        End If



        If RBT_WaterLoad5to6Check.Checked Then
            selectedWaterLoad5to6PM = "O"
        ElseIf RBT_WaterLoad5to6X.Checked Then
            selectedWaterLoad5to6PM = "X"
        Else
            selectedWaterLoad5to6PM = "N"
        End If



        If RBT_WaterLoad530to630Check.Checked Then
            selectedWaterLoad530to630PM = "O"
        ElseIf RBT_WaterLoad530to630X.Checked Then
            selectedWaterLoad530to630PM = "X"
        Else
            selectedWaterLoad530to630PM = "N"
        End If


















        'Glue Load
        'Dim prr_LAGluld0700to0800Decimal As Double
        'Dim prr_LAGluld0730to0830Decimal As Double
        'Dim prr_LAGluld0900to1000Decimal As Double
        'Dim prr_LAGluld0930to1030Decimal As Double
        'Dim prr_LAGluld1100to1200Decimal As Double
        'Dim prr_LAGluld1130to1230Decimal As Double
        'Dim prr_LAGluld0100to0200Decimal As Double
        'Dim prr_LAGluld0130to0230Decimal As Double
        'Dim prr_LAGluld0300to0400Decimal As Double
        'Dim prr_LAGluld0330to0430Decimal As Double
        'Dim prr_LAGluld0500to0600Decimal As Double
        'Dim prr_LAGluld0530to0630Decimal As Double


        'Double.TryParse(TXT_GlueLoad7AM_8AM.Text, prr_LAGluld0700to0800Decimal)
        'Double.TryParse(TXT_GlueLoad730AM_830AM.Text, prr_LAGluld0730to0830Decimal)
        'Double.TryParse(TXT_GlueLoad9AM_10AM.Text, prr_LAGluld0900to1000Decimal)
        'Double.TryParse(TXT_GlueLoad930AM_1030AM.Text, prr_LAGluld0930to1030Decimal)
        'Double.TryParse(TXT_GlueLoad11AM_12PM.Text, prr_LAGluld1100to1200Decimal)
        'Double.TryParse(TXT_GlueLoad1130AM_1230PM.Text, prr_LAGluld1130to1230Decimal)
        'Double.TryParse(TXT_GlueLoad1PM_2PM.Text, prr_LAGluld0100to0200Decimal)
        'Double.TryParse(TXT_GlueLoad130PM_230PM.Text, prr_LAGluld0130to0230Decimal)
        'Double.TryParse(TXT_GlueLoad3PM_4PM.Text, prr_LAGluld0300to0400Decimal)
        'Double.TryParse(TXT_GlueLoad330PM_430PM.Text, prr_LAGluld0330to0430Decimal)
        'Double.TryParse(TXT_GlueLoad5PM_6PM.Text, prr_LAGluld0500to0600Decimal)
        'Double.TryParse(TXT_GlueLoad530PM_630PM.Text, prr_LAGluld0530to0630Decimal)



        'Dim prr_LAWtrld0700to0800Decimal As Double
        'Dim prr_LAWtrld0730to0830Decimal As Double
        'Dim prr_LAWtrld0900to1000Decimal As Double
        'Dim prr_LAWtrld0930to1030Decimal As Double
        'Dim prr_LAWtrld1100to1200Decimal As Double
        'Dim prr_LAWtrld1130to1230Decimal As Double
        'Dim prr_LAWtrld0100to0200Decimal As Double
        'Dim prr_LAWtrld0130to0230Decimal As Double
        'Dim prr_LAWtrld0300to0400Decimal As Double
        'Dim prr_LAWtrld0330to0430Decimal As Double
        'Dim prr_LAWtrld0500to0600Decimal As Double
        'Dim prr_LAWtrld0530to0630Decimal As Double



        'Double.TryParse(TXT_WaterLoad7AM_8AM.Text, prr_LAWtrld0700to0800Decimal)
        'Double.TryParse(TXT_WaterLoad730AM_830AM.Text, prr_LAWtrld0730to0830Decimal)
        'Double.TryParse(TXT_WaterLoad9AM_10AM.Text, prr_LAWtrld0900to1000Decimal)
        'Double.TryParse(TXT_WaterLoad930AM_1030AM.Text, prr_LAWtrld0930to1030Decimal)
        'Double.TryParse(TXT_WaterLoad11AM_12PM.Text, prr_LAWtrld1100to1200Decimal)
        'Double.TryParse(TXT_WaterLoad1130AM_1230PM.Text, prr_LAWtrld1130to1230Decimal)
        'Double.TryParse(TXT_WaterLoad1PM_2PM.Text, prr_LAWtrld0100to0200Decimal)
        'Double.TryParse(TXT_WaterLoad130PM_230PM.Text, prr_LAWtrld0130to0230Decimal)
        'Double.TryParse(TXT_WaterLoad3PM_4PM.Text, prr_LAWtrld0300to0400Decimal)
        'Double.TryParse(TXT_WaterLoad330PM_430PM.Text, prr_LAWtrld0330to0430Decimal)
        'Double.TryParse(TXT_WaterLoad5PM_6PM.Text, prr_LAWtrld0500to0600Decimal)
        'Double.TryParse(TXT_WaterLoad530PM_630PM.Text, prr_LAWtrld0530to0630Decimal)



        Dim prr_LAThickn0700to0800Decimal As Double
        Dim prr_LAThickn0730to0830Decimal As Double
        Dim prr_LAThickn0900to1000Decimal As Double
        Dim prr_LAThickn0930to1030Decimal As Double
        Dim prr_LAThickn1100to1200Decimal As Double
        Dim prr_LAThickn1130to1230Decimal As Double
        Dim prr_LAThickn0100to0200Decimal As Double
        Dim prr_LAThickn0130to0230Decimal As Double
        Dim prr_LAThickn0300to0400Decimal As Double
        Dim prr_LAThickn0330to0430Decimal As Double
        Dim prr_LAThickn0500to0600Decimal As Double
        Dim prr_LAThickn0530to0630Decimal As Double




        Double.TryParse(TXT_Thickness7AM_8AM.Text, prr_LAThickn0700to0800Decimal)
        Double.TryParse(TXT_Thickness730AM_830AM.Text, prr_LAThickn0730to0830Decimal)
        Double.TryParse(TXT_Thickness9AM_10AM.Text, prr_LAThickn0900to1000Decimal)
        Double.TryParse(TXT_Thickness930AM_1030AM.Text, prr_LAThickn0930to1030Decimal)
        Double.TryParse(TXT_Thickness11AM_12PM.Text, prr_LAThickn1100to1200Decimal)
        Double.TryParse(TXT_Thickness1130AM_1230PM.Text, prr_LAThickn1130to1230Decimal)
        Double.TryParse(TXT_Thickness1PM_2PM.Text, prr_LAThickn0100to0200Decimal)
        Double.TryParse(TXT_Thickness130PM_230PM.Text, prr_LAThickn0130to0230Decimal)
        Double.TryParse(TXT_Thickness3PM_4PM.Text, prr_LAThickn0300to0400Decimal)
        Double.TryParse(TXT_Thickness330PM_430PM.Text, prr_LAThickn0330to0430Decimal)
        Double.TryParse(TXT_Thickness5PM_6PM.Text, prr_LAThickn0500to0600Decimal)
        Double.TryParse(TXT_Thickness530PM_630PM.Text, prr_LAThickn0530to0630Decimal)




        Dim prr_LAMoist0700to0800Decimal As Double
        Dim prr_LAMoist0730to0830Decimal As Double
        Dim prr_LAMoist0900to1000Decimal As Double
        Dim prr_LAMoist0930to1030Decimal As Double
        Dim prr_LAMoist1100to1200Decimal As Double
        Dim prr_LAMoist1130to1230Decimal As Double
        Dim prr_LAMoist0100to0200Decimal As Double
        Dim prr_LAMoist0130to0230Decimal As Double
        Dim prr_LAMoist0300to0400Decimal As Double
        Dim prr_LAMoist0330to0430Decimal As Double
        Dim prr_LAMoist0500to0600Decimal As Double
        Dim prr_LAMoist0530to0630Decimal As Double


        Double.TryParse(TXT_Moisture7AM_8AM.Text, prr_LAMoist0700to0800Decimal)
        Double.TryParse(TXT_Moisture730AM_830AM.Text, prr_LAMoist0730to0830Decimal)
        Double.TryParse(TXT_Moisture9AM_10AM.Text, prr_LAMoist0900to1000Decimal)
        Double.TryParse(TXT_Moisture930AM_1030AM.Text, prr_LAMoist0930to1030Decimal)
        Double.TryParse(TXT_Moisture11AM_12PM.Text, prr_LAMoist1100to1200Decimal)
        Double.TryParse(TXT_Moisture1130AM_1230PM.Text, prr_LAMoist1130to1230Decimal)
        Double.TryParse(TXT_Moisture1PM_2PM.Text, prr_LAMoist0100to0200Decimal)
        Double.TryParse(TXT_Moisture130PM_230PM.Text, prr_LAMoist0130to0230Decimal)
        Double.TryParse(TXT_Moisture3PM_4PM.Text, prr_LAMoist0300to0400Decimal)
        Double.TryParse(TXT_Moisture330PM_430PM.Text, prr_LAMoist0330to0430Decimal)
        Double.TryParse(TXT_Moisture5PM_6PM.Text, prr_LAMoist0500to0600Decimal)
        Double.TryParse(TXT_Moisture530PM_630PM.Text, prr_LAMoist0530to0630Decimal)






        'Double.TryParse(TXT_GlueLoad7AM_9AM.Text, GlueLoad7AM_9AMDecimal)
        'Double.TryParse(TXT_GlueLoad10AM_12PM.Text, GlueLoad10AM_12PMDecimal)
        'Double.TryParse(TXT_GlueLoad1PM_3PM.Text, GlueLoad1PM_3PMDecimal)
        'Double.TryParse(TXT_GlueLoad4PM_6PM.Text, GlueLoad4PM_6PMDecimal)


        ''waterload
        'Dim WaterLoad7AM_9AMDecimal As Double
        'Dim WaterLoad10AM_12PMDecimal As Double
        'Dim WaterLoad1PM_3PMDecimal As Double
        'Dim WaterLoad4PM_6PMDecimal As Double


        'Double.TryParse(TXT_WaterLoad7AM_9AM.Text, WaterLoad7AM_9AMDecimal)
        'Double.TryParse(TXT_WaterLoad1PM_3PM.Text, WaterLoad10AM_12PMDecimal)
        'Double.TryParse(TXT_WaterLoad1PM_3PM.Text, WaterLoad1PM_3PMDecimal)
        'Double.TryParse(TXT_WaterLoad4PM_6PM.Text, WaterLoad4PM_6PMDecimal)

        ''Thickness
        'Dim Thickness7AM_9AMDecimal As Double
        'Dim Thickness10AM_12PMDecimal As Double
        'Dim Conductivity1PM_3PMDecimal As Double
        'Dim Thickness4PM_6PMDecimal As Double


        'Double.TryParse(TXT_Thickness7AM_9AM.Text, Thickness7AM_9AMDecimal)
        'Double.TryParse(TXT_Thickness10AM_12PM.Text, Thickness10AM_12PMDecimal)
        'Double.TryParse(TXT_Conductivity1PM_3PM.Text, Conductivity1PM_3PMDecimal)
        'Double.TryParse(TXT_Thickness4PM_6PM.Text, Thickness4PM_6PMDecimal)



        ''Moisture
        'Dim Moisture7AM_9AMDecimal As Double
        'Dim Moisture10AM_12PMDecimal As Double
        'Dim Moisture1PM_3PMDecimal As Double
        'Dim Moisture4PM_6PMDecimal As Double


        'Double.TryParse(TXT_Moisture7AM_9AM.Text, Moisture7AM_9AMDecimal)
        'Double.TryParse(TXT_Moisture10AM_12PM.Text, Moisture10AM_12PMDecimal)
        'Double.TryParse(TXT_Moisture1PM_3PM.Text, Moisture1PM_3PMDecimal)
        'Double.TryParse(TXT_Moisture4PM_6PM.Text, Moisture4PM_6PMDecimal)




        OpenConnection()

        ' Check if mcnum exists
        cmd.CommandText = "SELECT * FROM sppmcPRR_LAM WHERE Site = @site  And mcnum  = @mcnum"
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
                cmd.CommandText = "UPDATE sppmcPRR_LAM SET " &
                                          "prr_RESNum = @prr_RESNum, " &
                                          "prr_SASNum = @prr_SASNum, " &
                                          "prr_LAGluld0700to0800 = @prr_LAGluld0700to0800, " &
                                          "prr_LAGluld0730to0830 = @prr_LAGluld0730to0830, " &
                                          "prr_LAGluld0900to1000 = @prr_LAGluld0900to1000, " &
                                          "prr_LAGluld0930to1030 = @prr_LAGluld0930to1030, " &
                                          "prr_LAGluld1100to1200 = @prr_LAGluld1100to1200, " &
                                          "prr_LAGluld1130to1230 = @prr_LAGluld1130to1230, " &
                                          "prr_LAGluld0100to0200 = @prr_LAGluld0100to0200, " &
                                          "prr_LAGluld0130to0230 = @prr_LAGluld0130to0230, " &
                                          "prr_LAGluld0300to0400 = @prr_LAGluld0300to0400, " &
                                          "prr_LAGluld0330to0430 = @prr_LAGluld0330to0430, " &
                                          "prr_LAGluld0500to0600 = @prr_LAGluld0500to0600, " &
                                          "prr_LAGluld0530to0630 = @prr_LAGluld0530to0630, " &
                                          "prr_LAWtrld0700to0800 = @prr_LAWtrld0700to0800, " &
                                          "prr_LAWtrld0730to0830 = @prr_LAWtrld0730to0830, " &
                                          "prr_LAWtrld0900to1000 = @prr_LAWtrld0900to1000, " &
                                          "prr_LAWtrld0930to1030 = @prr_LAWtrld0930to1030, " &
                                          "prr_LAWtrld1100to1200 = @prr_LAWtrld1100to1200, " &
                                          "prr_LAWtrld1130to1230 = @prr_LAWtrld1130to1230, " &
                                          "prr_LAWtrld0100to0200 = @prr_LAWtrld0100to0200, " &
                                          "prr_LAWtrld0130to0230 = @prr_LAWtrld0130to0230, " &
                                          "prr_LAWtrld0300to0400 = @prr_LAWtrld0300to0400, " &
                                          "prr_LAWtrld0330to0430 = @prr_LAWtrld0330to0430, " &
                                          "prr_LAWtrld0500to0600 = @prr_LAWtrld0500to0600, " &
                                          "prr_LAWtrld0530to0630 = @prr_LAWtrld0530to0630, " &
                                          "prr_LAThickn0700to0800 = @prr_LAThickn0700to0800, " &
                                          "prr_LAThickn0730to0830 = @prr_LAThickn0730to0830, " &
                                          "prr_LAThickn0900to1000 = @prr_LAThickn0900to1000, " &
                                          "prr_LAThickn0930to1030 = @prr_LAThickn0930to1030, " &
                                          "prr_LAThickn1100to1200 = @prr_LAThickn1100to1200, " &
                                          "prr_LAThickn1130to1230 = @prr_LAThickn1130to1230, " &
                                          "prr_LAThickn0100to0200 = @prr_LAThickn0100to0200, " &
                                          "prr_LAThickn0130to0230 = @prr_LAThickn0130to0230, " &
                                          "prr_LAThickn0300to0400 = @prr_LAThickn0300to0400, " &
                                          "prr_LAThickn0330to0430 = @prr_LAThickn0330to0430, " &
                                          "prr_LAThickn0500to0600 = @prr_LAThickn0500to0600, " &
                                          "prr_LAThickn0530to0630 = @prr_LAThickn0530to0630, " &
                                          "prr_LAMoist0700to0800 = @prr_LAMoist0700to0800, " &
                                          "prr_LAMoist0730to0830 = @prr_LAMoist0730to0830, " &
                                          "prr_LAMoist0900to1000 = @prr_LAMoist0900to1000, " &
                                          "prr_LAMoist0930to1030 = @prr_LAMoist0930to1030, " &
                                          "prr_LAMoist1100to1200 = @prr_LAMoist1100to1200, " &
                                          "prr_LAMoist1130to1230 = @prr_LAMoist1130to1230, " &
                                          "prr_LAMoist0100to0200 = @prr_LAMoist0100to0200, " &
                                          "prr_LAMoist0130to0230 = @prr_LAMoist0130to0230, " &
                                          "prr_LAMoist0300to0400 = @prr_LAMoist0300to0400, " &
                                          "prr_LAMoist0330to0430 = @prr_LAMoist0330to0430, " &
                                          "prr_LAMoist0500to0600 = @prr_LAMoist0500to0600, " &
                                          "prr_LAMoist0530to0630 = @prr_LAMoist0530to0630 " &
                                          "WHERE Site = @Site AND mcnum = @mcnum"
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()

                'Dim selectedGlueLoad7to8AM As String = ""
                'Dim selectedGlueLoad7to730AM As String = ""
                'Dim selectedGlueLoad9to10AM As String = ""
                'Dim selectedGlueLoad930to1030AM As String = ""
                'Dim selectedGlueLoad11to12AM As String = ""
                'Dim selectedGlueLoad1130to1230PM As String = ""
                'Dim selectedGlueLoad1to2PM As String = ""
                'Dim selectedGlueLoad130to230PM As String = ""
                'Dim selectedGlueLoad3to4PM As String = ""
                'Dim selectedGlueLoad330to430PM As String = ""
                'Dim selectedGlueLoad5to6PM As String = ""
                'Dim selectedGlueLoad530to630PM As String = ""


                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text) ' Add your actual values
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)

                    .AddWithValue("@prr_LAGluld0700to0800", selectedGlueLoad7to8AM)
                    .AddWithValue("@prr_LAGluld0730to0830", selectedGlueLoad7to730AM)
                    .AddWithValue("@prr_LAGluld0900to1000", selectedGlueLoad9to10AM)
                    .AddWithValue("@prr_LAGluld0930to1030", selectedGlueLoad930to1030AM)
                    .AddWithValue("@prr_LAGluld1100to1200", selectedGlueLoad11to12AM)
                    .AddWithValue("@prr_LAGluld1130to1230", selectedGlueLoad1130to1230PM)
                    .AddWithValue("@prr_LAGluld0100to0200", selectedGlueLoad1to2PM)
                    .AddWithValue("@prr_LAGluld0130to0230", selectedGlueLoad130to230PM)
                    .AddWithValue("@prr_LAGluld0300to0400", selectedGlueLoad3to4PM)
                    .AddWithValue("@prr_LAGluld0330to0430", selectedGlueLoad330to430PM)
                    .AddWithValue("@prr_LAGluld0500to0600", selectedGlueLoad5to6PM)
                    .AddWithValue("@prr_LAGluld0530to0630", selectedGlueLoad530to630PM)


                    .AddWithValue("@prr_LAWtrld0700to0800", selectedWaterLoad7to8AM)
                    .AddWithValue("@prr_LAWtrld0730to0830", selectedWaterLoad7to730AM)
                    .AddWithValue("@prr_LAWtrld0900to1000", selectedWaterLoad9to10AM)
                    .AddWithValue("@prr_LAWtrld0930to1030", selectedWaterLoad930to1030AM)
                    .AddWithValue("@prr_LAWtrld1100to1200", selectedWaterLoad11to12AM)
                    .AddWithValue("@prr_LAWtrld1130to1230", selectedWaterLoad1130to1230PM)
                    .AddWithValue("@prr_LAWtrld0100to0200", selectedWaterLoad1to2PM)
                    .AddWithValue("@prr_LAWtrld0130to0230", selectedWaterLoad130to230PM)
                    .AddWithValue("@prr_LAWtrld0300to0400", selectedWaterLoad3to4PM)
                    .AddWithValue("@prr_LAWtrld0330to0430", selectedWaterLoad330to430PM)
                    .AddWithValue("@prr_LAWtrld0500to0600", selectedWaterLoad5to6PM)
                    .AddWithValue("@prr_LAWtrld0530to0630", selectedWaterLoad530to630PM)




                    .AddWithValue("@prr_LAThickn0700to0800", prr_LAThickn0700to0800Decimal)
                    .AddWithValue("@prr_LAThickn0730to0830", prr_LAThickn0730to0830Decimal)
                    .AddWithValue("@prr_LAThickn0900to1000", prr_LAThickn0900to1000Decimal)
                    .AddWithValue("@prr_LAThickn0930to1030", prr_LAThickn0930to1030Decimal)
                    .AddWithValue("@prr_LAThickn1100to1200", prr_LAThickn1100to1200Decimal)
                    .AddWithValue("@prr_LAThickn1130to1230", prr_LAThickn1130to1230Decimal)
                    .AddWithValue("@prr_LAThickn0100to0200", prr_LAThickn0100to0200Decimal)
                    .AddWithValue("@prr_LAThickn0130to0230", prr_LAThickn0130to0230Decimal)
                    .AddWithValue("@prr_LAThickn0300to0400", prr_LAThickn0300to0400Decimal)
                    .AddWithValue("@prr_LAThickn0330to0430", prr_LAThickn0330to0430Decimal)
                    .AddWithValue("@prr_LAThickn0500to0600", prr_LAThickn0500to0600Decimal)
                    .AddWithValue("@prr_LAThickn0530to0630", prr_LAThickn0530to0630Decimal)


                    .AddWithValue("@prr_LAMoist0700to0800", prr_LAMoist0700to0800Decimal)
                    .AddWithValue("@prr_LAMoist0730to0830", prr_LAMoist0730to0830Decimal)
                    .AddWithValue("@prr_LAMoist0900to1000", prr_LAMoist0900to1000Decimal)
                    .AddWithValue("@prr_LAMoist0930to1030", prr_LAMoist0930to1030Decimal)
                    .AddWithValue("@prr_LAMoist1100to1200", prr_LAMoist1100to1200Decimal)
                    .AddWithValue("@prr_LAMoist1130to1230", prr_LAMoist1130to1230Decimal)
                    .AddWithValue("@prr_LAMoist0100to0200", prr_LAMoist0100to0200Decimal)
                    .AddWithValue("@prr_LAMoist0130to0230", prr_LAMoist0130to0230Decimal)
                    .AddWithValue("@prr_LAMoist0300to0400", prr_LAMoist0300to0400Decimal)
                    .AddWithValue("@prr_LAMoist0330to0430", prr_LAMoist0330to0430Decimal)
                    .AddWithValue("@prr_LAMoist0500to0600", prr_LAMoist0500to0600Decimal)
                    .AddWithValue("@prr_LAMoist0530to0630", prr_LAMoist0530to0630Decimal)




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
                cmd.CommandText = "Insert_sppmcPRR_LAM"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .AddWithValue("@Site", Form1.cmb_site.Text)
                    .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    .AddWithValue("@prr_RESNum", TXT_ResNo.Text)
                    .AddWithValue("@prr_SASNum", TXT_SasNo.Text)



                    .AddWithValue("@prr_LAGluld0700to0800", selectedGlueLoad7to8AM)
                    .AddWithValue("@prr_LAGluld0730to0830", selectedGlueLoad7to730AM)
                    .AddWithValue("@prr_LAGluld0900to1000", selectedGlueLoad9to10AM)
                    .AddWithValue("@prr_LAGluld0930to1030", selectedGlueLoad930to1030AM)
                    .AddWithValue("@prr_LAGluld1100to1200", selectedGlueLoad11to12AM)
                    .AddWithValue("@prr_LAGluld1130to1230", selectedGlueLoad1130to1230PM)
                    .AddWithValue("@prr_LAGluld0100to0200", selectedGlueLoad1to2PM)
                    .AddWithValue("@prr_LAGluld0130to0230", selectedGlueLoad130to230PM)
                    .AddWithValue("@prr_LAGluld0300to0400", selectedGlueLoad3to4PM)
                    .AddWithValue("@prr_LAGluld0330to0430", selectedGlueLoad330to430PM)
                    .AddWithValue("@prr_LAGluld0500to0600", selectedGlueLoad5to6PM)
                    .AddWithValue("@prr_LAGluld0530to0630", selectedGlueLoad530to630PM)


                    .AddWithValue("@prr_LAWtrld0700to0800", selectedWaterLoad7to8AM)
                    .AddWithValue("@prr_LAWtrld0730to0830", selectedWaterLoad7to730AM)
                    .AddWithValue("@prr_LAWtrld0900to1000", selectedWaterLoad9to10AM)
                    .AddWithValue("@prr_LAWtrld0930to1030", selectedWaterLoad930to1030AM)
                    .AddWithValue("@prr_LAWtrld1100to1200", selectedWaterLoad11to12AM)
                    .AddWithValue("@prr_LAWtrld1130to1230", selectedWaterLoad1130to1230PM)
                    .AddWithValue("@prr_LAWtrld0100to0200", selectedWaterLoad1to2PM)
                    .AddWithValue("@prr_LAWtrld0130to0230", selectedWaterLoad130to230PM)
                    .AddWithValue("@prr_LAWtrld0300to0400", selectedWaterLoad3to4PM)
                    .AddWithValue("@prr_LAWtrld0330to0430", selectedWaterLoad330to430PM)
                    .AddWithValue("@prr_LAWtrld0500to0600", selectedWaterLoad5to6PM)
                    .AddWithValue("@prr_LAWtrld0530to0630", selectedWaterLoad530to630PM)


                    .AddWithValue("@prr_LAThickn0700to0800", prr_LAThickn0700to0800Decimal)
                    .AddWithValue("@prr_LAThickn0730to0830", prr_LAThickn0730to0830Decimal)
                    .AddWithValue("@prr_LAThickn0900to1000", prr_LAThickn0900to1000Decimal)
                    .AddWithValue("@prr_LAThickn0930to1030", prr_LAThickn0930to1030Decimal)
                    .AddWithValue("@prr_LAThickn1100to1200", prr_LAThickn1100to1200Decimal)
                    .AddWithValue("@prr_LAThickn1130to1230", prr_LAThickn1130to1230Decimal)
                    .AddWithValue("@prr_LAThickn0100to0200", prr_LAThickn0100to0200Decimal)
                    .AddWithValue("@prr_LAThickn0130to0230", prr_LAThickn0130to0230Decimal)
                    .AddWithValue("@prr_LAThickn0300to0400", prr_LAThickn0300to0400Decimal)
                    .AddWithValue("@prr_LAThickn0330to0430", prr_LAThickn0330to0430Decimal)
                    .AddWithValue("@prr_LAThickn0500to0600", prr_LAThickn0500to0600Decimal)
                    .AddWithValue("@prr_LAThickn0530to0630", prr_LAThickn0530to0630Decimal)

                    .AddWithValue("@prr_LAMoist0700to0800", prr_LAMoist0700to0800Decimal)
                    .AddWithValue("@prr_LAMoist0730to0830", prr_LAMoist0730to0830Decimal)
                    .AddWithValue("@prr_LAMoist0900to1000", prr_LAMoist0900to1000Decimal)
                    .AddWithValue("@prr_LAMoist0930to1030", prr_LAMoist0930to1030Decimal)
                    .AddWithValue("@prr_LAMoist1100to1200", prr_LAMoist1100to1200Decimal)
                    .AddWithValue("@prr_LAMoist1130to1230", prr_LAMoist1130to1230Decimal)
                    .AddWithValue("@prr_LAMoist0100to0200", prr_LAMoist0100to0200Decimal)
                    .AddWithValue("@prr_LAMoist0130to0230", prr_LAMoist0130to0230Decimal)
                    .AddWithValue("@prr_LAMoist0300to0400", prr_LAMoist0300to0400Decimal)
                    .AddWithValue("@prr_LAMoist0330to0430", prr_LAThickn0330to0430Decimal)
                    .AddWithValue("@prr_LAMoist0500to0600", prr_LAMoist0500to0600Decimal)
                    .AddWithValue("@prr_LAMoist0530to0630", prr_LAMoist0530to0630Decimal)

                    .AddWithValue("@prr_LAGluApp0700", "")
                    .AddWithValue("@prr_LAGluApp0730", "")
                    .AddWithValue("@prr_LAGluApp0800", "")
                    .AddWithValue("@prr_LAGluApp0830", "")
                    .AddWithValue("@prr_LAGluApp0900", "")
                    .AddWithValue("@prr_LAGluApp0930", "")
                    .AddWithValue("@prr_LAGluApp1000", "")
                    .AddWithValue("@prr_LAGluApp1030", "")
                    .AddWithValue("@prr_LAGluApp1100", "")
                    .AddWithValue("@prr_LAGluApp1130", "")
                    .AddWithValue("@prr_LAGluApp1200", "")
                    .AddWithValue("@prr_LAGluApp1230", "")
                    .AddWithValue("@prr_LAGluApp0100", "")
                    .AddWithValue("@prr_LAGluApp0130", "")
                    .AddWithValue("@prr_LAGluApp0200", "")
                    .AddWithValue("@prr_LAGluApp0230", "")
                    .AddWithValue("@prr_LAGluApp0300", "")
                    .AddWithValue("@prr_LAGluApp0330", "")
                    .AddWithValue("@prr_LAGluApp0400", "")
                    .AddWithValue("@prr_LAGluApp0430", "")
                    .AddWithValue("@prr_LAGluApp0500", "")
                    .AddWithValue("@prr_LAGluApp0530", "")
                    .AddWithValue("@prr_LAGluApp0600", "")
                    .AddWithValue("@prr_LAGluApp0630", "")
                    .AddWithValue("@prr_LAGluApp0700val", "")
                    .AddWithValue("@prr_LAGluApp0730val", "")
                    .AddWithValue("@prr_LAGluApp0800val", "")
                    .AddWithValue("@prr_LAGluApp0830val", "")
                    .AddWithValue("@prr_LAGluApp0900val", "")
                    .AddWithValue("@prr_LAGluApp0930val", "")
                    .AddWithValue("@prr_LAGluApp1000val", "")
                    .AddWithValue("@prr_LAGluApp1030val", "")
                    .AddWithValue("@prr_LAGluApp1100val", "")
                    .AddWithValue("@prr_LAGluApp1130val", "")
                    .AddWithValue("@prr_LAGluApp1200val", "")
                    .AddWithValue("@prr_LAGluApp1230val", "")
                    .AddWithValue("@prr_LAGluApp0100val", "")
                    .AddWithValue("@prr_LAGluApp0130val", "")
                    .AddWithValue("@prr_LAGluApp0200val", "")
                    .AddWithValue("@prr_LAGluApp0230val", "")
                    .AddWithValue("@prr_LAGluApp0300val", "")
                    .AddWithValue("@prr_LAGluApp0330val", "")
                    .AddWithValue("@prr_LAGluApp0400val", "")
                    .AddWithValue("@prr_LAGluApp0430val", "")
                    .AddWithValue("@prr_LAGluApp0500val", "")
                    .AddWithValue("@prr_LAGluApp0530val", "")
                    .AddWithValue("@prr_LAGluApp0600val", "")
                    .AddWithValue("@prr_LAGluApp0630val", "")

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



        MsgBox("Successfully saved!")







    End Sub



    Private Sub FRM_AddProductionRunLamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            OpenConnection()
            cmd.CommandText = "Select_sppmcPRR_LAM"
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

                    'Glue Load
                    If dr("prr_LAGluld0700to0800").ToString() = "O" Then
                        RBT_GlueLoad7to8AMCheck.Checked = True
                    ElseIf dr("prr_LAGluld0700to0800").ToString() = "X"
                        RBT_GlueLoad7to8AMX.Checked = True
                    Else
                        RBT_GlueLoad7to8AMNA.Checked = True
                    End If

                    If dr("prr_LAGluld0730to0830").ToString() = "O" Then
                        RBT_GlueLoad730to830AMCheck.Checked = True
                    ElseIf dr("prr_LAGluld0730to0830").ToString() = "X"
                        RBT_GlueLoad730to830AMX.Checked = True
                    Else
                        RBT_GlueLoad730to830AMNA.Checked = True
                    End If


                    If dr("prr_LAGluld0900to1000").ToString() = "O" Then
                        RBT_GlueLoad9to10AMCheck.Checked = True
                    ElseIf dr("prr_LAGluld0900to1000").ToString() = "X"
                        RBT_GlueLoad9to10AMX.Checked = True
                    Else
                        RBT_GlueLoad9to10AMNA.Checked = True
                    End If


                    If dr("prr_LAGluld0930to1030").ToString() = "O" Then
                        RBT_GlueLoad930to1030AMCheck.Checked = True
                    ElseIf dr("prr_LAGluld0930to1030").ToString() = "X"
                        RBT_GlueLoad930to1030AMX.Checked = True
                    Else
                        RBT_GlueLoad930to1030AMNA.Checked = True
                    End If


                    If dr("prr_LAGluld1100to1200").ToString() = "O" Then
                        RBT_GlueLoad11to12Check.Checked = True
                    ElseIf dr("prr_LAGluld1100to1200").ToString() = "X"
                        RBT_GlueLoad11to12X.Checked = True
                    Else
                        RBT_GlueLoad11to12NA.Checked = True
                    End If


                    If dr("prr_LAGluld1130to1230").ToString() = "O" Then
                        RBT_GlueLoad1130to1230Check.Checked = True
                    ElseIf dr("prr_LAGluld1130to1230").ToString() = "X"
                        RBT_GlueLoad1130to1230X.Checked = True
                    Else
                        RBT_GlueLoad1130to1230NA.Checked = True
                    End If


                    If dr("prr_LAGluld0100to0200").ToString() = "O" Then
                        RBT_GlueLoad1to2Check.Checked = True
                    ElseIf dr("prr_LAGluld0100to0200").ToString() = "X"
                        RBT_GlueLoad1to2X.Checked = True
                    Else
                        RBT_GlueLoad1to2NA.Checked = True
                    End If


                    If dr("prr_LAGluld0130to0230").ToString() = "O" Then
                        RBT_GlueLoad130to230Check.Checked = True
                    ElseIf dr("prr_LAGluld0130to0230").ToString() = "X"
                        RBT_GlueLoad130to230X.Checked = True
                    Else
                        RBT_GlueLoad130to230NA.Checked = True
                    End If


                    If dr("prr_LAGluld0300to0400").ToString() = "O" Then
                        RBT_GlueLoad3to4Check.Checked = True
                    ElseIf dr("prr_LAGluld0300to0400").ToString() = "X"
                        RBT_GlueLoad3to4X.Checked = True
                    Else
                        RBT_GlueLoad3to4NA.Checked = True
                    End If


                    If dr("prr_LAGluld0330to0430").ToString() = "O" Then
                        RBT_GlueLoad330to430Check.Checked = True
                    ElseIf dr("prr_LAGluld0330to0430").ToString() = "X"
                        RBT_GlueLoad330to430X.Checked = True
                    Else
                        RBT_GlueLoad330to430NA.Checked = True
                    End If


                    If dr("prr_LAGluld0500to0600").ToString() = "O" Then
                        RBT_GlueLoad5to6Check.Checked = True
                    ElseIf dr("prr_LAGluld0500to0600").ToString() = "X"
                        RBT_GlueLoad5to6X.Checked = True
                    Else
                        RBT_GlueLoad5to6NA.Checked = True
                    End If


                    If dr("prr_LAGluld0530to0630").ToString() = "O" Then
                        RBT_GlueLoad530to630Check.Checked = True
                    ElseIf dr("prr_LAGluld0530to0630").ToString() = "X"
                        RBT_GlueLoad530to630X.Checked = True
                    Else
                        RBT_GlueLoad530to630NA.Checked = True
                    End If



                    'Water Load

                    'TXT_WaterLoad7AM_8AM.Text = dr("prr_LAWtrld0700to0800").ToString()
                    If dr("prr_LAWtrld0700to0800").ToString() = "O" Then
                        RBT_WaterLoad7to8AMCheck.Checked = True
                    ElseIf dr("prr_LAWtrld0700to0800").ToString() = "X"
                        RBT_WaterLoad7to8AMX.Checked = True
                    Else
                        RBT_WaterLoad7to8AMNA.Checked = True
                    End If

                    'TXT_WaterLoad730AM_830AM.Text = dr("prr_LAWtrld0730to0830").ToString()
                    If dr("prr_LAWtrld0730to0830").ToString() = "O" Then
                        RBT_WaterLoad730to830Check.Checked = True
                    ElseIf dr("prr_LAWtrld0730to0830").ToString() = "X"
                        RBT_WaterLoad730to830X.Checked = True
                    Else
                        RBT_WaterLoad730to830NA.Checked = True
                    End If

                    'TXT_WaterLoad9AM_10AM.Text = dr("prr_LAWtrld0900to1000").ToString()
                    If dr("prr_LAWtrld0900to1000").ToString() = "O" Then
                        RBT_WaterLoad9to10AMCheck.Checked = True
                    ElseIf dr("prr_LAWtrld0900to1000").ToString() = "X"
                        RBT_WaterLoad9to10AMX.Checked = True
                    Else
                        RBT_WaterLoad9to10NA.Checked = True
                    End If


                    'TXT_WaterLoad930AM_1030AM.Text = dr("prr_LAWtrld0930to1030").ToString()
                    If dr("prr_LAWtrld0930to1030").ToString() = "O" Then
                        RBT_WaterLoad930to1030Check.Checked = True
                    ElseIf dr("prr_LAWtrld0930to1030").ToString() = "X"
                        RBT_WaterLoad930to1030X.Checked = True
                    Else
                        RBT_WaterLoad930to1030NA.Checked = True
                    End If


                    'TXT_WaterLoad11AM_12PM.Text = dr("prr_LAWtrld1100to1200").ToString()
                    If dr("prr_LAWtrld1100to1200").ToString() = "O" Then
                        RBT_WaterLoad11to12Check.Checked = True
                    ElseIf dr("prr_LAWtrld1100to1200").ToString() = "X"
                        RBT_WaterLoad11to12X.Checked = True
                    Else
                        RBT_WaterLoad11to12NA.Checked = True
                    End If



                    'TXT_WaterLoad1130AM_1230PM.Text = dr("prr_LAWtrld1130to1230").ToString()
                    If dr("prr_LAWtrld1130to1230").ToString() = "O" Then
                        RBT_WaterLoad1130to1230Check.Checked = True
                    ElseIf dr("prr_LAWtrld1130to1230").ToString() = "X"
                        RBT_WaterLoad1130to1230X.Checked = True
                    Else
                        RBT_WaterLoad1130to1230NA.Checked = True
                    End If



                    'TXT_WaterLoad1PM_2PM.Text = dr("prr_LAWtrld0100to0200").ToString()
                    If dr("prr_LAWtrld0100to0200").ToString() = "O" Then
                        RBT_WaterLoad1to2Check.Checked = True
                    ElseIf dr("prr_LAWtrld0100to0200").ToString() = "X"
                        RBT_WaterLoad1to2X.Checked = True
                    Else
                        RBT_WaterLoad1to2NA.Checked = True
                    End If

                    'TXT_WaterLoad130PM_230PM.Text = dr("prr_LAWtrld0130to0230").ToString()
                    If dr("prr_LAWtrld0130to0230").ToString() = "O" Then
                        RBT_WaterLoad130to230Check.Checked = True
                    ElseIf dr("prr_LAWtrld0130to0230").ToString() = "X"
                        RBT_WaterLoad130to230X.Checked = True
                    Else
                        RBT_WaterLoad130to230NA.Checked = True
                    End If

                    'TXT_WaterLoad3PM_4PM.Text = dr("prr_LAWtrld0300to0400").ToString()
                    If dr("prr_LAWtrld0300to0400").ToString() = "O" Then
                        RBT_WaterLoad3to4Check.Checked = True
                    ElseIf dr("prr_LAWtrld0300to0400").ToString() = "X"
                        RBT_WaterLoad3to4X.Checked = True
                    Else
                        RBT_WaterLoad3to4NA.Checked = True
                    End If


                    'TXT_WaterLoad330PM_430PM.Text = dr("prr_LAWtrld0330to0430").ToString()
                    If dr("prr_LAWtrld0330to0430").ToString() = "O" Then
                        RBT_WaterLoad330to430Check.Checked = True
                    ElseIf dr("prr_LAWtrld0330to0430").ToString() = "X"
                        RBT_WaterLoad330to430X.Checked = True
                    Else
                        RBT_WaterLoad330to430NA.Checked = True
                    End If


                    'TXT_WaterLoad5PM_6PM.Text = dr("prr_LAWtrld0500to0600").ToString()
                    If dr("prr_LAWtrld0500to0600").ToString() = "O" Then
                        RBT_WaterLoad5to6Check.Checked = True
                    ElseIf dr("prr_LAWtrld0500to0600").ToString() = "X"
                        RBT_WaterLoad5to6X.Checked = True
                    Else
                        RBT_WaterLoad5to6NA.Checked = True
                    End If


                    'TXT_WaterLoad530PM_630PM.Text = dr("prr_LAWtrld0530to0630").ToString()
                    If dr("prr_LAWtrld0530to0630").ToString() = "O" Then
                        RBT_WaterLoad530to630Check.Checked = True
                    ElseIf dr("prr_LAWtrld0530to0630").ToString() = "X"
                        RBT_WaterLoad530to630X.Checked = True
                    Else
                        RBT_WaterLoad530to630NA.Checked = True
                    End If

                    TXT_Thickness7AM_8AM.Text = dr("prr_LAThickn0700to0800").ToString()
                    TXT_Thickness730AM_830AM.Text = dr("prr_LAThickn0730to0830").ToString()
                    TXT_Thickness9AM_10AM.Text = dr("prr_LAThickn0900to1000").ToString()
                    TXT_Thickness930AM_1030AM.Text = dr("prr_LAThickn0930to1030").ToString()
                    TXT_Thickness11AM_12PM.Text = dr("prr_LAThickn1100to1200").ToString()
                    TXT_Thickness1130AM_1230PM.Text = dr("prr_LAThickn1130to1230").ToString()
                    TXT_Thickness1PM_2PM.Text = dr("prr_LAThickn0100to0200").ToString()
                    TXT_Thickness130PM_230PM.Text = dr("prr_LAThickn0130to0230").ToString()
                    TXT_Thickness3PM_4PM.Text = dr("prr_LAThickn0300to0400").ToString()
                    TXT_Thickness330PM_430PM.Text = dr("prr_LAThickn0330to0430").ToString()
                    TXT_Thickness5PM_6PM.Text = dr("prr_LAThickn0500to0600").ToString()
                    TXT_Thickness530PM_630PM.Text = dr("prr_LAThickn0530to0630").ToString()

                    TXT_Moisture7AM_8AM.Text = dr("prr_LAMoist0700to0800").ToString()
                    TXT_Moisture730AM_830AM.Text = dr("prr_LAMoist0730to0830").ToString()
                    TXT_Moisture9AM_10AM.Text = dr("prr_LAMoist0900to1000").ToString()
                    TXT_Moisture930AM_1030AM.Text = dr("prr_LAMoist0930to1030").ToString()
                    TXT_Moisture11AM_12PM.Text = dr("prr_LAMoist1100to1200").ToString()
                    TXT_Moisture1130AM_1230PM.Text = dr("prr_LAMoist1130to1230").ToString()
                    TXT_Moisture1PM_2PM.Text = dr("prr_LAMoist0100to0200").ToString()
                    TXT_Moisture130PM_230PM.Text = dr("prr_LAMoist0130to0230").ToString()
                    TXT_Moisture3PM_4PM.Text = dr("prr_LAMoist0300to0400").ToString()
                    TXT_Moisture330PM_430PM.Text = dr("prr_LAMoist0330to0430").ToString()
                    TXT_Moisture5PM_6PM.Text = dr("prr_LAMoist0500to0600").ToString()
                    TXT_Moisture530PM_630PM.Text = dr("prr_LAMoist0530to0630").ToString()


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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BTN_SaveProductionRun_Click(sender As Object, e As EventArgs) Handles BTN_SaveProductionRun.Click
        Dim SelectedGluing As String = ""

        If RBT_GluingCheck.Checked Then
            SelectedGluing = "O"
        ElseIf RBT_GluingX.Checked Then
            SelectedGluing = "X"
        ElseIf RBT_GluingCheckNA.Checked Then
            SelectedGluing = "N"
        End If



        Dim selectedWaterApplication As String = ""

        If RBT_WaterApplicationCheck.Checked Then
            selectedWaterApplication = "O"
        ElseIf RBT_WaterApplicationX.Checked Then
            selectedWaterApplication = "X"
        ElseIf RBT_WaterApplicationNA.Checked Then
            selectedWaterApplication = "N"
        End If



        Dim selectedTorn As String = ""

        If RBT_TornCheck.Checked Then
            selectedTorn = "O"
        ElseIf RBT_TornChecX.Checked Then
            selectedTorn = "X"
        ElseIf RBT_TornCheckNA.Checked Then
            selectedTorn = "N"
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

            cmd.CommandText = "Select_TimeMaintenance"
            cmd.CommandType = CommandType.StoredProcedure

            'cmd.CommandText = "Select time FROM [dbo].[timemaintenance]  WHERE [time] BETWEEN @FromTime And @ToTime order by time ASC"
            'cmd.CommandType = CommandType.Text

            'cmd.CommandText = "SELECT [time]FROM [dbo].[timemaintenance] WHERE ([time] >= @FromTime AND [time] <= '2359') OR ([time] >= '0000' AND [time] <= @ToTime) "

            'cmd.CommandText = "SELECT time FROM [dbo].[timemaintenance] WHERE time >= @FromTime OR time <= @ToTime"
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



                    cmd.CommandText = $"UPDATE sppmcPRR_LAM 
                           SET prr_LAGluApp{vartime} = @prr_LAGluApp, 
                               prr_LAGluApp{vartime}val = @prr_LAGluAppval, 
                               prr_LAWtrApp{vartime} = @prr_LAWtrApp, 
                               prr_LAWtrApp{vartime}val = @prr_LAWtrAppval, 
                               prr_LAToCrScr{vartime} = @prr_LAToCrScr, 
                               prr_LAToCrScr{vartime}val = @prr_LAToCrScrval 
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_LAGluApp", SelectedGluing)
                        .AddWithValue("@prr_LAGluAppval", TXT_GluingQty.Text)
                        .AddWithValue("@prr_LAWtrApp", selectedWaterApplication)
                        .AddWithValue("@prr_LAWtrAppval", TXT_WaterApplicationQty.Text)
                        .AddWithValue("@prr_LAToCrScr", selectedTorn)
                        .AddWithValue("@prr_LAToCrScrval", TXT_TornQty.Text)


                    End With
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                MsgBox("Successfully saved!")
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

            cmd.CommandText = "Select_TimeMaintenance"
            cmd.CommandType = CommandType.StoredProcedure
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

                    cmd.CommandText = $"UPDATE sppmcPRR_LAM 
                           SET prr_LAGluApp{vartime} = @prr_LAGluApp, 
                               prr_LAGluApp{vartime}val = @prr_LAGluAppval, 
                               prr_LAWtrApp{vartime} = @prr_LAWtrApp, 
                               prr_LAWtrApp{vartime}val = @prr_LAWtrAppval, 
                               prr_LAToCrScr{vartime} = @prr_LAToCrScr, 
                               prr_LAToCrScr{vartime}val = @prr_LAToCrScrval
                            WHERE Site = @Site AND mcnum = @mcnum"
                    With cmd.Parameters
                        .Clear()

                        .AddWithValue("@Site", Form1.cmb_site.Text)
                        .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                        .AddWithValue("@prr_LAGluApp", SelectedGluing)
                        .AddWithValue("@prr_LAGluAppval", TXT_GluingQty.Text)
                        .AddWithValue("@prr_LAWtrApp", selectedWaterApplication)
                        .AddWithValue("@prr_LAWtrAppval", TXT_WaterApplicationQty.Text)
                        .AddWithValue("@prr_LAToCrScr", selectedTorn)
                        .AddWithValue("@prr_LAToCrScrval", TXT_TornQty.Text)


                    End With

                    cmd.CommandType = CommandType.Text
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


    Private Sub TXT_GluingQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_GluingQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_WaterApplicationQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_WaterApplicationQty.KeyPress
        NumberOnly(e)
    End Sub


    Private Sub TXT_TornQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TornQty.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_GlueLoad7AM_8AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_GlueLoad730AM_830AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub

    Private Sub TXT_GlueLoad9AM_10AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_GlueLoad930AM_1030AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad11AM_12PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad1130AM_1230PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad1PM_2PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad130PM_230PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub

    Private Sub TXT_GlueLoad3PM_4PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad330PM_430PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad5PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_GlueLoad530PM_630PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_WaterLoad7AM_8AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub

    Private Sub TXT_WaterLoad730AM_830AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad9AM_10AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_WaterLoad930AM_1030AM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad11AM_12PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad1130AM_1230PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad1PM_2PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub


    Private Sub TXT_WaterLoad130PM_230PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad3PM_4PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad330PM_430PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad5PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub



    Private Sub TXT_WaterLoad530PM_630PM_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumberChar(e)
    End Sub

    Private Sub TXT_Thickness7AM_8AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness7AM_8AM.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_Thickness730AM_830AM_TextChanged(sender As Object, e As EventArgs) Handles TXT_Thickness730AM_830AM.TextChanged

    End Sub

    Private Sub TXT_Thickness730AM_830AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness730AM_830AM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness9AM_10AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness9AM_10AM.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_Thickness930AM_1030AM_TextChanged(sender As Object, e As EventArgs) Handles TXT_Thickness930AM_1030AM.TextChanged

    End Sub

    Private Sub TXT_Thickness930AM_1030AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness930AM_1030AM.KeyPress
        NumberChar(e)
    End Sub

    Private Sub TXT_Thickness11AM_12PM_TextChanged(sender As Object, e As EventArgs) Handles TXT_Thickness11AM_12PM.TextChanged

    End Sub

    Private Sub TXT_Thickness11AM_12PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness11AM_12PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness1130AM_1230PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness1130AM_1230PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness1PM_2PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness1PM_2PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness130PM_230PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness130PM_230PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness3PM_4PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness3PM_4PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness330PM_430PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness330PM_430PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness5PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness5PM_6PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Thickness530PM_630PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Thickness530PM_630PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture7AM_8AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture7AM_8AM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture730AM_830AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture730AM_830AM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture9AM_10AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture9AM_10AM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture930AM_1030AM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture930AM_1030AM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture11AM_12PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture11AM_12PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture1130AM_1230PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture1130AM_1230PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture1PM_2PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture1PM_2PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture130PM_230PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture130PM_230PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture3PM_4PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture3PM_4PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture330PM_430PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture330PM_430PM.KeyPress
        NumberChar(e)
    End Sub



    Private Sub TXT_Moisture5PM_6PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture5PM_6PM.KeyPress
        NumberChar(e)
    End Sub


    Private Sub TXT_Moisture530PM_630PM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Moisture530PM_630PM.KeyPress
        NumberChar(e)
    End Sub

    Private Sub RBT_GluingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GluingCheck.CheckedChanged
        TXT_GluingQty.Enabled = False
        TXT_GluingQty.Text = ""
    End Sub

    Private Sub RBT_GluingX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GluingX.CheckedChanged
        TXT_GluingQty.Enabled = True
    End Sub

    Private Sub RBT_GluingCheckNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_GluingCheckNA.CheckedChanged
        TXT_GluingQty.Enabled = False
        TXT_GluingQty.Text = ""
    End Sub

    Private Sub RBT_WaterApplicationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_WaterApplicationCheck.CheckedChanged
        TXT_WaterApplicationQty.Enabled = False
        TXT_WaterApplicationQty.Text = ""
    End Sub

    Private Sub RBT_WaterApplicationX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_WaterApplicationX.CheckedChanged
        TXT_WaterApplicationQty.Enabled = True
    End Sub

    Private Sub RBT_WaterApplicationNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_WaterApplicationNA.CheckedChanged
        TXT_WaterApplicationQty.Enabled = False
        TXT_WaterApplicationQty.Text = ""
    End Sub

    Private Sub RBT_TornCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TornCheck.CheckedChanged
        TXT_TornQty.Enabled = False
        TXT_TornQty.Text = ""
    End Sub

    Private Sub RBT_TornChecX_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TornChecX.CheckedChanged
        TXT_TornQty.Enabled = True
    End Sub

    Private Sub RBT_TornCheckNA_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_TornCheckNA.CheckedChanged
        TXT_TornQty.Enabled = False
        TXT_TornQty.Text = ""
    End Sub

    Private Sub CBO_FromTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_FromTime.SelectedIndexChanged
        If CBO_FromTime.Text = "" Or ComboBox1.Text = "" Then

            BTN_SaveProductionRun.Enabled = False
        Else
            BTN_SaveProductionRun.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If CBO_FromTime.Text = "" Or ComboBox1.Text = "" Then

            BTN_SaveProductionRun.Enabled = False
        Else
            BTN_SaveProductionRun.Enabled = True
        End If
    End Sub
End Class