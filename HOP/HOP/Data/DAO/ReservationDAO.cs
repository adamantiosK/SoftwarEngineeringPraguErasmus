using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOP.Model;

namespace HOP.Data.DAO
{
    class ReservationDAO
    {
        // Getting From database Methods 

        public static List<Reservation> GetReservationDetails()
        {
            List<Reservation> reservations = new List<Reservation>();

            try
            {
                string queryString =
                    "SELECT StartOfReservation , EndOfReservation , CustomerID FROM Reservation WHERE GETDATE() >= StartOfReservation AND GETDATE() <= EndOfReservation AND ReservationID IN(SELECT ReservationID	 FROM Residence)";

                using (SqlConnection connection = new SqlConnection(
                    Form1._connectionString))
                {

                    SqlCommand command = new SqlCommand(
                        queryString, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            DateTime CheckIn = Convert.ToDateTime((Convert.ToString(reader[0])));
                            DateTime CheckOut = Convert.ToDateTime((Convert.ToString(reader[1])));
                            int CustomerID = (Convert.ToInt32(reader[2]));
                            Reservation reservation1 = new Reservation(CheckIn, CheckOut, CustomerID);
                            reservations.Add(reservation1);
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }

                    connection.Close();
                }
            }
            catch (Exception e) { }

            return reservations;
        }

    }
}
