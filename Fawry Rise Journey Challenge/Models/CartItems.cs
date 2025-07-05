namespace Fawry_Rise_Journey_Challenge.Models;

public class CartItems(Products products, int quantity)
{
    public Products Products { get; set; } = products;
    public int Quantity { get; set; } = quantity;
}