Imports System.Windows.Forms.VisualStyles
Imports Database

Public Class CarManagerForm
    Dim _genericRepositoryCar As New GenericRepository(Of Car)(GlobalVariables.SQLContext)

    Private Sub CarManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddCarDataGridView()
    End Sub

    Private Sub AddCarDataGridView()
        DataGridViewCars.Rows.Clear()

        Dim cars As List(Of Car) = _genericRepositoryCar.GetTAll(Function(x) True)
        For Each car In cars
            DataGridViewCars.Rows.Add(car.Id, car.Plate, car.Type, car.Active, car.Brand, car.Model, car.Version, car.Year)
        Next

        DataGridViewCars.ClearSelection()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        NavigationManager.OpenForm(New DashboardForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If String.IsNullOrEmpty(TextBoxPlate.Text) OrElse String.IsNullOrEmpty(TextBoxType.Text) OrElse String.IsNullOrEmpty(TextBoxBrand.Text) OrElse String.IsNullOrEmpty(TextBoxYear.Text) OrElse String.IsNullOrEmpty(TextBoxModel.Text) OrElse String.IsNullOrEmpty(TextBoxVersion.Text) Then
            MessageBox.Show("Gerekli Bilgileri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update
        If DataGridViewCars.SelectedRows.Count > 0 Then
            Dim Id As Integer = Convert.ToInt32(DataGridViewCars.CurrentRow.Cells(0).Value)
            Dim car = _genericRepositoryCar.GetT(Function(x) x.Id = Id)

            If car IsNot Nothing Then
                car.Brand = TextBoxBrand.Text
                car.Model = TextBoxModel.Text
                car.Version = TextBoxVersion.Text
                car.Year = TextBoxYear.Text
                car.Active = CheckBoxActive.Checked
                car.Type = TextBoxType.Text
                car.Plate = TextBoxPlate.Text

                _genericRepositoryCar.UpdateT(car)
            End If

            AddCarDataGridView()
            Clear()
            Return
        End If

        ' Save
        Dim newCar As New Car With {
            .Brand = TextBoxBrand.Text,
            .Model = TextBoxModel.Text,
            .Version = TextBoxVersion.Text,
            .Year = TextBoxYear.Text,
            .Active = CheckBoxActive.Checked,
            .Type = TextBoxType.Text,
            .Plate = TextBoxPlate.Text
        }

        _genericRepositoryCar.AddT(newCar)

        AddCarDataGridView()
        Clear()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridViewCars.SelectedRows.Count <= 0 Then
            MessageBox.Show("Araç Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Id As Integer = Convert.ToInt32(DataGridViewCars.CurrentRow.Cells(0).Value)
        Dim car = _genericRepositoryCar.GetT(Function(x) x.Id = Id)
        If car IsNot Nothing Then
            _genericRepositoryCar.DeleteT(car)

            AddCarDataGridView()
        End If
    End Sub

    Private Sub Clear()
        TextBoxBrand.Clear()
        TextBoxModel.Clear()
        TextBoxVersion.Clear()
        TextBoxYear.Clear()
        TextBoxType.Clear()
        TextBoxPlate.Clear()
    End Sub

    Private Sub DataGridViewCars_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCars.CellClick
        TextBoxBrand.Text = DataGridViewCars.CurrentRow.Cells(4).Value
        TextBoxModel.Text = DataGridViewCars.CurrentRow.Cells(5).Value
        TextBoxVersion.Text = DataGridViewCars.CurrentRow.Cells(6).Value
        TextBoxYear.Text = DataGridViewCars.CurrentRow.Cells(7).Value
        CheckBoxActive.Checked = DataGridViewCars.CurrentRow.Cells(3).Value
        TextBoxType.Text = DataGridViewCars.CurrentRow.Cells(2).Value
        TextBoxPlate.Text = DataGridViewCars.CurrentRow.Cells(1).Value
    End Sub
End Class