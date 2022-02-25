using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteBackEnd;

namespace TesteMSTest
{
    [TestClass]
    public class TesteMSTeste
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange - Organizar
            double pNum = 1;
            double sNum = 1;

            // Act  - Agir
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verificar 
            Assert.AreEqual(2, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 1, 3)]
        [DataRow(1, 2, 3)]
        public void SomarDoisNumerosListas(double pNum, double sNum, double tNum)
        {
            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.AreEqual(tNum, resultado);
        }
    }
}
