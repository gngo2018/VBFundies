Module Module1

    Sub Main()

        'Car newCar = new Car()
        Dim newCar As New Car()
        Console.WriteLine("What is the color of the car?")
        newCar.Color = Console.ReadLine()
        Console.WriteLine("What is the make of the car?")
        newCar.Make = Console.ReadLine()
        Console.WriteLine("What is the model of the car?")
        newCar.Model = Console.ReadLine()
        Console.WriteLine("What is the year of the car?")
        newCar.Year = CInt(Console.ReadLine())

        Console.WriteLine("Here are the specs of the car: " & "Color: " & newCar.Color & "Make: " & newCar.Make &
                          "Model: " & newCar.Model & "Year: " & newCar.Year)

        Console.WriteLine("Your car is worth: {0:C}", newCar.DetermineMarketValue())

        'Example for shared methods (static)
        CarLot.AddToInventory(newCar)

        Console.ReadLine()

    End Sub

End Module
