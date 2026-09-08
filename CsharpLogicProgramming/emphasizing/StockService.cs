public class StockService {

    public static List<Product> ProductsList { get; set; } = new List<Product>();

    public static void AddProduct(Product product) {
        System.Console.WriteLine($"receveing this product: {product.ProductName}");
        ProductsList.Add(product);
    }

    public static string RemoveProduct(int productId) {
        Product matchingProduct = ProductsList.Find(product => product.Id == productId);

        string logMessage;

        if (ProductsList.Count == 0) {
            logMessage = "There isn't any product on stock yet";
        }

        else if (matchingProduct == null) {
            logMessage = "This Product id wasn't found";

        }
        else {
            ProductsList.Remove(matchingProduct);
            logMessage = "product removed with success";

        }

        return logMessage;



    }

    public static List<Product> GetProductsList() {
        return ProductsList;
    }



}