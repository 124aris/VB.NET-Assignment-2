Imports System.Console

Module Program
    Sub Main()
        Dim grade As Integer
        WriteLine("Enter a Grade")
        grade = ReadLine()
        If grade > 100 Then
            WriteLine("Error. Your Grade is Greater than 100 which is out of Bounds.")
        ElseIf grade > 80 Then
            WriteLine("Grade A")
        ElseIf grade > 60 Then
            WriteLine("Grade B")
        ElseIf grade > 50 Then
            WriteLine("Grade C")
        ElseIf grade > 0 Then
            WriteLine("Grade U")
        Else
            WriteLine("Error. Your Grade is Smaller than 0 which is out of Bounds.")
        End If
        ReadKey()
    End Sub
End Module
