using System;

class Order
{
    public void Create() => Console.WriteLine("Замовлення створено");
}
class Payment
{
    public void Pay() => Console.WriteLine("Оплата пройшла");
}
class Delivery
{
    public void Send() => Console.WriteLine("Доставка оформлена");
}

class ShopFacade
{
    private Order o = new Order();
    private Payment p = new Payment();
    private Delivery d = new Delivery();

    public void MakeOrder()
    {
        o.Create();
        p.Pay();
        d.Send();
        Console.WriteLine(" Усе готово!");
    }
}

class Program
{
    static void Main()
    {
        var shop = new ShopFacade();
        shop.MakeOrder();
    }
}









