Module GlobalDataa

    Public flights As New List(Of Form5.Flight)
    Public reservations As New List(Of Form3.Reservation)
End Module

Public Class Form1
    Dim adminUsernamee As String = "admin"
    Dim adminPassworde As String = "admin123"
    Dim userUsernamee As String = "user"
    Dim userPassworde As String = "user123"

    Private Sub btn_connecter_Click(sender As Object, e As EventArgs) Handles btn_connecter.Click

        Dim usernamee As String = id.Text
        Dim passworde As String = mdp.Text


        If String.IsNullOrEmpty(usernamee) Or String.IsNullOrEmpty(passworde) Then
            Lbl5.Text = "Veuillez remplir tous les champs."
            Lbl5.ForeColor = Color.Red
            Return
        End If


        If lst.SelectedItem Is Nothing Then
            Lbl5.Text = "Veuillez sélectionner un rôle."
            Lbl5.ForeColor = Color.Red
            Return
        End If


        If lst.SelectedItem = "Admin" Then
            If usernamee = adminUsername And passworde = adminPassword Then
                Form5.Show()
                Me.Hide()
            End If
        ElseIf lst.SelectedItem = "Utilisateur" Then
            If usernamee = userUsername And passworde = userPassword Then
                Form3.Show()
                Me.Hide()
            End If
        End If


    End Sub


End Class





