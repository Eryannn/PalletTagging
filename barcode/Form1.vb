﻿

Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography
Public Class Form1
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"
    'CREATED THIS SYSTEM -ERIAN ROEN DOMONDON
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(128, 255, 128)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14, FontStyle.Bold)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnlogin.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnlogin.Region = New Region(Raduis)
    End Sub
    Private Sub roundCorners(obj As Form)
        'obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Ver. " + app_version
        Dim currenttime As DateTime = DateTime.Now
        If currenttime.Hour >= 7 AndAlso currenttime.Hour < 19 Then
            cmbshift.SelectedIndex = cmbshift.Items.IndexOf("DS")
        Else
            cmbshift.SelectedIndex = cmbshift.Items.IndexOf("NS")
        End If
        RoundButton(btnlogin)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        check_app_version()
        If app_version <> check_app_version() Then
            MessageBox.Show("System out of date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            opendb()
            login(cmbuserid.Text, Encrypt(txtpassword.Text), cmb_site.Text)
            closedb()
        End If
    End Sub

    Private Function check_shift()
        Dim currentDate As DateTime = "1/23/2025 3:15" ' Current date and time
        Dim shift As String = cmbshift.Text ' Replace this with your shift type, either "DS" or "NS"
        Dim shiftStart As DateTime
        Dim shiftEnd As DateTime

        If shift = "DS" Then
            ' Day shift is from 7:00 AM to 7:00 PM
            shiftStart = New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 7, 0, 0)
            shiftEnd = New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 19, 0, 0)

            If currentDate < shiftEnd Then
                ' If current time is before 7 PM, it's still the same date
                MsgBox(currentDate.ToString("MM/dd/yyyy"))
            Else
                ' If it's after 7 PM, we use the next day
                MsgBox(currentDate.AddDays(1).ToString("MM/dd/yyyy"))
            End If
        ElseIf shift = "NS" Then
            ' Night shift is from 7:00 PM to 7:00 AM
            shiftStart = New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 19, 0, 0)
            shiftEnd = New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 7, 0, 0).AddDays(1) ' Add a day to 7:00 AM

            If currentDate >= shiftStart AndAlso currentDate < shiftEnd Then
                ' If current time is between 7 PM and 7 AM, it's still the same date
                MsgBox(currentDate.ToString("MM/dd/yyyy"))
                MsgBox(currentDate)
            Else
                ' If it's after 7 AM, we consider it the next day
                MsgBox(currentDate.AddDays(1).ToString("MM/dd/yyyy"))
                MsgBox(currentDate)
            End If
        End If

        Return 0

    End Function


    Private Sub Button56_Click_2(sender As Object, e As EventArgs) Handles Button56.Click
        'Dim old As Long
        'If Environment.Is64BitOperatingSystem Then
        '    If Wow64DisableWow64FsRedirection(old) Then
        '        Process.Start(osk)
        '        Wow64EnableWow64FsRedirection(old)
        '    End If
        'Else
        '    Process.Start(osk)
        'End If

        check_shift()
    End Sub
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles cmbuserid.DropDown
        opendb()
        populateuser()
        closedb()
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub cmbuserid_TextChanged(sender As Object, e As EventArgs) Handles cmbuserid.TextChanged
        If Not isChangingText Then
            isChangingText = True
            cmbuserid.Text = cmbuserid.Text.ToUpper()
            cmbuserid.SelectionStart = cmbuserid.Text.Length
            isChangingText = False
        End If
    End Sub

    Private isChangingText As Boolean = False
End Class
