
Random random = new Random(); 
int randomNumber = random.Next(10,100); 
Console.WriteLine("Выпавшее число " + randomNumber);

int GetMaxNumber(int number)  // Метод GetMaxNumber ищет в случайном 2х
                              //значном чмисле, большее из этих 2х.
{
    int lastNumber = number % 10;
    int firstNumber = number / 10;
    if (lastNumber > firstNumber)
    {
        return lastNumber;
    }
   else
    {
        return firstNumber;
    }
}
int result = GetMaxNumber(randomNumber);

Console.WriteLine(result);