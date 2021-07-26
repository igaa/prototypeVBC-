Imports System.Data.SqlClient
Public Class AppTransaction



    'Public AT As String = "PayBoro.NET 2010 - " & Format(Year(Now))
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


    Public Sub GetErrorFillData()

        MsgBox("Terjadi kesalahan saat mengisi data!", vbExclamation)
    End Sub

    'Public Sub OpenForm(ByVal Frm As Form, ByVal Penuh As Boolean)
    '    Dim i As Integer

    '    For i = 0 To Application.OpenForms.Count - 1
    '        If Application.OpenForms.Item(i).Name.ToString = Frm.Name.ToString Then
    '            Frm.Focus()
    '        Else
    '            Frm.MdiParent = mainForm
    '            If Penuh = True Then
    '                Frm.WindowState = FormWindowState.Maximized
    '            End If
    '            Frm.Show()
    '            Frm.BackColor = Color.SteelBlue
    '            Dim ctl As Control
    '            For Each ctl In Frm.Controls
    '                If TypeOf ctl Is Label Or TypeOf ctl Is RadioButton Then ctl.ForeColor = Color.White
    '                If TypeOf ctl Is GroupBox Then
    '                    Dim Ctl1 As Control
    '                    For Each Ctl1 In ctl.Controls
    '                        If TypeOf Ctl1 Is Label Or TypeOf ctl Is RadioButton Then
    '                            ctl.ForeColor = Color.Black
    '                        End If
    '                    Next
    '                End If
    '            Next
    '        End If
    '    Next i
    'End Sub

    'Public Sub ClearTxt(ByVal Frm As Form)
    '    Dim Ctl As Control
    '    For Each Ctl In Frm.Controls
    '        If TypeOf Ctl Is GroupBox Then
    '            Dim Ctl1 As Control
    '            For Each Ctl1 In Frm.Controls(0).Controls
    '                If TypeOf Ctl1 Is TextBox Then
    '                    Ctl1.Text = ""
    '                End If
    '                If TypeOf Ctl1 Is RichTextBox Then
    '                    Ctl1.Text = ""
    '                End If
    '                If TypeOf Ctl1 Is DateTimePicker Then
    '                    Ctl1.Text = ""
    '                End If
    '            Next
    '        End If
    '    Next
    'End Sub


End Class
