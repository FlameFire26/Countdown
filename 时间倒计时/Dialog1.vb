Public Class Dialog1
    Public DateSelected As Date
    Public DateString As String

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DateSelected = MonthCalendar1.SelectionStart & " " & ComboBox1.SelectedItem & ":" & ComboBox2.SelectedItem & ":" & ComboBox3.SelectedItem
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, Form1.Height)
        If ComboBox1.Items.Count = 0 Then
            For i = 0 To 23
                ComboBox1.Items.Add(i)
            Next
            For i = 0 To 59
                ComboBox2.Items.Add(i)
                ComboBox3.Items.Add(i)
            Next
        End If
        MonthCalendar1.SetDate(My.Settings.Goal)
        ComboBox1.SelectedIndex = My.Settings.Goal.Hour
        ComboBox2.SelectedIndex = My.Settings.Goal.Minute
        ComboBox3.SelectedIndex = My.Settings.Goal.Second
    End Sub
End Class
