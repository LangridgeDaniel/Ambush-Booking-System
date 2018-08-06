<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AmmendBooking
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
        Me.SuspendLayout()
        '
        'Btn_Back
        '
        Me.Btn_Back.Location = New System.Drawing.Point(160, 226)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(112, 23)
        Me.Btn_Back.TabIndex = 1
        Me.Btn_Back.Text = "Back to Main Menu"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'Frm_AmmendBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn_Back)
        Me.Name = "Frm_AmmendBooking"
        Me.Text = "Ammend A Booking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Back As Button
End Class
