using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Painting : IPrintable
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public Painting(Artist artist, string title, int year)
        {
            throw new NotImplementedException();
        }

        public string PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}