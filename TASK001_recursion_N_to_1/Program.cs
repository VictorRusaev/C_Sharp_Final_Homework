Console.Clear();

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int[] arrayN = ListOfNaturalNumbers(n);
PrintArray(arrayN);

int[] ListOfNaturalNumbers(int number)
{
    int[] naturalArray = new int[number];
    for (int i = 0; i < naturalArray.Length; i++)
    {
        if (number != 0)
        {
            naturalArray[i] = number;
            number--;
            ListOfNaturalNumbers(number);
        }
    }
    return naturalArray;
}

void PrintArray(int[] arr)
{
    Console.Write(String.Join(", ", arr));
}