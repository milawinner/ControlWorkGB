// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

Console.WriteLine("Эта программа формирует из введённого массива строк новый массив, длина которого <= 3 символа.");
Console.WriteLine("Сколько строк будет в первоначальном массиве? NB! Вводить их придётся вам:)");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите строку:");
    array[i] = Console.ReadLine();
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Ваш массив: ");
PrintArray(array);

string[] secondArray = new string [array.Length];

void ArrayWithThreeSights(string[] array, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            secondArray[count] = array[i];
            count++;
        }
    }
}
ArrayWithThreeSights(array, secondArray);
Console.Write("Трансформированный массив: ");
PrintArray(secondArray);