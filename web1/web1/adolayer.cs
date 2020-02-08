using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace web1
{
    public class adolayer
    {
        string constr = "";
        public adolayer()
        {

            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;

        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            
            string selquery = "select * from Courses";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            return ds; 
        }
        public void Insertrow(int courseid, string coursename, string startdate, int fee)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@courseid", courseid);
                    cmd.Parameters.AddWithValue("@coursename", coursename);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.CommandText = "InsertRecord";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
            
        }

    }
    }
