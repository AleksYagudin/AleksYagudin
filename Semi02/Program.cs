// Программа выводит случайное число из отрезка и показывает наибольшую цифру

Random random = new Random(); // создание рандома с переменной random
int randomNumber = random.Next(10,100); // метод Next диапазон 10-100
// int randomNumberTwo = random.Next(10,100); // вызов двух рандомных (randomNumber переменная)
Console.WriteLine("Выпавшее число " + randomNumber);
// Console.WriteLine(randomNumberTwo);


int lastNumber = randomNumber / 10;  // выводит первое число из 2х значных

int firstNumber = randomNumber % 10; // записывает в переменную firstNumber 2 число от 2х знач чисел.
// для 3х знач /100 и 2 последних и далее.

Console.WriteLine("первое число " + lastNumber);
Console.WriteLine("второе число " + firstNumber);

// теперь сравниваем

if (lastNumber > firstNumber)
{
    Console.WriteLine("Большее число " + lastNumber);
}
else{
    Console.WriteLine("Большее число " + firstNumber);
}

