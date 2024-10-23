// See https://aka.ms/new-console-template for more information

int[] arr = { 2, 7, 11, 15 };
Console.Write("Target: ");
int target = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] + arr[j] == target)
        {
            Console.WriteLine("Index: [" + i + ", " + j + "]");
            break;
        }
    }
}