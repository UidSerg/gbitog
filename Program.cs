Console.Write("Введите через запятую элементы массива: ");
string[] elementArray = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

/// <summary>
/// метод формирует массив элементов длина которых не превышает N символа из входящего массива
/// </summary>
/// <param name="Array">входящий массив</param>
/// <param name="N">колличество символов</param>
/// <returns>итоговый массив</returns>
string [] LengthArray (string [] Array, int N)
{
int size = elementArray.Length;
int newSize = 0;
for (int i = 0; i < size; i++)
{
    if (elementArray[i].Length <= N)
    {
        newSize++;
    }
}

string[] resultArray = new string[newSize];
int j = 0; //счетчик для заполнения нового массива
for (int i = 0; i < size; i++)
{
    if (elementArray[i].Length <= N )
    {
        resultArray[j] = elementArray[i];
        j++;
    }
   
}
return resultArray;
}
int N = 3; //длина элента для нового массива
string [] resultArray = LengthArray(elementArray, N);
Console.WriteLine($"[{String.Join(",", elementArray)}] -> [{String.Join(",", resultArray)}]");
