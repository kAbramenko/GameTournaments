using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTournaments.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerToStringTest()
        {
            //arrange
            Player player = new Player("Kirill", "Abramenko", "DecadE", Convert.ToDateTime("12.08.1998"));
            string expected = "Имя: Kirill\nФамилия: Abramenko\nНикнейм: DecadE\nВозраст: 20\nКоманда: нет\n";

            //act
            string actual = player.ToString();
            //assert

            Assert.AreEqual(expected, actual);
        }

    }
}
