

using System;
using System.Collections.Generic;

namespace BackOnly {
    class progam {
        static void Main(string[] args) {

            BackArmy list2 = new();

            Console.WriteLine();
            Console.WriteLine("             Enter the number of employees ");
            Console.WriteLine("                 you want to register");
            
            Console.Write("                          => ");
            int number = int.Parse(Console.ReadLine());

            List<BackArmy> list = new List<BackArmy>();

            for (int i = 1; i <= number; i++) {
                Console.WriteLine();
                Console.WriteLine($"                Register #{i}");
                Console.Write("                               Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("                               Name: ");
                string name = Console.ReadLine();
                Console.Write("                               Position: ");
                string position = Console.ReadLine();
                list.Add(new BackArmy(id, name, position));
                Console.WriteLine();
                Console.WriteLine("                 ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                list2 = new(id, name, position);
            }
            Console.WriteLine();
            Console.WriteLine("                        >>   successful registrations   <<");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************");
            Console.Write("                              check added ID recently: ");
            int check = int.Parse(Console.ReadLine());

            BackArmy checkEmp = list.Find(x => x.Id == check);
            if (checkEmp != null) {
                Console.WriteLine();
                Console.WriteLine(checkEmp);
            }
            else {
                Console.WriteLine();
                Console.WriteLine("user ID not found");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                         ####################################");
            Console.WriteLine("                           Click the enter key to end the app");
            Console.WriteLine("                          ####################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("...developed by Alan Mestezk");

        }
    }
}
