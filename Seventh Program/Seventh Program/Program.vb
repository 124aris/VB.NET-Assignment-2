Imports System.Console

Module Program
    Sub Main()
        Dim temperature As Integer
        Write("Enter the Temperature of Water in Centigrade: ")
        temperature = ReadLine()
        If temperature <= 0 Then
            WriteLine("The Water is Frozen")
        ElseIf temperature >= 100 Then
            WriteLine("The Water is Boiling")
        Else
            WriteLine("The Water is Neither Freezing nor Boiling")
        End If
        ReadKey()
    End Sub
End Module