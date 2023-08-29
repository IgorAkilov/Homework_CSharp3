// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
ReverseNumber(number, reverse);

void ReverseNumber(int num, int rev)
{

    if(num > 9999 && num < 100000)
    {

        
        while (num > 0)
        {
            rev *= 10;
            rev =rev + num % 10;
            num = num / 10;
                            
                
            
        }
        if(rev == number){
            Console.WriteLine(rev + " Палиндром");
        }
        else{
            Console.WriteLine(rev + " Не палиндром");
        } 
           

            
    }
    else
    {
    Console.WriteLine("Это не пятизначное число.");
    }
}
