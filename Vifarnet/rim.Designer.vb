<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rim))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rest = New System.Windows.Forms.Button()
        Me.usr = New System.Windows.Forms.Label()
        Me.dte = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.des = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Vifarnet.My.Resources.Resources.taskx
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(320, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(294, 37)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Remind me about this later again"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rest
        '
        Me.rest.BackColor = System.Drawing.Color.Transparent
        Me.rest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rest.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown
        Me.rest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.rest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rest.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rest.Image = Global.Vifarnet.My.Resources.Resources.OK2
        Me.rest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rest.Location = New System.Drawing.Point(46, 222)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(252, 37)
        Me.rest.TabIndex = 87
        Me.rest.Text = "Yeah! I remember, Thanks"
        Me.rest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rest.UseVisualStyleBackColor = False
        '
        'usr
        '
        Me.usr.AutoSize = True
        Me.usr.BackColor = System.Drawing.Color.Transparent
        Me.usr.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr.ForeColor = System.Drawing.Color.Green
        Me.usr.Location = New System.Drawing.Point(18, 8)
        Me.usr.Name = "usr"
        Me.usr.Size = New System.Drawing.Size(37, 37)
        Me.usr.TabIndex = 86
        Me.usr.Text = "...."
        '
        'dte
        '
        Me.dte.AllowDrop = True
        Me.dte.BackColor = System.Drawing.Color.White
        Me.dte.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte.Location = New System.Drawing.Point(6, 51)
        Me.dte.Multiline = True
        Me.dte.Name = "dte"
        Me.dte.ReadOnly = True
        Me.dte.Size = New System.Drawing.Size(181, 33)
        Me.dte.TabIndex = 85
        Me.dte.Text = "<time>"
        '
        'title
        '
        Me.title.AllowDrop = True
        Me.title.BackColor = System.Drawing.Color.White
        Me.title.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(193, 51)
        Me.title.Multiline = True
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Size = New System.Drawing.Size(432, 33)
        Me.title.TabIndex = 84
        Me.title.Text = "<title>"
        '
        'des
        '
        Me.des.AllowDrop = True
        Me.des.BackColor = System.Drawing.Color.White
        Me.des.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des.Location = New System.Drawing.Point(6, 90)
        Me.des.Multiline = True
        Me.des.Name = "des"
        Me.des.ReadOnly = True
        Me.des.Size = New System.Drawing.Size(619, 126)
        Me.des.TabIndex = 83
        Me.des.Text = "<dis>"
        '
        'rim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet.My.Resources.Resources.bg9
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(631, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rest)
        Me.Controls.Add(Me.usr)
        Me.Controls.Add(Me.dte)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.des)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rim"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rest As System.Windows.Forms.Button
    Friend WithEvents usr As System.Windows.Forms.Label
    Friend WithEvents dte As System.Windows.Forms.TextBox
    Friend WithEvents title As System.Windows.Forms.TextBox
    Friend WithEvents des As System.Windows.Forms.TextBox
End Class
