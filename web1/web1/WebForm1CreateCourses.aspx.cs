using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web1
{
    public partial class WebForm1CreateCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            adolayer ai = new adolayer();
            int courseid = int.Parse(TextBox1.Text);
            string coursename = TextBox2.Text;
            string Startdate = TextBox3.Text;
            int fee = int.Parse(TextBox4.Text);
            ai.Insertrow(courseid, coursename, Startdate, fee);
        }
    }
}