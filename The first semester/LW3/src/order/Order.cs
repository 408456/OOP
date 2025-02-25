using LW3.src.discount;
using LW3.src.order;
using LW3.src;

public class Order
{
    public Customer Customer { get; set; }
    public List<Dish> Dishes { get; set; }
    public OrderState State { get; set; }
    public decimal TotalCost { get; set; }
    public IDiscountStrategy DiscountStrategy { get; set; }
    public DateTime? DeliveryTime { get; set; }

    public Order(Customer customer, List<Dish> dishes, IDiscountStrategy discountStrategy)
    {
        Customer = customer;
        Dishes = dishes;
        State = OrderState.InProgress;
        DiscountStrategy = discountStrategy;
        TotalCost = CalculateTotalCost();
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var dish in Dishes)
        {
            total += dish.Price;
        }
        return DiscountStrategy.ApplyDiscount(total);
    }

    public void NextState()
    {
        State.Next(this);
    }

    public string GetOrderStatus()
    {
        return State.GetStatus();
    }
}
