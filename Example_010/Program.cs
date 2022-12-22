int[] array = { 12, 32, 53, 22, 55, 123, 56, 34 };

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
