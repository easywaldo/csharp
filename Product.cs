public class Product
{
    public string Name { get; private set; }
    public Product(string name)
    {
        Name = name;
    }
    
    public override string ToString()
    {
        return this.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        var product =  obj as Product;

        if (product == null) return false;

        if (product.Name != this.Name)
        {
            return true;
        }

        return true;
    }
}