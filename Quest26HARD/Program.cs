// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
//Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.
Console.WriteLine("Введите количество элементов массива: ");
int index;
if (!int.TryParse(Console.ReadLine()!, out index))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[] zero = new int[index]; //вводим массив с необходимым количеством элементов

void FillArray(int[] zero) // функция заполняет массив нулями и еденицами в рандомном порядке(работает)
{
    Random rnd = new Random();
    for (index = 0; index < zero.Length; index++)
    {
        zero[index] = rnd.Next(0, 2);
    }
}

void Counter(int[] zero)// Считает количество нулей и едениц (РАБОТАЕТ)
{
    int una = 0;
    int cero = 0;
    for (index = 0; index < zero.Length; index++)
    {
        if (zero[index] > 0)
        {
            una++;
        }
        else
        {
            cero++;
        }
    }

    Console.WriteLine(" "); // Это затем чтобы надпись "Количество едениц" не лепилась в одну строчку с нулями и еденицами массива
    Console.WriteLine($"Количество едениц = {una}");
    Console.WriteLine($"Количество нулей = {cero}");

    if (una > cero)
    {
        Console.WriteLine("TRUE");
    }

    if (una < cero)
    {
        Console.WriteLine("False");
    }

    if (una == cero)
    {
        Console.WriteLine("RANDOM POWER");
    }
}
void Print(int[] two)//функция печатает массив(работает)
{
    int position = 0;
    Console.WriteLine("Полученный массив: ");
    for (position = 0; position < two.Length; position++)
    {
        Console.Write(two[position] + " ");
    }
}
FillArray(zero);
Print(zero);

Counter(zero);
