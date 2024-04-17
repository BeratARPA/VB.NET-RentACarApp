Imports Database

Public Class LoginForm

    Dim _genericRepositoryUser As New GenericRepository(Of User)(GlobalVariables.SQLContext)

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        If String.IsNullOrEmpty(TextBoxPin.Text) Then
            MessageBox.Show("Şifre Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userExist = _genericRepositoryUser.GetT(Function(x) x.Password = TextBoxPin.Text)
        If userExist IsNot Nothing Then
            LoggedInUser.Login(userExist)
        Else
            MessageBox.Show("Kullanıcı Bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxPin.Clear()
    End Sub

    Private Sub Numbers(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        Dim button As Button = DirectCast(sender, Button)
        TextBoxPin.Text += button.Text
    End Sub
End Class