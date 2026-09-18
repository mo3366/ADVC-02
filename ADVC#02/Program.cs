namespace ADVC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> catalog = new()
            {
            new Product { Id = 1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id = 2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id = 3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id = 4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id = 5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id = 6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id = 7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            new Product { Id = 8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id = 9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            new Product { Id = 10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };

            #region Task 01 : Smart Product Search

            //1. All Electronics products
            Console.WriteLine("-- Electronics --");

            List<Product> filteredProducts01 = Product.SearchProducts(catalog, p => p.Category == "Electronics");
            filteredProducts01.ForEach(p => Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})"));

            //2. Products cheaper than $50
            Console.WriteLine();
            Console.WriteLine("-- Under $50 --");
            List<Product> filteredProducts02 = Product.SearchProducts(catalog, p => p.Price < 50);
            filteredProducts02.ForEach(p => Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})"));

            //3. Products that are in stock (Stock > 0)
            Console.WriteLine();
            Console.WriteLine("-- In Stock --");
            List<Product> filteredProducts03 = Product.SearchProducts(catalog, p => p.Stock > 0);
            filteredProducts03.ForEach(p => Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})"));

            //4. Clothing products under $100
            Console.WriteLine();
            Console.WriteLine("-- Clothing under $100 --");

            List<Product> filteredProducts04 = Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
            filteredProducts04.ForEach(p => Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})"));
            Console.WriteLine();


            //// Func<Product, bool> is used because the filter takes a Product and returns true or false.

            #endregion

            #region  Task 03 : Custom Report Generator -> 3.1 Print Reports
            ////Scenario 1
            //Console.WriteLine();
            //Console.WriteLine("-- Short Report --");
            //Product.PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));
            ////Scenario 2
            //Console.WriteLine();
            //Console.WriteLine("-- Detailed Report --");
            //Product.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}")); 


            // Action<Product> is used because it takes a Product and performs an action without returning a value.

            #endregion

            #region 3.2. Transform Products
            ////Scenario 3
            //Console.WriteLine("-- Summary List --");
            //List<string> stringList = Product.TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
            // stringList.ForEach(p => Console.WriteLine(p));

            ////Scenario 4
            //Console.WriteLine();
            //Console.WriteLine("-- Price Levels --");
            //List<string> stringList02 = Product.TransformProducts(catalog, p => p.Price > 100 ? $"{p.Name}: Expensive!" : $"{p.Name}: Affordable");
            //stringList02.ForEach(p => Console.WriteLine(p));



            // Func<Product, string> is used because it takes a Product and returns a transformed string.
            #endregion

            #region 3.3. Filter Products
            //Scenario 5
            //Console.WriteLine("-- Low-Stock Alert --");
            //List<Product> PredicateProduct = Product.FilterProducts(catalog, p =>p.Stock<20);
            //PredicateProduct.ForEach(p => Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!"));



            // Predicate<Product> is used because it checks a condition and returns true or false.

            #endregion


        }
    }
}
