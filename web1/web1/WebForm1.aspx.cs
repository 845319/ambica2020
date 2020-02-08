using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                adolayer al = new adolayer();
                var slist = al.Getallrecords();
                GridView1.DataSource = slist;
                GridView1.DataBind();

               

            }
        }
        public static void GetData()
        {

        }
      


    }
}
