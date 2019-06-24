Module Module1
    Sub Main()
        Dim userValue As Integer
        Dim message As String

        Console.WriteLine("Would you prefer what is behind door number 1 2 or 3?")
        userValue = CInt(Console.ReadLine())

        If userValue = 1 Then
            message = "You won a new car!"
        ElseIf userValue = 2 Then
            message = "You won a New boat"
        ElseIf userValue = 3 Or userValue = 4 Then
            message = "You won a new cat"
        Else
            message = "Sorry, we did not understand"
        End If

        Console.WriteLine(message)
        Console.ReadLine()

    End Sub

End Module
