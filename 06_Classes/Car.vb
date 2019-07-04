Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String

    Public Function DetermineMarketValue() As Decimal

        Dim carValue As Decimal

        'Me relates to the properties above. Kind of like this.property with JS
        If Me.Year >= 1990 Then
            carValue = 10000.0

        Else
            carValue = 100.0
        End If

        Return carValue
    End Function
    'Ctor
    Public Sub New(ByVal _make As String,
                   ByVal _model As String,
                   ByVal _year As Integer,
                   ByVal _color As String)

        Me.Make = _make
        Me.Model = _model
        Me.Year = _year
        Me.Color = _color

    End Sub

    Public Sub New()

    End Sub

End Class
