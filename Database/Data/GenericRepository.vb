Imports System.Data.Entity
Imports System.Linq.Expressions
Public Class GenericRepository(Of T As {Class, New})
    Implements IGenericRepository(Of T)

    Private _context As SQLContext

    Public Sub New(context As SQLContext)
        _context = context
    End Sub

    Public Function AddT(entity As T) As T Implements IGenericRepository(Of T).AddT
        _context.Entry(entity).State = EntityState.Added
        _context.SaveChanges()

        Return entity
    End Function

    Public Sub UpdateT(entity As T) Implements IGenericRepository(Of T).UpdateT
        _context.Entry(entity).State = EntityState.Modified
        _context.SaveChanges()

    End Sub

    Public Sub DeleteT(entity As T) Implements IGenericRepository(Of T).DeleteT
        _context.Entry(entity).State = EntityState.Deleted
        _context.SaveChanges()
    End Sub

    Public Function GetT(filter As Expression(Of Func(Of T, Boolean))) As T Implements IGenericRepository(Of T).GetT
        Dim entity = _context.Set(Of T)().Where(filter).FirstOrDefault()

        Return entity
    End Function

    Public Function GetTAll(filter As Expression(Of Func(Of T, Boolean))) As List(Of T) Implements IGenericRepository(Of T).GetTAll
        Dim entities = If(filter Is Nothing, _context.Set(Of T)().AsNoTracking().ToList(), _context.Set(Of T)().Where(filter).ToList())

        Return entities
    End Function
End Class