// Задачи : Случайное 3х значное число и вывести результат без цифры в середине

Random random = new Random();
int randomNumber = random.Next(100,1000);

Console.WriteLine("Выпавшее число " + randomNumber);
int lastNumber = randomNumber / 100;  
int firstNumber = randomNumber % 10;

Console.Write($"Число без цифры в середин = {lastNumber}{firstNumber}");
