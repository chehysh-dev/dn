using System;
using System.Web;

namespace CookieApplication
{
    public partial class CookieDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Session Cookie (No expiration date set; deleted when browser closes)
            HttpCookie sessionCookie = new HttpCookie("SessionUser");
            sessionCookie.Value = txtName.Text;
            Response.Cookies.Add(sessionCookie);

            // Persistent Cookie (Expires in 7 days; persisted on client disk)
            HttpCookie persistentCookie = new HttpCookie("PersistentUser");
            persistentCookie.Value = txtName.Text;
            persistentCookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(persistentCookie);

            lblOutput.Text = "Cookies Saved Successfully";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string sessionData = (Request.Cookies["SessionUser"] != null)
                ? Request.Cookies["SessionUser"].Value
                : "No Session Cookie Found";

            string persistentData = (Request.Cookies["PersistentUser"] != null)
                ? Request.Cookies["PersistentUser"].Value
                : "No Persistent Cookie Found";

            lblOutput.Text = "Session Cookie: " + sessionData +
                             "<br/>Persistent Cookie: " + persistentData;
        }
    }
}
