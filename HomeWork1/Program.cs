using static System.Console;
using System.Linq;
using System;

//string[] firstArray = new string[5] {"123", "23", "hello", "world", "res"};  можно ввести массив изначально

string [] firstArray = ReadDataMass("Введите количество элементов cтрочного массива, которые хотите ввести: ");
PrintDataMass(firstArray, "Введенный массив:");
string[] secondArray = new string[firstArray.Length];
SecondArraySize3(firstArray,secondArray);
PrintDataMass(secondArray, "Полученный массив:");

void SecondArraySize3(string[] array1, string[] array2) //Метод создания второго массива из первого по условию
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

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
    Console.WriteLine(msg);
    for (int i = 0; i < arr.Length; ++i)
        {
        Console.Write("{0} ", arr[i]);
        }
        System.Console.WriteLine();
}

