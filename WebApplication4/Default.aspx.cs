using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Default : System.Web.UI.Page
    {
        public string login;
        public string password;

        public string lastLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Hello!");
            HttpCookie cookie = Request.Cookies["login_data"];
            if (cookie != null)
            {
                lastLogin = cookie["login"];
            }

            if (this.IsPostBack)
            {
                login = Request.Form["login"];
                password = Request.Form["password"];

                ind1Div.Visible = true;

                Label ind2Label = new Label();
                ind2Label.Text = "indicator 2";
                ind2Placeholder.Controls.Add(ind2Label);

                if (cookie == null)
                {
                    cookie = new HttpCookie("login_data");
                    cookie.Expires = DateTime.Now.AddYears(1);
                }

                cookie["login"] = login;
                Response.Cookies.Add(cookie);
            }
            else {
                ind1Div.Visible = false;
                ind2Placeholder.Controls.Clear();
            }
        }

        protected void remove_cookies_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["login_data"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(cookie);
            }
        }
    }
}