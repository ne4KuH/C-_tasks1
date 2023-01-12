using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Task1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            List<object> input = new List<object>() { 1, 'a', 2, "b" };
            List<int> output = GetIntegersFromList(input);
            List<int> expected = new List<int>() { 1, 2 };
            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Test2()
        {
            List<object> input = new List<object>() { 1, 'a', 'b', '1', "123", 256 };
            List<int> output = GetIntegersFromList(input);
            List<int> expected = new List<int>() { 1, 256 };
            CollectionAssert.AreEqual(expected, output);
        }

        List<int> GetIntegersFromList(List<object> input)
        {
            IEnumerable<int> selected = from obj in input
                                 where obj.GetType() == typeof(int)
                                           select (int)obj;
            return selected.ToList();
        }
    }
}