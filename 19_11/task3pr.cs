namespace _19_11
{
    class Task3Pr
    {
        public void Execute()
        {
            Console.WriteLine("sort massiva");
            int[] array = { 5, 2, 9, 1, 7 };
            
            Console.WriteLine("orig massiv: " + string.Join(", ", array));

            Console.Write("viberit poryadok (asc/desc): ");
            string order = Console.ReadLine();

            SortArray(array, order == "asc");

            Console.WriteLine("vidsortovani masiv4ik: " + string.Join(", ", array));
            Console.WriteLine();
        }

        private void SortArray(int[] array, bool ascending)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((ascending && array[i] > array[j]) || (!ascending && array[i] < array[j]))
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
        }
    }
}