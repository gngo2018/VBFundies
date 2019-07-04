Module Module1

    Sub Main()
        Dim numbers() As Integer = {4, 8, 15, 16, 23}

        'numbers(0) = 4
        'numbers(1) = 8
        'numbers(2) = 15
        'numbers(3) = 16
        'numbers(4) = 23

        Console.WriteLine("The third element of the array contains: " & numbers(2))

        Console.WriteLine("Iterating through the entire array:")

        For index = 0 To numbers.Length - 1
            Console.WriteLine(numbers(index))
        Next

        Dim names() As String = {"George", "Kyle", "Wendy"}

        For Each name In names
            Console.WriteLine(name)
        Next

        'Reversing string array
        Dim myText As String = "Sometimes you just gotta keep on keepin on"

        Dim charArray() As Char = myText.ToCharArray()

        Array.Reverse(charArray)

        For Each reverseChar In charArray
            Console.Write(reverseChar)
        Next

        Console.ReadLine()

    End Sub

End Module
