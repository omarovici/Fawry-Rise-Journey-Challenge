using Fawry_Rise_Journey_Challenge.Interfaces;

namespace Fawry_Rise_Journey_Challenge.Models;

public class Shipping
{
    public void ShippingItems(List<IShipping> items)
    {
        Console.WriteLine("** Shipment notice **");
        int totalWeight = 0;
        foreach (var item in items.GroupBy(prod=>prod.GetName()))
        {
            int count = item.Count();
            int weight = item.First().GetWeight();
            int groupWeight = weight * count;
            totalWeight += groupWeight;
            Console.WriteLine($"{count}x {item.Key} {groupWeight}g");
        }
        Console.WriteLine($"Total package weight {totalWeight}g\n");
    }
}