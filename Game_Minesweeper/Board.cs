using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Minesweeper
{
    public class Board
    {
        /// <summary>
        /// Numbers of rows in the Board.
        /// </summary>
        public int row;

        /// <summary>
        /// Number of columns in the Board.
        /// </summary>
        public int col;

        /// <summary>
        /// Count of mines in the Board.
        /// </summary>
        public int mines;

        /// <summary>
        /// The cells in the board.
        /// </summary>
        public Cell cell;
    }
}
