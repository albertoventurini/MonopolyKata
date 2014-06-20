using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyKata;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace MonopolyKataTest
{
    public class PlayerTest
    {
        private Board _board;
        private Mock<IDiceService> _diceService; 
        private Player _player;

        public PlayerTest()
        {
            _board = new Board();
            _diceService = new Mock<IDiceService>();
            
            _player = new Player(_board, _diceService.Object, "");
        }

        [Fact]
        public void NewPlayer_deve_avere_posizione_iniziale_a_zero()
        {
            Player player = new Player(_board, _diceService.Object, "Nome giocatore");

            Assert.Equal(0, player.ActualPosition);
        }

        [Fact]
        public void Play_deve_avanzare_la_posizione_attuale_di_n()
        {
            _diceService.Setup(d => d.Roll()).Returns(39);
            _player.Play();

            Assert.Equal(39, _player.ActualPosition);

            _diceService.Setup(d => d.Roll()).Returns(6);
            _player.Play();

            Assert.Equal(5, _player.ActualPosition);
        }




        [Fact]
        public void Play_deve_tirare_i_dadi()
        {
            
        }

        [Fact]
        public void Play_deve_avanzare_la_posizione_attuale()
        {
            
        }
    }
}
