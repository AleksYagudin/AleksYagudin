
int firstNumber = Convert.ToInt32(Console.ReadLine()); //Вводим число на которое будем делить
int twoNumber = Convert.ToInt32(Console.ReadLine());  //Вводим число которое делим

if (twoNumber % firstNumber == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    int number = (twoNumber % firstNumber);
    Console.WriteLine($"Не кратно, остаток : {number}");
}

