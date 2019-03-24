using System;

namespace BubbleSort_OP
{
    public class Competition
    {
        private readonly Rankings rankings = new Rankings(16);
        //optional, am ales nr 16
        public Competition()
        {
        }

        public void Match(Player firstPlayer, Player secondPlayer, int firstPlayerScore, int secondPlayerScore)
        {
            if (firstPlayerScore > secondPlayerScore)
            {
                rankings.UpdateScore(firstPlayer, 3);
            }
            else 
            {
                rankings.UpdateScore(secondPlayer, 3);
            }
            
            
        }
        //adaugam, in functie de meciul jucat, 3 puncte castigatorului
        

    }

    public class Rankings
    {
        private Player[] players;
        private int index;
        private int size;

        public Rankings(int numberOfPlayers)
        {
            players = new Player[numberOfPlayers];
            size = numberOfPlayers;
            index = 0;
        }

        public Player[] GetPlayers()
        {
            return players;
        }

        public void AddPlayer(Player player)
        {
            if (index < size)
            {
                players[index] = player;
                index++;
            }
        }
        //introducem jucatorii in clasament

        public void UpdateScore(Player player, int addedPoints)
        {
            foreach (var person in players)
            {
                if (player.GetName() == person.GetName())
                    person.SetScore(person.GetScore() + addedPoints);
            }
        }
        //dupa un meci jucat, updatam scorul, adaugand scorului vechi al castigatorului, un punctaj
    }

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

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }
        /*am construit 2 constructori, unul ce permite introducerea 
        numelui, fara niciun scor(caz in care se acesta se seteaza direct la 0)
           3 metode, pentru lucrul cu datele care ne intereseaza. SetScore() va atribui un scor pt un anumit jucator
         */
    }

    public class Program
    {
        static void Main(string[] args)
        {


            Rankings rankings = new Rankings(2);
            rankings.AddPlayer(new Player("bere"));
            rankings.AddPlayer(new Player("Andrei", 20));
            //exemplu de creare de lista de jucatori



            Console.ReadKey();
        }

    }
}
