// Homework1

// Task2. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
/*


 Console.Write("Input a first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input a second number: ");

int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if ( num1 < num2 ) max = num2;

Console.Write("Max = " + max );


*/
// Task4. Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number: ");

int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if ( max < num2 ) max = num2;
if ( max < num3 ) max = num3;

Console.Write("Max = " + max);
*/

// Task6. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if ( num1 % 2 != 0 ) Console.WriteLine($"Число {num1} не четное!");
else Console.WriteLine($"Число {num1} четное!");*/




// Task6. Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2;

while ( num1 >= num2 )
{
    Console.Write( num2 + " ");
    num2 = num2 + 2;
}
*/