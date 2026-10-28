using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }

            if (chkTerms.Checked)
            {
                lblOutput.Text = "Student Name: " + txtName.Text + "<br/>Gender: " +
                    gender + "<br/>Course: " + ddlCourse.SelectedValue +
                    "<br/>Date: " + calDOB.SelectedDate.ToShortDateString();
            }
            else
            {
                lblOutput.Text = "Please accept terms & conditions";
            }
        }
    }
}
