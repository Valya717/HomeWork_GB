int size = new Random().Next (10,21);
int [] array = new int[size];
for( int i = 0; i<size; i ++)
{
    array[i] =new Random().Next(1,10);
}
for( int i = 0; i<size; i ++)
{
    Console.Write(array[i]+ " ");
}
Console.WriteLine();

int count = 0;
for( int i = 0; i<size; i ++)
{
    if (array[i]%2 ==0)
    {
        count ++;
    }
}
int [] array_new = new int [count];
int pos =0;
for( int i = 0; i<size; i ++)
{
    if(array[i]%2==0)
    {
        array_new[pos] = array[i];
        pos++;
    }
}

for( int i = 0; i<count; i ++)
{
    Console.Write(array_new[i]+ " ");
}
Console.WriteLine();