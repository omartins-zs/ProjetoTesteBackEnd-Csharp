using ProjetoTesteBackEnd;
using System;
using Xunit;

namespace TesteXUnit
{
    public class TesteXUnit
    {
        [Fact]
        public void SubtrairDoisNumeros()

        {
            double pNum = 4;
            double sNum = 1;

            var resultado = Operacoes.Subtrair(pNum, sNum);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(5, 3, 2)]
        [InlineData(9, 5, 3)] // Errado
        public void SubtrairDoisNumerosTestes(double pNum, double sNum, double tNum)
        {
            var resultado = Operacoes.Subtrair(pNum, sNum);

            Assert.Equal(tNum, resultado);
        }
    }
}
