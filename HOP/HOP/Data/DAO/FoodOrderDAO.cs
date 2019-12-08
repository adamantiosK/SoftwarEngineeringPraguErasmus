using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOP.Model;

namespace HOP.Data.DAO
{
    class FoodOrderDAO
    {
        // Getting From database Methods 

        public static List<Model.FoodOrder> GetActiveFoodOrders()
        {
            List<Model.FoodOrder> orders = new List<Model.FoodOrder>();
            try
            {
                string queryString =
                    "SELECT TOP(1000)[OrderStatus],[FoodOrderID],[RoomNumber],[Comment]FROM[DB_A5088F_HOTELdb].[dbo].[FoodOrder]WHERE NOT OrderStatus = 'Done'";

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
                            string State = (Convert.ToString(reader[0]));
                            int OrderID = (Convert.ToInt32(reader[1]));
                            int RoomNumber = (Convert.ToInt32(reader[2]));
                            string Discription = (Convert.ToString(reader[3]));

                            Model.FoodOrder order1 = new Model.FoodOrder(State, OrderID, Discription, RoomNumber);
                            orders.Add(order1);
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

            return orders;
         
        }


        // Parsing to Database Methods

        public static void SetOrderStatusToInProgress(string OrderNo)
        {
            try
            {
                string queryString1 =
                    "UPDATE dbo.FoodOrder SET OrderStatus = 'InProgress' WHERE FoodOrderID =" + OrderNo;

                using (SqlConnection connection = new SqlConnection(
                    Form1._connectionString))
                {
                    SqlCommand command1 = new SqlCommand(
                        queryString1, connection);

                    connection.Open();
                    SqlDataReader reader1 = command1.ExecuteReader();
                    reader1.Close();

                    connection.Close();
                }
            }
            catch (Exception e) { }
        }

        public static void SetOrderStatusToDone(string orderNO)
        {
            try
            {
                string queryString =
                    "UPDATE dbo.FoodOrder SET OrderStatus = 'Done' WHERE FoodOrderID =" + orderNO;
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


    }
}
