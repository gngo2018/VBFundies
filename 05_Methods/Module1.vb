Module Module1

    Sub Main()
        displayTheMessage()
        Dim name As String
        Dim newNumber As Long
        Dim phone = String.Format("{0:(###)###-####}", 7654016253)

        Console.WriteLine(phone)


        Console.WriteLine("What is your name?")
        name = Console.ReadLine()

        Console.WriteLine(superSecretFormula(name))

        Console.WriteLine("What is your phone number?")
        newNumber = CLng(Console.ReadLine())

        Console.WriteLine(phoneNumber(newNumber))



        Console.ReadLine()

    End Sub

    Sub displayTheMessage()
        Console.WriteLine("From displayTheMessage")
    End Sub

    Function superSecretFormula() As String
        Return "Hello World!"
    End Function

    'Method overloading
    Function superSecretFormula(ByVal name As String) As String
        Return String.Format("Hello {0}!", name)
    End Function

    Function phoneNumber(ByVal number As Long) As String
        Return String.Format("{0:(###) ###-####}", number)
    End Function

End Module
