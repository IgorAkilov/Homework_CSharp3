// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt (string message) 
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return(number);
}

int x1 = Prompt("Введите координату точки X1 :");
int y1 = Prompt("Введите координату точки Y1 :");
int z1 = Prompt("Введите координату точки z1 :");
int x2 = Prompt("Введите координату точки X2 :");
int y2 = Prompt("Введите координату точки Y2 :");
int z2 = Prompt("Введите координату точки z2 :");
FindResult(x1, y1, z1, x2, y2, z2);
Console.WriteLine();


void FindResult(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Sqrt((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1) + (Z2-Z1)*(Z2-Z1));
    Console.WriteLine(result.ToString("0.##"));
}
