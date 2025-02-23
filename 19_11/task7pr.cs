namespace _19_11
{
    class Task7Pr
    {
        public void Execute()
        {
            Console.WriteLine("matrica");
            Matrix matrix = new Matrix(3, 3);
            matrix.InputData();
            matrix.DisplayInfo();
            Console.WriteLine($"Max: {matrix.FindMax()}");
            Console.WriteLine($"Min: {matrix.FindMin()}");
            Console.WriteLine();
        }

        private class Matrix
        {
            private int[,] _data;
            private int _rows, _cols;

            public Matrix(int rows, int cols)
            {
                _rows = rows;
                _cols = cols;
                _data = new int[rows, cols];
            }

            public void InputData()
            {
                Console.WriteLine("elementi matrici:");
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        Console.Write($"element [{i},{j}]: ");
                       string input = Console.ReadLine() ?? string.Empty;
                        if (!string.IsNullOrEmpty(input))
                        {
                            _data[i, j] = int.Parse(input);
                        }
                        else
                        {
                            _data[i, j] = 0; 
                        }
                    }
                }
            }

            public void DisplayInfo()
            {
                Console.WriteLine("matrica:");
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        Console.Write(_data[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            public int FindMax()
            {
                int max = _data[0, 0];
                foreach (int num in _data)
                {
                    if (num > max)
                        max = num;
                }
                return max;
            }

            public int FindMin()
            {
                int min = _data[0, 0];
                foreach (int num in _data)
                {
                    if (num < min)
                        min = num;
                }
                return min;
            }
        }
    }
}
