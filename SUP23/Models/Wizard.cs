using SUP23.Enums;
using SUP23.ViewModels;
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
    public class Wizard : BaseViewModel
    {
        public BloodStatus BloodStatus { get; set; }
        public Wizard(string firstname, string lastname, BloodStatus bloodStatus = BloodStatus.Fullblood)
        {
            Firstname = firstname;
            Lastname = lastname;
            BloodStatus = bloodStatus;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
       // public string Fullname => $"{Firstname} {Lastname}";

    }
}
