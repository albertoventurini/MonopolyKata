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
            _game = new Game(_diceService.Object, _board.Object);
        }

        [Fact]
        public void Add_deve_aggiungere_un_giocatore_al_gioco()
        {
            _game.Add("Giocatore1");

            Assert.Equal(1, _game.PlayerNumber);
            Assert.Equal("Giocatore1", _game.PlayerNames[0]);
        }

        [Fact]
        public void Start_con_un_giocatore_fallisce()
        {
            _game.Add("Giocatore1");

            _game.Start();

            Assert.False(_game.Running);
        }

        [Fact]
        public void Start_con_due_giocatori_va()
        {
            _game.Add("Giocatore1");
            _game.Add("Giocatore2");

            _game.Start();

            Assert.True(_game.Running);
        }

        [Fact]
        public void Start_con_nove_giocatori_non_va()
        {
            for(int i = 0; i < 9; i++)
                _game.Add("Giocatore");

            _game.Start();

            Assert.False(_game.Running);
        }
        

     
    }
}