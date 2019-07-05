Imports System.Collections.Specialized

Module Module1

    Sub Main()

        Dim car1 As New Car() With {
            .Make = "Ford",
            .Model = "F150"
        }
        Dim car2 As New Car() With {
            .Make = "Chevy",
            .Model = "Malibu"
        }

        Dim book1 As New Book() With {
            .Author = "George",
            .Title = "A Long Walk"
        }

        'Dim myArrayList As New ArrayList()

        'myArrayList.Add(car1)
        'myArrayList.Add(car2)
        'myArrayList.Add(book1)

        'For Each myCar As Car In myArrayList
        '    Console.WriteLine(myCar.Make)
        'Next

        'Uses System.Collections.Specialized
        'Dim dictionary As New ListDictionary()

        'dictionary.Add(car1.Make, car1)
        'dictionary.Add(car2.Make, car2)
        'dictionary.Add(book1.Author, book1)

        'Console.WriteLine(CType(dictionary("Geo"), Car).Model)
        'Console.WriteLine(CType(dictionary("George"), Book).Title)


        Dim carList As New List(Of Car) From {
            New Car With {.Make = "Aston Martin", .Model = "DB9"},
            New Car With {.Make = "Toyota", .Model = "Spyder"},
            New Car With {.Make = "Chevy", .Model = "Tahoe"},
            New Car With {.Make = "Chevy", .Model = "Corvette"}
        }

        carList.Add(car1)
        carList.Add(car2)

        'For Each car In carList
        '    Console.WriteLine(car.Model)
        'Next

        'Querying a list for a specific property/field using LINQ
        Dim chevyQuery = From car In carList
                         Where car.Make = "Chevy" 'And car.Model = "Corvette"  <--- Will make specific query for more accuracy
                         Select car

        Console.WriteLine("Here are a list of Chevy cars in the list: ")

        For Each chevy In chevyQuery
            Console.WriteLine("{0} {1}", chevy.Make, chevy.Model)
        Next

        'Using a dictionary and having user respond with what they want to look for
        Dim carDictionary As New Dictionary(Of String, Car)
        carDictionary.Add(car1.Make, car1)
        carDictionary.Add(car2.Make, car2)

        Console.WriteLine("Which car would you like to look up the model for?")
        Dim response As String = Console.ReadLine()

        'dictionaryVar.Key.what you want to see
        Console.WriteLine(carDictionary(response).Model)



        Console.ReadLine()

    End Sub

End Module
