'Author: Jon Yen
'Assignment: HW 2
'Date: 3/23/2019
Option Strict On
Public Class EmployeeInformation
    Private m_FirstName As String
    Private m_LastName As String
    Private m_DepartmentNo As Integer
    Private m_Email As String
    Private m_Phone As String
    Private m_HireDate As DateTime
    Dim DepartmentList As New SortedList(Of Integer, String)

    'properties
    Public Property FirstName As String
        Get
            Return m_FirstName
        End Get
        Set(value As String)
            m_FirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return m_LastName
        End Get
        Set(value As String)
            m_LastName = value
        End Set
    End Property

    Public Property DepartmentNo As Integer
        Get
            Return m_DepartmentNo
        End Get
        Set(value As Integer)
            m_DepartmentNo = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return m_Email
        End Get
        Set(value As String)
            m_Email = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return m_Phone
        End Get
        Set(value As String)
            m_Phone = value
        End Set
    End Property

    Public Property HireDate As DateTime
        Get
            Return m_HireDate
        End Get
        Set(value As DateTime)
            m_HireDate = value
        End Set
    End Property

    'constructors
    Public Sub New()

    End Sub

    Public Sub New(p_FirstName As String, p_LastName As String, p_DepartmentNo As Integer, p_Email As String, p_Phone As String, p_HireDate As DateTime)
        Me.FirstName = p_FirstName
        Me.LastName = p_LastName
        Me.DepartmentNo = p_DepartmentNo
        Me.Email = p_Email
        Me.Phone = p_Phone
        Me.HireDate = p_HireDate
        DepartmentList.Add(12, "Sales")
        DepartmentList.Add(15, "Human Resources")
        DepartmentList.Add(23, "Marketing")
        DepartmentList.Add(27, "Research and Development")
        DepartmentList.Add(29, "Finance")
        DepartmentList.Add(34, "Legal")
        DepartmentList.Add(38, "Information Systems")
        DepartmentList.Add(47, "Customer Support")
    End Sub

    'methods
    Public Function DisplayAddress() As String
        Return FirstName.PadRight(25) & " " & LastName.PadRight(25) & " " & Email.PadRight(25)
    End Function

    Public Function EmployeeDepartment() As String
        'to short date will get rid of what time it took place. It will then only display the date.
        Return LastName & ", " & FirstName.PadRight(27) & "-- ".PadRight(15) & DepartmentList.Item(DepartmentNo).ToString
        'DatePaid.ToShortDateString.PadRight(10) & "".PadLeft(5) & Payee.PadRight(15) & Amount.ToString("c2").PadLeft(10) & "".PadLeft(8) &
        'DepartmentList.Item(PaymentMethod).ToString.PadRight(13)
    End Function

End Class
