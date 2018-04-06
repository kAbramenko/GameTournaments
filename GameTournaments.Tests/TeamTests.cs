using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTournaments.Tests
{
    [TestClass]
    public class TeamTests
    {
        [TestMethod]
        public void AddPlayerTest()
        {
            //arrange
            Player player = new Player("Kirill", "Abramenko", "DecadE", Convert.ToDateTime("12.08.1998"));
            Team team = new Team("Team1");

            //act
            team.AddPlayer(player);

            //assert
            Assert.IsTrue(team.Contains(player));
        }

        [TestMethod]
        public void TeamToStringTest()
        {
            //arrange
            Player player = new Player("Kirill", "Abramenko", "DecadE", Convert.ToDateTime("12.08.1998"));
            Player player2 = new Player("Kirill2", "Abramenko2", "DecadE2", Convert.ToDateTime("12.08.1998"));
            Team team = new Team("Team1");
            team.AddPlayer(player);
            team.AddPlayer(player2);
            string expected = "(DecadE, DecadE2)";

            //act 
            string actual = team.ToString();

            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
