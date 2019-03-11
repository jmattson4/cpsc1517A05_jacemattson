using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        //RequiredField  - ensures that the user has not skipped the field.
        //RangeValidator - checks that the users entry is within a lower is within a 
        //                 lower range of Numbers OR Characters
        //RegularExpression - Checks that the users entry matches a pattern defined by a regular 
        //                    expression
        //CompareValidatior - 1) datatype check 
        //                    2) check an entered value against a constant value
        //                    3) check an entered value A against an entered Value B
        //CustomValidator - this calls a user method on your webserver
        public static List<ContestEntryData> ceData;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (IsPostBack)
            {
                ceData = new List<ContestEntryData>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //this test will determine if the fields on the page are valid
                //  before entering them in as data, this test fires the validation
                //  controls on the server side
                //If additional validation is required then do that first
                if (Terms.Checked)
                {
                    //user has agreed to the contest terms
                    //  collect the data, then create/load a contest entry
                    //  to the collection, then display the collection
                    string firstName = FirstName.Text;
                    string lastName = LastName.Text;
                    string streetAddress1 = StreetAddress1.Text;
                    string streetAddress2 = StreetAddress2.Text;
                    string city = City.Text;
                    string province = Province.SelectedValue;
                    string postalCode = PostalCode.Text;
                    string email = EmailAddress.Text;


                    ceData.Add(new ContestEntryData(firstName, lastName, streetAddress1, streetAddress2, city, province, postalCode, email));
                    ContestEntryGrid.DataSource = ceData;
                    ContestEntryGrid.DataBind();
                }
                else
                {
                    Message.Text = "You did not agree to the contest terms. Your entry is denied.";
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.ClearSelection();
            PostalCode.Text = "";
            EmailAddress.Text = "";
            CheckAnswer.Text = "";
            Terms.Checked = false;
        }
    }
}