

Public Class Form5

    Public Class Flight
        Public Property FlightNumber As String
        Public Property Destination As String
        Public Property FlightDate As DateTime
        Public Property AvailableSeats As Integer
        Public Property Price As Decimal
    End Class


    Public Shared flights As New List(Of Flight)


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_vol.Columns.Add("FlightNumber", "Numéro de vol")
        lst_vol.Columns.Add("Destination", "Destination")
        lst_vol.Columns.Add("FlightDate", "Date du vol")
        lst_vol.Columns.Add("AvailableSeats", "Places disponibles")
        lst_vol.Columns.Add("Price", "Prix")

        DisplayFlights()
    End Sub


    Private Sub DisplayFlights()
        lst_vol.Rows.Clear()
        For Each flight In GlobalData.flights
            lst_vol.Rows.Add(flight.FlightNumber, flight.Destination, flight.FlightDate, flight.AvailableSeats, flight.Price)
        Next
    End Sub


    Private Sub ajt_v_Click(sender As Object, e As EventArgs) Handles ajt_v.Click

        Dim newFlight As New Flight With {
            .FlightNumber = num_vol.Text,
            .Destination = dest.Text,
            .FlightDate = Date_vol.Value,
            .AvailableSeats = CInt(num_place.Value),
            .Price = CDec(prix.Text)
        }


        GlobalData.flights.Add(newFlight)


        DisplayFlights()


        ClearFields()
    End Sub


    Private Sub modif_v_Click(sender As Object, e As EventArgs) Handles mdf_v.Click
        If lst_vol.SelectedRows.Count > 0 Then

            Dim selectedIndex As Integer = lst_vol.SelectedRows(0).Index


            GlobalData.flights(selectedIndex).FlightNumber = num_vol.Text
            GlobalData.flights(selectedIndex).Destination = dest.Text
            GlobalData.flights(selectedIndex).FlightDate = Date_vol.Value
            GlobalData.flights(selectedIndex).AvailableSeats = CInt(num_place.Value)
            GlobalData.flights(selectedIndex).Price = CDec(prix.Text)


            DisplayFlights()


            ClearFields()

            MessageBox.Show("Le vol a été modifié avec succès.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub suppr_v_Click(sender As Object, e As EventArgs) Handles sup_v.Click
        If lst_vol.SelectedRows.Count > 0 Then

            Dim selectedIndex As Integer = lst_vol.SelectedRows(0).Index


            GlobalData.flights.RemoveAt(selectedIndex)


            DisplayFlights()


            ClearFields()

            MessageBox.Show("Le vol a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub lst_vol_SelectionChanged(sender As Object, e As EventArgs) Handles lst_vol.SelectionChanged
        If lst_vol.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = lst_vol.SelectedRows(0)
            num_vol.Text = selectedRow.Cells("FlightNumber").Value.ToString()
            dest.Text = selectedRow.Cells("Destination").Value.ToString()
            Date_vol.Value = CDate(selectedRow.Cells("FlightDate").Value)
            num_place.Value = CInt(selectedRow.Cells("AvailableSeats").Value)
            prix.Text = selectedRow.Cells("Price").Value.ToString()
        End If
    End Sub


    Private Sub ClearFields()
        num_vol.Clear()
        dest.Clear()
        prix.Clear()
        num_place.Value = 0
        Date_vol.Value = DateTime.Now
    End Sub
End Class

