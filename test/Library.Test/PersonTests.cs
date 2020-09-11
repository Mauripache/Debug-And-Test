using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void PersonWithValidId()
        {
            Person person = new Person("Test", "5.377.044-0");
            string name = "Test";
            string id = "5.377.044-0";
        }   

        [Test]
        public void PersonWithWrongVerifierDigit()
        {
            Person person = new Person("Test", "5.377.044-0");
        }
    }
}