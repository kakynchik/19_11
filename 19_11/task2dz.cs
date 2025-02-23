namespace _19_11
{
    class Task2
    {
        public void Execute()
        {
            Console.WriteLine("Perevirka palindromu");
            Console.WriteLine(IsPalindrome(1221));
            Console.WriteLine(IsPalindrome(7854));
            Console.WriteLine();
        }

        private bool IsPalindrome(int number)
        {
            string str = number.ToString();
            string reversed = new string(str.Reverse().ToArray());
            return str == reversed;
        }
    }
}