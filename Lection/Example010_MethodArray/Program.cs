int [] array = {1,2,38,4,5,6,7,38};


int n = array.Length;
int find = 38;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine (index);
        break;
    }
    index ++;
}