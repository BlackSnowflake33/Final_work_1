# Заключительное задание

[Задача](#задача)

[Задание 2. Создание алгоритма решения задачи](#задание-2-создание-алгоритма-решения-задачи)

[Задание 3. Решение задачи на C#](#задание-3-решение-задачи-на-c)


## **Задача**: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

___

## **Задание 2. Создание алгоритма решения задачи**
В папке  находится файл с изображением блок-схемы.

___

## **Задание 3. Решение задачи на C#**

```
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
```
________
