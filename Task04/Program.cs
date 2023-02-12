 int [] SomeElements(int size, int minValue, int maxValue)
{
int [] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int[] Massiv = SomeElements (5, 0, 5);

Console.WriteLine(String.Join(" ", Massiv));

System.Console.Write("Enter your name: ");
int temp = int.Parse(Console.ReadLine());

bool Yes = false;

foreach (var i in Massiv)
{
if (Math.Abs(i) == Math.Abs(temp))
Yes = true;
}

if (Yes) System.Console.WriteLine("yes");
else
{
System.Console.WriteLine("no");
}
