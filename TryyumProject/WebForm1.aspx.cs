using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryyumProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       	        
		 protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToByte(TextBox1.Text);
                int y = Convert.ToByte(TextBox2.Text);
                TextBox3.Text = (x + y).ToString();
            }
            catch (Exception e1)
            {
             
                Label1.Visible = true;
                Label1.Text = e1.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //try
            //{
                int x = Convert.ToByte(TextBox1.Text);
                int y = Convert.ToByte(TextBox2.Text);
                TextBox3.Text = (x - y).ToString();
        //    }
        //    catch (Exception e1)
        //    {

        //        Label1.Text = e1.Message;
        //    }
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Response.Clear();
            Exception exc = Server.GetLastError();


            

            Server.Transfer("ErrorPage.aspx?errorMessage=" + exc.Message);



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("w1.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["value100"] = TextBox1.Text;
            Response.Redirect("WebForm2.aspx?value1=" + TextBox1.Text);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cookie1");
            cookie["value1"] = TextBox1.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm2.aspx");
        }
    }
	  
}