// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*

bool IsPalindrom(int number)
{
   return number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10;
}


Console.Write("Input a a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 9999 && number < 100000)
    Console.Write(IsPalindrom(number));
else
    Console.Write("The input number is not a five-digit number!");




//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dis = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    return Math.Round(dis,2);
}

Console.Write("Input coordinate X for the first point:  ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y for the first point:  ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Z for the first point:  ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate X for the second point:  ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y for the second point:  ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Z for the second point:  ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance between two points is: " + Distance3D(x1, y1, z1, x2, y2, z2));



//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}

*/
