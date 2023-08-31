using System;

namespace SUP23.Models
{
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
}
