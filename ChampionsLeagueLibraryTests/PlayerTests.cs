using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChampionsLeagueLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static ChampionsLeagueLibrary.Tests.TestUtils;

namespace ChampionsLeagueLibrary.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        private Type? playerType;

        [TestInitialize]
        public void InitializeType()
        {
            playerType = typeof(FootballClub).Assembly.GetType("ChampionsLeagueLibrary.Player");

            Assert.IsNotNull(playerType);
        }

        [TestMethod()]
        public void NamePropertyTest()
        {
            dynamic? player = New(playerType, "Peter", FootballClub.RealMadrid, 123);
            Assert.AreEqual("Peter", player?.Name);
        }


        [TestMethod()]
        public void ClubPropertyTest()
        {
            dynamic? player = New(playerType, "Peter", FootballClub.RealMadrid, 123);
            Assert.AreEqual(FootballClub.RealMadrid, player?.Club);
        }

        [TestMethod()]
        public void GoalCountPropertyTest()
        {
            dynamic? player = New(playerType, "Peter", FootballClub.RealMadrid, 123);
            Assert.AreEqual(123, player?.GoalCount);
        }
    }
}