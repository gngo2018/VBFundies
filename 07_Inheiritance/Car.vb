Public Class Car
    Inherits Vehicle

    'public virtual function, like abstraction
    Public Overrides Function Format() As String
        Return String.Format("{0} - {1} - {2} - {3}",
                             Me.Make,
                             Me.Model,
                             Me.Year,
                             Me.Color)
    End Function

End Class
