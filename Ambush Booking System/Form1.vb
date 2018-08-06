Public Class Frm_MainMenu

    Private Sub Frm_MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Btn_MakeBooking_Click(sender As Object, e As EventArgs) Handles Btn_MakeBooking.Click
        Frm_MakeBooking.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_AmmendBooking_Click(sender As Object, e As EventArgs) Handles Btn_AmmendBooking.Click
        Frm_AmmendBooking.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_GenerateRunningOrder_Click(sender As Object, e As EventArgs) Handles Btn_GenerateRunningOrder.Click
        Frm_GenerateRunningOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        End
    End Sub

    Private Sub Btn_ViewBookings_Click(sender As Object, e As EventArgs) Handles Btn_ViewBookings.Click
        Frm_ViewBookings.Show()
        Me.Hide()
    End Sub
End Class
