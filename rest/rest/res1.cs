using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace rest
{
    class res1
    {
       public void data()
        {
            string constr = @"Data Source=BLT1080\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    string querystr = "select * from res";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}{1}{2}{3}{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
      
        public void insert()
        {
            string constr = @"Data Source=BLT1080\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    // string querystr = "insert into res(restname,restloc,opentime,closetime,ID)";
                    string r = Console.ReadLine();
                    con.Open();
                    SqlCommand cmd = new SqlCommand(r, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}{1}{2}{3}{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }

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

