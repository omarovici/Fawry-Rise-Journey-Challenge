using Fawry_Rise_Journey_Challenge.Models;

namespace Fawry_Rise_Journey_Challenge;

class Program
{
    static void Main(string[] args)
    {
        int balance = 1000;
        var cheese = new ShippedAndExpiredProducts("Cheese",100,55,DateTime.Now.AddDays(30),200);
        var biscuits = new ShippedAndExpiredProducts("Biscuits",150,5,DateTime.Now.AddDays(30),700);
        var tv = new ShippingProduct("TV", 5000, 3, 5000);
        var scratchCard = new Products("Scratch Card", 50, 5);

        var cart = new Cart();
        cart.Add(cheese,2);
        cart.Add(biscuits,1);
        cart.Add(tv,3);
        cart.Add(scratchCard,1);
        CartCheckout.Checkout(cart,ref balance);
        
        // Console.WriteLine(balance);
        
        // var cart1 = new Cart();
        // cart1.Add(cheese,5);
        // cart1.Add(biscuits,1);
        // cart1.Add(scratchCard,1);
        // CartCheckout.Checkout(cart1,ref balance);
        //
        // Console.WriteLine(balance);

    }
}