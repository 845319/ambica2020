using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clgt
{
    public partial class Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            emp td = new emp();
            int Id = int.Parse(TextBox1.Text);
            string domain = TextBox2.Text;
            
           string err= td.updatee(Id, domain);
            Label1.Text = err;
        }
    }
}