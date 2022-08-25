public class Product
{
    public Product(
        string Name,
        int Price,
        List<Review> Reviews = new List())
    {
        Name = Name;
        Price = Price;
        Reviews = Reviews;
    }

    public string Name { get; }
    public int Price { get; }
    public List<Review> Review { get; }

}