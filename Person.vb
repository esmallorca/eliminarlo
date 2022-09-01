Imports Microsoft.VisualBasic

Public MustInherit Class Person
    Private _name As String
    Private _secondName As String
    Public MustOverride Property Name As String
    Public MustOverride Property SecondName As String

    Protected Sub New(name As String, secondName As String)
        _name = name
        _secondName = secondName
    End Sub

    Public Overridable Sub Show()
        Console.WriteLine($"Name: {_name} - SecondName: {_secondName}")
    End Sub

End Class
