using static System.Console;
using System.Linq;
using System;

//string[] firstArray = new string[5] {"123", "23", "hello", "world", "res"};  можно ввести массив изначально

string [] ReadDataMass(string msg)  //Метод ввода строчного массива с клавиатуры
{
     System.Console.WriteLine();
            Console.WriteLine(msg);
            int n = int.Parse(Console.ReadLine()?? "0"); // Считываем строку, переводим в число.
            string[] strs = new string[n]; //Объявляем массив строк длиной n 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент №{0}:\r\n    ", i + 1);
                strs[i] = Console.ReadLine()?? "0"; //Заполняем его
            }
            return strs;
}
            
void PrintDataMass(string [] arr,string msg) //Метод, выводящий на печать строчный массив

{ 
    System.Console.WriteLine();
    Console.WriteLine(msg);
    for (int i = 0; i < arr.Length; ++i)
    Console.Write("{0} ", arr[i]);
    System.Console.WriteLine();
}