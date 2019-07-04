Module Module1

    Sub Main()

        Dim myCar As New Car()
        myCar.Make = "BMW"
        myCar.Model = "Titan"
        myCar.Color = "Black"
        myCar.Year = 2005

        Dim myTruck As New Truck()
        With myTruck
            .Make = "Ford"
            .Model = "F150"
            .Year = 1995
            .Color = "red"
            .TowingCapacity = 45
        End With

        printVehicleDetails(myCar)
        printVehicleDetails(myTruck)

        Console.ReadLine()
    End Sub

    Sub printVehicleDetails(ByVal vehicle As Vehicle)
        Console.WriteLine("Here are the vehicle's details: {0}", vehicle.Format())
    End Sub

End Module
