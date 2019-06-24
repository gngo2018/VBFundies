Module Module1

    Sub Main()
        'Way I would approach without looking up
        'For i = 1 To 100
        '    If i Mod 3 = 0 And i Mod 5 = 0 Then
        '        Console.WriteLine("FizzBuzz")
        '    ElseIf i Mod 3 = 0 Then
        '        Console.WriteLine("Fizz")
        '    ElseIf i Mod 5 = 0 Then
        '        Console.WriteLine("Buzz")
        '    Else
        '        Console.WriteLine(i)
        '    End If
        'Next

        '"Cleaner" way
        Dim output As String

        For i = 1 To 100
            If i Mod 3 = 0 And i Mod 5 = 0 Then
                output = "FizzBuzz"
            ElseIf i Mod 3 = 0 Then
                output = "Fizz"
            ElseIf i Mod 5 = 0 Then
                output = "Buzz"
            Else
                output = i
            End If
            Console.WriteLine(output)
        Next

        Console.ReadLine()

    End Sub

End Module
