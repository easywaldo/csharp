public abstract class Parent
{
    public virtual void Say()
    {
        System.Console.WriteLine("I'm a parent");
    }

    public virtual void Move()
    {
        System.Console.WriteLine("Parent is moving...");
    }
}

public class Child : Parent
{
    new public void Say()
    {
        System.Console.WriteLine("I'm a child");
    }

    public override void Move()
    {       
        System.Console.WriteLine("Child is moving...");
    }
}

public class ParentI
{
    public virtual void Say()
    {
        System.Console.WriteLine("I'm a parentI");
    }

    public virtual void Move()
    {
        System.Console.WriteLine("ParentI is moving...");
    }
}