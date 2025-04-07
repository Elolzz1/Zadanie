// Definicja klasy Product, która reprezentuje produkt w systemie
class Product
{
    // Publiczne pola klasy, które przechowują informacje o produkcie
    public string BarCode; // Kod kreskowy produktu
    public string Name;    // Nazwa produktu
    public double Price;   // Cena produktu
    public float Amount;   // Ilość produktu

    // Konstruktor klasy Product, który inicjalizuje pola klasy
    public Product(string barCode, string name, double price, float amount)
    {
        BarCode = barCode; // Inicjalizacja pola BarCode
        Name = name;       // Inicjalizacja pola Name
        Price = price;     // Inicjalizacja pola Price
        Amount = amount;
    }
}

class Menu
{
    static void Main(string[] args)
    {
        List<Product> storage = new List<Product>();

        while (true)
        {
            Console.WriteLine("Wybierz opcję :");
            Console.WriteLine("1. Dodaj produkt");
            Console.WriteLine("2. Usuń produkt");
            Console.WriteLine("3. Wyświetl produkty");
            Console.WriteLine("4. Aktualizuj Produkt");
            Console.WriteLine("5. Oblicz wartość magazynu");
            Console.WriteLine("6. Zakończ program");

            // Pobranie wyboru użytkownika
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Dodaj produkt
                    Console.WriteLine("Podaj nazwę produktu: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Podaj kod kreskowy produktu: ");
                    string barCode = Console.ReadLine();
                    Console.WriteLine("Podaj cenę produktu: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj ilość produktu: ");
                    float amount = Convert.ToSingle(Console.ReadLine());
                    Product newProduct = new Product(barCode, name, price, amount);
                    storage.Add(newProduct);

                    break;
                case 2:
                    // usuń produkt z magazynu
                    Console.WriteLine("Podaj nazwe produktu do usunięcia: ");
                    string nameToDelete = Console.ReadLine();
                    //przechodzimy przez każdy produkt w magazynie

                    foreach (Product product in storage)
                    {
                        //jeśli nazwa produktu jest równa nazwie produktu do usunięcia
                        if (product.Name == nameToDelete)
                        {
                            //usuwamy produkt z magazynu
                            storage.Remove(product);
                            break;
                        }
                    }
                    break;
                case 3:
                    // Wyświetl produkty
                    foreach (Product product in storage)
                    {
                        Console.WriteLine("Produkt o nazwie: " + product.Name +
                                          " o kodzie kreskowym: " + product.BarCode +
                                          " kosztuje: " + product.Price + "zł");
                    }
                    break;
                case 4:
                    // Aktualizuj Produkt z magazynu
                    Console.WriteLine("Podaj nazwe produktu do aktualizacji: ");
                    string nameToUpdate = Console.ReadLine();
                    //przechodzimy przez każdy produkt w magazynie
                    foreach (Product product in storage)
                    {
                        //jeśli nazwa produktu jest równa nazwie produktu do aktualizacji
                        if (product.Name == nameToUpdate)
                        {
                            //aktualizujemy produkt
                            Console.WriteLine("Podaj nową nazwę produktu: ");
                            product.Name = Console.ReadLine();
                            Console.WriteLine("Podaj nowy kod kreskowy produktu: ");
                            product.BarCode = Console.ReadLine();
                            Console.WriteLine("Podaj nową cenę produktu: ");
                            product.Price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Podaj nową ilość produktu: ");
                            product.Amount = Convert.ToSingle(Console.ReadLine());
                            break;
                        }
                    }

                    break;
                case 5:
                    // Oblicz wartość magazynu
                    double totalValue = 0;
                    //przechodzimy przez każdy produkt w magazynie
                    foreach (Product product in storage)
                    {
                        //dla każdego produktu dodajemy jego cenę * ilość do totalValue
                        totalValue += product.Price * product.Amount;
                    }
                    //wyświetlamy wartość całego magazynu
                    Console.WriteLine("Wartość całego magazynu to: " + totalValue + "zł");
                    break;
                case 6:
                    // Zakończ program
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                    break;
            }
        }
    }
}



