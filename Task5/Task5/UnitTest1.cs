namespace Task5
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
            string input = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string output = Invite(input);
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test2()
        {
            string input = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Barney:TornBull;Raphael:Corwill;Alfred:Corwill";
            string output = Invite(input);
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.IsTrue(output == expected);
        }

        string Invite(string s)
        {
            string[] names = s.Split(';');
            List<string> names_list = names.ToList();
            IEnumerable<string> ans = from name in names_list
                                      orderby name.Substring(name.IndexOf(':') + 1).ToUpper(), name.Substring(0, name.IndexOf(':')).ToUpper()
                                      select "(" + name.Substring(name.IndexOf(':') + 1).ToUpper() + ", " + name.Substring(0, name.IndexOf(':')).ToUpper() + ")";
            return string.Join("", ans.Select(name => name).ToArray());
        }
    }
}