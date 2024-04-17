Imports Database

Public Class UserManagerForm
    Dim _genericRepositoryUser As New GenericRepository(Of User)(GlobalVariables.SQLContext)

    Private Sub UserManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddUserDataGridView()
    End Sub

    Private Sub DataGridViewUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsers.CellClick
        TextBoxName.Text = DataGridViewUsers.CurrentRow.Cells(1).Value
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        NavigationManager.OpenForm(New DashboardForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If String.IsNullOrEmpty(TextBoxName.Text) OrElse String.IsNullOrEmpty(TextBoxPassword.Text) Then
            MessageBox.Show("Gerekli Bilgileri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update
        If DataGridViewUsers.SelectedRows.Count > 0 Then
            Dim Id As Integer = Convert.ToInt32(DataGridViewUsers.CurrentRow.Cells(0).Value)
            Dim user = _genericRepositoryUser.GetT(Function(x) x.Id = Id)

            If user IsNot Nothing Then
                user.Name = TextBoxName.Text
                user.Password = TextBoxPassword.Text

                _genericRepositoryUser.UpdateT(user)
            End If

            AddUserDataGridView()
            Clear()
            Return
        End If

        ' Save
        Dim newUser As New User With {
            .Name = TextBoxName.Text,
            .Password = TextBoxPassword.Text
        }

        _genericRepositoryUser.AddT(newUser)

        AddUserDataGridView()
        Clear()
    End Sub

    Private Sub AddUserDataGridView()
        DataGridViewUsers.Rows.Clear()

        Dim users As List(Of User) = _genericRepositoryUser.GetTAll(Function(x) True)
        For Each user In users
            DataGridViewUsers.Rows.Add(user.Id, user.Name)
        Next

        DataGridViewUsers.ClearSelection()
    End Sub

    Private Sub Clear()
        TextBoxName.Clear()
        TextBoxPassword.Clear()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridViewUsers.SelectedRows.Count <= 0 Then
            MessageBox.Show("Kullanıcı Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Id As Integer = Convert.ToInt32(DataGridViewUsers.CurrentRow.Cells(0).Value)
        Dim user = _genericRepositoryUser.GetT(Function(x) x.Id = Id)
        If user IsNot Nothing Then
            _genericRepositoryUser.DeleteT(user)

            AddUserDataGridView()
        End If
    End Sub
End Class