int[] CreateRandomArray(int FirstPoint, int LastPoint, int arrayLength)
{
    Random rand = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rand.Next(FirstPoint, LastPoint + 1);
    }
    return array;
}

int GetUserArray()
{
    int result;
    System.Console.Write("Введите количество элементов, которое вы хотите видеть в массиве: ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        System.Console.Write("Вы ввели некоректные данные, просьба ввести число элементов массива: ");
    }
    return result;
}

int[] GetEvenValuesArray(int[] initArray)
{
    int evenArrayLength = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i] % 2 == 0)
        {
            evenArrayLength++;
        }
    }

    int[] evenArray = new int[evenArrayLength];
    int index = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i] % 2 == 0)
        {
            evenArray[index] = initArray[i];
            index++;
        }
    }
    return evenArray;
}

void PrintArrayToConsole(int[] array)
{
    foreach (int space in array)
    {
        System.Console.Write(space + " ");
    }
    System.Console.WriteLine();
}


int FirstPoint = -100;
int LastPoint = 100;
int[] initArray, evenArray;

initArray = CreateRandomArray(FirstPoint, LastPoint, GetUserArray());
PrintArrayToConsole(initArray);
evenArray = GetEvenValuesArray(initArray);
PrintArrayToConsole(evenArray);