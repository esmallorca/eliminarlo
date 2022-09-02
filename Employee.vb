Public Class Employee : Inherits Person



    Public _employeeId As Integer?
    Private _name, _secondName As String

    Public Property EmployeeId() As Integer?
        Get
            Return _employeeId
        End Get
        Set(ByVal value As Integer?)
            _employeeId = value
        End Set
    End Property
    Public Sub New(name As String, secondName As String, employeeId As Integer?)
        MyBase.New(name, secondName)
        _employeeId = employeeId
    End Sub

    Public Overrides Property SecondName As String
        Get
            Return _secondName
        End Get
        Set(value As String)
            _secondName = value
        End Set
    End Property

    Public Overrides Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property


    Public Overrides Sub Show()
        Console.WriteLine($"Name: {Name} - SecondName: {SecondName} - Employeeid: {EmployeeId}")
    End Sub
End Class
