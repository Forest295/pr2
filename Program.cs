using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

void Sum(int x, int y) // 1 задание
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
}

Sum (25, 10);    // Выводит сумму двух чисел 

void radius(double x) // 2 задание
{
    double area = 3.14 * x * x;
    Console.WriteLine($"{3.14} * {x} * {x} = {area}");
}
radius(5);      // Выводит площадь окружности при вводе ее радиуса


void  str(string x) // 3 задание
{
    Console.WriteLine(x.Length);
}
str("Ростов-на-Дону"); // Выводит количество символов строки



static void maxnummassive(int[] array) // 4 задание
{
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
if (array[i] > max)
{
max = array[i];}
}
Console.WriteLine(max);}
    int[] numbers = { 2, 7, 5, 3, 6 };
    maxnummassive(numbers); // Возвращает наибольшее число массива


    void Factorial(int x) // 5 задание
{
    long result = 1;
    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    Console.WriteLine(result); // Выводит факториал числа 
}
Factorial(3);


static void palindrome(string str) // 6 задание
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    string reversed = new string(charArray);
    if (str == reversed)
        Console.WriteLine("Слово " + str + " является палиндромом");
    else
        Console.WriteLine("Слово " + str + " не является палиндромом");
}
palindrome("топот"); // Выводит слово наоборот и проверяет его на палиндром 


static void array3(int[] array1, int[] array2) // 7 задание
{
int[] array3 = new int[array1.Length + array2.Length];

Array.Copy(array1, array3, array1.Length);
Array.Copy(array2, 0, array3, array1.Length, array2.Length);
foreach (int num in array3)
{
Console.Write(num + " ");}
}
    int[] array1 = { 1, 2, 3 };
    int[] array2 = { 4, 5, 6 };
    array3(array1, array2); // Выводит числа из двух массивов в один общий массив


    void trueorfalse(int number) // 8 задание
{
    if (number <= 1) 
    {
        Console.WriteLine("false");
        return;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++) 
    {
        if (number % i == 0) 
        {
            Console.WriteLine("false");
            return;
        }
    }
    Console.WriteLine("true");
}
trueorfalse(7); // Проверяет простое число или нет 



void ReverseString(string str) // задание 9
{
    char[] charArray = str.ToCharArray(); 
    Array.Reverse(charArray); 
    Console.WriteLine(new string(charArray)); 
}
ReverseString("Дом"); // Выводит слово наоборот


static void sumarray(int[,] array) // 10 задание 
{
    int sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }
    Console.WriteLine(sum);
}
    int[,] nums = { { 1, 2, 3 } , { 4, 5, 6 } };
    sumarray(nums); // Сумма двух массивов