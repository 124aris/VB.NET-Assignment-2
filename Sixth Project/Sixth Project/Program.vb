Imports System.Console

Module Program
    Sub Main()
        Dim num As Integer
        Write("Enter a Number Between 1 and 12 Inclusive: ")
        num = ReadLine()
        If num = 1 Then
            WriteLine("January")
        ElseIf num = 2 Then
            WriteLine("February")
        ElseIf num = 3 Then
            WriteLine("March")
        ElseIf num = 4 Then
            WriteLine("April")
        ElseIf num = 5 Then
            WriteLine("May")
        ElseIf num = 6 Then
            WriteLine("June")
        ElseIf num = 7 Then
            WriteLine("July")
        ElseIf num = 8 Then
            WriteLine("August")
        ElseIf num = 9 Then
            WriteLine("September")
        ElseIf num = 10 Then
            WriteLine("October")
        ElseIf num = 11 Then
            WriteLine("November")
        Else
            WriteLine("December")
        End If
        ReadKey()
    End Sub
End Module
