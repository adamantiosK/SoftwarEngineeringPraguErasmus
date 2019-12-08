using HOP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Data.DAO
{
    class CleaningStaffDAO
    {
        // Getting From database Methods 

        public static List<CleaningStaff> GetCleaningStaffList()
        {
            List<CleaningStaff> _cleaners = new List<CleaningStaff>();
            try
            {

                string queryString1 =
                    "SELECT TOP(1000) [CleaningStaffID] FROM[DB_A5088F_HOTELdb].[dbo].[CleaningStaff]";

                using (SqlConnection connection = new SqlConnection(
                    Form1._connectionString))
                {

                    SqlCommand command1 = new SqlCommand(
                        queryString1, connection);

                    connection.Open();
                    SqlDataReader reader1 = command1.ExecuteReader();
                    try
                    {
                        while (reader1.Read())
                        {
                            CleaningStaff _cleaner = new CleaningStaff(Convert.ToInt16(reader1[0]));
                            _cleaners.Add(_cleaner);

                        }
                    }
                    finally
                    {
                        reader1.Close();
                    }

                    connection.Close();
                }

            }
            catch (Exception e) { }

            return _cleaners;
        }
    }
}
