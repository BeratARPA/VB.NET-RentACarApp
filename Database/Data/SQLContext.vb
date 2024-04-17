Imports System.Data.Entity

Public Class SQLContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("name=RentACarSQLServer")
    End Sub

    Public Property Cars As DbSet(Of Car)
    Public Property Customers As DbSet(Of Customer)
    Public Property Invoices As DbSet(Of Invoice)
    Public Property Users As DbSet(Of User)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
