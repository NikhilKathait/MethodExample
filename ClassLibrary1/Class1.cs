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

    //Method
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
}