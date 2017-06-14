<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mytasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mytasks))
        Me.Xit = New System.Windows.Forms.ToolStripMenuItem()
        Me.showMTasks = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.m = New System.Windows.Forms.Timer(Me.components)
        Me.min = New System.Windows.Forms.PictureBox()
        Me.mt_abt = New System.Windows.Forms.Button()
        Me.book = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.user = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vif = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.TextBox()
        Me.des = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TrayMenu.SuspendLayout()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Xit
        '
        Me.Xit.BackColor = System.Drawing.Color.White
        Me.Xit.Image = Global.Vifarnet.My.Resources.Resources.close2
        Me.Xit.Name = "Xit"
        Me.Xit.Size = New System.Drawing.Size(165, 22)
        Me.Xit.Text = "Exit My Tasks"
        Me.Xit.ToolTipText = "Exit My Tasks"
        '
        'showMTasks
        '
        Me.showMTasks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showMTasks.Image = Global.Vifarnet.My.Resources.Resources.taskx
        Me.showMTasks.Name = "showMTasks"
        Me.showMTasks.Size = New System.Drawing.Size(165, 22)
        Me.showMTasks.Text = "Show 'My Tasks'"
        Me.showMTasks.ToolTipText = "Show My Tasks app window"
        '
        'TrayMenu
        '
        Me.TrayMenu.BackColor = System.Drawing.Color.White
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showMTasks, Me.Xit})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(166, 48)
        '
        'nfi
        '
        Me.nfi.BalloonTipText = "Notification"
        Me.nfi.ContextMenuStrip = Me.TrayMenu
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "My Tasks"
        '
        'm
        '
        Me.m.Interval = 1000
        '
        'min
        '
        Me.min.BackColor = System.Drawing.Color.Transparent
        Me.min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.min.Image = Global.Vifarnet.My.Resources.Resources.min
        Me.min.Location = New System.Drawing.Point(768, 1)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(33, 31)
        Me.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.min.TabIndex = 67
        Me.min.TabStop = False
        '
        'mt_abt
        '
        Me.mt_abt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_abt.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mt_abt.Image = Global.Vifarnet.My.Resources.Resources.infoy
        Me.mt_abt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mt_abt.Location = New System.Drawing.Point(738, 402)
        Me.mt_abt.Name = "mt_abt"
        Me.mt_abt.Size = New System.Drawing.Size(69, 47)
        Me.mt_abt.TabIndex = 59
        Me.mt_abt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mt_abt.UseVisualStyleBackColor = True
        '
        'book
        '
        Me.book.AllowDrop = True
        Me.book.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book.Location = New System.Drawing.Point(14, 398)
        Me.book.Name = "book"
        Me.book.Size = New System.Drawing.Size(113, 38)
        Me.book.TabIndex = 62
        Me.book.Text = "Book Reminder"
        Me.book.UseVisualStyleBackColor = True
        '
        'dt
        '
        Me.dt.AllowDrop = True
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dt.Location = New System.Drawing.Point(14, 166)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(180, 20)
        Me.dt.TabIndex = 61
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Vifarnet.My.Resources.Resources.task
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Gabriola", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.Black
        Me.user.Location = New System.Drawing.Point(101, 81)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(47, 54)
        Me.user.TabIndex = 53
        Me.user.Text = "...."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Pristina", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(68, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 35)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "My Tasks!"
        '
        'vif
        '
        Me.vif.AutoSize = True
        Me.vif.BackColor = System.Drawing.Color.Transparent
        Me.vif.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vif.Location = New System.Drawing.Point(69, 6)
        Me.vif.Name = "vif"
        Me.vif.Size = New System.Drawing.Size(87, 26)
        Me.vif.TabIndex = 50
        Me.vif.Text = "Vifarnet"
        '
        'title
        '
        Me.title.AllowDrop = True
        Me.title.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(14, 197)
        Me.title.Multiline = True
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(707, 33)
        Me.title.TabIndex = 64
        Me.title.Text = "Title/Subject"
        '
        'des
        '
        Me.des.AllowDrop = True
        Me.des.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des.Location = New System.Drawing.Point(14, 234)
        Me.des.Multiline = True
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(707, 158)
        Me.des.TabIndex = 63
        Me.des.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 45)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Here's where you'll set your tasks for today"
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 39)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Time of the task..."
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gabriola", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-3, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 54)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Welcome,"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Vifarnet.My.Resources.Resources.bar
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(812, 5)
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'mytasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet.My.Resources.Resources.bg26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.mt_abt)
        Me.Controls.Add(Me.book)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vif)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.des)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mytasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Tasks"
        Me.TrayMenu.ResumeLayout(False)
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Xit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents showMTasks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents m As System.Windows.Forms.Timer
    Friend WithEvents min As System.Windows.Forms.PictureBox
    Friend WithEvents mt_abt As System.Windows.Forms.Button
    Friend WithEvents book As System.Windows.Forms.Button
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vif As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.TextBox
    Friend WithEvents des As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
