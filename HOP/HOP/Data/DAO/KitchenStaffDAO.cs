using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOP.Model;

namespace HOP.Data.DAO
{
    class KitchenStaffDAO
    {
        // Getting From database Methods 

        public static List<Model.KitchenStaff> GetKitchenStaffList()
        {
            List<Model.KitchenStaff> _cooks = new List<Model.KitchenStaff>();

            try
            {

                string queryString = "SELECT TOP (1000) [KitchenStaffID] FROM [DB_A5088F_HOTELdb].[dbo].[KitchenStaff]";

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
                            Model.KitchenStaff _cook = new Model.KitchenStaff(Convert.ToInt16(reader[0]));
                            _cooks.Add(_cook);
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

            return _cooks;
        }

    }
}
