Imports System.Console

Module Program
    Sub Main()
        Dim hours, extrahours, rate, pay As Double
        Write("Enter the Number of Hours You Worked this Week: ")
        hours = ReadLine()
        Write("Enter Your Hourly Rate of Pay: ")
        rate = ReadLine()
        If hours < 0 And hours > 60 Then
            WriteLine("Error. Your Number of Hours Worked in a Week are out of Range from 0 to 60")
        ElseIf hours <= 40 Then
            pay = hours * rate
        ElseIf hours > 40 Then
            extrahours = hours - 40
            pay = (40 * rate) + (extrahours * 1.5 * rate)
        End If
        WriteLine("Your Gross Pay for " & hours & " hours is " & pay)
        ReadKey()
    End Sub
End Module