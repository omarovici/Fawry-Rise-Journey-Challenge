namespace Fawry_Rise_Journey_Challenge.Models;

public class ExpiredProduct(string name, int price, int quantity, DateTime expired)
    : Products(name, price, quantity)
{
    private DateTime Expired { get; set; } = expired;

    public override bool IsExpired() => DateTime.Now > Expired;
}