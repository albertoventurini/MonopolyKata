using System.Security.Cryptography.X509Certificates;
using MonopolyKata;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace MonopolyKataTest
{
    public class GameTest
    {
        private Mock<IBoard> _board; 
        private Mock<IDiceService> _diceService;
        private IGame _game;

        public GameTest()
        {

            _board = new Mock<IBoard>();
            _diceService = new Mock<IDiceService>();
            _game = new Game(10, _diceService.Object, _board.Object);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        public void PlayerNumber_deve_restituire_il_numero_di_giocatori(int playerNumber)
        {
            var game = new Game(playerNumber, _diceService.Object, _board.Object);
            
            Assert.Equal(playerNumber, game.PlayerNumber);
        }

        
        

     
    }
}