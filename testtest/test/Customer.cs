using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Customer
{
    private List<Order> _orderHistory;

    // Properties
    public string Name { get; set; }
    public string Email { get; set; }

    // Readonly property for order history
    public IReadOnlyCollection<Order> OrderHistory
    {
        get { return _orderHistory.AsReadOnly(); }
    }

    // Constructor
    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
        _orderHistory = new List<Order>();
    }

    // Method to add an order to the customer's order history
    public void AddOrder(Order order)
    {
        _orderHistory.Add(order);
    }
}