using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUP23.Models
{
    /// <summary>
    /// Wizard with magic skills
    /// </summary>
    public class Wizard
    {
        public Wizard(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
       // public string Fullname => $"{Firstname} {Lastname}";

    }
}
