namespace _19_11
{
    public class Task1
    {
        public void Execute()
        {
            Console.WriteLine("vidobrazhennia kvadrata ziro4kami");
            DrawSquare(5, '*');
            Console.WriteLine();
        }

        private void DrawSquare(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }

                Console.WriteLine();
            }
        }
    }
}