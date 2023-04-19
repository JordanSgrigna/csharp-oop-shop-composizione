using csharp_composizione_shop;

Shop Eurospin = new Shop("Eurospin", "Roma", "Via Paolo", "42");

Product Insalata = new Product("Insalata", "Iceberg", 0.89f, "Verdura");
Product Carne = new Product("Carne", "Manzo", 4.00f, "Carne");
Product Gelato = new Product("Gelato alla fragola", "Dessert", 2.50f, "Dolce");

List<Product> newProductList = new List<Product> { Insalata, Carne, Gelato };
Eurospin.AddNewProductListToShopList(newProductList);

string shopInfo = Eurospin.PrintShopInfo();
Console.WriteLine(shopInfo);

