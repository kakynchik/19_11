namespace _19_11
{
    class Task4Pr
    {
        public void Execute()
        {
            Console.WriteLine("mimimisto");
            City city = new City { Name = "DefaultName", Country = "DefaultCountry", PhoneCode = "000", Districts = new[] { "DefaultDistrict" } };
            city.InputData();
            city.DisplayInfo();
            Console.WriteLine();
        }

        private class City
        {
           public required string Name { get; set; }
            public required string Country { get; set; }
            public int Population { get; set; }
            public required string PhoneCode { get; set; }
            public required string[] Districts { get; set; }

            public void InputData()
            {
                
                Console.Write("vvedit nazvy mista: ");
                Name = Console.ReadLine() ?? "DefaultName";
                Console.Write("vvedit nazvy krayini: ");
                Country = Console.ReadLine() ?? "DefaultCountry";
                Console.Write("vvedit kilkist zhiteliv: ");
                Population = int.TryParse(Console.ReadLine(), out int population) ? population : 0;
                Console.Write("vvedit telefonni kod mista: ");
                PhoneCode = Console.ReadLine() ?? "000";
                Console.Write("vvedit nazvi rayoniv 4erez komy: ");
                Districts = Console.ReadLine()?.Split(',') ?? new[] { "DefaultDistrict" };
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Misto: {Name}");
                Console.WriteLine($"Krayina: {Country}");
                Console.WriteLine($"naselennya: {Population}");
                Console.WriteLine($"telefonni kod: {PhoneCode}");
                Console.WriteLine($"rayoni: {string.Join(", ", Districts)}");
            }
        }
    }
}
