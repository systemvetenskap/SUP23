using SUP23.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SUP23.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        // viktigt.
        // Det måste vara properties 
        public string FirstName { get; set; }
        public MainViewModel()
        {
            IHaveId haveId = new Computer();
            IEnumerable<IHaveId> objectsWithIds = new List<IHaveId>();
            Player player = new Human();
            player.Name = FirstName;
            player.GetScore();
        }
     
    }
}
