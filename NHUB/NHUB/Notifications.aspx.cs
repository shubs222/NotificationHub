using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace NHUB
{
    public partial class Notifications : System.Web.UI.Page
    {
        NotificationsRepository notificationsRepository = new NotificationsRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            notificationsRepository.getDetails();
            if (!Page.IsPostBack)
            {
                HyperLink NameHyperlink;

                for (int Sourcecount = 0; Sourcecount < notificationsRepository.SourceList.Count; Sourcecount++)
                {
                    NameHyperlink = new HyperLink();
                    NameHyperlink.Text = notificationsRepository.SourceList[Sourcecount].SourceName+"<br/>";
                    NameHyperlink.ID = "count";
                    NotificationPlaceHolder.Controls.Add(NameHyperlink);
                   
                    for (int i = 0; i < 5; i++)
                    {
                        Label lb = new Label();
                        lb.Text = "shubham" + i+"<br/>";
                        NotificationPlaceHolder.Controls.Add(lb);
                    }
                }
            }

            //else
            //{
            //    int id = Convert.ToInt32(Request.QueryString["id"]);
            //    Label lb;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        lb = new Label();
            //        lb.Text = "shubham" + id + i + "<br/>";
            //        NotificationPlaceHolder.Controls.Add(lb);

            //    }
            //}

        }
       
        


        protected void AddNotificationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEvent.aspx");
        }
    }
}