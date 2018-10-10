using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp_2
{
    public partial class Default : System.Web.UI.Page
    {
        //1
        //public static int countStatic;
        //public int count;
        //2
        public int count;

        public IQueryable<dynamic> items;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Object countObject = Session["count"];
            //1
            //Object countObject = ViewState["count"];
            //2
            //Object countObject = Application["count"];
            /*if (countObject != null)
            {
                count = (int)countObject;
            }*/

            //3 parameter
            String countObject = Request.Params["count"];
            if (countObject != null)
            {
                count = Int32.Parse(countObject);
            }

            items =
                Globals.items.Select(item => new { id = item.id, title = item.title }).AsQueryable();
            itemsListView.DataSource = items;
            itemsListView.DataBind();
        }

        protected void countButton_Click(object sender, EventArgs e)
        {

            //1
            //Object countObject = ViewState["count"];
            //2
            /*Application.Lock();
                Object countObject = Application["count"];
                if (countObject != null)
                {
                    count = (int)countObject;
                }
                count++;
                Application["count"] = count;
            Application.UnLock();*/

            //3  parameter
            String countObject = Request.Params["count"];
            if (countObject != null)
            {
                //count = (int)countObject;
                count = Int32.Parse(countObject);
            }
            count++;
            Response.Redirect("~/Default.aspx?count=" + count);
        }
    }
}