using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение:");
            string text = Console.ReadLine();
            Console.WriteLine();
            string textReverse = "";
            text = text.Replace(" ", "").ToLower();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                textReverse += text[i];
            }
            if (text.CompareTo(textReverse) == 0)
                Console.WriteLine("Введенное предложение является полиндромом");
            else
                Console.WriteLine("Введенное предложение не является полиндромом");
            Console.ReadLine();
        }
    }
}
