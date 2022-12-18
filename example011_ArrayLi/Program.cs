void FillArray(int [] collection)
{
    int size = collection.Length;
    int index = 0;
    
    while (index < size)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int [] col)
{
    int Len = col.Length;
    int count = 0;

    while (count < Len)
    {
        Console.WriteLine (col[count]);
        count++;
    } 
}

int IndexOf (int[] collection, int find)
{
    int size = collection.Length;
    int index = 0;
    int position = 0;
    return position;

    while (index < size)
    {
        if (collection [index]== find)
        {
            position = index;
        }
        index++;

    }
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);