namespace _19_11

{
    class Task3
    {
        public void Execute()
        {
            Console.WriteLine("filtracia masivy");
            int[] original = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filter = { 6, 88, 7 };
            int[] result = FilterArray(original, filter);
            Console.WriteLine(string.Join(" ", result)); // 1 2 -1
            Console.WriteLine();
        }

        private int[] FilterArray(int[] original, int[] filter)
        {
            return original.Where(x => !filter.Contains(x)).ToArray();
        }
    }

}