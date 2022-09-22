// Нахождение максимум

//              0    1   2   3   4   5    6   7   8   9
int[] array = { 13, 22, 43, 14, 45, 66, 872, 82, 99, 14};
//  array[0] = 12; -- поменять значение в массиве
//  Console.WriteLine(array[0]);
int n = array.Length;
int find = 14;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}