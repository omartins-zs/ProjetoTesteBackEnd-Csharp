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
    }
}
