using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp_2
{
    public partial class Details : System.Web.UI.Page
    {
        public string title;
        public string author;
        public string details;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.Params["id"]);
            dynamic itemModel =
                Globals.items.Where(item => item.id == id).FirstOrDefault();
            title = itemModel.title;
            author = itemModel.author;
            details = itemModel.details;
        }
    }
}