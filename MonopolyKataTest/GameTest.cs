using System.Security.Cryptography.X509Certificates;
using MonopolyKata;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace MonopolyKataTest
{
    public class GameTest
    {
        private Mock<IDiceService> _diceService;
        private Game _game;

        public GameTest()
        {
            _game = new Game(10, _diceService.Object);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        public void PlayerNumber_deve_restituire_il_numero_di_giocatori(int playerNumber)
        {
            var game = new Game(playerNumber, _diceService.Object);
            
            Assert.Equal(playerNumber, game.PlayerNumber);
        }

        //TODO : test per l'inizio random

     
    }
}