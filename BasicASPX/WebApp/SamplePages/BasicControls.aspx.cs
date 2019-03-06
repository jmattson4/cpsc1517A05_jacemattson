using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //create static List<T> that will hang around between
        //  postings of the web page.
        //This could also have been done using a ViewState variable
        //Using a ViewState variable would require the user to retrieve 
        //  the data on each posting
        public static List<DDLClass> DataCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Page_Load executes each and every time there is a posting
            //  to this page.
            //Page_Load is executed before any submit events

            //this method is an excellent place to do form initilizition
            //You can Test your postings using Page.IsPostBack
            //IsPostBack is the same item as IsPost in Razor Forms

            if (!Page.IsPostBack)
            {
                //this code will be executed only on the first pass
                // to this page

                //create an instance for the static data collection
                DataCollection = new List<DDLClass>();
                //add instances to this collection using the DDLClass 
                //  greedy constructor
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(3, "DMIT2018"));
                DataCollection.Add(new DDLClass(4, "DMIT1508"));
                //sorting a List<T>
                //use the .Sort() method
                //(x,y) this represents any two items in your list
                //compare x.Field to y.Field; ascending
                //Compare y.Field to x.Field; descending
                //=> lambda symbol. Think of it as Do the Following
                DataCollection.Sort((x,y) => x.DisplayField.CompareTo(y.DisplayField));
                //Put the data collection into the dropdownlist
                //a) assign the collection to the controls DataSource
                CollectionList.DataSource = DataCollection;
                //b) assign the field names to the properties of the 
                //  dropdownlist for data association
                //DataValueField represents the value of the item
                //DataTextField represents the display of the line item
                CollectionList.DataValueField = "ValueField";
                CollectionList.DataTextField = nameof(DDLClass.DisplayField);
                //c) bind the data to the web control
                //NOTE: This Statement is NOT required in a Windows Form Application
                CollectionList.DataBind();
                //Can one put a prompt on their dropdownlist control?
                //  Obvs, Yes.
                CollectionList.Items.Insert(0, "Select...");
            }
        }

        protected void SubmitButtonChoice_Click(object sender, EventArgs e)
        {
            //to grab the contents of a control will depend on the access 
            // technique of the control
            //for a textbox label, literal use .text
            //for lists such as a radiobuttonlist or dropdownlistyou may use 
            // a) .SelectedValue -> associated data value field
            // b) .SelectedIndex -> the physical index position in the list
            // c) .SelecetedItem -> associated data display field
            //for a checkbox use .Checked (true or false)

            //for the most part, all data from a control returns as 
            //  a string except for boolean type controls

            string submitChoice = TextBoxNumberChoice.Text;
            int anum = 0;
            if (string.IsNullOrEmpty(submitChoice))
            {
                MessageLabel.Text = "Enter a number from 1-4";
            }
            else if(!int.TryParse(submitChoice, out anum))
            {
                MessageLabel.Text = "Entered value must be a number";
            }
            else if (anum > 4 || anum < 1)
            {
                MessageLabel.Text = "Entered value must be a number from 1 - 4";
            }
            else
            {
                //when positioning in a list it is BEST to position
                //  using the SelectedValue unless you wish to position
                //  in a specific physical location such as your prompt
                //  line, then use SelectedIndex.

                //SelectedValue expects a string value
                //SelectedIndex expects a numeric value
                RadioButtonListChoice.SelectedValue = submitChoice;

                //boolean controls are set using true or false
                if (submitChoice.Equals("2") || submitChoice.Equals("3"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                CollectionList.SelectedValue = submitChoice;
                //display label will show the various values
                //  obtained from a list using SelectedValue, 
                //  SelectedIndex and SelectedItem
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text +
                    " at index " + CollectionList.SelectedIndex +
                    " has a value of " + CollectionList.SelectedValue;
                MessageLabel.Text = "Successful Process";
            }
        }

        protected void CollectionButton_Click(object sender, EventArgs e)
        {
            string submitChoice = CollectionList.SelectedValue;

            TextBoxNumberChoice.Text = submitChoice;
            if (submitChoice.Equals("Select..."))
            {
                MessageLabel.Text = "Sorry that isnt a proper choice.";
            }
            else
            {
                RadioButtonListChoice.SelectedValue = submitChoice;
                if (submitChoice.Equals("2") || submitChoice.Equals("3"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text +
                            " at index " + CollectionList.SelectedIndex +
                            " has a value of " + CollectionList.SelectedValue;
                MessageLabel.Text = "Successful Process";
            }
        }
    }
}