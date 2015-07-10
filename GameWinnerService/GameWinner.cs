using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWinnerService
{
    public class GameWinner : IGameWinner
    {
        private const char blank = ' ';
        char col1, col2, col3 = blank;
        public char Validate(char[,] gameBoard)
        {
            var result = LookForHorizontalWins(gameBoard);
            if (result != blank)
                return result;

             result = LookForVerticalWins(gameBoard);
            if (result != blank)
                return result;
            
            result = LookForDiagonalWins(gameBoard);
            if (result != blank)
                return result;
            return blank;

        }

        private char LookForDiagonalWins(char[,] gameBoard)
        {
            var chartoEval = gameBoard[1, 1];
            var leftleaningWin = new[] {gameBoard[0, 0], gameBoard[1, 1], gameBoard[2, 2]}.All(x => x == chartoEval);
            var rightleaningWin = new[] {gameBoard[2, 0], gameBoard[1, 1], gameBoard[0, 2]}.All(x => x == chartoEval);
            if (leftleaningWin || rightleaningWin)
                return chartoEval;
            
            return blank;
        }

        private char LookForHorizontalWins(char[,] gameBoard)
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                col1 = gameBoard[i, 0];
                col2 = gameBoard[i, 1];
                col3 = gameBoard[i, 2];
                if (col1 == col2 && col2 == col3)
                    return col1;

            }
            return blank;
        }
        private char LookForVerticalWins(char[,] gameBoard)
        {

          for (int i = 0; i < gameBoard.GetLength(1); i++)
            {
                col1 = gameBoard[0, i];
                col2 = gameBoard[1, i];
                col3 = gameBoard[2, i];
                if (col1 == col2 && col2 == col3)
                    return col1;

            }
            return blank;
        }
    }
}
