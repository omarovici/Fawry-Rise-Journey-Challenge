using Fawry_Rise_Journey_Challenge.Interfaces;

namespace Fawry_Rise_Journey_Challenge.Models;

public class Shipping
{
    public static void ShippingItems(List<CartItems> cartItems)
    {
        Console.WriteLine("** Shipment notice **");
        int totalWeight = 0;
        foreach (var group in cartItems
                     .Where(item => item.Products is IShipping)
                     .GroupBy(item => ((IShipping)item.Products).GetName()))
        {
            int quantity = group.Sum(item => item.Quantity);
            var shippingProduct = (IShipping)group.First().Products;
            int weight = shippingProduct.GetWeight();
            int groupWeight = weight * quantity;
            totalWeight += groupWeight;
            Console.WriteLine($"{quantity}x {group.Key} {groupWeight}g");
        }

        string totalWeightStr = totalWeight >= 1000
            ? $"{totalWeight / 1000.0}kg"
            : $"{totalWeight}g";
        Console.WriteLine($"Total package weight {totalWeightStr}\n");
    }
}