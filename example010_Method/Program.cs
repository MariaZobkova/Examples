int[] array = { 1, 2, 5, 6, 9, 7, 8, 4 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    
    index++;
    
}
