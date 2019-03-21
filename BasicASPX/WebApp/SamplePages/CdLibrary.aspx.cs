using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class CdLibrary : System.Web.UI.Page
    {
        public static List<CdLibData> cdData;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (IsPostBack)
            {
                cdData = new List<CdLibData>();
            }
        }

        protected void AddToLibraryBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string title = TitleTextbox.Text;
                string artist = ArtistTextbox.Text;
                string year = YearTextbox.Text;
                string numberOfTracks = NumberOfTracksTextbox.Text;

                cdData.Add(new CdLibData(title, artist, year, numberOfTracks));
                LibraryGridView.DataSource = cdData;
                LibraryGridView.DataBind();
            }
            else
            {
                Message.Text = "Invalid data please try again.";
            }
        }
    }
}