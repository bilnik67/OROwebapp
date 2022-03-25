using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OROApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Achternaam { get; set; }
        public string Bestelling { get; set; }
        public string Datum { get; set; }

    }
}
