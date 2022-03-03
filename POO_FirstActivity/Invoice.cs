namespace POO_FirstActivity
{
    public class Invoice
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }
        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }
        public decimal ValueToPay()
        {
            decimal total = 0;
            foreach (Product product in _products)
            {
                total += product.ValueToPay();
            }
            return total;
        }
        public override string ToString()
        {
            string productsInfo = "";
            foreach (Product product in _products)
            {
                productsInfo += product.ToString() + "\n";
            }
            return $"RECEIPT \n" +
                $"-------------------------------------------------- \n" +
                $"{productsInfo}" +
                $"                    ============= \n" +
                $"TOTAL: {$"              {ValueToPay():C2}",13}";
        }
    }
}

