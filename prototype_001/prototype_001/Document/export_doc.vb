Imports document_process
Imports DataTransaction.Document_class
Imports System.Data
Imports System


Public Class export_doc

    Private dt As DataTable
    Private filldoc As document_modul_class

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim doc As procces_doc = New procces_doc()

        Dim x As Boolean = False

        x = proccesdoc(x)

        If x = True Then
            MsgBox("BERHASIL EXPORT DATA", vbExclamation)
        End If

    End Sub

    'Private Function getselecteddata(ByVal a As Guid) As Guid

    '    DataTable.Clear()
    '    row = DataTable.NewRow()
    '    row("ID") = Id
    '    row("Nama") = Me.tbName.Text
    '    row("Ttl") = Me.dtpTTL.Value
    '    row("Alamat") = Me.RtbAlamat.Text
    '    DataTable.Rows.Add(row)

    '    Return a
    'End Function
    Private Function getId(ByVal dt As DataTable)
        Dim row As DataRow


        If Not dtgData.Rows.Count = 0 Then

            dt.Columns.Add("ID", GetType(System.Guid))
            dt.Columns.Add("ID_TAG", GetType(System.Guid))

            dt.Clear()
            row = dt.NewRow()

            row("ID") = Guid.Parse(dtgData.SelectedCells(0).Value.ToString())
            row("ID_TAG") = Guid.Parse(dtgData.SelectedCells(1).Value.ToString())

            dt.Rows.Add(row)
        End If
        Return dt
    End Function

    Private Function proccesdoc(ByVal x As Boolean) As Boolean

        Dim dt As DataTable = New DataTable() 'dtParameter

        getId(dt) ' GET ID PARAM

        If x = False Then
            Dim doc As procces_doc = New procces_doc()
            x = doc.createdoc(dt, x)
            If x Then
                Return x
            End If

        End If
        Return x
    End Function

    Private Sub FillDS()
        dt = New DataTable()
        filldoc = New document_modul_class()
        Try
            filldoc.getContentTemplate(dt, AppConfig.app_helper.show)

            dtgData.DataSource = dt
        Catch ex As Exception

        End Try

    End Sub

    Private Sub exportdoc_load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDS()
        Me.dtgData.Columns("ID_TEMPLATE").Visible = False
        Me.dtgData.Columns("ID_TAG").Visible = False
    End Sub

    'Private Sub dtgData_SelectionChanged(sender As Object, e As EventArgs) Handles dtgData.SelectionChanged
    '    If Not dtg1.SelectedCells.Count = 0 Then

    '    End If
    'End Sub
End Class