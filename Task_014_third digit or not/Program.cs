// Найти третью цифру числа или сообщить, что её нет
int number = new Random().Next(1, 99999999);
String s = number.ToString();
Console.WriteLine("Число: "+number);
if (number>99)
{
    Console.WriteLine("Третья цифра: "+s[2]);
} 
else
Console.WriteLine("Третьей цифры нет");



//try {Console.WriteLine("Третья цифра: "+s[2]);}
//catch {Console.WriteLine("Третьей цифры нет");}






/* // Найти третью цифру числа или сообщить, что её нет
int number = new Random().Next(1, 9999);
int a = number;
Console.WriteLine("Число: " + number);
int n = 0;
int number3 = 0;
while (a > 0)
{
    a = a / 10;
    n = n + 1;
}
if (n == 9)
{
number3 = (number % 10000000) / 1000000;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 8)
{
number3 = (number % 1000000) / 100000;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 7)
{
number3 = (number % 100000) / 10000;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 6)
{
number3 = (number % 10000) / 1000;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 5)
{
number3 = (number % 1000) / 100;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 4)
{
number3 = (number % 100) / 10;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 3)
{
number3 = number % 10;
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третья цифра: " + number3);
}
else if (n == 2)
{
Console.WriteLine("Длинна числа: " + n);
Console.WriteLine("Третьей цифры нет");
}
else
Console.WriteLine("Третьей цифры нет");
 */