﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud1
{
    public partial class updatef : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int tid = int.Parse(TextBox1.Text);

            string techdomain = TextBox2.Text;

            ad.updatedataoff(tid, techdomain);
        }
    }
}