Imports System.Console

Module Program
    Sub Main()
        Dim age As Integer
        Write("Enter Your Age Please: ")
        age = ReadLine()
        If age >= 18 Then
            WriteLine("You are old enough to drive")
        Else
            WriteLine("You are not old enough to drive")
        End If
        ReadKey()
    End Sub
End Module