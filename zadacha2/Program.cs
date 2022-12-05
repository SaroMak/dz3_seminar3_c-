// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int DataEntryXYZ(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return result;
}

int x1 = DataEntryXYZ("Введите координаты Х1: ");
int x2 = DataEntryXYZ("Введите координаты Х2: ");

int y1 = DataEntryXYZ("Введите координаты Y1: ");
int y2 = DataEntryXYZ("Введите координаты Y2: ");

int z1 = DataEntryXYZ("Введите координаты Z1: ");
int z2 = DataEntryXYZ("Введите координаты Z2: ");

double result = CalcDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками: " + result);







