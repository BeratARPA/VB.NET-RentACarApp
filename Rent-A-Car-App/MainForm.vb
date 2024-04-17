Public Class MainForm
    Public Sub New()
        InitializeComponent()

        GlobalVariables.MainForm = Me

        NavigationManager.OpenForm(New LoginForm, DockStyle.Fill, PanelMain)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class