/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void Week(int num)
{
if(num < 1 || num > 7)
    Console.WriteLine("Нет такого дня недели");
else if(num == 6 || num == 7)
    Console.WriteLine("Этот день ВЫХОДНОЙ!");
else 
     Console.WriteLine("Этот день НЕ выходной");
}

Console.Write("Введите число дня недели: "); 
int num = Convert.ToInt32(Console.ReadLine());
Week(num);