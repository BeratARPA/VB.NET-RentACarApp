Imports Database

Public Class CustomerManagerForm
    Dim _genericRepositoryCustomer As New GenericRepository(Of Customer)(GlobalVariables.SQLContext)

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If String.IsNullOrEmpty(TextBoxName.Text) OrElse String.IsNullOrEmpty(TextBoxPhoneNumber.Text) Then
            MessageBox.Show("Gerekli Bilgileri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update
        If DataGridViewCustomers.SelectedRows.Count > 0 Then
            Dim Id As Integer = Convert.ToInt32(DataGridViewCustomers.CurrentRow.Cells(0).Value)
            Dim customer = _genericRepositoryCustomer.GetT(Function(x) x.Id = Id)

            If customer IsNot Nothing Then
                customer.Name = TextBoxName.Text
                customer.PhoneNumber = TextBoxPhoneNumber.Text

                _genericRepositoryCustomer.UpdateT(customer)
            End If

            AddCustomerDataGridView()
            Clear()
            Return
        End If

        ' Save
        Dim newCustomer As New Customer With {
            .Name = TextBoxName.Text,
            .PhoneNumber = TextBoxPhoneNumber.Text
        }

        _genericRepositoryCustomer.AddT(newCustomer)

        AddCustomerDataGridView()
        Clear()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridViewCustomers.SelectedRows.Count <= 0 Then
            MessageBox.Show("Müşteri Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Id As Integer = Convert.ToInt32(DataGridViewCustomers.CurrentRow.Cells(0).Value)
        Dim customer = _genericRepositoryCustomer.GetT(Function(x) x.Id = Id)
        If customer IsNot Nothing Then
            _genericRepositoryCustomer.DeleteT(customer)

            AddCustomerDataGridView()
        End If
    End Sub

    Private Sub CustomerManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddCustomerDataGridView()
    End Sub

    Private Sub Clear()
        TextBoxName.Clear()
        TextBoxPhoneNumber.Clear()
    End Sub

    Private Sub AddCustomerDataGridView()
        DataGridViewCustomers.Rows.Clear()

        Dim customers As List(Of Customer) = _genericRepositoryCustomer.GetTAll(Function(x) True)
        For Each customer In customers
            DataGridViewCustomers.Rows.Add(customer.Id, customer.Name, customer.PhoneNumber)
        Next

        DataGridViewCustomers.ClearSelection()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        NavigationManager.OpenForm(New DashboardForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub DataGridViewCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomers.CellClick
        TextBoxName.Text = DataGridViewCustomers.CurrentRow.Cells(1).Value
        TextBoxPhoneNumber.Text = DataGridViewCustomers.CurrentRow.Cells(2).Value
    End Sub
End Class