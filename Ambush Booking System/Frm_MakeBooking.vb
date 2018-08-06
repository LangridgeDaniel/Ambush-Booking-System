Public Class Frm_MakeBooking

    Public EventDate As Date
    Public OrganiserName, GroupAge, EventType, TimeSlot As String
    Public GroupSize As Integer

    Public PaintballBronze, PaintballSilver, PaintballGold, PaintballPlatinum As Integer
    Public AirsoftRental, AirsoftOwnGear As Integer
    Public PaintballWalkOnRental, PaintballWalkOnOwnGear As Integer

    Private Sub Frm_MakeBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = GrpBox_DateSelection.Width + 20

        GrpBox_CustomerDetails.Text = ""
        GrpBox_DateSelection.Text = ""
        GrpBox_EventDetails.Text = ""
        GrpBox_Event_TimesOther.Text = ""
        GrpBox_Event_TimesPaintball.Text = ""
        GrpBox_68PackageDetails.Text = ""
        GrpBox_AirsoftPackageDetails.Text = ""
        GrpBox_68WalkOnPackageDetails.Text = ""

        GrpBox_DateSelection.Parent = Me
        GrpBox_CustomerDetails.Parent = Me
        GrpBox_EventDetails.Parent = Me
        GrpBox_68PackageDetails.Parent = Me
        GrpBox_AirsoftPackageDetails.Parent = Me
        GrpBox_68WalkOnPackageDetails.Parent = Me

        GrpBox_CustomerDetails.Location = GrpBox_DateSelection.Location
        GrpBox_EventDetails.Location = GrpBox_DateSelection.Location
        GrpBox_68PackageDetails.Location = GrpBox_DateSelection.Location
        GrpBox_AirsoftPackageDetails.Location = GrpBox_DateSelection.Location
        GrpBox_68WalkOnPackageDetails.Location = GrpBox_DateSelection.Location

        GrpBox_CustomerDetails.Visible = False
        GrpBox_EventDetails.Visible = False
        GrpBox_68PackageDetails.Visible = False
        GrpBox_AirsoftPackageDetails.Visible = False
        GrpBox_68WalkOnPackageDetails.Visible = False

        MonthCalendar1.MinDate = Date.Today

        GrpBox_Event_TimesOther.Location = GrpBox_Event_TimesPaintball.Location

        GrpBox_Event_TimesOther.Parent = GrpBox_EventDetails
        GrpBox_Event_TimesPaintball.Parent = GrpBox_EventDetails

    End Sub

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

    Private Sub RdoBtn_Other_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Other.CheckedChanged

        If RdoBtn_Other.Checked = True Then
            TxtBox_EventOther.Visible = True
        Else
            TxtBox_EventOther.Visible = False
        End If

        CheckActiveTimingGroup()

    End Sub

    Private Sub RdoBtn_68_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_68.CheckedChanged
        CheckActiveTimingGroup()
    End Sub

    Private Sub RdoBtn_50_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_50.CheckedChanged
        CheckActiveTimingGroup()
    End Sub

    Private Sub RdoBtn_Airsoft_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Airsoft.CheckedChanged
        CheckActiveTimingGroup()
    End Sub

    Private Sub RdoBtn_Laser_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Laser.CheckedChanged
        CheckActiveTimingGroup()
    End Sub

    Private Sub RdoBtn_Nerf_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Nerf.CheckedChanged
        CheckActiveTimingGroup()
    End Sub

    Function CheckActiveTimingGroup()

        If RdoBtn_68.Checked = True Or RdoBtn_Airsoft.Checked = True Or RdoBtn_Other.Checked = True Or RdoBtn_68WalkOn.Checked = True Then
            GrpBox_Event_TimesPaintball.Visible = True
            GrpBox_Event_TimesOther.Visible = False
        ElseIf RdoBtn_Laser.Checked = True Or RdoBtn_Nerf.Checked = True Or RdoBtn_50.Checked = True Then
            GrpBox_Event_TimesPaintball.Visible = False
            GrpBox_Event_TimesOther.Visible = True
        End If

    End Function

    Private Sub Btn_AirsoftPackageDetailsNext_Click(sender As Object, e As EventArgs) Handles Btn_AirsoftPackageDetailsNext.Click

        Dim Count As Integer = RentalCounterAirsoft.Value + OwnGearCounterAirsoft.Value

        AirsoftRental = RentalCounterAirsoft.Value
        AirsoftOwnGear = OwnGearCounterAirsoft.Value

        If Count <> GroupSize Then
            MsgBox("Number of Participants does not equal group size")
        Else
            ConfirmBooking()
        End If

    End Sub

    Private Sub Btn_PaintballWalkOnPackageDetailsNext_Click(sender As Object, e As EventArgs) Handles Btn_PaintballWalkOnPackageDetailsNext.Click

        Dim Count As Integer = RentalCounter68WalkOn.Value + OwnGearCounter68WalkOn.Value

        PaintballWalkOnRental = RentalCounter68WalkOn.Value
        PaintballWalkOnOwnGear = OwnGearCounter68WalkOn.Value

        If Count <> GroupSize Then
            MsgBox("Number of Participants does not equal group size")
        Else
            ConfirmBooking()
        End If

    End Sub

    Private Sub Btn_68PackageDetailsBack_Click(sender As Object, e As EventArgs) Handles Btn_68PackageDetailsBack.Click

        GrpBox_68PackageDetails.Visible = False
        GrpBox_EventDetails.Visible = True

    End Sub

    Private Sub Btn_AirsoftPackageDetailsBack_Click(sender As Object, e As EventArgs) Handles Btn_AirsoftPackageDetailsBack.Click

        GrpBox_AirsoftPackageDetails.Visible = False
        GrpBox_EventDetails.Visible = True

    End Sub

    Private Sub Btn_DateNext_Click(sender As Object, e As EventArgs) Handles Btn_DateNext.Click

        EventDate = DateTimePicker1.Value

        GrpBox_DateSelection.Visible = False
        GrpBox_CustomerDetails.Visible = True

        Me.Width = GrpBox_CustomerDetails.Width + 20

    End Sub

    Private Sub Btn_PaintballWalkOnPackageDetailsBack_Click(sender As Object, e As EventArgs) Handles Btn_PaintballWalkOnPackageDetailsBack.Click

        GrpBox_68WalkOnPackageDetails.Visible = False
        GrpBox_EventDetails.Visible = True

    End Sub

    Private Sub RdoBtn_68WalkOn_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_68WalkOn.CheckedChanged
        CheckActiveTimingGroup()
    End Sub

    Private Sub GrpBox_CustomerDetails_Enter(sender As Object, e As EventArgs) Handles GrpBox_CustomerDetails.Enter

    End Sub

    Private Sub Btn_68PackageDetailsNext_Click(sender As Object, e As EventArgs) Handles Btn_68PackageDetailsNext.Click

        Dim Count As Integer = BronzeCounter68.Value + SilverCounter68.Value + GoldCounter68.Value + PlatinumCounter68.Value

        PaintballBronze = BronzeCounter68.Value
        PaintballSilver = SilverCounter68.Value
        PaintballGold = GoldCounter68.Value
        PaintballPlatinum = PlatinumCounter68.Value

        If Count <> GroupSize Then
            MsgBox("Number of Participants does not equal group size")
        Else
            ConfirmBooking()
        End If

    End Sub

    Private Sub Btn_CustomerNext_Click(sender As Object, e As EventArgs) Handles Btn_CustomerNext.Click

        OrganiserName = TxtBox_CustomerName.Text
        GroupSize = GroupSizeCounter.Value

        If RdoBtn_Age_Adults.Checked = True Then
            GroupAge = "Adults"
        ElseIf RdoBtn_Age_AdultsJuniors.Checked = True Then
            GroupAge = "Adults & Juniors"
        ElseIf RdoBtn_Age_Juniors.Checked = True Then
            GroupAge = "Juniors"
        ElseIf RdoBtn_Age_NA.Checked = True Then
            GroupAge = "NA"
        End If

        GrpBox_CustomerDetails.Visible = False
        GrpBox_EventDetails.Visible = True

        Me.Width = GrpBox_EventDetails.Width + 15

    End Sub

    Private Sub Btn_DetailsBack_Click(sender As Object, e As EventArgs) Handles Btn_DetailsBack.Click

        GrpBox_DateSelection.Visible = True
        GrpBox_CustomerDetails.Visible = False

        Me.Width = GrpBox_DateSelection.Width + 20

    End Sub

    Private Sub Btn_EventNext_Click(sender As Object, e As EventArgs) Handles Btn_EventNext.Click

        If RdoBtn_68.Checked = True Then
            EventType = "68 Cal"
        ElseIf RdoBtn_68WalkOn.Checked = True Then
            EventType = "WalkOn 68"
        ElseIf RdoBtn_50.Checked = True Then
            EventType = "50 Cal"
        ElseIf RdoBtn_Airsoft.Checked = True Then
            EventType = "Airsoft"
        ElseIf RdoBtn_Laser.Checked = True Then
            EventType = "Laser"
        ElseIf RdoBtn_Nerf.Checked = True Then
            EventType = "Nerf"
        ElseIf RdoBtn_Other.Checked = True Then
            EventType = TxtBox_EventOther.Text
        End If

        If EventType = "68 Cal" Or EventType = "WalkOn 68" Or EventType = "Airsoft" Or RdoBtn_Other.Checked = True Then
            If RdoBtn_TimesPaintball_FullDay.Checked = True Then
                TimeSlot = "Full Day"
            ElseIf RdoBtn_TimesPaintball_Morning.Checked = True Then
                TimeSlot = "Morning"
            ElseIf RdoBtn_TimesOther_Afternoon.Checked = True Then
                TimeSlot = "Afternoon"
            End If

        ElseIf EventType = "50 Cal" Or EventType = "Laser" Or EventType = "Nerf" Then
            If RdoBtn_TimesOther_Morning.Checked = True Then
                TimeSlot = "Morning"
            ElseIf RdoBtn_TimesOther_Afternoon.Checked = True Then
                TimeSlot = "Afternoon"
            End If
        End If

        GrpBox_EventDetails.Visible = False

        If RdoBtn_68.Checked = True Then
            GrpBox_68PackageDetails.Visible = True
        ElseIf RdoBtn_Airsoft.Checked = True Then
            GrpBox_AirsoftPackageDetails.Visible = True
        ElseIf RdoBtn_68WalkOn.Checked = True Then
            GrpBox_68WalkOnPackageDetails.Visible = True
        Else
            ConfirmBooking()
        End If

        Me.Width = GrpBox_CustomerDetails.Width + 15

    End Sub

    Private Sub Btn_EventBack_Click(sender As Object, e As EventArgs) Handles Btn_EventBack.Click

        GrpBox_EventDetails.Visible = False
        GrpBox_CustomerDetails.Visible = True

        Me.Width = GrpBox_CustomerDetails.Width + 15

    End Sub

    Private Sub Timer_MakeBooking_Tick(sender As Object, e As EventArgs) Handles Timer_MakeBooking.Tick

        If TxtBox_CustomerName.Text = "" Then
            Btn_CustomerNext.Enabled = False
        ElseIf RdoBtn_Age_Adults.Checked = False And RdoBtn_Age_AdultsJuniors.Checked = False And RdoBtn_Age_Juniors.Checked = False And RdoBtn_Age_NA.Checked = False Then
            Btn_CustomerNext.Enabled = False
        ElseIf GroupSizeCounter.Value = 0 Then
            Btn_CustomerNext.Enabled = False
        Else
            Btn_CustomerNext.Enabled = True
        End If

        If RdoBtn_68.Checked = False And RdoBtn_68WalkOn.Checked = False And RdoBtn_50.Checked = False And RdoBtn_Airsoft.Checked = False And RdoBtn_Laser.Checked = False And RdoBtn_Nerf.Checked = False And RdoBtn_Other.Checked = False Then
            Btn_EventNext.Enabled = False
        ElseIf RdoBtn_Other.Checked = True And TxtBox_EventOther.Text = "Please Specify Here" Then
            Btn_EventNext.Enabled = False
        ElseIf RdoBtn_Other.Checked = True And TxtBox_EventOther.Text = "" Then
            Btn_EventNext.Enabled = False
        ElseIf RdoBtn_68.Checked = True Or RdoBtn_Airsoft.Checked = True Or RdoBtn_Other.Checked = True Then
            If RdoBtn_TimesPaintball_FullDay.Checked = False And RdoBtn_TimesPaintball_Morning.Checked = False And RdoBtn_TimesPaintball_Afternoon.Checked = False Then
                Btn_EventNext.Enabled = False
            Else
                Btn_EventNext.Enabled = True
            End If
        ElseIf RdoBtn_Laser.Checked = True Or RdoBtn_50.Checked = True Or RdoBtn_Nerf.Checked = True Or RdoBtn_Other.Checked = True Then
            If RdoBtn_TimesOther_Morning.Checked = False And RdoBtn_TimesOther_Afternoon.Checked = False Then
                Btn_EventNext.Enabled = False
            Else
                Btn_EventNext.Enabled = True
            End If
        Else
            Btn_EventNext.Enabled = True
        End If
    End Sub

    Sub ConfirmBooking()

        If MsgBox("This is the current booking preferences, are you sure?" & vbNewLine _
                  & " " & vbNewLine _
                  & "Date: " & EventDate & vbNewLine _
                  & " " & vbNewLine _
                  & "Organiser Name: " & OrganiserName & vbNewLine _
                  & "Group Size: " & GroupSize & vbNewLine _
                  & "Group Age: " & GroupAge & vbNewLine _
                  & " " & vbNewLine _
                  & "Event Type: " & EventType & vbNewLine _
                  & "Time Slot: " & TimeSlot _
                  , MsgBoxStyle.YesNo, Title:="Confirm Booking") = vbYes Then
            Me.Close()

            SaveChanges()
            MsgBox("Booking Saved")

            Frm_MainMenu.Show()
        End If

    End Sub

    Sub SaveChanges() 'Adapt to work with Database when it has been designed and is functional.

        'Dim TextReader As String = My.Computer.FileSystem.ReadAllText("File.txt")
        'Dim TextWriter As New System.IO.StreamWriter("File.txt")

        'TextWriter.Write(TextReader)
        'TextWriter.WriteLine("Yeet")
        'TextWriter.Close()

        Dim TempDate As String = EventDate
        Mid(TempDate, 3, 1) = "-"
        Mid(TempDate, 6, 1) = "-"
        Dim FileName As String = TempDate + ".txt"

        Dim TextReader As String
        Dim FileExists As Boolean = False

        Dim BookingNumber As Integer = 0

        Try
            TextReader = My.Computer.FileSystem.ReadAllText(FileName)
            FileExists = True
        Catch
            FileExists = False
        End Try

        Dim TextWriter As New System.IO.StreamWriter(FileName)

        If FileExists = True Then
            TextWriter.Write(TextReader)
        End If

        TextWriter.WriteLine("START")
        TextWriter.WriteLine("--------------------") 'Signifies start of booking

        TextWriter.WriteLine(EventType)
        TextWriter.WriteLine(TimeSlot)
        TextWriter.WriteLine(OrganiserName) 'Saving booking information
        TextWriter.WriteLine(GroupSize)
        TextWriter.WriteLine(GroupAge)

        If EventType = "68 Cal" Then 'Saving Packages for Paintball
            TextWriter.WriteLine(PaintballBronze)
            TextWriter.WriteLine(PaintballSilver)
            TextWriter.WriteLine(PaintballGold)
            TextWriter.WriteLine(PaintballPlatinum)
        ElseIf EventType = "Airsoft" Then 'Saving Packages for Airsoft
            TextWriter.WriteLine(AirsoftRental)
            TextWriter.WriteLine(AirsoftOwnGear)
        ElseIf EventType = "WalkOn 68" Then 'Saving Packages for WalkOn Paintball
            TextWriter.WriteLine(PaintballWalkOnRental)
            TextWriter.WriteLine(PaintballWalkOnOwnGear)
        End If

        TextWriter.WriteLine("--------------------") 'Signifies end of booking
        TextWriter.WriteLine("END")
        TextWriter.WriteLine("")

        TextWriter.Close()

    End Sub

End Class