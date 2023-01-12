namespace Task2
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
            string input = "stress";
            char? output = first_non_repeating_letter(input);
            char? expected = 't';
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test2()
        {
            string input = "abcddcba";
            char? output = first_non_repeating_letter(input);
            char? expected = null;
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test3()
        {
            string input = "ParampampamZ";
            char? output = first_non_repeating_letter(input);
            char? expected = 'Z';
            Assert.IsTrue(output == expected);
        }

        char? first_non_repeating_letter(string str)
        {
            char? ans = null;
            for(int i = 0; i < str.Length; i++)
            {
                char a = str[i];
                ans = a;
                for(int j = 0; j < str.Length; j++)
                {
                    if ((a == str[j]) && (i != j))
                    {
                        ans = null;
                        break;
                    }
                }
                if (ans != null)
                    return ans;
            }
            return ans;
        }
    }
}