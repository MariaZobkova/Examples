using static System.Console;

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2; 
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 32;
int a2 = 59;
int a3 = 150;
int b1 = 38;
int b2 = 155;
int b3 = 5;
int c1 = 95;
int c2 = 209;
int c3 = -3;

//int max = Max (Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int max = Max(max1, max2, max3); 

Write(max);