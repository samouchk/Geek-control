﻿Console.Clear();
int LenAr(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        string el = arr[i];
        if (el.Length <= 3)
            count++;

    }
    return count;
}

void CorrectArray(string[] array, string[] Corarr)
{
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        string el = array[j];
        if (el.Length <= 3)
        {
            Corarr[k] = el;
            k++;
        }
    }
}

void PrintArr(string[] arr)
{

    for (int m = 0; m < arr.Length; m++)
    {
        Console.Write($"'{arr[m]}'");
    }

}


Console.WriteLine("Вводите элементы массива черезе пробел");
string input = Console.ReadLine();
string[] array = input.Split(" ");
int count = LenAr(array);
string[] CorArray = new string [count];
CorrectArray(array, CorArray);
PrintArr(CorArray);