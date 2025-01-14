Module GlobalData

    Public flights As New List(Of Form5.Flight)
    Public reservations As New List(Of Form3.Reservation)
End Module

Public Class Form1
    Dim adminUsername As String = "admin"
    Dim adminPassword As String = "admin123"
    Dim userUsername As String = "user"
    Dim userPassword As String = "user123"

    Private Sub btn_connecter_Click(sender As Object, e As EventArgs) Handles btn_connecter.Click

        Dim username As String = id.Text
        Dim password As String = mdp.Text


        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
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
            If username = adminUsername And password = adminPassword Then
                Form5.Show()
                Me.Hide()
            End If
        ElseIf lst.SelectedItem = "Utilisateur" Then
            If username = userUsername And password = userPassword Then
                Form3.Show()
                Me.Hide()
            End If
        End If


    End Sub


End Class





