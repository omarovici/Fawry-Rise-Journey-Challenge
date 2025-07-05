namespace Fawry_Rise_Journey_Challenge.Models;

public class Products(string name, int price, int quantity)
{
    public string Name { get; set; } = name;
    protected int Price { get; set; } = price;
    public int Quantity { get; set; } = quantity;

    public virtual bool IsExpired() => false;
    public virtual bool IsShipping() => false;
}