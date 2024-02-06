using Task2;

static void PrintArray(int[] array)
{
    foreach (var element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

int[] inputArray = { 1, 2, 3, 4, 4, 56 };

DuplicateRemover duplicateRemover = new DuplicateRemover();
int[] resultArray = duplicateRemover.RemoveDuplicates(inputArray);

Console.WriteLine("Original Array:");
PrintArray(inputArray);

Console.WriteLine("\nArray after removing duplicates:");
PrintArray(resultArray);