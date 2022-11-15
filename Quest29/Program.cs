// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
//Конструкция принимает число и проверяет его на соответсвие int. При несоответсвии завершает действие программы.
Console.WriteLine("Введите количество элементов массива: ");
int ind;
if (!int.TryParse(Console.ReadLine()!, out ind))
{
    Console.WriteLine("Неверный ввод");
    return;
}
// Создание массива с введенным количеством элементов
int[] array = new int[ind];

//Функция заполнения массива с клавиатуры
void FillArray(int[] array)
{
    for (ind = 0; ind < array.Length; ind++) // Цикл перебора индексов к заполнению
    {
        Console.WriteLine($"Введите элемент массива с индексом {ind}:");
        array[ind] = int.Parse(Console.ReadLine()!);
    }
}
FillArray(array);

Console.WriteLine("Массив: ");

for (ind = 0; ind < array.Length; ind++) // Цикл вывода массива - выводит поочереди все элементы начиная с нулевого.
{
    Console.Write(array[ind]+" ");
}
