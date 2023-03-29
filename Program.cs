Console.Write("Введите через запятую элементы массива: ");
string[] elementArray = Console.ReadLine().Split(",");
/// <summary>
/// метод формирует массив элементов длина которых не превышает 3 символа из входящего массива
/// </summary>
/// <param name="Array">входящий массив</param>
/// <returns>итоговый массив</returns>
string [] LengthArray (string [] Array)
{
int size = elementArray.Length;
int newSize = 0;
for (int i = 0; i < size; i++)
{
    if (elementArray[i].Length <= 3)
    {
        newSize++;
    }
}
/*
if (newSize == 0)
{
   Console.WriteLine($"в массиве [{String.Join(",", elementArray)}] нет элементов короче 3х символов"); 
   return;
}*/

string[] resultArray = new string[newSize];
int j = 0;
for (int i = 0; i < size; i++)
{
    if (elementArray[i].Length <= 3)
    {
        resultArray[j] = elementArray[i];
        j++;
    }
   
}
return resultArray;
}

string [] resultArray = LengthArray(elementArray);
Console.WriteLine($"[{String.Join(",", elementArray)}] -> [{String.Join(",", resultArray)}]"); 