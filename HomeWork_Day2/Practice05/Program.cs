using Practice01.MyUtilities;

while (true)
{
    try
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số tiền USD: ");
        double usdAmount = Utils.ParseDouble(Console.ReadLine());

        Console.WriteLine("Nhập tỉ giá USD sang VND: ");
        double exchangeRate = Utils.ParseDouble(Console.ReadLine());

        double vndAmount = usdAmount * exchangeRate;

        Console.WriteLine($"Số tiền tương ứng bằng VND: {vndAmount}");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}