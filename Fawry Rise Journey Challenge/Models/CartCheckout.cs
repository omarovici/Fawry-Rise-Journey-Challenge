using Fawry_Rise_Journey_Challenge.Interfaces;

namespace Fawry_Rise_Journey_Challenge.Models;

public class CartCheckout
{
    public void Checkout(Cart cart)
    {
        if(cart.IsEmpty())
            throw new Exception("Cart is empty");
        
        int subtotal = 0;
        int shippingCost = 0;
        List<IShipping>  shippings = new List<IShipping>();

        foreach (var item in cart._items)
        {
            if(item.Products.IsExpired())
                throw new Exception("Product is expired");
            if(item.Products.Quantity < item.Quantity)
                throw new Exception($"{item.Products.Quantity} is out of stock");
            
            subtotal += item.Products.Price * item.Quantity;
            if(item.Products.IsShipping() && item.Products is IShipping shippable)
                for(int i=0; i<item.Products.Quantity; i++)
                    shippings.Add(shippable);
        }
        if (shippings.Any())
        {
            shippingCost = 30;
            Shipping.ShippingItems(shippings);
        }
            
        int total = subtotal + shippingCost;
        foreach (var item in cart._items)
        {
            item.Products.Quantity -= item.Quantity;
        }
        Console.WriteLine("** Checkout receipt **");
        foreach (var item in cart._items)
        {
            Console.WriteLine($"{item.Quantity}x {item.Products.Name} {item.Products.Price * item.Quantity}");
        }
        Console.WriteLine("----------------------");
        Console.WriteLine($"Subtotal         {subtotal}");
        Console.WriteLine($"Shipping         {shippingCost}");
        Console.WriteLine($"Amount           {total}");
    }
}