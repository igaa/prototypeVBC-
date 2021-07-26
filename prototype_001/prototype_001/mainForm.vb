Public Class mainForm
    Public succes As Boolean = False
    Public _action As Action

    'Sub New(ByVal action As Action)
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    _action = action
    'End Sub

    'Private Sub New(ByVal action As Action)
    '    _action = action

    'End Sub

    Private Sub Module1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Module1ToolStripMenuItem.Click

    End Sub

    Private Sub btnModule1p2_Click(sender As Object, e As EventArgs) Handles btnModule1p2.Click
        Call OpenForm(ChildForm, True)
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Await Task.Run(_action)
        Call CenterForm(Me)
        Me.BackColor = Color.SteelBlue

    End Sub


    'Private Sub openForm(ByVal frm As Form, ByVal a As Boolean)

    '    'Using formload As mainForm = New mainForm(Sub() Threading.Thread.Sleep(500))
    '    '    Call openForm(frm, True)
    '    'End Using

    'End Sub

    Private Sub mainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim login As loginform = New loginform()

        If Not succes Then

            login.ShowDialog()
        Else
            If login.Visible = False Then
                login.Close()
            End If
        End If
    End Sub

    Private Sub Template1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Templat1ToolStripMenuItem.Click
        Call OpenForm(export_doc, True)
    End Sub
End Class
