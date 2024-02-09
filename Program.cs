// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите первое натуральное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе натуральное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int ShowNumbers(int m, int n){
//     if(m < n){
//         Console.Write($"{m}, ");
//         return ShowNumbers(m + 1, n);
//     }
//     else if(m > n){
//         Console.Write($"{m}, ");
//         return ShowNumbers(m - 1, n);
//     }
//     else {
//         Console.Write(m);
//         return m;
//     }
// }
// ShowNumbers(m, n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.WriteLine("Введите первое неотрицательное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе неотрицательное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int Akkermanformul(int m, int n){
//     if(m > 0 && n == 0){
//         return Akkermanformul(m - 1, 1);
//     }
//     if(m > 0 && n > 0){
//         return Akkermanformul(m - 1, Akkermanformul(m, n - 1));
//     }
//     return n + 1;
// }
// Console.WriteLine($"A(m,n) = {Akkermanformul(m, n)}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// int[] array = {1, 2, 5, 0, 10, 34};
// int i = array.Length - 1;
// void ArrNumbers(int[] array, int i){
//         Console.Write($"{array[i]} ");
//     if (0 < i){
//         ArrNumbers(array, i - 1);
//     }
// }
// ArrNumbers(array, i);