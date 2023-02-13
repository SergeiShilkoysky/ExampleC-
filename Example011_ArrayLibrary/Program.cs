void FillArray(int[] collection) // метод заполнения массива случайными числами
        {
            int length = collection.Length;
            int index = 0;
            while (index < length)
            {
                collection[index] = new Random().Next(1, 10);
                index++;
            }
        }

void PrintArray(int[] col) // метод печати массива
        {
            int count = col.Length;
            int position = 0;
            while (position < count)
            {
                Console.WriteLine(col[position]);
                position++;
            }
        }

 int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если оставить 0 то при поиске числа напр 44 не из масс. будет 0 индекс 

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // осстановит поиск после первой 4ки иначе будут все 4 и индекс последней
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //новый массив на 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // результат поиск в массива 4
Console.WriteLine(pos);

