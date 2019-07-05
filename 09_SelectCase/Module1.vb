Module Module1

    Sub Main()

        Console.WriteLine("Type in a super hero's name to see his nickname!")

        Dim userValue As String = Console.ReadLine
        Dim hero As Superhero

        If Superhero.TryParse(userValue, True, hero) Then

            'Switch Case in C#
            Select Case hero
                Case Superhero.Batman
                    Console.WriteLine("Scrub")
                Case Superhero.Ironman
                    Console.WriteLine("Stud")
                Case Superhero.Thor
                    Console.WriteLine("Kind of Stud")
            End Select
        Else
            Console.WriteLine("Oooopsss")
        End If
        Console.ReadLine()
    End Sub

End Module
