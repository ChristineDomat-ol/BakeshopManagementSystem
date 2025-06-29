Public Class Product

    'Product Properties'

    Private Shared nextId As Integer = 1
    Public Property Id As Integer
    Public Property Name As String
    Public Property Category As String
    Public Property Price As Integer

    Public Sub New()
        Me.Id = nextId
        nextId += 1
    End Sub

    Public Class ProductOrder
        Public Property Username As String    'for ID matchy matchy sa orders  - megs    'name nalang ng user girl~  -tin    'oksi po madam -megs
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public Property Subtotal As Decimal
        Public Property Status As String = "Pending"   ' for status ng order   -megs

    End Class

End Class
