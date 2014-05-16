using System;

namespace MonopolyKata
{
    public interface IBoard
    {
        Int32 GetCellsCount { get; }
        int GetnewPosition(int posIniziale, int avanzamento);
        
    }

    public class Board : IBoard
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