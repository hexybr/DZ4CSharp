
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Конструкция принимает число А и проверяет его на соответсвие int. При несоответсвии завершает действие программы.
Console.WriteLine("Введите число возводимое в степень: ");
double digitA;
if (!double.TryParse(Console.ReadLine()!, out digitA))
{
    Console.WriteLine("Неверный ввод");
    return;
}
// Конструкция принимает число В и проверяет его на соответсвие int. При несоответсвии завершает действие программы.
Console.WriteLine("Введите степень: ");
double digitB;
if (!double.TryParse(Console.ReadLine()!, out digitB))
{
    Console.WriteLine("Неверный ввод степени");
    return;
}

// Функция которая возводит в степень

double exponentiation(double digitA, double digitB)
{
    digitB = Math.Abs(digitB); // Т.к. в задании указанно возвести в натуральную степень сначала присваиваем степени её значение по модулю оператором Math.Abs
    double n = Math.Pow(digitA, digitB); 
    // Оператор Math.Pow работает со значениями double и для того чтобы оперрировать целочисленными значениями 
    // используем Convert.ToInt32 для соответствующего оператора. Или просто использовать перменные типа double - 
    // т.к. задание не ограничивает степень натуральным числом а указывает на возможность использования такового. 
    return n;
}

Console.WriteLine("Ответ:" + exponentiation(digitA, digitB)); // Использование написанной функции