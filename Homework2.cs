// // Задача 10
// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n % 100 /10;
// while (n < 100 || n > 999)
//  {
//     Console.Write("Вы ошиблись! Введите трехзначное число: ");
//        n = Convert.ToInt32(Console.ReadLine());
//  }

// Console.WriteLine($"Вторая цифра числа: {n1}");

// // Задача 13
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = 0;     
// while (n < 100)
//  {
//     Console.Write("Третьей цифры нет! Введите число: ");
//        n = Convert.ToInt32(Console.ReadLine());
//  }
// if (n > 99 && n < 1000) 
// n1 = n % 10;
// else
// do 
// {
//     n= n/10;
//     n1 = n % 10;
// }
// while (n > 999);

//  Console.WriteLine($"Третья цифра числа: {n1}");

// Задача 15
// Console.Clear();
// Console.Write("Введите день недели: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n <1 || n > 7)
// {
//        Console.Write("Вы ошиблись! Введите день недели:");
//        n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//    Console.WriteLine("Понедельник");
// if (n == 2)
//    Console.WriteLine("Вторник");
// if (n == 3)
//    Console.WriteLine("Среда");
// if (n == 4)
//    Console.WriteLine("Четверг");
// if (n == 5)
//    Console.WriteLine("Пятница");
// if (n == 6)
//    Console.WriteLine("Суббота");
// if (n == 7)
//    Console.WriteLine("Воскресенье");
// if (n < 6)
//    Console.Write("Рабочий день");
// else
//     Console.Write("Выходной");
/////Второй способ
// Console.Clear();
// Console.Write("Введите день недели: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n <1 || n > 7)
// {
//        Console.Write("Вы ошиблись! Введите день недели:");
//        n = Convert.ToInt32(Console.ReadLine());
// }
// if (n < 6)
//        Console.WriteLine("Рабочий день");
// else
//        Console.WriteLine("Выходной");