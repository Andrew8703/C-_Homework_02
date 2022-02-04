// Удалить вторую цифру трёхзначного числа.
int number = new Random().Next(100, 999);
Console.WriteLine("Число: " + number);
Console.WriteLine("Число без второй цифры: " + (number / 100) + (number % 10));