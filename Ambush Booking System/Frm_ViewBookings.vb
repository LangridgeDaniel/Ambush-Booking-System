Public Class Frm_ViewBookings

    Dim EventDate As Date

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Frm_MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        If MonthCalendar1.SelectionStart <> DateTimePicker1.Value Then
            MonthCalendar1.SelectionStart = DateTimePicker1.Value
        End If

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        If DateTimePicker1.Value <> MonthCalendar1.SelectionStart Then
            DateTimePicker1.Value = MonthCalendar1.SelectionStart
        End If

    End Sub

    Private Sub Btn_DateNext_Click(sender As Object, e As EventArgs) Handles Btn_DateNext.Click

        EventDate = DateTimePicker1.Value

        GrpBox_DateSelection.Visible = False
        'GrpBox_CustomerDetails.Visible = True 'Change to next Group

        'Me.Width = GrpBox_CustomerDetails.Width + 20 'Change to next Group

    End Sub

    Private Sub Frm_ViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GrpBox_

    End Sub
End Class