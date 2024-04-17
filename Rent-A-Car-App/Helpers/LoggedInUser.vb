Imports Database

Public Class LoggedInUser
    Public Shared Property CurrentUser As User

    Public Shared Sub Login(user As User)
        CurrentUser = user
        NavigationManager.OpenForm(New DashboardForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub

    Public Shared Sub Logout()
        CurrentUser = Nothing
        NavigationManager.OpenForm(New LoginForm, DockStyle.Fill, GlobalVariables.MainForm.PanelMain)
    End Sub
End Class