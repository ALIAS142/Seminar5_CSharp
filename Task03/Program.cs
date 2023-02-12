// Программа, которая определяет, присутствует ли заданное число в массиве: 4; [6, 8, 4, 9]-> да.

int [] Array = GetArray(4, -8, 8);
System.Console.WriteLine(String.Join(" ", Array));


int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int n = Array.Length;
int find = 4;
int i = 0;

while (i < n)
{
 if(Array[i] == find)
{
 System.Console.WriteLine($"{find} - > yes");
}
    
i = i + 1;
}
