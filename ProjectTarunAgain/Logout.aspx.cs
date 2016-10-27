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
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //store session info and authentication methods in the authentication objects
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            //perform signout
            authenticationManager.SignOut();

            //Redirect to Login.aspx
            Response.Redirect("~/login.aspx");
        }
    }
}