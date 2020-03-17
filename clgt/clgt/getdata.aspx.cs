using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clgt
{
    public partial class getdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
       
                emp td = new emp();
                int Id = Convert.ToInt32(TextBox1.Text);
                var list = td.getdata(Id);
                GridView1.DataSource = list;
                GridView1.DataBind();
            
        }

       
    }
}
