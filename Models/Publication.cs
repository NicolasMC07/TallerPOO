using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShopPOO.Models
{
    public class Publication
    {

        public string Title { get; set; }

        public DateTime PublicationYear { get; set; }

        public Publication(string title, DateTime publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
    }
}