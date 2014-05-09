using System;

namespace MonopolyKata
{
    public class Board
    {
        private int _cellsNumber;

        public Board()
        {
            _cellsNumber = 40;
        }

        public Int32 GetCellsCount { get { return _cellsNumber; } }

        public int GetnewPosition(int posIniziale, int avanzamento)
        {
            return (posIniziale + avanzamento)%_cellsNumber;
        }
    }
}