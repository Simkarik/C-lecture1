int[] array = {11, 21, 41, 43, 55, 123, 345, 12, 98};
int max = array[0];
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

for(int i = 0; i < 9; i++)
{
   if(max < array[i])
   { 
   max = array[i];
   }
}

Console.WriteLine(max);
