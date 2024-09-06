Imports System.Console

Module Program
    Sub Main()
        Dim num1, num2, num3 As Integer
        Write("Enter Your First Number: ")
        num1 = ReadLine()
        Write("Enter Your Second Number: ")
        num2 = ReadLine()
        Write("Enter Your Third Number: ")
        num3 = ReadLine()
        If num1 > num2 And num1 > num3 Then
            WriteLine("First number " & num1 & " is largest of the three numbers others include " & num2 & " " & num3)
        ElseIf num2 > num1 And num2 > num3 Then
            WriteLine("Second number " & num2 & " is largest of the three numbers others include " & num1 & " " & num3)
        Else
            WriteLine("Third number " & num3 & " is largest of the three numbers others include " & num1 & " " & num2)
        End If
        ReadKey()
    End Sub
End Module
