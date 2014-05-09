using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace MonopolyKataTest
{
    public class PlayerTest
    {
        private Player _player;

        public PlayerTest()
        {
            _player = new Player();
        }

        [Fact]
        public void NewPlayer_deve_avere_posizione_iniziale_a_zero()
        {
            Player player = new Player();

            Assert.Equal(0, player.ActualPosition);
        }

        [Fact]
        public void Advance_deve_avanzare_la_posizione_attuale_di_n()
        {
            _player.Advance(10);

            Assert.Equal(10, _player.ActualPosition);

            _player.Advance(7);

            Assert.Equal(17, _player.ActualPosition);
        }
    }

    public class Player
    {
        public int ActualPosition { get; private set; }

        public Player()
        {

        }

        public void Advance(int delta)
        {
            ActualPosition += delta;
        }
    }
}
