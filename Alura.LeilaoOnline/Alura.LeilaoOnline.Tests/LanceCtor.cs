using Alura.LeilaoOnline.Core;
using System;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Arrange
            var valorNegativo = -100;

            //Assert
            var excecaoCapturada = Assert.Throws<ArgumentException>(
                //Act
                () => new Lance(null, valorNegativo)
            );

            var msgEsperada = "Lance inválido: valor deve ser maior que zero.";

            //Assert
            Assert.Equal(msgEsperada, excecaoCapturada.Message);
        }
    }
}
