using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOP.Model;

namespace HOP.Data.DAO
{
    class RoomsDAO
    {
        // Getting From database Methods 


        public static List<Room> GetRoomsOfResidence()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                string queryString =
                    "SELECT RoomNumber , CleaningStatus , NumberOfCleaners FROM Room WHERE ( NOT CleaningStatus = 'Done') AND  RoomNumber IN (SELECT RoomNumber FROM ReservationOfRoomR WHERE ReservationID IN (SELECT ReservationID FROM Reservation  WHERE GETDATE() > StartOfReservation AND GETDATE() < EndOfReservation AND ReservationID IN(SELECT ReservationID FROM Residence)))";

                using (SqlConnection connection = new SqlConnection(
                    Form1._connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        queryString, connection);


                    connection.Open();
                    SqlDataReader reader1 = command.ExecuteReader();


                    while (reader1.Read())
                    {
                        string RoomID = (Convert.ToString(reader1[0]));
                        string RoomState = (Convert.ToString(reader1[1]));
                        string Number = (Convert.ToString(reader1[2]));

                        Room room1 = new Room(RoomID, RoomState, Number);
                        rooms.Add(room1);
                    }

                    reader1.Close();
                    connection.Close();
                }
            }
            catch (Exception e) { }

            return rooms;
        }
        

        // Parsing to Database Methods
        public static void SetCleaningStatusToDone(string roomNumber)
        {
            try
            {
                string queryString =
                    "UPDATE dbo.Room SET CleaningStatus = 'DONE' WHERE RoomNumber = " + roomNumber;
                using (SqlConnection connection = new SqlConnection(
                    Form1._connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
            }
            catch (Exception e) { }
        }


        public static void SetCleaningStatusToInProgress(string ActiveNumber, string roomNumber)
        {
            try
            {
                string queryString1 =
                    "UPDATE dbo.Room SET CleaningStatus = 'InProgress' WHERE RoomNumber = " + roomNumber;
                string queryString2 =
                    "UPDATE dbo.Room SET NumberOfCleaners = '" + ActiveNumber + "' WHERE RoomNumber = " + roomNumber;
                using (SqlConnection connection = new SqlConnection(
                    Form1._connectionString))
                {
                    SqlCommand command1 = new SqlCommand(
                        queryString1, connection);
                    SqlCommand command2 = new SqlCommand(
                        queryString2, connection);
                    connection.Open();
                    SqlDataReader reader1 = command1.ExecuteReader();
                    reader1.Close();
                    SqlDataReader reader2 = command2.ExecuteReader();
                    reader2.Close();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
            }
        }



    }
}
