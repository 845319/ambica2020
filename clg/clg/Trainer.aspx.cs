﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clg
{
    public partial class Trainer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Train td = new Train();
            int Id = int.Parse(TextBox1.Text);
            string name = TextBox2.Text;
            string location = TextBox3.Text;
            string domain = TextBox4.Text;
            string sdate = TextBox5.Text;
            td.Insertrow(Id, name, location, domain, sdate);
        }
    }
}