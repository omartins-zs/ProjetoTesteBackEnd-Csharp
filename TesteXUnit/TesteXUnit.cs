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
    }
}
