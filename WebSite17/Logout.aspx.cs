﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      /*  if (Session["user"] != null)
        {
            TextBox.Text = "Welcome" + Session["user"].ToString();
        }  */
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("~/Login.aspx");

    }
}