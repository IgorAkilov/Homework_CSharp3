// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int I = 0;
FindCubeNumber(num, I);

void FindCubeNumber(int number, int i)
{
    if(number > 0)
    {
    while(i < number)
    {
        i++;
        
        int temp = i * i * i;
        
        Console.Write(temp + " ");
    
    }
}
else
{
    Console.WriteLine("Нет кубов от ноля.");
}
}
