Module Module1

    Sub Main()

        'Dim = Dimension, must use decimal to return exact decimal
        Dim x As Integer = 24
        Dim y As Integer = x + 14
        Dim a As Integer = 0
        Dim sampleString As String = "George"
        'Can be "lazy" declaring variables, but should follow above to write clear code
        Dim q = 12 + y
        Dim newString = ""
        '& converts int to a string implicitly in this example, but should use .ToString() method to write better code
        'Dim combineStringAndInt = q & sampleString
        Dim combineStringAndInt = q.ToString() & sampleString.ToLower()

        Console.WriteLine("What is your name?")
        newString = Console.ReadLine()
        'If you want to display string saying and int, must convert the variable to str before
        Console.WriteLine("What number would you like to add to " + CStr(x) + "?")
        a = CInt(Console.ReadLine())

        Dim add As Integer = x + a
        Console.WriteLine("Hello " + newString + "! You're answer is: " + CStr(add))

        Console.ReadLine()

    End Sub

End Module
