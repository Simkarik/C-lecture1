int a1 = 12, b1 = 43, c1 = 53, a2 = 32, b2 = 11, c2 = 44, a3 = 65, b3 = 87, c3 = 63;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
