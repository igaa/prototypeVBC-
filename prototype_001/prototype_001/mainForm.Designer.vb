<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.C1MainMenu1 = New C1.Win.C1Command.C1MainMenu()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Module1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModule1p2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Module2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Templat1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1MainMenu1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1MainMenu1
        '
        Me.C1MainMenu1.AccessibleName = "Menu Bar"
        Me.C1MainMenu1.CommandHolder = Nothing
        Me.C1MainMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1})
        Me.C1MainMenu1.Controls.Add(Me.MenuStrip1)
        Me.C1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.C1MainMenu1.Name = "C1MainMenu1"
        Me.C1MainMenu1.Size = New System.Drawing.Size(1029, 27)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Module1ToolStripMenuItem, Me.Module2ToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1029, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Module1ToolStripMenuItem
        '
        Me.Module1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.Module1ToolStripMenuItem.Name = "Module1ToolStripMenuItem"
        Me.Module1ToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.Module1ToolStripMenuItem.Text = "Module 1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModule1p2})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'btnModule1p2
        '
        Me.btnModule1p2.Name = "btnModule1p2"
        Me.btnModule1p2.Size = New System.Drawing.Size(89, 22)
        Me.btnModule1p2.Text = "1.2"
        '
        'Module2ToolStripMenuItem
        '
        Me.Module2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.Module2ToolStripMenuItem.Name = "Module2ToolStripMenuItem"
        Me.Module2ToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.Module2ToolStripMenuItem.Text = "Module 2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripMenuItem4.Text = "2.1"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripMenuItem5.Text = "2.2"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplateToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'TemplateToolStripMenuItem
        '
        Me.TemplateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Templat1ToolStripMenuItem})
        Me.TemplateToolStripMenuItem.Name = "TemplateToolStripMenuItem"
        Me.TemplateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TemplateToolStripMenuItem.Text = "Template"
        '
        'Templat1ToolStripMenuItem
        '
        Me.Templat1ToolStripMenuItem.Name = "Templat1ToolStripMenuItem"
        Me.Templat1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Templat1ToolStripMenuItem.Text = "Template_1"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 734)
        Me.Controls.Add(Me.C1MainMenu1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainForm"
        Me.Text = "Main"
        Me.C1MainMenu1.ResumeLayout(False)
        Me.C1MainMenu1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1MainMenu1 As C1.Win.C1Command.C1MainMenu
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Module1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents btnModule1p2 As ToolStripMenuItem
    Friend WithEvents Module2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemplateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Templat1ToolStripMenuItem As ToolStripMenuItem
End Class
