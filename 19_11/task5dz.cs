namespace _19_11
{
    class Task5
    {
        public void Execute()
        {
            Console.WriteLine("Zhyrnal");
            Journal journal = new Journal();
            journal.InputData();
            journal.DisplayInfo();
            Console.WriteLine();
        }

        private class Journal
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Description { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public void InputData()
            {
                Console.Write("vvedit nazvy zhyrnaly: ");
                Name = Console.ReadLine();
                Console.Write("vvedit rik zasnyvannia: ");
                Year = int.Parse(Console.ReadLine());
                Console.Write("vvedit opis zhyrnal: ");
                Description = Console.ReadLine();
                Console.Write("vvedit kontaktniy teelfon: ");
                Phone = Console.ReadLine();
                Console.Write("vvedit email: ");
                Email = Console.ReadLine();
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"nazva: {Name}");
                Console.WriteLine($"rik zasnyvannia: {Year}");
                Console.WriteLine($"Opic: {Description}");
                Console.WriteLine($"telefon: {Phone}");
                Console.WriteLine($"Email: {Email}");
            }
        }
    }
    
}