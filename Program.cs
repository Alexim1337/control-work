string[] array = new string[] { "may", "20", "Wassup", "4", "Hello", "89", "JJJ" };
Console.WriteLine("Задан массив:");
int count = 0;


foreach (string s in array)
{
    Console.Write(s + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}

string[] resultArray = new string[count];
int j = 0;
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            resultArray[j++] = array[i];
    }
}
Console.WriteLine("\n\nЭлеменеты массива меньше 3 символов:");

foreach (string s in resultArray)
    Console.Write(s + " ");
