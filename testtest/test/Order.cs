using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Order
{
    // Private list of menu items
    private List<MenuItem> _items;

    // Constructor
    public Order()
    {
        _items = new List<MenuItem>();
    }

    // Method to add an item to the collection
    public void AddItem(MenuItem item)
    {
        _items.Add(item);
    }

    // Method to get the total cost of all items in the collection
    public decimal GetTotal()
    {
        decimal total = 0;
        foreach (var item in _items)
        {
            total += item.Price;
        }
        return total;
    }

    // ReadOnly property to access the collection
    public IReadOnlyCollection<MenuItem> Items
    {
        get { return new ReadOnlyCollection<MenuItem>(_items); }
    }
}
