using MonopolyKata;
using Xunit;

namespace MonopolyKataTest
{
    public class PlayersServiceTest
    {

        private PlayersService _service;

        public PlayersServiceTest()
        {
            _service = new PlayersService();
        }

        [Fact]
        public void Create_deve_creare_il_servizio_con_n_players()
        {
            _service.Create(5);

            Assert.Equal(5, _service.PlayerNumber);
        }

        [Fact]
        public void Next_deve_restituire_il_prossimo_giocatore()
        {
            
        }
    }
}