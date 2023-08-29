using SUP23.ViewModels;
using System;
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

    public class Human : Player
    {
        public override int GetScore()
        {
            return base.GetScore();
        }

        public override void SetPlayerName(string name)
        {
            throw new NotImplementedException();
        }
    }
    public class Computer : Player
    {
        public override void SetPlayerName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Card : IHaveId
    {
        public int Id { get; set; }
    }

    public interface IHaveId
    {
        int Id { get; set; }
    }
}
