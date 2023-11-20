Dictionary<string, Tuple<double, int>> products = new Dictionary<string, Tuple<double, int>>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "buy")
    {
        break;
    }

    string[] productInfo = input.Split();

    string productName = productInfo[0];
    double productPrice = double.Parse(productInfo[1]);
    int productQuantity = int.Parse(productInfo[2]);

    if (products.ContainsKey(productName))
    {
        var existingProduct = products[productName];
        int existingQuantity = existingProduct.Item2;
        double existingPrice = existingProduct.Item1;

        existingQuantity += productQuantity;
        if (existingPrice != productPrice)
        {
            existingPrice = productPrice;
        }

        products[productName] = Tuple.Create(existingPrice, existingQuantity);
    }
    else
    {
        products.Add(productName, Tuple.Create(productPrice, productQuantity));
    }
}

foreach (var pair in products)
{
    string productName = pair.Key;
    double totalPrice = pair.Value.Item1 * pair.Value.Item2;
    Console.WriteLine($"{productName} -> {totalPrice:F2}");
}