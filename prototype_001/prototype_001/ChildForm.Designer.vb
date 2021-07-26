<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTTL = New System.Windows.Forms.DateTimePicker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.RtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpTTL)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.RtbAlamat)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 585)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Child 1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(286, 159)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 33)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Tag = "insert"
        Me.btnAdd.Text = "  Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tempat Tanggal Lahir "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Alamat "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = ":"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(205, 30)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(325, 20)
        Me.tbName.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = ":"
        '
        'dtpTTL
        '
        Me.dtpTTL.Location = New System.Drawing.Point(205, 56)
        Me.dtpTTL.Name = "dtpTTL"
        Me.dtpTTL.Size = New System.Drawing.Size(325, 20)
        Me.dtpTTL.TabIndex = 25
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(205, 159)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 33)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Tag = "save"
        Me.btnsave.Text = " Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'RtbAlamat
        '
        Me.RtbAlamat.Location = New System.Drawing.Point(205, 82)
        Me.RtbAlamat.Name = "RtbAlamat"
        Me.RtbAlamat.Size = New System.Drawing.Size(512, 71)
        Me.RtbAlamat.TabIndex = 24
        Me.RtbAlamat.Text = ""
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(367, 159)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Tag = "delete"
        Me.btnDelete.Text = " Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dtg1)
        Me.Panel1.Location = New System.Drawing.Point(3, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 344)
        Me.Panel1.TabIndex = 0
        '
        'dtg1
        '
        Me.dtg1.AllowUserToAddRows = False
        Me.dtg1.AllowUserToDeleteRows = False
        Me.dtg1.AllowUserToOrderColumns = True
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg1.Location = New System.Drawing.Point(0, 0)
        Me.dtg1.MultiSelect = False
        Me.dtg1.Name = "dtg1"
        Me.dtg1.ReadOnly = True
        Me.dtg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg1.Size = New System.Drawing.Size(964, 344)
        Me.dtg1.TabIndex = 0
        '
        'ChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 598)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ChildForm"
        Me.Text = "child1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtg1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTTL As DateTimePicker
    Friend WithEvents btnsave As Button
    Friend WithEvents RtbAlamat As RichTextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
End Class
