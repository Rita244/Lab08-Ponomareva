// ### Шаг 2. CountDown и первая модификация

// void CountUp(int n) {
//     if (n == 0) {
//         return;
//     }

//     CountUp(n - 1);
//     Console.WriteLine(n);
// }




// ### Шаг 3. Соберите SumToN с трассировкой самостоятельно

// int SumToN(int n) {
//     Console.WriteLine($"Вход: {n}");

//     if (n == 1)
//         return 1;

//     int result = n + SumToN(n - 1);

//     Console.WriteLine($"Выход: {n}, result = {result}");
//     return result;
// }



// ### Шаг 4. Глубина рекурсии

// void CountDownWithDepth(int n, int depth) {
//     Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n={n}");
//     if (n == 0)
//         return;
//     CountDownWithDepth(n - 1, depth + 1);
// }


// ### Шаг 5. Broken

// void Broken(int n) {
//     Broken(n + 1);
// }


// ## Часть 4. Самостоятельная рекурсия
// ### Задача A. Сумма цифр числа

// int SumDigits(int n) {
//     if (n == 0)
//         return 0;
//     return (n % 10) + SumDigits(n / 10);
// }




// ### Задача B. Возведение в степень

// int Power(int baseNum, int exp) {
//     if (exp == 0)
//         return 1;
//     return baseNum * Power(baseNum, exp - 1);
// }


// ### Задача C. Найди ошибку в рекурсии

// ** 1 метод
// return Sum(n);   // аргумент не меняется!  

// ** 2 метод

// return n + Sum(n + 1);   // аргумент РАСТЁТ, а не убывает



// ## Итоговая задача. Рекурсивный анализ числа

// using System;

// class Program {

//     static int CountDigits(int n) {
//         if (n < 10)
//             return 1;
//         return 1 + CountDigits(n / 10);
//     }

//     static int SumDigits(int n) {
//         if (n == 0)
//             return 0;
//         return (n % 10) + SumDigits(n / 10);
//     }

//     static int MaxDigit(int n) {
//         if (n < 10)
//             return n;
//         int last = n % 10;
//         int maxRest = MaxDigit(n / 10);
//         return last > maxRest ? last : maxRest;
//     }

//     static void PrintDigits(int n) {
//         if (n < 10) {
//             Console.Write(n + " ");
//             return;
//         }
//         PrintDigits(n / 10);
//         Console.Write((n % 10) + " ");
//     }

//     static void Main() {
//         Console.Write("Введите положительное целое число: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Количество цифр: {CountDigits(n)}");
//         Console.WriteLine($"Сумма цифр: {SumDigits(n)}");
//         Console.WriteLine($"Максимальная цифра: {MaxDigit(n)}");
//         Console.Write("Цифры: ");
//         PrintDigits(n);
//         Console.WriteLine();
//     }
// }