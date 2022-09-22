void FillArray(int[] collection)// заполняем массив числами с помощью метода FillArray
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }

}

void PrintArray(int[] col) //методом PrintArray выводим все элементы из массива в терминал
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int[] array = new int[10];  // определяем массив, в данный момент из 10 элементов

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;
}

FillArray(array); //вызывает массив
PrintArray(array); // распечатывает массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);