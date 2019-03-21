using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class CdLibData
    {
        string Title { get; set; }
        string Artist { get; set; }
        string Year { get; set; }
        string NumberOfTracks { get; set; }
        
        public CdLibData ()
        {

        }
        public CdLibData(string title, string artist, string year, string numberOfTracks)
        {
            Title = title;
            Artist = artist;
            Year = year;
            NumberOfTracks = numberOfTracks;
        }

    }
}