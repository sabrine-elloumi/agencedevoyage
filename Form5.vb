Public Class Form5

    ' Définition de la classe Flight
    Public Class Flight
        Public Property FlightNumber As String
        Public Property Destination As String
        Public Property FlightDate As DateTime
        Public Property AvailableSeats As Integer
        Public Property Price As Decimal
    End Class

    ' Liste des vols partagée à travers GlobalData
    Public Shared flights As New List(Of Flight)

    ' Méthode qui se déclenche lors du chargement du formulaire
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nettoyage avant l'ajout des colonnes pour éviter les duplications
        lst_vol.Columns.Clear()

        ' Ajout des colonnes au DataGridView
        lst_vol.Columns.Add("FlightNumber", "Numéro de vol")
        lst_vol.Columns.Add("Destination", "Destination")
        lst_vol.Columns.Add("FlightDate", "Date du vol")
        lst_vol.Columns.Add("AvailableSeats", "Places disponibles")
        lst_vol.Columns.Add("Price", "Prix")

        ' Affichage des vols existants
        DisplayFlights()
    End Sub

    ' Méthode pour afficher la liste des vols dans le DataGridView
    Private Sub DisplayFlights()
        lst_vol.Rows.Clear() ' Vider les lignes existantes avant d'ajouter les nouvelles
        For Each flight In GlobalData.flights
            lst_vol.Rows.Add(flight.FlightNumber, flight.Destination, flight.FlightDate, flight.AvailableSeats, flight.Price)
        Next
    End Sub

    ' Méthode pour ajouter un vol
    Private Sub ajt_v_Click(sender As Object, e As EventArgs) Handles ajt_v.Click
        ' Valider les entrées utilisateur
        If String.IsNullOrWhiteSpace(num_vol.Text) OrElse
           String.IsNullOrWhiteSpace(dest.Text) OrElse
           String.IsNullOrWhiteSpace(prix.Text) Then
            MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ajout d'un nouveau vol
        Dim newFlight As New Flight With {
            .FlightNumber = num_vol.Text,
            .Destination = dest.Text,
            .FlightDate = Date_vol.Value,
            .AvailableSeats = CInt(num_place.Value),
            .Price = CDec(prix.Text)
        }

        ' Ajouter le nouveau vol à la liste
        GlobalData.flights.Add(newFlight)

        ' Mettre à jour l'affichage
        DisplayFlights()

        ' Vider les champs
        ClearFields()
    End Sub

    ' Méthode pour modifier un vol
    Private Sub modif_v_Click(sender As Object, e As EventArgs) Handles mdf_v.Click
        ' Vérifier si un vol est sélectionné
        If lst_vol.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = lst_vol.SelectedRows(0).Index

            ' Modifier les informations du vol sélectionné
            GlobalData.flights(selectedIndex).FlightNumber = num_vol.Text
            GlobalData.flights(selectedIndex).Destination = dest.Text
            GlobalData.flights(selectedIndex).FlightDate = Date_vol.Value
            GlobalData.flights(selectedIndex).AvailableSeats = CInt(num_place.Value)
            GlobalData.flights(selectedIndex).Price = CDec(prix.Text)

            ' Mettre à jour l'affichage
            DisplayFlights()

            ' Vider les champs
            ClearFields()

            MessageBox.Show("Le vol a été modifié avec succès.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Méthode pour supprimer un vol
    Private Sub suppr_v_Click(sender As Object, e As EventArgs) Handles sup_v.Click
        ' Vérifier si un vol est sélectionné
        If lst_vol.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = lst_vol.SelectedRows(0).Index

            ' Supprimer le vol sélectionné
            GlobalData.flights.RemoveAt(selectedIndex)

            ' Mettre à jour l'affichage
            DisplayFlights()

            ' Vider les champs
            ClearFields()

            MessageBox.Show("Le vol a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Méthode qui se déclenche lorsque la sélection dans le DataGridView change
    Private Sub lst_vol_SelectionChanged(sender As Object, e As EventArgs) Handles lst_vol.SelectionChanged
        ' Vérifier si une ligne est sélectionnée
        If lst_vol.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = lst_vol.SelectedRows(0)

            ' Récupérer les valeurs des cellules et les afficher dans les champs de saisie
            If selectedRow.Cells("FlightNumber").Value IsNot Nothing Then
                num_vol.Text = selectedRow.Cells("FlightNumber").Value.ToString()
            End If
            If selectedRow.Cells("Destination").Value IsNot Nothing Then
                dest.Text = selectedRow.Cells("Destination").Value.ToString()
            End If
            If selectedRow.Cells("FlightDate").Value IsNot Nothing Then
                Date_vol.Value = CDate(selectedRow.Cells("FlightDate").Value)
            End If
            If selectedRow.Cells("AvailableSeats").Value IsNot Nothing Then
                num_place.Value = CInt(selectedRow.Cells("AvailableSeats").Value)
            End If
            If selectedRow.Cells("Price").Value IsNot Nothing Then
                prix.Text = selectedRow.Cells("Price").Value.ToString()
            End If
        End If
    End Sub

    ' Méthode pour vider les champs après une opération
    Private Sub ClearFields()
        num_vol.Clear()
        dest.Clear()
        prix.Clear()
        num_place.Value = 0
        Date_vol.Value = DateTime.Now
    End Sub

End Class


