Public Class NavigationManager
    Public Shared Sub OpenForm(form As Form, dockStyle As DockStyle, parentPanel As Panel)
        parentPanel.Controls.Clear()

        Dim formCollection As FormCollection = Application.OpenForms
        For i As Integer = formCollection.Count - 1 To 0 Step -1
            If formCollection(i).Name <> "MainForm" Then
                formCollection(i).Close()
            End If
        Next

        Dim formSearch As Form = Application.OpenForms(form.Name)
        If formSearch IsNot Nothing Then
            formSearch.Dock = dockStyle
            formSearch.TopLevel = False
            formSearch.TopMost = True
            formSearch.Show()

            parentPanel.Controls.Add(formSearch)
        Else
            form.Dock = dockStyle
            form.TopLevel = False
            form.TopMost = True
            form.Show()

            parentPanel.Controls.Add(form)
        End If
    End Sub
End Class