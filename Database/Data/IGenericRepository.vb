Imports System.Linq.Expressions

Public Interface IGenericRepository(Of T As {Class, New})
    Function AddT(entity As T) As T
    Sub UpdateT(entity As T)
    Sub DeleteT(entity As T)
    Function GetT(filter As Expression(Of Func(Of T, Boolean))) As T
    Function GetTAll(filter As Expression(Of Func(Of T, Boolean))) As List(Of T)
End Interface