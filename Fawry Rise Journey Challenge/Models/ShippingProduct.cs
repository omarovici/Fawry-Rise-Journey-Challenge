using Fawry_Rise_Journey_Challenge.Interfaces;

namespace Fawry_Rise_Journey_Challenge.Models;

public class ShippingProduct(string name, int price, int quantity, int weight)
    : Products(name, price, quantity), IShipping
{
    private int Weight { get; set; } = weight;

    public string GetName() => Name;

    public int GetWeight() => Weight;
}