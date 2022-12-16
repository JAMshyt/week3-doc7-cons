using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строки_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string[] text = Console.ReadLine().Split(' ', '.', ',', ':', ';', '!', '?'); ;
            string[] result = new string[text.Length];
            bool flag = false;
            string res = "";
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > max)
                {
                    max = text[i].Length;
                    result[i] = text[i];
                    res = text[i];
                }
                if (text[i].Length == max)
                {
                    result[i] = text[i];
                }
            }
            Console.Write("Самое длинное слово: ");
            for (int i = 0; i < result.Length; i++)
            {
                if (res.Length >= result[i].Length)
                {
                    flag = true;
                    break;
                }
                else
                {
                    Console.Write(result[i] + " ");
                }
            }
            if (flag)  Console.Write(res);
            Console.Write("\n");
        }
    }
}
