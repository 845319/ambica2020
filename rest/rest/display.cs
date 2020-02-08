using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rest
{
    class display
    {
        public string Name { get; set; }
        public string ID { get; set; }
        private string Type { get; set; }
        public string Location { get; set; }
        public void showres()
        {
            string constr = @"Data Source=BLT1080\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    string querystr = "select * from res";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader r = cmd.ExecuteReader();
                    while(r.Read())
                        {
                            Console.WriteLine("{0}{1}{2}{3}",r[0],r[1],r[2],r[3]);

                        }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
