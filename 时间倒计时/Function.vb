Public Class FX
    Public Shared Function ToCh(Item As String) As String
        Select Case Item
            Case "y"
                Return "年"
            Case "m"
                Return "月"
            Case "d"
                Return "天"
            Case "h"
                Return "小时"
            Case "n"
                Return "分钟"
            Case "s"
                Return "秒"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function ToEn(Item As String) As String
        Select Case Item
            Case "y"
                Return "Year"
            Case "m"
                Return "Month"
            Case "d"
                Return "Day"
            Case "h"
                Return "Hour"
            Case "n"
                Return "Minute"
            Case "s"
                Return "Second"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function ToLt(Item As String) As String
        Select Case Item
            Case "年"
                Return "y"
            Case "月"
                Return "m"
            Case "天"
                Return "d"
            Case "小时"
                Return "h"
            Case "分钟"
                Return "n"
            Case "秒"
                Return "s"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function ChangeTimer(Item As String)
        Select Case Item
            Case "年"
                Return "y"
            Case "月"
                Return "m"
            Case "天"
                Return "d"
            Case "小时"
                Return "h"
            Case "分钟"
                Return "n"
            Case "秒"
                Return "s"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function ReadLine(Path As String, Index As Integer) As String
        Dim str = Nothing
        For i = 1 To Index
            str = IO.File.ReadLines(Path)
        Next
        Return str
    End Function
End Class
