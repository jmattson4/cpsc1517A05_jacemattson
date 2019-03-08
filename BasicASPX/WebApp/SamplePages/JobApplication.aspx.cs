using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApplication : System.Web.UI.Page
    {
        //this is a temporary storage area because we are not 
        //  currently using a database
        public static List<GridViewData> gvCollection;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (!Page.IsPostBack)
            {
                gvCollection = new List<GridViewData>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //assuming for this example, all data is valid - a real application would have validation
            string fullname = FullName.Text;
            string emailAddress = EmailAddress.Text;
            string phoneNumber = PhoneNumber.Text;
            string fullOrPartime = FullOrPartTime.SelectedValue;
            //when dealing with a checkbox list you can get multiple values so .SelectedValue will not work
            //  a foreach loop is more appropriate
            //the checkbox list a collection of items(rows)
            //  we can traverse a collection using a loop: foreach.
            //on each row of the collection, you can process its data
            string jobs = "";
            foreach (ListItem jobRow in Jobs.Items)
            {
                if (jobRow.Selected)
                {
                    jobs += jobRow.Text + " ";
                }
            }
            //place the data on the data collection
            gvCollection.Add(new GridViewData(fullname, emailAddress, phoneNumber, fullOrPartime, jobs));
            //display the collection of data
            // we would like to display the data in a tabular format
            //we will use the GridView control the display the tabular format
            JobApplicantList.DataSource = gvCollection;
            JobApplicantList.DataBind();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FullName.Text = "";
            EmailAddress.Text = "";
            PhoneNumber.Text = "";
            //FullOrPartTime.SelectedIndex = -1; either or will work
            FullOrPartTime.ClearSelection();
            Jobs.ClearSelection();
        }
    }
}