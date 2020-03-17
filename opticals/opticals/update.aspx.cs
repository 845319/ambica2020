using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opticals
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           adolayer ad = new adolayer();
            int cid = int.Parse(TextBox1.Text);

            string range = TextBox2.Text;

            ad.update(cid, range);
        }
    }
}