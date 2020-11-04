Public Class MonthlyDues
    'delcaring the varibales i need 
    Private _BacFee As Integer
    Private _AddFee As Integer
    Private _MonFee As Integer

    'getting  the values i need for variblaes
    Public Property BacFee As Integer
        Get
            Return _BacFee
        End Get
        Set(value As Integer)
            _BacFee = value
        End Set
    End Property

    Public Property AddFee As Integer
        Get
            Return _AddFee
        End Get
        Set(value As Integer)
            _AddFee = value
        End Set
    End Property

    Public ReadOnly Property MonFee As Integer
        Get
            Return _MonFee
        End Get
    End Property


    'setting the values to 0 
    Public Sub New()
        _BacFee = 0
        _AddFee = 0
        _MonFee = 0
    End Sub

    'doing cal to get monthly total due 
    Public Sub MontlyFee()
        _MonFee = _BacFee + _AddFee
    End Sub

End Class
