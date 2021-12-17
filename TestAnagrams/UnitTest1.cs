using NUnit.Framework;


namespace TestAnagrams
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            string value = Anagram.Program.Anagram();
            string expected = "A";


            Assert.AreEqual(value, expected);
        }
    }
}