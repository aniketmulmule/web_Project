﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            //this modification done by user1
            Button1.Visible = false;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.Visible = true;
            //this modification done by user2
        }
    }
}