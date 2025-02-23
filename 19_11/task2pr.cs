namespace _19_11
{
    class Task2Pr
    {
        public void Execute()
        {
            Console.WriteLine("4islo fibonacci");
            Console.WriteLine(IsFibonacci(8)); 
            Console.WriteLine(IsFibonacci(10)); 
            Console.WriteLine();
        }

        private bool IsFibonacci(int number)
        {
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            return b == number || number == 0;
        }
    }
}