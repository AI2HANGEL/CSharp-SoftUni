using System;
using System.Collections.Generic;

public class Restaurant
{
    private List<Customer> _customers;
    private List<MenuItem> _menu;

    // Constructor
    public Restaurant()
    {
        _customers = new List<Customer>();
        _menu = new List<MenuItem>();
    }

    // Method to add a customer to the restaurant
    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    // Method to get a menu item by index
    public MenuItem GetMenuItem(int index)
    {
        if (index < 0 || index >= _menu.Count)
        {
            throw new IndexOutOfRangeException("Index is out of bounds");
        }

        return _menu[index];
    }

    // Method to add a menu item to the restaurant's menu
    public void AddMenuItem(MenuItem item)
    {
        _menu.Add(item);
    }

    // Method to place an order for a customer
    public void PlaceOrder(Customer customer, Order order)
    {
        customer.AddOrder(order);
    }

    // Method to display the menu
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Items:");
        foreach (var item in _menu)
        {
            Console.WriteLine(item);
        }
    }

    // Method to display the order history for a customer
    public void DisplayOrderHistory(Customer customer)
    {
        Console.WriteLine($"{customer.Name}'s Order History:");
        foreach (var order in customer.OrderHistory)
        {
            Console.WriteLine($"Order Total: ${order.GetTotal()}");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"  {item}");
            }
        }
    }
}