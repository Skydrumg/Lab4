Option Strict On

Public Class Car
    Private Shared carCount As Integer
    Private carID As Integer = 0
    Private carModel As String = String.Empty
    Private carMake As String = String.Empty
    Private carYear As Integer
    Private carPrice As Integer
    Private carIfUsed As Boolean = False

    Public Sub New(Model As String, Make As String, Year As Integer, Price As Integer, IfUsed As Boolean)
        Me.New()

        carModel = Model
        carMake = Make
        carYear = Year
        carPrice = Price
        carIfUsed = IfUsed

    End Sub

    Public Sub New()
        carCount += 1
        carID = carCount
    End Sub

    Public Property IfUsed() As Boolean

        Get
            Return carIfUsed
        End Get
        Set(ByVal value As Boolean)
            carIfUsed = value
        End Set

    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public ReadOnly Property IdentifcationNumber() As Integer
        Get
            Return carID
        End Get
    End Property

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set

    End Property

    Public Property Price As Integer
        Get
            Return carPrice
        End Get
        Set(ByVal value As Integer)
            carPrice = value
        End Set
    End Property

    Public Function GetSaluation() As String

        Return "This car is " & carMake & " " & carModel & " " & carYear & " " & IIF(carIfUsed = True, "this is used", "this is new").ToString()
    End Function
End Class
