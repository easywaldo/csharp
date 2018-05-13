class Product
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
}