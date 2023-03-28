using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();

            Console.WriteLine("Введите тип питомца: собака, рыбка, хомячок");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возраст питомца");
            Pet.Age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину имени питомца");
            Pet.NameCount = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
