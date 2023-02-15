using static System.Console;
Clear();

Write("Enter several value in string by space: ");
string[] userStringArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] selectedArray = SelectionArray(userStringArray);
PrintArray(selectedArray);

string[] SelectionArray(string[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) quantity++;
    }

    if  (quantity == 0) quantity = 1;
    string[] resultArray = new string[quantity];
    int count = 0;

    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length <= 3)
        {
            resultArray[count] = array[k];
            count++;
        }   
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    Write($"[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }
    Write($"{array[array.Length - 1]} ]");
}
