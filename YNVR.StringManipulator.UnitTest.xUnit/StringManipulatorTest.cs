using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YNVR.StringManipulator.UnitTest.xUnit
{
    public class StringManipulatorTest
    {
    
        private readonly StringManipulator _stringManipulator;

        public StringManipulatorTest()
        {
            _stringManipulator = new StringManipulator();
        }

        [Fact]
        public void ReverseString_InputIsHello_ShouldReturnOlleh()
        {

            var input = "Hola";

            var result = _stringManipulator.ReverseString(input);


            Assert.Equal("aloH", result);
        }

        [Fact]
        public void RemoveSpaces_InputHasSpaces_ShouldRemoveAllSpaces()
        {

            var input = "H o l a";


            var result = _stringManipulator.RemoveSpaces(input);


            Assert.Equal("Hola", result);
        }
    }
}

