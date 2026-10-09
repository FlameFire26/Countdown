Public Class Form1
    Public TimeFormat = My.Settings.Format
    Public TimeGoal = My.Settings.Goal
    Public TimeFormatCh = FX.ToCh(TimeFormat)
    Public TimeFormatEn = " " & FX.ToEn(TimeFormat)
    Public TimeShow = My.Settings.Goal.Year & "-" & My.Settings.Goal.Month & "-" & My.Settings.Goal.Day & " " & My.Settings.Goal.Hour & ":" & My.Settings.Goal.Minute & ":" & My.Settings.Goal.Second
    Public Transparent() As Double = {1, 0.8, 0.6, 0.4, 0.2}
    Public GoalCount As Long = DateDiff(TimeFormat, Now, TimeGoal) + 1

    Public Sub AppUpdate()
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        'Label1.Text = "Left days of:"
        Label2.Text = GoalCount & TimeFormatEn
        TableLayoutPanel1.Height = Label1.Height + TableLayoutPanel2.Height + 20
        Height = TableLayoutPanel1.Height
        Width = TableLayoutPanel2.Width + 12
    End Sub

    Public Sub Set时间显示格式()
        For Each i As ToolStripMenuItem In TSMI时间显示格式.DropDownItems
            If i.Name = My.Settings.Format Then
                i.Checked = True
            Else
                i.Checked = False
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, 0)
        ContextMenuStrip = ContextMenuStrip1
        TSMI置顶.Checked = My.Settings.OnTop
        TSCB透明度.SelectedIndex = My.Settings.Transparent
        Opacity = Transparent(TSCB透明度.SelectedIndex)
        TopMost = My.Settings.OnTop
        Set时间显示格式()
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AppUpdate()
    End Sub

    Private Sub TSMI置顶_Click(sender As Object, e As EventArgs) Handles TSMI置顶.Click
        TSMI置顶.Checked = Not TSMI置顶.Checked
        TopMost = TSMI置顶.Checked
        My.Settings.OnTop = TSMI置顶.Checked
        My.Settings.Save()
    End Sub

    Private Sub TSMI设置目标时间_Click(sender As Object, e As EventArgs) Handles TSMI设置目标时间.Click
        If Dialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.Goal = Dialog1.DateSelected
            My.Settings.Save()
        End If
    End Sub

    Private Sub TSMI刷新_Click(sender As Object, e As EventArgs) Handles TSMI刷新.Click
        TimeFormat = My.Settings.Format
        TimeGoal = My.Settings.Goal
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub TSCB透明度_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TSCB透明度.SelectedIndexChanged
        Opacity = Transparent(TSCB透明度.SelectedIndex)
        My.Settings.Transparent = TSCB透明度.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub TSMI关闭_Click(sender As Object, e As EventArgs) Handles TSMI关闭.Click
        End
    End Sub

    Private Sub y_Click(sender As Object, e As EventArgs) Handles y.Click
        My.Settings.Format = "y"
        My.Settings.Save()
        Set时间显示格式()
        TimeFormat = My.Settings.Format
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub m_Click(sender As Object, e As EventArgs) Handles m.Click
        My.Settings.Format = "m"
        My.Settings.Save()
        Set时间显示格式()
        TimeFormat = My.Settings.Format
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub d_Click(sender As Object, e As EventArgs) Handles d.Click
        My.Settings.Format = "d"
        My.Settings.Save()
        Set时间显示格式()
        TimeFormat = My.Settings.Format
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub h_Click(sender As Object, e As EventArgs) Handles h.Click
        My.Settings.Format = "h"
        My.Settings.Save()
        Set时间显示格式()
        TimeFormat = My.Settings.Format
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub n_Click(sender As Object, e As EventArgs) Handles n.Click, n.Click
        My.Settings.Format = "n"
        My.Settings.Save()
        Set时间显示格式()
        TimeFormat = My.Settings.Format
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub

    Private Sub s_Click(sender As Object, e As EventArgs) Handles s.Click
        My.Settings.Format = "s"
        My.Settings.Save()
        Set时间显示格式()
        TimeFormat = My.Settings.Format
        TimeFormatCh = FX.ToCh(TimeFormat)
        TimeFormatEn = " " & FX.ToEn(TimeFormat)
        GoalCount = DateDiff(TimeFormat, Now, TimeGoal) + 1
        If GoalCount > 1 Then TimeFormatEn &= "s"
        AppUpdate()
    End Sub
End Class
