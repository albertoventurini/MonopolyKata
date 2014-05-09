using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyKata;
using Xunit;
using Xunit.Extensions;

namespace MonopolyKataTest
{

    public class BoardTest
    {
        private Board _board;

        public BoardTest()
        {
            _board = new Board();
        }

        [Fact]
        public void GetAllCells_deve_restuituire_40_celle()
        {
            Assert.Equal(40, _board.GetCellsCount);
        }

        [Theory]
        [InlineData(20, 10, 30)]
        [InlineData(35, 10, 5)]
        public void GetNewPosition_deve_restituire_la_posizione_finale(int posIniziale, int avanzamento, int posFinale)
        {
            int newPosition = _board.GetnewPosition(posIniziale, avanzamento);

            Assert.Equal(posFinale, newPosition);
        }


}
}
