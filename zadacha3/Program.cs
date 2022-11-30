// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void NumberPow(string str)
{
    Console.WriteLine(str);
    double number = double.Parse(Console.ReadLine());
    double count = 1;
     while(count <= number)
     {
     double numb = Math.Pow(count,3);
     Console.Write(numb+ ", ");
     count++;
     }
}

NumberPow("Введите число N: ");
