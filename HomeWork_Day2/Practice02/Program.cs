// See https://aka.ms/new-console-template for more information


using Practice01.MyUtilities;

while (true)
{
    try
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập giá trị đơn hàng: ");
        double orderValue = Utils.ParseDouble(Console.ReadLine());

        Console.WriteLine("Nhập phần trăm giảm giá (x%):  ");
        double discountPercentage = Utils.ParseDouble(Console.ReadLine());

        double discountAmount = orderValue * discountPercentage;
        double totalPrice = orderValue - discountAmount;

        Console.WriteLine($"Số tiền giảm: {discountAmount}, Tổng sau giảm giá: {totalPrice}");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}
