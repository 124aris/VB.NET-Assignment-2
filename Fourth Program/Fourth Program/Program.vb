Imports System.Console

Module Program
    Sub Main()
        Dim num As Integer
        Write("Enter Your Number: ")
        num = ReadLine()
        If num >= 21 And num <= 29 Then
            WriteLine("Your number " & num & " is between the range of 21 and 29 inclusive")
        ElseIf num < 21 Then
            WriteLine("Your number " & num & " is out of range and is lesser than 21 which is below the range")
        Else
            WriteLine("Your number " & num & " is out of range and is greater than 29 which is above the range")
        End If
        ReadKey()
    End Sub
End Module