Public MustInherit Class Vehicle
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String

    'public virtual method, must be overriden by classes that inherit from vehicle class
    Public MustOverride Function Format() As String

End Class
