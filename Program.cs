//задача №2
/*
int a, b;

Console.WriteLine("Введите два числа по очереди");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Число " + a + " больше, чем число " + b);
}
else
{
    Console.WriteLine("Число " + b + " больше, чем число " + a);
}
*/

//Задача №4
/*
int a, b, c, max;
max = 0;
Console.WriteLine("Введите три числа по очереди");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
    if(max > c)
    {
        Console.WriteLine("Наибольшее число " + max);
    }
    else
    {
        max = c;
        Console.WriteLine("Наибольшее число " + max);
    }
}
else
{
    max = b;
    if(max > c)
    {
        Console.WriteLine("Наибольшее число " + max);
    }
    else
    {
        max = c;
        Console.WriteLine("Наибольшее число " + max);
    }
}
*/

//Задача №6
/*
int a;

Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
a = a % 2;
if(a == 0)
{
    Console.WriteLine("Введенное число четное.");
}
else
{
    Console.WriteLine("Введенное число нечетное.");
}
*/

//Задача №8
// Неверный вариант - обратный счет.
/*
int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());

while(1 <= a)
{
    if(a % 2 == 0)
    {
        Console.Write(a + " ");
         a = a - 1;
    }
    else
    {
        a = a - 1;
    }
}
*/

//Верный вариант

Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

for(int a = 1; a <= b; a++)
{
    if(a % 2 == 0)
    {
        Console.Write(a + " ");
    }
}
// Сегодня было холоднео
//ss