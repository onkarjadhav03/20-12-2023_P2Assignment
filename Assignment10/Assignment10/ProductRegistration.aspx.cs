using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblmsg.Visible = false;
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            lblmsg.Visible = true;
            lblmsg.Text="Product Name:"+txtpname.Text;
            lblmsg.Text += "<br> Category" + Cat.Text;
            lblmsg.Text+="<br> Price:"+txtprice.Text;
            lblmsg.Text += "<br> Description:" + Desc.InnerText;
            lblmsg.Text += "<br>Release Date:" + Calendar.SelectedDate.ToShortDateString();
        }
    }
}