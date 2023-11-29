namespace Polindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input data : ");
                string input = Console.ReadLine();
                //string input = "rumah";

                if (IsPalindrome(input.ToLower()))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }   
        }
        public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}