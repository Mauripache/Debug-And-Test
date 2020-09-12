using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            this.person = new Person("Mauricio", "5.377.044-0");
        }

        [Test]
        public void AssignValidId()
        {
            person.ID = "2.750.720-5";
            Assert.AreEqual(person.ID, "2.750.720-5");
        }   

        [Test]
        public void AssignIdWrongVerifierDigit()
        {
            person.ID = "2.750.720-7";
            Assert.AreEqual(person.ID, "5.377.044-0");
        }

        [Test]
        public void AssignNameValid()
        {
            person.Name= "Santiago";
            Assert.AreEqual(person.Name, "Santiago");
        }

        [Test]
        public void AssignNameInvalid()
        {
            person.Name = "";
            Assert.AreEqual(person.Name, "Mauricio");
        }

        [Test]
        public void AssignIdWrongFormat()
        {
            person.ID = "5|377|044|0";
            Assert.AreEqual(person.ID, "5.377.044-0");
        }

        [Test]
        public void AssignIdWrongLength()
        {
            person.ID = "9108309182309182093810923";
            Assert.AreEqual(person.ID, "5.377.044-0");
        }
    }
}