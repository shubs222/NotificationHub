using System;
using System.Collections.Generic;
using System.Data;
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
        AddNotificationRepository addNotificationRepository = new AddNotificationRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            //notificationsRepository.getDetails();
            //if (!Page.IsPostBack)
            //{
            //    HyperLink NameHyperlink;

            //    for (int Sourcecount = 0; Sourcecount < notificationsRepository.SourceList.Count; Sourcecount++)
            //    {
            //        NameHyperlink = new HyperLink();
            //        NameHyperlink.Text = notificationsRepository.SourceList[Sourcecount].SourceName+"<br/>";
            //        NameHyperlink.ID = "count";
            //        NotificationPlaceHolder.Controls.Add(NameHyperlink);

            //        for (int i = 0; i < 5; i++)
            //        {
            //            Label lb = new Label();
            //            lb.Text = "shubham" + i + "<br/>";
            //            lb.Visible = true;
            //            if (lb.Visible == false)
            //            {

            //            }
            //            else
            //            {

            //                NotificationPlaceHolder.Controls.Add(lb);
            //            }
            //        } 

            //    }
            //}

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
            if (!this.IsPostBack)
            {
                DataTable dt = addNotificationRepository.GetData("SELECT Id, Name FROM Source");
                this.PopulateTreeView(dt, 0, null);
            }


        }
        private void PopulateTreeView(DataTable dtParent, int parentId, TreeNode treeNode)
        {
            foreach (DataRow row in dtParent.Rows)
            {
                TreeNode child = new TreeNode
                {
                    Text = row["Name"].ToString(),
                    Value = row["Id"].ToString()
                };
                
                if (parentId == 0)
                {
                    TreeView1.Nodes.Add(child);
                    DataTable dtChild = addNotificationRepository.GetData("SELECT Id, Name FROM Event where sourceid="+child.Value);
                    PopulateTreeView(dtChild, int.Parse(child.Value), child);
                }
                else
                {
                    treeNode.ChildNodes.Add(child);
                }
            }
        }




        protected void AddNotificationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEvent.aspx");
        }
    }
}