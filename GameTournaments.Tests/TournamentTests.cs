using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTournaments.Tests
{
    [TestClass]
    public class TournamentTests
    {
        [TestMethod]
        public void AddTeamTest()
        {
            //arrange
            Tournament tour = new Tournament("Tour1", 100);
            Team team = new Team("Team1");
            
            //act
            tour.AddTeam(team);

            //assert
            Assert.IsTrue(tour.Contains(team));
        }
        [TestMethod]
        public void TournamentTeamsToStringTest()
        {
            //arrange
            Tournament tour = new Tournament("Tour1", 100);
            Team team = new Team("Team1");
            Team team2 = new Team("Team2");
            tour.AddTeam(team);
            tour.AddTeam(team2);
            string exception = "Teams list: 1Team1\n2Team2\n";
            //act
            string actual = tour.TeamsToString();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestMethod]
        public void TournamentToStringTest()
        {
            //arrange
            Tournament tour = new Tournament("Tour1", 100, 0);
            Team team = new Team("Team1");
            Team team2 = new Team("Team2");
            tour.AddTeam(team);
            tour.AddTeam(team2);
            string exception = "Tournament name: Tour1\nPrize pool:100$\nGame discipline:Dota\nTeams list: Team1 (В команде отсутствуют игроки), Team2 (В команде отсутствуют игроки).";
            //act
            string actual = tour.ToString();
            //assert
            Assert.AreEqual(exception, actual);
        }
    }
}
