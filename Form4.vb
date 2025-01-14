Public Class Form4
    ' Méthode pour charger les vols et les réservations
    Public Sub LoadData(flights As List(Of Form5.Flight), reservations As List(Of Form3.Reservation))
        ' Charger les vols dans le DataGridView des vols
        dgv_v.Rows.Clear()
        For Each flight In flights
            dgv_v.Rows.Add(flight.FlightNumber, flight.Destination, flight.FlightDate, flight.AvailableSeats, flight.Price)
        Next

        ' Charger les réservations dans le DataGridView des réservations
        dgv_r.Rows.Clear()
        For Each reservation In reservations
            dgv_r.Rows.Add(reservation.ClientName, reservation.PhoneNumber, reservation.FlightNumber)
        Next

    End Sub


    ' Initialisation des colonnes des DataGridView lors du chargement du formulaire
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Colonnes pour les vols
        dgv_v.Columns.Add("FlightNumber", "Numéro de vol")
        dgv_v.Columns.Add("Destination", "Destination")
        dgv_v.Columns.Add("FlightDate", "Date du vol")
        dgv_v.Columns.Add("AvailableSeats", "Places disponibles")
        dgv_v.Columns.Add("Price", "Prix")

        ' Colonnes pour les réservations
        dgv_r.Columns.Add("ClientName", "Nom du client")
        dgv_r.Columns.Add("ClientPhone", "Téléphone")
        dgv_r.Columns.Add("FlightNumber", "Numéro de vol")
    End Sub
End Class



