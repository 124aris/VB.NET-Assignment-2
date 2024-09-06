Imports System.Console

Module Program
    Sub Main()
        Dim int1, int2, int3 As Integer
        Dim day, month, year, finaldate As String
        WriteLine("Write Three Seperate Integers for Date, Month and Year Respectively.")
        int1 = ReadLine()
        int2 = ReadLine()
        int3 = ReadLine()
        If int1 = 1 Or int1 = 21 Or int1 = 31 Then
            day = int1 & "st"
        ElseIf int1 = 2 Or int1 = 22 Then
            day = int1 & "nd"
        ElseIf int1 = 3 Or int1 = 23 Then
            day = int1 & "rd"
        Else
            day = int1 & "th"
        End If
        If int2 = 1 And int1 < 32 Then
            month = "January"
        ElseIf int2 = 2 And int1 < 29 Then
            month = "February"
        ElseIf int2 = 3 And int1 < 32 Then
            month = "March"
        ElseIf int2 = 4 And int1 < 31 Then
            month = "April"
        ElseIf int2 = 5 And int1 < 32 Then
            month = "May"
        ElseIf int2 = 6 And int1 < 31 Then
            month = "June"
        ElseIf int2 = 7 And int1 < 32 Then
            month = "July"
        ElseIf int2 = 8 And int1 < 32 Then
            month = "August"
        ElseIf int2 = 9 And int1 < 31 Then
            month = "September"
        ElseIf int2 = 10 And int1 < 32 Then
            month = "October"
        ElseIf int2 = 11 And int1 < 31 Then
            month = "November"
        ElseIf int2 = 12 And int1 < 32 Then
            month = "December"
        Else
            month = "Error"
        End If
        If int3 >= 31 And int3 <= 99 Then
            year = "19" & int3
        ElseIf int3 >= 0 And int3 <= 9 Then
            year = "200" & int3
        ElseIf int3 > 99 Then
            year = "Error"
        Else
            year = "20" & int3
        End If
        If month = "Error" Or year = "Error" Then
            WriteLine("Error. The Date You Entered is not Valid")
        Else
            finaldate = day & " " & month & " " & year
            WriteLine("Date: " & finaldate)
            ReadKey()
        End If
    End Sub
End Module
