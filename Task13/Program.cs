/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string x = Convert.ToString(num);
if(x.Length > 2)
{
    Console.WriteLine("Третья цифра: " + x[2]);

}
else
{
    Console.WriteLine("третьей цифры нет");
}