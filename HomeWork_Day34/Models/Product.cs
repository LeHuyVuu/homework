namespace BlazorProductManagement.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }  // Đảm bảo thuộc tính này tồn tại
        public string ImageUrl { get; set; }
    }
}
