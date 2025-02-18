using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using HomeWork_Day34.Data;
using BlazorProductManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapHub<ProductHub>("/product-hub");
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
