Imports System.Console

Module Program
    Sub Main()
        Dim num1, num2 As Integer
        Write("Enter Your First Number: ")
        num1 = ReadLine()
        Write("Entrer Your Second Number: ")
        num2 = ReadLine()
        If num1 > num2 Then
            WriteLine("First Number " & num1 & " is greater than Second Number " & num2)
        Else
            WriteLine("Second Number " & num2 & " is greater than First Number " & num1)
        End If
        ReadKey()
    End Sub
End Module