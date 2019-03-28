using BubbleSort_OP;
using Xunit;

namespace Player_Tests
{
    public class RankingFacts
    {
        [Fact]
        public void AddPlayer_SimpleCase()
        {
            var ranking = new Rankings();
            ranking.AddPlayer(new Player("Andrei"));
            Assert.Equal(1, ranking.GetPosition("Andrei"));
        }

        [Fact]
        public void AddPlayer_WorksWithTwoPlayers()
        {
            var ranking = new Rankings();
            ranking.AddPlayer(new Player("A"));
            ranking.AddPlayer(new Player("B"));
            Assert.Equal(2, ranking.GetPosition("B"));
        }

        [Fact]
        public void GetPositionReturnsZeroWhenPlayerDoesNotExist()
        {
            var ranking = new Rankings();
            ranking.AddPlayer(new Player("A"));
            Assert.Equal(0, ranking.GetPosition("C"));
        }

        [Fact]
        public void GetPositionIsCaseInsensitive()
        {
            var ranking = new Rankings();
            ranking.AddPlayer(new Player("A"));
            Assert.Equal(1, ranking.GetPosition("a"));
        }

        [Fact]
        public void GetPlayerWhenGivenPosition()
        {
            var player = new Player("A");
            var ranking = new Rankings();
            ranking.AddPlayer(player);
            Assert.Equal(player,ranking.GetPlayer(0));
        }

        [Fact]
        public void GetPlayerWhenArrayHasMorePlayers()
        {
            var firstPlayer = new Player("A");
            var secondPlayer = new Player("B");
            var ranking = new Rankings();
            ranking.AddPlayer(firstPlayer);
            ranking.AddPlayer(secondPlayer);
            Assert.Equal(secondPlayer, ranking.GetPlayer(1));
        }

        [Fact]
        public void SortRankings_ArrayHasTwoPlayers()
        {
            var player = new Player("Ionescu",3);
            var newPlayer = new Player("Andrei", 6);
            Rankings ranking = new Rankings();
            ranking.AddPlayer(player);
            ranking.AddPlayer(newPlayer);
            Assert.Equal(1, ranking.GetPosition("Andrei"));
        }


        [Fact]
        public void SortRankings_ArrayHasMorePlayers()
        {
            var firstPlayer = new Player("Ionescu", 5);
            var secondPlayer = new Player("Andrei", 15);
            var thirdPlayer = new Player("Alexandru", 7);
            var forthPlayer = new Player("Ma Long", 25);
            var newPlayer = new Player("Timo Boll", 8);
            Rankings ranking = new Rankings();
            ranking.AddPlayer(firstPlayer);
            ranking.AddPlayer(secondPlayer);
            ranking.AddPlayer(thirdPlayer);
            ranking.AddPlayer(forthPlayer);
            ranking.AddPlayer(newPlayer);
            Assert.Equal(3, ranking.GetPosition("Timo Boll"));
        }

        [Fact]
        public void UpdateScore_OneMatch()
        {
            var player = new Player("Ionescu", 4);
            var newPlayer = new Player("Andrei", 6);
            Rankings ranking = new Rankings();
            ranking.AddPlayer(player);
            ranking.AddPlayer(newPlayer);
            ranking.ReadMatch("Ionescu-Andrei: 11-8");
            Assert.Equal(2, ranking.GetPosition("Andrei"));
        }

    }
}
