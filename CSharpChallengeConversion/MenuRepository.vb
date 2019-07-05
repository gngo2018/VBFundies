Public Class MenuRepository

    Dim _menuList As New List(Of Menu)

    Public Sub AddMenuItemToList(item As Menu)

        _menuList.Add(item)

    End Sub

    Public Function GetMenuList()

        Return _menuList

    End Function

End Class
