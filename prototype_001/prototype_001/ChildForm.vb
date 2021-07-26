Imports System.Data.SqlClient
Imports System.Data
Imports DataTransaction.Modul1_2__Class

Public Class ChildForm

    Private dataTable As DataTable = New DataTable()
    Private Id As Guid = Guid.Empty
    Private row As DataRow
    Private modul1_2 As Modul2_1_Class

    Private Sub childForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.user_controls()
        Me.Fill_DS()
        Me.dtg1.Columns("ID").Visible = False
    End Sub


    Private Sub Fill_DS()

        modul1_2 = New Modul2_1_Class()

        Try
            dataTable = New DataTable()

            Dim job As String = "select"
            modul1_2.Modul1_2(dataTable, job)

            Me.dtg1.DataSource = dataTable
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub user_controls()
        Me.btnDelete.Enabled = False
    End Sub

    Private Sub init_data()


    End Sub

    Private Function getselecteddata(ByVal a As Guid) As Guid

        dataTable.Clear()
        row = dataTable.NewRow()
        row("ID") = Id
        row("Nama") = Me.tbName.Text
        row("Ttl") = Me.dtpTTL.Value
        row("Alamat") = Me.RtbAlamat.Text
        dataTable.Rows.Add(row)

        Return a
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        modul1_2 = New Modul2_1_Class()

        If Not getselecteddata(Id) = Guid.Empty And Not dataTable.Rows(0)("ID").Equals(Guid.Empty) Then

            Dim job As String = "update"
            modul1_2.Modul1_2(dataTable, job)

        Else

            Dim job As String = "insert"
            modul1_2.Modul1_2(dataTable, job)

        End If



        Me.dtg1.Refresh()

        Me.Fill_DS()
    End Sub

    Private Sub dtg1_SelectionChanged(sender As Object, e As EventArgs) Handles dtg1.SelectionChanged

        If Not dtg1.SelectedCells.Count = 0 Then

            Me.btnDelete.Enabled = True

            Id = Guid.Parse(dtg1.SelectedCells(0).Value.ToString())
            Me.tbName.Text = dtg1.SelectedCells(1).Value.ToString
            Me.dtpTTL.Value = dtg1.SelectedCells(2).Value
            Me.RtbAlamat.Text = dtg1.SelectedCells(3).Value.ToString
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Id = Guid.Empty
        Call ClearTxt(Me)

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Not getselecteddata(Id) = Guid.Empty Then
            Try
                If Not Id = Guid.Empty Then
                    Dim job As String = "delete"
                    modul1_2.Modul1_2(dataTable, job)
                End If
            Catch ex As Exception

            End Try
        End If

        Me.dtg1.Refresh()

        Me.Fill_DS()
    End Sub
End Class


