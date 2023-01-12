namespace Task3
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
            int input = 16;
            int output = digital_root(input);
            int expected = 7;
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test2()
        {
            int input = 942;
            int output = digital_root(input);
            int expected = 6;
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test3()
        {
            int input = 493193;
            int output = digital_root(input);
            int expected = 2;
            Assert.IsTrue(output == expected);
        }

        int digital_root(int number)
        {
            string str = number.ToString();
            if (str.Length == 1)
                return int.Parse(str);
            else
            {
                int sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    sum += int.Parse(str[i].ToString());
                }
                return digital_root(sum);
            }
        }
    }

}