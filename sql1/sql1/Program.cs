using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace sql1
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=BLT1080\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";
            using (SqlConnection co = new SqlConnection(constr))
            {
                string insertquery = "insert into Dep(Did,Dname) values("+"'104'"+","+"'IT')";

                try
                {

                    
                    co.Open();
                    SqlCommand cmd = new SqlCommand(insertquery, co);
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
