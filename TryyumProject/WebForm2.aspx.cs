using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryyumProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["value1"]!=null)
            {
                Label1.Text = Request.QueryString["value1"].ToString();
            }

          HttpCookie cookie1= Request.Cookies["cookie1"];
            if(cookie1 !=null)
            {
                Label2.Text = cookie1["value1"].ToString() + "Hi";
            }
            if(Session["value100"] !=null)
            {
                Label3.Text = Session["value100"].ToString();
            }
        }
    }
}