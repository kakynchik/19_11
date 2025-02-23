namespace _19_11
{
    class Task4
    {
        public void Execute()
        {
            Console.WriteLine("web site");
            Website site = new Website();
            site.InputData();
            site.DisplayInfo();
            Console.WriteLine();
        }

        private class Website
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public string Description { get; set; }
            public string IPAddress { get; set; }

            public void InputData()
            {
                Console.Write("vvedit nazvy: ");
                Name = Console.ReadLine();
                Console.Write("vvedit URL saytu: ");
                Url = Console.ReadLine();
                Console.Write("vvedit opic saytu: ");
                Description = Console.ReadLine();
                Console.Write("vvedit IP saytu: ");
                IPAddress = Console.ReadLine();
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"nazva: {Name}");
                Console.WriteLine($"URL: {Url}");
                Console.WriteLine($"opis: {Description}");
                Console.WriteLine($"IP-adress: {IPAddress}");
            }
        }
    }
    
}