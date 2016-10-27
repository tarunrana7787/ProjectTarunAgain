using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//required using statements
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace ProjectTarunAgain
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    //show the UserNavbar area
                    UserNavigation.Visible = true;
                    PublicNavigation.Visible = false;
                }
                else
                {
                    //only show PublicNavbar
                    UserNavigation.Visible = false;
                    PublicNavigation.Visible = true;
                }
                this.SetActivePage();
            }
        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "default":
                    home_public.Attributes.Add("class", "active");
                    break;

                case "login":
                    login_public.Attributes.Add("class", "active");
                    break;

                case "register":
                    register_public.Attributes.Add("class", "active");
                    break;

                case "logout":
                    logout_user.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}