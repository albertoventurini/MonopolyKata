using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyKata;
using Xunit;
using Xunit.Extensions;

namespace MonopolyKataTest
{
    public class DieTest
    {
        private Die _die;
        private const int _faceNumber = 6;

        public DieTest()
        {
            _die = new Die(_faceNumber);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(20)]
        public void FaceNumber_deve_restituire_il_valore_corretto(int faces)
        {
            Die myDie = new Die(faces);

            Assert.Equal(faces, myDie.Faces);
        }

        
        [Fact]
        public void Roll_deve_restituire_un_numero_tra_1_e_numerofacce()
        {
            int roll = _die.Roll();

            Assert.InRange(roll, 1, _die.Faces);
        }
    }
}
