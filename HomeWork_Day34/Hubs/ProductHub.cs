using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorProductManagement.Data;
using Microsoft.AspNetCore.SignalR;

public class ProductHub : Hub
{
    private readonly ProductService _productService;

    public ProductHub(ProductService productService)
    {
        _productService = productService;
    }

    public override async Task OnConnectedAsync()
    {
        Console.WriteLine($"Connected client-id: {Context.ConnectionId}");
        await Clients.Caller.SendAsync("GetAllProduct", _productService.GetProducts());
    }

    public async Task AddProduct(Product newProduct)
    {
        _productService.AddProduct(newProduct);
        var updatedList = _productService.GetProducts();
        await Clients.All.SendAsync("GetAllProduct", updatedList);
    }

    public async Task DeleteProduct(int id)
    {
        _productService.DeleteProduct(id);
        var updatedList = _productService.GetProducts();
        await Clients.All.SendAsync("GetAllProduct", updatedList);
    }



    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        Console.WriteLine($"Disconnected client-id: {Context.ConnectionId}");
        await base.OnDisconnectedAsync(exception);
    }
}
