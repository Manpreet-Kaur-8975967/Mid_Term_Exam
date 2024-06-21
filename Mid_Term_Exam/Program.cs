using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Not enough stock to sell the requested quantity.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Name: {ItemName} \nID: {ItemId} \nPrice: {Price:C} \nQuantity: {QuantityInStock}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Demonstrate functionality
        Console.WriteLine("Initial Inventory Details:");
        item1.PrintDetails();
        //Console.WriteLine("\n");
        item2.PrintDetails();

        // 1. Update Price of all items.
        Console.WriteLine("\nUpdated Price of Items:");
        item1.UpdatePrice(1250.20);
        //Console.WriteLine("\n");
        item2.UpdatePrice(850.40);
        Console.WriteLine("\nAfter Selling Items:");
        item1.PrintDetails();
        //Console.WriteLine("\n");
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.
        item1.SellItem(3);
        Console.WriteLine("\n");
        item2.SellItem(12);
        Console.WriteLine("\nAfter Selling Items:");
        item1.PrintDetails();
        Console.WriteLine("\n");
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.
        item1.RestockItem(5);
        Console.WriteLine("\n");
        item2.RestockItem(10);
        Console.WriteLine("\nAfter Restocking Items:");
        item1.PrintDetails();
        Console.WriteLine("\n");
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine();
        if (item1.IsInStock())
        {
            Console.WriteLine($"{item1.ItemName} is in stock.");
        }
        else
        {
            Console.WriteLine($"{item1.ItemName} is out of stock.");
        }

        if (item2.IsInStock())
        {
            Console.WriteLine($"{item2.ItemName} is in stock.");
        }
        else
        {
            Console.WriteLine($"{item2.ItemName} is out of stock.");
        }
    }
}
