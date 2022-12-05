// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.Clear();

// Console.WriteLine("Введите пятизначное число: ");

// int number = int.Parse(Console.ReadLine());

// void VerifyPolindrome(string str)
// {
//     Console.WriteLine(str);
//     int ostatok = number/1000;
//     int ostatokEnd = number % 100;
//     int ostatokEnd2 = (ostatokEnd % 10) * 10 + (ostatokEnd /10 );
//     if (ostatok == ostatokEnd2)
//         Console.WriteLine ($"число {number} является полиндромом");
//     else 
//         Console.WriteLine ($"число {number}  не является полиндромом");
// }
// VerifyPolindrome("Проверяем на полиндромность: ");

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");

void VerifyPolindrome(string str)

{
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine(str);

    int ostatok = number/1000;

    int ostatokEnd = number % 100;

    int ostatokEnd2 = (ostatokEnd % 10) * 10 + (ostatokEnd /10 );

    if (ostatok == ostatokEnd2)

        Console.WriteLine ($"число {number} является полиндромом");

    else 

        Console.WriteLine ($"число {number}  не является полиндромом");
}

VerifyPolindrome("Проверяем на полиндромность: ");
