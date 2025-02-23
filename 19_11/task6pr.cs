namespace _19_11
{
    class Task6Pr
    {
        public void Execute()
        {
            Console.WriteLine("litak");

            Plane plane1 = new Plane("Boeing 747", "Boeing", 1990, "Passagirskiy");
            Plane plane2 = new Plane();
            plane2.InputData();

            plane1.DisplayInfo();
            plane2.DisplayInfo();

            Console.WriteLine();
        }

        private class Plane
        {
            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }

           public Plane() { Name = string.Empty; Manufacturer = string.Empty; Type = string.Empty; }

            public Plane(string name, string manufacturer, int year, string type)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                Manufacturer = manufacturer;
                Year = year;
                Type = type;
            }

            public void InputData()
            {
               Console.Write("nazva litaka: ");
                Name = Console.ReadLine() ?? string.Empty;
                Console.Write("virobnik: ");
                Manufacturer = Console.ReadLine() ?? string.Empty;
                Console.Write("rik vipysky: ");
                Year = int.TryParse(Console.ReadLine(), out int year) ? year : 0;
                Console.Write("tip litaka: ");
                Type = Console.ReadLine() ?? string.Empty;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"nazva litaka: {Name}");
                Console.WriteLine($"virobnik: {Manufacturer}");
                Console.WriteLine($"rik vipysky: {Year}");
                Console.WriteLine($"tip litaka: {Type}");
                Console.WriteLine();
            }
        }
    }
}