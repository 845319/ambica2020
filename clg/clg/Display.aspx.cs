using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clg
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                Train t = new Train();
                var slist = t.Getallrecords();
                GridView1.DataSource = slist;
                GridView1.DataBind();
            }
        }
    }
}