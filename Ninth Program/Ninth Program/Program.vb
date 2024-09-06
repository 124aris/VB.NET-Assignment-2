Imports System.ComponentModel
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
        If int2 = 1 Then
            month = "January"
        ElseIf int2 = 2 Then
            month = "February"
        ElseIf int2 = 3 Then
            month = "March"
        ElseIf int2 = 4 Then
            month = "April"
        ElseIf int2 = 5 Then
            month = "May"
        ElseIf int2 = 6 Then
            month = "June"
        ElseIf int2 = 7 Then
            month = "July"
        ElseIf int2 = 8 Then
            month = "August"
        ElseIf int2 = 9 Then
            month = "September"
        ElseIf int2 = 10 Then
            month = "October"
        ElseIf int2 = 11 Then
            month = "November"
        Else
            month = "December"
        End If
        If int3 >= 31 And int3 <= 99 Then
            year = "19" & int3
        ElseIf int3 >= 0 And int3 <= 9 Then
            year = "200" & int3
        Else
            year = "20" & int3
        End If
        finaldate = day & " " & month & " " & year
        WriteLine("Date: " & finaldate)
        ReadKey()
    End Sub
End Module