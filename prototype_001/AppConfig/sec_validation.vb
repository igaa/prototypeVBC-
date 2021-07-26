Public Class sec_validation
    Public Function DecryptText(strText As String, ByVal Kunci As String)
        Dim i As Integer, c As Integer, strBuff As String = ""

#If Not CASE_SENSITIVE_PASSWORD Then
        Kunci = UCase$(Kunci)
#End If

        If Len(Kunci) Then
            For i = 1 To Len(strText)
                c = Asc(Mid$(strText, i, 1))
                c = c - Asc(Mid$(Kunci, (i Mod Len(Kunci)) + 1, 1))
                strBuff = strBuff & Chr(c And &HFF)
            Next i
        Else
            strBuff = strText
        End If
        DecryptText = strBuff
    End Function
    Public Function EncryptText(strText As String, ByVal Kunci As String)
        Dim i As Integer, c As Integer
        Dim strBuff As String = ""

#If Not CASE_SENSITIVE_PASSWORD Then
        Kunci = UCase$(Kunci)

#End If

        If Len(Kunci) Then
            For i = 1 To Len(strText)
                c = Asc(Mid$(strText, i, 1))
                c = c + Asc(Mid$(Kunci, (i Mod Len(Kunci)) + 1, 1))
                strBuff = strBuff & Chr(c And &HFF)

            Next i
        Else
            strBuff = strText
        End If
        EncryptText = strBuff
    End Function

End Class
