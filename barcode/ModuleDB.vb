Imports System.Data.SqlClient
Module ModuleDB
    Public con As New SqlConnection("Data Source=ERP-SVR;Initial Catalog=Pallet_Tagging;User ID=sa;Password=pi_dc_2011")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader


    Sub OpenConnection()
        con.Open()
        cmd.Connection = con

    End Sub






End Module
