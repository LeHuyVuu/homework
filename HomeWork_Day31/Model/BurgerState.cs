public class BurgerState
{
    public event Action? OnChange;

    public List<Ingredient> lst = new()
    {
        new Ingredient { Name = "Salad", UnitPrice = 10, Quantity = 1 },
        new Ingredient { Name = "Cheese", UnitPrice = 20, Quantity = 2 },
        new Ingredient { Name = "Beef", UnitPrice = 55, Quantity = 0 }
    };

    public void AddIngredient(string name)
    {
        Ingredient? found = lst.FirstOrDefault(x => x.Name == name);
        if (found != null)
        {
            found.Quantity++;
            NotifyStateChanged();
        }
    }

    public void RemoveIngredient(string name)
    {
        Ingredient? found = lst.FirstOrDefault(x => x.Name == name);
        if (found != null && found.Quantity > 0)
        {
            found.Quantity--;
            NotifyStateChanged();
        }
    }

    public double Total()
    {
        return lst.Sum(item => item.UnitPrice * item.Quantity);
    }

    private void NotifyStateChanged()
    {
        Console.WriteLine("State changed!"); // Log kiểm tra xem sự kiện có chạy không
        OnChange?.Invoke();
    }
}
