<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asktime
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
        Me.components = New System.ComponentModel.Container()
        Me.rest = New System.Windows.Forms.Button()
        Me.usr = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.m = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'rest
        '
        Me.rest.BackColor = System.Drawing.Color.Transparent
        Me.rest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rest.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.rest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.rest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rest.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rest.Image = Global.Vifarnet.My.Resources.Resources.taskx
        Me.rest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rest.Location = New System.Drawing.Point(208, 53)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(192, 33)
        Me.rest.TabIndex = 88
        Me.rest.Text = "Postpone reminder"
        Me.rest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rest.UseVisualStyleBackColor = False
        '
        'usr
        '
        Me.usr.AutoSize = True
        Me.usr.BackColor = System.Drawing.Color.Transparent
        Me.usr.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr.ForeColor = System.Drawing.Color.Black
        Me.usr.Location = New System.Drawing.Point(7, 9)
        Me.usr.Name = "usr"
        Me.usr.Size = New System.Drawing.Size(464, 26)
        Me.usr.TabIndex = 89
        Me.usr.Text = "Enter the time when the reminder has to be postponed"
        '
        'dt
        '
        Me.dt.AllowDrop = True
        Me.dt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dt.Location = New System.Drawing.Point(12, 53)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(180, 33)
        Me.dt.TabIndex = 90
        '
        'm
        '
        Me.m.Interval = 1000
        '
        'asktime
        '
        Me.AcceptButton = Me.rest
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet.My.Resources.Resources.bg26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(476, 108)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.usr)
        Me.Controls.Add(Me.rest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "asktime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rest As System.Windows.Forms.Button
    Friend WithEvents usr As System.Windows.Forms.Label
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents m As System.Windows.Forms.Timer
End Class
