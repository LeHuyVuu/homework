// See https://aka.ms/new-console-template for more information

using Practice01.MyUtilities;

while (true)
{
    try
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số phút: ");
        int minutes = Utils.ParseInt(Console.ReadLine());

        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;

        Console.WriteLine($"Thời gian: {hours} giờ {remainingMinutes} phút");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}