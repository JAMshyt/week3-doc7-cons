using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строки_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            Console.Write("Введите что заменить: ");
            string subst1 = Console.ReadLine();
            Console.Write("Введите на что заменить: ");
            string subst2 = Console.ReadLine();
            text.Replace(subst1, subst2);
            Console.Write("Изменённая строка: "+text.ToString());
        }
    }
}
