Public Class ProgramUI

    Dim _menuRepository As New MenuRepository()
    Public Sub RunProgram()
        Dim isRunning As Boolean = True

        While isRunning = True

            Console.Clear()
            Console.WriteLine("Please choose an action: " & vbCrLf &      '<----- vbCrLf = \n
                              "1. Add Menu Item" & vbCrLf &
                              "2. Delete Menu Item" & vbCrLf &
                              "3. See Menu List" & vbCrLf &
                              "4. Exit")
            Dim input = CInt(Console.ReadLine())
            Select Case input
                Case 1
                    CreateMenuItem()
                Case 2
                    DeleteMenuItem()
                Case 3
                    GetMenuItems()
                    Console.WriteLine("Press any key to return to the menu!")
                    Console.ReadKey()
                Case 4
                    isRunning = False
                Case Else
                    Console.WriteLine("Sorry, invalid option")
                    Console.ReadKey()
            End Select


        End While

    End Sub

    Private Sub CreateMenuItem()
        Dim newMenuItem As New Menu()
        Console.WriteLine("What price would you want the item to be? (No $ needed)")
        newMenuItem.ItemPrice = CDec(Console.ReadLine)
        Console.WriteLine("What would you like to call the menu item?")
        newMenuItem.ItemTitle = Console.ReadLine()
        Console.WriteLine("What Description would you like to give the menu item?")
        newMenuItem.ItemDescription = Console.ReadLine()
        newMenuItem.IngredientList = AddIngredient()

        _menuRepository.AddMenuItemToList(newMenuItem)

    End Sub
    Private Function AddIngredient() As List(Of String)
        Dim ingredientsList As New List(Of String)
        Console.WriteLine("Would you like to add ingredients to the new menu item? (y/n)")
        Dim answer = Console.ReadLine().ToLower

        While answer.Contains("y")
            Console.WriteLine("What ingredient would you like to add?")
            Dim ingredient As String = Console.ReadLine()
            ingredientsList.Add(ingredient)

            Console.WriteLine("Would you like to include more ingredients? (y/n)")
            answer = Console.ReadLine().ToLower
        End While


        Return ingredientsList
    End Function
    Private Function GetIngredients(ingredients As List(Of String))
        Dim printedIngredients As String = ""
        For Each ingredient As String In ingredients
            printedIngredients = ingredient + ", " + printedIngredients
        Next

        Return printedIngredients
    End Function
    Private Sub DeleteMenuItem()
        GetMenuItems()
        Console.WriteLine("Please choose the listed item number to remove.")
        Dim answer = CInt(Console.ReadLine())
        _menuRepository.GetMenuList().RemoveAt(answer - 1)

    End Sub
    Private Sub GetMenuItems()
        Console.WriteLine("The current list of menu items registered are: ")
        Dim i As Integer = 0

        For Each item As Menu In _menuRepository.GetMenuList()
            i = i + 1

            'vbTab = \t in c#
            Console.WriteLine(i & "." & vbTab &
                              "Menu Item Name: " & item.ItemTitle & vbCrLf &
                              vbTab & "Menu Item Description: " & item.ItemDescription & vbCrLf &
                              vbTab & "Ingredient List: " & GetIngredients(item.IngredientList))

            Console.WriteLine(vbTab & "Menu Item Price: {0:C}", item.ItemPrice)

            Console.WriteLine("")
        Next
    End Sub

End Class
