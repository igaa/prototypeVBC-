Imports System.Data.SqlClient


Public Class app_config
    Public AT As String = "PayBoro.NET"
    Public Conn As SqlConnection
    Public Conn23 As SqlConnection
    Public RecruitmentCn As SqlConnection
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public cmd As SqlCommand
    Public mycontrans As SqlTransaction

    Public PathPhoto As String
    Public PathLogo As String
    Public PathStamp As String
    Public PathTTD As String
    Public PathBlangkoKosong As String
    Public PathBlangkoTerisi As String

    Public isNew As Boolean = False
    'Public Const PathPhoto As String = "\\192.168.3.2\foto\BORO\"
    'Public Const PathLogo As String = "\\192.168.3.2\foto\LOGO\"
    'Public Const PathStamp As String = "\\192.168.3.2\foto\STAMP\"
    'Public Const PathTTD As String = "\\192.168.3.2\foto\TTD\"

    Public Const AppServer As String = ".\"
    'Public Const AppServer As String = "192.168.3.248"
    Public Const AppDB As String = "designApp"

    Public Const RecDB As String = "PSGRekrutmen"
    'Public Const AppUser As String = "sa"
    'Public Const apppwd As String = "37441"

    Public Const AppUser As String = "dev"
    Public Const AppPwd As String = "password"
    'Public Const AppUser As String = "appKoneksi"
    'Public Const AppPwd As String = "app@1psg"

    Public Const AppServer23 As String = "192.168.2.32"
    Public Const AppDB23 As String = "PSGAccounting"
    Public Const AppUser23 As String = "appkoneksi"
    Public Const AppPwd23 As String = "app@1psg"

    Public LogID As Long
    Public KodeDept As Integer
    'Public user As String = mainForm.UserID
    'Public compname As String = mainForm.GetComputerName


    Function getError() As String
        Dim x As String
        x = ""
    End Function

    Function openConnection() As SqlConnection
        Conn = New SqlConnection("server= " & AppServer & "; database=" & AppDB & "; user= " & AppUser & "; password=" & AppPwd & ";" & "pooling=false;" & "Max Pool Size=1000;" & "Connection Timeout=10; ")
        If Conn.State = ConnectionState.Closed Then
            Try
                Conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Ke Server Gagal !", vbExclamation)
            End Try
        End If
        Return Conn
    End Function
    Public Sub closeConnection()
        If Conn.State = ConnectionState.Open Then
            Try
                Conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menutup koneksi!", vbFalse)
            End Try
        End If
    End Sub

End Class
