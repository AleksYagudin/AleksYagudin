Console.Write("Number enter : ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num * 0;

while (num1 <= num)
{
    
    if (num1 % 2 == 0)
    {
    Console.WriteLine(num1);
    }
    num1++;
}