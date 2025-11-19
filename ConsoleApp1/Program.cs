using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connstr = @"Server=localhost\SQLEXPRESS;Database=StudentsDB;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "select id,name,detailsid from Students";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine($"{dr["id"]} - {dr["name"]} - {dr["detailsid"]}");
                }
                dr.Close();
            }
        }
    }
}
