namespace csharp
{   
    class Man : Someone
    {
        public string name { get; private set; }

        public bool isAlive = true;

        public override void Shout()
        {
            System.Console.WriteLine("man");
        }
    }
}