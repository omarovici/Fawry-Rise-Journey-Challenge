namespace Fawry_Rise_Journey_Challenge.Models;

public class Cart
{
    public List<CartItems> _items = new List<CartItems>();

    public void Add(Products products, int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");
        if (quantity > products.Quantity)
            throw new ArgumentException(
                $"The product {products.Name} is out of stock.\nYou cannot add more than {products.Quantity}.");
        _items.Add(new CartItems(products, quantity));
    }

    public bool IsEmpty() => !_items.Any();
}