// Ввод массива
string[] InputMassive(int size)
{
    string[] arry = new string[size]; // Задаем массив
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i} массива: ");
        string element = Convert.ToString(Console.ReadLine()!);
        arry[i] = element;
    }
    return arry;
}
// Вывод массива
void PrintMassive(string[] arry)
{
    for (int i = 0; i < arry.Length; i++)
        Console.Write($" {arry[i]}  ");
    Console.WriteLine();
}

string[] LengthLineThree(int size, string[] arry, int lengthLine)
{
    string[] arryResult = new string[size]; // Задаем массив
    for (int i = 0; i < size; i++)
    {
        if (arry[i].Length <= lengthLine)
        {
            arryResult[i] = arry[i];
        }
    }
    return arryResult;
}
Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите длину элемента массива: ");
int lengthLine = int.Parse(Console.ReadLine()!);

string[] arryBeging = InputMassive(size);
PrintMassive(arryBeging);

string[] arryResult = LengthLineThree(size, arryBeging, lengthLine);
PrintMassive(arryResult);


