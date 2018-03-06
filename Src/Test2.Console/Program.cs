namespace Test2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new NumberGenerator();
            for (int i = 1; i <= 100; i++)
                System.Console.WriteLine(nums.Get(i));

            System.Console.Read();
        }
    }

    public class NumberGenerator
    {
        public string Get(int i)
        {
            if (i == 0)
                return "0";
            if (i % 15 == 0)
                return "Ansible Australia";
            if (i % 3 == 0)
                return "Ansible";
            if (i % 5 == 0)
                return "Australia";
            return i.ToString();
        }
    }

}
