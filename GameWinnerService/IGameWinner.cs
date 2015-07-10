using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWinnerService
{
    public interface IGameWinner
    {
        char Validate(char[,] gameBoard);
    }
}
