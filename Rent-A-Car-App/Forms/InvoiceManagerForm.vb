Imports Database

Public Class InvoiceManagerForm
    Dim _genericRepositoryInvoice As New GenericRepository(Of Invoice)(GlobalVariables.SQLContext)
    Dim _genericRepositoryCar As New GenericRepository(Of Car)(GlobalVariables.SQLContext)
    Dim _genericRepositoryCustomer As New GenericRepository(Of Customer)(GlobalVariables.SQLContext)

    Private Sub InvoiceManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddInvoiceDataGridView()
        AddCarComboBox()
        AddCustomerComboBox()
    End Sub

    Private Sub AddCarComboBox()
        ComboBoxCars.Items.Clear()

        Dim cars As List(Of Car) = _genericRepositoryCar.GetTAll(Function(x) True)
        ComboBoxCars.DataSource = cars
        ComboBoxCars.DisplayMember = "Plate"
        ComboBoxCars.ValueMember = "Id"
    End Sub

    Private Sub AddCustomerComboBox()
        ComboBoxCustomers.Items.Clear()

        Dim customers As List(Of Customer) = _genericRepositoryCustomer.GetTAll(Function(x) True)
        ComboBoxCustomers.DataSource = customers
        ComboBoxCustomers.DisplayMember = "Name"
        ComboBoxCustomers.ValueMember = "Id"
    End Sub

    Private Sub AddInvoiceDataGridView()
        DataGridViewInvoices.Rows.Clear()

        Dim carPlate = ""
        Dim customerName = ""

        Dim invoices As List(Of Invoice) = _genericRepositoryInvoice.GetTAll(Function(x) True)
        For Each invoice In invoices
            Dim car = _genericRepositoryCar.GetT(Function(x) x.Id = invoice.CarId)
            Dim customer = _genericRepositoryCustomer.GetT(Function(x) x.Id = invoice.CustomerId)

            If car IsNot Nothing Then
                carPlate = car.Plate
            Else
                carPlate = ""
            End If

            If customer IsNot Nothing Then
                customerName = customer.Name
            Else
                customerName = ""
            End If

            DataGridViewInvoices.Rows.Add(invoice.Id, invoice.CarId, carPlate, invoice.CustomerId, customerName, invoice.Amount, invoice.Status, invoice.CreateDate)
        Next

        DataGridViewInvoices.ClearSelection()
    End Sub

    Private Sub Clear()
        TextBoxAmount.Clear()
        ComboBoxCars.SelectedValue = -1
        ComboBoxCustomers.SelectedValue = -1
        ComboBoxStatus.SelectedValue = -1
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        NavigationManager.OpenForm(New DashboardForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If String.IsNullOrEmpty(ComboBoxCars.Text) OrElse String.IsNullOrEmpty(ComboBoxCustomers.Text) OrElse String.IsNullOrEmpty(TextBoxAmount.Text) OrElse String.IsNullOrEmpty(ComboBoxStatus.Text) Then
            MessageBox.Show("Gerekli Bilgileri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update
        If DataGridViewInvoices.SelectedRows.Count > 0 Then
            Dim Id As Integer = Convert.ToInt32(DataGridViewInvoices.CurrentRow.Cells(0).Value)
            Dim invoice = _genericRepositoryInvoice.GetT(Function(x) x.Id = Id)

            If invoice IsNot Nothing Then
                invoice.CarId = ComboBoxCars.SelectedValue
                invoice.CustomerId = ComboBoxCustomers.SelectedValue
                invoice.Amount = TextBoxAmount.Text
                invoice.Status = ComboBoxStatus.Text
                invoice.CreateDate = DateTimePickerCreateDate.Value

                _genericRepositoryInvoice.UpdateT(invoice)
            End If

            AddInvoiceDataGridView()
            Clear()
            Return
        End If

        ' Save
        Dim newInvoice As New Invoice With {
            .CarId = ComboBoxCars.SelectedValue,
            .CustomerId = ComboBoxCustomers.SelectedValue,
            .Amount = TextBoxAmount.Text,
            .Status = ComboBoxStatus.Text,
            .CreateDate = DateTimePickerCreateDate.Value
        }

        _genericRepositoryInvoice.AddT(newInvoice)

        AddInvoiceDataGridView()
        Clear()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridViewInvoices.SelectedRows.Count <= 0 Then
            MessageBox.Show("Fatura Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Id As Integer = Convert.ToInt32(DataGridViewInvoices.CurrentRow.Cells(0).Value)
        Dim invoice = _genericRepositoryInvoice.GetT(Function(x) x.Id = Id)
        If invoice IsNot Nothing Then
            _genericRepositoryInvoice.DeleteT(invoice)

            AddInvoiceDataGridView()
        End If
    End Sub

    Private Sub DataGridViewInvoices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewInvoices.CellClick
        ComboBoxCars.SelectedValue = DataGridViewInvoices.CurrentRow.Cells(1).Value
        ComboBoxCustomers.SelectedValue = DataGridViewInvoices.CurrentRow.Cells(3).Value
        TextBoxAmount.Text = DataGridViewInvoices.CurrentRow.Cells(5).Value
        ComboBoxStatus.Text = DataGridViewInvoices.CurrentRow.Cells(6).Value
        DateTimePickerCreateDate.Value = DataGridViewInvoices.CurrentRow.Cells(7).Value
    End Sub
End Class