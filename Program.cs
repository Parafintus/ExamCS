string[] array1 = new string[5] { "987", "Geek", "hello", "world", "res" };
string[] array2 = new string[array1.Length];
void FindElementsToArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
FindElementsToArray(array1, array2);
PrintArray(array2);