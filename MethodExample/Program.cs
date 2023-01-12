class Sample
{
    //Using ClassLibrary1 in reference
    static void Main()
    {
        //Create reference varaibles
        Product product1, product2, product3;

        //Create objects
        product1 = new Product();
        Product.TotalNoOfProducts++; //1
        product2 = new Product();
        Product.TotalNoOfProducts++; //2
        product3 = new Product(); 
        Product.TotalNoOfProducts++; //3

        //Intializing Fields
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);

        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);

        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        //Call method for tax
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();


        //Display value from fields
        System.Console.WriteLine("\nProduct 1");
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Product cost: " + product1.GetCost());
        System.Console.WriteLine("Product quantityInStock: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Product dateOfPurchase: " + product1.GetDateOfPurchase());
        System.Console.WriteLine("Product Tax: " + product1.GetTax());

        System.Console.WriteLine("\nProduct 2");
        System.Console.WriteLine("Product ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Product cost: " + product2.GetCost());
        System.Console.WriteLine("Product quantityInStock: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Product dateOfPurchase: " + product2.GetDateOfPurchase());
        System.Console.WriteLine("Product Tax: " + product2.GetTax());

        System.Console.WriteLine("\nProduct 3");
        System.Console.WriteLine("Product ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Product cost: " + product3.GetCost());
        System.Console.WriteLine("Product quantityInStock: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Product dateOfPurchase: " + product3.GetDateOfPurchase());
        System.Console.WriteLine("Product Tax: " + product3.GetTax());

        int TotalQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();

        System.Console.WriteLine("\nTotal Quantity: " + TotalQuantity);
        System.Console.WriteLine("Total No. Of Products: " + Product.TotalNoOfProducts);
        System.Console.WriteLine("Category Name: " + Product.CategoryName);

        if (product1.cost > product2.cost && product1.cost > product3.cost)
            System.Console.WriteLine("\nProduct 1 cost is highest.");

        if (product2.cost > product1.cost && product2.cost > product3.cost)
            System.Console.WriteLine("\nProduct 2 cost is highest.");

        if (product3.cost > product2.cost && product3.cost > product1.cost)
            System.Console.WriteLine("\nProduct 3 cost is highest.");

        System.Console.ReadKey();
    }

}