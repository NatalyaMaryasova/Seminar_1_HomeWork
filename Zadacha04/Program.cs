Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num0 = 2;

while(num0 <= num)
{
    Console.Write(num0 + " ");
    num0 = num0 + 2;
}