﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud1
{
    public partial class deletf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer n = new ADOLayer();
            int fid = int.Parse(TextBox1.Text);
            n.deletefac(fid);
        }
    }
}