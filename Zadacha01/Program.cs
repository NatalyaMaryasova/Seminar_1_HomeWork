Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine("Первое число больше второго");
    int max = num1;
    Console.WriteLine("max" + "=" + num1);
}
if(num1 < num2)
{
    Console.WriteLine("Второе число больше первого");
    int max = num2;
    Console.WriteLine("max" + "=" + num2);
}
if(num1 == num2)
{
    Console.WriteLine("Числа равны");
}