using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort_OP
{

    public class Player
    {
        private readonly string name;
        private int score;

        public Player(string name)
        {
            this.name = name;
            score = 0;
        }

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public bool IsEqual(string name)
        {
            return string.Equals(this.name, name, StringComparison.CurrentCultureIgnoreCase);
        }

        public bool HasSmallerScore(Player other)
        {
            
            return (other.score > score);
        }

        public void UpdateScore(int addPoints)
        {
            score += addPoints;
        }
    }

}
