using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class TunicaCueroTest
    {

        private TunicaCuero tunicaCuero;
        [SetUp]
        public void Setup()
        {
            this.tunicaCuero = new TunicaCuero(0,30);
        }

        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueValido()
        {
            this.tunicaCuero.Ataque = 10;
            Assert.AreEqual(this.tunicaCuero.Ataque, 10);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.tunicaCuero.Ataque = -10;
            Assert.AreEqual(this.tunicaCuero.Ataque, 0);
        }
        /*
            Es necesario probar la asignacion de una defensa valida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaValida()
        {
            this.tunicaCuero.Defensa = 50;
            Assert.AreEqual(this.tunicaCuero.Defensa, 50);
        }
        /*
            Es necesario probar la asignacion de una defensa invalida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.tunicaCuero.Defensa = -30;
            Assert.AreEqual(this.tunicaCuero.Defensa, 0);
        }
    }


}