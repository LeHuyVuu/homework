namespace Practice01.MyUtilities;

public class Utils
{
    public static int ParseInt(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            throw new ArgumentException("Dữ liệu nhập không phải là số nguyên hợp lệ.");
        }
    }

    // Hàm kiểm tra nhập liệu hợp lệ, trả về giá trị số thực
    public static double ParseDouble(string input)
    {
        if (double.TryParse(input, out double result))
        {
            return result;
        }
        else
        {
            throw new ArgumentException("Dữ liệu nhập không phải là số thực hợp lệ.");
        }
    }
}