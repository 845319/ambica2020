using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opticals
{
    public partial class show1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                adolayer ad = new adolayer();
                var data = ad.Getrecords();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

       
    }
}