using System;
using static System.Console;

Clear();
WriteLine("Введите максимальное кол-во символов в элементе финального массива: ");
int maxSimbols = Convert.ToInt32(ReadLine());
WriteLine("Введите кол-во элементов в массиве: ");
int initialArrayLength = Convert.ToInt32(ReadLine());

string[] initialArray = GetInitialArray(initialArrayLength);
string[] finalArray = GetFinalArray(maxSimbols, initialArray);
PrintArray(initialArray);
PrintArray(finalArray);

string[] GetInitialArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < result.Length; i++)
    {
        WriteLine($"Введите {i + 1} элемент массива: ");
        result[i] = ReadLine();
    }
    return result;
}

void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"''{array[i]}''");
        if (i < array.Length - 1)
        {
            Write(", ");
        }
    }
    WriteLine("]");
}

string[] GetFinalArray(int max, string[] array)
{
    string[] result = new string[0];
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= max)
        {
            Array.Resize(ref result, result.Length + 1);
            result[i] = array[j];
            i = i + 1;
        }
    }
    return result;
}



