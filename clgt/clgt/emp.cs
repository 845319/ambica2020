using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace clgt
{
    public class emp
    {
        string constr = "";
        public emp()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();

            string selquery = "select * from Table1";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            return ds;
        }
        public void Insertrow(int Id, string name, string domain, string location, string sdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Trainer", con);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@domain", domain);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@sdate", sdate);
                    cmd.CommandText = "Pinsert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public string updatee(int Id,string domain)
        {
            string err = "";
            DataSet ds = new DataSet();
            try
            {
                using(SqlConnection con=new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Up",con);
                    cmd.Parameters.AddWithValue("@Id",Id);
                    cmd.Parameters.AddWithValue("@domain",domain);
                    cmd.CommandText = "updater";
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(ds);
                    ad.Update(ds);
                }
            }
            catch
            {
               
            }
            return err;
        }
        public DataSet getdata(int Id)
        {
            
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id",Id);
                    cmd.CommandText = "getd";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con; 
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);

                }
            }
            catch(Exception ex)
            {
                
            }
            
            return ds;
           
        }
    }
}