
Public Class Form3

    Public Structure Reservationn
        Public ClientName As String
        Public ClientSurname As String
        Public PhoneNumber As String
        Public FlightNumber As String
    End Structure


    Public Shared reservationns As New List(Of Reservation)

    Private Sub btn_reserv_Click(sender As Object, e As EventArgs) Handles btn_reserv.Click

        If String.IsNullOrEmpty(nom_u.Text) OrElse String.IsNullOrEmpty(prenom_u.Text) OrElse String.IsNullOrEmpty(numtel_u.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs avant de réserver.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If aff_res.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol dans la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim selectedRow As DataGridViewRow = aff_res.SelectedRows(0)
        Dim flightNumber As String = selectedRow.Cells("FlightNumber").Value.ToString()


        Dim newReservation As New Reservation With {
            .ClientName = nom_u.Text,
            .ClientSurname = prenom_u.Text,
            .PhoneNumber = numtel_u.Text,
            .FlightNumber = flightNumber
        }


        reservations.Add(newReservation)


        MessageBox.Show("Réservation réussie !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


        nom_u.Clear()
        prenom_u.Clear()
        numtel_u.Clear()


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Ajouter des colonnes au DataGridView
        aff_res.Columns.Add("FlightNumber", "Numéro de vol")
        aff_res.Columns.Add("Destination", "Destination")
        aff_res.Columns.Add("Date", "Date")

        ' Ajouter des exemples de vols
        aff_res.Rows.Add("FL123", "Paris", "04/01/2025")
        aff_res.Rows.Add("FL456", "Londres", "05/01/2025")
        aff_res.Rows.Add("FL789", "New York", "06/01/2025")

    End Sub
End Class




