using SUP23.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUP23.Models
{
    public abstract class Player : BaseViewModel, IHaveId
    {
        public string Name { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// Return current player score
        /// </summary>
        /// <returns>curren score</returns>
        public virtual int GetScore() 
        { 
            return 0; 
        }

        public abstract void SetPlayerName(string name);
    }
}
