Console.Clear();
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        string elem = Console.ReadLine();
        array[i] = elem;
    }
}
void CorrectArray(string[] array, string[] Corarr)
{

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
            Corarr[j] = array[j];
        if (array[j].Length > 3)
            Corarr[j] = "";

    }
}
void PrintArr(string[] arr)
{

    for (int m = 0; m < arr.Length; m++)
    {
        if (arr[m] != "")
            Console.Write($"'{arr[m]}'");
    }

}


Console.WriteLine("Укажите размер массива: ");
int l = Convert.ToInt32(Console.ReadLine());
string[] array = new string[l];
string[] CorArray = new string [l];
FillArray(array);
CorrectArray(array, CorArray);
PrintArr(CorArray);