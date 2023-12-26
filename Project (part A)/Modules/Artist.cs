using Project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Artist : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ArtStyle Style { get; set; }

        public Artist(int id, string firstName, string lastName, ArtStyle style)
        {
            throw new NotImplementedException();
        }
    }
}