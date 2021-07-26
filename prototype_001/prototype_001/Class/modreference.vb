Public Class modreference
    Public Function ValidIsi(ByVal Model As Integer) As String
        ValidIsi = String.Empty
        Select Case Model
            Case 1
                ValidIsi = "0123456789SAIM"
            Case 2
                ValidIsi = "0123456789-"
            Case 3
                ValidIsi = "0123456789,"

            Case 4
                ValidIsi = "0123456789.-"
            Case 5
                ValidIsi = "0123456789,."
            Case 6
                ValidIsi = "0123456789,.-"
            Case 11
                ValidIsi = "PWpw" 'Pria/Wanita
            Case 12
                ValidIsi = "LPlp" 'Laki-laki/Perempuan
            Case 13
                ValidIsi = "YTyt" 'Ya/Tidak
            Case 14
                ValidIsi = "YNyn" 'Yes/No
            Case 15
                ValidIsi = "DKdk" 'Debet/Kredit
        End Select
    End Function



End Class
