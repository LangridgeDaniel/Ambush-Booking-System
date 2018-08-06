<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MainMenu
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
        Me.Btn_MakeBooking = New System.Windows.Forms.Button()
        Me.Btn_AmmendBooking = New System.Windows.Forms.Button()
        Me.Btn_GenerateRunningOrder = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Lbl_VersionNumber = New System.Windows.Forms.Label()
        Me.Btn_ViewBookings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_MakeBooking
        '
        Me.Btn_MakeBooking.Location = New System.Drawing.Point(35, 12)
        Me.Btn_MakeBooking.Name = "Btn_MakeBooking"
        Me.Btn_MakeBooking.Size = New System.Drawing.Size(194, 23)
        Me.Btn_MakeBooking.TabIndex = 0
        Me.Btn_MakeBooking.Text = "Make a Booking"
        Me.Btn_MakeBooking.UseVisualStyleBackColor = True
        '
        'Btn_AmmendBooking
        '
        Me.Btn_AmmendBooking.Location = New System.Drawing.Point(35, 70)
        Me.Btn_AmmendBooking.Name = "Btn_AmmendBooking"
        Me.Btn_AmmendBooking.Size = New System.Drawing.Size(194, 23)
        Me.Btn_AmmendBooking.TabIndex = 1
        Me.Btn_AmmendBooking.Text = "Ammend A Booking"
        Me.Btn_AmmendBooking.UseVisualStyleBackColor = True
        '
        'Btn_GenerateRunningOrder
        '
        Me.Btn_GenerateRunningOrder.Location = New System.Drawing.Point(21, 99)
        Me.Btn_GenerateRunningOrder.Name = "Btn_GenerateRunningOrder"
        Me.Btn_GenerateRunningOrder.Size = New System.Drawing.Size(222, 23)
        Me.Btn_GenerateRunningOrder.TabIndex = 2
        Me.Btn_GenerateRunningOrder.Text = "Generate A Running Order"
        Me.Btn_GenerateRunningOrder.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(35, 153)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(59, 23)
        Me.Btn_Exit.TabIndex = 3
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Lbl_VersionNumber
        '
        Me.Lbl_VersionNumber.AutoSize = True
        Me.Lbl_VersionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_VersionNumber.Location = New System.Drawing.Point(118, 163)
        Me.Lbl_VersionNumber.Name = "Lbl_VersionNumber"
        Me.Lbl_VersionNumber.Size = New System.Drawing.Size(103, 7)
        Me.Lbl_VersionNumber.TabIndex = 4
        Me.Lbl_VersionNumber.Text = "Ambush Booking System v1.1"
        '
        'Btn_ViewBookings
        '
        Me.Btn_ViewBookings.Location = New System.Drawing.Point(35, 41)
        Me.Btn_ViewBookings.Name = "Btn_ViewBookings"
        Me.Btn_ViewBookings.Size = New System.Drawing.Size(194, 23)
        Me.Btn_ViewBookings.TabIndex = 5
        Me.Btn_ViewBookings.Text = "View Bookings"
        Me.Btn_ViewBookings.UseVisualStyleBackColor = True
        '
        'Frm_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 181)
        Me.Controls.Add(Me.Btn_ViewBookings)
        Me.Controls.Add(Me.Lbl_VersionNumber)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_GenerateRunningOrder)
        Me.Controls.Add(Me.Btn_AmmendBooking)
        Me.Controls.Add(Me.Btn_MakeBooking)
        Me.Name = "Frm_MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_MakeBooking As Button
    Friend WithEvents Btn_AmmendBooking As Button
    Friend WithEvents Btn_GenerateRunningOrder As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Lbl_VersionNumber As Label
    Friend WithEvents Btn_ViewBookings As Button
End Class
