//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void zadacha19()
{
        Console.WriteLine("Введите пятизначное число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 10 == number / 10000)
        {
            number = number/10;
            if (number % 10 == number / 100 % 10)
            Console.WriteLine("число палиндром");
            else Console.WriteLine("число не палиндром");
        }
        else Console.WriteLine("число не палиндром");
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
void zadacha21()
{
        Random random = new Random();
        int ax = random.Next(-10,10);
        int ay = random.Next(-10,10);
        int az = random.Next(-10,10);
        int bx = random.Next(-10,10);
        int by = random.Next(-10,10);
        int bz = random.Next(-10,10);

        Console.WriteLine($"A: ({ax},{ay},{az}), B: ({bx},{by},{bz})");
        Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2))}");
}

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void zadacha23()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double kub;
    while (i <= number)
    {
        kub = Math.Pow(i,3);
        Console.WriteLine($"|{i}|{kub}|");
        i++;
    }
}

zadacha19();
//zadacha21();
//zadacha23();
