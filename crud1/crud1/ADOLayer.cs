using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace crud1
{
    public class ADOLayer
    {
        string constr = "";
        public ADOLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstr"].ConnectionString;
        }
        public DataSet getstu(int Id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandText = "id";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }
        public DataSet deletestu(int sid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", sid);
                    cmd.CommandText = "Del2";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }
        public DataSet deleteco(int cid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.CommandText = "Del3";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }
        public DataSet deletefac(int fid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", fid);
                    cmd.CommandText = "Del1";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }
        public void updatedata(int Id, string name)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    //cmd.Parameters.AddWithValue("@tname", tname);
                    // cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@Name", name);
                    // cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.CommandText = "Up1";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
        public void updatedataofc(int cid, int stu)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    //cmd.Parameters.AddWithValue("@tname", tname);
                    // cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@students", stu);
                    // cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.CommandText = "Up2";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
        public void updatedataoff(int fid, string fname)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", fid);
                    //cmd.Parameters.AddWithValue("@tname", tname);
                    // cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    // cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.CommandText = "Up3";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
        public void insertrow(int Id, string name)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", name);


                    cmd.CommandText = "Insert1";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public void insertrowofc(int cid, string cname, int students)
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
                    cmd.Parameters.AddWithValue("@students", students);


                    cmd.CommandText = "Insert2";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public void insertrowoff(int fid, string fname)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", fid);
                    cmd.Parameters.AddWithValue("@fname", fname);

                    cmd.CommandText = "Insert3";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from Student";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
        public DataSet Getallrecordsofc()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from Course";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
        public DataSet GetallrecordsofF()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from Faculty";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
    }
}