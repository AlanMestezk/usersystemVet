

namespace BackOnly {
    internal class BackArmy {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public BackArmy() { }

        public BackArmy(int id, string name, string position) {
            Id = id;
            Name = name;
            Position = position;
        }

        override public string ToString() {
            Console.WriteLine();
            
            Console.WriteLine($"              Result for ID: {Id}");
            Console.WriteLine();
            Console.WriteLine($"                             Name: {Name}");
            Console.WriteLine($"                             Position: {Position}");
            return "";
        }

    }
}
