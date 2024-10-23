// See https://aka.ms/new-console-template for more information

using Practice01.MyUtilities;

while (true)
{
    try
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số tiền gốc: ");
        double originalAmount = Utils.ParseDouble(Console.ReadLine());

        Console.WriteLine("Nhập tỉ lệ thuế VAT (x%): ");
        double vatPercentage = Utils.ParseDouble(Console.ReadLine());

        double vatAmount = originalAmount * vatPercentage;
        double totalAmount = originalAmount + vatAmount;

        Console.WriteLine($"Tổng tiền sau khi cộng thêm VAT: {totalAmount}");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}