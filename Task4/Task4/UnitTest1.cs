namespace Task4
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
            int[] arr = new int[] { 1, 3, 6, 2, 2, 0, 4, 5};
            int target = 5;
            int output = count_pairs(arr, target);
            int expected = 4;
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test2()
        {
            int[] arr = new int[] { 7, 6, 8, 10, 78, 15 };
            int target = 5;
            int output = count_pairs(arr, target);
            int expected = 0;
            Assert.IsTrue(output == expected);
        }

        int count_pairs(int[] arr, int target)
        {
            int pairs = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int local_target = target - arr[i];
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] == local_target)
                        pairs++;
                }
            }
            return pairs;
        }
    }
}