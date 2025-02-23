namespace _19_11
{
    class Task5Pr
    {
        public void Execute()
        {
            Console.WriteLine("spivrobidnik");
            Employee employee = new Employee();
            employee.InputData();
            employee.DisplayInfo();
            Console.WriteLine();
        }

        private class Employee
        {
            public string FullName { get; set; }
            public DateTime BirthDate { get; set; }
            public string PhoneNumber { get; set; }
            public string WorkEmail { get; set; }
            public string Position { get; set; }
            public string Responsibilities { get; set; }

            public void InputData()
            {
               Console.Write("vvedit PIB: ");
                FullName = Console.ReadLine() ?? string.Empty;
                Console.Write("data narodzhennia (rrrr-mm-dd): ");
                BirthDate = DateTime.TryParse(Console.ReadLine(), out DateTime birthDate) ? birthDate : DateTime.MinValue;
                Console.Write("vvedit tellefonni nomer: ");
                PhoneNumber = Console.ReadLine() ?? string.Empty;
                Console.Write("vvedit robo4iy email: ");
                WorkEmail = Console.ReadLine() ?? string.Empty;
                Console.Write("vvedit posady: ");
                Position = Console.ReadLine() ?? string.Empty;
                Console.Write("vvedit opis slyzhbovih obovyazkiv: ");
                Responsibilities = Console.ReadLine() ?? string.Empty;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"PIB: {FullName}");
                Console.WriteLine($"Date of birth: {BirthDate:yyyy-MM-dd}");
                Console.WriteLine($"telefon: {PhoneNumber}");
                Console.WriteLine($"robo4i email: {WorkEmail}");
                Console.WriteLine($"Posada: {Position}");
                Console.WriteLine($"obovyazki: {Responsibilities}");
            }
        }
    }
}