using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort_OP
{
    public class Rankings
    {
        private Player[] players;

        public Rankings()
        {
            players = new Player[0];
        }

        public int GetPosition(string name)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].IsEqual(name))
                {
                    return i + 1;
                }
            }
            return 0;
        }


        public Player GetPlayer(int position)
        {
            return players[position];
        }

        public void AddPlayer(Player player)
        {
            Array.Resize(ref players, players.Length + 1);
            players[players.Length - 1] = player;
            SortPlayers(players);
        }

        void SortPlayers(Player[] players)
        {
            int lastPlayerPosition = players.Length - 1;
            for (int i = 0; i <=lastPlayerPosition; i++)
            {
                if (players[i].HasSmallerScore(players[lastPlayerPosition]))
                    SwapPlayers(ref players[i], ref players[lastPlayerPosition]);
            }
        }

        void SwapPlayers(ref Player firstPlayer, ref Player secondPlayer)
        {

            var temp = firstPlayer;
            firstPlayer = secondPlayer;
            secondPlayer = temp;

        }

        public void ReadMatch(string match)
        {
            string[] playersAndResult = match.Split(':');
            string[]score = playersAndResult[1].Split('-');
            
            string[] twoPlayers = playersAndResult[0].Split('-');
            int firstPlayerResult = Convert.ToInt32(score[0]);
            int secondPlayerResult = Convert.ToInt32(score[1]);
            
            if (firstPlayerResult > secondPlayerResult)
            {
               
                players[GetPosition(twoPlayers[0]) - 1].UpdateScore(3);
            }
                
            else
            {
                players[GetPosition(twoPlayers[1]) - 1].UpdateScore(3);
            }
                

            SortPlayers(players);
        }

    }
}
