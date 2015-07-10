using System;
using GameWinnerService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameWinnerService = GameWinnerService.GameWinner;

namespace TTT
{
    [TestClass]
    public class ValidateTests
    {
        private IGameWinner _gameWinner;
        private char[, ] _gameboard;
        private char blank = ' ' ;
       
        [TestInitialize]
        public void Setup()
        {
            _gameWinner = new GameWinner();
             _gameboard = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}


            };
        }

        [TestMethod]
        public void NoPlayerHasThreeInaRow()
        {

            const char expected = ' ';
        
            var actual = _gameWinner.Validate(_gameboard);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PlayHasThreeItemsHorizontally()
        {
            const char expected = 'X';
            _gameboard = new char[3,3]{
                {blank,expected,expected},
                {expected,expected,expected},
                {blank,blank,blank}
            };

            var actual = _gameWinner.Validate(_gameboard);

            Assert.AreEqual(expected,actual);
        }
        
        [TestMethod]
        public void PlayHasThreeItemsVertically()
        {
            const char expected = 'X';
            _gameboard = new char[3,3]{
                {blank,expected,expected},
                {expected,expected,blank},
                {blank,expected,blank}
            };

            var actual = _gameWinner.Validate(_gameboard);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void PlayHasThreeItemsDiagonally()
        {
            const char expected = 'X';
            _gameboard = new char[3, 3]{
                {blank,blank,expected},
                {blank,expected,blank},
                {expected,blank,blank}
            };

            var actual = _gameWinner.Validate(_gameboard);

            Assert.AreEqual(expected, actual);
        }

     
    }
}





