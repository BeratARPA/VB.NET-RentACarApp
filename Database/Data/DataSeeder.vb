Public Class DataSeeder
    Public Shared Sub Seed()
        Dim _context As New SQLContext()

        Dim _genericRepositoryUser As New GenericRepository(Of User)(_context)

        Dim userExist = _genericRepositoryUser.GetT(Function(x) x.Name = "Manager")
        If userExist Is Nothing Then
            Dim user As New User With {
                .Name = "Manager",
                .Password = "1"
            }

            _genericRepositoryUser.AddT(user)
        End If
    End Sub
End Class
