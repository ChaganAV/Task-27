// See https://aka.ms/new-console-template for more information
int number = 0;
int summaNumbers = 0;

Console.WriteLine("Введите число");
if(Int32.TryParse(Console.ReadLine(),out number))
{
    summaNumbers = SumNumbers(number);
    Console.WriteLine($"Сумма цифр в указанном числе: {summaNumbers}");
}
else
{
    Console.WriteLine("Необходимо ввести число!");
    return;
}



int SumNumbers(int num)
{
    int sum = 0;
    while(num>0)
    {
        sum+=num%10;
        num = num/10;
    }
    return sum;
}
