string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] myArray = { "I", "am", "diveloper", "J_J", "^_^" };

int Max_Word_Length = 3;

void PrintArray(string[] P_arr)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < P_arr.GetLength(0); i++)
    {
        if (i < P_arr.GetLength(0) - 1) Console.Write(P_arr[i] + ", ");
        else Console.Write(P_arr[i] + " ");
    }
    Console.Write("]");
}

void SortArray(string[] S_arr)
{
    int count = 0;
    Console.Write("\nSort words (with simbols < 3) = ");
    Console.Write("[ ");
    for (int i = 0; i < S_arr.GetLength(0); i++)
    {
        if (S_arr[i].Length <= Max_Word_Length)
        {
            if (i < S_arr.GetLength(0) - 1) Console.Write(S_arr[i] + ", ");
            else Console.Write(S_arr[i] + " ");
            count++;
        }

    }
    if (count < 1) Console.Write("'Array is empty =(' ");
    Console.Write("]");
}

PrintArray(myArray);
SortArray(myArray);

Console.WriteLine();
Console.WriteLine();

PrintArray(array1);
SortArray(array1);

Console.WriteLine();
Console.WriteLine();

PrintArray(array2);
SortArray(array2);

Console.WriteLine();
Console.WriteLine();

PrintArray(array3);
SortArray(array3);