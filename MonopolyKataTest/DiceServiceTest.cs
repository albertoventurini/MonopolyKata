using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MonopolyKata;
using Moq;
using Xunit;

namespace MonopolyKataTest
{
    public class DiceServiceTest
    {
        private DiceService _diceService;
        private IList<IDie> _dice;
        private Mock<IDie> _first;
        private Mock<IDie> _second;

        public DiceServiceTest()
        {
            _first = new Mock<IDie>();
            _second = new Mock<IDie>();
            _dice = new List<IDie>() {_first.Object, _second.Object};
            _diceService = new DiceService(_dice);
        }

        [Fact]
        private void RollDice_deve_restituire_il_risultato_dei_due_dadi()
        {
            _first.Setup(f => f.Roll()).Returns(4);
            _second.Setup(f => f.Roll()).Returns(5);

            int roll = _diceService.Roll();

            Assert.Equal(9, roll);
        }
        
    }
}