using NUnit.Framework;


namespace TestAnagrams
{
    public class Tests
    {
        
        [Test]
        public void LeerPrimeraLinea()
        {
            string value = Anagram.Program.Anagram(5);
            string expected = "A";


            Assert.AreEqual(value, expected);
        }

        [Test]
        public void Order()
        {
            string value = Anagram.Program.Order("dcab");
            string expected = "abcd";


            Assert.AreEqual(value, expected);
        }

    }
}