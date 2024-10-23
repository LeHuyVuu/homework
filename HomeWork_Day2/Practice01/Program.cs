// See https://aka.ms/new-console-template for more information


using Practice01.MyUtilities;

while (true)
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    try
    {
        Console.Write("Nhập số ngày: ");
        int days = Utils.ParseInt(Console.ReadLine());

        int weeks = days / 7;
        int remainingDays = days % 7;

        Console.WriteLine($"Số tuần: {weeks}, Số ngày: {remainingDays}");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
