Public Class DashboardForm
    Private Sub ButtonCustomerManager_Click(sender As Object, e As EventArgs) Handles ButtonCustomerManager.Click
        NavigationManager.OpenForm(New CustomerManagerForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub ButtonCarManager_Click(sender As Object, e As EventArgs) Handles ButtonCarManager.Click
        NavigationManager.OpenForm(New CarManagerForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub ButtonInvoiceManager_Click(sender As Object, e As EventArgs) Handles ButtonInvoiceManager.Click
        NavigationManager.OpenForm(New InvoiceManagerForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub ButtonLogOut_Click(sender As Object, e As EventArgs) Handles ButtonLogOut.Click
        LoggedInUser.Logout()
    End Sub

    Private Sub ButtonUserManager_Click(sender As Object, e As EventArgs) Handles ButtonUserManager.Click
        NavigationManager.OpenForm(New UserManagerForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUserName.Text = LoggedInUser.CurrentUser.Name
    End Sub
End Class