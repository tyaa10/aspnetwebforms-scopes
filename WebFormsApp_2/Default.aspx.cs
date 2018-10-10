using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Object countObject = Session["count"];
            if (countObject != null)
            {
                count = (int)countObject;
            }
        }

        protected void countButton_Click(object sender, EventArgs e)
        {
            //countStatic++;
            //count++;
            Object countObject = Session["count"];
            if (countObject != null)
            {
                count = (int)countObject;
            }
            count++;
            Session["count"] = count;
        }
    }
}