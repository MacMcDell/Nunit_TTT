using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using GameWinnerService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameWinnerService = GameWinnerService.GameWinner;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TTT
{

    [TestFixture]
    public class NUnitTests
    {
        private const char expected = 'X';
        private IGameWinner _gameWinner;
        private char[,] gameboard;
        private const char blank = ' ';
        public char[,] Board { get; set; }


        [TestFixtureSetUp]
        public void setup()
        {
            _gameWinner = new GameWinner();

        }



        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n/d);
        }


        [Test, TestCaseSource("WinningGameboards")]
        public void TestDiagonal(char[,] b)
        {
            var result = _gameWinner.Validate(b);
            Assert.AreEqual(expected, result);
        }

  
        private static readonly char[][,] WinningGameboards =
        {
           new char[3, 3]{
                {blank,blank,expected},
                {blank,expected,blank},
                {expected,blank,blank}
            }, new char[3, 3]{
                {expected,blank,blank},
                {blank,expected,blank},
                {blank,blank,expected}
            }, new char[3, 3]{
                {expected,expected,expected},
                {blank,blank,blank},
                {blank,blank,blank}
            }

        };

        //public IEnumerable<char[,]> Boards
        //{
        //    get
        //    {
        //      //  Setup();
        //        yield return new TestCaseData(gameboard,  Char[3, 3]
        //        {
        //            {blank, expected, expected},
        //            {expected, expected, expected},
        //            {blank, blank, blank}
        //        });
          
        //    }
        //}
    }
}
