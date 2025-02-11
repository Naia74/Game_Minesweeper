using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Minesweeper
{
    public class Cell
    {
        /// <summary>
        /// If the cell is a mine.
        /// </summary>
        public bool isMine;

        /// <summary>
        /// If the cell is revealed.
        /// </summary>
        public bool isRevealed;

        /// <summary>
        /// If the cell is flagged.
        /// </summary>
        public bool isFlagged;

        /// <summary>
        /// If nearby cells are mines.
        /// </summary>
        public int nearByMines;

        
        //public bool mine()
        //{
        //    return 
        //}

        //public bool revealed()
        //{
        //    return
        //}

        //public bool toggledFlag()
        //{
        //    return 
        //}

        //public int getNearbyMines()
        //{
        //    return 
        //}

    }
}
