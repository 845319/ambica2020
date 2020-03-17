using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace opticals
{
    public class adolayer
    {
        string constr = "";
        public adolayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstr"].ConnectionString;
        }
        
        public void insert(int cid, string cname, string ctype, int range)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    cmd.Parameters.AddWithValue("@ctype", ctype);
                    cmd.Parameters.AddWithValue("@range", range);
                    cmd.CommandText = "insert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
       
        public DataSet Getrecords()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from opt";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    
                }
            }
            catch(Exception ex)
            {

            }
            return ds;
        }
        public void update(int cid, string range)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid",cid);
                    //cmd.Parameters.AddWithValue("@tname", tname);
                    // cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@range", range);
                    // cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.CommandText = "update";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
    }
}
