// Семинар 1. Знакомство
int a = 5, b = 3;

Console.WriteLine("My numbers are " + a + " and " + b);
Console.WriteLine($"My numbers are {a} and {b}");

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
/*

Комментарий
Ctrl+/ - комментирование строк

*/
// Задача 1. Равно ли 1 число квадрату другого.
Console.Write("Input a number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inout a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if(num1 == quad)
{
    Console.Write("Yes!");
}
else
{
    Console.Write("No!");
}


// Задача 2.

Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int  current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}