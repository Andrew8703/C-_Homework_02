// Показать вторую цифру трёхзначного числа
int number = new Random().Next(100, 999);
Console.WriteLine("Число: " + number);
int number2 = (number % 100) / 10;
Console.WriteLine("Вторая цифра в числе: " + number2);




