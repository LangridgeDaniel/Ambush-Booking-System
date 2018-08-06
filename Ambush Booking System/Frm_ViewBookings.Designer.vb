<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ViewBookings
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
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.GrpBox_DateSelection = New System.Windows.Forms.GroupBox()
        Me.Btn_DateNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Other = New System.Windows.Forms.Button()
        Me.Btn_Nerf = New System.Windows.Forms.Button()
        Me.Btn_Airsoft = New System.Windows.Forms.Button()
        Me.Btn_50 = New System.Windows.Forms.Button()
        Me.Btn_WalkOn68 = New System.Windows.Forms.Button()
        Me.Btn_68 = New System.Windows.Forms.Button()
        Me.GrpBox_68 = New System.Windows.Forms.GroupBox()
        Me.GrpBox_Airsoft = New System.Windows.Forms.GroupBox()
        Me.GrpBox_68WalkOn = New System.Windows.Forms.GroupBox()
        Me.GrpBox_Nerf = New System.Windows.Forms.GroupBox()
        Me.GrpBox_50 = New System.Windows.Forms.GroupBox()
        Me.GrpBox_Other = New System.Windows.Forms.GroupBox()
        Me.Btn_EventSelection_Back = New System.Windows.Forms.Button()
        Me.GrpBox_DateSelection.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Back
        '
        Me.Btn_Back.Location = New System.Drawing.Point(336, 1252)
        Me.Btn_Back.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(428, 65)
        Me.Btn_Back.TabIndex = 2
        Me.Btn_Back.Text = "Back To Main menu"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'GrpBox_DateSelection
        '
        Me.GrpBox_DateSelection.Controls.Add(Me.Btn_DateNext)
        Me.GrpBox_DateSelection.Controls.Add(Me.Label1)
        Me.GrpBox_DateSelection.Controls.Add(Me.MonthCalendar1)
        Me.GrpBox_DateSelection.Controls.Add(Me.DateTimePicker1)
        Me.GrpBox_DateSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpBox_DateSelection.Location = New System.Drawing.Point(6, 6)
        Me.GrpBox_DateSelection.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_DateSelection.Name = "GrpBox_DateSelection"
        Me.GrpBox_DateSelection.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_DateSelection.Size = New System.Drawing.Size(798, 800)
        Me.GrpBox_DateSelection.TabIndex = 4
        Me.GrpBox_DateSelection.TabStop = False
        Me.GrpBox_DateSelection.Text = "Date Selection"
        '
        'Btn_DateNext
        '
        Me.Btn_DateNext.Location = New System.Drawing.Point(260, 706)
        Me.Btn_DateNext.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_DateNext.Name = "Btn_DateNext"
        Me.Btn_DateNext.Size = New System.Drawing.Size(238, 65)
        Me.Btn_DateNext.TabIndex = 4
        Me.Btn_DateNext.Text = "Next"
        Me.Btn_DateNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 629)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select event date above and click next"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(3, 3)
        Me.MonthCalendar1.Location = New System.Drawing.Point(38, 71)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(29, 26, 29, 26)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(209, 538)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(356, 44)
        Me.DateTimePicker1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_EventSelection_Back)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Btn_Other)
        Me.GroupBox1.Controls.Add(Me.Btn_Nerf)
        Me.GroupBox1.Controls.Add(Me.Btn_Airsoft)
        Me.GroupBox1.Controls.Add(Me.Btn_50)
        Me.GroupBox1.Controls.Add(Me.Btn_WalkOn68)
        Me.GroupBox1.Controls.Add(Me.Btn_68)
        Me.GroupBox1.Location = New System.Drawing.Point(823, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox1.Size = New System.Drawing.Size(747, 800)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Selection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 74)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please select the Event you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wish to see bookings for:"
        '
        'Btn_Other
        '
        Me.Btn_Other.Location = New System.Drawing.Point(19, 562)
        Me.Btn_Other.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_Other.Name = "Btn_Other"
        Me.Btn_Other.Size = New System.Drawing.Size(659, 65)
        Me.Btn_Other.TabIndex = 6
        Me.Btn_Other.Text = "Other"
        Me.Btn_Other.UseVisualStyleBackColor = True
        '
        'Btn_Nerf
        '
        Me.Btn_Nerf.Location = New System.Drawing.Point(20, 479)
        Me.Btn_Nerf.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_Nerf.Name = "Btn_Nerf"
        Me.Btn_Nerf.Size = New System.Drawing.Size(659, 65)
        Me.Btn_Nerf.TabIndex = 5
        Me.Btn_Nerf.Text = "Nerf"
        Me.Btn_Nerf.UseVisualStyleBackColor = True
        '
        'Btn_Airsoft
        '
        Me.Btn_Airsoft.Location = New System.Drawing.Point(19, 396)
        Me.Btn_Airsoft.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_Airsoft.Name = "Btn_Airsoft"
        Me.Btn_Airsoft.Size = New System.Drawing.Size(659, 65)
        Me.Btn_Airsoft.TabIndex = 3
        Me.Btn_Airsoft.Text = "Airsoft"
        Me.Btn_Airsoft.UseVisualStyleBackColor = True
        '
        'Btn_50
        '
        Me.Btn_50.Location = New System.Drawing.Point(19, 313)
        Me.Btn_50.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_50.Name = "Btn_50"
        Me.Btn_50.Size = New System.Drawing.Size(659, 65)
        Me.Btn_50.TabIndex = 2
        Me.Btn_50.Text = ".50 Cal"
        Me.Btn_50.UseVisualStyleBackColor = True
        '
        'Btn_WalkOn68
        '
        Me.Btn_WalkOn68.Location = New System.Drawing.Point(19, 231)
        Me.Btn_WalkOn68.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_WalkOn68.Name = "Btn_WalkOn68"
        Me.Btn_WalkOn68.Size = New System.Drawing.Size(659, 65)
        Me.Btn_WalkOn68.TabIndex = 1
        Me.Btn_WalkOn68.Text = "WalkOn .68 Cal"
        Me.Btn_WalkOn68.UseVisualStyleBackColor = True
        '
        'Btn_68
        '
        Me.Btn_68.Location = New System.Drawing.Point(19, 148)
        Me.Btn_68.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_68.Name = "Btn_68"
        Me.Btn_68.Size = New System.Drawing.Size(659, 65)
        Me.Btn_68.TabIndex = 0
        Me.Btn_68.Text = " .68 Cal"
        Me.Btn_68.UseVisualStyleBackColor = True
        '
        'GrpBox_68
        '
        Me.GrpBox_68.Location = New System.Drawing.Point(1590, 6)
        Me.GrpBox_68.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_68.Name = "GrpBox_68"
        Me.GrpBox_68.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_68.Size = New System.Drawing.Size(747, 800)
        Me.GrpBox_68.TabIndex = 6
        Me.GrpBox_68.TabStop = False
        Me.GrpBox_68.Text = ".68 Cal"
        '
        'GrpBox_Airsoft
        '
        Me.GrpBox_Airsoft.Location = New System.Drawing.Point(2347, 6)
        Me.GrpBox_Airsoft.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_Airsoft.Name = "GrpBox_Airsoft"
        Me.GrpBox_Airsoft.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_Airsoft.Size = New System.Drawing.Size(747, 800)
        Me.GrpBox_Airsoft.TabIndex = 7
        Me.GrpBox_Airsoft.TabStop = False
        Me.GrpBox_Airsoft.Text = "Airsoft"
        '
        'GrpBox_68WalkOn
        '
        Me.GrpBox_68WalkOn.Location = New System.Drawing.Point(1590, 814)
        Me.GrpBox_68WalkOn.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_68WalkOn.Name = "GrpBox_68WalkOn"
        Me.GrpBox_68WalkOn.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_68WalkOn.Size = New System.Drawing.Size(747, 800)
        Me.GrpBox_68WalkOn.TabIndex = 8
        Me.GrpBox_68WalkOn.TabStop = False
        Me.GrpBox_68WalkOn.Text = ".68 Walk On"
        '
        'GrpBox_Nerf
        '
        Me.GrpBox_Nerf.Location = New System.Drawing.Point(2347, 814)
        Me.GrpBox_Nerf.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_Nerf.Name = "GrpBox_Nerf"
        Me.GrpBox_Nerf.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_Nerf.Size = New System.Drawing.Size(747, 800)
        Me.GrpBox_Nerf.TabIndex = 7
        Me.GrpBox_Nerf.TabStop = False
        Me.GrpBox_Nerf.Text = "Nerf"
        '
        'GrpBox_50
        '
        Me.GrpBox_50.Location = New System.Drawing.Point(3104, 6)
        Me.GrpBox_50.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_50.Name = "GrpBox_50"
        Me.GrpBox_50.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_50.Size = New System.Drawing.Size(747, 800)
        Me.GrpBox_50.TabIndex = 9
        Me.GrpBox_50.TabStop = False
        Me.GrpBox_50.Text = ".50 Cal"
        '
        'GrpBox_Other
        '
        Me.GrpBox_Other.Location = New System.Drawing.Point(3105, 814)
        Me.GrpBox_Other.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_Other.Name = "GrpBox_Other"
        Me.GrpBox_Other.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GrpBox_Other.Size = New System.Drawing.Size(747, 800)
        Me.GrpBox_Other.TabIndex = 7
        Me.GrpBox_Other.TabStop = False
        Me.GrpBox_Other.Text = "Other"
        '
        'Btn_EventSelection_Back
        '
        Me.Btn_EventSelection_Back.Location = New System.Drawing.Point(20, 706)
        Me.Btn_EventSelection_Back.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Btn_EventSelection_Back.Name = "Btn_EventSelection_Back"
        Me.Btn_EventSelection_Back.Size = New System.Drawing.Size(238, 65)
        Me.Btn_EventSelection_Back.TabIndex = 5
        Me.Btn_EventSelection_Back.Text = "Back"
        Me.Btn_EventSelection_Back.UseVisualStyleBackColor = True
        '
        'Frm_ViewBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(3844, 1848)
        Me.Controls.Add(Me.GrpBox_Other)
        Me.Controls.Add(Me.GrpBox_50)
        Me.Controls.Add(Me.GrpBox_Nerf)
        Me.Controls.Add(Me.GrpBox_68WalkOn)
        Me.Controls.Add(Me.GrpBox_Airsoft)
        Me.Controls.Add(Me.GrpBox_68)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpBox_DateSelection)
        Me.Controls.Add(Me.Btn_Back)
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "Frm_ViewBookings"
        Me.Text = "Frm_ViewBookings"
        Me.GrpBox_DateSelection.ResumeLayout(False)
        Me.GrpBox_DateSelection.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Back As Button
    Friend WithEvents GrpBox_DateSelection As GroupBox
    Friend WithEvents Btn_DateNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Other As Button
    Friend WithEvents Btn_Nerf As Button
    Friend WithEvents Btn_Airsoft As Button
    Friend WithEvents Btn_50 As Button
    Friend WithEvents Btn_WalkOn68 As Button
    Friend WithEvents Btn_68 As Button
    Friend WithEvents GrpBox_68 As GroupBox
    Friend WithEvents Btn_EventSelection_Back As Button
    Friend WithEvents GrpBox_Airsoft As GroupBox
    Friend WithEvents GrpBox_68WalkOn As GroupBox
    Friend WithEvents GrpBox_Nerf As GroupBox
    Friend WithEvents GrpBox_50 As GroupBox
    Friend WithEvents GrpBox_Other As GroupBox
End Class
