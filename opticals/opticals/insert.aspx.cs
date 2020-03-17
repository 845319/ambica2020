using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opticals
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adolayer ad = new adolayer();
            int cid = int.Parse(TextBox1.Text);
            string cname = TextBox2.Text;
            string ctype = TextBox3.Text;
            int range = int.Parse(TextBox4.Text);

            ad.insert(cid, cname,ctype,range);
        }
    }
}