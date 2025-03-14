Imports System.Data.SqlClient

Public Class UC_OperatorFinishing
    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function SafeConvertToInt(ByVal value As String) As Integer
        If String.IsNullOrEmpty(value) Then
            Return 0
        Else
            Return Convert.ToInt32(value)
        End If
    End Function
    Private Sub PalletNoCount()
        Dim totalPalletNoCount As Integer = 0

        ' List of all text boxes to check
        Dim textBoxes As New List(Of TextBox) From {TXT_1PalletNo1, TXT_1PalletNo2, TXT_1PalletNo3, TXT_1PalletNo4, TXT_1PalletNo5, TXT_1PalletNo6, TXT_1PalletNo7, TXT_1PalletNo8, TXT_1PalletNo9, TXT_1PalletNo10, TXT_1PalletNo11, TXT_1PalletNo12, TXT_1PalletNo13, TXT_1PalletNo14, TXT_1PalletNo15, TXT_1PalletNo16, TXT_1PalletNo17, TXT_1PalletNo18, TXT_1PalletNo19,
        TXT_1PalletNo20, TXT_1PalletNo21, TXT_1PalletNo22, TXT_1PalletNo23, TXT_1PalletNo24, TXT_1PalletNo25, TXT_1PalletNo26, TXT_1PalletNo27, TXT_1PalletNo28, TXT_1PalletNo29, TXT_1PalletNo30, TXT_1PalletNo31, TXT_1PalletNo32, TXT_1PalletNo33,
        TXT_1PalletNo34, TXT_1PalletNo35, TXT_1PalletNo36, TXT_1PalletNo37, TXT_1PalletNo38, TXT_1PalletNo39, TXT_1PalletNo40, TXT_1PalletNo41, TXT_1PalletNo42} ' Add all your text boxes here

        ' Loop through each text box and check if it has a value
        For Each txtBox As TextBox In textBoxes
            If txtBox.Text <> "" Then
                totalPalletNoCount += 1
            End If
        Next

        ' Optionally, use or return totalPalletNoCount here
        ' For example, you can show the result in a label or textbox:
        TXT_TotalPalletNo.Text = totalPalletNoCount.ToString()
    End Sub


    Private Sub PackageCountTotal()


        Dim Total1PackageCountSum As Integer = SafeConvertToInt(TXT_1PackageCount1.Text) + SafeConvertToInt(TXT_1PackageCount2.Text) + SafeConvertToInt(TXT_1PackageCount3.Text) + SafeConvertToInt(TXT_1PackageCount4.Text) + SafeConvertToInt(TXT_1PackageCount5.Text) + SafeConvertToInt(TXT_1PackageCount6.Text) + SafeConvertToInt(TXT_1PackageCount7.Text) + SafeConvertToInt(TXT_1PackageCount8.Text) + SafeConvertToInt(TXT_1PackageCount9.Text) + SafeConvertToInt(TXT_1PackageCount10.Text) + SafeConvertToInt(TXT_1PackageCount11.Text) + SafeConvertToInt(TXT_1PackageCount12.Text) + SafeConvertToInt(TXT_1PackageCount13.Text) + SafeConvertToInt(TXT_1PackageCount14.Text)

        Dim Total2PackageCountSum As Integer = SafeConvertToInt(TXT_1PackageCount15.Text) + SafeConvertToInt(TXT_1PackageCount16.Text) + SafeConvertToInt(TXT_1PackageCount17.Text) + SafeConvertToInt(TXT_1PackageCount18.Text) + SafeConvertToInt(TXT_1PackageCount19.Text) + SafeConvertToInt(TXT_1PackageCount20.Text) + SafeConvertToInt(TXT_1PackageCount21.Text) + SafeConvertToInt(TXT_1PackageCount22.Text) + SafeConvertToInt(TXT_1PackageCount23.Text) + SafeConvertToInt(TXT_1PackageCount24.Text) + SafeConvertToInt(TXT_1PackageCount25.Text) + SafeConvertToInt(TXT_1PackageCount26.Text) + SafeConvertToInt(TXT_1PackageCount27.Text) + SafeConvertToInt(TXT_1PackageCount28.Text)

        Dim Total3PackageCountSum As Integer = SafeConvertToInt(TXT_1PackageCount29.Text) + SafeConvertToInt(TXT_1PackageCount30.Text) + SafeConvertToInt(TXT_1PackageCount31.Text) + SafeConvertToInt(TXT_1PackageCount32.Text) + SafeConvertToInt(TXT_1PackageCount33.Text) + SafeConvertToInt(TXT_1PackageCount34.Text) + SafeConvertToInt(TXT_1PackageCount35.Text) + SafeConvertToInt(TXT_1PackageCount36.Text) + SafeConvertToInt(TXT_1PackageCount37.Text) + SafeConvertToInt(TXT_1PackageCount38.Text) + SafeConvertToInt(TXT_1PackageCount39.Text) + SafeConvertToInt(TXT_1PackageCount40.Text) + SafeConvertToInt(TXT_1PackageCount41.Text) + SafeConvertToInt(TXT_1PackageCount42.Text)

        Dim TotalPackageCount As Integer = Total1PackageCountSum + Total2PackageCountSum + Total3PackageCountSum
        TXT_TotalPackageCount.Text = Convert.ToDecimal(TotalPackageCount).ToString("N0")

    End Sub

    'Private Sub PackageCountSumQualityPerpack()


    '    Try
    '        Dim QualityPerpack As Integer

    '        OpenConnection()
    '        cmd.CommandText = "SELECT * FROM sppmcJIC WHERE Site = @Site AND mcnum = @mcnum"
    '        cmd.CommandType = CommandType.Text
    '        With cmd.Parameters
    '            .Clear()
    '            .AddWithValue("@Site", Form1.cmb_site.Text)
    '            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
    '        End With
    '        dr = cmd.ExecuteReader
    '        If dr.HasRows Then
    '            If dr.Read Then
    '                QualityPerpack = dr("jic_FIQtyperpk").ToString()
    '                dr.Close()
    '                con.Close()

    '            End If
    '        End If
    '        dr.Close()
    '        con.Close()

    '        Dim PalletNoTotal = SafeConvertToInt(TXT_1PackageCount1.Text) * QualityPerpack


    '        TXT_1PackageCountQty1.Text = PalletNoTotal


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()

    '    End Try




    'End Sub

    'Private Sub PackageCountSumQualityPerpack()

    '    Try
    '        Dim QualityPerpack As Integer

    '        OpenConnection()
    '        cmd.CommandText = "SELECT * FROM sppmcJIC WHERE Site = @Site AND mcnum = @mcnum"
    '        cmd.CommandType = CommandType.Text
    '        With cmd.Parameters
    '            .Clear()
    '            .AddWithValue("@Site", Form1.cmb_site.Text)
    '            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
    '        End With
    '        dr = cmd.ExecuteReader
    '        If dr.HasRows Then
    '            If dr.Read Then
    '                QualityPerpack = SafeConvertToInt(dr("jic_FIQtyperpk").ToString())
    '                dr.Close()
    '                con.Close()
    '            End If
    '        End If
    '        dr.Close()
    '        con.Close()

    '        ' Loop through a range of package counts and update dynamically
    '        Dim totalPackageCount As Integer
    '        For i As Integer = 1 To 10 ' Adjust the range as needed based on the number of TextBoxes
    '            ' Dynamically generate the TextBox names based on the index
    '            Dim packageCountTextBoxName As String = "TXT_1PackageCount" & i.ToString()
    '            Dim packageCountQtyTextBoxName As String = "TXT_1PackageCountQty" & i.ToString()

    '            ' Try to get the controls by name dynamically
    '            Dim packageCountTextBox As TextBox = CType(Me.Controls(packageCountTextBoxName), TextBox)
    '            Dim packageCountQtyTextBox As TextBox = CType(Me.Controls(packageCountQtyTextBoxName), TextBox)

    '            ' Check if the TextBox exists and calculate the total quantity
    '            If packageCountTextBox IsNot Nothing AndAlso packageCountQtyTextBox IsNot Nothing Then
    '                totalPackageCount = SafeConvertToInt(packageCountTextBox.Text) * QualityPerpack
    '                packageCountQtyTextBox.Text = totalPackageCount.ToString()
    '            End If
    '        Next

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try

    'End Sub

    'Private Sub PackageCountSumQualityPerpack()

    '    Try
    '        Dim QualityPerpack As Integer

    '        OpenConnection()
    '        cmd.CommandText = "SELECT * FROM sppmcJIC WHERE Site = @Site AND mcnum = @mcnum"
    '        cmd.CommandType = CommandType.Text
    '        With cmd.Parameters
    '            .Clear()
    '            .AddWithValue("@Site", Form1.cmb_site.Text)
    '            .AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
    '        End With
    '        dr = cmd.ExecuteReader
    '        If dr.HasRows Then
    '            If dr.Read Then
    '                QualityPerpack = SafeConvertToInt(dr("jic_FIQtyperpk").ToString())
    '                dr.Close()
    '                con.Close()
    '            End If
    '            dr.Close()
    '            con.Close()
    '        End If
    '        dr.Close()
    '        con.Close()

    '        ' Loop through a range of package counts for prefix 1, 2, etc. (you can add more prefixes if needed)
    '        For prefix As Integer = 1 To 1 ' Loop through prefix 1 and 2 (adjust if needed)
    '            For i As Integer = 1 To 42 ' Adjust the range as needed based on the number of TextBoxes
    '                ' Dynamically generate the TextBox names based on the prefix and index
    '                Dim packageCountTextBoxName As String = "TXT_" & prefix.ToString() & "PackageCount" & i.ToString()
    '                Dim packageCountQtyTextBoxName As String = "TXT_" & prefix.ToString() & "PackageCountQty" & i.ToString()

    '                ' Try to get the controls by name dynamically
    '                Dim packageCountTextBox As TextBox = CType(Me.Controls(packageCountTextBoxName), TextBox)
    '                Dim packageCountQtyTextBox As TextBox = CType(Me.Controls(packageCountQtyTextBoxName), TextBox)

    '                ' Check if the TextBox exists and calculate the total quantity
    '                If packageCountTextBox IsNot Nothing AndAlso packageCountQtyTextBox IsNot Nothing Then
    '                    Dim totalPackageCount = SafeConvertToInt(packageCountTextBox.Text) * QualityPerpack
    '                    packageCountQtyTextBox.Text = totalPackageCount.ToString()
    '                End If
    '            Next
    '        Next


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try

    'End Sub

    Private Sub PackageCountSumQualityPerpack()
        Dim QualityPerpack As Integer

        Try
            ' Open connection securely
            OpenConnection()

            ' Set up command
            cmd.CommandText = "SELECT * FROM sppmcJIC WHERE Site = @Site AND mcnum = @mcnum"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

            ' Use a Using block to automatically handle the SqlDataReader
            Using dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    If dr.Read() Then
                        QualityPerpack = SafeConvertToInt(dr("jic_FIQtyperpk").ToString())
                    End If
                End If
            End Using ' SqlDataReader will be disposed of automatically here
            dr.Close()
            con.Close()
            ' Loop through package counts and calculate totals
            For prefix As Integer = 1 To 1 ' Loop for prefix 1 (you can expand if needed)
                For i As Integer = 1 To 42 ' Loop through TextBox indices
                    Dim packageCountTextBoxName As String = "TXT_" & prefix.ToString() & "PackageCount" & i.ToString()
                    Dim packageCountQtyTextBoxName As String = "TXT_" & prefix.ToString() & "PackageCountQty" & i.ToString()

                    ' Try to get the controls by name dynamically
                    Dim packageCountTextBox As TextBox = CType(Me.Controls(packageCountTextBoxName), TextBox)
                    Dim packageCountQtyTextBox As TextBox = CType(Me.Controls(packageCountQtyTextBoxName), TextBox)

                    ' Check if TextBox exists and calculate total package count
                    If packageCountTextBox IsNot Nothing AndAlso packageCountQtyTextBox IsNot Nothing Then
                        Dim totalPackageCount = SafeConvertToInt(packageCountTextBox.Text) * QualityPerpack
                        packageCountQtyTextBox.Text = totalPackageCount.ToString()
                    End If
                Next
            Next

        Catch ex As Exception
            ' Display the exception message in case of an error
            MsgBox(ex.Message)
        Finally
            ' Ensure that the connection is always closed securely
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub





    Private Sub PackageCountQty()
        Dim Total1PackageCountQtySum As Integer = SafeConvertToInt(TXT_1PackageCountQty1.Text) + SafeConvertToInt(TXT_1PackageCountQty2.Text) + SafeConvertToInt(TXT_1PackageCountQty3.Text) + SafeConvertToInt(TXT_1PackageCountQty4.Text) + SafeConvertToInt(TXT_1PackageCountQty5.Text) + SafeConvertToInt(TXT_1PackageCountQty6.Text) + SafeConvertToInt(TXT_1PackageCountQty7.Text) + SafeConvertToInt(TXT_1PackageCountQty8.Text) + SafeConvertToInt(TXT_1PackageCountQty9.Text) + SafeConvertToInt(TXT_1PackageCountQty10.Text) + SafeConvertToInt(TXT_1PackageCountQty11.Text) + SafeConvertToInt(TXT_1PackageCountQty12.Text) + SafeConvertToInt(TXT_1PackageCountQty13.Text) + SafeConvertToInt(TXT_1PackageCountQty14.Text)

        Dim Total2PackageCountQtySum As Integer = SafeConvertToInt(TXT_1PackageCountQty15.Text) + SafeConvertToInt(TXT_1PackageCountQty16.Text) + SafeConvertToInt(TXT_1PackageCountQty17.Text) + SafeConvertToInt(TXT_1PackageCountQty18.Text) + SafeConvertToInt(TXT_1PackageCountQty19.Text) + SafeConvertToInt(TXT_1PackageCountQty20.Text) + SafeConvertToInt(TXT_1PackageCountQty21.Text) + SafeConvertToInt(TXT_1PackageCountQty22.Text) + SafeConvertToInt(TXT_1PackageCountQty23.Text) + SafeConvertToInt(TXT_1PackageCountQty24.Text) + SafeConvertToInt(TXT_1PackageCountQty25.Text) + SafeConvertToInt(TXT_1PackageCountQty26.Text) + SafeConvertToInt(TXT_1PackageCountQty27.Text) + SafeConvertToInt(TXT_1PackageCountQty28.Text)

        Dim Total3PackageCountQtySum As Integer = SafeConvertToInt(TXT_1PackageCountQty29.Text) + SafeConvertToInt(TXT_1PackageCountQty30.Text) + SafeConvertToInt(TXT_1PackageCountQty31.Text) + SafeConvertToInt(TXT_1PackageCountQty32.Text) + SafeConvertToInt(TXT_1PackageCountQty33.Text) + SafeConvertToInt(TXT_1PackageCountQty34.Text) + SafeConvertToInt(TXT_1PackageCountQty35.Text) + SafeConvertToInt(TXT_1PackageCountQty36.Text) + SafeConvertToInt(TXT_1PackageCountQty37.Text) + SafeConvertToInt(TXT_1PackageCountQty38.Text) + SafeConvertToInt(TXT_1PackageCountQty39.Text) + SafeConvertToInt(TXT_1PackageCountQty40.Text) + SafeConvertToInt(TXT_1PackageCountQty41.Text) + SafeConvertToInt(TXT_1PackageCountQty42.Text)

        Dim TotalPackageCountQty As Integer = Total1PackageCountQtySum + Total2PackageCountQtySum + Total3PackageCountQtySum
        TXT_PackageQty.Text = Convert.ToDecimal(TotalPackageCountQty).ToString("N0")

    End Sub





    Private Sub UC_OperatorFinishing_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If position = "Operator" Or position = "Line Leader" Then

            TXT_Remarks.Enabled = True
            BTN_Save.Visible = True

            If FRM_MonitoringChecklistMain.TXT_MCNO.Text = "" Then

                BTN_Save.Enabled = False

            End If
        Else
            BTN_Save.Enabled = False
            TXT_Remarks.Enabled = False
        End If


        If FRM_MonitoringChecklistMain.txt_operator.Text <> "" Then

            If FRM_MonitoringChecklistMain.lbl_empname.Text <> FRM_MonitoringChecklistMain.txt_operator.Text Then
                BTN_Save.Enabled = False

            End If
        End If



        Try
            ' Ensure the connection is open and cleanly handled
            Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011") ' Replace connectionString with your actual connection string
                con.Open()

                ' Create a command to fetch data for the pallets
                Using cmd As New SqlCommand("SELECT * FROM sppmcPRR_FIN_REP WHERE Site = @Site And mcnum = @mcnum", con)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                    cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                    ' Execute the command and retrieve data
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        Dim palletIndex As Integer = 1 ' Initialize the pallet index

                        While dr.Read() ' Read each record from the result set
                            ' Dynamically set values for the current pallet
                            If palletIndex <= 42 Then
                                CType(Me.Controls("TXT_1PalletNo" & palletIndex), TextBox).Text = dr("output_FIPalletNo").ToString()
                                CType(Me.Controls("TXT_PackageNo" & palletIndex), TextBox).Text = dr("output_FIPckgNum").ToString()
                                CType(Me.Controls("TXT_1PackageCount" & palletIndex), TextBox).Text = dr("output_FIPckg#").ToString()
                                CType(Me.Controls("TXT_1PackageCountQty" & palletIndex), TextBox).Text = dr("output_FIQty").ToString()
                            End If

                            palletIndex += 1 ' Move to the next pallet index
                        End While

                    End Using ' Automatically closes dr when done
                End Using ' Automatically closes cmd when done
            End Using ' Automatically closes con when done

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






        Try
            ' Ensure the connection is open and cleanly handled
            Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011") ' Replace connectionString with your actual connection string
                con.Open()

                ' Create and configure the command for SELECT query
                Using cmd As New SqlCommand("SELECT output_Remrks FROM sppmcOutput WHERE Site = @Site AND mcnum = @mcnum", con)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                    cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                    ' Execute the command and retrieve data
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        If dr.HasRows Then
                            ' Record exists, retrieve the value for output_Remrks
                            If dr.Read() Then
                                TXT_Remarks.Text = dr("output_Remrks").ToString()
                            End If
                        Else
                            ' No rows found, handle accordingly (optional)
                            TXT_Remarks.Text = String.Empty ' or provide a default value
                        End If
                    End Using ' Automatically closes dr when done
                End Using ' Automatically closes cmd when done
            End Using ' Automatically closes con when done

        Catch ex As Exception
            ' Display error message in case of failure
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub TXT_1PackageCount1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount1.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount2.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount3.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount4.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount5.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount6.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount7.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount8.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount9.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount10.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount11.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount12.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount13.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount14.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount15.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount16.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount17.TextChanged
        PackageCountSumQualityPerpack()
        PackageCountTotal()
    End Sub

    Private Sub TXT_2PackageCount4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount18.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount19.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount20.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount21.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount22.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount23.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount24.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount25.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount26.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount27.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_2PackageCount14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount28.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount29.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount30.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount31.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount32.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount33.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount34.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount35.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount36.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount37.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount38.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount39.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount40.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount41.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_3PackageCount14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCount42.TextChanged
        PackageCountTotal()
        PackageCountSumQualityPerpack()
    End Sub

    Private Sub TXT_1PackageCount1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount1.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount3.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount4.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount5.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount6.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount7.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount8.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount9.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount10.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount11.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount12.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount13.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCount14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount14.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty1.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty1.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty2.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty3.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty3.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty4.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty4.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty5.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty5.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty6.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty6.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty7.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty7.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty8.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty8.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty9.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty9.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty10.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty10.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty11.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty11.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty12.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty12.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty13.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty13.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PackageCountQty14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty14.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_1PackageCountQty14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty14.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo1.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo1.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo2.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo2.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo3.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo3.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo4.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo4.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo5.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo5.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo6.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo6.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo7.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo7.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo8.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo8.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo9.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo9.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo10.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo10.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo11.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo11.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo12.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo12.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo13.TextChanged

    End Sub

    Private Sub TXT_1PalletNo13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo13.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_1PalletNo14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo14.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_1PalletNo14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo14.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo15.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo15.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo16.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo16.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo17.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo17.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo18.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo18.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo19.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo19.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo20.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo20.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo21.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo21.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo22.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo22.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo23.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo23.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo24.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo24.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo25.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo25.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo26.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo26.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo27.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo27.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PalletNo14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo28.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_2PalletNo14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo28.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount15.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount16.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount17.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount18.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount19.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount20.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount21.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount22.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount23.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount24.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount25.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount26.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount27.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCount14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount28.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty15.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty15.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty16.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty16.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty17.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty17.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty18.TextChanged

    End Sub

    Private Sub TXT_2PackageCountQty4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty18.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty19.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty19.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty20.TextChanged

    End Sub

    Private Sub TXT_2PackageCountQty6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty20.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty21.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty21.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty22.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty22.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty23.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty23.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty24.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty24.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty25.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty25.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty26.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty26.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty27.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty27.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_2PackageCountQty14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty28.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_2PackageCountQty14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty28.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo29.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo29.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo30.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo30.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo31.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo31.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo32.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo32.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo33.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo33.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo34.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo34.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo35.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo36.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo37.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo38.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo39.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo40.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo41.KeyPress
        NumberOnly(e)
    End Sub



    Private Sub TXT_3PalletNo14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PalletNo42.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount29.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount30.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount31.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount32.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount33.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount34.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount35.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount36.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount37.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount38.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount39.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount40.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount41.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCount14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCount42.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty1_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty29.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty29.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty2_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty30.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty30.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty3_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty31.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty31.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty4_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty32.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty32.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty5_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty33.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty33.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty6_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty34.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty34.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty35.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty35.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty36.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty36.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty37.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty37.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty38.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty38.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty39.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty39.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty40.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty40.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty41.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty41.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PackageCountQty14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PackageCountQty42.TextChanged
        PackageCountQty()
    End Sub

    Private Sub TXT_3PackageCountQty14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1PackageCountQty42.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TXT_3PalletNo7_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo35.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo8_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo36.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo9_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo37.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo10_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo38.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo11_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo39.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo12_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo40.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo13_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo41.TextChanged
        PalletNoCount()
    End Sub

    Private Sub TXT_3PalletNo14_TextChanged(sender As Object, e As EventArgs) Handles TXT_1PalletNo42.TextChanged
        PalletNoCount()
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Try
            'Dim palletCountTotal As Integer = TXT_TotalPalletNo.Text

            'For i As Integer = 1 To 42
            '    Dim palletTextBoxNameHide As String = "TXT_HidePalletNo" & i.ToString()
            '    Dim palletTextBoxName As String = "TXT_1PalletNo" & i.ToString()
            '    Dim packageNoTextBoxName As String = "TXT_PackageNo" & i.ToString()
            '    Dim packageCountTextBoxName As String = "TXT_1PackageCount" & i.ToString()
            '    Dim packageQtyTextBoxName As String = "TXT_1PackageCountQty" & i.ToString()

            '    ' Get the TextBox controls dynamically
            '    Dim palletTextBoxHide As TextBox = CType(Me.Controls(palletTextBoxNameHide), TextBox)
            '    Dim palletTextBox As TextBox = CType(Me.Controls(palletTextBoxName), TextBox)
            '    Dim packageNoTextBox As TextBox = CType(Me.Controls(packageNoTextBoxName), TextBox)
            '    Dim packageCountTextBox As TextBox = CType(Me.Controls(packageCountTextBoxName), TextBox)
            '    Dim packageQtyTextBox As TextBox = CType(Me.Controls(packageQtyTextBoxName), TextBox)



            '    If palletTextBoxHide Is Nothing AndAlso palletTextBox Is Nothing AndAlso packageNoTextBox Is Nothing AndAlso packageCountTextBox Is Nothing AndAlso packageQtyTextBox Is Nothing Then
            '        If String.IsNullOrWhiteSpace(palletTextBox.Text) OrElse palletTextBox.Text = "0" Then
            '            Continue For
            '        End If

            '        OpenConnection()

            '        cmd.CommandText = "SELECT * FROM sppmcPRR_FIN_REP WHERE Site = @Site AND mcnum = @mcnum AND [output_FIPallet#] = @output_FIPallet#"
            '        cmd.CommandType = CommandType.Text
            '        cmd.Parameters.Clear()
            '        cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            '        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            '        cmd.Parameters.AddWithValue("@output_FIPallet#", palletTextBoxHide.Text)

            '        dr = cmd.ExecuteReader()

            '        If dr.HasRows Then
            '            dr.Close()
            '            con.Close()

            '            ' Perform Update
            '            OpenConnection()
            '            cmd.CommandText = "UPDATE sppmcPRR_FIN_REP SET output_FIPallet# = @output_FIPallet#, output_FIPckgNum = @output_FIPckgNum, output_FIPckg# = @output_FIPckg#, output_FIQty = @output_FIQty WHERE Site = @Site AND mcnum = @mcnum AND [output_FIPallet#] = @output_FIPallet#"
            '            cmd.CommandType = CommandType.Text
            '            cmd.Parameters.Clear()
            '            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            '            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPallet#", palletTextBoxHide.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPalletNo", palletTextBox.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPckgNum", packageNoTextBox.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPckg#", packageCountTextBox.Text)
            '            cmd.Parameters.AddWithValue("@output_FIQty", packageQtyTextBox.Text)

            '            cmd.ExecuteNonQuery()
            '            con.Close()

            '        Else
            '            dr.Close()
            '            con.Close()

            '            ' Perform Insert
            '            OpenConnection()
            '            cmd.CommandText = "INSERT INTO sppmcPRR_FIN_REP (Site, mcnum, [output_FIPallet#], output_FIPckgNum, output_FIPckg#, output_FIQty) VALUES (@Site, @mcnum, @output_FIPallet#, @output_FIPckgNum, @output_FIPckg#, @output_FIQty)"
            '            cmd.CommandType = CommandType.Text
            '            cmd.Parameters.Clear()
            '            cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
            '            cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPallet#", palletTextBoxHide.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPalletNo", palletTextBox.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPckgNum", packageNoTextBox.Text)
            '            cmd.Parameters.AddWithValue("@output_FIPckg#", packageCountTextBox.Text)
            '            cmd.Parameters.AddWithValue("@output_FIQty", packageQtyTextBox.Text)

            '            cmd.ExecuteNonQuery()
            '            con.Close()
            '        End If
            '    End If
            'Next
            For i As Integer = 1 To 42
                Dim palletTextBoxNameHide As String = "TXT_HidePalletNo" & i.ToString()
                Dim palletTextBoxName As String = "TXT_1PalletNo" & i.ToString()
                Dim packageNoTextBoxName As String = "TXT_PackageNo" & i.ToString()
                Dim packageCountTextBoxName As String = "TXT_1PackageCount" & i.ToString()
                Dim packageQtyTextBoxName As String = "TXT_1PackageCountQty" & i.ToString()

                ' Get the TextBox controls dynamically
                Dim palletTextBoxHide As TextBox = CType(Me.Controls(palletTextBoxNameHide), TextBox)
                Dim palletTextBox As TextBox = CType(Me.Controls(palletTextBoxName), TextBox)
                Dim packageNoTextBox As TextBox = CType(Me.Controls(packageNoTextBoxName), TextBox)
                Dim packageCountTextBox As TextBox = CType(Me.Controls(packageCountTextBoxName), TextBox)
                Dim packageQtyTextBox As TextBox = CType(Me.Controls(packageQtyTextBoxName), TextBox)

                If palletTextBoxHide IsNot Nothing AndAlso palletTextBox IsNot Nothing AndAlso
                   packageNoTextBox IsNot Nothing AndAlso packageCountTextBox IsNot Nothing AndAlso
                   packageQtyTextBox IsNot Nothing Then

                    ' Check if HidePalletNo is empty or "0", if so, skip this iteration
                    If String.IsNullOrWhiteSpace(palletTextBoxHide.Text) OrElse palletTextBoxHide.Text = "0" Then
                        Continue For
                    End If

                    ' Check if any of the required textboxes are empty or contain only whitespace
                    If String.IsNullOrWhiteSpace(palletTextBox.Text) OrElse
                       String.IsNullOrWhiteSpace(packageNoTextBox.Text) OrElse
                       String.IsNullOrWhiteSpace(packageCountTextBox.Text) OrElse
                       String.IsNullOrWhiteSpace(packageQtyTextBox.Text) Then
                        'MsgBox("One or more required fields are empty. Skipping entry for Pallet #" & palletTextBoxHide.Text)
                        Continue For ' Skip inserting if any required textbox is empty
                    End If

                    OpenConnection()

                    cmd.CommandText = "SELECT * FROM sppmcPRR_FIN_REP WHERE Site = @Site AND mcnum = @mcnum AND [output_FIPallet#] = @output_FIPallet#"
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                    cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                    cmd.Parameters.AddWithValue("@output_FIPallet#", palletTextBoxHide.Text)

                    dr = cmd.ExecuteReader()

                    If dr.HasRows Then
                        dr.Close()
                        con.Close()

                        ' Perform Update
                        OpenConnection()
                        cmd.CommandText = "UPDATE sppmcPRR_FIN_REP SET output_FIPallet# = @output_FIPallet#, output_FIPalletNo = @output_FIPalletNo, output_FIPckgNum = @output_FIPckgNum, output_FIPckg# = @output_FIPckg#, output_FIQty = @output_FIQty WHERE Site = @Site AND mcnum = @mcnum AND [output_FIPallet#] = @output_FIPallet#"
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        cmd.Parameters.AddWithValue("@output_FIPallet#", palletTextBoxHide.Text)
                        cmd.Parameters.AddWithValue("@output_FIPalletNo", palletTextBox.Text)
                        cmd.Parameters.AddWithValue("@output_FIPckgNum", packageNoTextBox.Text)
                        cmd.Parameters.AddWithValue("@output_FIPckg#", packageCountTextBox.Text)
                        cmd.Parameters.AddWithValue("@output_FIQty", packageQtyTextBox.Text)

                        cmd.ExecuteNonQuery()
                        con.Close()
                    Else
                        dr.Close()
                        con.Close()

                        ' Perform Insert
                        OpenConnection()
                        cmd.CommandText = "INSERT INTO sppmcPRR_FIN_REP (Site, mcnum, [output_FIPallet#],output_FIPalletNo, output_FIPckgNum, output_FIPckg#, output_FIQty) VALUES (@Site, @mcnum, @output_FIPallet#,@output_FIPalletNo, @output_FIPckgNum, @output_FIPckg#, @output_FIQty)"
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                        cmd.Parameters.AddWithValue("@output_FIPallet#", palletTextBoxHide.Text)
                        cmd.Parameters.AddWithValue("@output_FIPalletNo", palletTextBox.Text)
                        cmd.Parameters.AddWithValue("@output_FIPckgNum", packageNoTextBox.Text)
                        cmd.Parameters.AddWithValue("@output_FIPckg#", packageCountTextBox.Text)
                        cmd.Parameters.AddWithValue("@output_FIQty", packageQtyTextBox.Text)

                        cmd.ExecuteNonQuery()
                        con.Close()
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
        con.Close()
        End Try




        Try
            ' Ensure the connection is open and cleanly handled
            Using con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011") ' Replace connectionString with your actual connection string
                con.Open()

                ' Create and configure the command for SELECT query
                Using cmd As New SqlCommand("SELECT * FROM sppmcOutput WHERE Site = @Site AND mcnum = @mcnum", con)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                    cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)

                    ' Execute the command and retrieve data
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        If dr.HasRows Then
                            ' Record exists, perform UPDATE
                            dr.Close()

                            ' Create a new command for UPDATE to update the record
                            Using updateCmd As New SqlCommand("UPDATE sppmcOutput SET output_Remrks = @output_Remrks WHERE Site = @Site AND mcnum = @mcnum", con)
                                updateCmd.CommandType = CommandType.Text
                                updateCmd.Parameters.Clear()
                                updateCmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                                updateCmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                                updateCmd.Parameters.AddWithValue("@output_Remrks", TXT_Remarks.Text)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        Else
                            ' Record doesn't exist, perform INSERT
                            dr.Close()

                            ' Create a new command for INSERT to insert the new record
                            Using insertCmd As New SqlCommand("INSERT INTO sppmcOutput (Site, mcnum, output_Remrks) VALUES (@Site, @mcnum, @output_Remrks)", con)
                                insertCmd.CommandType = CommandType.Text
                                insertCmd.Parameters.Clear()
                                insertCmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
                                insertCmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
                                insertCmd.Parameters.AddWithValue("@output_Remrks", TXT_Remarks.Text)
                                insertCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using ' Automatically closes dr when done
                End Using ' Automatically closes cmd when done
            End Using ' Automatically closes con when done

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Try
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



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()


        End Try


        'Try
        '    OpenConnection()
        '    cmd.CommandText = "SELECT * FROM sppmcOutput WHERE Site = @Site and mcnum =  @mcnum"
        '    cmd.CommandType = CommandType.Text
        '    cmd.Parameters.Clear()
        '    cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
        '    cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        '    dr = cmd.ExecuteReader
        '    If dr.HasRows Then
        '        dr.Close()
        '        con.Close()

        '        OpenConnection()
        '        cmd.CommandText = "UPDATE sppmcOutput SET output_Remrks = @output_Remrks WHERE Site = @Site AND mcnum = @mcnum"
        '        cmd.CommandType = CommandType.Text
        '        cmd.Parameters.Clear()
        '        cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
        '        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        '        cmd.Parameters.AddWithValue("@output_Remrks", TXT_Remarks.Text)
        '        cmd.ExecuteNonQuery()
        '        con.Close()


        '    Else


        '        OpenConnection()
        '        cmd.CommandText = "INSERT INTO sppmcOutput (Site,mcnum, output_Remrks) VALUES (@Site, @mcnum, @output_Remrks )"
        '        cmd.CommandType = CommandType.Text
        '        cmd.Parameters.Clear()
        '        cmd.Parameters.AddWithValue("@Site", Form1.cmb_site.Text)
        '        cmd.Parameters.AddWithValue("@mcnum", FRM_MonitoringChecklistMain.TXT_MCNO.Text)
        '        cmd.Parameters.AddWithValue("@output_Remrks", TXT_Remarks.Text)
        '        cmd.ExecuteNonQuery()
        '        con.Close()


        '    End If
        '    dr.Close()
        '    con.Close()



        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    con.Close()

        'End Try






        MsgBox("saved successfully!")

        Dim int As Integer
        For int = 0 To 0
            FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain.Controls.RemoveAt(int)
        Next


        Dim UC_OperatorFinishing As New UC_OperatorFinishing


        UC_OperatorFinishing.Parent = FRM_MonitoringChecklistMain.PNL_MonitoringChecklistOperatorMain
        UC_OperatorFinishing.Show()
        UC_OperatorFinishing.Dock = DockStyle.Fill

    End Sub

    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click

        'section = FRM_ProcessJob.LBL_OrigSection.Text
        'section_code = FRM_ProcessJob.LBL_SecCode.Text
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


        section = FRM_MonitoringChecklistMain.TXT_OrigSection.Text
        section_code = FRM_MonitoringChecklistMain.TXT_OrigSectionCode.Text
        FRM_MonitoringChecklistMain.LBL_SectionName.Text = section

        FRM_MonitoringChecklistMain.LBL_Title.Visible = True
        FRM_MonitoringChecklistMain.LBL_Title.Text = "MONITORING CHECKLIST - "
        FRM_MonitoringChecklistMain.LBL_SectionName.Visible = True


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TXT_HidePalletNo5.TextChanged

    End Sub

    Private Sub TXT_PackageNo1_TextChanged(sender As Object, e As EventArgs) Handles TXT_PackageNo1.TextChanged

    End Sub
End Class
