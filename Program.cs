//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int secondNumb(int num)
{
    int num1 = num / 10;
    int result = num1 % 10;
    return result;
}

Console.Write("Input tree-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number >= 100 && number < 1000 )
{
    int newNum = secondNumb(number);
    Console.WriteLine(newNum);
}
else {
    Console.Write($"The number {number} is not three-digit");
}

*/

//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int threeNumber(int num)
{
    while ( num > 1000 )
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number < 100 )
{
    Console.Write($"There is {number} no third digit");
}
else 
{
    int newNum = threeNumber(number);
    Console.Write(newNum);
}
*/


//Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
/*
bool weekday(int num)
{
    if( num == 6 || num == 7 )
    {
        Console.Write("Yes");
        return true;
    }
    else
    {
        Console.Write("No");
        return false;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if( number > 7)
    {
        Console.Write("This is not weekday");
    }
    else 
    {
        weekday(number);
    }
*/