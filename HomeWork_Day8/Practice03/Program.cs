// See https://aka.ms/new-console-template for more information

int[] arr = { 1, 1, 2, 2, 2, 3, 4, 4, 5, 6 };
int[] result = arr.Distinct().ToArray();
Console.WriteLine(string.Join(",", result));