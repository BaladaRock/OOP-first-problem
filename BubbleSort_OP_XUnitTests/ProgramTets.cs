using System;
using Xunit;
using BubbleSort_OP;
namespace BubbleSort_OP_XUnitTests
{
    public class ProgramTests
    {
        [Fact]
        public void Test_Get_Name()
        {
            string name = "RandomName";
            Player player = new Player(name);
            Assert.Equal(name, player.GetName());
        }

        [Fact]
        public void Test_Get_Score()
        {
            int score = 20;
            Player player = new Player("Zhang Jike", score);

            Assert.Equal(score, player.GetScore());
        }

        [Fact]
        public void Test_Set_Score()
        {
            int score = 20;
            Player player = new Player("Andreiut");
            player.SetScore(score);

            Assert.Equal(score, player.GetScore());
        }

      
    }
}
