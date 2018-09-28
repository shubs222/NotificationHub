using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NHUB
{
    public partial class Notifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!(Page.IsPostBack))
            {
                for (int count = 0; count < 5; count++)
                {
                    Label NotificationName = new Label();
                    HyperLink EditLink = new HyperLink();
                    HyperLink DeleteLink = new HyperLink();
                    NotificationName.Text = "Shubham" + 1;
                    NotificationName.Width = 200;
                    NotificationPlaceHolder.Controls.Add(NotificationName);
                    EditLink.Text = "Edit";
                    EditLink.Width = 200;
                    NotificationPlaceHolder.Controls.Add(EditLink);
                    DeleteLink.Text = "Delete" + "<br/>";

                    NotificationPlaceHolder.Controls.Add(DeleteLink);
                }
            }
        }

        protected void TestButton_Click(object sender, EventArgs e)
        {

        }

        protected void Test2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}