namespace _19_11
{
    class Task1Pr
    {
        public void Execute()
        {
            Console.WriteLine("Завдання 1: Добуток чисел у діапазоні");
            Console.WriteLine($"Добуток від 2 до 5: {ProductInRange(2, 5)}"); // 2*3*4*5 = 120
            Console.WriteLine($"Добуток від 1 до 3: {ProductInRange(1, 3)}"); // 1*2*3 = 6
            Console.WriteLine();
        }

        private long ProductInRange(int start, int end)
        {
            long product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
    }
    
}