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

            if (Page.IsPostBack)
            {
                for (int count = 0; count < 5; count++)
                {
                    HyperLink button = new HyperLink();
                    button.Text = "Click";
                    NotificationPlaceHolder.Controls.Add(button);
                    button.NavigateUrl = "Notifications?=" + count;
                    //EditLink.Text = "Edit";
                    //EditLink.Width = 200;
                    //NotificationPlaceHolder.Controls.Add(EditLink);
                    //DeleteLink.Text = "Delete" + "<br/>";

                    //NotificationPlaceHolder.Controls.Add(DeleteLink);
                }
            }

            else
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Label lb;
                for (int i = 0; i < 5; i++)
                {
                    lb = new Label();
                    lb.Text = "shubham" + id + i + "<br/>";
                    NotificationPlaceHolder.Controls.Add(lb);

                }
            }
        }
       
        


        protected void AddNotificationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEvent.aspx");
        }
    }
}