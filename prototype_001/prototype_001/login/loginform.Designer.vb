<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnlogin)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'pwd
        '
        Me.pwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pwd.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.pwd.Location = New System.Drawing.Point(166, 133)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(206, 17)
        Me.pwd.TabIndex = 6
        Me.pwd.Text = "Password"
        '
        'username
        '
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.username.Location = New System.Drawing.Point(166, 64)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(206, 17)
        Me.username.TabIndex = 5
        Me.username.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.prototype_001.My.Resources.Resources.pwd2
        Me.PictureBox2.Location = New System.Drawing.Point(102, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(284, 65)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.prototype_001.My.Resources.Resources.user2
        Me.PictureBox1.Location = New System.Drawing.Point(102, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 57)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnlogin.ForeColor = System.Drawing.Color.Black
        Me.btnlogin.Location = New System.Drawing.Point(102, 196)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(284, 48)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(502, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.ShowIcon = False
        Me.Tag = "login"
        Me.Text = "Login Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents pwd As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
