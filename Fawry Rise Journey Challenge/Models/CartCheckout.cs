namespace Fawry_Rise_Journey_Challenge.Models;

public class CartCheckout
{
    public static void Checkout(Cart cart,ref int balance)
    {
        if (cart.IsEmpty())
            throw new Exception("Cart is empty");

        int shippingCost = 0;
        var shippableItems = cart._items.Where(item => item.Products.IsShipping()).ToList();
        int subtotal = shippableItems.Sum(item => item.Products.Price * item.Quantity);

        if (shippableItems.Any())
        {
            shippingCost = 30;
            Shipping.ShippingItems(shippableItems);
        }

        int total = subtotal + shippingCost;
        if (balance < total)
            throw new Exception("Customer's balance is not enough.");

        foreach (var item in cart._items)
        {
            item.Products.Quantity -= item.Quantity;
        }

        Console.WriteLine("** Checkout receipt **");
        foreach (var item in shippableItems)
        {
            Console.WriteLine($"{item.Quantity}x {item.Products.Name} {item.Products.Price * item.Quantity}");
        }

        Console.WriteLine("----------------------");
        Console.WriteLine($"Subtotal         {subtotal}");
        Console.WriteLine($"Shipping         {shippingCost}");
        Console.WriteLine($"Amount           {total}");
        balance -= total;
    }
}