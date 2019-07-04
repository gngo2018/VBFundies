Public NotInheritable Class Truck
    Inherits Vehicle

    Public Property TowingCapacity As Integer

    Public Overrides Function Format() As String
        Return String.Format("{0} - {1} - {2}",
                             Me.Make,
                             Me.Model,
                             Me.TowingCapacity)
    End Function
End Class

'NotInheritable makes it that another class cannot inherit from a specific class
'May cause cascading issues if inheriting from a class that inherits from another (inheritception)
