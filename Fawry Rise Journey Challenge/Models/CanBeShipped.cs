using Fawry_Rise_Journey_Challenge.Interfaces;

namespace Fawry_Rise_Journey_Challenge.Models;

public class CanBeShipped(string name, int price, int quantity, DateTime expired, int weight)
    : ExpiredProduct(name, price, quantity, expired), IShipping
{
    private int Weight { get; set; } = weight;

    public string GetName() => Name;
    public int GetWeight() => Weight;
}