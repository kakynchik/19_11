namespace _19_11
{
    class Task6
    {
        public void Execute()
        {
            Console.WriteLine("Magazin4ik");
            Store store = new Store();
            store.InputData();
            store.DisplayInfo();
            Console.WriteLine();
        }

        private class Store
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Profile { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public void InputData()
            {
                Console.Write("vvedit nazvy magaziny: ");
                Name = Console.ReadLine();
                Console.Write("vvedit adress: ");
                Address = Console.ReadLine();
                Console.Write("vvedit opic profilyu: ");
                Profile = Console.ReadLine();
                Console.Write("vvedit kontaktniy telefon: ");
                Phone = Console.ReadLine();
                Console.Write("vvedit email: ");
                Email = Console.ReadLine();
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Nazva: {Name}");
                Console.WriteLine($"Address: {Address}");
                Console.WriteLine($"Opis: {Profile}");
                Console.WriteLine($"Telefon: {Phone}");
                Console.WriteLine($"Email: {Email}");
            }
        }
    }
}