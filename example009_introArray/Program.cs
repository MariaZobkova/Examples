using static System.Console;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int [] array = { 12, 2, 23, 83, 94, 55, 76, 47, 38, 59 };

int max = Max (
    Max(array[0], array[1], array[2]), 
    Max(array[4], array[5], array[6]), 
    Max(array[7], array[8], array[9]));

 

Write(max);
