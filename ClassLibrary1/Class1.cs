public class Product
{
    //Fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoOfProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    // Set method for Product ID
    public void SetProductID(int value)
    {
        productID = value;
    }

    // Get method for Product ID
    public int GetProductID()
    {
        return productID;
    }

    // Set method for Product Name
    public void SetProductName(string value)
    {
        productName = value;
    }

    // Get method for Product Name
    public string GetProductName()
    {
        return productName;
    }

    // Set method for Product cost
    public void SetCost(double value)
    {
        cost = value;
    }

    // Get method for Product cost
    public double GetCost()
    {
        return cost;
    }

    // Set method for Product tax
    public void SetTax(double value)
    {
        tax = value;
    }

    // Get method for Product tax
    public double GetTax()
    {
        return tax;
    }

    //CalculateTax Method
    /*Cost <= 20000 then tax = 10%
     Cost > 20000 then tax = 12.5% */

    public void CalculateTax()
    {
        //Create local variable
        double t;

        //Calculate Tax
        if( cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }

        tax = t;
    }

    // Set method for Product quantity In Stock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    // Get method for Product quantity In Stock
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    // Get method for Product Date of Purchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }
}