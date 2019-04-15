using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_HelloWorld
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Write("Name is "+txtName.Text);
            Response.Write("<br />Country is " + ListBox1.SelectedItem.Text);
            //Response.Write("Gender is " +)
        }
    }
}