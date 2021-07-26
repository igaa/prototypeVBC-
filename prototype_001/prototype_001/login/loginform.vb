Public Class loginform



    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterForm(Me)
        'Call set_icon(Me)
    End Sub

    Private Sub tbusername_click(sender As Object, e As EventArgs) Handles username.Click
        If Me.username.Text.Trim().Equals("Username") Then
            Me.username.Text = String.Empty
            Me.username.Font = New Font("Arial", 11.0, FontStyle.Bold)
        End If
    End Sub

    Private Sub pwd_click(sender As Object, e As EventArgs) Handles pwd.Click
        If Me.pwd.Text.Trim().Equals("Password") Then
            Me.pwd.Font = New Font("Arial", 11.0, FontStyle.Bold)

            Me.pwd.PasswordChar = "*"
            Me.pwd.Text = String.Empty

        End If
    End Sub


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim user, pass As String

        user = Trim(UCase(username.Text))

        If user = String.Empty Then
            MsgBox("UserID Tidak Boleh Kosong !", vbCritical, AT)
            username.Focus()
            Exit Sub
        End If
        If pwd.Text = String.Empty Then
            MsgBox("Password Tidak Boleh Kosong !", vbCritical, AT)
            pwd.Focus()
            Exit Sub
        End If

        mainForm.succes = True
        Me.Close()
    End Sub
End Class