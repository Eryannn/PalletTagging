Imports System.Data.SqlClient

Public Class FRM_UserMaintenance
    Dim empNumber As String
    Private Shared connectionString As String = "Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011" ' Replace with your actual connection string
    Private Sub BTN_Register_Click(sender As Object, e As EventArgs) Handles BTN_Register.Click
        'Encrypt(txtpassword.Text.Trim())

        If CBO_Position.Text = "Operator" Or CBO_Position.Text = "Asst. Operator" Then
            If txt_idnum.TextLength <> 4 Then
                MsgBox("Invalid ID number! Requires 4 digit")
            Else
                Reg_user()
            End If
        Else
            Reg_user()
        End If

    End Sub


    Public Shared Function GenerateEmployeeNumber() As String
        ' Get the current year (last two digits)
        Dim currentYear As String = DateTime.Now.Year.ToString().Substring(2, 2)

        ' Initialize the counter variable
        Dim counter As Integer = 1 ' Default counter if no employee number is found

        ' Query to get the latest Emp_num for the current year
        Dim query As String = "SELECT TOP 1 Emp_num FROM Employee WHERE Emp_num LIKE 'PK" & currentYear & "%' ORDER BY Emp_num DESC"

        ' Connect to the database and retrieve the latest Emp_num
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()

                ' Execute the query and retrieve the latest Emp_num
                Dim result = command.ExecuteScalar()

                ' If a result is found, extract and increment the counter
                If result IsNot Nothing Then
                    Dim latestEmpNum As String = result.ToString()
                    Dim counterPart As String = latestEmpNum.Substring(4) ' Extract the counter part (e.g., "001" from "PK25001")
                    counter = Convert.ToInt32(counterPart) + 1 ' Increment the counter
                End If
            End Using
        End Using

        ' Format the counter to always have 3 digits (e.g., 001, 002, 003)
        Dim formattedCounter As String = counter.ToString("D3")

        ' Generate the new Emp_num in the format "PKYYXXX"
        Dim newEmpNum As String = "PK" & currentYear & formattedCounter

        ' Return the new employee number
        Return newEmpNum
    End Function



    Private Sub FRM_UserMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_Site.Text = Form1.cmb_site.Text
        TXT_FullName.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Me.Hide()
        FRM_ProcessJob.Show()

    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        TXT_Empnum.Text = ""
        TXT_FullName.Text = ""
        CBO_Position.Text = ""
        txt_idnum.Clear()
        TXT_Site.Clear()
    End Sub

    Function Generate_Userid()
        Dim UserId As String = "PPK" + txt_idnum.Text
        Return UserId
    End Function

    Function Reg_user()

        If CBO_Position.Text = "Operator" Or CBO_Position.Text = "Asst. Operator" Then
            empNumber = Generate_Userid()
        Else
            empNumber = GenerateEmployeeNumber()
        End If



        Try
            OpenConnection()
            cmd.CommandText = "INSERT INTO Employee (Site, Emp_num, Name, Dept, Section, Position, Password, IsSuperUser,IsAdmin, IsUser, IsActive, Access, Rights) " & "VALUES (@site, @empnum, @name, @department, @section, @position, @password, 0, 0, 1, @IsActive, @access, @rights)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("@site", Form1.cmb_site.Text)
                .AddWithValue("@empnum", empNumber)
                .AddWithValue("@name", TXT_FullName.Text)

                If CBO_Position.Text = "Line Leader" Then
                    .AddWithValue("@department", "Finishing")
                Else
                    .AddWithValue("@department", "Production")
                End If


                If CBO_Position.Text = "Line Leader" Then
                    .AddWithValue("@section", "FINISHING")
                Else
                    .AddWithValue("@section", "PRODUCTION")
                End If

                If CBO_Position.Text = "Asst. Operator" Then
                    .AddWithValue("@position", "Operator")
                Else
                    .AddWithValue("@position", CBO_Position.Text)
                End If
                '.AddWithValue("@position", CBO_Position.Text)
                .AddWithValue("@password", Encrypt(empNumber.Trim()))

                .AddWithValue("@IsActive", "1")
                .AddWithValue("@access", "TAGGING")
                .AddWithValue("@rights", "EDIT")

            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Register Successfully!")
            TXT_Empnum.Text = empNumber



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Return 0
    End Function

    Private Sub NumberOnly(ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_idnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idnum.KeyPress
        NumberOnly(e)
    End Sub
End Class