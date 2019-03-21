using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        public static List<UserRegData> urData;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (IsPostBack)
            {
                urData = new List<UserRegData>();
            }

        }

        protected void ConfirmRegistrationBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (ConfirmCheckbox.Checked )
                {
                    string firstName = FirstNameTextbox.Text;
                    string lastName = LastNameTextbox.Text;
                    string userName = UserNameTextbox.Text;
                    string emailAddress = EmailTextbox.Text;
                    string password = PasswordTextbox.Text;

                    urData.Add(new UserRegData(firstName, lastName, userName, emailAddress, password));
                    DisplayUserDataGrid.DataSource = urData;
                    DisplayUserDataGrid.DataBind();
                }
                else
                {
                    Message.Text = "You did not check the confirmation box! Please check and try again.";
                }
            }
        }
    }
}