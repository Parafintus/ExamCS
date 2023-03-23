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
